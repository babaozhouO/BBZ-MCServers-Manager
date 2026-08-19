Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.Json
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <StandardModule>
    Friend NotInheritable Class 仅变化部分增量备份模块
        Public Class 增量备份器_仅变化部分
            Implements IDisposable
            Private ReadOnly 块大小 As Integer

            Private ReadOnly 输入目录 As String

            Private ReadOnly 备份存放目录 As String

            Private 备份存放子目录 As String

            Private 备份文件存放目录 As String

            Private 元数据目录 As String

            Private 备份时间 As Date

            Private ReadOnly 排除文件参数 As String

            Private ReadOnly 服务端序号 As Integer

            Private ReadOnly 黑名单扩展名 As HashSet(Of String)

            Private ReadOnly 黑名单文件夹 As HashSet(Of String)

            Private ReadOnly 黑名单文件 As HashSet(Of String)

            Private 已释放 As Boolean

            Private ReadOnly 活动文件流列表 As List(Of FileStream)

            Public Sub New(输入目录_ As String, 备份存放目录_ As String, 排除文件参数_ As String, Optional 服务端序号_ As Integer = -1)
                块大小 = 4096
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
                已释放 = False
                活动文件流列表 = New List(Of FileStream)()
                输入目录 = 输入目录_
                备份存放目录 = 备份存放目录_
                排除文件参数 = 排除文件参数_
                服务端序号 = 服务端序号_
                If String.IsNullOrEmpty(排除文件参数) Then
                    Return
                End If
                Dim array = 排除文件参数.Replace("-x!", "").Replace(""" """, "'").Replace("""", "'").Split("'", StringSplitOptions.RemoveEmptyEntries)
                Dim array2 = array
                For Each 文本项 In array2
                    If 文本项.StartsWith("*.") Then
                        黑名单扩展名.Add(文本项.TrimStart("*"c))
                    ElseIf 文本项.Contains("."c) Then
                        Dim list = 增量回档模块.查找文件(输入目录, 文本项)
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

            Public Function 增量备份并压缩文件夹() As Boolean
                备份时间 = Date.Now
                If 服务端序号 = -1 Then
                    日志窗口.添加日志("执行自定义备份文件夹增量备份操作(仅变化部分)", 5)
                Else
                    日志窗口.添加日志($"执行MC服务端{服务端序号}增量备份操作(仅变化部分)", 5)
                End If
                备份存放子目录 = Path.Combine(备份存放目录, $"增量备份_{备份时间:yyyyMMdd-HHmmss}")
                备份文件存放目录 = Path.Combine(备份存放子目录, "文件更新的部分")
                元数据目录 = Path.Combine(备份存放子目录, "元数据")
                Directory.CreateDirectory(备份文件存放目录)
                Directory.CreateDirectory(元数据目录)
                遍历目录(输入目录, 输入目录, 备份文件存放目录)
                Dim 完整备份器 As 完整文件增量或完整备份模块.完整备份器 = New 完整文件增量或完整备份模块.完整备份器()
                Dim result = If(服务端序号 <> -1, 完整备份器.执行完整备份(备份存放子目录, 备份存放目录, $"MC服务端{服务端序号}", "", 服务端序号, 完整文件模式:=False), 完整备份器.执行完整备份(备份存放子目录, 备份存放目录, "自定义备份文件夹", "", -1, 完整文件模式:=False))
                记录备份(备份时间, 备份存放目录)
                Return result
            End Function

            Private Sub 遍历目录(根目录 As String, 当前目录 As String, 备份目录 As String)
                Try
                    For Each item In Directory.EnumerateFiles(当前目录)
                        If Not 是否需跳过文件(item) Then
                            Dim relativePath = Path.GetRelativePath(根目录, item)
                            Dim 文本项 = Path.Combine(备份目录, relativePath)
                            Directory.CreateDirectory(Path.GetDirectoryName(文本项))
                            处理单个文件(item, 文本项)
                        End If
                    Next
                    For Each item2 In Directory.EnumerateDirectories(当前目录)
                        If Not 是否需跳过目录(Path.GetFileName(item2)) Then
                            遍历目录(根目录, item2, 备份目录)
                        End If
                    Next
                Catch ex As UnauthorizedAccessException
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    日志窗口.添加日志($"访问被拒绝：{当前目录}", 2)
                    Call ProjectData.ClearProjectError()
                Catch ex3 As PathTooLongException
                    ProjectData.SetProjectError(ex3)
                    Dim ex4 = ex3
                    日志窗口.添加日志($"路径过长：{当前目录}", 2)
                    Call ProjectData.ClearProjectError()
                End Try
            End Sub

            Private Sub 处理单个文件(源文件 As String, 备份路径 As String)
                Dim fileStream As FileStream = Nothing
                Try
                    fileStream = New FileStream(源文件, FileMode.Open, FileAccess.Read, FileShare.Read)
                    活动文件流列表.Add(fileStream)
                    Dim list = 加载元数据(源文件)
                    Dim list2 As List(Of String) = New List(Of String)()
                    Dim array = New Byte(块大小 - 1 + 1 - 1) {}
                    Using 备份流 As FileStream = New FileStream(备份路径, FileMode.Append)
                        Dim num = 0
                        Do
                            Dim num2 = fileStream.Read(array, 0, array.Length)
                            If num2 = 0 Then
                                Exit Do
                            End If
                            Dim array2 = New Byte(num2 - 1 + 1 - 1) {}
                            System.Array.Copy(array, array2, num2)
                            Dim array3 = SHA256.HashData(array2)
                            Dim 文本项 = BitConverter.ToString(array3).Replace("-", "")
                            list2.Add(文本项)
                            If num >= list.Count OrElse Operators.CompareString(list(num), 文本项, TextCompare:=False) <> 0 Then
                                写入增量块(备份流, num, array2)
                            End If
                            num += 1
                        Loop While num <= Integer.MaxValue
                    End Using
                    保存元数据(源文件, list2)
                Catch ex As IOException
                    ProjectData.SetProjectError(ex)
                    Dim ex2 = ex
                    日志窗口.添加日志($"文件错误：{源文件}", 2)
                    Call ProjectData.ClearProjectError()
                Finally
                    If fileStream IsNot Nothing Then
                        fileStream.Dispose()
                        活动文件流列表.Remove(fileStream)
                    End If
                End Try
            End Sub

            Private Function 加载元数据(文件路径 As String) As List(Of String)
                Dim inArray = SHA256.HashData(Encoding.UTF8.GetBytes(文件路径))
                Dim path As String = IO.Path.Combine(Directory.GetParent(元数据目录).Parent.FullName, $"增量备份_{读取上次备份时间():yyyyMMdd-HHmmss}", "元数据", $"{Convert.ToHexString(inArray)}.json")
                If File.Exists(path) Then
                    Using utf8Json = File.OpenRead(path)
                        Return JsonSerializer.Deserialize(Of List(Of String))(utf8Json)
                    End Using
                End If
                Return New List(Of String)()
            End Function

            Private Function 读取上次备份时间() As Date
                Dim result = Date.MinValue
                Dim path = IO.Path.Combine(Directory.GetParent(元数据目录).Parent.FullName, "时间记录文件.记录")
                If File.Exists(path) Then
                    Dim array = File.ReadAllLines(path)
                    If Date.TryParse(array(array.Length - 1), result) Then
                        Return result
                    End If
                End If
                Return result
            End Function

            Private Sub 保存元数据(文件路径 As String, 哈希列表 As List(Of String))
                Dim path = IO.Path.Combine(元数据目录, $"{Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(文件路径)))}.json")
                Dim utf8Json = File.Create(path)
                Call JsonSerializer.Serialize(utf8Json, 哈希列表, New JsonSerializerOptions With {
        .WriteIndented = True
    })
            End Sub

            Private Sub 写入增量块(备份流 As FileStream, 块索引 As Integer, 数据 As Byte())
                Dim bytes = BitConverter.GetBytes(块索引)
                If Not BitConverter.IsLittleEndian Then
                    Array.Reverse(bytes)
                End If
                备份流.Write(bytes, 0, 4)
                Dim bytes2 = BitConverter.GetBytes(数据.Length)
                If Not BitConverter.IsLittleEndian Then
                    Array.Reverse(bytes2)
                End If
                备份流.Write(bytes2, 0, 4)
                备份流.Write(数据, 0, 数据.Length)
            End Sub

            Private Sub 记录备份(时间 As Date, 时间记录文件目录 As String)
                Dim path = IO.Path.Combine(时间记录文件目录, "时间记录文件.记录")
                File.AppendAllText(path, 时间.ToString("o") & vbCrLf)
            End Sub

            Private Function 是否需跳过文件(路径 As String) As Boolean
                Dim directoryName = Path.GetDirectoryName(路径)
                Dim item = If(String.IsNullOrEmpty(directoryName), "", Path.GetFileName(directoryName))
                Return 黑名单文件.Contains(Path.GetFileName(路径)) OrElse 黑名单扩展名.Contains(Path.GetExtension(路径)) OrElse 黑名单文件夹.Contains(item)
            End Function

            Private Function 是否需跳过目录(名称 As String) As Boolean
                Return 黑名单文件夹.Contains(名称)
            End Function

            Public Sub Dispose()
                If 已释放 Then
                    Return
                End If
                For Each item In 活动文件流列表
                    item.Dispose()
                Next
                活动文件流列表.Clear()
                已释放 = True
                GC.SuppressFinalize(Me)
            End Sub

            Private Sub Dispose1() Implements IDisposable.Dispose
                'ILSpy generated this explicit interface implementation from .override directive in Dispose
                Dispose()
            End Sub

            Protected Overrides Sub Finalize()
                Dispose()
            End Sub
        End Class

        Public Shared Function 增量备份并压缩文件夹(输入目录_ As String, 备份存放目录_ As String, 排除文件参数_ As String, Optional 服务端序号_ As Integer = -1) As Object
            Dim flag As Boolean
            Using 增量备份器_仅变化部分 As 增量备份器_仅变化部分 = New 增量备份器_仅变化部分(输入目录_, 备份存放目录_, 排除文件参数_, 服务端序号_)
                flag = 增量备份器_仅变化部分.增量备份并压缩文件夹()
            End Using
            Return flag
        End Function
    End Class
End Namespace
