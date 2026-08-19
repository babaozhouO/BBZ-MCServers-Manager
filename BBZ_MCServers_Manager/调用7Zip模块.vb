Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <StandardModule>
    Friend NotInheritable Class 调用7Zip模块
        Public Class SevenZIP
            Implements IDisposable
            <CompilerGenerated>
            Friend NotInheritable Class _Closure_0024__12_002D0
                Public _0024VB_0024Local_进度百分比 As String

                Public _0024VB_0024Local_进度 As String

                Public _0024VB_0024Local_处理中的文件 As String

                Public Sub New(arg0 As _Closure_0024__12_002D0)
                    If arg0 IsNot Nothing Then
                        _0024VB_0024Local_进度百分比 = arg0._0024VB_0024Local_进度百分比
                        _0024VB_0024Local_进度 = arg0._0024VB_0024Local_进度
                        _0024VB_0024Local_处理中的文件 = arg0._0024VB_0024Local_处理中的文件
                    End If
                End Sub

                <SpecialName>
                <DebuggerHidden>
                Friend Sub _Lambda_0024__R3(a0 As Object)
                    _Lambda_0024__0()
                End Sub

                <SpecialName>
                Friend Sub _Lambda_0024__0()
                    日志窗口.添加日志(String.Format("进度:{0} | 正在处理第{1}个文件{2}处理中的文件:{3}", _0024VB_0024Local_进度百分比, _0024VB_0024Local_进度, vbCrLf, _0024VB_0024Local_处理中的文件), 0)
                    MainForm.更新标签("分任务", String.Format("进度:{0} | 正在处理第{1}个文件{2}处理中的文件:{3}", _0024VB_0024Local_进度百分比, _0024VB_0024Local_进度, vbCrLf, _0024VB_0024Local_处理中的文件))
                    MainForm.更新进度条("分任务", Math.Round(50.0 + Conversions.ToInteger(_0024VB_0024Local_进度百分比.TrimEnd("%"c)) * 0.4))
                End Sub
            End Class

            <CompilerGenerated>
            Friend NotInheritable Class _Closure_0024__12_002D1
                Public _0024VB_0024Local_输入数据 As String

                Public Sub New(arg0 As _Closure_0024__12_002D1)
                    If arg0 IsNot Nothing Then
                        _0024VB_0024Local_输入数据 = arg0._0024VB_0024Local_输入数据
                    End If
                End Sub

                <SpecialName>
                <DebuggerHidden>
                Friend Sub _Lambda_0024__R4(a0 As Object)
                    _Lambda_0024__1()
                End Sub

                <SpecialName>
                Friend Sub _Lambda_0024__1()
                    日志窗口.添加日志($"原始输出:{_0024VB_0024Local_输入数据}", 0)
                End Sub

                <SpecialName>
                <DebuggerHidden>
                Friend Sub _Lambda_0024__R5(a0 As Object)
                    _Lambda_0024__2()
                End Sub

                <SpecialName>
                Friend Sub _Lambda_0024__2()
                    If _0024VB_0024Local_输入数据.Contains("warning") Then
                        日志窗口.添加日志($"{_0024VB_0024Local_输入数据}", 1)
                    End If
                    If _0024VB_0024Local_输入数据.Contains("error") Then
                        日志窗口.添加日志($"{_0024VB_0024Local_输入数据}", 2)
                    End If
                End Sub

                <SpecialName>
                <DebuggerHidden>
                Friend Sub _Lambda_0024__R6(a0 As Object)
                    _Lambda_0024__3()
                End Sub

                <SpecialName>
                Friend Sub _Lambda_0024__3()
                    日志窗口.添加日志($"解析时发生错误,原始输出:{_0024VB_0024Local_输入数据}", 2)
                End Sub
            End Class

            <CompilerGenerated>
            <DebuggerBrowsable(DebuggerBrowsableState.Never)>
            <AccessedThroughProperty("KillCountDownTimer")>
            Private _KillCountDownTimer As Timers.Timer

            Private ReadOnly 进程 As Process

            Private 进程是否被杀死 As Boolean

            Private UI线程 As SynchronizationContext

            Private Property KillCountDownTimer As Timers.Timer
                <CompilerGenerated>
                Get
                    Return _KillCountDownTimer
                End Get
                <MethodImpl(MethodImplOptions.Synchronized)>
                <CompilerGenerated>
                Set(value As Timers.Timer)
                    Dim value2 As ElapsedEventHandler = Sub(a0, a1) Kill()
                    Dim lKillCountDownTimer = _KillCountDownTimer
                    If lKillCountDownTimer IsNot Nothing Then
                        RemoveHandler lKillCountDownTimer.Elapsed, value2
                    End If
                    _KillCountDownTimer = value
                    lKillCountDownTimer = _KillCountDownTimer
                    If lKillCountDownTimer IsNot Nothing Then
                        AddHandler lKillCountDownTimer.Elapsed, value2
                    End If
                End Set
            End Property

            Public Sub New()
                KillCountDownTimer = New Timers.Timer With {
        .AutoReset = False,
        .Interval = 配置文件操作模块.超时时长 * 1000
    }
                进程 = New Process()
                进程是否被杀死 = False
                UI线程 = SynchronizationContext.Current
            End Sub

            Public Function 调用7Zip(操作模式 As String, 附加参数 As String, 输出路径 As String, 输入目录 As String, Optional 要备份的MC服务端序号 As Integer = -1) As Integer
                Dim text = If(配置文件操作模块.是否增量备份, "增量备份", "完整备份")
                MainForm.更新进度条("分任务", 10)
                If 要备份的MC服务端序号 = -1 Then
                    MainForm.更新标签("分任务", $"执行自定义文件夹{text}操作")
                    日志窗口.添加日志($"开始执行自定义文件夹{text}操作", 5)
                Else
                    MainForm.更新标签("分任务", $"执行MC服务端{要备份的MC服务端序号}{text}操作")
                    日志窗口.添加日志($"开始执行MC服务端{要备份的MC服务端序号}{text}操作", 5)
                End If
                Dim text2 = 生成压缩参数(操作模式, 附加参数, 输出路径, 输入目录)
                MainForm.更新进度条("分任务", 15)
                If String.IsNullOrEmpty(text2) Then
                    日志窗口.添加日志("用户取消了操作", 1)
                    MainForm.更新标签("分任务", "无")
                    MainForm.更新进度条("分任务", 0)
                    Return 0
                End If
                Return 运行压缩进程(text2)
            End Function

            Private Shared Function 生成压缩参数(操作模式 As String, 附加参数 As String, 输出路径 As String, 输入目录 As String) As String
                日志窗口.添加日志("生成完整压缩参数中", 0)
                Dim item = """" & 输出路径.Replace("""", "\""") & """"
                Dim item2 = """" & 输入目录.Replace("""", "\""") & """"
                Dim list As List(Of String) = New List(Of String) From {
                        操作模式
                    }
                If Not String.IsNullOrWhiteSpace(附加参数) Then
                    日志窗口.添加日志($"正在解析附加参数：{附加参数}", 4)
                    Dim source = Regex.Matches(附加参数, "(?:\s*("".*?""|\S+))")
                    Dim collection As List(Of String) = (From m In source Select m.Groups(1).Value.Trim()).ToList()
                    list.AddRange(collection)
                Else
                    日志窗口.添加日志("无附加参数", 1)
                    Dim dialogResult = MessageBox.Show("附加参数为空,确认执行操作?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    If dialogResult = DialogResult.No Then
                        Return ""
                    End If
                End If
                list.Add(item)
                list.Add(item2)
                Dim text = String.Join(" ", list)
                日志窗口.添加日志("完整压缩参数生成完成", 3)
                日志窗口.添加日志($"完整参数：{text}", 4)
                Return text
            End Function

            Private Sub Kill()
                UI线程.Post(Sub(a0) _Lambda_0024__9_002D0(), Nothing)
            End Sub

            Public Function 运行压缩进程(参数 As String) As Integer
                Try
                    If 配置文件操作模块.是否循环更新界面 Then
                        AddHandler 进程.OutputDataReceived, Sub(sender, 收到的输出)
                                                              If Not String.IsNullOrEmpty(收到的输出.Data) Then
                                                                  解析输出数据(收到的输出.Data, 类型:=True)
                                                              End If
                                                          End Sub
                        AddHandler 进程.ErrorDataReceived, Sub(sender, 收到的输出)
                                                             If Not String.IsNullOrEmpty(收到的输出.Data) Then
                                                                 解析输出数据(收到的输出.Data, 类型:=False)
                                                             End If
                                                         End Sub
                    End If
                    进程.StartInfo = New ProcessStartInfo With {
    .FileName = 配置文件操作模块.程序路径,
    .Arguments = $"{参数} -bsp1",
    .UseShellExecute = False,
    .CreateNoWindow = True,
    .RedirectStandardOutput = True,
    .RedirectStandardError = True
}
                    日志窗口.添加日志($"7z正在启动，启动命令：{配置文件操作模块.程序路径} {参数}", 4)
                    If 进程.Start() Then
                        MainForm.更新进度条("分任务", 50)
                        If 配置文件操作模块.是否循环更新界面 Then
                            KillCountDownTimer.Enabled = True
                            日志窗口.添加日志($"7z已启动,请耐心等待压缩完成(超时时长:{配置文件操作模块.超时时长}秒)", 0)
                            进程.BeginOutputReadLine()
                            进程.BeginErrorReadLine()
                            While Not 进程.HasExited
                                Thread.Sleep(配置文件操作模块.延时毫秒数)
                            End While
                            Dim num = 配置文件操作模块.帧数 * 3
                            For i = 1 To num
                                Thread.Sleep(配置文件操作模块.延时毫秒数)
                            Next
                        Else
                            If Not 进程.WaitForExit(配置文件操作模块.超时时长 * 1000) Then
                                进程.Kill()
                                MainForm.更新进度条("分任务", 90)
                                进程是否被杀死 = True
                            End If
                            Dim text As String = 进程.StandardOutput.ReadToEnd()
                            Dim text2 As String = 进程.StandardError.ReadToEnd()
                            If Not String.IsNullOrEmpty(text) Then
                                日志窗口.添加日志($"7z输出：{text}", 0)
                            End If
                            If Not String.IsNullOrEmpty(text2) Then
                                日志窗口.添加日志($"7z错误：{text2}", 2)
                            End If
                        End If
                        MainForm.更新进度条("分任务", 100)
                        If 进程是否被杀死 Then
                            Return 2
                        End If
                        If 进程.ExitCode = 0 Then
                            Return 0
                        End If
                        If 进程.ExitCode = 1 Then
                            If 进程是否被杀死 Then
                                日志窗口.添加日志("压缩过程中7z进程被杀死", 2)
                            Else
                                日志窗口.添加日志("压缩过程中发生非致命错误", 1)
                            End If
                        ElseIf 进程.ExitCode = 2 Then
                            If 进程是否被杀死 Then
                                日志窗口.添加日志("压缩过程中7z进程被杀死", 2)
                            End If
                            日志窗口.添加日志("压缩过程中发生致命错误", 1)
                            日志窗口.添加日志("请检查压缩参数设置，可能是需要的内存过多", 1)
                        End If
                        Return 进程.ExitCode
                    End If
                    日志窗口.添加日志("7z启动失败", 2)
                    Return 2
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    日志窗口.添加日志($"压缩过程中发生错误:{ex2.Message}", 2)
                    MainForm.更新进度条("分任务", 0)
                    Call ProjectData.ClearProjectError()
                Finally
                    MainForm.更新标签("分任务", "无")
                    MainForm.更新进度条("分任务", 0)
                End Try
                Return 2
            End Function

            Private Sub 解析输出数据(输入数据 As String, 类型 As Boolean)
                Dim arg As _Closure_0024__12_002D1 = Nothing
                Dim CS_0024_003C_003E8__locals0 As _Closure_0024__12_002D1 = New _Closure_0024__12_002D1(arg)
                CS_0024_003C_003E8__locals0._0024VB_0024Local_输入数据 = 输入数据
                Try
                    If CS_0024_003C_003E8__locals0._0024VB_0024Local_输入数据.Contains("                    ") Then
                        Return
                    End If
                    If 类型 Then
                        If CS_0024_003C_003E8__locals0._0024VB_0024Local_输入数据.Contains("\"c) AndAlso CS_0024_003C_003E8__locals0._0024VB_0024Local_输入数据.Contains("%"c) AndAlso (CS_0024_003C_003E8__locals0._0024VB_0024Local_输入数据.Contains("+"c) OrElse CS_0024_003C_003E8__locals0._0024VB_0024Local_输入数据.Contains("A"c)) Then
                            Dim arg2 As _Closure_0024__12_002D0 = Nothing
                            Dim CS_0024_003C_003E8__locals1 As _Closure_0024__12_002D0 = New _Closure_0024__12_002D0(arg2)
                            Dim array = CS_0024_003C_003E8__locals0._0024VB_0024Local_输入数据.Replace(" + ", " ").Replace("% A ", "% 0 ").TrimStart(" "c).Split(" ")
                            CS_0024_003C_003E8__locals1._0024VB_0024Local_进度百分比 = array(0)
                            CS_0024_003C_003E8__locals1._0024VB_0024Local_进度 = array(1)
                            CS_0024_003C_003E8__locals1._0024VB_0024Local_处理中的文件 = ""
                            Dim num = array.Length - 1
                            For i = 2 To num
                                CS_0024_003C_003E8__locals1._0024VB_0024Local_处理中的文件 += $"{array(i)} "
                            Next
                            CS_0024_003C_003E8__locals1._0024VB_0024Local_处理中的文件 = CS_0024_003C_003E8__locals1._0024VB_0024Local_处理中的文件.TrimEnd(" "c)
                            UI线程.Post(Sub(a0) CS_0024_003C_003E8__locals1._Lambda_0024__0(), Nothing)
                        Else
                            UI线程.Post(Sub(a0) CS_0024_003C_003E8__locals0._Lambda_0024__1(), Nothing)
                        End If
                    Else
                        UI线程.Post(Sub(a0) CS_0024_003C_003E8__locals0._Lambda_0024__2(), Nothing)
                    End If
                Catch projectError As Exception
                    ProjectData.SetProjectError(projectError)
                    UI线程.Post(Sub(a0) CS_0024_003C_003E8__locals0._Lambda_0024__3(), Nothing)
                    Call ProjectData.ClearProjectError()
                End Try
            End Sub

            Public Sub Dispose()
                进程?.Dispose()
                KillCountDownTimer?.Dispose()
                UI线程 = Nothing
                GC.SuppressFinalize(Me)
            End Sub

            Private Sub Dispose1() Implements IDisposable.Dispose
                'ILSpy generated this explicit interface implementation from .override directive in Dispose
                Dispose()
            End Sub

            <SpecialName>
            <CompilerGenerated>
            Private Sub _Lambda_0024__9_002D0()
                If Not 进程.HasExited Then
                    进程.Kill()
                    进程是否被杀死 = True
                    日志窗口.添加日志("压缩超时终止", 2)
                End If
                KillCountDownTimer.Dispose()
            End Sub
        End Class
    End Class
End Namespace
