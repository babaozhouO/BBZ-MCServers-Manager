Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace BBZ_MCServers_Manager

    Partial Public Class 日志窗口
        Inherits Form
        Private _LogsRichTextBox As RichTextBox
        Friend Property LogsRichTextBox As RichTextBox
            Get
                Return _LogsRichTextBox
            End Get
            Set(value As RichTextBox)
                _LogsRichTextBox = value
            End Set
        End Property

        Private components As IContainer

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("位置同步Timer")>
        Private _位置同步Timer As Timer

        Private Shared 日志处理器实例 As 日志处理模块.日志处理功能

        Private 当前目标窗口 As Form

        Private ReadOnly 主窗口 As MainForm
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("LogsRichTextBox")]
''' 	internal virtual System.Windows.Forms.RichTextBox LogsRichTextBox
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property 位置同步Timer As Timer
            <CompilerGenerated>
            Get
                Return _位置同步Timer
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf 位置同步Timer_Tick
                Dim timer = _位置同步Timer
                If timer IsNot Nothing Then
                    RemoveHandler timer.Tick, value2
                End If
                _位置同步Timer = value
                timer = _位置同步Timer
                If timer IsNot Nothing Then
                    AddHandler timer.Tick, value2
                End If
            End Set
        End Property

        Public Sub New()
            AddHandler Load, AddressOf 日志窗口_Load
        End Sub

        <DebuggerNonUserCode>
        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If

            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        <DebuggerStepThrough>
        Private Sub InitializeComponent()
            components = New Container()
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(日志窗口))
            Me.LogsRichTextBox = New RichTextBox()
            位置同步Timer = New Timer(components)
            SuspendLayout()
            Me.LogsRichTextBox.BackColor = SystemColors.Window
            Me.LogsRichTextBox.Dock = DockStyle.Fill
            Me.LogsRichTextBox.ForeColor = SystemColors.ControlText
            Me.LogsRichTextBox.Location = New Point(0, 0)
            Me.LogsRichTextBox.Name = "LogsRichTextBox"
            Me.LogsRichTextBox.ReadOnly = True
            Me.LogsRichTextBox.Size = New Size(708, 432)
            Me.LogsRichTextBox.TabIndex = 21
            Me.LogsRichTextBox.Text = ""
            位置同步Timer.Enabled = True
            位置同步Timer.Interval = 10
            AutoScaleDimensions = New SizeF(8F, 19F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(708, 432)
            Controls.Add(Me.LogsRichTextBox)
            DoubleBuffered = True
            Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134)
            FormBorderStyle = FormBorderStyle.None
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Name = "日志窗口"
            ShowInTaskbar = False
            StartPosition = FormStartPosition.CenterScreen
            Text = "日志窗口"
            ResumeLayout(False)
        End Sub

        Private Sub 日志窗口_Load(sender As Object, e As EventArgs)
            InitializeComponent()
            日志处理器实例 = New 日志处理模块.日志处理功能()
            日志处理器实例.绑定文本框(Me.LogsRichTextBox)
        End Sub

        Public Sub 添加日志(信息 As String, 日志类别 As Integer)
            ' 日志处理模块内部已处理线程 marshal（写文件同步、控件更新回 UI 线程）
            If 日志处理器实例 IsNot Nothing Then
                日志处理器实例.添加日志(信息, 日志类别)
            End If
        End Sub

        Public Sub 测试日志()
            日志处理器实例.测试日志()
        End Sub

        Public Sub 日志输出软件信息()
            日志处理器实例.日志输出软件信息()
        End Sub

        Public Sub 日志输出主程序配置()
            日志处理器实例.日志输出主程序配置()
        End Sub

        Public Sub 日志输出MC服务端配置()
            日志处理器实例.日志输出MC服务端配置()
        End Sub

        Public Sub 日志输出SFTP配置()
            日志处理器实例.日志输出SFTP配置()
        End Sub

        Public Sub 日志输出7zip配置()
            日志处理器实例.日志输出7zip配置()
        End Sub

        Public Sub 更新停靠位置(目标窗口 As Form)
            ' 总是用传入的显示窗口作为目标（不用 MainForm 默认实例，默认实例可能未显示导致日志窗口被隐藏）
            当前目标窗口 = 目标窗口
            If Not 配置文件操作模块.日志窗口隐藏状态 Then
                Visible = 目标窗口.Visible
                If TypeOf 目标窗口 Is MainForm Then
                    ' 主界面时：日志框左上角锁定到主界面内部约 (50,30)，与 C# 原版一致（PointToScreen(30,30) 语义）
                    Location = 目标窗口.PointToScreen(New Point(30, 30))
                    Size = New Size(650, 410)
                Else
                    Dim location As Point = New Point(目标窗口.Left - Width, 目标窗口.Top + (目标窗口.Height - Height) \ 2)
                    MyBase.Location = location
                End If
            End If
        End Sub

        Private Sub 位置同步Timer_Tick(sender As Object, e As EventArgs)
            If Not 配置文件操作模块.日志窗口隐藏状态 AndAlso 当前目标窗口 IsNot Nothing AndAlso Not 当前目标窗口.IsDisposed Then
                Visible = 当前目标窗口.Visible
                If TypeOf 当前目标窗口 Is MainForm Then
                    MyBase.Location = 当前目标窗口.PointToScreen(New Point(30, 30))
                    Return
                End If
                Dim location As Point = New Point(当前目标窗口.Left - Width, 当前目标窗口.Top + (当前目标窗口.Height - Height) \ 2)
                MyBase.Location = location
            End If
        End Sub
    End Class
End Namespace
