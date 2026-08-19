Imports System
Imports System.IO
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    Public Class RCON客户端
        Implements IDisposable
        Private RCON客户端实例 As TcpClient

        Private 数据流 As NetworkStream

        Private 请求ID As Integer

        Private ReadOnly 服务端序号 As Integer

        Public 连接状态 As Boolean

        Private 释放状态 As Boolean

        Public Sub New(服务端序号_ As Integer)
            请求ID = 0
            连接状态 = False
            释放状态 = False
            服务端序号 = 服务端序号_
            RCON客户端实例 = New TcpClient()
        End Sub

        Public Sub 连接RCON(地址 As String, 端口 As Integer, 密码 As String)
            If 连接状态 Then
                Return
            End If
            日志窗口.添加日志($"正在连接到RCON{服务端序号}服务端", 5)
            MainForm.更新标签("分任务", $"处理RCON{服务端序号}服务端")
            MainForm.更新进度条("分任务", 0)
            If RCON客户端实例 Is Nothing Then
                RCON客户端实例 = New TcpClient()
            End If
            If RCON客户端实例.Connected Then
                If 数据流 IsNot Nothing Then
                    数据流.Dispose()
                    数据流 = Nothing
                End If
                If RCON客户端实例 IsNot Nothing Then
                    RCON客户端实例.Dispose()
                    RCON客户端实例 = Nothing
                End If
            End If
            If 配置文件操作模块.是否循环更新界面 Then
                Dim task = RCON客户端实例.ConnectAsync(地址, 端口)
                While Not task.IsCompleted
                    Thread.Sleep(配置文件操作模块.延时毫秒数)
                End While
            Else
                RCON客户端实例.Connect(地址, 端口)
            End If
            If Not RCON客户端实例.Connected Then
                日志窗口.添加日志($"RCON{服务端序号}客户端无法连接到指定的服务器，请检查网络连接和配置文件。", 2)
                MainForm.更新标签("分任务", "无")
                MainForm.更新进度条("分任务", 0)
                Return
            End If
            MainForm.更新进度条("分任务", 10)
            日志窗口.添加日志($"RCON{服务端序号}连接成功", 3)
            数据流 = RCON客户端实例.GetStream()
            日志窗口.添加日志($"正在尝试登录至RCON{服务端序号}服务器", 5)
            日志窗口.添加日志($"RCON{服务端序号}客户端正在构建登录信息数据包", 5)
            Dim array = 构建数据包(3, 密码)
            MainForm.更新进度条("分任务", 15)
            日志窗口.添加日志($"RCON{服务端序号}客户端正在发送登录信息数据包", 5)
            If 配置文件操作模块.是否循环更新界面 Then
                Dim task2 = 数据流.WriteAsync(array, 0, array.Length)
                While Not task2.IsCompleted
                    Thread.Sleep(配置文件操作模块.延时毫秒数)
                End While
            Else
                数据流.Write(array, 0, array.Length)
            End If
            日志窗口.添加日志($"RCON{服务端序号}客户端:登录数据包发送完成", 3)
            日志窗口.添加日志($"RCON{服务端序号}客户端正在接收并读取返回数据包,接收超时时长:0.5s", 5)
            If 配置文件操作模块.是否循环更新界面 Then
                Dim num As Integer = Math.Round(0.5 * 配置文件操作模块.帧数)
                Dim num2 = 55.0 / num
                Dim num3 = num
                For i = 1 To num3
                    MainForm.更新进度条("分任务", 35 + Math.Min(CInt(Math.Round(num2 * i)), 55))
                    Thread.Sleep(配置文件操作模块.延时毫秒数)
                Next
                MainForm.更新进度条("分任务", 90)
            Else
                Thread.Sleep(500)
                MainForm.更新进度条("分任务", 90)
            End If
            Dim item As Integer = 读取返回数据包().Item1
            Select Case item
                Case 0
                    连接状态 = True
                    日志窗口.添加日志($"RCON{服务端序号}登录成功", 3)
                    MainForm.更新进度条("分任务", 20)
                    Return
                Case -1
                    日志窗口.添加日志($"RCON{服务端序号}登录失败，密码错误", 2)
                Case -2
                    日志窗口.添加日志($"RCON{服务端序号}登录失败，网络错误", 2)
                Case Else
                    日志窗口.添加日志($"RCON{服务端序号}登录失败，未知错误，返回代码{item}", 2)
            End Select
            MainForm.更新进度条("分任务", 0)
            MainForm.更新标签("分任务", "")
        End Sub

        Public Sub 发送指令并返回响应(指令 As String, Optional 等待时长 As Integer = 3)
            If Not 连接状态 Then
                Return
            End If
            If String.IsNullOrEmpty(指令) Then
                日志窗口.添加日志($"RCON{服务端序号}客户端指令不能为空", 2)
                Return
            End If
            日志窗口.添加日志($"RCON{服务端序号}客户端要发送的指令:{指令}", 0)
            请求ID += 1
            日志窗口.添加日志($"RCON{服务端序号}客户端正在构建指令数据包", 5)
            Dim array = 构建数据包(2, 指令)
            MainForm.更新进度条("分任务", 30)
            日志窗口.添加日志($"RCON{服务端序号}客户端正在发送指令数据包", 5)
            If 配置文件操作模块.是否循环更新界面 Then
                Dim task = 数据流.WriteAsync(array, 0, array.Length)
                While Not task.IsCompleted
                    Thread.Sleep(配置文件操作模块.延时毫秒数)
                End While
            Else
                数据流.Write(array, 0, array.Length)
            End If
            日志窗口.添加日志($"RCON{服务端序号}客户端:指令数据包发送完成", 3)
            MainForm.更新进度条("分任务", 35)
            If Operators.CompareString(指令, "list", TextCompare:=False) = 0 Or Operators.CompareString(指令, "stop", TextCompare:=False) = 0 Or Operators.CompareString(指令, "save-off", TextCompare:=False) = 0 Or Operators.CompareString(指令, "save-on", TextCompare:=False) = 0 Then
                日志窗口.添加日志($"RCON{服务端序号}客户端正在接收并读取返回数据包,接收超时时长:0.5s", 5)
                If 配置文件操作模块.是否循环更新界面 Then
                    Dim num As Integer = Math.Round(0.5 * 配置文件操作模块.帧数)
                    Dim num2 = 55.0 / num
                    Dim num3 = num
                    For i = 1 To num3
                        MainForm.更新进度条("分任务", 35 + Math.Min(CInt(Math.Round(num2 * i)), 55))
                        Thread.Sleep(配置文件操作模块.延时毫秒数)
                    Next
                    MainForm.更新进度条("分任务", 90)
                Else
                    Thread.Sleep(500)
                    MainForm.更新进度条("分任务", 90)
                End If
            Else
                日志窗口.添加日志($"RCON{服务端序号}客户端正在接收并读取返回数据包,接收超时时长:{等待时长}s", 5)
                If 配置文件操作模块.是否循环更新界面 Then
                    Dim num4 As Double = 等待时长 * 配置文件操作模块.帧数
                    Dim num5 = 55.0 / num4
                    Dim num6 As Integer = Nothing
                    While num6 <= num4
                        num6 += 1
                        Thread.Sleep(配置文件操作模块.延时毫秒数)
                        MainForm.更新进度条("分任务", 35 + Math.Min(CInt(Math.Round(num5 * num6)), 55))
                    End While
                Else
                    Thread.Sleep(等待时长 * 1000)
                    MainForm.更新进度条("分任务", 90)
                End If
            End If
            Dim text = ""
            Try
                While 数据流.DataAvailable
                    Dim tuple As (Integer, String) = 读取返回数据包()
                    If tuple.Item1 = 请求ID Then
                        text += tuple.Item2
                    End If
                End While
            Catch ex As IOException
                ProjectData.SetProjectError(ex)
                Dim ex2 = ex
                日志窗口.添加日志($"读取返回响应失败: {ex2.Message}", 2)
                Call ProjectData.ClearProjectError()
            End Try
            MainForm.更新进度条("分任务", 100)
            日志窗口.添加日志($"MC服务器{服务端序号}指令返回信息:", 0)
            日志窗口.添加日志(text, 0)
        End Sub

        Private Function 构建数据包(数据包类型 As Integer, 要发送的数据 As String) As Byte()
            Dim memoryStream As MemoryStream = New MemoryStream()
            Using binaryWriter As BinaryWriter = New BinaryWriter(memoryStream)
                Dim bytes = Encoding.UTF8.GetBytes(要发送的数据)
                Dim value = 8 + bytes.Length + 2
                binaryWriter.Write(value)
                binaryWriter.Write(请求ID)
                binaryWriter.Write(数据包类型)
                binaryWriter.Write(bytes)
                binaryWriter.Write(New Byte(1) {})
            End Using
            Return memoryStream.ToArray()
        End Function

        Public Function 读取返回数据包() As (Integer, String)
            Dim result As (Integer, String)
            If 数据流.DataAvailable Then
                Dim array = New Byte(3) {}
                Dim num = 0
                Dim num2 = 0
                While num < 4 AndAlso num2 <= 5
                    Dim num3 = 数据流.Read(array, num, 4 - num)
                    If num3 = 0 Then
                        num2 += 1
                    Else
                        num += num3
                    End If
                End While
                If num < 4 AndAlso num2 >= 5 Then
                    日志窗口.添加日志($"数据包长度记录读取完成前,MC服务端{服务端序号}已关闭连接", 2)
                    result = (-2, "空")
                Else
                    Dim num4 = BitConverter.ToInt32(array, 0)
                    Dim array2 = New Byte(3) {}
                    数据流.Read(array2, 0, 4)
                    Dim item = BitConverter.ToInt32(array2, 0)
                    Dim array3 = New Byte(3) {}
                    数据流.Read(array3, 0, 4)
                    Dim num5 = BitConverter.ToInt32(array3, 0)
                    Dim array4 = New Byte(num4 - 4 - 4 - 2 - 1 + 1 - 1) {}
                    数据流.Read(array4, 0, array4.Length)
                    Dim [string] = Encoding.UTF8.GetString(array4)
                    Dim buffer = New Byte(1) {}
                    数据流.Read(buffer, 0, 2)
                    result = (item, [string])
                End If
            Else
                日志窗口.添加日志("没有滞留的数据包", 1)
                result = (-2, "空")
            End If
            Return result
        End Function

        Public Sub 软断开()
            If RCON客户端实例?.Client Is Nothing OrElse Not RCON客户端实例.Client.Connected Then
                Return
            End If
            Try
                If 数据流 IsNot Nothing Then
                    数据流.Dispose()
                    数据流 = Nothing
                End If
                If RCON客户端实例 IsNot Nothing Then
                    RCON客户端实例.Dispose()
                    RCON客户端实例 = Nothing
                End If
                连接状态 = False
                MainForm.更新标签("分任务", "无")
                MainForm.更新进度条("分任务", 0)
                日志窗口.添加日志($"RCON{服务端序号}连接已软断开", 3)
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim ex2 = ex
                日志窗口.添加日志($"RCON{服务端序号}软断开失败: {ex2.Message}", 2)
                Call ProjectData.ClearProjectError()
            End Try
        End Sub

        Protected Overridable Sub Dispose(disposing As Boolean)
            If 释放状态 Then
                Return
            End If
            If disposing Then
                If 数据流 IsNot Nothing Then
                    数据流.Dispose()
                    数据流 = Nothing
                End If
                If RCON客户端实例 IsNot Nothing Then
                    RCON客户端实例.Dispose()
                    RCON客户端实例 = Nothing
                End If
            End If
            释放状态 = True
            MainForm.更新标签("分任务", "无")
            MainForm.更新进度条("分任务", 0)
            日志窗口.添加日志($"RCON{服务端序号}服务器连接已硬断开并释放资源", 3)
        End Sub

        Public Sub 释放资源()
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub

        Private Sub Dispose1() Implements IDisposable.Dispose
            'ILSpy generated this explicit interface implementation from .override directive in 释放资源
            释放资源()
        End Sub
    End Class
End Namespace
