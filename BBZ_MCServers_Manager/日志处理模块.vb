Imports System
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <StandardModule>
    Friend NotInheritable Class 日志处理模块
        Public Class 日志处理功能
            Private 日志文本框 As RichTextBox

            Public Sub 绑定文本框(要绑定的文本框 As RichTextBox)
                日志文本框 = 要绑定的文本框
            End Sub

            Public Sub 添加日志(消息 As String, 日志类别 As Integer)
                Dim selectionColor = Color.Black
                Dim text = ""
                Select Case 日志类别
                    Case 0
                        text = "[信息💬]"
                        selectionColor = Color.FromArgb(0, 0, 0)
                    Case 1
                        text = "[警告⚠]"
                        selectionColor = Color.FromArgb(255, 128, 0)
                    Case 2
                        text = "[错误❌]"
                        selectionColor = Color.FromArgb(255, 0, 0)
                    Case 3
                        text = "[成功✔]"
                        selectionColor = Color.FromArgb(0, 224, 0)
                    Case 4
                        text = "[调试🛠]"
                        selectionColor = Color.FromArgb(218, 37, 209)
                    Case 5
                        text = "[行为👉]"
                        selectionColor = Color.FromArgb(0, 221, 221)
                    Case 6
                        text = "[配置文件🧾]"
                        selectionColor = Color.FromArgb(43, 92, 230)
                    Case 7
                        text = "================================================="
                        selectionColor = Color.FromArgb(0, 0, 0)
                End Select
                Dim dateTime = Conversions.ToDate(Date.Now.ToString("F"))
                Dim text2 = String.Format("{0}[{1}] {2}{3}", If(是否首次日志, "", Environment.NewLine), dateTime, text, 消息)
                是否首次日志 = False
                ' 异步改造：写文件始终同步执行，不依赖 UI 线程
                写入日志文件(text2)
                ' 维护线程安全的共享最近日志，供后台线程的 RCON 响应检查使用（避免直接读 UI 控件）
                SyncLock GetType(日志处理功能)
                    最近日志.Add(text2)
                    If 最近日志.Count > 30 Then
                        最近日志.RemoveAt(0)
                    End If
                End SyncLock
                ' 控件更新 marshal 到 UI 线程
                If 日志文本框 IsNot Nothing Then
                    If 日志文本框.InvokeRequired Then
                        Try
                            日志文本框.Invoke(Sub() 更新控件显示(text2, selectionColor))
                        Catch
                        End Try
                    Else
                        更新控件显示(text2, selectionColor)
                    End If
                End If
            End Sub

            Private Shared 是否首次日志 As Boolean = True

            Private Shared 最近日志 As New System.Collections.Generic.List(Of String)

            Public Shared Function 获取最近日志文本() As String
                SyncLock GetType(日志处理功能)
                    Return String.Join(Environment.NewLine, 最近日志)
                End SyncLock
            End Function

            Private Sub 更新控件显示(text2 As String, selectionColor As Color)
                Try
                    日志文本框.SelectionStart = 日志文本框.Text.Length
                    日志文本框.SelectionColor = selectionColor
                    日志文本框.AppendText(text2)
                    日志文本框.SelectionColor = 日志文本框.ForeColor
                    If 日志文本框.Lines.Length > 2000 Then
                        截断日志(2000)
                    End If
                    日志文本框.ScrollToCaret()
                Catch
                End Try
            End Sub

            Public Sub 截断日志(最大保留行数 As Integer)
                Dim lineNumber = 日志文本框.Lines.Length - 最大保留行数
                Dim firstCharIndexFromLine = 日志文本框.GetFirstCharIndexFromLine(lineNumber)
                日志文本框.Select(0, firstCharIndexFromLine)
                日志文本框.SelectedText = ""
                日志文本框.SelectionStart = 日志文本框.Text.Length
            End Sub

            Public Shared Sub 写入日志文件(日志 As String)
                Dim path = IO.Path.Combine(配置文件操作模块.日志文件夹, $"日志_{Date.Now:D}.txt")
                Try
                    Directory.CreateDirectory(配置文件操作模块.日志文件夹)
                    File.AppendAllText(path, 日志, Encoding.UTF8)
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    MessageBox.Show($"写入日志失败:{ex2.Message}", "你对日志文件干了什么！", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Call ProjectData.ClearProjectError()
                End Try
            End Sub

            Public Sub 测试日志()
                添加日志("测试日志", 0)
                添加日志("测试日志", 1)
                添加日志("测试日志", 2)
                添加日志("测试日志", 3)
                添加日志("测试日志", 4)
                添加日志("测试日志", 5)
                添加日志("测试日志", 6)
                添加日志("", 7)
            End Sub

            Public Sub 日志输出软件信息()
                添加日志("作者:八宝粥", 0)
                添加日志("联系方式:邮箱:1749861851@qq.com", 0)
                添加日志($"程序启动: [{配置文件操作模块.版本名称}:V0.1.0-alphav3.4] ", 3)
                添加日志("Github仓库链接:https://github.com/babaozhouO/BBZ-MCServers-Manager", 0)
                添加日志("未经作者同意，不得删除软件中的作者标识，本软件受开源协议保护", 1)
                添加日志("正在读取配置文件", 5)
            End Sub

            Public Sub 日志输出主程序配置()
                配置文件操作模块.读取主程序配置()
                添加日志("配置文件读取完成", 3)
                添加日志("配置文件数据:", 6)
                添加日志("", 7)
                添加日志("主程序配置:", 6)
                添加日志($"运行时间: {配置文件操作模块.运行时间}", 6)
                添加日志($"每次运行间隔天数: {配置文件操作模块.间隔天数}", 6)
                添加日志($"关服备份: {配置文件操作模块.是否关服备份}", 6)
                添加日志($"关服等待时长: {配置文件操作模块.等待服务端关闭时长}秒", 6)
                添加日志($"执行耗时操作时的界面帧数: {配置文件操作模块.帧数}", 6)
                添加日志("", 7)
            End Sub

            Public Sub 日志输出MC服务端配置()
                配置文件操作模块.读取MC服务端配置()
                If 配置文件操作模块.是否控制MC服务端1 Then
                    添加日志("", 7)
                    添加日志("MC服务端1配置:", 6)
                    添加日志($"MC服务端1名称:{配置文件操作模块.MC服务端1名称}", 6)
                    添加日志($"MC服务端1地址:{配置文件操作模块.RCON1地址}", 6)
                    添加日志($"MC服务端1RCON端口:{配置文件操作模块.RCON1端口}", 6)
                    添加日志($"MC服务端1路径:{配置文件操作模块.MC服务端1路径}", 6)
                    添加日志($"MC服务端1启动脚本名称:{配置文件操作模块.MC服务端1启动脚本名称}", 6)
                End If
                If 配置文件操作模块.是否控制MC服务端2 Then
                    添加日志("", 7)
                    添加日志("MC服务端2配置:", 6)
                    添加日志($"MC服务端2名称:{配置文件操作模块.MC服务端2名称}", 6)
                    添加日志($"MC服务端2地址:{配置文件操作模块.RCON2地址}", 6)
                    添加日志($"MC服务端2RCON端口:{配置文件操作模块.RCON2端口}", 6)
                    添加日志($"MC服务端2路径:{配置文件操作模块.MC服务端2路径}", 6)
                    添加日志($"MC服务端2启动脚本名称:{配置文件操作模块.MC服务端2启动脚本名称}", 6)
                End If
                If 配置文件操作模块.是否控制MC服务端3 Then
                    添加日志("", 7)
                    添加日志("MC服务端3配置:", 6)
                    添加日志($"MC服务端3名称:{配置文件操作模块.MC服务端3名称}", 6)
                    添加日志($"MC服务端3地址:{配置文件操作模块.RCON3地址}", 6)
                    添加日志($"MC服务端3RCON端口:{配置文件操作模块.RCON3端口}", 6)
                    添加日志($"MC服务端3路径:{配置文件操作模块.MC服务端3路径}", 6)
                    添加日志($"MC服务端3启动脚本名称:{配置文件操作模块.MC服务端3启动脚本名称}", 6)
                End If
                If 配置文件操作模块.是否控制MC服务端4 Then
                    添加日志("", 7)
                    添加日志("MC服务端4配置:", 6)
                    添加日志($"MC服务端4名称:{配置文件操作模块.MC服务端4名称}", 6)
                    添加日志($"MC服务端4地址:{配置文件操作模块.RCON4地址}", 6)
                    添加日志($"MC服务端4RCON端口:{配置文件操作模块.RCON4端口}", 6)
                    添加日志($"MC服务端4路径:{配置文件操作模块.MC服务端4路径}", 6)
                    添加日志($"MC服务端4启动脚本名称:{配置文件操作模块.MC服务端4启动脚本名称}", 6)
                End If
                If 配置文件操作模块.是否控制MC服务端5 Then
                    添加日志("", 7)
                    添加日志("MC服务端5配置:", 6)
                    添加日志($"MC服务端5名称:{配置文件操作模块.MC服务端5名称}", 6)
                    添加日志($"MC服务端5地址:{配置文件操作模块.RCON5地址}", 6)
                    添加日志($"MC服务端5RCON端口:{配置文件操作模块.RCON5端口}", 6)
                    添加日志($"MC服务端5路径:{配置文件操作模块.MC服务端5路径}", 6)
                    添加日志($"MC服务端5启动脚本名称:{配置文件操作模块.MC服务端5启动脚本名称}", 6)
                End If
                If 配置文件操作模块.是否控制MC服务端6 Then
                    添加日志("", 7)
                    添加日志("MC服务端6配置:", 6)
                    添加日志($"MC服务端6名称:{配置文件操作模块.MC服务端6名称}", 6)
                    添加日志($"MC服务端6地址:{配置文件操作模块.RCON6地址}", 6)
                    添加日志($"MC服务端6RCON端口:{配置文件操作模块.RCON6端口}", 6)
                    添加日志($"MC服务端6路径:{配置文件操作模块.MC服务端6路径}", 6)
                    添加日志($"MC服务端6启动脚本名称:{配置文件操作模块.MC服务端6启动脚本名称}", 6)
                End If
                If 配置文件操作模块.是否控制MC服务端7 Then
                    添加日志("", 7)
                    添加日志("MC服务端7配置:", 6)
                    添加日志($"MC服务端7名称:{配置文件操作模块.MC服务端7名称}", 6)
                    添加日志($"MC服务端7地址:{配置文件操作模块.RCON7地址}", 6)
                    添加日志($"MC服务端7RCON端口:{配置文件操作模块.RCON7端口}", 6)
                    添加日志($"MC服务端7路径:{配置文件操作模块.MC服务端7路径}", 6)
                    添加日志($"MC服务端7启动脚本名称:{配置文件操作模块.MC服务端7启动脚本名称}", 6)
                End If
                If 配置文件操作模块.是否控制MC服务端8 Then
                    添加日志("", 7)
                    添加日志("MC服务端8配置:", 6)
                    添加日志($"MC服务端8名称:{配置文件操作模块.MC服务端8名称}", 6)
                    添加日志($"MC服务端8地址:{配置文件操作模块.RCON8地址}", 6)
                    添加日志($"MC服务端8RCON端口:{配置文件操作模块.RCON8端口}", 6)
                    添加日志($"MC服务端8路径:{配置文件操作模块.MC服务端8路径}", 6)
                    添加日志($"MC服务端8启动脚本名称:{配置文件操作模块.MC服务端8启动脚本名称}", 6)
                End If
                If 配置文件操作模块.是否控制MC服务端9 Then
                    添加日志("", 7)
                    添加日志("MC服务端9配置:", 6)
                    添加日志($"MC服务端9名称:{配置文件操作模块.MC服务端9名称}", 6)
                    添加日志($"MC服务端9地址:{配置文件操作模块.RCON9地址}", 6)
                    添加日志($"MC服务端9RCON端口:{配置文件操作模块.RCON9端口}", 6)
                    添加日志($"MC服务端9路径:{配置文件操作模块.MC服务端9路径}", 6)
                    添加日志($"MC服务端9启动脚本名称:{配置文件操作模块.MC服务端9启动脚本名称}", 6)
                End If
                If 配置文件操作模块.是否控制MC服务端10 Then
                    添加日志("", 7)
                    添加日志("MC服务端10配置:", 6)
                    添加日志($"MC服务端10名称:{配置文件操作模块.MC服务端10名称}", 6)
                    添加日志($"MC服务端10地址:{配置文件操作模块.RCON10地址}", 6)
                    添加日志($"MC服务端10RCON端口:{配置文件操作模块.RCON10端口}", 6)
                    添加日志($"MC服务端10路径:{配置文件操作模块.MC服务端10路径}", 6)
                    添加日志($"MC服务端10启动脚本名称:{配置文件操作模块.MC服务端10启动脚本名称}", 6)
                End If
                If Not 配置文件操作模块.是否控制MC服务端1 AndAlso Not 配置文件操作模块.是否控制MC服务端2 AndAlso Not 配置文件操作模块.是否控制MC服务端3 AndAlso Not 配置文件操作模块.是否控制MC服务端4 AndAlso Not 配置文件操作模块.是否控制MC服务端5 AndAlso Not 配置文件操作模块.是否控制MC服务端6 AndAlso Not 配置文件操作模块.是否控制MC服务端7 AndAlso Not 配置文件操作模块.是否控制MC服务端8 AndAlso Not 配置文件操作模块.是否控制MC服务端9 AndAlso Not 配置文件操作模块.是否控制MC服务端10 Then
                    添加日志("", 7)
                    添加日志("MC服务端已全部禁用", 1)
                End If
                添加日志("", 7)
            End Sub

            Public Sub 日志输出7zip配置()
                配置文件操作模块.读取7zip配置()
                添加日志("", 7)
                添加日志("[Info]7zip配置:", 6)
                添加日志($"[Info]压缩格式:{配置文件操作模块.压缩格式}", 6)
                添加日志($"[Info]压缩等级:{配置文件操作模块.压缩级别}", 6)
                添加日志($"[Info]压缩方法:{配置文件操作模块.压缩方法}", 6)
                添加日志($"[Info]使用的CPU线程数:{配置文件操作模块.线程数}", 6)
                添加日志($"[Info]自定义备份目录:{配置文件操作模块.自定义备份目录}", 6)
                添加日志($"[Info]备份输出目录:{配置文件操作模块.备份输出目录}", 6)
                添加日志($"[Info}}是否备份自定义备份目录:{配置文件操作模块.是否备份自定义目录}", 6)
                添加日志($"[Info]增量备份:{配置文件操作模块.是否增量备份}", 6)
            End Sub

            Public Sub 日志输出SFTP配置()
                配置文件操作模块.读取Sftp配置()
                If 配置文件操作模块.Sftp1开关 Then
                    添加日志("", 7)
                    添加日志("SFTP1服务器配置:", 6)
                    添加日志($"SFTP1服务器名称:{配置文件操作模块.Sftp1名称}", 6)
                    添加日志($"SFTP1服务器地址:{配置文件操作模块.Sftp1地址}", 6)
                    添加日志($"SFTP1服务器端口:{配置文件操作模块.Sftp1端口}", 6)
                    添加日志($"SFTP1服务器用户名:{配置文件操作模块.Sftp1用户名}", 6)
                    添加日志($"SFTP1服务器密码:{配置文件操作模块.Sftp1密码}", 6)
                End If
                If 配置文件操作模块.Sftp2开关 Then
                    添加日志("", 7)
                    添加日志("SFTP2服务器配置:", 6)
                    添加日志($"SFTP2服务器名称:{配置文件操作模块.Sftp2名称}", 6)
                    添加日志($"SFTP2服务器地址:{配置文件操作模块.Sftp2地址}", 6)
                    添加日志($"SFTP2服务器端口:{配置文件操作模块.Sftp2端口}", 6)
                    添加日志($"SFTP2服务器用户名:{配置文件操作模块.Sftp2用户名}", 6)
                    添加日志($"SFTP2服务器密码:{配置文件操作模块.Sftp2密码}", 6)
                End If
                If 配置文件操作模块.Sftp3开关 Then
                    添加日志("", 7)
                    添加日志("SFTP3服务器配置:", 6)
                    添加日志($"SFTP3服务器名称:{配置文件操作模块.Sftp3名称}", 6)
                    添加日志($"SFTP3服务器地址:{配置文件操作模块.Sftp3地址}", 6)
                    添加日志($"SFTP3服务器端口:{配置文件操作模块.Sftp3端口}", 6)
                    添加日志($"SFTP3服务器用户名:{配置文件操作模块.Sftp3用户名}", 6)
                    添加日志($"SFTP3服务器密码:{配置文件操作模块.Sftp3密码}", 6)
                End If
                If Not 配置文件操作模块.Sftp1开关 AndAlso Not 配置文件操作模块.Sftp2开关 AndAlso Not 配置文件操作模块.Sftp3开关 Then
                    添加日志("", 7)
                    添加日志("Sftp服务端已全部禁用", 1)
                End If
                添加日志("", 7)
            End Sub
        End Class
    End Class
End Namespace
