Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <DesignerGenerated>
    Partial Public Class SevenZipSettingsForm
        Inherits Form
        Private _CheckBox1 As CheckBox
        Friend Property CheckBox1 As CheckBox
            Get
                Return _CheckBox1
            End Get
            Set(value As CheckBox)
                _CheckBox1 = value
            End Set
        End Property
        Private _CheckBox2 As CheckBox
        Friend Property CheckBox2 As CheckBox
            Get
                Return _CheckBox2
            End Get
            Set(value As CheckBox)
                _CheckBox2 = value
            End Set
        End Property
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
        Private _Label10 As Label
        Friend Property Label10 As Label
            Get
                Return _Label10
            End Get
            Set(value As Label)
                _Label10 = value
            End Set
        End Property
        Private _Label11 As Label
        Friend Property Label11 As Label
            Get
                Return _Label11
            End Get
            Set(value As Label)
                _Label11 = value
            End Set
        End Property
        Private _Label17 As Label
        Friend Property Label17 As Label
            Get
                Return _Label17
            End Get
            Set(value As Label)
                _Label17 = value
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
        Private _Label4 As Label
        Friend Property Label4 As Label
            Get
                Return _Label4
            End Get
            Set(value As Label)
                _Label4 = value
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
        Private _Label6 As Label
        Friend Property Label6 As Label
            Get
                Return _Label6
            End Get
            Set(value As Label)
                _Label6 = value
            End Set
        End Property
        Private _Label7 As Label
        Friend Property Label7 As Label
            Get
                Return _Label7
            End Get
            Set(value As Label)
                _Label7 = value
            End Set
        End Property
        Private _Label8 As Label
        Friend Property Label8 As Label
            Get
                Return _Label8
            End Get
            Set(value As Label)
                _Label8 = value
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
        Private _label压缩格式 As Label
        Friend Property label压缩格式 As Label
            Get
                Return _label压缩格式
            End Get
            Set(value As Label)
                _label压缩格式 = value
            End Set
        End Property
        Private _label压缩级别 As Label
        Friend Property label压缩级别 As Label
            Get
                Return _label压缩级别
            End Get
            Set(value As Label)
                _label压缩级别 = value
            End Set
        End Property
        Private _TextBox1 As TextBox
        Friend Property TextBox1 As TextBox
            Get
                Return _TextBox1
            End Get
            Set(value As TextBox)
                _TextBox1 = value
            End Set
        End Property
        Private _TextBox2 As TextBox
        Friend Property TextBox2 As TextBox
            Get
                Return _TextBox2
            End Get
            Set(value As TextBox)
                _TextBox2 = value
            End Set
        End Property
        Private _TextBox3 As TextBox
        Friend Property TextBox3 As TextBox
            Get
                Return _TextBox3
            End Get
            Set(value As TextBox)
                _TextBox3 = value
            End Set
        End Property
        Private _TextBox4 As TextBox
        Friend Property TextBox4 As TextBox
            Get
                Return _TextBox4
            End Get
            Set(value As TextBox)
                _TextBox4 = value
            End Set
        End Property
        Private _选择单词大小 As ComboBox
        Friend Property 选择单词大小 As ComboBox
            Get
                Return _选择单词大小
            End Get
            Set(value As ComboBox)
                _选择单词大小 = value
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
        <AccessedThroughProperty("ButtonCancle")>
        Private _ButtonCancle As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ButtonSaveAndExit")>
        Private _ButtonSaveAndExit As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("选择压缩格式")>
        Private _选择压缩格式 As ComboBox

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("选择压缩级别")>
        Private _选择压缩级别 As ComboBox

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("Button1")>
        Private _Button1 As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("Button2")>
        Private _Button2 As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("选择压缩方法")>
        Private _选择压缩方法 As ComboBox

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("Button3")>
        Private _Button3 As Button
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("label压缩格式")]
''' 	internal virtual System.Windows.Forms.Label label压缩格式
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("label压缩级别")]
''' 	internal virtual System.Windows.Forms.Label label压缩级别
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property ButtonCancle As Button
            <CompilerGenerated>
            Get
                Return _ButtonCancle
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ButtonCancle_Click
                Dim lButtonCancle = _ButtonCancle
                If lButtonCancle IsNot Nothing Then
                    RemoveHandler lButtonCancle.Click, value2
                End If
                _ButtonCancle = value
                lButtonCancle = _ButtonCancle
                If lButtonCancle IsNot Nothing Then
                    AddHandler lButtonCancle.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ButtonSaveAndExit As Button
            <CompilerGenerated>
            Get
                Return _ButtonSaveAndExit
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ButtonSaveAndExit_Click
                Dim lButtonSaveAndExit = _ButtonSaveAndExit
                If lButtonSaveAndExit IsNot Nothing Then
                    RemoveHandler lButtonSaveAndExit.Click, value2
                End If
                _ButtonSaveAndExit = value
                lButtonSaveAndExit = _ButtonSaveAndExit
                If lButtonSaveAndExit IsNot Nothing Then
                    AddHandler lButtonSaveAndExit.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property 选择压缩格式 As ComboBox
            <CompilerGenerated>
            Get
                Return _选择压缩格式
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As ComboBox)
                Dim value2 As EventHandler = AddressOf 选择压缩格式_索引变化
                Dim comboBox = _选择压缩格式
                If comboBox IsNot Nothing Then
                    RemoveHandler comboBox.SelectedIndexChanged, value2
                End If
                _选择压缩格式 = value
                comboBox = _选择压缩格式
                If comboBox IsNot Nothing Then
                    AddHandler comboBox.SelectedIndexChanged, value2
                End If
            End Set
        End Property

        Friend Overridable Property 选择压缩级别 As ComboBox
            <CompilerGenerated>
            Get
                Return _选择压缩级别
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As ComboBox)
                Dim value2 As EventHandler = AddressOf 选择压缩级别_SelectedIndexChanged
                Dim comboBox = _选择压缩级别
                If comboBox IsNot Nothing Then
                    RemoveHandler comboBox.SelectedIndexChanged, value2
                End If
                _选择压缩级别 = value
                comboBox = _选择压缩级别
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

                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TextBox2")]
''' 	internal virtual System.Windows.Forms.TextBox TextBox2
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("CheckBox1")]
''' 	internal virtual System.Windows.Forms.CheckBox CheckBox1
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property Button2 As Button
            <CompilerGenerated>
            Get
                Return _Button2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf Button2_Click
                Dim button = _Button2
                If button IsNot Nothing Then
                    RemoveHandler button.Click, value2
                End If
                _Button2 = value
                button = _Button2
                If button IsNot Nothing Then
                    AddHandler button.Click, value2
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TextBox1")]
''' 	internal virtual System.Windows.Forms.TextBox TextBox1
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
                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("CheckBox2")]
''' 	internal virtual System.Windows.Forms.CheckBox CheckBox2
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label4")]
''' 	internal virtual System.Windows.Forms.Label Label4
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

        Friend Overridable Property 选择压缩方法 As ComboBox
            <CompilerGenerated>
            Get
                Return _选择压缩方法
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As ComboBox)
                Dim value2 As EventHandler = AddressOf 选择压缩方法_SelectedIndexChanged
                Dim comboBox = _选择压缩方法
                If comboBox IsNot Nothing Then
                    RemoveHandler comboBox.SelectedIndexChanged, value2
                End If
                _选择压缩方法 = value
                comboBox = _选择压缩方法
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TextBox3")]
''' 	internal virtual System.Windows.Forms.TextBox TextBox3
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label6")]
''' 	internal virtual System.Windows.Forms.Label Label6
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label7")]
''' 	internal virtual System.Windows.Forms.Label Label7
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("选择单词大小")]
''' 	internal virtual System.Windows.Forms.ComboBox 选择单词大小
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label8")]
''' 	internal virtual System.Windows.Forms.Label Label8
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label10")]
''' 	internal virtual System.Windows.Forms.Label Label10
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TextBox4")]
''' 	internal virtual System.Windows.Forms.TextBox TextBox4
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label11")]
''' 	internal virtual System.Windows.Forms.Label Label11
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label17")]
''' 	internal virtual System.Windows.Forms.Label Label17
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property Button3 As Button
            <CompilerGenerated>
            Get
                Return _Button3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf Button3_Click
                Dim button = _Button3
                If button IsNot Nothing Then
                    RemoveHandler button.Click, value2
                End If
                _Button3 = value
                button = _Button3
                If button IsNot Nothing Then
                    AddHandler button.Click, value2
                End If
            End Set
        End Property

        Public Sub New()
            AddHandler Load, AddressOf SevenZipSettingsForm_Load
            AddHandler Activated, AddressOf SevenZipSettingsForm_Activated
            AddHandler Move, AddressOf SevenZipSettingsForm_Move
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
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(SevenZipSettingsForm))
            Me.label压缩格式 = New Label()
            Me.label压缩级别 = New Label()
            ButtonCancle = New Button()
            ButtonSaveAndExit = New Button()
            选择压缩格式 = New ComboBox()
            选择压缩级别 = New ComboBox()
            Me.Label1 = New Label()
            Button1 = New Button()
            Me.TextBox2 = New TextBox()
            Me.CheckBox1 = New CheckBox()
            Button2 = New Button()
            Me.TextBox1 = New TextBox()
            Me.Label2 = New Label()
            Me.CheckBox2 = New CheckBox()
            Me.CPU线程数 = New TextBox()
            Me.Label3 = New Label()
            Me.Label4 = New Label()
            Me.Label5 = New Label()
            选择压缩方法 = New ComboBox()
            Me.TextBox3 = New TextBox()
            Me.Label6 = New Label()
            Me.Label7 = New Label()
            Me.选择单词大小 = New ComboBox()
            Me.Label8 = New Label()
            Me.选择字典大小 = New ComboBox()
            Me.Label9 = New Label()
            Me.Label10 = New Label()
            Me.TextBox4 = New TextBox()
            Me.Label11 = New Label()
            Me.Label17 = New Label()
            Button3 = New Button()
            SuspendLayout()
            Me.label压缩格式.AutoSize = True
            Me.label压缩格式.Location = New Point(46, 38)
            Me.label压缩格式.Name = "label压缩格式"
            Me.label压缩格式.Size = New Size(61, 19)
            Me.label压缩格式.TabIndex = 1
            Me.label压缩格式.Text = "压缩格式"
            Me.label压缩级别.AutoSize = True
            Me.label压缩级别.Location = New Point(46, 70)
            Me.label压缩级别.Name = "label压缩级别"
            Me.label压缩级别.Size = New Size(61, 19)
            Me.label压缩级别.TabIndex = 2
            Me.label压缩级别.Text = "压缩等级"
            ButtonCancle.Location = New Point(613, 470)
            ButtonCancle.Name = "ButtonCancle"
            ButtonCancle.Size = New Size(93, 50)
            ButtonCancle.TabIndex = 5
            ButtonCancle.Text = "取消"
            ButtonCancle.UseVisualStyleBackColor = True
            ButtonSaveAndExit.Location = New Point(733, 470)
            ButtonSaveAndExit.Name = "ButtonSaveAndExit"
            ButtonSaveAndExit.Size = New Size(93, 50)
            ButtonSaveAndExit.TabIndex = 4
            ButtonSaveAndExit.Text = "保存并关闭"
            ButtonSaveAndExit.UseVisualStyleBackColor = True
            选择压缩格式.FormattingEnabled = True
            选择压缩格式.Items.AddRange(New Object() {"7z-压缩率最高,兼容性稍差", "tar-仅打包(需要配合gzip使用)", "wim-仅打包(7z对wim方法支持较差)", "zip-兼容性最好,压缩率中等"})
            选择压缩格式.Location = New Point(113, 35)
            选择压缩格式.MaxDropDownItems = 7
            选择压缩格式.Name = "选择压缩格式"
            选择压缩格式.Size = New Size(185, 27)
            选择压缩格式.TabIndex = 6
            选择压缩级别.FormattingEnabled = True
            选择压缩级别.Items.AddRange(New Object() {"0-仅存储(取决于硬盘速度,最快)", "1-极速压缩", "2", "3-快速压缩", "4", "5-标准压缩", "6", "7-最大压缩", "8", "9-极限压缩(取决于CPU等硬件,最慢)"})
            选择压缩级别.Location = New Point(113, 67)
            选择压缩级别.Name = "选择压缩级别"
            选择压缩级别.Size = New Size(185, 27)
            选择压缩级别.TabIndex = 7
            Me.Label1.AutoSize = True
            Me.Label1.Location = New Point(323, 98)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(87, 19)
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "备份输出目录"
            Button1.Location = New Point(834, 95)
            Button1.Name = "Button1"
            Button1.Size = New Size(24, 24)
            Button1.TabIndex = 119
            Button1.UseVisualStyleBackColor = True
            Me.TextBox2.Location = New Point(416, 95)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New Size(412, 24)
            Me.TextBox2.TabIndex = 118
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Location = New Point(323, 125)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New Size(106, 23)
            Me.CheckBox1.TabIndex = 120
            Me.CheckBox1.Text = "是否增量备份"
            Me.CheckBox1.UseVisualStyleBackColor = True
            Button2.Location = New Point(834, 35)
            Button2.Name = "Button2"
            Button2.Size = New Size(24, 24)
            Button2.TabIndex = 123
            Button2.UseVisualStyleBackColor = True
            Me.TextBox1.Location = New Point(429, 35)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New Size(399, 24)
            Me.TextBox1.TabIndex = 122
            Me.Label2.AutoSize = True
            Me.Label2.Location = New Point(323, 38)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(100, 19)
            Me.Label2.TabIndex = 121
            Me.Label2.Text = "自定义备份目录"
            Me.CheckBox2.AutoSize = True
            Me.CheckBox2.Location = New Point(435, 125)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New Size(119, 23)
            Me.CheckBox2.TabIndex = 124
            Me.CheckBox2.Text = "备份自定义目录"
            Me.CheckBox2.UseVisualStyleBackColor = True
            Me.CPU线程数.Location = New Point(167, 199)
            Me.CPU线程数.Name = "CPU线程数"
            Me.CPU线程数.Size = New Size(131, 24)
            Me.CPU线程数.TabIndex = 126
            Me.Label3.AutoSize = True
            Me.Label3.Location = New Point(46, 202)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(115, 19)
            Me.Label3.TabIndex = 125
            Me.Label3.Text = "使用的CPU线程数"
            Me.Label4.AutoSize = True
            Me.Label4.Font = New Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134)
            Me.Label4.Location = New Point(46, 319)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(812, 62)
            Me.Label4.TabIndex = 127
            Me.Label4.Text = "使用LZMA/LZMA2压缩方法压缩产生的压缩包请使用7z打开" & vbCrLf & "使用其它软件可能无法打开，若没有7z可在没用的小工具窗口中点击安装7z"
            Me.Label5.AutoSize = True
            Me.Label5.Location = New Point(46, 103)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(61, 19)
            Me.Label5.TabIndex = 128
            Me.Label5.Text = "压缩方法"
            选择压缩方法.FormattingEnabled = True
            选择压缩方法.Location = New Point(113, 100)
            选择压缩方法.Name = "选择压缩方法"
            选择压缩方法.Size = New Size(185, 27)
            选择压缩方法.TabIndex = 129
            Me.TextBox3.Location = New Point(143, 229)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New Size(127, 24)
            Me.TextBox3.TabIndex = 131
            Me.Label6.AutoSize = True
            Me.Label6.Location = New Point(46, 232)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Size(91, 19)
            Me.Label6.TabIndex = 130
            Me.Label6.Text = "压缩超时时长:"
            Me.Label7.AutoSize = True
            Me.Label7.Location = New Point(276, 232)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Size(22, 19)
            Me.Label7.TabIndex = 132
            Me.Label7.Text = "秒"
            Me.选择单词大小.FormattingEnabled = True
            Me.选择单词大小.Location = New Point(113, 166)
            Me.选择单词大小.Name = "选择单词大小"
            Me.选择单词大小.Size = New Size(185, 27)
            Me.选择单词大小.TabIndex = 136
            Me.Label8.AutoSize = True
            Me.Label8.Location = New Point(46, 169)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Size(61, 19)
            Me.Label8.TabIndex = 135
            Me.Label8.Text = "单词大小"
            Me.选择字典大小.FormattingEnabled = True
            Me.选择字典大小.Items.AddRange(New Object() {"0-仅存储(取决于硬盘速度,最快)", "1-极速压缩", "2", "3-快速压缩", "4", "5-标准压缩", "6", "7-最大压缩", "8", "9-极限压缩(取决于CPU等硬件,最慢)"})
            Me.选择字典大小.Location = New Point(113, 133)
            Me.选择字典大小.Name = "选择字典大小"
            Me.选择字典大小.Size = New Size(185, 27)
            Me.选择字典大小.TabIndex = 134
            Me.Label9.AutoSize = True
            Me.Label9.Location = New Point(46, 136)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Size(61, 19)
            Me.Label9.TabIndex = 133
            Me.Label9.Text = "字典大小"
            Me.Label10.AutoSize = True
            Me.Label10.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134)
            Me.Label10.Location = New Point(46, 396)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New Size(499, 44)
            Me.Label10.TabIndex = 137
            Me.Label10.Text = "建议设置压缩参数时，右键任意文件夹选择7-zip的添加到压缩包选项" & vbCrLf & "选择好合适的压缩参数再转移到本程序内(注意内存占用)"
            Me.TextBox4.Location = New Point(520, 65)
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Size = New Size(338, 24)
            Me.TextBox4.TabIndex = 139
            Me.Label11.AutoSize = True
            Me.Label11.Location = New Point(323, 68)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New Size(191, 19)
            Me.Label11.TabIndex = 138
            Me.Label11.Text = "自定义备份目录的排除文件参数"
            Me.Label17.AutoSize = True
            Me.Label17.Location = New Point(323, 151)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New Size(456, 76)
            Me.Label17.TabIndex = 182
            Me.Label17.Text = "排除文件拓展名为" & ChrW(8220) & "tmp" & ChrW(8221) & "的文件示例：-x!""*.tmp""" & vbCrLf & "排除error.txt文件示例：-x!""error.txt"" " & vbCrLf & "排除logs文件夹参数示例：-x!""logs""" & vbCrLf & "已固定排除-x!""tmp"" -x!"" * .tmp"" -x!""Thumbs.db"" -x!""$RECYCLE.BIN"""
            Button3.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134)
            Button3.Location = New Point(46, 259)
            Button3.Name = "Button3"
            Button3.Size = New Size(252, 57)
            Button3.TabIndex = 183
            Button3.Text = "点我查看压缩参数示例"
            Button3.UseVisualStyleBackColor = True
            AutoScaleDimensions = New SizeF(8F, 19F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(884, 561)
            ControlBox = False
            Controls.Add(Button3)
            Controls.Add(Me.Label17)
            Controls.Add(Me.TextBox4)
            Controls.Add(Me.Label11)
            Controls.Add(Me.Label10)
            Controls.Add(Me.选择单词大小)
            Controls.Add(Me.Label8)
            Controls.Add(Me.选择字典大小)
            Controls.Add(Me.Label9)
            Controls.Add(Me.Label7)
            Controls.Add(Me.TextBox3)
            Controls.Add(Me.Label6)
            Controls.Add(选择压缩方法)
            Controls.Add(Me.Label5)
            Controls.Add(Me.Label4)
            Controls.Add(Me.CPU线程数)
            Controls.Add(Me.Label3)
            Controls.Add(Me.CheckBox2)
            Controls.Add(Button2)
            Controls.Add(Me.TextBox1)
            Controls.Add(Me.Label2)
            Controls.Add(Me.CheckBox1)
            Controls.Add(Button1)
            Controls.Add(Me.TextBox2)
            Controls.Add(Me.Label1)
            Controls.Add(选择压缩级别)
            Controls.Add(选择压缩格式)
            Controls.Add(ButtonCancle)
            Controls.Add(ButtonSaveAndExit)
            Controls.Add(Me.label压缩级别)
            Controls.Add(Me.label压缩格式)
            Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134)
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Location = New Point(800, 300)
            Name = "SevenZipSettingsForm"
            ShowIcon = False
            ShowInTaskbar = False
            StartPosition = FormStartPosition.Manual
            Text = "7-Zip配置"
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Private Sub ButtonCancle_Click(sender As Object, e As EventArgs)
            Dim dialogResult = MessageBox.Show("是否放弃保存设置并退出?", "提示", MessageBoxButtons.YesNo)
            If dialogResult = DialogResult.Yes Then
                日志窗口.添加日志("关闭7-Zip设置窗口", 5)
                Close()
            End If
        End Sub

        Private Sub ButtonSaveAndExit_Click(sender As Object, e As EventArgs)
            Dim dialogResult = MessageBox.Show("是否保存设置并退出?", "提示", MessageBoxButtons.YesNo)
            If Me.CheckBox1.Checked Then
                配置文件操作模块.是否增量备份 = True
            Else
                配置文件操作模块.是否增量备份 = False
            End If
            If Me.CheckBox2.Checked Then
                配置文件操作模块.是否备份自定义目录 = True
            Else
                配置文件操作模块.是否备份自定义目录 = False
            End If
            Select Case 选择压缩格式.SelectedIndex
                Case 0
                    配置文件操作模块.压缩格式 = "7z"
                    Select Case 选择压缩方法.SelectedIndex
                        Case 0
                            配置文件操作模块.压缩方法 = "LZMA2"
                        Case 1
                            配置文件操作模块.压缩方法 = "LZMA"
                        Case 2
                            配置文件操作模块.压缩方法 = "PPMd"
                        Case 3
                            配置文件操作模块.压缩方法 = "BZip2"
                    End Select
                Case 1
                    配置文件操作模块.压缩格式 = "tar"
                    Select Case 选择压缩方法.SelectedIndex
                        Case 0
                            配置文件操作模块.压缩方法 = "GNU"
                        Case 1
                            配置文件操作模块.压缩方法 = "POSIX"
                    End Select
                Case 2
                    配置文件操作模块.压缩格式 = "wim"
                    配置文件操作模块.压缩方法 = ""
                Case 3
                    配置文件操作模块.压缩格式 = "zip"
                    Select Case 选择压缩方法.SelectedIndex
                        Case 0
                            配置文件操作模块.压缩方法 = "Deflate"
                        Case 1
                            配置文件操作模块.压缩方法 = "Deflate64"
                        Case 2
                            配置文件操作模块.压缩方法 = "BZip2"
                        Case 3
                            配置文件操作模块.压缩方法 = "LZMA"
                        Case 4
                            配置文件操作模块.压缩方法 = "PPMd"
                    End Select
            End Select
            配置文件操作模块.压缩级别 = 选择压缩级别.SelectedIndex
            If dialogResult = DialogResult.Yes Then
                配置文件操作模块.写入7zip配置(配置文件操作模块.压缩格式, 配置文件操作模块.压缩级别, 配置文件操作模块.压缩方法, Me.选择字典大小.Text, Me.选择单词大小.Text, Conversions.ToInteger(Me.TextBox3.Text), Me.TextBox1.Text, Me.TextBox2.Text, 配置文件操作模块.是否增量备份, Conversions.ToString(配置文件操作模块.是否备份自定义目录), Me.CPU线程数.Text, Me.TextBox4.Text)
                日志窗口.添加日志("成功保存7-Zip设置", 3)
                Call 日志窗口.日志输出7zip配置()
                日志窗口.添加日志("", 7)
                日志窗口.添加日志("关闭7-Zip设置窗口", 5)
                Close()
            End If
        End Sub

        Private Sub SevenZipSettingsForm_Load(sender As Object, e As EventArgs)
            日志窗口.更新停靠位置(Me)
            初始化配置项()
        End Sub

        Private Sub SevenZipSettingsForm_Activated(sender As Object, e As EventArgs)
            If Owner IsNot Nothing AndAlso TypeOf Owner Is MainForm Then
                日志窗口.更新停靠位置(Me)
            End If
        End Sub

        Private Sub SevenZipSettingsForm_Move(sender As Object, e As EventArgs)
            If Owner IsNot Nothing AndAlso TypeOf Owner Is MainForm Then
                日志窗口.更新停靠位置(Me)
            End If
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs)
            Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Me.TextBox2.Text = folderBrowserDialog.SelectedPath
            End If
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
            Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Me.TextBox1.Text = folderBrowserDialog.SelectedPath
            End If
        End Sub

        Private Sub 初始化配置项()
            配置文件操作模块.读取7zip配置()
            Select Case 配置文件操作模块.压缩格式
                Case "7z"
                    选择压缩格式.SelectedIndex = 0
                    Select Case 配置文件操作模块.压缩方法
                        Case "LZMA2"
                            选择压缩方法.SelectedIndex = 0
                            Select Case 配置文件操作模块.字典大小
                                Case "64KB"
                                    Me.选择字典大小.SelectedIndex = 0
                                Case "256KB"
                                    Me.选择字典大小.SelectedIndex = 1
                                Case "1MB"
                                    Me.选择字典大小.SelectedIndex = 2
                                Case "2MB"
                                    Me.选择字典大小.SelectedIndex = 3
                                Case "3MB"
                                    Me.选择字典大小.SelectedIndex = 4
                                Case "4MB"
                                    Me.选择字典大小.SelectedIndex = 5
                                Case "6MB"
                                    Me.选择字典大小.SelectedIndex = 6
                                Case "8MB"
                                    Me.选择字典大小.SelectedIndex = 7
                                Case "12MB"
                                    Me.选择字典大小.SelectedIndex = 8
                                Case "16MB"
                                    Me.选择字典大小.SelectedIndex = 9
                                Case "24MB"
                                    Me.选择字典大小.SelectedIndex = 10
                                Case "32MB"
                                    Me.选择字典大小.SelectedIndex = 11
                                Case "48MB"
                                    Me.选择字典大小.SelectedIndex = 12
                                Case "64MB"
                                    Me.选择字典大小.SelectedIndex = 13
                                Case "96MB"
                                    Me.选择字典大小.SelectedIndex = 14
                                Case "128MB"
                                    Me.选择字典大小.SelectedIndex = 15
                                Case "192MB"
                                    Me.选择字典大小.SelectedIndex = 16
                                Case "256MB"
                                    Me.选择字典大小.SelectedIndex = 17
                                Case "384MB"
                                    Me.选择字典大小.SelectedIndex = 18
                                Case "512MB"
                                    Me.选择字典大小.SelectedIndex = 19
                                Case "768MB"
                                    Me.选择字典大小.SelectedIndex = 20
                                Case "1024MB"
                                    Me.选择字典大小.SelectedIndex = 21
                                Case "1536MB"
                                    Me.选择字典大小.SelectedIndex = 22
                                Case "2048MB"
                                    Me.选择字典大小.SelectedIndex = 23
                                Case "3072MB"
                                    Me.选择字典大小.SelectedIndex = 24
                                Case "3840MB"
                                    Me.选择字典大小.SelectedIndex = 25
                            End Select
                            Select Case 配置文件操作模块.单词大小
                                Case "8"
                                    Me.选择单词大小.SelectedIndex = 0
                                Case "12"
                                    Me.选择单词大小.SelectedIndex = 1
                                Case "16"
                                    Me.选择单词大小.SelectedIndex = 2
                                Case "24"
                                    Me.选择单词大小.SelectedIndex = 3
                                Case "32"
                                    Me.选择单词大小.SelectedIndex = 4
                                Case "48"
                                    Me.选择单词大小.SelectedIndex = 5
                                Case "64"
                                    Me.选择单词大小.SelectedIndex = 6
                                Case "96"
                                    Me.选择单词大小.SelectedIndex = 7
                                Case "128"
                                    Me.选择单词大小.SelectedIndex = 8
                                Case "192"
                                    Me.选择单词大小.SelectedIndex = 9
                                Case "256"
                                    Me.选择单词大小.SelectedIndex = 10
                                Case "273"
                                    Me.选择单词大小.SelectedIndex = 11
                            End Select
                        Case "LZMA"
                            选择压缩方法.SelectedIndex = 1
                            Select Case 配置文件操作模块.字典大小
                                Case "64KB"
                                    Me.选择字典大小.SelectedIndex = 0
                                Case "256KB"
                                    Me.选择字典大小.SelectedIndex = 1
                                Case "1MB"
                                    Me.选择字典大小.SelectedIndex = 2
                                Case "2MB"
                                    Me.选择字典大小.SelectedIndex = 3
                                Case "3MB"
                                    Me.选择字典大小.SelectedIndex = 4
                                Case "4MB"
                                    Me.选择字典大小.SelectedIndex = 5
                                Case "6MB"
                                    Me.选择字典大小.SelectedIndex = 6
                                Case "8MB"
                                    Me.选择字典大小.SelectedIndex = 7
                                Case "12MB"
                                    Me.选择字典大小.SelectedIndex = 8
                                Case "16MB"
                                    Me.选择字典大小.SelectedIndex = 9
                                Case "24MB"
                                    Me.选择字典大小.SelectedIndex = 10
                                Case "32MB"
                                    Me.选择字典大小.SelectedIndex = 11
                                Case "48MB"
                                    Me.选择字典大小.SelectedIndex = 12
                                Case "64MB"
                                    Me.选择字典大小.SelectedIndex = 13
                                Case "96MB"
                                    Me.选择字典大小.SelectedIndex = 14
                                Case "128MB"
                                    Me.选择字典大小.SelectedIndex = 15
                                Case "192MB"
                                    Me.选择字典大小.SelectedIndex = 16
                                Case "256MB"
                                    Me.选择字典大小.SelectedIndex = 17
                                Case "384MB"
                                    Me.选择字典大小.SelectedIndex = 18
                                Case "512MB"
                                    Me.选择字典大小.SelectedIndex = 19
                                Case "768MB"
                                    Me.选择字典大小.SelectedIndex = 20
                                Case "1024MB"
                                    Me.选择字典大小.SelectedIndex = 21
                                Case "1536MB"
                                    Me.选择字典大小.SelectedIndex = 22
                                Case "2048MB"
                                    Me.选择字典大小.SelectedIndex = 23
                                Case "3072MB"
                                    Me.选择字典大小.SelectedIndex = 24
                                Case "3840MB"
                                    Me.选择字典大小.SelectedIndex = 25
                            End Select
                            Select Case 配置文件操作模块.单词大小
                                Case "8"
                                    Me.选择单词大小.SelectedIndex = 0
                                Case "12"
                                    Me.选择单词大小.SelectedIndex = 1
                                Case "16"
                                    Me.选择单词大小.SelectedIndex = 2
                                Case "24"
                                    Me.选择单词大小.SelectedIndex = 3
                                Case "32"
                                    Me.选择单词大小.SelectedIndex = 4
                                Case "48"
                                    Me.选择单词大小.SelectedIndex = 5
                                Case "64"
                                    Me.选择单词大小.SelectedIndex = 6
                                Case "96"
                                    Me.选择单词大小.SelectedIndex = 7
                                Case "128"
                                    Me.选择单词大小.SelectedIndex = 8
                                Case "192"
                                    Me.选择单词大小.SelectedIndex = 9
                                Case "256"
                                    Me.选择单词大小.SelectedIndex = 10
                                Case "273"
                                    Me.选择单词大小.SelectedIndex = 11
                            End Select
                        Case "PPMd"
                            选择压缩方法.SelectedIndex = 2
                            Select Case 配置文件操作模块.字典大小
                                Case "1MB"
                                    Me.选择字典大小.SelectedIndex = 0
                                Case "2MB"
                                    Me.选择字典大小.SelectedIndex = 1
                                Case "3MB"
                                    Me.选择字典大小.SelectedIndex = 2
                                Case "4MB"
                                    Me.选择字典大小.SelectedIndex = 3
                                Case "6MB"
                                    Me.选择字典大小.SelectedIndex = 4
                                Case "8MB"
                                    Me.选择字典大小.SelectedIndex = 5
                                Case "12MB"
                                    Me.选择字典大小.SelectedIndex = 6
                                Case "16MB"
                                    Me.选择字典大小.SelectedIndex = 7
                                Case "24MB"
                                    Me.选择字典大小.SelectedIndex = 8
                                Case "32MB"
                                    Me.选择字典大小.SelectedIndex = 9
                                Case "48MB"
                                    Me.选择字典大小.SelectedIndex = 10
                                Case "64MB"
                                    Me.选择字典大小.SelectedIndex = 11
                                Case "96MB"
                                    Me.选择字典大小.SelectedIndex = 12
                                Case "128MB"
                                    Me.选择字典大小.SelectedIndex = 13
                                Case "192MB"
                                    Me.选择字典大小.SelectedIndex = 14
                                Case "256MB"
                                    Me.选择字典大小.SelectedIndex = 15
                                Case "384MB"
                                    Me.选择字典大小.SelectedIndex = 16
                                Case "512MB"
                                    Me.选择字典大小.SelectedIndex = 17
                                Case "768MB"
                                    Me.选择字典大小.SelectedIndex = 18
                                Case "1024MB"
                                    Me.选择字典大小.SelectedIndex = 19
                            End Select
                            Select Case 配置文件操作模块.单词大小
                                Case "2"
                                    Me.选择单词大小.SelectedIndex = 0
                                Case "3"
                                    Me.选择单词大小.SelectedIndex = 1
                                Case "4"
                                    Me.选择单词大小.SelectedIndex = 2
                                Case "5"
                                    Me.选择单词大小.SelectedIndex = 3
                                Case "6"
                                    Me.选择单词大小.SelectedIndex = 4
                                Case "7"
                                    Me.选择单词大小.SelectedIndex = 5
                                Case "8"
                                    Me.选择单词大小.SelectedIndex = 6
                                Case "10"
                                    Me.选择单词大小.SelectedIndex = 7
                                Case "12"
                                    Me.选择单词大小.SelectedIndex = 8
                                Case "14"
                                    Me.选择单词大小.SelectedIndex = 9
                                Case "16"
                                    Me.选择单词大小.SelectedIndex = 10
                                Case "20"
                                    Me.选择单词大小.SelectedIndex = 11
                                Case "24"
                                    Me.选择单词大小.SelectedIndex = 12
                                Case "28"
                                    Me.选择单词大小.SelectedIndex = 13
                                Case "32"
                                    Me.选择单词大小.SelectedIndex = 14
                            End Select
                        Case "BZip2"
                            选择压缩方法.SelectedIndex = 3
                            Select Case 配置文件操作模块.字典大小
                                Case "100KB"
                                    Me.选择字典大小.SelectedIndex = 0
                                Case "200KB"
                                    Me.选择字典大小.SelectedIndex = 1
                                Case "300KB"
                                    Me.选择字典大小.SelectedIndex = 2
                                Case "400KB"
                                    Me.选择字典大小.SelectedIndex = 3
                                Case "500KB"
                                    Me.选择字典大小.SelectedIndex = 4
                                Case "600KB"
                                    Me.选择字典大小.SelectedIndex = 5
                                Case "700KB"
                                    Me.选择字典大小.SelectedIndex = 6
                                Case "800KB"
                                    Me.选择字典大小.SelectedIndex = 7
                                Case "900KB"
                                    Me.选择字典大小.SelectedIndex = 8
                            End Select
                            Me.选择单词大小.Enabled = False
                    End Select
                Case "tar"
                    选择压缩格式.SelectedIndex = 1
                    选择压缩级别.Enabled = False
                    Dim 压缩方法 = 配置文件操作模块.压缩方法
                    If Operators.CompareString(压缩方法, "GNU", TextCompare:=False) <> 0 Then
                        If Operators.CompareString(压缩方法, "POSIX", TextCompare:=False) = 0 Then
                            选择压缩方法.SelectedIndex = 1
                        End If
                    Else
                        选择压缩方法.SelectedIndex = 0
                    End If
                    Me.选择字典大小.Enabled = False
                    Me.选择单词大小.Enabled = False
                    Me.CPU线程数.Enabled = False
                    Exit Select
                Case "wim"
                    选择压缩格式.SelectedIndex = 2
                    选择压缩级别.Enabled = False
                    选择压缩方法.Enabled = False
                    选择压缩方法.SelectedIndex = -1
                    Me.CPU线程数.Enabled = False
                Case "zip"
                    选择压缩格式.SelectedIndex = 3
                    Select Case 配置文件操作模块.压缩方法
                        Case "Deflate"
                            选择压缩方法.SelectedIndex = 0
                            Me.选择字典大小.Enabled = False
                            Me.选择字典大小.Text = "32KB"
                            Select Case 配置文件操作模块.单词大小
                                Case "8"
                                    Me.选择单词大小.SelectedIndex = 0
                                Case "12"
                                    Me.选择单词大小.SelectedIndex = 1
                                Case "16"
                                    Me.选择单词大小.SelectedIndex = 2
                                Case "24"
                                    Me.选择单词大小.SelectedIndex = 3
                                Case "32"
                                    Me.选择单词大小.SelectedIndex = 4
                                Case "48"
                                    Me.选择单词大小.SelectedIndex = 5
                                Case "64"
                                    Me.选择单词大小.SelectedIndex = 6
                                Case "96"
                                    Me.选择单词大小.SelectedIndex = 7
                                Case "128"
                                    Me.选择单词大小.SelectedIndex = 8
                                Case "192"
                                    Me.选择单词大小.SelectedIndex = 9
                                Case "256"
                                    Me.选择单词大小.SelectedIndex = 10
                                Case "258"
                                    Me.选择单词大小.SelectedIndex = 11
                            End Select
                        Case "Deflate64"
                            选择压缩方法.SelectedIndex = 1
                            选择压缩方法.SelectedIndex = 0
                            Me.选择字典大小.Enabled = False
                            Me.选择字典大小.Text = "64KB"
                            Select Case 配置文件操作模块.单词大小
                                Case "8"
                                    Me.选择单词大小.SelectedIndex = 0
                                Case "12"
                                    Me.选择单词大小.SelectedIndex = 1
                                Case "16"
                                    Me.选择单词大小.SelectedIndex = 2
                                Case "24"
                                    Me.选择单词大小.SelectedIndex = 3
                                Case "32"
                                    Me.选择单词大小.SelectedIndex = 4
                                Case "48"
                                    Me.选择单词大小.SelectedIndex = 5
                                Case "64"
                                    Me.选择单词大小.SelectedIndex = 6
                                Case "96"
                                    Me.选择单词大小.SelectedIndex = 7
                                Case "128"
                                    Me.选择单词大小.SelectedIndex = 8
                                Case "192"
                                    Me.选择单词大小.SelectedIndex = 9
                                Case "256"
                                    Me.选择单词大小.SelectedIndex = 10
                                Case "257"
                                    Me.选择单词大小.SelectedIndex = 11
                            End Select
                        Case "BZip2"
                            选择压缩方法.SelectedIndex = 2
                            选择压缩方法.SelectedIndex = 3
                            Me.选择单词大小.Enabled = False
                            Select Case 配置文件操作模块.字典大小
                                Case "100KB"
                                    Me.选择字典大小.SelectedIndex = 0
                                Case "200KB"
                                    Me.选择字典大小.SelectedIndex = 1
                                Case "300KB"
                                    Me.选择字典大小.SelectedIndex = 2
                                Case "400KB"
                                    Me.选择字典大小.SelectedIndex = 3
                                Case "500KB"
                                    Me.选择字典大小.SelectedIndex = 4
                                Case "600KB"
                                    Me.选择字典大小.SelectedIndex = 5
                                Case "700KB"
                                    Me.选择字典大小.SelectedIndex = 6
                                Case "800KB"
                                    Me.选择字典大小.SelectedIndex = 7
                                Case "900KB"
                                    Me.选择字典大小.SelectedIndex = 8
                            End Select
                        Case "LZMA"
                            选择压缩方法.SelectedIndex = 3
                            Select Case 配置文件操作模块.字典大小
                                Case "64KB"
                                    Me.选择字典大小.SelectedIndex = 0
                                Case "256KB"
                                    Me.选择字典大小.SelectedIndex = 1
                                Case "1MB"
                                    Me.选择字典大小.SelectedIndex = 2
                                Case "2MB"
                                    Me.选择字典大小.SelectedIndex = 3
                                Case "3MB"
                                    Me.选择字典大小.SelectedIndex = 4
                                Case "4MB"
                                    Me.选择字典大小.SelectedIndex = 5
                                Case "6MB"
                                    Me.选择字典大小.SelectedIndex = 6
                                Case "8MB"
                                    Me.选择字典大小.SelectedIndex = 7
                                Case "12MB"
                                    Me.选择字典大小.SelectedIndex = 8
                                Case "16MB"
                                    Me.选择字典大小.SelectedIndex = 9
                                Case "24MB"
                                    Me.选择字典大小.SelectedIndex = 10
                                Case "32MB"
                                    Me.选择字典大小.SelectedIndex = 11
                                Case "48MB"
                                    Me.选择字典大小.SelectedIndex = 12
                                Case "64MB"
                                    Me.选择字典大小.SelectedIndex = 13
                                Case "96MB"
                                    Me.选择字典大小.SelectedIndex = 14
                                Case "128MB"
                                    Me.选择字典大小.SelectedIndex = 15
                                Case "192MB"
                                    Me.选择字典大小.SelectedIndex = 16
                                Case "256MB"
                                    Me.选择字典大小.SelectedIndex = 17
                                Case "384MB"
                                    Me.选择字典大小.SelectedIndex = 18
                                Case "512MB"
                                    Me.选择字典大小.SelectedIndex = 19
                                Case "768MB"
                                    Me.选择字典大小.SelectedIndex = 20
                                Case "1024MB"
                                    Me.选择字典大小.SelectedIndex = 21
                                Case "1536MB"
                                    Me.选择字典大小.SelectedIndex = 22
                                Case "2048MB"
                                    Me.选择字典大小.SelectedIndex = 23
                                Case "3072MB"
                                    Me.选择字典大小.SelectedIndex = 24
                                Case "3840MB"
                                    Me.选择字典大小.SelectedIndex = 25
                            End Select
                            Select Case 配置文件操作模块.单词大小
                                Case "8"
                                    Me.选择单词大小.SelectedIndex = 0
                                Case "12"
                                    Me.选择单词大小.SelectedIndex = 1
                                Case "16"
                                    Me.选择单词大小.SelectedIndex = 2
                                Case "24"
                                    Me.选择单词大小.SelectedIndex = 3
                                Case "32"
                                    Me.选择单词大小.SelectedIndex = 4
                                Case "48"
                                    Me.选择单词大小.SelectedIndex = 5
                                Case "64"
                                    Me.选择单词大小.SelectedIndex = 6
                                Case "96"
                                    Me.选择单词大小.SelectedIndex = 7
                                Case "128"
                                    Me.选择单词大小.SelectedIndex = 8
                                Case "192"
                                    Me.选择单词大小.SelectedIndex = 9
                                Case "256"
                                    Me.选择单词大小.SelectedIndex = 10
                                Case "273"
                                    Me.选择单词大小.SelectedIndex = 11
                            End Select
                        Case "PPMd"
                            选择压缩方法.SelectedIndex = 4
                            Select Case 配置文件操作模块.字典大小
                                Case "1MB"
                                    Me.选择字典大小.SelectedIndex = 0
                                Case "2MB"
                                    Me.选择字典大小.SelectedIndex = 1
                                Case "3MB"
                                    Me.选择字典大小.SelectedIndex = 2
                                Case "4MB"
                                    Me.选择字典大小.SelectedIndex = 3
                                Case "6MB"
                                    Me.选择字典大小.SelectedIndex = 4
                                Case "8MB"
                                    Me.选择字典大小.SelectedIndex = 5
                                Case "12MB"
                                    Me.选择字典大小.SelectedIndex = 6
                                Case "16MB"
                                    Me.选择字典大小.SelectedIndex = 7
                                Case "24MB"
                                    Me.选择字典大小.SelectedIndex = 8
                                Case "32MB"
                                    Me.选择字典大小.SelectedIndex = 9
                                Case "48MB"
                                    Me.选择字典大小.SelectedIndex = 10
                                Case "64MB"
                                    Me.选择字典大小.SelectedIndex = 11
                                Case "96MB"
                                    Me.选择字典大小.SelectedIndex = 12
                                Case "128MB"
                                    Me.选择字典大小.SelectedIndex = 13
                                Case "192MB"
                                    Me.选择字典大小.SelectedIndex = 14
                                Case "256MB"
                                    Me.选择字典大小.SelectedIndex = 15
                                Case "384MB"
                                    Me.选择字典大小.SelectedIndex = 16
                                Case "512MB"
                                    Me.选择字典大小.SelectedIndex = 17
                                Case "768MB"
                                    Me.选择字典大小.SelectedIndex = 18
                                Case "1024MB"
                                    Me.选择字典大小.SelectedIndex = 19
                            End Select
                            Select Case 配置文件操作模块.单词大小
                                Case "2"
                                    Me.选择单词大小.SelectedIndex = 0
                                Case "3"
                                    Me.选择单词大小.SelectedIndex = 1
                                Case "4"
                                    Me.选择单词大小.SelectedIndex = 2
                                Case "5"
                                    Me.选择单词大小.SelectedIndex = 3
                                Case "6"
                                    Me.选择单词大小.SelectedIndex = 4
                                Case "7"
                                    Me.选择单词大小.SelectedIndex = 5
                                Case "8"
                                    Me.选择单词大小.SelectedIndex = 6
                                Case "10"
                                    Me.选择单词大小.SelectedIndex = 7
                                Case "12"
                                    Me.选择单词大小.SelectedIndex = 8
                                Case "14"
                                    Me.选择单词大小.SelectedIndex = 9
                                Case "16"
                                    Me.选择单词大小.SelectedIndex = 10
                                Case "20"
                                    Me.选择单词大小.SelectedIndex = 11
                                Case "24"
                                    Me.选择单词大小.SelectedIndex = 12
                                Case "28"
                                    Me.选择单词大小.SelectedIndex = 13
                                Case "32"
                                    Me.选择单词大小.SelectedIndex = 14
                            End Select
                    End Select
            End Select
            选择压缩级别.SelectedIndex = 配置文件操作模块.压缩级别
            Me.CPU线程数.Text = 配置文件操作模块.线程数
            Me.TextBox1.Text = 配置文件操作模块.自定义备份目录
            Me.TextBox2.Text = 配置文件操作模块.备份输出目录
            Me.TextBox3.Text = 配置文件操作模块.超时时长.ToString()
            Me.TextBox4.Text = 配置文件操作模块.自定义备份目录排除文件参数
            Me.CheckBox1.Checked = 配置文件操作模块.是否增量备份
            Me.CheckBox2.Checked = 配置文件操作模块.是否备份自定义目录
        End Sub

        Private Sub 选择压缩格式_索引变化(sender As Object, e As EventArgs)
            Dim items = New Object(3) {"LZMA2-压缩率最高,兼容性较差", "LZMA-压缩率稍低,兼容性较差", "PPMd-高效压缩纯文本", "BZip2-兼容性较好(Linux)"}
            Dim obj As Object = New Object(1) {"GNU", "POSIX"}
            Dim obj2 As Object = New Object(4) {"Deflate-压缩率中等", "Deflate64-压缩率较高", "BZip2-兼容性较好(Linux)", "LZMA-压缩率最高,兼容性较差", "PPMd-高效压缩纯文本"}
            选择压缩方法.Items.Clear()
            Select Case 选择压缩格式.SelectedIndex
                Case 0
                    选择压缩级别.Enabled = True
                    Me.CPU线程数.Enabled = True
                    选择压缩方法.Items.AddRange(items)
                    If Operators.CompareString(选择压缩方法.Text, "LZMA2-压缩率最高,兼容性较差", TextCompare:=False) <> 0 Or Operators.CompareString(选择压缩方法.Text, "LZMA-压缩率稍低,兼容性较差", TextCompare:=False) <> 0 Or Operators.CompareString(选择压缩方法.Text, "PPMd-高效压缩纯文本", TextCompare:=False) <> 0 Or Operators.CompareString(选择压缩方法.Text, "BZip2-兼容性较好(Linux)", TextCompare:=False) <> 0 Then
                        选择压缩方法.SelectedIndex = 0
                    End If
                    If 选择压缩级别.SelectedIndex = 0 Then
                        选择压缩方法.Enabled = False
                        选择压缩方法.SelectedIndex = -1
                        选择压缩方法.Text = ""
                        Me.选择字典大小.Enabled = False
                        Me.选择字典大小.SelectedIndex = -1
                        Me.选择字典大小.Text = ""
                        Me.选择单词大小.Enabled = False
                        Me.选择单词大小.SelectedIndex = -1
                        Me.选择单词大小.Text = ""
                    Else
                        选择压缩方法.Enabled = True
                        Me.选择字典大小.Enabled = True
                        Me.选择单词大小.Enabled = True
                    End If
                Case 1
                    选择压缩方法.Items.AddRange(CType(obj, Object()))
                    If Operators.CompareString(选择压缩方法.Text, "GNU", TextCompare:=False) <> 0 Or Operators.CompareString(选择压缩方法.Text, "POSIX", TextCompare:=False) <> 0 Then
                        选择压缩方法.SelectedIndex = 0
                    End If
                    选择压缩方法.Enabled = True
                    选择压缩级别.Enabled = False
                    选择压缩级别.SelectedIndex = 0
                    Me.CPU线程数.Enabled = False
                    Me.CPU线程数.Text = Conversions.ToString(1)
                Case 2
                    选择压缩方法.Enabled = False
                    选择压缩方法.SelectedIndex = -1
                    选择压缩方法.Text = ""
                    选择压缩级别.Enabled = False
                    选择压缩级别.SelectedIndex = 0
                    Me.CPU线程数.Enabled = False
                    Me.CPU线程数.Text = "1"
                Case 3
                    选择压缩方法.Items.AddRange(CType(obj2, Object()))
                    选择压缩级别.Enabled = True
                    选择压缩方法.Enabled = True
                    Me.CPU线程数.Enabled = True
                    If Operators.CompareString(选择压缩方法.Text, "Deflate-压缩率中等", TextCompare:=False) <> 0 Or Operators.CompareString(选择压缩方法.Text, "Deflate64-压缩率较高", TextCompare:=False) <> 0 Or Operators.CompareString(选择压缩方法.Text, "BZip2-兼容性较好(Linux)", TextCompare:=False) <> 0 Or Operators.CompareString(选择压缩方法.Text, "LZMA-压缩率最高,兼容性较差", TextCompare:=False) <> 0 Or Operators.CompareString(选择压缩方法.Text, "PPMd-高效压缩纯文本", TextCompare:=False) <> 0 Then
                        选择压缩方法.SelectedIndex = 0
                    End If
                    If 选择压缩级别.SelectedIndex = 0 Then
                        选择压缩方法.Enabled = False
                        选择压缩方法.SelectedIndex = -1
                        选择压缩方法.Text = ""
                        Me.选择字典大小.Enabled = False
                        Me.选择字典大小.SelectedIndex = -1
                        Me.选择字典大小.Text = ""
                        Me.选择单词大小.Enabled = False
                        Me.选择单词大小.SelectedIndex = -1
                        Me.选择单词大小.Text = ""
                    Else
                        选择压缩方法.Enabled = True
                        Me.选择字典大小.Enabled = True
                        Me.选择单词大小.Enabled = True
                    End If
            End Select
        End Sub

        Private Sub 选择压缩级别_SelectedIndexChanged(sender As Object, e As EventArgs)
            If 选择压缩级别.SelectedIndex = 0 Then
                选择压缩方法.Enabled = False
                选择压缩方法.SelectedIndex = -1
                Me.选择字典大小.Enabled = False
                Me.选择字典大小.SelectedIndex = -1
                Me.选择字典大小.Text = ""
                Me.选择单词大小.Enabled = False
                Me.选择单词大小.SelectedIndex = -1
                Me.选择单词大小.Text = ""
                Me.CPU线程数.Enabled = False
                Me.CPU线程数.Text = "1"
            Else
                选择压缩方法.Enabled = True
                Me.CPU线程数.Enabled = True
                If 选择压缩方法.SelectedIndex = -1 AndAlso 选择压缩格式.SelectedIndex <> 2 Then
                    选择压缩方法.SelectedIndex = 0
                End If
            End If
        End Sub

        Private Sub 选择压缩方法_SelectedIndexChanged(sender As Object, e As EventArgs)
            Me.选择字典大小.Items.Clear()
            Me.选择单词大小.Items.Clear()
            Dim items = New Object(25) {"64KB", "256KB", "1MB", "2MB", "3MB", "4MB", "6MB", "8MB", "12MB", "16MB", "24MB", "32MB", "48MB", "64MB", "96MB", "128MB", "192MB", "256MB", "384MB", "512MB", "768MB", "1024MB", "1536MB", "2048MB", "3072MB", "3840MB"}
            Dim items2 = New Object(11) {"8", "12", "16", "24", "32", "48", "64", "96", "128", "192", "256", "273"}
            Dim items3 = New Object(25) {"64KB", "256KB", "1MB", "2MB", "3MB", "4MB", "6MB", "8MB", "12MB", "16MB", "24MB", "32MB", "48MB", "64MB", "96MB", "128MB", "192MB", "256MB", "384MB", "512MB", "768MB", "1024MB", "1536MB", "2048MB", "3072MB", "3840MB"}
            Dim items4 = New Object(11) {"8", "12", "16", "24", "32", "48", "64", "96", "128", "192", "256", "273"}
            Dim items5 = New Object(19) {"1MB", "2MB", "3MB", "4MB", "6MB", "8MB", "12MB", "16MB", "24MB", "32MB", "48MB", "64MB", "96MB", "128MB", "192MB", "256MB", "384MB", "512MB", "768MB", "1024MB"}
            Dim items6 = New Object(13) {"2", "3", "4", "5", "6", "7", "8", "10", "12", "16", "20", "24", "28", "32"}
            Dim items7 = New Object(8) {"100KB", "200KB", "300KB", "400KB", "500KB", "600KB", "700KB", "800KB", "900KB"}
            Dim items8 = New Object(11) {"8", "12", "16", "24", "32", "48", "64", "96", "128", "192", "256", "258"}
            Dim items9 = New Object(11) {"8", "12", "16", "24", "32", "48", "64", "96", "128", "192", "256", "257"}
            Select Case 选择压缩方法.Text
                Case "LZMA2-压缩率最高,兼容性较差"
                    Me.选择字典大小.Items.AddRange(items)
                    Me.选择单词大小.Items.AddRange(items2)
                    Me.选择字典大小.Enabled = True
                    Me.选择单词大小.Enabled = True
                    If Operators.CompareString(Me.选择字典大小.Text, "64KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "256KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "1MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "2MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "3MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "4MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "6MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "8MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "12MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "16MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "24MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "32MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "48MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "64MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "96MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "128MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "192MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "256MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "384MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "512MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "768MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "1024MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "1536MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "2048MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "3072MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "3840MB", TextCompare:=False) <> 0 Then
                        Me.选择字典大小.SelectedIndex = 0
                    End If
                    If Operators.CompareString(Me.选择单词大小.Text, "8", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "12", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "16", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "24", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "32", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "48", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "64", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "96", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "128", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "192", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "256", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "273", TextCompare:=False) <> 0 Then
                        Me.选择单词大小.SelectedIndex = 0
                    End If
                Case "LZMA-压缩率稍低,兼容性较差"
                    Me.选择字典大小.Items.AddRange(items3)
                    Me.选择单词大小.Items.AddRange(items4)
                    Me.选择字典大小.Enabled = True
                    Me.选择单词大小.Enabled = True
                    If Operators.CompareString(Me.选择字典大小.Text, "64KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "256KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "1MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "2MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "3MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "4MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "6MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "8MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "12MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "16MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "24MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "32MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "48MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "64MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "96MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "128MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "192MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "256MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "384MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "512MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "768MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "1024MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "1536MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "2048MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "3072MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "3840MB", TextCompare:=False) <> 0 Then
                        Me.选择字典大小.SelectedIndex = 0
                    End If
                    If Operators.CompareString(Me.选择单词大小.Text, "8", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "12", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "16", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "24", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "32", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "48", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "64", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "96", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "128", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "192", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "256", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "273", TextCompare:=False) <> 0 Then
                        Me.选择单词大小.SelectedIndex = 0
                    End If
                Case "LZMA-压缩率最高,兼容性较差"
                    Me.选择字典大小.Items.AddRange(items3)
                    Me.选择单词大小.Items.AddRange(items4)
                    Me.选择字典大小.Enabled = True
                    Me.选择单词大小.Enabled = True
                    If Operators.CompareString(Me.选择字典大小.Text, "64KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "256KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "1MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "2MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "3MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "4MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "6MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "8MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "12MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "16MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "24MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "32MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "48MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "64MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "96MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "128MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "192MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "256MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "384MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "512MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "768MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "1024MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "1536MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "2048MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "3072MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "3840MB", TextCompare:=False) <> 0 Then
                        Me.选择字典大小.SelectedIndex = 0
                    End If
                    If Operators.CompareString(Me.选择单词大小.Text, "8", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "12", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "16", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "24", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "32", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "48", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "64", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "96", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "128", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "192", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "256", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "273", TextCompare:=False) <> 0 Then
                        Me.选择单词大小.SelectedIndex = 0
                    End If
                Case "PPMd-高效压缩纯文本"
                    Me.选择字典大小.Items.AddRange(items5)
                    Me.选择单词大小.Items.AddRange(items6)
                    Me.选择字典大小.Enabled = True
                    Me.选择单词大小.Enabled = True
                    If Operators.CompareString(Me.选择字典大小.Text, "1MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "2MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "3MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "4MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "6MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "8MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "12MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "16MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "24MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "32MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "48MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "64MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "96MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "128MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "192MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "256MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "384MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "512MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "768MB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "1024MB", TextCompare:=False) <> 0 Then
                        Me.选择字典大小.SelectedIndex = 0
                    End If
                    If Operators.CompareString(Me.选择单词大小.Text, "2", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "3", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "4", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "5", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "6", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "7", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "8", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "10", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "12", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "14", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "16", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "20", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "24", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "28", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "32", TextCompare:=False) <> 0 Then
                        Me.选择单词大小.SelectedIndex = 0
                    End If
                Case "BZip2-兼容性较好(Linux)"
                    Me.选择字典大小.Items.AddRange(items7)
                    Me.选择字典大小.Enabled = True
                    Me.选择单词大小.Enabled = False
                    If Operators.CompareString(Me.选择字典大小.Text, "100KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "200KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "300KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "400KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "500KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "600KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "700KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "800KB", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择字典大小.Text, "900KB", TextCompare:=False) <> 0 Then
                        Me.选择字典大小.SelectedIndex = 0
                    End If
                    Me.选择单词大小.SelectedIndex = -1
                    Me.选择单词大小.Text = ""
                Case "Deflate-压缩率中等"
                    Me.选择单词大小.Items.AddRange(items8)
                    Me.选择单词大小.Enabled = True
                    Me.选择字典大小.Enabled = False
                    Me.选择字典大小.Items.Add("32KB")
                    Me.选择字典大小.SelectedIndex = 0
                    If Operators.CompareString(Me.选择单词大小.Text, "8", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "12", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "16", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "24", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "32", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "48", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "64", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "96", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "128", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "192", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "256", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "258", TextCompare:=False) <> 0 Then
                        Me.选择单词大小.SelectedIndex = 0
                    End If
                Case "Deflate64-压缩率较高"
                    Me.选择单词大小.Items.AddRange(items9)
                    Me.选择单词大小.Enabled = True
                    Me.选择字典大小.Enabled = False
                    Me.选择字典大小.Items.Add("64KB")
                    Me.选择字典大小.SelectedIndex = 0
                    If Operators.CompareString(Me.选择单词大小.Text, "8", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "12", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "16", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "24", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "32", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "48", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "64", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "96", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "128", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "192", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "256", TextCompare:=False) <> 0 Or Operators.CompareString(Me.选择单词大小.Text, "257", TextCompare:=False) <> 0 Then
                        Me.选择单词大小.SelectedIndex = 0
                    End If
            End Select
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs)
            Call CompactingArgumentsExamplesForm.Show()
        End Sub
    End Class
End Namespace
