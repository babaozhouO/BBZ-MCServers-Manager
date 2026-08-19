Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <StandardModule>
    Public NotInheritable Class 处理单个RCON服务端
        Public Shared Sub 处理单个RCON服务端_发送指令(地址 As String, 端口 As Integer, 密码 As String, 指令 As String, 服务端序号 As String)
            Dim rCON客户端 As RCON客户端 = New RCON客户端(Conversions.ToInteger(服务端序号))
            rCON客户端.连接RCON(地址, 端口, 密码)
            rCON客户端.发送指令并返回响应(指令)
            rCON客户端.软断开()
        End Sub

        Public Shared Sub 处理单个RCON服务端_关服(地址 As String, 端口 As Integer, 密码 As String, 服务端序号 As String)
            Dim rCON客户端 As RCON客户端 = New RCON客户端(Conversions.ToInteger(服务端序号))
            rCON客户端.连接RCON(地址, 端口, 密码)
            rCON客户端.发送指令并返回响应("stop")
            rCON客户端.软断开()
        End Sub

        Public Shared Sub 处理单个RCON服务端_停止自动保存(地址 As String, 端口 As Integer, 密码 As String, 服务端序号 As String)
            Dim rCON客户端 As RCON客户端 = New RCON客户端(Conversions.ToInteger(服务端序号))
            rCON客户端.连接RCON(地址, 端口, 密码)
            rCON客户端.发送指令并返回响应("save-off")
            rCON客户端.发送指令并返回响应("save-all")
            rCON客户端.软断开()
        End Sub

        Public Shared Sub 处理单个RCON服务端_启用自动保存(地址 As String, 端口 As Integer, 密码 As String, 服务端序号 As String)
            Dim rCON客户端 As RCON客户端 = New RCON客户端(Conversions.ToInteger(服务端序号))
            rCON客户端.连接RCON(地址, 端口, 密码)
            rCON客户端.发送指令并返回响应("save-on")
            rCON客户端.软断开()
        End Sub
    End Class
End Namespace
