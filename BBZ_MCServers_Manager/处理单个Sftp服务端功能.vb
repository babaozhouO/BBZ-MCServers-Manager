Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <StandardModule>
    Public NotInheritable Class 处理单个Sftp服务端功能
        Public Shared Sub 处理单个Sftp服务端_上传文件(地址 As String, 端口 As String, 用户名 As String, 密码 As String, 服务器序号 As String, 本地文件路径 As String, 远程目录 As String)
            Dim sFTP客户端RenciSshNet版 As SFTP客户端RenciSshNet版 = New SFTP客户端RenciSshNet版(Conversions.ToInteger(服务器序号))
            sFTP客户端RenciSshNet版.建立Sftp连接(地址, Conversions.ToInteger(端口), 用户名, 密码)
            If sFTP客户端RenciSshNet版.连接状态() Then
                sFTP客户端RenciSshNet版.上传文件(本地文件路径, 远程目录)
            End If
        End Sub

        Public Shared Sub 处理单个Sftp服务端_删除文件(地址 As String, 端口 As String, 用户名 As String, 密码 As String, 服务器序号 As String, 远程文件路径 As String)
            Dim sFTP客户端RenciSshNet版 As SFTP客户端RenciSshNet版 = New SFTP客户端RenciSshNet版(Conversions.ToInteger(服务器序号))
            sFTP客户端RenciSshNet版.建立Sftp连接(地址, Conversions.ToInteger(端口), 用户名, 密码)
            If Conversions.ToBoolean(sFTP客户端RenciSshNet版.连接状态() AndAlso Conversions.ToBoolean(sFTP客户端RenciSshNet版.检测远程文件是否存在(远程文件路径))) Then
                sFTP客户端RenciSshNet版.删除文件(远程文件路径)
            End If
        End Sub

        Public Shared Sub 测试单个Sftp服务端_上传和删除(地址 As String, 端口 As String, 用户名 As String, 密码 As String, 服务器序号 As String, 本地文件路径 As String, 远程目录 As String, 远程文件路径 As String)
            Dim sFTP客户端RenciSshNet版 As SFTP客户端RenciSshNet版 = New SFTP客户端RenciSshNet版(Conversions.ToInteger(服务器序号))
            sFTP客户端RenciSshNet版.建立Sftp连接(地址, Conversions.ToInteger(端口), 用户名, 密码)
            Call MainForm.更新进度条("主任务", 0, 1)
            If sFTP客户端RenciSshNet版.连接状态() Then
                sFTP客户端RenciSshNet版.上传文件(本地文件路径, 远程目录)
                Call MainForm.更新进度条("主任务", 0, 1)
                If Conversions.ToBoolean(sFTP客户端RenciSshNet版.连接状态() AndAlso Conversions.ToBoolean(sFTP客户端RenciSshNet版.检测远程文件是否存在(远程文件路径))) Then
                    sFTP客户端RenciSshNet版.删除文件(远程文件路径)
                End If
                Call MainForm.更新进度条("主任务", 0, 1)
            End If
        End Sub
    End Class
End Namespace
