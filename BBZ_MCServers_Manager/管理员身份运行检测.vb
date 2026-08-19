Imports System
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <StandardModule>
    Friend NotInheritable Class 管理员身份运行检测
        <DllImport("shell32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
        Private Shared Function IsUserAnAdmin() As Boolean
        End Function

        Public Shared Function 是否以管理员身份运行() As Boolean
            Dim result As Boolean
            Try
                Dim windowsPrincipal As WindowsPrincipal = New WindowsPrincipal(WindowsIdentity.GetCurrent())
                Dim flag = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator)
                Dim flag2 As Boolean = IsUserAnAdmin()
                result = flag AndAlso flag2
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim ex2 = ex
                result = False
                Call ProjectData.ClearProjectError()
            End Try
            Return result
        End Function
    End Class
End Namespace
