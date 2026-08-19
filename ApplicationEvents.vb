Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup, Shutdown, UnhandledException, StartupNextInstance, NetworkAvailabilityChanged, ApplyApplicationDefaults

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            ' 异步改造：允许后台线程直接更新 UI 控件（耗时操作移到后台线程）
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Try
                System.IO.File.WriteAllText(
                    System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "crash.log"),
                    e.Exception.ToString())
            Catch
            End Try
        End Sub

    End Class
End Namespace
