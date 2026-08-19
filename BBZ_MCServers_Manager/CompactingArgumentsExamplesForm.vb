Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <DesignerGenerated>
    Partial Public Class CompactingArgumentsExamplesForm
        Inherits Form
        Private _CPU线程数 As TextBox
        Friend Property CPU线程数 As TextBox
            Get
                Return _CPU线程数
            End Get
            Set(value As TextBox)
                _CPU线程数 = value
            End Set
        End Property
        Private _Label1 As Label
        Friend Property Label1 As Label
            Get
                Return _Label1
            End Get
            Set(value As Label)
                _Label1 = value
            End Set
        End Property
        Private _Label2 As Label
        Friend Property Label2 As Label
            Get
                Return _Label2
            End Get
            Set(value As Label)
                _Label2 = value
            End Set
        End Property
        Private _Label3 As Label
        Friend Property Label3 As Label
            Get
                Return _Label3
            End Get
            Set(value As Label)
                _Label3 = value
            End Set
        End Property
        Private _Label5 As Label
        Friend Property Label5 As Label
            Get
                Return _Label5
            End Get
            Set(value As Label)
                _Label5 = value
            End Set
        End Property
        Private _Label9 As Label
        Friend Property Label9 As Label
            Get
                Return _Label9
            End Get
            Set(value As Label)
                _Label9 = value
            End Set
        End Property
        Private _选择字典大小 As ComboBox
        Friend Property 选择字典大小 As ComboBox
            Get
                Return _选择字典大小
            End Get
            Set(value As ComboBox)
                _选择字典大小 = value
            End Set
        End Property

        Private components As IContainer

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("Button1")>
        Private _Button1 As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ComboBox1")>
        Private _ComboBox1 As ComboBox

        Friend Overridable Property Button1 As Button
            <CompilerGenerated>
            Get
                Return _Button1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf Button1_Click
                Dim button = _Button1
                If button IsNot Nothing Then
                    RemoveHandler button.Click, value2
                End If
                _Button1 = value
                button = _Button1
                If button IsNot Nothing Then
                    AddHandler button.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ComboBox1 As ComboBox
            <CompilerGenerated>
            Get
                Return _ComboBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As ComboBox)
                Dim value2 As EventHandler = AddressOf ComboBox1_SelectedIndexChanged
                Dim comboBox = _ComboBox1
                If comboBox IsNot Nothing Then
                    RemoveHandler comboBox.SelectedIndexChanged, value2
                End If
                _ComboBox1 = value
                comboBox = _ComboBox1
                If comboBox IsNot Nothing Then
                    AddHandler comboBox.SelectedIndexChanged, value2
                End If
            End Set
        End Property

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
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("选择字典大小")]
''' 	internal virtual System.Windows.Forms.ComboBox 选择字典大小
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label9")]
''' 	internal virtual System.Windows.Forms.Label Label9
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label5")]
''' 	internal virtual System.Windows.Forms.Label Label5
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("CPU线程数")]
''' 	internal virtual System.Windows.Forms.TextBox CPU线程数
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label3")]
''' 	internal virtual System.Windows.Forms.Label Label3
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label2")]
''' 	internal virtual System.Windows.Forms.Label Label2
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Public Sub New()
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
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(CompactingArgumentsExamplesForm))
            Button1 = New Button()
            ComboBox1 = New ComboBox()
            Me.Label1 = New Label()
            Me.选择字典大小 = New ComboBox()
            Me.Label9 = New Label()
            Me.Label5 = New Label()
            Me.CPU线程数 = New TextBox()
            Me.Label3 = New Label()
            Me.Label2 = New Label()
            SuspendLayout()
            Button1.Location = New Point(804, 543)
            Button1.Name = "Button1"
            Button1.Size = New Size(119, 45)
            Button1.TabIndex = 0
            Button1.Text = "关掉"
            Button1.UseVisualStyleBackColor = True
            ComboBox1.FormattingEnabled = True
            ComboBox1.Items.AddRange(New Object() {"1MB", "100MB", "500MB", "1G", "2G", "4G", "6G", "8G", "10G", "12G", "14G", "16G", "18G", "20G", "24G", "28G", "32G", "36G", "40G", "48G", "56G", "64G", "72G", "78G", "86G", "92G", "100G", "120G", "160G", "1083G"})
            ComboBox1.Location = New Point(312, 19)
            ComboBox1.Name = "ComboBox1"
            ComboBox1.Size = New Size(150, 27)
            ComboBox1.TabIndex = 1
            Me.Label1.AutoSize = True
            Me.Label1.Location = New Point(25, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(281, 19)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "您(希望或你能够)分配给7z压缩时使用的内存量"
            Me.选择字典大小.FormattingEnabled = True
            Me.选择字典大小.Items.AddRange(New Object() {"0-仅存储(取决于硬盘速度,最快)", "1-极速压缩", "2", "3-快速压缩", "4", "5-标准压缩", "6", "7-最大压缩", "8", "9-极限压缩(取决于CPU等硬件,最慢)"})
            Me.选择字典大小.Location = New Point(92, 81)
            Me.选择字典大小.Name = "选择字典大小"
            Me.选择字典大小.Size = New Size(185, 27)
            Me.选择字典大小.TabIndex = 146
            Me.Label9.AutoSize = True
            Me.Label9.Location = New Point(25, 84)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Size(61, 19)
            Me.Label9.TabIndex = 145
            Me.Label9.Text = "字典大小"
            Me.Label5.AutoSize = True
            Me.Label5.Location = New Point(25, 51)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(120, 19)
            Me.Label5.TabIndex = 143
            Me.Label5.Text = "压缩方法：LZMA2"
            Me.CPU线程数.Location = New Point(146, 114)
            Me.CPU线程数.Name = "CPU线程数"
            Me.CPU线程数.Size = New Size(131, 24)
            Me.CPU线程数.TabIndex = 142
            Me.Label3.AutoSize = True
            Me.Label3.Location = New Point(25, 117)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(115, 19)
            Me.Label3.TabIndex = 141
            Me.Label3.Text = "使用的CPU线程数"
            Me.Label2.AutoSize = True
            Me.Label2.Location = New Point(25, 175)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(773, 304)
            Me.Label2.TabIndex = 149
            Me.Label2.Text = resources.GetString("Label2.Text")
            AutoScaleDimensions = New SizeF(8F, 19F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(925, 590)
            ControlBox = False
            Controls.Add(Me.Label2)
            Controls.Add(Me.选择字典大小)
            Controls.Add(Me.Label9)
            Controls.Add(Me.Label5)
            Controls.Add(Me.CPU线程数)
            Controls.Add(Me.Label3)
            Controls.Add(Me.Label1)
            Controls.Add(ComboBox1)
            Controls.Add(Button1)
            Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134)
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            MaximizeBox = False
            MinimizeBox = False
            Name = "CompactingArgumentsExamplesForm"
            ShowInTaskbar = False
            StartPosition = FormStartPosition.CenterScreen
            Text = "压缩参数示例"
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            Close()
        End Sub

        Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
            Dim selectedIndex = ComboBox1.SelectedIndex
            If selectedIndex = 1 Then
            End If
        End Sub
    End Class
End Namespace
