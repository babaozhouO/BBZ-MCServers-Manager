Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    Public Class 模拟RCON服务端
        Implements IDisposable
        Private Structure RCON数据包结构
            Public 请求编号 As Integer

            Public 包类型 As Integer

            Public 包内容 As String
        End Structure

        Private 监听器 As TcpListener

        Private 运行状态 As Boolean

        Private 响应间隔时间 As Integer

        Private 认证密码 As String

        Private 响应数据包数量 As Integer

        Public Sub New(端口 As Integer, 密码 As String)
            运行状态 = False
            响应间隔时间 = 100
            认证密码 = "测试密码"
            响应数据包数量 = 3
            认证密码 = 密码
            监听器 = New TcpListener(IPAddress.Loopback, 端口)
        End Sub

        Public Sub 启动服务()
            运行状态 = True
            监听器.Start()
            Call ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf 监听客户端连接))
        End Sub

        Private Sub 监听客户端连接(状态 As Object)
            While 运行状态
                Try
                    If 监听器.Pending() Then
                        Dim state As TcpClient = 监听器.AcceptTcpClient()
                        Call ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf 处理客户端请求), state)
                    End If
                    Thread.Sleep(50)
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    Console.WriteLine($"监听异常: {ex2.Message}")
                    Call ProjectData.ClearProjectError()
                End Try
            End While
        End Sub

        Private Sub 处理客户端请求(状态 As Object)
            Dim tcpClient = CType(状态, TcpClient)
            Try
                Using tcpClient
                    Dim networkStream As NetworkStream = tcpClient.GetStream()
                    networkStream.ReadTimeout = 5000
                    Dim flag = False
                    Dim rCON数据包结构 = 读取数据包(networkStream)
                    If rCON数据包结构.包类型 = 3 AndAlso Operators.CompareString(rCON数据包结构.包内容, 认证密码, TextCompare:=False) = 0 Then
                        发送数据包(networkStream, rCON数据包结构.请求编号, 2, "")
                        flag = True
                    End If
                    If Not flag Then
                        发送数据包(networkStream, -1, 2, "认证失败")
                        Return
                    End If
                    While tcpClient.Connected
                        If networkStream.DataAvailable Then
                            Dim rCON数据包结构2 = 读取数据包(networkStream)
                            If rCON数据包结构2.包类型 = 2 Then
                                Dim num = 响应数据包数量
                                Dim i = 1

                                While i <= num
                                    Dim 包内容 = $"响应包[{i}] 请求ID:{rCON数据包结构2.请求编号}" & vbCrLf
                                    发送数据包(networkStream, rCON数据包结构2.请求编号, 0, 包内容)
                                    Thread.Sleep(响应间隔时间)
                                    i = i + 1
                                End While
                                发送数据包(networkStream, rCON数据包结构2.请求编号, 0, "")
                            End If
                        End If
                        Thread.Sleep(50)
                    End While
                End Using
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim ex2 = ex
                Console.WriteLine($"客户端处理异常: {ex2.Message}")
                Call ProjectData.ClearProjectError()
            End Try
        End Sub

        Private Function 读取数据包(网络流 As NetworkStream) As RCON数据包结构
            Dim array = New Byte(3) {}
            网络流.Read(array, 0, 4)
            Dim num = BitConverter.ToInt32(array, 0)
            Dim array2 = New Byte(num - 1 + 1 - 1) {}
            Dim num2 As Integer
            Dim i = 0

            While i < array2.Length
                num2 = 网络流.Read(array2, i, array2.Length - i)
                If num2 = 0 Then
                    Throw New Exception("连接已关闭")
                End If

                i += num2
            End While
            Dim input As MemoryStream = New MemoryStream(array2)
            Dim binaryReader As BinaryReader = New BinaryReader(input)
            Dim result As RCON数据包结构 = Nothing
            result.请求编号 = binaryReader.ReadInt32()
            result.包类型 = binaryReader.ReadInt32()
            result.包内容 = Encoding.UTF8.GetString(binaryReader.ReadBytes(array2.Length - 4 - 4 - 2))
            Return result
        End Function

        Private Sub 发送数据包(网络流 As NetworkStream, 请求编号 As Integer, 包类型 As Integer, 包内容 As String)
            Try
                Dim bytes = Encoding.UTF8.GetBytes(包内容)
                Dim value = 8 + bytes.Length + 2
                Dim memoryStream As MemoryStream = New MemoryStream()
                Using binaryWriter As BinaryWriter = New BinaryWriter(memoryStream)
                    binaryWriter.Write(value)
                    binaryWriter.Write(请求编号)
                    binaryWriter.Write(包类型)
                    binaryWriter.Write(bytes)
                    binaryWriter.Write(New Byte(1) {})
                End Using
                Dim array As Byte() = memoryStream.ToArray()
                网络流.Write(array, 0, array.Length)
                网络流.Flush()
                Console.WriteLine($"已发送数据包 [ID:{请求编号}] 类型:{包类型} 长度:{array.Length}")
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim ex2 = ex
                Console.WriteLine($"发送数据包失败: {ex2.Message}")
                Call ProjectData.ClearProjectError()
            End Try
        End Sub

        Public Sub 配置参数(间隔时间毫秒 As Integer, 数据包数量 As Integer)
            响应间隔时间 = Math.Max(间隔时间毫秒, 10)
            响应数据包数量 = Math.Max(数据包数量, 1)
        End Sub

        Public Sub Dispose()
            运行状态 = False
            监听器.Stop()
        End Sub

        Private Sub Dispose1() Implements IDisposable.Dispose
            'ILSpy generated this explicit interface implementation from .override directive in Dispose
            Dispose()
        End Sub
    End Class
End Namespace
