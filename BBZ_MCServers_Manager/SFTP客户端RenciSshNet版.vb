Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Timers
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Renci.SshNet
Imports Renci.SshNet.Sftp

Namespace BBZ_MCServers_Manager

    Public Class SFTP客户端RenciSshNet版
        Implements IDisposable
        <CompilerGenerated>
        Friend NotInheritable Class _Closure_0024__14_002D0
            Public _0024VB_0024Local_新进度 As Integer

            Public _0024VB_0024Local_速度 As String

            <SpecialName>
            <DebuggerHidden>
            Friend Sub _Lambda_0024__R2(a0 As Object)
                _Lambda_0024__0()
            End Sub

            <SpecialName>
            Friend Sub _Lambda_0024__0()
                MainForm.更新进度条("分任务", _0024VB_0024Local_新进度)
                MainForm.更新标签("分任务", $"上传文件中(速度:{_0024VB_0024Local_速度})")
            End Sub
        End Class

        <CompilerGenerated>
        Friend NotInheritable Class _Closure_0024__16_002D0
            Public _0024VB_0024Local_i As Integer

            Public Sub New(arg0 As _Closure_0024__16_002D0)
                If arg0 IsNot Nothing Then
                    _0024VB_0024Local_i = arg0._0024VB_0024Local_i
                End If
            End Sub

            <SpecialName>
            <DebuggerHidden>
            Friend Sub _Lambda_0024__R3(a0 As Object)
                _Lambda_0024__0()
            End Sub

            <SpecialName>
            Friend Sub _Lambda_0024__0()
                MainForm.更新进度条("分任务", 30 + _0024VB_0024Local_i / 配置文件操作模块.帧数 * 3)
                MainForm.更新标签("分任务", $"等待重试中... ({_0024VB_0024Local_i / 配置文件操作模块.帧数}/10秒)")
            End Sub
        End Class

        Private 客户端实例 As SftpClient

        Private ReadOnly 服务端序号 As String

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("半秒计算一次速度")>
        Private _半秒计算一次速度 As Timers.Timer

        Private 上次计算时字节数 As Long

        Private 现在的字节数 As Long

        Private 比例系数 As Double

        Private 传输中的文件 As String

        Private ReadOnly UI线程 As SynchronizationContext

        Private Property 半秒计算一次速度 As Timers.Timer
            <CompilerGenerated>
            Get
                Return _半秒计算一次速度
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Timers.Timer)
                Dim value2 As ElapsedEventHandler = Sub(a0, a1) 计算速度()
                Dim timer = _半秒计算一次速度
                If timer IsNot Nothing Then
                    RemoveHandler timer.Elapsed, value2
                End If
                _半秒计算一次速度 = value
                timer = _半秒计算一次速度
                If timer IsNot Nothing Then
                    AddHandler timer.Elapsed, value2
                End If
            End Set
        End Property

        Public Sub New(序号 As Integer)
            半秒计算一次速度 = New Timers.Timer With {
        .AutoReset = True,
        .Interval = 500.0
    }
            上次计算时字节数 = 0L
            现在的字节数 = 0L
            比例系数 = 0.0
            UI线程 = SynchronizationContext.Current
            服务端序号 = Conversions.ToString(序号)
        End Sub

        Public Function 连接状态() As Boolean
            Return 客户端实例.IsConnected
        End Function

        Public Sub 建立Sftp连接(主机地址 As String, 端口号 As Integer, 用户名 As String, 密码 As String)
            MainForm.更新标签("分任务", $"处理Sftp{服务端序号}服务器")
            MainForm.更新进度条("分任务", 0)
            日志窗口.添加日志($"正在尝试连接到Sftp{服务端序号}服务器", 5)
            If 客户端实例 Is Nothing OrElse Not 客户端实例.IsConnected Then
                Dim connectionInfo As PasswordConnectionInfo = New PasswordConnectionInfo(主机地址, 端口号, 用户名, 密码) With {
        .Encoding = Encoding.UTF8
    }
                客户端实例 = New SftpClient(connectionInfo)
                If 配置文件操作模块.是否循环更新界面 Then
                    Dim task = 客户端实例.ConnectAsync(CancellationToken.None)
                    While Not task.IsCompleted
                        Thread.Sleep(配置文件操作模块.延时毫秒数)
                    End While
                Else
                    客户端实例.Connect()
                End If
            Else
                日志窗口.添加日志($"Sftp{服务端序号}服务器已连接，请勿重复连接", 1)
            End If
            If 客户端实例 IsNot Nothing AndAlso 客户端实例.IsConnected Then
                日志窗口.添加日志($"成功连接Sftp{服务端序号}服务器", 3)
                MainForm.更新进度条("分任务", 10)
            Else
                日志窗口.添加日志($"]SFTP{服务端序号}服务器连接失败，请检查网络和凭据或配置文件", 2)
                MainForm.更新标签("分任务", "无")
                MainForm.更新进度条("分任务", 0)
            End If
        End Sub

        Private Sub 计算速度()
            Dim CS_0024_003C_003E8__locals0 As _Closure_0024__14_002D0 = New _Closure_0024__14_002D0()
            现在的字节数 = 客户端实例.Get(传输中的文件).Length
            Dim 字节数 = (现在的字节数 - 上次计算时字节数) * 2
            CS_0024_003C_003E8__locals0._0024VB_0024Local_速度 = 转换字节长度(字节数)
            CS_0024_003C_003E8__locals0._0024VB_0024Local_新进度 = 30 + CInt(Math.Round(现在的字节数 * 比例系数))
            UI线程.Post(Sub(a0) CS_0024_003C_003E8__locals0._Lambda_0024__0(), Nothing)
            上次计算时字节数 = 现在的字节数
        End Sub

        Private Function 转换字节长度(字节数 As Long) As String
            Dim array = New String(3) {"B", "KB", "MB", "GB"}
            Dim num = 0
            While 字节数 >= 1024 AndAlso num < array.Length - 1
                字节数 = CLng(Math.Round(字节数 / 1024.0))
                num += 1
            End While
            Return $"{字节数:F2} {array(num)}"
        End Function

        Public Sub 上传文件(本地文件路径 As String, 远程文件目录 As String)
            If 客户端实例 Is Nothing OrElse Not 客户端实例.IsConnected Then
                日志窗口.添加日志($"Sftp{服务端序号}客户端未连接", 2)
                Return
            End If
            If Operators.CompareString(本地文件路径, "", TextCompare:=False) = 0 Then
                日志窗口.添加日志($"Sftp{服务端序号}客户端发现未选择文件", 2)
                Return
            End If
            If Not File.Exists(本地文件路径) Then
                日志窗口.添加日志($"Sftp{服务端序号}客户端发现本地文件不存在", 2)
                Return
            End If
            Dim text As String
            If Not 远程文件目录.StartsWith(配置文件操作模块.正斜杠) AndAlso Not 远程文件目录.StartsWith(配置文件操作模块.反斜杠) Then
                text = $"/{远程文件目录}"
            ElseIf Not 远程文件目录.StartsWith(配置文件操作模块.正斜杠) AndAlso 远程文件目录.StartsWith(配置文件操作模块.反斜杠) Then
                text = 远程文件目录.Replace(配置文件操作模块.反斜杠, 配置文件操作模块.正斜杠)
            Else
                远程文件目录.StartsWith(配置文件操作模块.正斜杠)
                text = 远程文件目录
            End If
            text = text.Replace(配置文件操作模块.反斜杠, 配置文件操作模块.正斜杠).TrimEnd(配置文件操作模块.正斜杠)
            If Operators.CompareString(text, "", TextCompare:=False) = 0 Then
                text = "/"
            End If
            If 客户端实例.Exists(text) Then
                日志窗口.添加日志($"Sftp{服务端序号}客户端确认远程目录存在", 3)
            Else
                Dim array = text.Trim(配置文件操作模块.正斜杠).Split(配置文件操作模块.正斜杠, StringSplitOptions.RemoveEmptyEntries)
                Dim text2 = "/"
                Dim array2 = array
                For Each text3 In array2
                    Dim text4 = $"{text2.TrimEnd("/"c)}/{text3}"
                    Try
                        If Not 客户端实例.Exists(text4) Then
                            客户端实例.ChangeDirectory(text2)
                            客户端实例.CreateDirectory(text3)
                            If Not 客户端实例.Exists(text4) Then
                                日志窗口.添加日志($"目录创建失败：{text4}", 2)
                                Return
                            End If
                        End If
                        text2 = text4
                    Catch ex As Exception
                        ProjectData.SetProjectError(ex)
                        Dim ex2 = ex
                        日志窗口.添加日志($"创建目录失败：{text4}，错误：{ex2.Message}", 2)
                        Call ProjectData.ClearProjectError()
                        Return
                    End Try
                Next
            End If
            MainForm.更新进度条("分任务", 30)
            日志窗口.添加日志($"Sftp{服务端序号}客户端正在上传文件", 5)
            Dim fileInfo As FileInfo = New FileInfo(本地文件路径)
            Dim name = fileInfo.Name
            Dim text5 = If(text.EndsWith("/"c), $"{text}{name}", $"{text}/{name}")
            Dim text6 = $"{text5}.文件块"
            Dim num As Long
            If 客户端实例.Exists(text5) Then
                日志窗口.添加日志($"Sftp{服务端序号}客户端发现远程文件已存在", 0)
                If MsgBox($"Sftp{服务端序号}客户端发现[{text5}]已存在，是否覆盖？", MsgBoxStyle.YesNo, "提示") <> MsgBoxResult.Yes Then
                    日志窗口.添加日志($"Sftp{服务端序号}客户端:用户选择不覆盖远程文件", 5)
                    日志窗口.添加日志($"Sftp{服务端序号}客户端:已取消上传文件操作", 3)
                    MainForm.更新进度条("分任务", 10)
                    Return
                End If
                日志窗口.添加日志($"Sftp{服务端序号}客户端:用户选择覆盖远程文件", 5)
                客户端实例.DeleteFile(text5)
                If 客户端实例.Exists(text5) Then
                    日志窗口.添加日志($"Sftp{服务端序号}客户端:远程文件删除失败", 2)
                    日志窗口.添加日志($"Sftp{服务端序号}客户端:已取消上传文件操作", 3)
                    MainForm.更新进度条("分任务", 10)
                    Return
                End If
                日志窗口.添加日志($"Sftp{服务端序号}客户端:远程文件删除成功", 3)
                日志窗口.添加日志($"Sftp{服务端序号}客户端:将上传文件", 5)
                num = 0L
            ElseIf 客户端实例.Exists(text6) Then
                日志窗口.添加日志($"Sftp{服务端序号}客户端发现存在未传输完成的文件", 0)
                If MsgBox($"Sftp{服务端序号}客户端发现[{text6}]存在，是否续传？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    日志窗口.添加日志($"Sftp{服务端序号}客户端:用户选择续传远程文件", 5)
                    日志窗口.添加日志($"Sftp{服务端序号}客户端正在读取远程文件块信息", 5)
                    num = 客户端实例.Get(text6).Length
                    日志窗口.添加日志($"Sftp{服务端序号}客户端成功获取到上次传输进度", 3)
                    日志窗口.添加日志($"Sftp{服务端序号}客户端:将上传文件", 5)
                Else
                    日志窗口.添加日志($"Sftp{服务端序号}客户端:用户选择不续传远程文件", 5)
                    If MsgBox($"是否删除[{text6}]并重新上传？", MsgBoxStyle.YesNo, "提示") <> MsgBoxResult.Yes Then
                        日志窗口.添加日志($"Sftp{服务端序号}客户端:用户选择不删除未完成的远程文件", 5)
                        日志窗口.添加日志($"Sftp{服务端序号}客户端:已取消上传文件操作", 3)
                        MainForm.更新进度条("分任务", 10)
                        Return
                    End If
                    日志窗口.添加日志($"Sftp{服务端序号}客户端:用户选择删除未完成的远程文件", 5)
                    客户端实例.DeleteFile(text6)
                    If 客户端实例.Exists(text6) Then
                        日志窗口.添加日志($"Sftp{服务端序号}客户端:远程文件删除失败", 2)
                        日志窗口.添加日志($"Sftp{服务端序号}客户端:已取消上传文件操作", 3)
                        MainForm.更新进度条("分任务", 10)
                        Return
                    End If
                    日志窗口.添加日志($"Sftp{服务端序号}客户端:远程文件删除成功", 3)
                    日志窗口.添加日志($"Sftp{服务端序号}客户端:将上传文件", 5)
                    num = 0L
                End If
            Else
                日志窗口.添加日志($"Sftp{服务端序号}客户端发现无已存在的同名文件或同名文件的片段(.文件块),将上传文件", 0)
                num = 0L
            End If
            Dim length = fileInfo.Length
            比例系数 = 65.0 / length
            传输中的文件 = text6
            半秒计算一次速度.Start()
            Dim num2 = 0
            Dim num3 = 10
            Dim num4 = 10
            Dim closure_0024__16_002D As _Closure_0024__16_002D0 = Nothing
            While num2 <= num3
                Try
                    Dim fileStream As FileStream = New FileStream(本地文件路径, FileMode.Open, FileAccess.Read)
                    Dim sftpFileStream = 客户端实例.OpenWrite(text6)
                    Dim array3 = New Byte(1048576 * 配置文件操作模块.读取缓冲区大小 - 1 + 1 - 1) {}
                    半秒计算一次速度.Start()
                    While num < length
                        If Not 客户端实例.IsConnected Then
                            日志窗口.添加日志($"连接中断，尝试重新连接（重试{num2}）", 2)
                            If 配置文件操作模块.是否循环更新界面 Then
                                Dim task = 客户端实例.ConnectAsync(CancellationToken.None)
                                While Not task.IsCompleted
                                    Thread.Sleep(配置文件操作模块.延时毫秒数)
                                End While
                            Else
                                客户端实例.Connect()
                            End If
                        End If
                        fileStream.Position = num
                        sftpFileStream.Position = num
                        Dim num5 As Long = fileStream.Read(array3, 0, array3.Length - 1)
                        Dim task2 = sftpFileStream.WriteAsync(array3, 0, num5)
                        While Not task2.IsCompleted
                            Thread.Sleep(配置文件操作模块.延时毫秒数)
                        End While
                        num = 客户端实例.Get(text6).Length
                    End While
                    sftpFileStream.Flush()
                    sftpFileStream.Close()
                    半秒计算一次速度.Stop()
                    Dim num6 = 500.0 / 配置文件操作模块.延时毫秒数
                    Dim num7 = num6
                    Dim num8 = 1.0

                    While num8 <= num7
                        Thread.Sleep(配置文件操作模块.延时毫秒数)
                        num8 += 1.0
                    End While
                Catch ex3 As Exception
                    ProjectData.SetProjectError(ex3)
                    Dim ex4 = ex3
                    num2 += 1
                    If num2 > num3 Then
                        日志窗口.添加日志($"上传失败已达最大重试次数{num3}次", 2)
                        Call ProjectData.ClearProjectError()
                        Exit While
                    End If
                    日志窗口.添加日志($"上传失败（第{num2}次重试）：{ex4.Message}", 2)
                    Dim num9 = 10 * 配置文件操作模块.帧数
                    closure_0024__16_002D = New _Closure_0024__16_002D0(closure_0024__16_002D)
                    Dim closure_0024__16_002D2 = closure_0024__16_002D
                    Dim num10 = num9
                    closure_0024__16_002D2._0024VB_0024Local_i = 1
                    While closure_0024__16_002D._0024VB_0024Local_i <= num10
                        Thread.Sleep(配置文件操作模块.延时毫秒数)
                        UI线程.Post(New SendOrPostCallback(AddressOf closure_0024__16_002D._Lambda_0024__R3), Nothing)
                        closure_0024__16_002D._0024VB_0024Local_i += 1
                    End While
                    If Not 客户端实例.IsConnected Then
                        Try
                            If 配置文件操作模块.是否循环更新界面 Then
                                Dim task3 = 客户端实例.ConnectAsync(CancellationToken.None)
                                While Not task3.IsCompleted
                                    Thread.Sleep(配置文件操作模块.延时毫秒数)
                                End While
                            Else
                                客户端实例.Connect()
                            End If
                            If 客户端实例.IsConnected Then
                                日志窗口.添加日志("重连服务器成功", 3)
                            Else
                                日志窗口.添加日志("重连失败", 2)
                            End If
                        Catch ex5 As Exception
                            ProjectData.SetProjectError(ex5)
                            Dim ex6 = ex5
                            日志窗口.添加日志($"重连失败：{ex6.Message}", 2)
                            Call ProjectData.ClearProjectError()
                        End Try
                    End If
                    Call ProjectData.ClearProjectError()
                    Continue While
                End Try
                Exit While
            End While
            If num2 <= num3 Then
                客户端实例.RenameFile(text6, text5)
                日志窗口.添加日志($"Sftp{服务端序号}客户端文件上传成功", 3)
                MainForm.更新进度条("分任务", 100)
            Else
                日志窗口.添加日志("文件上传最终失败", 2)
            End If
            ' 异步改造：SFTP 处理完成后分任务进度条归零、标签恢复
            MainForm.更新进度条("分任务", 0)
            MainForm.更新标签("分任务", "无")
        End Sub

        Public Function 检测远程文件是否存在(远程文件路径 As String) As Object
            Dim result As Object
            If 客户端实例 Is Nothing OrElse Not 客户端实例.IsConnected Then
                日志窗口.添加日志($"Sftp{服务端序号}客户端未连接", 2)
                result = False
            Else
                MainForm.更新进度条("分任务", 30)
                Try
                    If 客户端实例.Exists(远程文件路径) Then
                        日志窗口.添加日志($"Sftp{服务端序号}客户端发现远程文件存在", 3)
                        result = True
                    Else
                        日志窗口.添加日志($"Sftp{服务端序号}客户端发现远程文件不存在", 2)
                        result = False
                    End If
                Catch projectError As Exception
                    ProjectData.SetProjectError(projectError)
                    日志窗口.添加日志($"Sftp{服务端序号}客户端检测远程文件失败", 2)
                    result = False
                    Call ProjectData.ClearProjectError()
                End Try
            End If
            Return result
        End Function

        Public Sub 删除文件(远程文件路径 As String)
            If 客户端实例 Is Nothing OrElse Not 客户端实例.IsConnected Then
                日志窗口.添加日志($"Sftp{服务端序号}客户端未连接", 2)
                Return
            End If
            MainForm.更新进度条("分任务", 50)
            Try
                客户端实例.DeleteFile(远程文件路径)
                日志窗口.添加日志($"Sftp{服务端序号}客户端成功删除远程文件", 3)
            Catch projectError As Exception
                ProjectData.SetProjectError(projectError)
                日志窗口.添加日志($"Sftp{服务端序号}客户端删除远程文件失败", 2)
                Call ProjectData.ClearProjectError()
            Finally
                MainForm.更新进度条("分任务", 100)
                ' 异步改造：删除完成后分任务进度条归零、标签恢复
                MainForm.更新进度条("分任务", 0)
                MainForm.更新标签("分任务", "无")
            End Try
        End Sub

        Public Sub 断开连接()
            If 客户端实例 IsNot Nothing AndAlso 客户端实例.IsConnected Then
                客户端实例.Disconnect()
                MainForm.更新进度条("分任务", 0)
                MainForm.更新标签("分任务", "无")
            End If
        End Sub

        Public Sub Dispose()
            If 连接状态() Then
                断开连接()
                客户端实例?.Dispose()
                GC.Collect()
                GC.WaitForPendingFinalizers()
                GC.SuppressFinalize(Me)
                日志窗口.添加日志($"Sftp{服务端序号}服务器连接已断开并释放", 3)
                日志窗口.添加日志("已回收读取缓冲区占用的内存", 3)
            End If
        End Sub

        Private Sub Dispose1() Implements IDisposable.Dispose
            'ILSpy generated this explicit interface implementation from .override directive in Dispose
            Dispose()
        End Sub
    End Class
End Namespace
