Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <DesignerGenerated>
    Partial Public Class ServiceSettingsForm
        Inherits Form
        Private _Label1 As Label
        Friend Property Label1 As Label
            Get
                Return _Label1
            End Get
            Set(value As Label)
                _Label1 = value
            End Set
        End Property

        Private components As IContainer

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("SetupButton")>
        Private _SetupButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ButtonUninstall")>
        Private _ButtonUninstall As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("Buttondone")>
        Private _Buttondone As Button
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label1")]
''' 	internal virtual System.Windows.Forms.Label Label1
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property SetupButton As Button
            <CompilerGenerated>
            Get
                Return _SetupButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf SetupButton_Click
                Dim lSetupButton = _SetupButton
                If lSetupButton IsNot Nothing Then
                    RemoveHandler lSetupButton.Click, value2
                End If
                _SetupButton = value
                lSetupButton = _SetupButton
                If lSetupButton IsNot Nothing Then
                    AddHandler lSetupButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ButtonUninstall As Button
            <CompilerGenerated>
            Get
                Return _ButtonUninstall
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ButtonUninstall_Click
                Dim lButtonUninstall = _ButtonUninstall
                If lButtonUninstall IsNot Nothing Then
                    RemoveHandler lButtonUninstall.Click, value2
                End If
                _ButtonUninstall = value
                lButtonUninstall = _ButtonUninstall
                If lButtonUninstall IsNot Nothing Then
                    AddHandler lButtonUninstall.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Buttondone As Button
            <CompilerGenerated>
            Get
                Return _Buttondone
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf Buttondone_Click
                Dim lButtondone = _Buttondone
                If lButtondone IsNot Nothing Then
                    RemoveHandler lButtondone.Click, value2
                End If
                _Buttondone = value
                lButtondone = _Buttondone
                If lButtondone IsNot Nothing Then
                    AddHandler lButtondone.Click, value2
                End If
            End Set
        End Property

        Public Sub New()
            AddHandler Activated, AddressOf ServiceSettingsForm_Activated
            AddHandler Move, AddressOf ServiceSettingsForm_Move
            InitializeComponent()
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
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(ServiceSettingsForm))
            Me.Label1 = New Label()
            SetupButton = New Button()
            ButtonUninstall = New Button()
            Buttondone = New Button()
            SuspendLayout()
            Me.Label1.AutoSize = True
            Me.Label1.Location = New Point(45, 30)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(300, 19)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "安装为系统服务可自动运行,服务名称:BBZBackup"
            SetupButton.Location = New Point(12, 140)
            SetupButton.Name = "SetupButton"
            SetupButton.Size = New Size(100, 50)
            SetupButton.TabIndex = 1
            SetupButton.Text = "安装服务"
            SetupButton.UseVisualStyleBackColor = True
            ButtonUninstall.Location = New Point(133, 140)
            ButtonUninstall.Name = "ButtonUninstall"
            ButtonUninstall.Size = New Size(100, 50)
            ButtonUninstall.TabIndex = 2
            ButtonUninstall.Text = "卸载服务"
            ButtonUninstall.UseVisualStyleBackColor = True
            Buttondone.Location = New Point(255, 140)
            Buttondone.Name = "Buttondone"
            Buttondone.Size = New Size(100, 50)
            Buttondone.TabIndex = 3
            Buttondone.Text = "完成"
            Buttondone.UseVisualStyleBackColor = True
            AcceptButton = Buttondone
            AutoScaleDimensions = New SizeF(8F, 19F)
            AutoScaleMode = AutoScaleMode.Font
            CancelButton = Buttondone
            ClientSize = New Size(380, 257)
            ControlBox = False
            Controls.Add(Buttondone)
            Controls.Add(ButtonUninstall)
            Controls.Add(SetupButton)
            Controls.Add(Me.Label1)
            Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134)
            ForeColor = SystemColors.ControlText
            FormBorderStyle = FormBorderStyle.FixedSingle
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Location = New Point(1050, 400)
            MaximizeBox = False
            MinimizeBox = False
            Name = "ServiceSettingsForm"
            ShowIcon = False
            ShowInTaskbar = False
            StartPosition = FormStartPosition.Manual
            Text = "安装/卸载系统服务"
            TopMost = True
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Private Sub Buttondone_Click(sender As Object, e As EventArgs)
            Dim num As Integer = MessageBox.Show("确认退出?", "提示", MessageBoxButtons.YesNo)
            If num = 6 Then
                日志窗口.添加日志("关闭服务设置窗口", 5)
                Close()
            End If
        End Sub

        Private Sub SetupButton_Click(sender As Object, e As EventArgs)
            MessageBox.Show("尚未实现", "等等吧", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Sub

        Private Sub ButtonUninstall_Click(sender As Object, e As EventArgs)
            MessageBox.Show("尚未实现", "等等吧", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Sub

        Private Sub ServiceSettingsForm_Activated(sender As Object, e As EventArgs)
            If Owner IsNot Nothing AndAlso TypeOf Owner Is MainForm Then
                日志窗口.更新停靠位置(Me)
            End If
        End Sub

        Private Sub ServiceSettingsForm_Move(sender As Object, e As EventArgs)
            If Owner IsNot Nothing AndAlso TypeOf Owner Is MainForm Then
                日志窗口.更新停靠位置(Me)
            End If
        End Sub
    End Class
End Namespace
