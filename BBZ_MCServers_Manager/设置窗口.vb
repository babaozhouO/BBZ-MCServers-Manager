Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <DesignerGenerated>
    Partial Public Class 设置窗口
        Inherits Form
        Private _MC服务端设置 As TabPage
        Friend Property MC服务端设置 As TabPage
            Get
                Return _MC服务端设置
            End Get
            Set(value As TabPage)
                _MC服务端设置 = value
            End Set
        End Property
        Private _SevenZip设置 As TabPage
        Friend Property SevenZip设置 As TabPage
            Get
                Return _SevenZip设置
            End Get
            Set(value As TabPage)
                _SevenZip设置 = value
            End Set
        End Property
        Private _Sftp服务器设置 As TabPage
        Friend Property Sftp服务器设置 As TabPage
            Get
                Return _Sftp服务器设置
            End Get
            Set(value As TabPage)
                _Sftp服务器设置 = value
            End Set
        End Property
        Private _TabControl1 As TabControl
        Friend Property TabControl1 As TabControl
            Get
                Return _TabControl1
            End Get
            Set(value As TabControl)
                _TabControl1 = value
            End Set
        End Property
        Private _TableLayoutPanel1 As TableLayoutPanel
        Friend Property TableLayoutPanel1 As TableLayoutPanel
            Get
                Return _TableLayoutPanel1
            End Get
            Set(value As TableLayoutPanel)
                _TableLayoutPanel1 = value
            End Set
        End Property
        Private _TableLayoutPanel2 As TableLayoutPanel
        Friend Property TableLayoutPanel2 As TableLayoutPanel
            Get
                Return _TableLayoutPanel2
            End Get
            Set(value As TableLayoutPanel)
                _TableLayoutPanel2 = value
            End Set
        End Property
        Private _TableLayoutPanel3 As TableLayoutPanel
        Friend Property TableLayoutPanel3 As TableLayoutPanel
            Get
                Return _TableLayoutPanel3
            End Get
            Set(value As TableLayoutPanel)
                _TableLayoutPanel3 = value
            End Set
        End Property
        Private _TableLayoutPanel4 As TableLayoutPanel
        Friend Property TableLayoutPanel4 As TableLayoutPanel
            Get
                Return _TableLayoutPanel4
            End Get
            Set(value As TableLayoutPanel)
                _TableLayoutPanel4 = value
            End Set
        End Property
        Private _TableLayoutPanel5 As TableLayoutPanel
        Friend Property TableLayoutPanel5 As TableLayoutPanel
            Get
                Return _TableLayoutPanel5
            End Get
            Set(value As TableLayoutPanel)
                _TableLayoutPanel5 = value
            End Set
        End Property
        Private _TableLayoutPanel6 As TableLayoutPanel
        Friend Property TableLayoutPanel6 As TableLayoutPanel
            Get
                Return _TableLayoutPanel6
            End Get
            Set(value As TableLayoutPanel)
                _TableLayoutPanel6 = value
            End Set
        End Property
        Private _主程序设置 As TabPage
        Friend Property 主程序设置 As TabPage
            Get
                Return _主程序设置
            End Get
            Set(value As TabPage)
                _主程序设置 = value
            End Set
        End Property

        Private components As IContainer
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TableLayoutPanel1")]
''' 	internal virtual System.Windows.Forms.TableLayoutPanel TableLayoutPanel1
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TabControl1")]
''' 	internal virtual System.Windows.Forms.TabControl TabControl1
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("主程序设置")]
''' 	internal virtual System.Windows.Forms.TabPage 主程序设置
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("SevenZip设置")]
''' 	internal virtual System.Windows.Forms.TabPage SevenZip设置
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("MC服务端设置")]
''' 	internal virtual System.Windows.Forms.TabPage MC服务端设置
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Sftp服务器设置")]
''' 	internal virtual System.Windows.Forms.TabPage Sftp服务器设置
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TableLayoutPanel2")]
''' 	internal virtual System.Windows.Forms.TableLayoutPanel TableLayoutPanel2
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TableLayoutPanel3")]
''' 	internal virtual System.Windows.Forms.TableLayoutPanel TableLayoutPanel3
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TableLayoutPanel4")]
''' 	internal virtual System.Windows.Forms.TableLayoutPanel TableLayoutPanel4
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TableLayoutPanel5")]
''' 	internal virtual System.Windows.Forms.TableLayoutPanel TableLayoutPanel5
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TableLayoutPanel6")]
''' 	internal virtual System.Windows.Forms.TableLayoutPanel TableLayoutPanel6
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
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(设置窗口))
            Me.TableLayoutPanel1 = New TableLayoutPanel()
            Me.TabControl1 = New TabControl()
            Me.主程序设置 = New TabPage()
            Me.SevenZip设置 = New TabPage()
            Me.MC服务端设置 = New TabPage()
            Me.Sftp服务器设置 = New TabPage()
            Me.TableLayoutPanel2 = New TableLayoutPanel()
            Me.TableLayoutPanel3 = New TableLayoutPanel()
            Me.TableLayoutPanel4 = New TableLayoutPanel()
            Me.TableLayoutPanel5 = New TableLayoutPanel()
            Me.TableLayoutPanel6 = New TableLayoutPanel()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TabControl1.SuspendLayout()
            Me.主程序设置.SuspendLayout()
            Me.SevenZip设置.SuspendLayout()
            Me.MC服务端设置.SuspendLayout()
            Me.Sftp服务器设置.SuspendLayout()
            SuspendLayout()
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
            Me.TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
            Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 1)
            Me.TableLayoutPanel1.Dock = DockStyle.Fill
            Me.TableLayoutPanel1.Location = New Point(0, 0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 89.71774F))
            Me.TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.282258F))
            Me.TableLayoutPanel1.Size = New Size(858, 496)
            Me.TableLayoutPanel1.TabIndex = 0
            Me.TabControl1.Controls.Add(Me.主程序设置)
            Me.TabControl1.Controls.Add(Me.SevenZip设置)
            Me.TabControl1.Controls.Add(Me.MC服务端设置)
            Me.TabControl1.Controls.Add(Me.Sftp服务器设置)
            Me.TabControl1.Dock = DockStyle.Fill
            Me.TabControl1.Location = New Point(3, 3)
            Me.TabControl1.Name = "TabControl1"
            Me.TabControl1.SelectedIndex = 0
            Me.TabControl1.Size = New Size(852, 439)
            Me.TabControl1.TabIndex = 1
            Me.主程序设置.Controls.Add(Me.TableLayoutPanel2)
            Me.主程序设置.Location = New Point(4, 28)
            Me.主程序设置.Name = "主程序设置"
            Me.主程序设置.Padding = New Padding(3)
            Me.主程序设置.Size = New Size(844, 407)
            Me.主程序设置.TabIndex = 0
            Me.主程序设置.Text = "主程序设置"
            Me.主程序设置.UseVisualStyleBackColor = True
            Me.SevenZip设置.Controls.Add(Me.TableLayoutPanel3)
            Me.SevenZip设置.Location = New Point(4, 28)
            Me.SevenZip设置.Name = "SevenZip设置"
            Me.SevenZip设置.Padding = New Padding(3)
            Me.SevenZip设置.Size = New Size(741, 374)
            Me.SevenZip设置.TabIndex = 1
            Me.SevenZip设置.Text = "7Zip设置"
            Me.SevenZip设置.UseVisualStyleBackColor = True
            Me.MC服务端设置.Controls.Add(Me.TableLayoutPanel4)
            Me.MC服务端设置.Location = New Point(4, 28)
            Me.MC服务端设置.Name = "MC服务端设置"
            Me.MC服务端设置.Padding = New Padding(3)
            Me.MC服务端设置.Size = New Size(741, 374)
            Me.MC服务端设置.TabIndex = 2
            Me.MC服务端设置.Text = "MC服务端设置"
            Me.MC服务端设置.UseVisualStyleBackColor = True
            Me.Sftp服务器设置.Controls.Add(Me.TableLayoutPanel5)
            Me.Sftp服务器设置.Location = New Point(4, 28)
            Me.Sftp服务器设置.Name = "Sftp服务器设置"
            Me.Sftp服务器设置.Padding = New Padding(3)
            Me.Sftp服务器设置.Size = New Size(741, 374)
            Me.Sftp服务器设置.TabIndex = 3
            Me.Sftp服务器设置.Text = "Sftp服务器设置"
            Me.Sftp服务器设置.UseVisualStyleBackColor = True
            Me.TableLayoutPanel2.ColumnCount = 2
            Me.TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel2.Dock = DockStyle.Fill
            Me.TableLayoutPanel2.Location = New Point(3, 3)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 2
            Me.TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel2.Size = New Size(838, 401)
            Me.TableLayoutPanel2.TabIndex = 0
            Me.TableLayoutPanel3.ColumnCount = 2
            Me.TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel3.Dock = DockStyle.Fill
            Me.TableLayoutPanel3.Location = New Point(3, 3)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 2
            Me.TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel3.Size = New Size(735, 368)
            Me.TableLayoutPanel3.TabIndex = 0
            Me.TableLayoutPanel4.ColumnCount = 2
            Me.TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel4.Dock = DockStyle.Fill
            Me.TableLayoutPanel4.Location = New Point(3, 3)
            Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
            Me.TableLayoutPanel4.RowCount = 2
            Me.TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel4.Size = New Size(735, 368)
            Me.TableLayoutPanel4.TabIndex = 1
            Me.TableLayoutPanel5.ColumnCount = 2
            Me.TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel5.Dock = DockStyle.Fill
            Me.TableLayoutPanel5.Location = New Point(3, 3)
            Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
            Me.TableLayoutPanel5.RowCount = 2
            Me.TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
            Me.TableLayoutPanel5.Size = New Size(735, 368)
            Me.TableLayoutPanel5.TabIndex = 1
            Me.TableLayoutPanel6.ColumnCount = 3
            Me.TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 66.666664F))
            Me.TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.90141F))
            Me.TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.314554F))
            Me.TableLayoutPanel6.Dock = DockStyle.Fill
            Me.TableLayoutPanel6.Location = New Point(3, 448)
            Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
            Me.TableLayoutPanel6.RowCount = 1
            Me.TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
            Me.TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
            Me.TableLayoutPanel6.Size = New Size(852, 45)
            Me.TableLayoutPanel6.TabIndex = 2
            AutoScaleDimensions = New SizeF(96F, 96F)
            AutoScaleMode = AutoScaleMode.Dpi
            ClientSize = New Size(858, 496)
            Controls.Add(Me.TableLayoutPanel1)
            Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134)
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Name = "设置窗口"
            StartPosition = FormStartPosition.Manual
            Text = "设置窗口"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TabControl1.ResumeLayout(False)
            Me.主程序设置.ResumeLayout(False)
            Me.SevenZip设置.ResumeLayout(False)
            Me.MC服务端设置.ResumeLayout(False)
            Me.Sftp服务器设置.ResumeLayout(False)
            ResumeLayout(False)
        End Sub
    End Class
End Namespace
