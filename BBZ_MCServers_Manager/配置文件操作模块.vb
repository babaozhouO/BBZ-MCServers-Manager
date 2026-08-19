Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <StandardModule>
    Friend NotInheritable Class 配置文件操作模块
        Public Class Ini文件
            Private ReadOnly 文件路径 As String

            Private ReadOnly 节区字典 As Dictionary(Of String, Dictionary(Of String, String))

            Public Sub New(路径 As String)
                节区字典 = New Dictionary(Of String, Dictionary(Of String, String))()
                文件路径 = 路径
                If File.Exists(文件路径) Then
                    加载()
                End If
            End Sub

            Private Sub 加载()
                Dim key = ""
                Dim array = File.ReadAllLines(文件路径, Encoding.UTF8)
                For Each 文本项 In array
                    Dim text2 As String = 文本项.Trim()
                    If text2.StartsWith("["c) AndAlso text2.EndsWith("]"c) Then
                        key = text2.Substring(1, text2.Length - 2)
                        节区字典(key) = New Dictionary(Of String, String)()
                    ElseIf Not String.IsNullOrEmpty(text2) AndAlso Not text2.StartsWith(";"c) Then
                        Dim array2 = text2.Split("="c, 2)
                        If array2.Length = 2 Then
                            节区字典(key)(array2(0).Trim()) = array2(1).Trim()
                        End If
                    End If
                Next
            End Sub

            Public Sub 保存()
                Dim streamWriter As StreamWriter = New StreamWriter(文件路径)
                Try
                    For Each item In 节区字典
                        streamWriter.WriteLine($"[{item.Key}]", Encoding.UTF8)
                        For Each item2 In item.Value
                            streamWriter.WriteLine($"{item2.Key}={item2.Value}", Encoding.UTF8)
                        Next
                        streamWriter.WriteLine()
                    Next
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim arg = ex
                    日志窗口.添加日志($"配置文件写入失败：{arg}", 2)
                    Call ProjectData.ClearProjectError()
                End Try
            End Sub

            Public Function 获取值(节区 As String, 键 As String, Optional 默认值 As String = "") As String
                Dim value As Dictionary(Of String, String) = Nothing
                If 节区字典.TryGetValue(节区, value) AndAlso value.ContainsKey(键) Then
                    If String.IsNullOrEmpty(节区字典(节区)(键)) Then
                        Return 默认值
                    End If
                    Return 节区字典(节区)(键)
                End If
                Return 默认值
            End Function

            Public Function 设置值(节区 As String, 键 As String, 值 As String) As Ini文件
                Dim value As Dictionary(Of String, String) = Nothing
                If Not 节区字典.TryGetValue(节区, value) Then
                    value = New Dictionary(Of String, String)()
                    节区字典(节区) = value
                End If
                value(键) = 值
                Return Me
            End Function
        End Class

        Public Shared ReadOnly 正斜杠 As Char = "/"c

        Public Shared ReadOnly 反斜杠 As Char = "\"c

        Public Shared Property 程序数据目录 As String

        Public Shared Property MSI版本目录 As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "八宝粥的单人团队", "八宝粥的多MC服务端管理面板")


        Public Shared Property 散文件版本目录 As String = Application.StartupPath


        Public Shared Property 图片目录 As String

        Public Shared Property 程序路径 As String

        Public Shared Property 日志文件夹 As String

        Public Shared Property 配置文件目录 As String

        Public Shared Property 程序版本 As Boolean

        Public Shared Property 版本名称 As String

        Public Shared Property 运行时间 As String

        Public Shared Property 间隔天数 As String

        Public Shared Property 运行模式 As Boolean

        Public Shared Property 是否关服备份 As Boolean

        Public Shared Property 等待服务端关闭时长 As Integer

        Public Shared Property 日志窗口隐藏状态 As Boolean = False


        Public Shared Property 备份模式 As Boolean

        Public Shared Property 帧数 As Integer

        Public Shared Property 延时毫秒数 As Integer

        Public Shared Property 是否循环更新界面 As Boolean

        Public Shared Property 服务运行状态 As Boolean

        Public Shared Property 备份操作进行状态 As Boolean

        Public Shared Property 日志窗口位置更新频率 As Integer

        Public Shared Property 日志窗口是否更新位置 As Boolean

        Public Shared Property 是否控制MC服务端1 As Boolean

        Public Shared Property MC服务端1名称 As String

        Public Shared Property RCON1地址 As String

        Public Shared Property RCON1端口 As String

        Public Shared Property RCON1密码 As String

        Public Shared Property MC服务端1路径 As String

        Public Shared Property MC服务端1启动脚本名称 As String

        Public Shared Property 备份MC服务端1排除文件参数 As String

        Public Shared Property 是否控制MC服务端2 As Boolean

        Public Shared Property MC服务端2名称 As String

        Public Shared Property RCON2地址 As String

        Public Shared Property RCON2端口 As String

        Public Shared Property RCON2密码 As String

        Public Shared Property MC服务端2路径 As String

        Public Shared Property MC服务端2启动脚本名称 As String

        Public Shared Property 备份MC服务端2排除文件参数 As String

        Public Shared Property 是否控制MC服务端3 As Boolean

        Public Shared Property MC服务端3名称 As String

        Public Shared Property RCON3地址 As String

        Public Shared Property RCON3端口 As String

        Public Shared Property RCON3密码 As String

        Public Shared Property MC服务端3路径 As String

        Public Shared Property MC服务端3启动脚本名称 As String

        Public Shared Property 备份MC服务端3排除文件参数 As String

        Public Shared Property 是否控制MC服务端4 As Boolean

        Public Shared Property MC服务端4名称 As String

        Public Shared Property RCON4地址 As String

        Public Shared Property RCON4端口 As String

        Public Shared Property RCON4密码 As String

        Public Shared Property MC服务端4路径 As String

        Public Shared Property MC服务端4启动脚本名称 As String

        Public Shared Property 备份MC服务端4排除文件参数 As String

        Public Shared Property 是否控制MC服务端5 As Boolean

        Public Shared Property MC服务端5名称 As String

        Public Shared Property RCON5地址 As String

        Public Shared Property RCON5端口 As String

        Public Shared Property RCON5密码 As String

        Public Shared Property MC服务端5路径 As String

        Public Shared Property MC服务端5启动脚本名称 As String

        Public Shared Property 备份MC服务端5排除文件参数 As String

        Public Shared Property 是否控制MC服务端6 As Boolean

        Public Shared Property MC服务端6名称 As String

        Public Shared Property RCON6地址 As String

        Public Shared Property RCON6端口 As String

        Public Shared Property RCON6密码 As String

        Public Shared Property MC服务端6路径 As String

        Public Shared Property MC服务端6启动脚本名称 As String

        Public Shared Property 备份MC服务端6排除文件参数 As String

        Public Shared Property 是否控制MC服务端7 As Boolean

        Public Shared Property MC服务端7名称 As String

        Public Shared Property RCON7地址 As String

        Public Shared Property RCON7端口 As String

        Public Shared Property RCON7密码 As String

        Public Shared Property MC服务端7路径 As String

        Public Shared Property MC服务端7启动脚本名称 As String

        Public Shared Property 备份MC服务端7排除文件参数 As String

        Public Shared Property 是否控制MC服务端8 As Boolean

        Public Shared Property MC服务端8名称 As String

        Public Shared Property RCON8地址 As String

        Public Shared Property RCON8端口 As String

        Public Shared Property RCON8密码 As String

        Public Shared Property MC服务端8路径 As String

        Public Shared Property MC服务端8启动脚本名称 As String

        Public Shared Property 备份MC服务端8排除文件参数 As String

        Public Shared Property 是否控制MC服务端9 As Boolean

        Public Shared Property MC服务端9名称 As String

        Public Shared Property RCON9地址 As String

        Public Shared Property RCON9端口 As String

        Public Shared Property RCON9密码 As String

        Public Shared Property MC服务端9路径 As String

        Public Shared Property MC服务端9启动脚本名称 As String

        Public Shared Property 备份MC服务端9排除文件参数 As String

        Public Shared Property 是否控制MC服务端10 As Boolean

        Public Shared Property MC服务端10名称 As String

        Public Shared Property RCON10地址 As String

        Public Shared Property RCON10端口 As String

        Public Shared Property RCON10密码 As String

        Public Shared Property MC服务端10路径 As String

        Public Shared Property MC服务端10启动脚本名称 As String

        Public Shared Property 备份MC服务端10排除文件参数 As String

        Public Shared Property 压缩格式 As String

        Public Shared Property 压缩级别 As Integer

        Public Shared Property 压缩方法 As String

        Public Shared Property 字典大小 As String

        Public Shared Property 单词大小 As String

        Public Shared Property 线程数 As String

        Public Shared Property 超时时长 As Integer

        Public Shared Property 备份输出目录 As String

        Public Shared Property 自定义备份目录 As String

        Public Shared Property 是否增量备份 As Boolean

        Public Shared Property 是否备份自定义目录 As Boolean

        Public Shared Property 自定义备份目录排除文件参数 As String

        Public Shared Property 读取缓冲区大小 As Integer = 15


        Public Shared Property Sftp1开关 As Boolean

        Public Shared Property Sftp1名称 As String

        Public Shared Property Sftp1地址 As String

        Public Shared Property Sftp1端口 As String

        Public Shared Property Sftp1用户名 As String

        Public Shared Property Sftp1密码 As String

        Public Shared Property Sftp1已保存密钥指纹 As String

        Public Shared Property Sftp2开关 As Boolean

        Public Shared Property Sftp2名称 As String

        Public Shared Property Sftp2地址 As String

        Public Shared Property Sftp2端口 As String

        Public Shared Property Sftp2用户名 As String

        Public Shared Property Sftp2密码 As String

        Public Shared Property Sftp2已保存密钥指纹 As String

        Public Shared Property Sftp3开关 As Boolean

        Public Shared Property Sftp3名称 As String

        Public Shared Property Sftp3地址 As String

        Public Shared Property Sftp3端口 As String

        Public Shared Property Sftp3用户名 As String

        Public Shared Property Sftp3密码 As String

        Public Shared Property Sftp3已保存密钥指纹 As String

        Public Shared Sub 读取主程序配置()
            Dim ini文件 As Ini文件 = New Ini文件(Path.Combine(程序数据目录, "配置文件", "MainConfig.ini"))
            间隔天数 = ini文件.获取值("MainSettings", "Days", "1")
            运行时间 = ini文件.获取值("MainSettings", "Runtime", "03:00:00")
            是否关服备份 = Conversions.ToBoolean(ini文件.获取值("MainSettings", "StopMCServer", "True"))
            等待服务端关闭时长 = Conversions.ToInteger(ini文件.获取值("MainSettings", "WaitingSeconds", "60"))
            运行模式 = Conversions.ToBoolean(ini文件.获取值("MainSettings", "RunMode", "True"))
            帧数 = Conversions.ToInteger(ini文件.获取值("MainSettings", "FPS", "25"))
            日志窗口位置更新频率 = Conversions.ToInteger(ini文件.获取值("MainSettings", "LogWindowUpdateFrequency", "100"))
            备份模式 = Conversions.ToBoolean(ini文件.获取值("MainSettings", "BackupMode", "False"))
            读取缓冲区大小 = Conversions.ToInteger(ini文件.获取值("MainSettings", "BufferSizes", "15"))
            Call 转换帧数为延时毫秒数()
            Call 转换更新频率为延时毫秒数()
        End Sub

        Public Shared Sub 转换帧数为延时毫秒数()
            If 帧数 = 0 Then
                是否循环更新界面 = False
                Return
            End If
            If 帧数 > 1000 Then
                帧数 = 1000
            End If
            延时毫秒数 = 1000 / 帧数
            是否循环更新界面 = True
        End Sub

        Public Shared Sub 转换更新频率为延时毫秒数()
            If 日志窗口位置更新频率 = 0 Then
                日志窗口是否更新位置 = False
                日志窗口.位置同步Timer.Interval = 1000
                Return
            End If
            If 日志窗口位置更新频率 > 1000 Then
                日志窗口位置更新频率 = 1000
            End If
            Dim interval As Integer = 1000 / 日志窗口位置更新频率
            日志窗口是否更新位置 = True
            日志窗口.位置同步Timer.Interval = interval
        End Sub

        Public Shared Sub 读取MC服务端配置()
            Dim ini文件 As Ini文件 = New Ini文件(Path.Combine(程序数据目录, "配置文件", "MCServerConfig.ini"))
            是否控制MC服务端1 = Conversions.ToBoolean(ini文件.获取值("MCServer1Config", "Enable", "False"))
            MC服务端1名称 = ini文件.获取值("MCServer1Config", "Name", "MC服务器1")
            RCON1地址 = ini文件.获取值("MCServer1Config", "RCONIP", "25575")
            RCON1端口 = ini文件.获取值("MCServer1Config", "RCONPort", "127.0.0.1")
            RCON1密码 = ini文件.获取值("MCServer1Config", "RCONPassword")
            MC服务端1路径 = ini文件.获取值("MCServer1Config", "ServerPath")
            MC服务端1启动脚本名称 = ini文件.获取值("MCServer1Config", "StartBatPath")
            备份MC服务端1排除文件参数 = ini文件.获取值("MCServer1Config", "BackupServerExcludedFile")
            是否控制MC服务端2 = Conversions.ToBoolean(ini文件.获取值("MCServer2Config", "Enable", "False"))
            MC服务端2名称 = ini文件.获取值("MCServer2Config", "Name", "MC服务器2")
            RCON2地址 = ini文件.获取值("MCServer2Config", "RCONIP", "25576")
            RCON2端口 = ini文件.获取值("MCServer2Config", "RCONPort", "127.0.0.1")
            RCON2密码 = ini文件.获取值("MCServer2Config", "RCONPassword")
            MC服务端2路径 = ini文件.获取值("MCServer2Config", "ServerPath")
            MC服务端2启动脚本名称 = ini文件.获取值("MCServer2Config", "StartBatPath")
            备份MC服务端2排除文件参数 = ini文件.获取值("MCServer2Config", "BackupServerExcludedFile")
            是否控制MC服务端3 = Conversions.ToBoolean(ini文件.获取值("MCServer3Config", "Enable", "False"))
            MC服务端3名称 = ini文件.获取值("MCServer3Config", "Name", "MC服务器3")
            RCON3地址 = ini文件.获取值("MCServer3Config", "RCONIP", "25577")
            RCON3端口 = ini文件.获取值("MCServer3Config", "RCONPort", "127.0.0.1")
            RCON3密码 = ini文件.获取值("MCServer3Config", "RCONPassword")
            MC服务端3路径 = ini文件.获取值("MCServer3Config", "ServerPath")
            MC服务端3启动脚本名称 = ini文件.获取值("MCServer3Config", "StartBatPath")
            备份MC服务端3排除文件参数 = ini文件.获取值("MCServer3Config", "BackupServerExcludedFile")
            是否控制MC服务端4 = Conversions.ToBoolean(ini文件.获取值("MCServer4Config", "Enable", "False"))
            MC服务端4名称 = ini文件.获取值("MCServer4Config", "Name", "MC服务器4")
            RCON4地址 = ini文件.获取值("MCServer4Config", "RCONIP", "25578")
            RCON4端口 = ini文件.获取值("MCServer4Config", "RCONPort", "127.0.0.1")
            RCON4密码 = ini文件.获取值("MCServer4Config", "RCONPassword")
            MC服务端4路径 = ini文件.获取值("MCServer4Config", "ServerPath")
            MC服务端4启动脚本名称 = ini文件.获取值("MCServer4Config", "StartBatPath")
            备份MC服务端4排除文件参数 = ini文件.获取值("MCServer4Config", "BackupServerExcludedFile")
            是否控制MC服务端5 = Conversions.ToBoolean(ini文件.获取值("MCServer5Config", "Enable", "False"))
            MC服务端5名称 = ini文件.获取值("MCServer5Config", "Name", "MC服务器5")
            RCON5地址 = ini文件.获取值("MCServer5Config", "RCONIP", "25579")
            RCON5端口 = ini文件.获取值("MCServer5Config", "RCONPort", "127.0.0.1")
            RCON5密码 = ini文件.获取值("MCServer5Config", "RCONPassword")
            MC服务端5路径 = ini文件.获取值("MCServer5Config", "ServerPath")
            MC服务端5启动脚本名称 = ini文件.获取值("MCServer5Config", "StartBatPath")
            备份MC服务端5排除文件参数 = ini文件.获取值("MCServer5Config", "BackupServerExcludedFile")
            是否控制MC服务端6 = Conversions.ToBoolean(ini文件.获取值("MCServer6Config", "Enable", "False"))
            MC服务端6名称 = ini文件.获取值("MCServer6Config", "Name", "MC服务器6")
            RCON6地址 = ini文件.获取值("MCServer6Config", "RCONIP", "25580")
            RCON6端口 = ini文件.获取值("MCServer6Config", "RCONPort", "127.0.0.1")
            RCON6密码 = ini文件.获取值("MCServer6Config", "RCONPassword")
            MC服务端6路径 = ini文件.获取值("MCServer6Config", "ServerPath")
            MC服务端6启动脚本名称 = ini文件.获取值("MCServer6Config", "StartBatPath")
            备份MC服务端6排除文件参数 = ini文件.获取值("MCServer6Config", "BackupServerExcludedFile")
            是否控制MC服务端7 = Conversions.ToBoolean(ini文件.获取值("MCServer7Config", "Enable", "False"))
            MC服务端7名称 = ini文件.获取值("MCServer7Config", "Name", "MC服务器7")
            RCON7地址 = ini文件.获取值("MCServer7Config", "RCONIP", "25581")
            RCON7端口 = ini文件.获取值("MCServer7Config", "RCONPort", "127.0.0.1")
            RCON7密码 = ini文件.获取值("MCServer7Config", "RCONPassword")
            MC服务端7路径 = ini文件.获取值("MCServer7Config", "ServerPath")
            MC服务端7启动脚本名称 = ini文件.获取值("MCServer7Config", "StartBatPath")
            备份MC服务端7排除文件参数 = ini文件.获取值("MCServer7Config", "BackupServerExcludedFile")
            是否控制MC服务端8 = Conversions.ToBoolean(ini文件.获取值("MCServer8Config", "Enable", "False"))
            MC服务端8名称 = ini文件.获取值("MCServer8Config", "Name", "MC服务器8")
            RCON8地址 = ini文件.获取值("MCServer8Config", "RCONIP", "25582")
            RCON8端口 = ini文件.获取值("MCServer8Config", "RCONPort", "127.0.0.1")
            RCON8密码 = ini文件.获取值("MCServer8Config", "RCONPassword")
            MC服务端8路径 = ini文件.获取值("MCServer8Config", "ServerPath")
            MC服务端8启动脚本名称 = ini文件.获取值("MCServer8Config", "StartBatPath")
            备份MC服务端8排除文件参数 = ini文件.获取值("MCServer8Config", "BackupServerExcludedFile")
            是否控制MC服务端9 = Conversions.ToBoolean(ini文件.获取值("MCServer9Config", "Enable", "False"))
            MC服务端9名称 = ini文件.获取值("MCServer9Config", "Name", "MC服务器9")
            RCON9地址 = ini文件.获取值("MCServer9Config", "RCONIP", "25583")
            RCON9端口 = ini文件.获取值("MCServer9Config", "RCONPort", "127.0.0.1")
            RCON9密码 = ini文件.获取值("MCServer9Config", "RCONPassword")
            MC服务端9路径 = ini文件.获取值("MCServer9Config", "ServerPath")
            MC服务端9启动脚本名称 = ini文件.获取值("MCServer9Config", "StartBatPath")
            备份MC服务端9排除文件参数 = ini文件.获取值("MCServer9Config", "BackupServerExcludedFile")
            是否控制MC服务端10 = Conversions.ToBoolean(ini文件.获取值("MCServer10Config", "Enable", "False"))
            MC服务端10名称 = ini文件.获取值("MCServer10Config", "Name", "MC服务器10")
            RCON10地址 = ini文件.获取值("MCServer10Config", "RCONIP", "25584")
            RCON10端口 = ini文件.获取值("MCServer10Config", "RCONPort", "127.0.0.1")
            RCON10密码 = ini文件.获取值("MCServer10Config", "RCONPassword")
            MC服务端10路径 = ini文件.获取值("MCServer10Config", "ServerPath")
            MC服务端10启动脚本名称 = ini文件.获取值("MCServer10Config", "StartBatPath")
            备份MC服务端10排除文件参数 = ini文件.获取值("MCServer10Config", "BackupServerExcludedFile")
        End Sub

        Public Shared Sub 读取7zip配置()
            Dim ini文件 As Ini文件 = New Ini文件(Path.Combine(程序数据目录, "配置文件", "7-ZipConfig.ini"))
            压缩格式 = ini文件.获取值("7zipConfig", "CompressionFormat", "7z")
            压缩级别 = Conversions.ToInteger(ini文件.获取值("7zipConfig", "CompressionLevel", "9"))
            压缩方法 = ini文件.获取值("7zipConfig", "CompressionMethod", "LZMA2")
            字典大小 = ini文件.获取值("7zipConfig", "DictionarySize", "64KB")
            单词大小 = ini文件.获取值("7zipConfig", "WordSize", "8")
            线程数 = ini文件.获取值("7zipConfig", "ThreadsCounts", "1")
            超时时长 = Conversions.ToInteger(ini文件.获取值("7zipConfig", "TimeOut", "600"))
            备份输出目录 = ini文件.获取值("7zipConfig", "BackupOutputDir")
            是否备份自定义目录 = Conversions.ToBoolean(ini文件.获取值("7zipConfig", "BackupCustomizedDir", "False"))
            自定义备份目录 = ini文件.获取值("7zipConfig", "BackupDir")
            是否增量备份 = Conversions.ToBoolean(ini文件.获取值("7zipConfig", "IncrementalBackup", "True"))
            自定义备份目录排除文件参数 = ini文件.获取值("7zipConfig", "BackupCustomizedDirExcludedFile")
        End Sub

        Public Shared Sub 读取Sftp配置()
            Dim ini文件 As Ini文件 = New Ini文件(Path.Combine(程序数据目录, "配置文件", "SFTPConfig.ini"))
            Sftp1开关 = Conversions.ToBoolean(ini文件.获取值("SFTP1Config", "Enable", Conversions.ToString(Value:=True)))
            Sftp1名称 = ini文件.获取值("SFTP1Config", "Name", "SFTP1")
            Sftp1地址 = ini文件.获取值("SFTP1Config", "IP", "127.0.0.1")
            Sftp1端口 = ini文件.获取值("SFTP1Config", "Port", "22")
            Sftp1用户名 = ini文件.获取值("SFTP1Config", "User", "admin")
            Sftp1密码 = ini文件.获取值("SFTP1Config", "Password")
            Sftp1已保存密钥指纹 = ini文件.获取值("SFTP1Config", "SavedKeyFingerprint")
            Sftp2开关 = Conversions.ToBoolean(ini文件.获取值("SFTP2Config", "Enable", "False"))
            Sftp2名称 = ini文件.获取值("SFTP2Config", "Name", "SFTP2")
            Sftp2地址 = ini文件.获取值("SFTP2Config", "IP", "127.0.0.1")
            Sftp2端口 = ini文件.获取值("SFTP2Config", "Port", "22")
            Sftp2用户名 = ini文件.获取值("SFTP2Config", "User", "admin")
            Sftp2密码 = ini文件.获取值("SFTP2Config", "Password")
            Sftp2已保存密钥指纹 = ini文件.获取值("SFTP2Config", "SavedKeyFingerprint")
            Sftp3开关 = Conversions.ToBoolean(ini文件.获取值("SFTP3Config", "Enable", "False"))
            Sftp3名称 = ini文件.获取值("SFTP3Config", "Name", "SFTP3")
            Sftp3地址 = ini文件.获取值("SFTP3Config", "IP", "127.0.0.1")
            Sftp3端口 = ini文件.获取值("SFTP3Config", "Port", "22")
            Sftp3用户名 = ini文件.获取值("SFTP3Config", "User", "admin")
            Sftp3密码 = ini文件.获取值("SFTP3Config", "Password")
            Sftp3已保存密钥指纹 = ini文件.获取值("SFTP3Config", "SavedKeyFingerprint")
        End Sub

        Public Shared Sub 写入主程序配置(间隔天数 As String, 运行时间 As String, 是否关服备份 As Boolean, 关服等待时长 As Integer, 帧数 As Integer, 运行模式 As Boolean, 日志窗口位置更新频率 As Integer, 备份模式 As Boolean, 读取缓冲区大小 As Integer)
            Dim ini文件 As Ini文件 = New Ini文件(Path.Combine(程序数据目录, "配置文件", "MainConfig.ini"))
            ini文件.设置值("MainSettings", "Runtime", 运行时间).设置值("MainSettings", "Days", 间隔天数).设置值("MainSettings", "StopMCServer", Conversions.ToString(是否关服备份)).设置值("MainSettings", "WaitingSeconds", Conversions.ToString(关服等待时长)).设置值("MainSettings", "RunMode", Conversions.ToString(运行模式)).设置值("MainSettings", "FPS", 帧数.ToString()).设置值("MainSettings", "LogWindowUpdateFrequency", 日志窗口位置更新频率.ToString()).设置值("MainSettings", "BackupMode", Conversions.ToString(备份模式)).设置值("MainSettings", "BufferSizes", Conversions.ToString(读取缓冲区大小)).保存()
        End Sub

        Public Shared Sub 写入MC服务端配置(MC服务器序号 As String, 开关状态 As String, 服务器名称 As String, 地址 As String, 端口 As String, 密码 As String, 路径 As String, 启动脚本 As String, 排除文件参数 As String)
            Dim ini文件 As Ini文件 = New Ini文件(Path.Combine(程序数据目录, "配置文件", "MCServerConfig.ini"))
            ini文件.设置值($"MCServer{MC服务器序号}Config", "Enable", 开关状态).设置值($"MCServer{MC服务器序号}Config", "Name", 服务器名称).设置值($"MCServer{MC服务器序号}Config", "IP", 地址).设置值($"MCServer{MC服务器序号}Config", "RCONPort", 端口).设置值($"MCServer{MC服务器序号}Config", "RCONPassword", 密码).设置值($"MCServer{MC服务器序号}Config", "ServerPath", 路径).设置值($"MCServer{MC服务器序号}Config", "StartBatPath", 启动脚本).设置值($"MCServer{MC服务器序号}Config", "BackupServerExcludedFile", 排除文件参数).保存()
        End Sub

        Public Shared Sub 写入7zip配置(压缩格式 As String, 压缩级别 As Integer, 压缩方法 As String, 字典大小 As String, 单词大小 As String, 超时时长 As Integer, 自定义备份目录 As String, 备份目录 As String, 是否增量备份 As Boolean, 是否备份自定义目录 As String, 线程数 As String, 自定义备份目录排除文件参数 As String)
            Dim ini文件 As Ini文件 = New Ini文件(Path.Combine(程序数据目录, "配置文件", "7-ZipConfig.ini"))
            ini文件.设置值("7zipConfig", "CompressionFormat", 压缩格式).设置值("7zipConfig", "CompressionLevel", 压缩级别.ToString()).设置值("7zipConfig", "CompressionMethod", 压缩方法).设置值("7zipConfig", "DictionarySize", 字典大小).设置值("7zipConfig", "WordSize", 单词大小).设置值("7zipConfig", "ThreadsCounts", 线程数).设置值("7zipConfig", "TimeOut", 超时时长.ToString()).设置值("7zipConfig", "BackupDir", 自定义备份目录).设置值("7zipConfig", "BackupOutputDir", 备份目录).设置值("7zipConfig", "IncrementalBackup", Conversions.ToString(是否增量备份)).设置值("7zipConfig", "BackupCustomizedDir", 是否备份自定义目录).设置值("7zipConfig", "BackupCustomizedDirExcludedFile", 自定义备份目录排除文件参数).保存()
        End Sub

        Public Shared Sub 写入Sftp配置(Sftp服务器序号 As String, 开关状态 As String, 服务器名称 As String, 地址 As String, 端口 As String, 用户名 As String, 密码 As String)
            Dim ini文件 As Ini文件 = New Ini文件(Path.Combine(程序数据目录, "配置文件", "SFTPConfig.ini"))
            ini文件.设置值($"SFTP{Sftp服务器序号}Config", "Enable", 开关状态).设置值($"SFTP{Sftp服务器序号}Config", "Name", 服务器名称).设置值($"SFTP{Sftp服务器序号}Config", "IP", 地址).设置值($"SFTP{Sftp服务器序号}Config", "Port", 端口).设置值($"SFTP{Sftp服务器序号}Config", "User", 用户名).设置值($"SFTP{Sftp服务器序号}Config", "Password", 密码).保存()
        End Sub

        Public Shared Sub 写入Sftp密钥指纹(Sftp服务器序号 As String, 要保存的密钥指纹 As String)
            Dim ini文件 As Ini文件 = New Ini文件(Path.Combine(程序数据目录, "配置文件", "SFTPConfig.ini"))
            ini文件.设置值($"SFTP{Sftp服务器序号}Config", "SavedKeyFingerprint", 要保存的密钥指纹).保存()
        End Sub
    End Class
End Namespace
