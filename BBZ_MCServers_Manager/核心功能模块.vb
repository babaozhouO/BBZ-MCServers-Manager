Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <StandardModule>
    Public NotInheritable Class 核心功能模块
        Public Class 间隔任务执行器
            Private ReadOnly UI线程 As SynchronizationContext

            Private 下次执行时间 As Date

            Private 执行时间间隔 As TimeSpan

            <CompilerGenerated>
            <DebuggerBrowsable(DebuggerBrowsableState.Never)>
            <AccessedThroughProperty("计时器")>
            Private _计时器 As Timers.Timer

            Private Property 计时器 As Timers.Timer
                <CompilerGenerated>
                Get
                    Return _计时器
                End Get
                <MethodImpl(MethodImplOptions.Synchronized)>
                <CompilerGenerated>
                Set(value As Timers.Timer)
                    Dim value2 As ElapsedEventHandler = Sub(a0, a1) 时间到达()
                    Dim timer = _计时器
                    If timer IsNot Nothing Then
                        RemoveHandler timer.Elapsed, value2
                    End If
                    _计时器 = value
                    timer = _计时器
                    If timer IsNot Nothing Then
                        AddHandler timer.Elapsed, value2
                    End If
                End Set
            End Property

            Public Sub New()
                UI线程 = SynchronizationContext.Current
                计时器 = New Timers.Timer With {
        .AutoReset = False
    }
                启动()
                日志窗口.添加日志("已启动备份计划", 3)
            End Sub

            Private Sub 启动()
                日志窗口.添加日志("正在计算下一次执行时间", 5)
                配置文件操作模块.间隔天数 = Conversions.ToString(If(Conversions.ToDouble(配置文件操作模块.间隔天数) < 1.0, CObj(1), 配置文件操作模块.间隔天数))
                Dim value = 配置文件操作模块.运行时间.Split(":")(0)
                Dim value2 = 配置文件操作模块.运行时间.Split(":")(1)
                Dim value3 = 配置文件操作模块.运行时间.Split(":")(2)
                If 配置文件操作模块.运行模式 Then
                    Dim [date] = Date.Now.Date
                    Dim t = [date].AddHours(Conversions.ToDouble(value)).AddMinutes(Conversions.ToDouble(value2)).AddSeconds(Conversions.ToDouble(value3))
                    If Date.Compare(t, Date.Now) < 0 Then
                        下次执行时间 = [date].AddDays(Conversions.ToDouble(配置文件操作模块.间隔天数)).AddHours(Conversions.ToDouble(value)).AddMinutes(Conversions.ToDouble(value2)).AddSeconds(Conversions.ToDouble(value3))
                    Else
                        下次执行时间 = t
                    End If
                Else
                    下次执行时间 = Date.Now.AddHours(Conversions.ToDouble(value)).AddMinutes(Conversions.ToDouble(value2)).AddSeconds(Conversions.ToDouble(value3))
                End If
                执行时间间隔 = 下次执行时间 - Date.Now
                日志窗口.添加日志($"执行时间成功传入,下次执行时间:{下次执行时间}", 3)
                计时器.Interval = 执行时间间隔.TotalMilliseconds
                计时器.Start()
                配置文件操作模块.服务运行状态 = True
            End Sub

            Private Sub 时间到达()
                计时器.Stop()
                UI线程.Post(Sub(a0) _Lambda_0024__9_002D0(), Nothing)
            End Sub

            Public Function 获取剩余秒数() As (Integer, Integer)
                Dim totalSeconds = (下次执行时间 - Date.Now).TotalSeconds
                totalSeconds = If(totalSeconds >= 0.0, totalSeconds, 0.0)
                Return (CInt(Math.Round(totalSeconds)), CInt(Math.Round(执行时间间隔.TotalSeconds)))
            End Function

            Public Sub 开始计时()
                计时器.Start()
            End Sub

            Public Function 获取计时器状态() As Boolean
                Return 计时器.Enabled
            End Function

            Public Sub 停止计时()
                计时器.Stop()
            End Sub

            Public Sub 停止任务()
                配置文件操作模块.服务运行状态 = False
                计时器?.Dispose()
            End Sub

            <SpecialName>
            <CompilerGenerated>
            Private Sub _Lambda_0024__9_002D0()
                ' 异步改造：把耗时的核心功能方法放到后台线程执行，避免阻塞 UI 线程
                System.Threading.Tasks.Task.Run(Sub()
                    Dim 核心功能类 As 核心功能类 = New 核心功能类()
                    核心功能类.核心功能方法()
                    启动()
                End Sub)
            End Sub
        End Class

        Public Class 核心功能类
            Private MC服务端1运行状态 As Integer

            Private MC服务端2运行状态 As Integer

            Private MC服务端3运行状态 As Integer

            Private MC服务端4运行状态 As Integer

            Private MC服务端5运行状态 As Integer

            Private MC服务端6运行状态 As Integer

            Private MC服务端7运行状态 As Integer

            Private MC服务端8运行状态 As Integer

            Private MC服务端9运行状态 As Integer

            Private MC服务端10运行状态 As Integer

            Private MC服务端1备份状态 As Boolean

            Private MC服务端2备份状态 As Boolean

            Private MC服务端3备份状态 As Boolean

            Private MC服务端4备份状态 As Boolean

            Private MC服务端5备份状态 As Boolean

            Private MC服务端6备份状态 As Boolean

            Private MC服务端7备份状态 As Boolean

            Private MC服务端8备份状态 As Boolean

            Private MC服务端9备份状态 As Boolean

            Private MC服务端10备份状态 As Boolean

            Private 自定义备份目录备份状态 As Boolean

            Public Sub New()
                MC服务端1运行状态 = -1
                MC服务端2运行状态 = -1
                MC服务端3运行状态 = -1
                MC服务端4运行状态 = -1
                MC服务端5运行状态 = -1
                MC服务端6运行状态 = -1
                MC服务端7运行状态 = -1
                MC服务端8运行状态 = -1
                MC服务端9运行状态 = -1
                MC服务端10运行状态 = -1
                MC服务端1备份状态 = False
                MC服务端2备份状态 = False
                MC服务端3备份状态 = False
                MC服务端4备份状态 = False
                MC服务端5备份状态 = False
                MC服务端6备份状态 = False
                MC服务端7备份状态 = False
                MC服务端8备份状态 = False
                MC服务端9备份状态 = False
                MC服务端10备份状态 = False
                自定义备份目录备份状态 = False
            End Sub

            Public Sub 核心功能方法()
                If 配置文件操作模块.备份操作进行状态 Then
                    日志窗口.添加日志("重复运行备份功能,后发起的请求已取消", 1)
                    Return
                End If
                If Not 检查执行备份的条件() Then
                    日志窗口.添加日志("执行备份功能的条件不满足,已取消", 1)
                    Return
                End If
                Dim list As List(Of Integer) = New List(Of Integer)()
                配置文件操作模块.备份操作进行状态 = True
                Dim 服务运行状态 = 配置文件操作模块.服务运行状态
                MainForm.备份运行时更改控件状态(运行状态:=True)
                Dim flag = False
                Try
                    日志窗口.添加日志("开始执行备份功能", 5)
                    日志窗口.添加日志($"备份输出目录: {配置文件操作模块.备份输出目录}", 4)
                    日志窗口.添加日志($"备份模式: {If(配置文件操作模块.是否增量备份, "增量备份", "完整备份")} / 关服备份: {配置文件操作模块.是否关服备份}", 4)
                    MainForm.更新标签("主任务", "备份MC服务端")
                    MainForm.更新进度条("主任务", 100, 2)
                    MainForm.更新进度条("主任务", 0)
                    If 配置文件操作模块.是否关服备份 Then
                        RCON关闭MC服务器()
                    Else
                        RCON停止服务端自动保存()
                    End If
                    MainForm.更新进度条("主任务", 10)
                    Dim collection As IEnumerable(Of Integer) = New Integer(9) {MC服务端1运行状态, MC服务端2运行状态, MC服务端3运行状态, MC服务端4运行状态, MC服务端5运行状态, MC服务端6运行状态, MC服务端7运行状态, MC服务端8运行状态, MC服务端9运行状态, MC服务端10运行状态}
                    list.AddRange(collection)
                    If list.Contains(0) Then
                        日志窗口.添加日志($"等待MC服务端彻底关闭({配置文件操作模块.等待服务端关闭时长}s)", 5)
                        MainForm.更新标签("分任务", $"等待MC服务端彻底关闭({配置文件操作模块.等待服务端关闭时长}s)")
                        If 配置文件操作模块.是否循环更新界面 Then
                            Dim num = 配置文件操作模块.等待服务端关闭时长 * 配置文件操作模块.帧数
                            Dim num2 = 100.0 / num
                            Dim num3 = num
                            For i = 1 To num3
                                MainForm.更新进度条("分任务", If(CInt(Math.Round(num2 * i)) <= 100, Math.Round(num2 * i), 100))
                                Thread.Sleep(配置文件操作模块.延时毫秒数)
                            Next
                            MainForm.更新进度条("分任务", 100)
                        Else
                            Thread.Sleep(配置文件操作模块.等待服务端关闭时长 * 1000)
                            MainForm.更新进度条("分任务", 100)
                        End If
                    End If
                    MainForm.更新进度条("主任务", 15)
                    备份MC服务端()
                    MainForm.更新进度条("主任务", 60)
                    If Not 配置文件操作模块.是否关服备份 Then
                        RCON启用服务端自动保存()
                    ElseIf 配置文件操作模块.是否关服备份 And Not 配置文件操作模块.是否备份自定义目录 AndAlso (list.Contains(0) OrElse list.Contains(4)) Then
                        启动MC服务器()
                        flag = True
                    End If
                    向Sftp服务器上传MC服务端备份文件()
                    MainForm.更新进度条("主任务", 90)
                    MainForm.更新进度条("主任务", 100)
                    MainForm.更新标签("分任务", "完成备份MC服务端任务")
                    Dim num4 = 配置文件操作模块.帧数 * 2
                    For j = 1 To num4
                        Thread.Sleep(配置文件操作模块.延时毫秒数)
                    Next
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    日志窗口.添加日志($"执行备份MC服务端任务时发生错误:{ex2.Message}", 2)
                    Call ProjectData.ClearProjectError()
                Finally
                    MainForm.更新标签("主任务", "无")
                    MainForm.更新进度条("主任务", 0)
                    MainForm.更新标签("分任务", "无")
                    MainForm.更新进度条("分任务", 0)
                End Try
                Try
                    MainForm.更新标签("主任务", "备份自定义目录")
                    MainForm.更新进度条("主任务", 0)
                    备份自定义目录()
                    MainForm.更新进度条("主任务", 50)
                    If Not flag AndAlso 配置文件操作模块.是否关服备份 AndAlso (list.Contains(0) OrElse list.Contains(4)) Then
                        启动MC服务器()
                        flag = True
                    End If
                    Sftp上传自定义备份文件()
                    MainForm.更新标签("主任务", "完成备份自定义目录任务")
                    MainForm.更新进度条("主任务", 100)
                    Dim num5 = 配置文件操作模块.帧数 * 2
                    For k = 1 To num5
                        Thread.Sleep(配置文件操作模块.延时毫秒数)
                    Next
                Catch ex3 As Exception
                    ProjectData.SetProjectError(ex3)
                    Dim ex4 = ex3
                    日志窗口.添加日志($"执行备份自定义文件夹任务时发生错误:{ex4.Message}", 2)
                    Call ProjectData.ClearProjectError()
                Finally
                    If Not flag AndAlso 配置文件操作模块.是否关服备份 AndAlso (list.Contains(0) OrElse list.Contains(4)) Then
                        启动MC服务器()
                    End If
                    MainForm.更新标签("主任务", "无")
                    MainForm.更新进度条("主任务", 0)
                    MainForm.更新标签("分任务", "无")
                    MainForm.更新进度条("分任务", 0)
                End Try
                配置文件操作模块.备份操作进行状态 = False
                配置文件操作模块.服务运行状态 = 服务运行状态
                MainForm.备份运行时更改控件状态(运行状态:=False)
            End Sub

            Private Function 检查执行备份的条件() As Boolean
                日志窗口.添加日志("正在检查配置是否正确可用", 5)
                Dim list As List(Of Boolean) = New List(Of Boolean)()
                If String.IsNullOrEmpty(配置文件操作模块.备份输出目录) Then
                    日志窗口.添加日志("备份输出目录不能为空", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                If 配置文件操作模块.是否控制MC服务端1 Then
                    list.Add(检查单个MC服务端的设置(配置文件操作模块.MC服务端1路径, 配置文件操作模块.RCON1地址, 配置文件操作模块.RCON1端口, 配置文件操作模块.RCON1密码, 配置文件操作模块.MC服务端1启动脚本名称, 1))
                End If
                If 配置文件操作模块.是否控制MC服务端2 Then
                    list.Add(检查单个MC服务端的设置(配置文件操作模块.MC服务端2路径, 配置文件操作模块.RCON2地址, 配置文件操作模块.RCON2端口, 配置文件操作模块.RCON2密码, 配置文件操作模块.MC服务端2启动脚本名称, 2))
                End If
                If 配置文件操作模块.是否控制MC服务端3 Then
                    list.Add(检查单个MC服务端的设置(配置文件操作模块.MC服务端3路径, 配置文件操作模块.RCON3地址, 配置文件操作模块.RCON3端口, 配置文件操作模块.RCON3密码, 配置文件操作模块.MC服务端3启动脚本名称, 3))
                End If
                If 配置文件操作模块.是否控制MC服务端4 Then
                    list.Add(检查单个MC服务端的设置(配置文件操作模块.MC服务端4路径, 配置文件操作模块.RCON4地址, 配置文件操作模块.RCON4端口, 配置文件操作模块.RCON4密码, 配置文件操作模块.MC服务端4启动脚本名称, 4))
                End If
                If 配置文件操作模块.是否控制MC服务端5 Then
                    list.Add(检查单个MC服务端的设置(配置文件操作模块.MC服务端5路径, 配置文件操作模块.RCON5地址, 配置文件操作模块.RCON5端口, 配置文件操作模块.RCON5密码, 配置文件操作模块.MC服务端5启动脚本名称, 5))
                End If
                If 配置文件操作模块.是否控制MC服务端6 Then
                    list.Add(检查单个MC服务端的设置(配置文件操作模块.MC服务端6路径, 配置文件操作模块.RCON6地址, 配置文件操作模块.RCON6端口, 配置文件操作模块.RCON6密码, 配置文件操作模块.MC服务端6启动脚本名称, 6))
                End If
                If 配置文件操作模块.是否控制MC服务端7 Then
                    list.Add(检查单个MC服务端的设置(配置文件操作模块.MC服务端7路径, 配置文件操作模块.RCON7地址, 配置文件操作模块.RCON7端口, 配置文件操作模块.RCON7密码, 配置文件操作模块.MC服务端7启动脚本名称, 7))
                End If
                If 配置文件操作模块.是否控制MC服务端8 Then
                    list.Add(检查单个MC服务端的设置(配置文件操作模块.MC服务端8路径, 配置文件操作模块.RCON8地址, 配置文件操作模块.RCON8端口, 配置文件操作模块.RCON8密码, 配置文件操作模块.MC服务端8启动脚本名称, 8))
                End If
                If 配置文件操作模块.是否控制MC服务端9 Then
                    list.Add(检查单个MC服务端的设置(配置文件操作模块.MC服务端9路径, 配置文件操作模块.RCON9地址, 配置文件操作模块.RCON9端口, 配置文件操作模块.RCON9密码, 配置文件操作模块.MC服务端9启动脚本名称, 9))
                End If
                If 配置文件操作模块.是否控制MC服务端10 Then
                    list.Add(检查单个MC服务端的设置(配置文件操作模块.MC服务端10路径, 配置文件操作模块.RCON10地址, 配置文件操作模块.RCON10端口, 配置文件操作模块.RCON10密码, 配置文件操作模块.MC服务端10启动脚本名称, 10))
                End If
                If 配置文件操作模块.Sftp1开关 Then
                    list.Add(检查单个Sftp服务器的设置(配置文件操作模块.Sftp1地址, 配置文件操作模块.Sftp1端口, 配置文件操作模块.Sftp1用户名, 配置文件操作模块.Sftp1密码, 1))
                End If
                If 配置文件操作模块.Sftp2开关 Then
                    list.Add(检查单个Sftp服务器的设置(配置文件操作模块.Sftp2地址, 配置文件操作模块.Sftp2端口, 配置文件操作模块.Sftp2用户名, 配置文件操作模块.Sftp2密码, 2))
                End If
                If 配置文件操作模块.Sftp3开关 Then
                    list.Add(检查单个Sftp服务器的设置(配置文件操作模块.Sftp3地址, 配置文件操作模块.Sftp3端口, 配置文件操作模块.Sftp3用户名, 配置文件操作模块.Sftp3密码, 3))
                End If
                If 配置文件操作模块.是否备份自定义目录 Then
                    If String.IsNullOrEmpty(配置文件操作模块.自定义备份目录) Then
                        日志窗口.添加日志("自定义目录不能为空", 2)
                        list.Add(item:=False)
                    Else
                        list.Add(item:=True)
                    End If
                    If Not Directory.Exists(配置文件操作模块.自定义备份目录) Then
                        日志窗口.添加日志("自定义目录不存在", 2)
                        list.Add(item:=False)
                    Else
                        list.Add(item:=True)
                    End If
                End If
                If Not File.Exists(配置文件操作模块.程序路径) Then
                    日志窗口.添加日志("7zip程序没了", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                If Not 配置文件操作模块.是否控制MC服务端1 AndAlso Not 配置文件操作模块.是否控制MC服务端2 AndAlso Not 配置文件操作模块.是否控制MC服务端3 AndAlso Not 配置文件操作模块.是否控制MC服务端3 AndAlso Not 配置文件操作模块.是否控制MC服务端4 AndAlso Not 配置文件操作模块.是否控制MC服务端5 AndAlso Not 配置文件操作模块.是否控制MC服务端6 AndAlso Not 配置文件操作模块.是否控制MC服务端7 AndAlso Not 配置文件操作模块.是否控制MC服务端8 AndAlso Not 配置文件操作模块.是否控制MC服务端9 AndAlso Not 配置文件操作模块.是否控制MC服务端10 AndAlso Not 配置文件操作模块.是否备份自定义目录 Then
                    日志窗口.添加日志("至少要控制一个MC服务端或备份一个自定义目录", 2)
                    日志窗口.添加日志("[前面的划掉][吐槽]我能干点啥呢(思索中)🤔😅😥😪😴😓😢😰", 0)
                    日志窗口.添加日志("[前面的划掉][吐槽]既然啥都不干", 0)
                    日志窗口.添加日志("[前面的划掉][吐槽]那就给你看风景吧", 0)
                    日志窗口.添加日志("[前面的划掉][吐槽]正在进入看风景模式(3秒),右下角按钮退出", 5)
                    MainForm.更新标签("分任务", "正在进入看风景模式(3秒)")
                    MainForm.更新进度条("分任务", 0)
                    Dim num = 3 * 配置文件操作模块.帧数
                    Dim num2 = 100.0 / num
                    Dim num3 = num
                    For i = 1 To num3
                        MainForm.更新进度条("分任务", If(CInt(Math.Round(num2 * i)) <= 100, Math.Round(num2 * i), 100))
                        Thread.Sleep(配置文件操作模块.延时毫秒数)
                    Next
                    MainForm.更新进度条("分任务", 100)
                    MainForm.看风景模式()
                    MainForm.更新标签("分任务", "无")
                    MainForm.更新进度条("分任务", 0)
                    list.Add(item:=False)
                End If
                If Not list.Contains(item:=False) Then
                    日志窗口.添加日志("真棒,配置完整且可用", 3)
                    Return True
                End If
                日志窗口.添加日志("配置不完整或不可用", 2)
                Return False
            End Function

            Private Function 检查单个MC服务端的设置(RCON地址 As String, RCON端口 As String, RCON密码 As String, 服务端路径 As String, 启动脚本名称 As String, 服务端序号 As Integer) As Boolean
                Dim list As List(Of Boolean) = New List(Of Boolean)()
                If String.IsNullOrEmpty(RCON地址) Then
                    日志窗口.添加日志($"MC服务端{服务端序号}的RCON地址不能为空", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                If String.IsNullOrEmpty(RCON端口) Then
                    日志窗口.添加日志($"MC服务端{服务端序号}的RCON端口不能为空", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                If String.IsNullOrEmpty(RCON密码) Then
                    日志窗口.添加日志($"MC服务端{服务端序号}的RCON密码不能为空", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                If String.IsNullOrEmpty(服务端路径) AndAlso Not Directory.Exists(服务端路径) Then
                    日志窗口.添加日志($"MC服务端{服务端序号}的路径为空/不存在", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                If String.IsNullOrEmpty(启动脚本名称) AndAlso Not File.Exists(Path.Combine(服务端路径, 启动脚本名称)) Then
                    日志窗口.添加日志($"MC服务端{服务端序号}的启动脚本名称为空/不存在", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                Return Not list.Contains(item:=False)
            End Function

            Private Function 检查单个Sftp服务器的设置(服务器地址 As String, 端口 As String, 用户名 As String, 密码 As String, 服务器序号 As Integer) As Boolean
                Dim list As List(Of Boolean) = New List(Of Boolean)()
                If String.IsNullOrEmpty(服务器地址) Then
                    日志窗口.添加日志($"SFTP服务器{服务器序号}的地址不能为空", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                If String.IsNullOrEmpty(端口) Then
                    日志窗口.添加日志($"SFTP服务器{服务器序号}的端口不能为空", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                If String.IsNullOrEmpty(用户名) Then
                    日志窗口.添加日志($"SFTP服务器{服务器序号}的用户名不能为空", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                If String.IsNullOrEmpty(密码) Then
                    日志窗口.添加日志($"SFTP服务器{服务器序号}的密码不能为空", 2)
                    list.Add(item:=False)
                Else
                    list.Add(item:=True)
                End If
                Return Not list.Contains(item:=False)
            End Function

            Private Sub RCON关闭MC服务器()
                MainForm.更新标签("分任务", "使用RCON通信关闭MC服务端")
                Dim list As List(Of Integer) = New List(Of Integer)()
                If 配置文件操作模块.是否控制MC服务端1 Then
                    list.Add(1)
                    MC服务端1运行状态 = RCON关闭单个MC服务器(配置文件操作模块.RCON1地址, 配置文件操作模块.RCON1端口, 配置文件操作模块.RCON1密码, 配置文件操作模块.MC服务端1路径, 1)
                End If
                If 配置文件操作模块.是否控制MC服务端2 Then
                    list.Add(2)
                    MC服务端2运行状态 = RCON关闭单个MC服务器(配置文件操作模块.RCON2地址, 配置文件操作模块.RCON2端口, 配置文件操作模块.RCON2密码, 配置文件操作模块.MC服务端2路径, 2)
                End If
                If 配置文件操作模块.是否控制MC服务端3 Then
                    list.Add(3)
                    MC服务端3运行状态 = RCON关闭单个MC服务器(配置文件操作模块.RCON3地址, 配置文件操作模块.RCON3端口, 配置文件操作模块.RCON3密码, 配置文件操作模块.MC服务端3路径, 3)
                End If
                If 配置文件操作模块.是否控制MC服务端4 Then
                    list.Add(4)
                    MC服务端4运行状态 = RCON关闭单个MC服务器(配置文件操作模块.RCON4地址, 配置文件操作模块.RCON4端口, 配置文件操作模块.RCON4密码, 配置文件操作模块.MC服务端4路径, 4)
                End If
                If 配置文件操作模块.是否控制MC服务端5 Then
                    list.Add(5)
                    MC服务端5运行状态 = RCON关闭单个MC服务器(配置文件操作模块.RCON5地址, 配置文件操作模块.RCON5端口, 配置文件操作模块.RCON5密码, 配置文件操作模块.MC服务端5路径, 5)
                End If
                If 配置文件操作模块.是否控制MC服务端6 Then
                    list.Add(6)
                    MC服务端6运行状态 = RCON关闭单个MC服务器(配置文件操作模块.RCON6地址, 配置文件操作模块.RCON6端口, 配置文件操作模块.RCON6密码, 配置文件操作模块.MC服务端6路径, 6)
                End If
                If 配置文件操作模块.是否控制MC服务端7 Then
                    list.Add(7)
                    MC服务端7运行状态 = RCON关闭单个MC服务器(配置文件操作模块.RCON7地址, 配置文件操作模块.RCON7端口, 配置文件操作模块.RCON7密码, 配置文件操作模块.MC服务端7路径, 7)
                End If
                If 配置文件操作模块.是否控制MC服务端8 Then
                    list.Add(8)
                    MC服务端8运行状态 = RCON关闭单个MC服务器(配置文件操作模块.RCON8地址, 配置文件操作模块.RCON8端口, 配置文件操作模块.RCON8密码, 配置文件操作模块.MC服务端8路径, 8)
                End If
                If 配置文件操作模块.是否控制MC服务端9 Then
                    list.Add(9)
                    MC服务端9运行状态 = RCON关闭单个MC服务器(配置文件操作模块.RCON9地址, 配置文件操作模块.RCON9端口, 配置文件操作模块.RCON9密码, 配置文件操作模块.MC服务端9路径, 9)
                End If
                If 配置文件操作模块.是否控制MC服务端10 Then
                    list.Add(10)
                    MC服务端10运行状态 = RCON关闭单个MC服务器(配置文件操作模块.RCON10地址, 配置文件操作模块.RCON10端口, 配置文件操作模块.RCON10密码, 配置文件操作模块.MC服务端10路径, 10)
                End If
                If list.Count = 0 Then
                    日志窗口.添加日志("没有控制中的MC服务器,已自动跳过", 1)
                End If
            End Sub

            Private Function RCON关闭单个MC服务器(地址 As String, 端口 As String, 密码 As String, 服务端路径 As String, 服务端序号 As Integer) As Integer
                处理单个RCON服务端.处理单个RCON服务端_关服(地址, Conversions.ToInteger(端口), 密码, Conversions.ToString(服务端序号))
                Dim selectedText As String = 日志处理模块.日志处理功能.获取最近日志文本()
                If selectedText.Contains($"MC服务器{服务端序号}指令返回信息:") And (selectedText.Contains("正在关闭服务器") OrElse selectedText.Contains("Stopping the server")) Then
                    日志窗口.添加日志($"RCON{服务端序号}通信成功,将备份MC服务端{服务端序号}", 3)
                    Return 0
                End If
                日志窗口.添加日志($"RCON{服务端序号}通信失败,将检测MC服务端{服务端序号}是否正在运行", 2)
                Select Case 检测单个服务端是否已启动(服务端路径, 服务端序号)
                    Case 1
                        日志窗口.添加日志($"RCON{服务端序号}通信失败,但检测到服务端已开启,停止备份MC服务端{服务端序号}", 2)
                        Return 1
                    Case 2
                        日志窗口.添加日志($"RCON{服务端序号}通信失败,但检测到服务端未开启,继续备份MC服务端{服务端序号}", 1)
                        Return 4
                    Case Else
                        日志窗口.添加日志($"RCON{服务端序号}通信失败,且无法判断服务端运行状态,停止备份MC服务端{服务端序号}", 2)
                        Return 1
                End Select
            End Function

            Private Sub RCON停止服务端自动保存()
                MainForm.更新标签("分任务", "使用RCON通信停止服务端自动保存")
                Dim list As List(Of Integer) = New List(Of Integer)()
                If 配置文件操作模块.是否控制MC服务端1 Then
                    list.Add(1)
                    MC服务端1运行状态 = RCON停止单个服务端自动保存(配置文件操作模块.RCON1地址, 配置文件操作模块.RCON1端口, 配置文件操作模块.RCON1密码, 配置文件操作模块.MC服务端1路径, 1)
                End If
                If 配置文件操作模块.是否控制MC服务端2 Then
                    list.Add(2)
                    MC服务端2运行状态 = RCON停止单个服务端自动保存(配置文件操作模块.RCON2地址, 配置文件操作模块.RCON2端口, 配置文件操作模块.RCON2密码, 配置文件操作模块.MC服务端2路径, 2)
                End If
                If 配置文件操作模块.是否控制MC服务端3 Then
                    list.Add(3)
                    MC服务端3运行状态 = RCON停止单个服务端自动保存(配置文件操作模块.RCON3地址, 配置文件操作模块.RCON3端口, 配置文件操作模块.RCON3密码, 配置文件操作模块.MC服务端3路径, 3)
                End If
                If 配置文件操作模块.是否控制MC服务端4 Then
                    list.Add(4)
                    MC服务端4运行状态 = RCON停止单个服务端自动保存(配置文件操作模块.RCON4地址, 配置文件操作模块.RCON4端口, 配置文件操作模块.RCON4密码, 配置文件操作模块.MC服务端4路径, 4)
                End If
                If 配置文件操作模块.是否控制MC服务端5 Then
                    list.Add(5)
                    MC服务端5运行状态 = RCON停止单个服务端自动保存(配置文件操作模块.RCON5地址, 配置文件操作模块.RCON5端口, 配置文件操作模块.RCON5密码, 配置文件操作模块.MC服务端5路径, 5)
                End If
                If 配置文件操作模块.是否控制MC服务端6 Then
                    list.Add(6)
                    MC服务端6运行状态 = RCON停止单个服务端自动保存(配置文件操作模块.RCON6地址, 配置文件操作模块.RCON6端口, 配置文件操作模块.RCON6密码, 配置文件操作模块.MC服务端6路径, 6)
                End If
                If 配置文件操作模块.是否控制MC服务端7 Then
                    list.Add(7)
                    MC服务端7运行状态 = RCON停止单个服务端自动保存(配置文件操作模块.RCON7地址, 配置文件操作模块.RCON7端口, 配置文件操作模块.RCON7密码, 配置文件操作模块.MC服务端7路径, 7)
                End If
                If 配置文件操作模块.是否控制MC服务端8 Then
                    list.Add(8)
                    MC服务端8运行状态 = RCON停止单个服务端自动保存(配置文件操作模块.RCON8地址, 配置文件操作模块.RCON8端口, 配置文件操作模块.RCON8密码, 配置文件操作模块.MC服务端8路径, 8)
                End If
                If 配置文件操作模块.是否控制MC服务端9 Then
                    list.Add(9)
                    MC服务端9运行状态 = RCON停止单个服务端自动保存(配置文件操作模块.RCON9地址, 配置文件操作模块.RCON9端口, 配置文件操作模块.RCON9密码, 配置文件操作模块.MC服务端9路径, 9)
                End If
                If 配置文件操作模块.是否控制MC服务端10 Then
                    list.Add(10)
                    MC服务端10运行状态 = RCON停止单个服务端自动保存(配置文件操作模块.RCON10地址, 配置文件操作模块.RCON10端口, 配置文件操作模块.RCON10密码, 配置文件操作模块.MC服务端10路径, 10)
                End If
                If list.Count = 0 Then
                    日志窗口.添加日志("没有控制中的MC服务器,已跳过备份MC服务端", 1)
                End If
            End Sub

            Private Function RCON停止单个服务端自动保存(地址 As String, 端口 As String, 密码 As String, 服务端路径 As String, 服务端序号 As Integer) As Integer
                处理单个RCON服务端.处理单个RCON服务端_停止自动保存(地址, Conversions.ToInteger(端口), 密码, Conversions.ToString(服务端序号))
                Dim selectedText As String = 日志处理模块.日志处理功能.获取最近日志文本()
                If selectedText.Contains("游戏已保存") OrElse selectedText.Contains("Saved the game") Then
                    日志窗口.添加日志($"RCON{服务端序号}通信成功,将备份MC服务端{服务端序号}", 3)
                    Return 2
                End If
                日志窗口.添加日志($"RCON{服务端序号}通信失败,将检测MC服务端{服务端序号}是否正在运行", 2)
                Select Case 检测单个服务端是否已启动(服务端路径, 服务端序号)
                    Case 1
                        日志窗口.添加日志($"检测到服务端已开启,停止备份MC服务端{服务端序号}", 2)
                        Return 3
                    Case 2
                        日志窗口.添加日志($"检测到服务端未开启,继续备份MC服务端{服务端序号}", 1)
                        Return 2
                    Case Else
                        日志窗口.添加日志($"无法判断服务端运行状态,停止备份MC服务端{服务端序号}", 2)
                        Return 3
                End Select
            End Function

            Private Sub RCON启用服务端自动保存()
                MainForm.更新标签("分任务", "使用RCON通信重新启用服务端自动保存")
                If 配置文件操作模块.是否控制MC服务端1 Then
                    If MC服务端1运行状态 = 2 Then
                        处理单个RCON服务端.处理单个RCON服务端_启用自动保存(配置文件操作模块.RCON1地址, Conversions.ToInteger(配置文件操作模块.RCON1端口), 配置文件操作模块.RCON1密码, Conversions.ToString(1))
                    Else
                        日志窗口.添加日志("MC服务端1未运行/之前已RCON通信失败,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端2 Then
                    If MC服务端2运行状态 = 2 Then
                        处理单个RCON服务端.处理单个RCON服务端_启用自动保存(配置文件操作模块.RCON2地址, Conversions.ToInteger(配置文件操作模块.RCON2端口), 配置文件操作模块.RCON2密码, Conversions.ToString(2))
                    Else
                        日志窗口.添加日志("MC服务端2未运行/之前已RCON通信失败,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端3 Then
                    If MC服务端3运行状态 = 2 Then
                        处理单个RCON服务端.处理单个RCON服务端_启用自动保存(配置文件操作模块.RCON3地址, Conversions.ToInteger(配置文件操作模块.RCON3端口), 配置文件操作模块.RCON3密码, Conversions.ToString(3))
                    Else
                        日志窗口.添加日志("MC服务端3未运行/之前已RCON通信失败,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端4 Then
                    If MC服务端4运行状态 = 2 Then
                        处理单个RCON服务端.处理单个RCON服务端_启用自动保存(配置文件操作模块.RCON4地址, Conversions.ToInteger(配置文件操作模块.RCON4端口), 配置文件操作模块.RCON4密码, Conversions.ToString(4))
                    Else
                        日志窗口.添加日志("MC服务端4未运行/之前已RCON通信失败,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端5 Then
                    If MC服务端5运行状态 = 2 Then
                        处理单个RCON服务端.处理单个RCON服务端_启用自动保存(配置文件操作模块.RCON5地址, Conversions.ToInteger(配置文件操作模块.RCON5端口), 配置文件操作模块.RCON5密码, Conversions.ToString(5))
                    Else
                        日志窗口.添加日志("MC服务端5未运行/之前已RCON通信失败,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端6 Then
                    If MC服务端6运行状态 = 2 Then
                        处理单个RCON服务端.处理单个RCON服务端_启用自动保存(配置文件操作模块.RCON6地址, Conversions.ToInteger(配置文件操作模块.RCON6端口), 配置文件操作模块.RCON6密码, Conversions.ToString(6))
                    Else
                        日志窗口.添加日志("MC服务端6未运行/之前已RCON通信失败,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端7 Then
                    If MC服务端7运行状态 = 2 Then
                        处理单个RCON服务端.处理单个RCON服务端_启用自动保存(配置文件操作模块.RCON7地址, Conversions.ToInteger(配置文件操作模块.RCON7端口), 配置文件操作模块.RCON7密码, Conversions.ToString(7))
                    Else
                        日志窗口.添加日志("MC服务端7未运行/之前已RCON通信失败,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端8 Then
                    If MC服务端8运行状态 = 2 Then
                        处理单个RCON服务端.处理单个RCON服务端_启用自动保存(配置文件操作模块.RCON8地址, Conversions.ToInteger(配置文件操作模块.RCON8端口), 配置文件操作模块.RCON8密码, Conversions.ToString(8))
                    Else
                        日志窗口.添加日志("MC服务端8未运行/之前已RCON通信失败,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端9 Then
                    If MC服务端9运行状态 = 2 Then
                        处理单个RCON服务端.处理单个RCON服务端_启用自动保存(配置文件操作模块.RCON9地址, Conversions.ToInteger(配置文件操作模块.RCON9端口), 配置文件操作模块.RCON9密码, Conversions.ToString(9))
                    Else
                        日志窗口.添加日志("MC服务端9未运行/之前已RCON通信失败,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端10 Then
                    If MC服务端10运行状态 = 2 Then
                        处理单个RCON服务端.处理单个RCON服务端_启用自动保存(配置文件操作模块.RCON10地址, Conversions.ToInteger(配置文件操作模块.RCON10端口), 配置文件操作模块.RCON10密码, Conversions.ToString(10))
                    Else
                        日志窗口.添加日志("MC服务端10未运行/之前已RCON通信失败,跳过", 1)
                    End If
                End If
            End Sub

            Private Sub 备份MC服务端()
                If 配置文件操作模块.是否增量备份 Then
                    Dim path = IO.Path.Combine(配置文件操作模块.备份输出目录, "增量备份")
                    If 配置文件操作模块.备份模式 Then
                        If 配置文件操作模块.是否控制MC服务端1 Then
                            If MC服务端1运行状态 = 0 OrElse MC服务端1运行状态 = 2 OrElse MC服务端1运行状态 = 4 Then
                                MC服务端1备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.MC服务端1路径, IO.Path.Combine(path, "MC服务端1备份", "仅备份文件变化部分模式"), 配置文件操作模块.备份MC服务端1排除文件参数, 1))
                            Else
                                日志窗口.添加日志("MC服务端1(关服/停止自动保存操作失败）,跳过", 1)
                            End If
                        End If
                        If 配置文件操作模块.是否控制MC服务端2 Then
                            If MC服务端2运行状态 = 0 OrElse MC服务端2运行状态 = 2 OrElse MC服务端2运行状态 = 4 Then
                                MC服务端2备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.MC服务端2路径, IO.Path.Combine(path, "MC服务端2备份", "仅备份文件变化部分模式"), 配置文件操作模块.备份MC服务端2排除文件参数, 2))
                            Else
                                日志窗口.添加日志("MC服务端2(关服/停止自动保存操作失败）,跳过", 1)
                            End If
                        End If
                        If 配置文件操作模块.是否控制MC服务端3 Then
                            If MC服务端3运行状态 = 0 OrElse MC服务端3运行状态 = 2 OrElse MC服务端3运行状态 = 4 Then
                                MC服务端3备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.MC服务端3路径, IO.Path.Combine(path, "MC服务端3备份", "仅备份文件变化部分模式"), 配置文件操作模块.备份MC服务端3排除文件参数, 3))
                            Else
                                日志窗口.添加日志("MC服务端3(关服/停止自动保存操作失败）,跳过", 1)
                            End If
                        End If
                        If 配置文件操作模块.是否控制MC服务端4 Then
                            If MC服务端4运行状态 = 0 OrElse MC服务端4运行状态 = 2 OrElse MC服务端4运行状态 = 4 Then
                                MC服务端4备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.MC服务端4路径, IO.Path.Combine(path, "MC服务端4备份", "仅备份文件变化部分模式"), 配置文件操作模块.备份MC服务端4排除文件参数, 4))
                            Else
                                日志窗口.添加日志("MC服务端4(关服/停止自动保存操作失败）,跳过", 1)
                            End If
                        End If
                        If 配置文件操作模块.是否控制MC服务端5 Then
                            If MC服务端5运行状态 = 0 OrElse MC服务端5运行状态 = 2 OrElse MC服务端5运行状态 = 4 Then
                                MC服务端5备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.MC服务端5路径, IO.Path.Combine(path, "MC服务端5备份", "仅备份文件变化部分模式"), 配置文件操作模块.备份MC服务端5排除文件参数, 5))
                            Else
                                日志窗口.添加日志("MC服务端5(关服/停止自动保存操作失败）,跳过", 1)
                            End If
                        End If
                        If 配置文件操作模块.是否控制MC服务端6 Then
                            If MC服务端6运行状态 = 0 OrElse MC服务端6运行状态 = 2 OrElse MC服务端6运行状态 = 4 Then
                                MC服务端6备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.MC服务端6路径, IO.Path.Combine(path, "MC服务端6备份", "仅备份文件变化部分模式"), 配置文件操作模块.备份MC服务端6排除文件参数, 6))
                            Else
                                日志窗口.添加日志("MC服务端6(关服/停止自动保存操作失败）,跳过", 1)
                            End If
                        End If
                        If 配置文件操作模块.是否控制MC服务端7 Then
                            If MC服务端7运行状态 = 0 OrElse MC服务端7运行状态 = 2 OrElse MC服务端7运行状态 = 4 Then
                                MC服务端7备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.MC服务端7路径, IO.Path.Combine(path, "MC服务端7备份", "仅备份文件变化部分模式"), 配置文件操作模块.备份MC服务端7排除文件参数, 7))
                            Else
                                日志窗口.添加日志("MC服务端7(关服/停止自动保存操作失败）,跳过", 1)
                            End If
                        End If
                        If 配置文件操作模块.是否控制MC服务端8 Then
                            If MC服务端8运行状态 = 0 OrElse MC服务端8运行状态 = 2 OrElse MC服务端8运行状态 = 4 Then
                                MC服务端8备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.MC服务端8路径, IO.Path.Combine(path, "MC服务端8备份", "仅备份文件变化部分模式"), 配置文件操作模块.备份MC服务端8排除文件参数, 8))
                            Else
                                日志窗口.添加日志("MC服务端8(关服/停止自动保存操作失败）,跳过", 1)
                            End If
                        End If
                        If 配置文件操作模块.是否控制MC服务端9 Then
                            If MC服务端9运行状态 = 0 OrElse MC服务端9运行状态 = 2 OrElse MC服务端9运行状态 = 4 Then
                                MC服务端9备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.MC服务端9路径, IO.Path.Combine(path, "MC服务端9备份", "仅备份文件变化部分模式"), 配置文件操作模块.备份MC服务端9排除文件参数, 9))
                            Else
                                日志窗口.添加日志("MC服务端9(关服/停止自动保存操作失败）,跳过", 1)
                            End If
                        End If
                        If 配置文件操作模块.是否控制MC服务端10 Then
                            If MC服务端10运行状态 = 0 OrElse MC服务端10运行状态 = 2 OrElse MC服务端10运行状态 = 4 Then
                                MC服务端10备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.MC服务端10路径, IO.Path.Combine(path, "MC服务端10备份", "仅备份文件变化部分模式"), 配置文件操作模块.备份MC服务端10排除文件参数, 10))
                            Else
                                日志窗口.添加日志("MC服务端10(关服/停止自动保存操作失败）,跳过", 1)
                            End If
                        End If
                        Return
                    End If
                    Dim 增量备份器_完整文件 As 完整文件增量或完整备份模块.增量备份器_完整文件 = New 完整文件增量或完整备份模块.增量备份器_完整文件()
                    If 配置文件操作模块.是否控制MC服务端1 Then
                        If MC服务端1运行状态 = 0 OrElse MC服务端1运行状态 = 2 OrElse MC服务端1运行状态 = 4 Then
                            MC服务端1备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.MC服务端1路径, IO.Path.Combine(path, "MC服务端1备份", "备份整个文件模式"), "MC服务端1", 配置文件操作模块.备份MC服务端1排除文件参数, 1)
                        Else
                            日志窗口.添加日志("MC服务端1(关服/停止自动保存操作失败）,跳过", 1)
                        End If
                    End If
                    If 配置文件操作模块.是否控制MC服务端2 Then
                        If MC服务端2运行状态 = 0 OrElse MC服务端2运行状态 = 2 OrElse MC服务端2运行状态 = 4 Then
                            MC服务端2备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.MC服务端2路径, IO.Path.Combine(path, "MC服务端2备份", "备份整个文件模式"), "MC服务端2", 配置文件操作模块.备份MC服务端2排除文件参数, 2)
                        Else
                            日志窗口.添加日志("MC服务端2(关服/停止自动保存操作失败）,跳过", 1)
                        End If
                    End If
                    If 配置文件操作模块.是否控制MC服务端3 Then
                        If MC服务端3运行状态 = 0 OrElse MC服务端3运行状态 = 2 OrElse MC服务端3运行状态 = 4 Then
                            MC服务端3备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.MC服务端3路径, IO.Path.Combine(path, "MC服务端3备份", "备份整个文件模式"), "MC服务端3", 配置文件操作模块.备份MC服务端3排除文件参数, 3)
                        Else
                            日志窗口.添加日志("MC服务端3(关服/停止自动保存操作失败）,跳过", 1)
                        End If
                    End If
                    If 配置文件操作模块.是否控制MC服务端4 Then
                        If MC服务端4运行状态 = 0 OrElse MC服务端4运行状态 = 2 OrElse MC服务端4运行状态 = 4 Then
                            MC服务端4备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.MC服务端4路径, IO.Path.Combine(path, "MC服务端4备份", "备份整个文件模式"), "MC服务端4", 配置文件操作模块.备份MC服务端4排除文件参数, 4)
                        Else
                            日志窗口.添加日志("MC服务端4(关服/停止自动保存操作失败）,跳过", 1)
                        End If
                    End If
                    If 配置文件操作模块.是否控制MC服务端5 Then
                        If MC服务端5运行状态 = 0 OrElse MC服务端5运行状态 = 2 OrElse MC服务端5运行状态 = 4 Then
                            MC服务端5备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.MC服务端5路径, IO.Path.Combine(path, "MC服务端5备份", "备份整个文件模式"), "MC服务端5", 配置文件操作模块.备份MC服务端5排除文件参数, 5)
                        Else
                            日志窗口.添加日志("MC服务端5(关服/停止自动保存操作失败）,跳过", 1)
                        End If
                    End If
                    If 配置文件操作模块.是否控制MC服务端6 Then
                        If MC服务端6运行状态 = 0 OrElse MC服务端6运行状态 = 2 OrElse MC服务端6运行状态 = 4 Then
                            MC服务端6备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.MC服务端6路径, IO.Path.Combine(path, "MC服务端6备份", "备份整个文件模式"), "MC服务端6", 配置文件操作模块.备份MC服务端6排除文件参数, 6)
                        Else
                            日志窗口.添加日志("MC服务端6(关服/停止自动保存操作失败）,跳过", 1)
                        End If
                    End If
                    If 配置文件操作模块.是否控制MC服务端7 Then
                        If MC服务端7运行状态 = 0 OrElse MC服务端7运行状态 = 2 OrElse MC服务端7运行状态 = 4 Then
                            MC服务端7备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.MC服务端7路径, IO.Path.Combine(path, "MC服务端7备份", "备份整个文件模式"), "MC服务端7", 配置文件操作模块.备份MC服务端7排除文件参数, 7)
                        Else
                            日志窗口.添加日志("MC服务端7(关服/停止自动保存操作失败）,跳过", 1)
                        End If
                    End If
                    If 配置文件操作模块.是否控制MC服务端8 Then
                        If MC服务端8运行状态 = 0 OrElse MC服务端8运行状态 = 2 OrElse MC服务端8运行状态 = 4 Then
                            MC服务端8备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.MC服务端8路径, IO.Path.Combine(path, "MC服务端8备份", "备份整个文件模式"), "MC服务端8", 配置文件操作模块.备份MC服务端8排除文件参数, 8)
                        Else
                            日志窗口.添加日志("MC服务端8(关服/停止自动保存操作失败）,跳过", 1)
                        End If
                    End If
                    If 配置文件操作模块.是否控制MC服务端9 Then
                        If MC服务端9运行状态 = 0 OrElse MC服务端9运行状态 = 2 OrElse MC服务端9运行状态 = 4 Then
                            MC服务端9备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.MC服务端9路径, IO.Path.Combine(path, "MC服务端9备份", "备份整个文件模式"), "MC服务端9", 配置文件操作模块.备份MC服务端9排除文件参数, 9)
                        Else
                            日志窗口.添加日志("MC服务端9(关服/停止自动保存操作失败）,跳过", 1)
                        End If
                    End If
                    If 配置文件操作模块.是否控制MC服务端10 Then
                        If MC服务端10运行状态 = 0 OrElse MC服务端10运行状态 = 2 OrElse MC服务端10运行状态 = 4 Then
                            MC服务端10备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.MC服务端10路径, IO.Path.Combine(path, "MC服务端10备份", "备份整个文件模式"), "MC服务端10", 配置文件操作模块.备份MC服务端10排除文件参数, 10)
                        Else
                            日志窗口.添加日志("MC服务端10(关服/停止自动保存操作失败）,跳过", 1)
                        End If
                    End If
                    Return
                End If
                Dim path2 = Path.Combine(配置文件操作模块.备份输出目录, "完整备份")
                Dim 完整备份器 As 完整文件增量或完整备份模块.完整备份器 = New 完整文件增量或完整备份模块.完整备份器()
                If 配置文件操作模块.是否控制MC服务端1 Then
                    If MC服务端1运行状态 = 0 OrElse MC服务端1运行状态 = 2 OrElse MC服务端1运行状态 = 4 Then
                        MC服务端1备份状态 = 完整备份器.执行完整备份(配置文件操作模块.MC服务端1路径, Path.Combine(path2, "MC服务端1备份"), "MC服务端1", 配置文件操作模块.备份MC服务端1排除文件参数, 1)
                    Else
                        日志窗口.添加日志("MC服务端1(关服/停止自动保存操作失败）,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端2 Then
                    If MC服务端2运行状态 = 0 OrElse MC服务端2运行状态 = 2 OrElse MC服务端2运行状态 = 4 Then
                        MC服务端2备份状态 = 完整备份器.执行完整备份(配置文件操作模块.MC服务端2路径, Path.Combine(path2, "MC服务端2备份"), "MC服务端2", 配置文件操作模块.备份MC服务端2排除文件参数, 2)
                    Else
                        日志窗口.添加日志("MC服务端2(关服/停止自动保存操作失败）,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端3 Then
                    If MC服务端3运行状态 = 0 OrElse MC服务端3运行状态 = 2 OrElse MC服务端3运行状态 = 4 Then
                        MC服务端3备份状态 = 完整备份器.执行完整备份(配置文件操作模块.MC服务端3路径, Path.Combine(path2, "MC服务端3备份"), "MC服务端3", 配置文件操作模块.备份MC服务端3排除文件参数, 3)
                    Else
                        日志窗口.添加日志("MC服务端3(关服/停止自动保存操作失败）,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端4 Then
                    If MC服务端4运行状态 = 0 OrElse MC服务端4运行状态 = 2 OrElse MC服务端4运行状态 = 4 Then
                        MC服务端4备份状态 = 完整备份器.执行完整备份(配置文件操作模块.MC服务端4路径, Path.Combine(path2, "MC服务端4备份"), "MC服务端4", 配置文件操作模块.备份MC服务端4排除文件参数, 4)
                    Else
                        日志窗口.添加日志("MC服务端4(关服/停止自动保存操作失败）,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端5 Then
                    If MC服务端5运行状态 = 0 OrElse MC服务端5运行状态 = 2 OrElse MC服务端5运行状态 = 4 Then
                        MC服务端5备份状态 = 完整备份器.执行完整备份(配置文件操作模块.MC服务端5路径, Path.Combine(path2, "MC服务端5备份"), "MC服务端5", 配置文件操作模块.备份MC服务端5排除文件参数, 5)
                    Else
                        日志窗口.添加日志("MC服务端5(关服/停止自动保存操作失败）,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端6 Then
                    If MC服务端6运行状态 = 0 OrElse MC服务端6运行状态 = 2 OrElse MC服务端6运行状态 = 4 Then
                        MC服务端6备份状态 = 完整备份器.执行完整备份(配置文件操作模块.MC服务端6路径, Path.Combine(path2, "MC服务端6备份"), "MC服务端6", 配置文件操作模块.备份MC服务端6排除文件参数, 6)
                    Else
                        日志窗口.添加日志("MC服务端6(关服/停止自动保存操作失败）,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端7 Then
                    If MC服务端7运行状态 = 0 OrElse MC服务端7运行状态 = 2 OrElse MC服务端7运行状态 = 4 Then
                        MC服务端7备份状态 = 完整备份器.执行完整备份(配置文件操作模块.MC服务端7路径, Path.Combine(path2, "MC服务端7备份"), "MC服务端7", 配置文件操作模块.备份MC服务端7排除文件参数, 7)
                    Else
                        日志窗口.添加日志("MC服务端7(关服/停止自动保存操作失败）,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端8 Then
                    If MC服务端8运行状态 = 0 OrElse MC服务端8运行状态 = 2 OrElse MC服务端8运行状态 = 4 Then
                        MC服务端8备份状态 = 完整备份器.执行完整备份(配置文件操作模块.MC服务端8路径, Path.Combine(path2, "MC服务端8备份"), "MC服务端8", 配置文件操作模块.备份MC服务端8排除文件参数, 8)
                    Else
                        日志窗口.添加日志("MC服务端8(关服/停止自动保存操作失败）,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端9 Then
                    If MC服务端9运行状态 = 0 OrElse MC服务端9运行状态 = 2 OrElse MC服务端9运行状态 = 4 Then
                        MC服务端9备份状态 = 完整备份器.执行完整备份(配置文件操作模块.MC服务端9路径, Path.Combine(path2, "MC服务端9备份"), "MC服务端9", 配置文件操作模块.备份MC服务端9排除文件参数, 9)
                    Else
                        日志窗口.添加日志("MC服务端9(关服/停止自动保存操作失败）,跳过", 1)
                    End If
                End If
                If 配置文件操作模块.是否控制MC服务端10 Then
                    If MC服务端10运行状态 = 0 OrElse MC服务端10运行状态 = 2 OrElse MC服务端10运行状态 = 4 Then
                        MC服务端10备份状态 = 完整备份器.执行完整备份(配置文件操作模块.MC服务端10路径, Path.Combine(path2, "MC服务端10备份"), "MC服务端10", 配置文件操作模块.备份MC服务端10排除文件参数, 10)
                    Else
                        日志窗口.添加日志("MC服务端10(关服/停止自动保存操作失败）,跳过", 1)
                    End If
                End If
            End Sub

            Private Sub 备份自定义目录()
                If 配置文件操作模块.是否备份自定义目录 Then
                    If 配置文件操作模块.是否增量备份 Then
                        If 配置文件操作模块.备份模式 Then
                            自定义备份目录备份状态 = Conversions.ToBoolean(仅变化部分增量备份模块.增量备份并压缩文件夹(配置文件操作模块.自定义备份目录, Path.Combine(配置文件操作模块.备份输出目录, "增量备份", "自定义备份目录", "仅备份文件变化部分模式"), 配置文件操作模块.自定义备份目录排除文件参数))
                            Return
                        End If
                        Dim 增量备份器_完整文件 As 完整文件增量或完整备份模块.增量备份器_完整文件 = New 完整文件增量或完整备份模块.增量备份器_完整文件()
                        自定义备份目录备份状态 = 增量备份器_完整文件.执行增量备份(配置文件操作模块.自定义备份目录, Path.Combine(配置文件操作模块.备份输出目录, "增量备份", "自定义备份目录", "备份整个文件模式"), "自定义备份目录", 配置文件操作模块.自定义备份目录排除文件参数)
                    Else
                        Dim 完整备份器 As 完整文件增量或完整备份模块.完整备份器 = New 完整文件增量或完整备份模块.完整备份器()
                        自定义备份目录备份状态 = 完整备份器.执行完整备份(配置文件操作模块.自定义备份目录, Path.Combine(配置文件操作模块.备份输出目录, "完整备份", "自定义备份目录", "备份整个文件模式"), "自定义备份目录", 配置文件操作模块.自定义备份目录排除文件参数)
                    End If
                Else
                    日志窗口.添加日志("未启用自定义目录备份,跳过", 0)
                End If
            End Sub

            Public Sub 启动MC服务器()
                MainForm.更新标签("分任务", "启动所有已启用的MC服务端")
                MainForm.更新进度条("分任务", 10)
                Dim list As List(Of Integer) = New List(Of Integer)()
                If 配置文件操作模块.是否控制MC服务端1 AndAlso 检测单个服务端是否已启动(配置文件操作模块.MC服务端1路径, 1) = 2 Then
                    启动单个MC服务器(Conversions.ToString(1))
                    list.Add(1)
                End If
                If 配置文件操作模块.是否控制MC服务端2 AndAlso 检测单个服务端是否已启动(配置文件操作模块.MC服务端2路径, 2) = 2 Then
                    启动单个MC服务器(Conversions.ToString(2))
                    list.Add(2)
                End If
                If 配置文件操作模块.是否控制MC服务端3 AndAlso 检测单个服务端是否已启动(配置文件操作模块.MC服务端3路径, 3) = 2 Then
                    启动单个MC服务器(Conversions.ToString(3))
                    list.Add(3)
                End If
                If 配置文件操作模块.是否控制MC服务端4 AndAlso 检测单个服务端是否已启动(配置文件操作模块.MC服务端4路径, 4) = 2 Then
                    启动单个MC服务器(Conversions.ToString(4))
                    list.Add(4)
                End If
                If 配置文件操作模块.是否控制MC服务端5 AndAlso 检测单个服务端是否已启动(配置文件操作模块.MC服务端5路径, 5) = 2 Then
                    启动单个MC服务器(Conversions.ToString(5))
                    list.Add(5)
                End If
                If 配置文件操作模块.是否控制MC服务端6 AndAlso 检测单个服务端是否已启动(配置文件操作模块.MC服务端6路径, 6) = 2 Then
                    启动单个MC服务器(Conversions.ToString(6))
                    list.Add(6)
                End If
                If 配置文件操作模块.是否控制MC服务端7 AndAlso 检测单个服务端是否已启动(配置文件操作模块.MC服务端7路径, 7) = 2 Then
                    启动单个MC服务器(Conversions.ToString(7))
                    list.Add(7)
                End If
                If 配置文件操作模块.是否控制MC服务端8 AndAlso 检测单个服务端是否已启动(配置文件操作模块.MC服务端8路径, 8) = 2 Then
                    启动单个MC服务器(Conversions.ToString(8))
                    list.Add(8)
                End If
                If 配置文件操作模块.是否控制MC服务端9 AndAlso 检测单个服务端是否已启动(配置文件操作模块.MC服务端9路径, 9) = 2 Then
                    启动单个MC服务器(Conversions.ToString(9))
                    list.Add(9)
                End If
                If 配置文件操作模块.是否控制MC服务端10 AndAlso 检测单个服务端是否已启动(配置文件操作模块.MC服务端10路径, 10) = 2 Then
                    启动单个MC服务器(Conversions.ToString(10))
                    list.Add(10)
                End If
                If list.Count > 0 Then
                    日志窗口.添加日志("所有已启用的MC服务端已启动", 3)
                    Dim i = 0

                    While i * 配置文件操作模块.延时毫秒数 < 1000
                        Thread.Sleep(配置文件操作模块.延时毫秒数)
                        i += 1
                    End While
                Else
                    日志窗口.添加日志("没有已启用的MC服务端或没有启动成功的服务端", 1)
                End If
                MainForm.更新标签("主任务", "无")
                MainForm.更新进度条("主任务", 0)
                MainForm.更新标签("分任务", "无")
                MainForm.更新进度条("分任务", 0)
            End Sub

            Private Sub 启动单个MC服务器(服务器序号 As String)
                日志窗口.添加日志($"正在启动MC服务器{服务器序号}", 5)
                Dim text = ""
                Dim path = ""
                If Operators.CompareString(服务器序号, Conversions.ToString(1), TextCompare:=False) = 0 Then
                    text = 配置文件操作模块.MC服务端1路径
                    path = 配置文件操作模块.MC服务端1启动脚本名称
                ElseIf Operators.CompareString(服务器序号, Conversions.ToString(2), TextCompare:=False) = 0 Then
                    text = 配置文件操作模块.MC服务端2路径
                    path = 配置文件操作模块.MC服务端2启动脚本名称
                ElseIf Operators.CompareString(服务器序号, Conversions.ToString(3), TextCompare:=False) = 0 Then
                    text = 配置文件操作模块.MC服务端3路径
                    path = 配置文件操作模块.MC服务端3启动脚本名称
                ElseIf Operators.CompareString(服务器序号, Conversions.ToString(4), TextCompare:=False) = 0 Then
                    text = 配置文件操作模块.MC服务端4路径
                    path = 配置文件操作模块.MC服务端4启动脚本名称
                ElseIf Operators.CompareString(服务器序号, Conversions.ToString(5), TextCompare:=False) = 0 Then
                    text = 配置文件操作模块.MC服务端5路径
                    path = 配置文件操作模块.MC服务端5启动脚本名称
                ElseIf Operators.CompareString(服务器序号, Conversions.ToString(6), TextCompare:=False) = 0 Then
                    text = 配置文件操作模块.MC服务端6路径
                    path = 配置文件操作模块.MC服务端6启动脚本名称
                ElseIf Operators.CompareString(服务器序号, Conversions.ToString(7), TextCompare:=False) = 0 Then
                    text = 配置文件操作模块.MC服务端7路径
                    path = 配置文件操作模块.MC服务端7启动脚本名称
                ElseIf Operators.CompareString(服务器序号, Conversions.ToString(8), TextCompare:=False) = 0 Then
                    text = 配置文件操作模块.MC服务端8路径
                    path = 配置文件操作模块.MC服务端8启动脚本名称
                ElseIf Operators.CompareString(服务器序号, Conversions.ToString(9), TextCompare:=False) = 0 Then
                    text = 配置文件操作模块.MC服务端9路径
                    path = 配置文件操作模块.MC服务端9启动脚本名称
                ElseIf Operators.CompareString(服务器序号, Conversions.ToString(10), TextCompare:=False) = 0 Then
                    text = 配置文件操作模块.MC服务端10路径
                    path = 配置文件操作模块.MC服务端10启动脚本名称
                End If
                Try
                    Dim process As Process = New Process()
                    process.StartInfo.FileName = IO.Path.Combine(text, path)
                    process.StartInfo.WorkingDirectory = text
                    process.StartInfo.UseShellExecute = True
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                    process.Start()
                    日志窗口.添加日志($"MC服务器{服务器序号}已成功启动", 3)
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    日志窗口.添加日志($"启动MC服务器{服务器序号}时发生异常：{ex2.Message}", 2)
                    Call ProjectData.ClearProjectError()
                End Try
            End Sub

            Private Sub 向Sftp服务器上传MC服务端备份文件()
                MainForm.更新标签("主任务", " 向Sftp服务器上传MC服务端备份文件")
                Dim list As List(Of Integer) = New List(Of Integer)()
                If 配置文件操作模块.Sftp1开关 Then
                    list.Add(1)
                End If
                If 配置文件操作模块.Sftp2开关 Then
                    list.Add(2)
                End If
                If 配置文件操作模块.Sftp3开关 Then
                    list.Add(3)
                End If
                If list.Count = 0 Then
                    日志窗口.添加日志("没有启用的Sftp服务器,跳过向Sftp服务器上传MC服务端备份文件", 1)
                    Return
                End If
                Dim m As String
                Dim m2 As String
                If 配置文件操作模块.是否增量备份 Then
                    m = "增量备份"
                    m2 = If(Not 配置文件操作模块.备份模式, "备份整个文件模式", "仅备份文件变化部分模式")
                Else
                    m = "完整备份"
                    m2 = ""
                End If
                向Sftp服务器上传MC服务端备份文件_(m, m2)
            End Sub

            Private Sub 向Sftp服务器上传MC服务端备份文件_(m As String, m1 As String)
                If 配置文件操作模块.是否控制MC服务端1 AndAlso MC服务端1备份状态 Then
                    多个Sftp上传单个MC服务端备份文件(Conversions.ToString(1), m, m1)
                End If
                If 配置文件操作模块.是否控制MC服务端2 AndAlso MC服务端2备份状态 Then
                    多个Sftp上传单个MC服务端备份文件(Conversions.ToString(2), m, m1)
                End If
                If 配置文件操作模块.是否控制MC服务端3 AndAlso MC服务端3备份状态 Then
                    多个Sftp上传单个MC服务端备份文件(Conversions.ToString(3), m, m1)
                End If
                If 配置文件操作模块.是否控制MC服务端4 AndAlso MC服务端4备份状态 Then
                    多个Sftp上传单个MC服务端备份文件(Conversions.ToString(4), m, m1)
                End If
                If 配置文件操作模块.是否控制MC服务端5 AndAlso MC服务端5备份状态 Then
                    多个Sftp上传单个MC服务端备份文件(Conversions.ToString(5), m, m1)
                End If
                If 配置文件操作模块.是否控制MC服务端6 AndAlso MC服务端6备份状态 Then
                    多个Sftp上传单个MC服务端备份文件(Conversions.ToString(6), m, m1)
                End If
                If 配置文件操作模块.是否控制MC服务端7 AndAlso MC服务端7备份状态 Then
                    多个Sftp上传单个MC服务端备份文件(Conversions.ToString(7), m, m1)
                End If
                If 配置文件操作模块.是否控制MC服务端8 AndAlso MC服务端8备份状态 Then
                    多个Sftp上传单个MC服务端备份文件(Conversions.ToString(8), m, m1)
                End If
                If 配置文件操作模块.是否控制MC服务端9 AndAlso MC服务端9备份状态 Then
                    多个Sftp上传单个MC服务端备份文件(Conversions.ToString(9), m, m1)
                End If
                If 配置文件操作模块.是否控制MC服务端10 AndAlso MC服务端10备份状态 Then
                    多个Sftp上传单个MC服务端备份文件(Conversions.ToString(10), m, m1)
                End If
            End Sub

            Private Sub 多个Sftp上传单个MC服务端备份文件(MC服务端序号 As String, 备份模式 As String, 增量备份模式 As String)
                日志窗口.添加日志($"正在上传MC服务端{MC服务端序号}的备份文件", 5)
                Dim 本地文件路径 As String
                Dim 远程目录 As String
                If String.IsNullOrEmpty(增量备份模式) Then
                    Dim text = Path.Combine(配置文件操作模块.备份输出目录, 备份模式, $"MC服务端{MC服务端序号}备份")
                    本地文件路径 = Path.Combine(text, $"MC服务端{MC服务端序号}的{备份模式}_{读取上次备份时间(text):yyyyMMdd-HHmmss}.{配置文件操作模块.压缩格式}")
                    远程目录 = $"/备份/{备份模式}/MC服务端{MC服务端序号}备份"
                Else
                    Dim text = Path.Combine(配置文件操作模块.备份输出目录, 备份模式, $"MC服务端{MC服务端序号}备份", 增量备份模式)
                    本地文件路径 = Path.Combine(text, $"MC服务端{MC服务端序号}的{备份模式}({增量备份模式})_{读取上次备份时间(text):yyyyMMdd-HHmmss}.{配置文件操作模块.压缩格式}")
                    远程目录 = $"/备份/{备份模式}/MC服务端{MC服务端序号}备份/{增量备份模式}"
                End If
                日志窗口.添加日志($"待上传的本地备份文件: {本地文件路径}", 4)
                日志窗口.添加日志($"远程备份目录: {远程目录}", 4)
                If 配置文件操作模块.Sftp1开关 Then
                    处理单个Sftp服务端功能.处理单个Sftp服务端_上传文件(配置文件操作模块.Sftp1地址, 配置文件操作模块.Sftp1端口, 配置文件操作模块.Sftp1用户名, 配置文件操作模块.Sftp1密码, "1", 本地文件路径, 远程目录)
                End If
                If 配置文件操作模块.Sftp2开关 Then
                    处理单个Sftp服务端功能.处理单个Sftp服务端_上传文件(配置文件操作模块.Sftp2地址, 配置文件操作模块.Sftp2端口, 配置文件操作模块.Sftp2用户名, 配置文件操作模块.Sftp2密码, "2", 本地文件路径, 远程目录)
                End If
                If 配置文件操作模块.Sftp3开关 Then
                    处理单个Sftp服务端功能.处理单个Sftp服务端_上传文件(配置文件操作模块.Sftp3地址, 配置文件操作模块.Sftp3端口, 配置文件操作模块.Sftp3用户名, 配置文件操作模块.Sftp3密码, "3", 本地文件路径, 远程目录)
                End If
            End Sub

            Private Sub Sftp上传自定义备份文件()
                MainForm.更新标签("主任务", " 向Sftp服务器上传自定义备份文件夹的备份文件")
                If Not 配置文件操作模块.是否备份自定义目录 Then
                    Return
                End If
                If 自定义备份目录备份状态 Then
                    日志窗口.添加日志("正在上传自定义备份目录的备份文件", 5)
                    Dim list As List(Of Integer) = New List(Of Integer)()
                    If 配置文件操作模块.Sftp1开关 Then
                        list.Add(1)
                    End If
                    If 配置文件操作模块.Sftp2开关 Then
                        list.Add(2)
                    End If
                    If 配置文件操作模块.Sftp3开关 Then
                        list.Add(3)
                    End If
                    If list.Count = 0 Then
                        日志窗口.添加日志("没有启用的Sftp服务器,跳过向Sftp服务器上传自定义目录备份文件", 1)
                        Return
                    End If
                    Dim 本地文件路径 As String
                    Dim 远程目录 As String
                    If 配置文件操作模块.是否增量备份 Then
                        Dim text = "增量备份"
                        Dim text2 = If(Not 配置文件操作模块.备份模式, "备份整个文件模式", "仅备份文件变化部分模式")
                        Dim text3 = Path.Combine(配置文件操作模块.备份输出目录, text, "自定义备份目录", text2)
                        本地文件路径 = Path.Combine(text3, $"自定义备份目录的{text}({text2})_{读取上次备份时间(text3):yyyyMMdd-HHmmss}.{配置文件操作模块.压缩格式}")
                        远程目录 = $"/备份/{text}/自定义备份目录/{text2}"
                    Else
                        Dim text = "完整备份"
                        Dim text3 = Path.Combine(配置文件操作模块.备份输出目录, text, "自定义备份目录")
                        本地文件路径 = Path.Combine(text3, $"自定义备份目录的{text}_{读取上次备份时间(text3):yyyyMMdd-HHmmss}.{配置文件操作模块.压缩格式}")
                        远程目录 = $"/备份/{text}/自定义备份目录"
                    End If
                    If 配置文件操作模块.Sftp1开关 Then
                        处理单个Sftp服务端功能.处理单个Sftp服务端_上传文件(配置文件操作模块.Sftp1地址, 配置文件操作模块.Sftp1端口, 配置文件操作模块.Sftp1用户名, 配置文件操作模块.Sftp1密码, "1", 本地文件路径, 远程目录)
                    End If
                    If 配置文件操作模块.Sftp2开关 Then
                        处理单个Sftp服务端功能.处理单个Sftp服务端_上传文件(配置文件操作模块.Sftp2地址, 配置文件操作模块.Sftp2端口, 配置文件操作模块.Sftp2用户名, 配置文件操作模块.Sftp2密码, "2", 本地文件路径, 远程目录)
                    End If
                    If 配置文件操作模块.Sftp3开关 Then
                        处理单个Sftp服务端功能.处理单个Sftp服务端_上传文件(配置文件操作模块.Sftp3地址, 配置文件操作模块.Sftp3端口, 配置文件操作模块.Sftp3用户名, 配置文件操作模块.Sftp3密码, "3", 本地文件路径, 远程目录)
                    End If
                Else
                    日志窗口.添加日志("自定义备份目录备份失败/无新增备份,跳过向Sftp服务器上传自定义目录备份文件", 1)
                End If
            End Sub

            Private Function 读取上次备份时间(输出目录 As String) As Date
                Dim result = Date.MinValue
                Dim path = "LastBackup.time"
                Dim path2 = IO.Path.Combine(输出目录, path)
                If File.Exists(path2) AndAlso Date.TryParse(File.ReadAllText(path2), result) Then
                    Return result
                End If
                Return result
            End Function

            Private Function 检测单个服务端是否已启动(MC服务端路径 As String, 服务端序号 As Integer) As Integer
                日志窗口.添加日志($"开始搜索日志文件以确认服务端运行状态，根目录: {MC服务端路径}", 5)
                Dim tuple = 查找并检测日志文件是否被锁定(MC服务端路径)
                Dim num_ As (num As Integer, List(Of String)) = Nothing
                num_ = tuple
                Select Case num_.num
                    Case 0
                        日志窗口.添加日志($"MC服务端{服务端序号}正在运行", 0)
                        Return 1
                    Case 1
                        日志窗口.添加日志($"MC服务端{服务端序号}未运行", 0)
                        Return 2
                    Case 2
                        日志窗口.添加日志($"MC服务端{服务端序号}的最新日志文件不存在", 2)
                        Return 3
                    Case 3
                        日志窗口.添加日志($"无权限访问MC服务端{服务端序号}的最新日志文件", 2)
                        Return 3
                    Case 4
                        日志窗口.添加日志($"MC服务端{服务端序号}的路径为空", 2)
                        Return 3
                    Case 5
                        日志窗口.添加日志($"MC服务端{服务端序号}的路径不存在", 2)
                        Return 3
                    Case 6
                        日志窗口.添加日志($"尝试锁定MC服务端{服务端序号}的最新日志文件发生IO异常", 2)
                        Return 3
                    Case 7
                        日志窗口.添加日志($"MC服务端{服务端序号}的根目录下发现多个日志文件", 1)
                        日志窗口.添加日志("将逐个检查", 1)
                        Dim list As List(Of Boolean) = New List(Of Boolean)()
                        For Each item In tuple.Item2
                            日志窗口.添加日志($"正在检查日志文件: {item}", 1)
                            Select Case 仅检查日志文件是否被锁定(item)
                                Case 1
                                    日志窗口.添加日志($"日志文件: [{item}] 未被锁定", 0)
                                    list.Add(item:=True)
                                Case 0
                                    日志窗口.添加日志($"日志文件: [{item}] 被锁定", 2)
                                    list.Add(item:=False)
                                Case 3
                                    日志窗口.添加日志($"检查日志文件:[{item}] 时发生无权限访问异常", 2)
                                    list.Add(item:=False)
                                Case 6
                                    日志窗口.添加日志($"检查日志文件:[{item}] 时发生IO异常", 2)
                                    list.Add(item:=False)
                            End Select
                        Next
                        If Not list.Contains(item:=False) Then
                            日志窗口.添加日志("所有日志文件均未被锁定,备份继续", 0)
                            Return 1
                        End If
                        日志窗口.添加日志($"存在被锁定的日志文件,取消备份MC服务端{服务端序号}", 2)
                        Return 2
                    Case Else
                        日志窗口.添加日志($"以现代计算机的数据安全性,你是不可能看到这条消息的,被篡改的返回代码: {num_.num}", 2)
                        日志窗口.添加日志("或许,你在使用一个不受支持的操作系统?", 2)
                        日志窗口.添加日志("或许,你小子把代码改了?", 2)
                        日志窗口.添加日志("或许,你的CPU是个假货还是痴线了?", 2)
                        Return 3
                End Select
            End Function

            Private Function 仅检查日志文件是否被锁定(要检查的日志文件路径 As String) As Integer
                Dim result As Integer
                Try
                    Using File.Open(要检查的日志文件路径, FileMode.Open, FileAccess.Read, FileShare.None)
                        result = 1
                    End Using
                Catch ex As IOException
                    ProjectData.SetProjectError(ex)
                    Dim e = ex
                    Dim num = Marshal.GetHRForException(e) And &HFFFF
                    If num = 32 OrElse num = 33 Then
                        result = 0
                        Call ProjectData.ClearProjectError()
                    Else
                        result = 6
                        Call ProjectData.ClearProjectError()
                    End If
                Catch ex2 As UnauthorizedAccessException
                    ProjectData.SetProjectError(ex2)
                    Dim ex3 = ex2
                    result = 3
                    Call ProjectData.ClearProjectError()
                End Try
                Return result
            End Function

            Private Function 查找并检测日志文件是否被锁定(MC服务端路径 As String) As (Integer, List(Of String))
                Dim result As (Integer, List(Of String))
                If String.IsNullOrEmpty(MC服务端路径) Then
                    result = (4, Nothing)
                ElseIf Not Directory.Exists(MC服务端路径) Then
                    result = (5, Nothing)
                Else
                    Dim list = 查找文件(MC服务端路径, "latest.log")
                    result = If(list.Count = 1, (仅检查日志文件是否被锁定(list(0)), Nothing), If(list.Count <> 0, (7, list), (2, Nothing)))
                End If
                Return result
            End Function

            Public Function 查找文件(根目录 As String, 文件名 As String) As List(Of String)
                Dim list As List(Of String) = New List(Of String)()
                Try
                    list.AddRange(Directory.GetFiles(根目录, 文件名, SearchOption.TopDirectoryOnly))
                    Dim directories = Directory.GetDirectories(根目录)
                    For Each 根目录2 In directories
                        list.AddRange(查找文件(根目录2, 文件名))
                    Next
                Catch ex As UnauthorizedAccessException
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    日志窗口.添加日志($"无权限访问目录 [{根目录}]", 2)
                    Call ProjectData.ClearProjectError()
                Catch ex3 As IOException
                    ProjectData.SetProjectError(ex3)
                    Dim ex4 = ex3
                    日志窗口.添加日志($"IO异常: {ex4.Message} [{根目录}]", 2)
                    Call ProjectData.ClearProjectError()
                Catch ex5 As Exception
                    ProjectData.SetProjectError(ex5)
                    Dim ex6 = ex5
                    日志窗口.添加日志($"本程序未定义的错误: {ex6.Message} [{根目录}]", 2)
                    Call ProjectData.ClearProjectError()
                End Try
                Return list
            End Function
        End Class
    End Class
End Namespace
