Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <StandardModule>
    Public NotInheritable Class 完整文件增量或完整备份模块
        Public Class 增量备份器_完整文件
            Private 上次备份时间 As Date

            Private Const 时间记录文件 As String = "LastBackup.time"

            Public Sub New()
                上次备份时间 = Date.MinValue
            End Sub

            Public Function 执行增量备份(输入目录 As String, 输出目录 As String, Optional 压缩文件说明 As String = "某文件", Optional 排除文件参数 As String = "", Optional MC服务端序号 As Integer = -1) As Boolean
                Dim now = Date.Now
                Dim path = IO.Path.Combine(输出目录, "LastBackup.time")
                If File.Exists(path) Then
                    Dim 文本项 = File.ReadAllText(path)
                    If Not Date.TryParse(文本项, 上次备份时间) Then
                        日志窗口.添加日志("含日期时间数据的字符串转换为日期时间数据类型数据时出错,你是不是对时间记录文件下毒手了！", 2)
                        日志窗口.添加日志($"看看你干的好事:时间记录文件内容：{文本项}", 2)
                        Return False
                    End If
                End If
                Dim arg = IO.Path.Combine(配置文件操作模块.备份输出目录, 压缩文件说明)
                Dim text2 = IO.Path.Combine(输出目录, $"{压缩文件说明}的增量备份(备份整个文件模式)_{now:yyyyMMdd-HHmmss}.7z")
                Try
                    Dim 附加参数 As String
                    If Date.Compare(上次备份时间, Date.MinValue) > 0 Then
                        日志窗口.添加日志("找到上次备份时间，将执行增量备份", 5)
                        Dim tuple = 复制增量文件到临时存放目录并输出目录(输入目录, 上次备份时间, 排除文件参数)
                        MainForm.更新进度条("分任务", 40)
                        附加参数 = If(配置文件操作模块.压缩级别 <> 0, $" -r -aoa -sdel -t{配置文件操作模块.压缩格式} -mx{配置文件操作模块.压缩级别} -m0={配置文件操作模块.压缩方法}:d={配置文件操作模块.字典大小.TrimEnd("B"c)}:fb={配置文件操作模块.单词大小} -ms -mmt{配置文件操作模块.线程数} -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}", If(Operators.CompareString(配置文件操作模块.压缩方法, "GNU", TextCompare:=False) = 0 Or Operators.CompareString(配置文件操作模块.压缩方法, "POSIX", TextCompare:=False) = 0, $" -r -aoa -sdel -t{配置文件操作模块.压缩格式} -mx0 -mo={配置文件操作模块.压缩方法} -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}", If(Operators.CompareString(配置文件操作模块.压缩方法, "", TextCompare:=False) <> 0, $" -r -aoa -sdel -t{配置文件操作模块.压缩格式} -mx{配置文件操作模块.压缩级别} -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}", $" -r -aoa -sdel -twim -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}")))
                        If String.IsNullOrEmpty(tuple.Item1) AndAlso tuple.Item2 = 2 Then
                            日志窗口.添加日志("复制增量文件到临时存放目录失败", 2)
                            Return False
                        End If
                        If String.IsNullOrEmpty(tuple.Item1) AndAlso tuple.Item2 = 1 Then
                            日志窗口.添加日志("备份目录无已更新文件,已取消次备份操作", 3)
                            File.WriteAllText(path, now.ToString("o"))
                            Return False
                        End If
                        Dim num As Integer
                        Using sevenZIP As 调用7Zip模块.SevenZIP = New 调用7Zip模块.SevenZIP()
                            num = sevenZIP.调用7Zip("a", 附加参数, text2, tuple.Item1, MC服务端序号)
                        End Using
                        If num = 0 OrElse num = 1 Then
                            File.WriteAllText(path, now.ToString("o"))
                            日志窗口.添加日志($"备份完成：{text2}", 3)
                            Return True
                        End If
                        日志窗口.添加日志("压缩过程返回错误", 2)
                        If File.Exists(text2) Then
                            File.Delete(text2)
                            If File.Exists(text2) Then
                                日志窗口.添加日志("出错的压缩文件删除成功", 1)
                            End If
                        End If
                        Return False
                    End If
                    日志窗口.添加日志("未找到上次备份时间，将执行完整备份", 5)
                    MainForm.更新进度条("分任务", 40)
                    附加参数 = If(配置文件操作模块.压缩级别 <> 0, $" -r -aoa -t{配置文件操作模块.压缩格式} -mx{配置文件操作模块.压缩级别} -m0={配置文件操作模块.压缩方法}:d={配置文件操作模块.字典大小.TrimEnd("B"c)}:fb={配置文件操作模块.单词大小} -ms -mmt{配置文件操作模块.线程数} -x!""tmp"" -x!"" * .tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}", If(Operators.CompareString(配置文件操作模块.压缩方法, "GNU", TextCompare:=False) = 0 Or Operators.CompareString(配置文件操作模块.压缩方法, "POSIX", TextCompare:=False) = 0, $" -r -aoa -t{配置文件操作模块.压缩格式} -mx0 -mo={配置文件操作模块.压缩方法} -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}", If(Operators.CompareString(配置文件操作模块.压缩方法, "", TextCompare:=False) <> 0, $" -r -aoa -t{配置文件操作模块.压缩格式} -mx{配置文件操作模块.压缩级别} -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}", $" -r -aoa -twim -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}")))
                    Dim num2 As Integer
                    Using sevenZIP2 As 调用7Zip模块.SevenZIP = New 调用7Zip模块.SevenZIP()
                        num2 = sevenZIP2.调用7Zip("a", 附加参数, text2, 输入目录, MC服务端序号)
                    End Using
                    If num2 = 0 OrElse num2 = 1 Then
                        File.WriteAllText(path, now.ToString("o"))
                        日志窗口.添加日志($"备份完成：{text2}", 3)
                        Return True
                    End If
                    日志窗口.添加日志("压缩过程返回错误", 2)
                    If File.Exists(text2) Then
                        File.Delete(text2)
                        If File.Exists(text2) Then
                            日志窗口.添加日志("出错的压缩文件删除成功", 1)
                        End If
                    End If
                    Return False
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    If ex2.Message.Contains("目录不是空的") Then
                        日志窗口.添加日志("临时文件夹删除失败", 2)
                        日志窗口.添加日志($"请手动删除{arg}", 2)
                    Else
                        日志窗口.添加日志($"备份时发生错误：{ex2.Message}", 2)
                    End If
                    Call ProjectData.ClearProjectError()
                End Try
                Return False
            End Function

            Private Shared Function 复制增量文件到临时存放目录并输出目录(源路径 As String, 上次备份时间 As Date, 排除文件参数 As String) As (String, Integer)
                Dim 文本项 As String = MainForm.执行中的主任务.Text
                Dim value As Integer = MainForm.主任务进度条.Value
                Dim text2 As String = MainForm.执行中的分任务.Text
                Dim value2 As Integer = MainForm.分任务进度条.Value
                MainForm.更新标签("主任务", text2)
                MainForm.更新进度条("主任务", value2)
                MainForm.更新标签("分任务", "复制增量文件到临时存放目录")
                Dim text3 = Path.Combine(配置文件操作模块.备份输出目录, "增量文件")
                Dim 文件复制器 As 文件复制器 = New 文件复制器(排除文件参数, 源路径, text3, 上次备份时间)
                Dim num As Double
                Dim value3 As Integer
                AddHandler 文件复制器.进度更新, Sub(当前进度, 总数量)
                                           num = 总数量 / 100.0
                                           value3 = If(CInt(Math.Round(当前进度 / num)) <= 100, CInt(Math.Round(当前进度 / num)), 100)
                                           MainForm.更新进度条("分任务", value3)
                                           日志窗口.添加日志($"进度: {当前进度}/{总数量} ({当前进度 / 总数量:P})", 0)
                                       End Sub
                Dim result As (String, Integer)
                Try
                    Dim num2 As Integer = 文件复制器.复制修改时间后的文件()
                    If num2 = 0 Then
                        result = ("", 1)
                    Else
                        日志窗口.添加日志($"[Debug]成功复制{num2}个文件到临时目录", 3)
                        result = (text3, 0)
                    End If
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    日志窗口.添加日志($"执行复制增量文件时出错：{ex2.Message}", 2)
                    result = ("", 2)
                    Call ProjectData.ClearProjectError()
                Finally
                    MainForm.更新标签("主任务", 文本项)
                    MainForm.更新进度条("主任务", value)
                    MainForm.更新标签("分任务", text2)
                End Try
                Return result
            End Function
        End Class

        Public Class 完整备份器
            Private Const 时间记录文件 As String = "LastBackup.time"

            Public Function 执行完整备份(输入目录 As String, 输出目录 As String, Optional 压缩文件说明 As String = "某文件", Optional 排除文件参数 As String = "", Optional MC服务端序号 As Integer = -1, Optional 完整文件模式 As Boolean = True) As Boolean
                Dim now = Date.Now
                Dim path = IO.Path.Combine(输出目录, "LastBackup.time")
                Dim 文本项 = If(Not 完整文件模式, IO.Path.Combine(输出目录, $"{压缩文件说明}的增量备份(仅备份文件变化部分模式)_{Date.Now:yyyyMMdd-HHmmss}.7z"), IO.Path.Combine(输出目录, $"{压缩文件说明}的完整备份_{Date.Now:yyyyMMdd-HHmmss}.7z"))
                Dim 附加参数 = If(配置文件操作模块.压缩级别 <> 0, $" -r -aoa -t{配置文件操作模块.压缩格式} -mx{配置文件操作模块.压缩级别} -m0={配置文件操作模块.压缩方法}:d={配置文件操作模块.字典大小.TrimEnd("B"c)}:fb={配置文件操作模块.单词大小} -ms -mmt{配置文件操作模块.线程数} -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}", If(Operators.CompareString(配置文件操作模块.压缩方法, "GNU", TextCompare:=False) = 0 Or Operators.CompareString(配置文件操作模块.压缩方法, "POSIX", TextCompare:=False) = 0, $" -r -aoa -t{配置文件操作模块.压缩格式} -mx0 -mo={配置文件操作模块.压缩方法} -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}", If(Operators.CompareString(配置文件操作模块.压缩方法, "", TextCompare:=False) <> 0, $" -r -aoa -t{配置文件操作模块.压缩格式} -mx{配置文件操作模块.压缩级别} -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}", $" -r -aoa -twim -x!""tmp"" -x!""*.tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"" {排除文件参数}")))
                MainForm.更新进度条("分任务", 40)
                Try
                    Dim num As Integer
                    Using sevenZIP As 调用7Zip模块.SevenZIP = New 调用7Zip模块.SevenZIP()
                        num = sevenZIP.调用7Zip("a", 附加参数, 文本项, 输入目录, MC服务端序号)
                    End Using
                    If num = 0 OrElse num = 1 Then
                        File.WriteAllText(path, now.ToString("o"))
                        If 完整文件模式 Then
                            日志窗口.添加日志($" 完整备份完成：{文本项}", 3)
                        Else
                            日志窗口.添加日志($" 压缩完成：{文本项}", 3)
                        End If
                        Return True
                    End If
                    日志窗口.添加日志(" 压缩过程返回错误", 2)
                    If File.Exists(文本项) Then
                        File.Delete(文本项)
                        If File.Exists(文本项) Then
                            日志窗口.添加日志("出错的压缩文件删除成功", 1)
                        Else
                            日志窗口.添加日志($"出错的压缩文件删除失败:{文本项}", 2)
                        End If
                    Else
                        日志窗口.添加日志("出错的压缩文件删除成功", 1)
                    End If
                    Return False
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    If 完整文件模式 Then
                        日志窗口.添加日志($"备份中发生异常：{ex2.Message}", 2)
                    Else
                        日志窗口.添加日志($"压缩中发生异常：{ex2.Message}", 2)
                    End If
                    Call ProjectData.ClearProjectError()
                End Try
                Return False
            End Function
        End Class

        Public Class 文件复制器
            Private ReadOnly 黑名单扩展名 As HashSet(Of String)

            Private ReadOnly 黑名单文件夹 As HashSet(Of String)

            Private ReadOnly 黑名单文件 As HashSet(Of String)

            Private ReadOnly 临时目录 As String

            Private ReadOnly 源目录 As String

            Private ReadOnly 时间阈值 As Date

            Public Event 进度更新 As Action(Of Integer, Integer)

            Public Sub New(排除文件参数 As String, 源目录_ As String, 临时目录_ As String, 时间阈值_ As Date)
                黑名单扩展名 = New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
                        ".tmp"
                    }
                黑名单文件夹 = New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
                        "tmp",
                        "$RECYCLE.BIN"
                    }
                黑名单文件 = New HashSet(Of String)(StringComparer.OrdinalIgnoreCase) From {
                        "Thumbs.db"
                    }
                源目录 = 源目录_
                临时目录 = 临时目录_
                时间阈值 = 时间阈值_
                If String.IsNullOrEmpty(排除文件参数) Then
                    Return
                End If
                Dim array = 排除文件参数.Replace("-x!", "").Replace(""" """, "'").Replace("""", "'").Split("'", StringSplitOptions.RemoveEmptyEntries)
                Dim array2 = array
                For Each 文本项 In array2
                    If 文本项.StartsWith("*.") Then
                        黑名单扩展名.Add(文本项.TrimStart("*"c))
                    ElseIf 文本项.Contains("."c) Then
                        Dim list = 增量回档模块.查找文件(源目录, 文本项)
                        If list.Count = 0 Then
                            黑名单文件夹.Add(文本项)
                        Else
                            黑名单文件.Add(文本项)
                        End If
                    Else
                        黑名单文件夹.Add(文本项)
                    End If
                Next
            End Sub

            Public Function 复制修改时间后的文件() As Integer
                Directory.CreateDirectory(临时目录)
                Dim 文本项 = Path.GetFullPath(源目录)
                If Not 文本项.EndsWith(Path.DirectorySeparatorChar) Then
                    文本项 += Conversions.ToString(Path.DirectorySeparatorChar)
                End If
                Dim num = 0
                Try
                    Dim list As List(Of String) = New List(Of String)()
                    Dim stack As Stack(Of String) = New Stack(Of String)()
                    stack.Push(文本项)
                    While stack.Count > 0
                        Dim text2 As String = stack.Pop()
                        Try
                            Dim directories = Directory.GetDirectories(text2)
                            For Each text3 In directories
                                If Not 是否需跳过目录(Path.GetFileName(text3)) Then
                                    stack.Push(text3)
                                End If
                            Next
                            Dim files = Directory.GetFiles(text2)
                            For Each text4 In files
                                Dim lastWriteTimeUtc = File.GetLastWriteTimeUtc(text4)
                                Dim dateTime = 时间阈值
                                If Date.Compare(lastWriteTimeUtc, dateTime.ToUniversalTime()) > 0 AndAlso Not 是否需跳过文件(text4) Then
                                    list.Add(text4)
                                End If
                            Next
                        Catch ex As UnauthorizedAccessException
                            ProjectData.SetProjectError(ex)
                            Dim ex2 = ex
                            日志窗口.添加日志($"跳过无权限目录: {text2}", 2)
                            Call ProjectData.ClearProjectError()
                        End Try
                    End While
                    Dim num2 = list.Count - 1
                    For k = 0 To num2
                        Dim text5 = list(k)
                        Try
                            Dim path = text5.Substring(文本项.Length)
                            Dim text6 = IO.Path.Combine(临时目录, path)
                            Dim directoryName = IO.Path.GetDirectoryName(text6)
                            Directory.CreateDirectory(directoryName)
                            Try
                                File.Copy(text5, text6, overwrite:=True)
                                num += 1
                            Catch ex3 As IOException When Function()
                                                              ' Could not convert BlockContainer to single expression
                                                              ProjectData.SetProjectError(ex3)
                                                              Return ex3.HResult = -2147024864
                                                          End Function.Invoke()
                                Thread.Sleep(500)
                                File.Copy(text5, text6, overwrite:=True)
                                num += 1
                                Call ProjectData.ClearProjectError()
                            End Try
                        Catch ex4 As Exception
                            ProjectData.SetProjectError(ex4)
                            Dim ex5 = ex4
                            日志窗口.添加日志($"文件复制失败 [{Path.GetFileName(text5)}]: {ex5.Message}", 2)
                            Call ProjectData.ClearProjectError()
                        End Try
                        RaiseEvent 进度更新(k + 1, list.Count)
                    Next
                Catch ex6 As Exception
                    ProjectData.SetProjectError(ex6)
                    Dim ex7 = ex6
                    日志窗口.添加日志($"发生本程序未定义的异常: {ex7.Message}", 2)
                    Call ProjectData.ClearProjectError()
                End Try
                Return num
            End Function

            Private Function 是否需跳过文件(路径 As String) As Boolean
                Dim directoryName = Path.GetDirectoryName(路径)
                Dim item = If(String.IsNullOrEmpty(directoryName), "", Path.GetFileName(directoryName))
                Return 黑名单文件.Contains(Path.GetFileName(路径)) OrElse 黑名单扩展名.Contains(Path.GetExtension(路径)) OrElse 黑名单文件夹.Contains(item)
            End Function

            Private Function 是否需跳过目录(名称 As String) As Boolean
                Return 黑名单文件夹.Contains(名称)
            End Function

            Private Shared Sub 使用示例(排除文件参数 As String, 源路径 As String, 最后备份时间 As Date, Optional 临时路径 As String = "")
                Dim 文件复制器 As 文件复制器 = New 文件复制器(排除文件参数, 源路径, 临时路径, 最后备份时间)
                AddHandler 文件复制器.进度更新, Sub(当前进度, 总数量) Console.WriteLine($"进度: {当前进度}/{总数量} ({当前进度 / 总数量:P})")
                If String.IsNullOrEmpty(临时路径) Then
                    临时路径 = Path.Combine(Path.GetTempPath(), "备份缓存\")
                End If
                Try
                    Dim num As Integer = 文件复制器.复制修改时间后的文件()
                    Console.WriteLine($"✅ 成功复制 {num} 个文件到临时目录")
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    Console.WriteLine($"💥 操作失败: {ex2.Message}")
                    Call ProjectData.ClearProjectError()
                End Try
            End Sub
        End Class
    End Class
End Namespace
