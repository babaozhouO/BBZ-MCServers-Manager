Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text.Json
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <StandardModule>
    Friend NotInheritable Class 增量回档模块
        Public Class 增量回档器
            Implements IDisposable
            <CompilerGenerated>
            Friend NotInheritable Class _Closure_0024__13_002D0
                Public _0024VB_0024Local_目标时间 As Date

                Public _0024I4 As Func(Of Date, Boolean)

                Public Sub New(arg0 As _Closure_0024__13_002D0)
                    If arg0 IsNot Nothing Then
                        _0024VB_0024Local_目标时间 = arg0._0024VB_0024Local_目标时间
                    End If
                End Sub

                <SpecialName>
                Friend Function _Lambda_0024__0(t As Date) As Boolean
                    Return Date.Compare(t, _0024VB_0024Local_目标时间) <= 0
                End Function

                <SpecialName>
                Friend Function _Lambda_0024__2(t As Date) As Boolean
                    Return Date.Compare(t, _0024VB_0024Local_目标时间) <= 0
                End Function

                <SpecialName>
                Friend Function _Lambda_0024__4(t As Date) As Boolean
                    Return Date.Compare(t, _0024VB_0024Local_目标时间) <= 0
                End Function
            End Class

            Private ReadOnly 块大小 As Integer

            Private ReadOnly 备份根目录 As String

            Private ReadOnly 目标恢复目录 As String

            Private ReadOnly 服务端序号 As Integer

            Private 元数据目录 As String

            Private 增量文件目录 As String

            Private 已释放 As Boolean

            Private 可用备份时间 As List(Of Date)

            Private ReadOnly 最大回退次数 As Integer

            Private ReadOnly 自动合并阈值 As Integer

            Public Sub New(备份存放根目录 As String, 恢复目标目录 As String, Optional 服务端序号_ As Integer = -1)
                块大小 = 4096
                已释放 = False
                可用备份时间 = New List(Of Date)()
                最大回退次数 = 10
                自动合并阈值 = 5
                备份根目录 = 备份存放根目录
                目标恢复目录 = 恢复目标目录
                服务端序号 = 服务端序号_
                加载可用备份()
            End Sub

            Public Function 获取可用备份时间() As List(Of Date)
                Return New List(Of Date)(可用备份时间)
            End Function

            Public Function 获取最后备份时间() As Date
                Return If(可用备份时间.Count > 0, 可用备份时间.Last(), Date.MinValue)
            End Function

            Public Function 安全回档到指定时间(目标时间 As Date) As Boolean
                Dim arg As _Closure_0024__13_002D0 = Nothing
                Dim CS_0024_003C_003E8__locals0 As _Closure_0024__13_002D0 = New _Closure_0024__13_002D0(arg)
                CS_0024_003C_003E8__locals0._0024VB_0024Local_目标时间 = 目标时间
                If 可用备份时间.Count = 0 Then
                    日志窗口.添加日志("没有可用备份", 2)
                    Return False
                End If
                Dim list As List(Of Date) = (From t In 可用备份时间 Where Date.Compare(t, CS_0024_003C_003E8__locals0._0024VB_0024Local_目标时间) <= 0 Order By t Select t).ToList()
                If list.Count = 0 Then
                    日志窗口.添加日志("没有早于目标时间的备份", 2)
                    Return False
                End If
                If list.Count > 自动合并阈值 Then
                    日志窗口.添加日志("检测到过多增量备份，开始自动合并...", 3)
                    If 合并备份(list) Then
                        list = (From t In 可用备份时间 Where Date.Compare(t, CS_0024_003C_003E8__locals0._0024VB_0024Local_目标时间) <= 0 Order By t Select t).ToList()
                    End If
                End If
                If 回档到指定时间(CS_0024_003C_003E8__locals0._0024VB_0024Local_目标时间) Then
                    Return True
                End If
                日志窗口.添加日志("开始回退式回档流程", 3)
                Dim dateTime As Date = list.First()
                Dim num = Math.Min(最大回退次数, list.Count - 1)
                For i = 0 To num
                    If 回档到指定时间(dateTime) Then
                        日志窗口.添加日志($"成功恢复到中间点：{dateTime:yyyy-MM-dd HH:mm:ss}", 3)
                        For Each item In From t In list.Skip(i + 1) Where Date.Compare(t, CS_0024_003C_003E8__locals0._0024VB_0024Local_目标时间) <= 0 Select t
                            If Not 应用增量更新(item) Then
                                Exit For
                            End If
                            dateTime = item
                        Next
                        Return Date.Compare(dateTime, CS_0024_003C_003E8__locals0._0024VB_0024Local_目标时间) = 0
                    End If
                    dateTime = list(i + 1)
                Next
                日志窗口.添加日志("无法通过回退完成恢复", 2)
                Return False
            End Function

            Private Function 回档到指定时间(备份时间 As Date) As Boolean
                Dim path = IO.Path.Combine(备份根目录, $"增量备份_{备份时间:yyyyMMdd-HHmmss}")
                元数据目录 = IO.Path.Combine(path, "元数据")
                增量文件目录 = IO.Path.Combine(path, "文件更新的部分")
                If Not Directory.Exists(元数据目录) Then
                    日志窗口.添加日志($"元数据目录不存在：{元数据目录}", 2)
                    Return False
                End If
                If Not Directory.Exists(增量文件目录) Then
                    日志窗口.添加日志($"增量文件目录不存在：{增量文件目录}", 2)
                    Return False
                End If
                日志窗口.添加日志($"开始回档到 {备份时间:yyyy-MM-dd HH:mm:ss}", 5)
                遍历回档目录(增量文件目录, 目标恢复目录)
                Return True
            End Function

            Private Sub 遍历回档目录(当前备份目录 As String, 当前目标目录 As String)
                Try
                    Directory.CreateDirectory(当前目标目录)
                    For Each item In Directory.EnumerateFiles(当前备份目录)
                        Dim relativePath = Path.GetRelativePath(增量文件目录, item)
                        Dim text = Path.Combine(目标恢复目录, relativePath)
                        Directory.CreateDirectory(Path.GetDirectoryName(text))
                        恢复单个文件(item, text)
                    Next
                    For Each item2 In Directory.EnumerateDirectories(当前备份目录)
                        Dim fileName = Path.GetFileName(item2)
                        Dim 当前目标目录2 = Path.Combine(当前目标目录, fileName)
                        遍历回档目录(item2, 当前目标目录2)
                    Next
                Catch ex As UnauthorizedAccessException
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    日志窗口.添加日志($"权限不足：{当前备份目录}", 2)
                    Call ProjectData.ClearProjectError()
                Catch ex3 As PathTooLongException
                    ProjectData.SetProjectError(ex3)
                    Dim ex4 = ex3
                    日志窗口.添加日志($"路径过长：{当前备份目录}", 2)
                    Call ProjectData.ClearProjectError()
                Catch ex5 As Exception
                    ProjectData.SetProjectError(ex5)
                    Dim ex6 = ex5
                    日志窗口.添加日志($"目录处理失败：{ex6.Message}", 2)
                    Call ProjectData.ClearProjectError()
                End Try
            End Sub

            Private Sub 恢复单个文件(备份文件路径 As String, 目标文件路径 As String)
                Try
                    Dim path = $"{IO.Path.GetFileName(备份文件路径)}.json"
                    Dim text = IO.Path.Combine(元数据目录, path)
                    If Not File.Exists(text) Then
                        日志窗口.添加日志($"缺失元数据文件：{text}", 2)
                        Return
                    End If
                    Dim 哈希列表 As List(Of String)
                    Using utf8Json = File.OpenRead(text)
                        Try
                            哈希列表 = JsonSerializer.Deserialize(Of List(Of String))(utf8Json)
                        Catch ex As JsonException
                            ProjectData.SetProjectError(ex)
                            Dim ex2 = ex
                            日志窗口.添加日志($"元数据文件损坏：{text}", 2)
                            Call ProjectData.ClearProjectError()
                            Return
                        End Try
                    End Using
                    Using 目标流 = File.Create(目标文件路径)
                        应用增量块(备份文件路径, 目标流, 哈希列表)
                    End Using
                    日志窗口.添加日志($"成功恢复文件：{目标文件路径}", 3)
                Catch ex3 As IOException
                    ProjectData.SetProjectError(ex3)
                    Dim ex4 = ex3
                    日志窗口.添加日志($"文件被占用：{目标文件路径}", 2)
                    Call ProjectData.ClearProjectError()
                Catch ex5 As Exception
                    ProjectData.SetProjectError(ex5)
                    Dim ex6 = ex5
                    日志窗口.添加日志($"文件恢复失败：{目标文件路径} - {ex6.Message}", 2)
                    Call ProjectData.ClearProjectError()
                End Try
            End Sub

            Private Sub 应用增量块(备份文件路径 As String, 目标流 As FileStream, 哈希列表 As List(Of String))
                Dim fileStream = File.OpenRead(备份文件路径)
                Dim array = New Byte(7) {}
                While fileStream.Position < fileStream.Length
                    If fileStream.Read(array, 0, 4) < 4 Then
                        日志窗口.添加日志("块头不完整", 2)
                        Exit While
                    End If
                    Dim num = BitConverter.ToInt32(array, 0)
                    If Not BitConverter.IsLittleEndian Then
                        System.Array.Reverse(array, 0, 4)
                    End If
                    If fileStream.Read(array, 4, 4) < 4 Then
                        日志窗口.添加日志("块长度不完整", 2)
                        Exit While
                    End If
                    Dim num2 = BitConverter.ToInt32(array, 4)
                    If Not BitConverter.IsLittleEndian Then
                        System.Array.Reverse(array, 4, 4)
                    End If
                    If num < 0 OrElse num >= 哈希列表.Count Then
                        日志窗口.添加日志($"无效块索引：{num}", 2)
                        Exit While
                    End If
                    Dim array2 = New Byte(num2 - 1 + 1 - 1) {}
                    Dim num3 = fileStream.Read(array2, 0, num2)
                    If num3 <> num2 Then
                        日志窗口.添加日志($"数据块不完整，预期{num2}字节，实际{num3}字节", 2)
                        Exit While
                    End If
                    Dim left = BitConverter.ToString(SHA256.HashData(array2)).Replace("-", "")
                    If Operators.CompareString(left, 哈希列表(num), TextCompare:=False) <> 0 Then
                        日志窗口.添加日志($"块校验失败：{num}", 2)
                        Continue While
                    End If
                    目标流.Seek(num * 块大小, SeekOrigin.Begin)
                    目标流.Write(array2, 0, array2.Length)
                End While
            End Sub

            Private Function 应用增量更新(增量时间 As Date) As Boolean
                Dim path = IO.Path.Combine(备份根目录, $"增量备份_{增量时间:yyyyMMdd-HHmmss}")
                Dim path2 = IO.Path.Combine(path, "元数据")
                Dim result As Boolean
                Try
                    For Each item In Directory.EnumerateFiles(path2, "*.json")
                        Dim fileNameWithoutExtension = IO.Path.GetFileNameWithoutExtension(item)
                        Dim path3 = IO.Path.Combine(目标恢复目录, fileNameWithoutExtension)
                        Dim 目标流 = File.Open(path3, FileMode.OpenOrCreate, FileAccess.ReadWrite)
                        Dim 哈希列表 As List(Of String)
                        Using utf8Json = File.OpenRead(item)
                            哈希列表 = JsonSerializer.Deserialize(Of List(Of String))(utf8Json)
                        End Using
                        Dim text = IO.Path.Combine(path, "文件更新的部分", fileNameWithoutExtension)
                        If File.Exists(text) Then
                            应用增量块(text, 目标流, 哈希列表)
                        End If
                    Next
                    result = True
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    日志窗口.添加日志($"应用增量更新失败：{ex2.Message}", 2)
                    result = False
                    Call ProjectData.ClearProjectError()
                End Try
                Return result
            End Function

            Private Function 合并备份(备份列表 As List(Of Date)) As Boolean
                Dim result As Boolean
                If 备份列表.Count < 2 Then
                    result = True
                Else
                    Dim dateTime As Date = 备份列表.First()
                    Dim dateTime2 As Date = 备份列表.Last()
                    Dim text = Path.Combine(备份根目录, $"合并备份_{dateTime:yyyyMMdd-HHmmss}_至_{dateTime2:yyyyMMdd-HHmmss}")
                    Try
                        Directory.CreateDirectory(text)
                        Dim text2 = Path.Combine(text, "元数据")
                        Directory.CreateDirectory(text2)
                        Dim dictionary As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))()
                        For Each item In 备份列表
                            Dim path = IO.Path.Combine(备份根目录, $"增量备份_{item:yyyyMMdd-HHmmss}", "元数据")
                            For Each item2 In Directory.EnumerateFiles(path, "*.json")
                                Dim fileName = IO.Path.GetFileName(item2)
                                Dim value As List(Of String) = Nothing
                                If Not dictionary.TryGetValue(fileName, value) Then
                                    value = New List(Of String)()
                                    dictionary.Add(fileName, value)
                                End If
                                Dim utf8Json = File.OpenRead(item2)
                                Dim 新增列表 = JsonSerializer.Deserialize(Of List(Of String))(utf8Json)
                                dictionary(fileName) = 合并哈希列表(value, 新增列表)
                            Next
                        Next
                        For Each item3 In dictionary
                            File.WriteAllText(Path.Combine(text2, item3.Key), JsonSerializer.Serialize(item3.Value))
                        Next
                        File.AppendAllText(Path.Combine(备份根目录, "时间记录文件.记录"), String.Format("{0:o}{1}", dateTime2, vbCrLf))
                        Enumerable.ToList(Enumerable.Take(备份列表, 备份列表.Count - 1)).ForEach(Sub(t) Directory.Delete(Path.Combine(备份根目录, $"增量备份_{t:yyyyMMdd-HHmmss}"), recursive:=True))
                        result = True
                    Catch ex As Exception
                        ProjectData.SetProjectError(ex)
                        Dim ex2 = ex
                        日志窗口.添加日志($"备份合并失败：{ex2.Message}", 2)
                        result = False
                        Call ProjectData.ClearProjectError()
                    End Try
                End If
                Return result
            End Function

            Private Function 合并哈希列表(原始列表 As List(Of String), 新增列表 As List(Of String)) As List(Of String)
                If 原始列表 Is Nothing OrElse 原始列表.Count = 0 Then
                    Return 新增列表
                End If
                If 新增列表 Is Nothing OrElse 新增列表.Count = 0 Then
                    Return 原始列表
                End If
                Dim list As List(Of String) = New List(Of String)(原始列表)
                Dim num = Math.Min(list.Count, 新增列表.Count) - 1
                For i = 0 To num
                    If Not Equals(新增列表(i), Nothing) Then
                        list(i) = 新增列表(i)
                    End If
                Next
                If 新增列表.Count > list.Count Then
                    list.AddRange(新增列表.Skip(list.Count))
                End If
                Return list
            End Function

            Private Sub 加载可用备份()
                Dim result As Date = Nothing
                Try
                    Dim path = IO.Path.Combine(备份根目录, "时间记录文件.记录")
                    If File.Exists(path) Then
                        Dim list As List(Of String) = (From s In File.ReadAllLines(path) Where Not String.IsNullOrWhiteSpace(s) Select s).ToList()
                        If list.Count = 0 Then
                            日志窗口.添加日志("时间记录文件为空", 2)
                            Return
                        End If
                        For Each item In list

                            If Date.TryParse(item, result) Then
                                可用备份时间.Add(result)
                            Else
                                日志窗口.添加日志($"无效时间格式：{item}", 2)
                            End If
                        Next
                        可用备份时间 = 可用备份时间.OrderBy(Function(t) t).ToList()
                    Else
                        日志窗口.添加日志("未找到时间记录文件", 2)
                    End If
                Catch ex As Exception
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    日志窗口.添加日志($"加载备份记录失败：{ex2.Message}", 2)
                    Call ProjectData.ClearProjectError()
                End Try
            End Sub

            Public Sub Dispose()
                If Not 已释放 Then
                    日志窗口.添加日志($"释放回档器资源（服务端{服务端序号}）", 5)
                    已释放 = True
                    GC.SuppressFinalize(Me)
                End If
            End Sub

            Private Sub Dispose1() Implements IDisposable.Dispose
                'ILSpy generated this explicit interface implementation from .override directive in Dispose
                Dispose()
            End Sub

            Protected Overrides Sub Finalize()
                Dispose()
            End Sub
        End Class

        Public Shared Function 查找文件(根目录 As String, 文件名 As String) As List(Of String)
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
            Catch ex3 As DirectoryNotFoundException
                ProjectData.SetProjectError(ex3)
                Dim ex4 = ex3
                日志窗口.添加日志($"目录不存在 [{根目录}]", 2)
                Call ProjectData.ClearProjectError()
            Catch ex5 As IOException
                ProjectData.SetProjectError(ex5)
                Dim ex6 = ex5
                日志窗口.添加日志($"IO异常: {ex6.Message} ({根目录})", 2)
                Call ProjectData.ClearProjectError()
            Catch ex7 As Exception
                ProjectData.SetProjectError(ex7)
                Dim ex8 = ex7
                Call 日志窗口.添加日志($"未知错误: {ex8.GetType().Name} ({根目录})", 2)
                Call ProjectData.ClearProjectError()
            End Try
            Return list
        End Function
    End Class
End Namespace
