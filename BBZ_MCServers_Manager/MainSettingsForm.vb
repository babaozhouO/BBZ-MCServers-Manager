Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <DesignerGenerated>
    Partial Public Class MainSettingsForm
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
        Private _CheckBox是否关服备份 As CheckBox
        Friend Property CheckBox是否关服备份 As CheckBox
            Get
                Return _CheckBox是否关服备份
            End Get
            Set(value As CheckBox)
                _CheckBox是否关服备份 = value
            End Set
        End Property
        Private _Days As TextBox
        Friend Property Days As TextBox
            Get
                Return _Days
            End Get
            Set(value As TextBox)
                _Days = value
            End Set
        End Property
        Private _FPS As TextBox
        Friend Property FPS As TextBox
            Get
                Return _FPS
            End Get
            Set(value As TextBox)
                _FPS = value
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
        Private _LabelRuntime As Label
        Friend Property LabelRuntime As Label
            Get
                Return _LabelRuntime
            End Get
            Set(value As Label)
                _LabelRuntime = value
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
        Private _TextBoxhour As TextBox
        Friend Property TextBoxhour As TextBox
            Get
                Return _TextBoxhour
            End Get
            Set(value As TextBox)
                _TextBoxhour = value
            End Set
        End Property
        Private _TextBoxminute As TextBox
        Friend Property TextBoxminute As TextBox
            Get
                Return _TextBoxminute
            End Get
            Set(value As TextBox)
                _TextBoxminute = value
            End Set
        End Property
        Private _TextBoxsecond As TextBox
        Friend Property TextBoxsecond As TextBox
            Get
                Return _TextBoxsecond
            End Get
            Set(value As TextBox)
                _TextBoxsecond = value
            End Set
        End Property
        Private _WaitingSeconds As TextBox
        Friend Property WaitingSeconds As TextBox
            Get
                Return _WaitingSeconds
            End Get
            Set(value As TextBox)
                _WaitingSeconds = value
            End Set
        End Property

        Private components As IContainer

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ButtonSaveAndExit")>
        Private _ButtonSaveAndExit As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ButtonCancle")>
        Private _ButtonCancle As Button

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

                ''' Cannot convert PropertyDeclarationSyntax, System.InvalidCastException: Unable to cast object of type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.EmptyStatementSyntax' to type 'Microsoft.CodeAnalysis.VisualBasic.Syntax.AttributeListSyntax'.
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertAndSplitAttributes(SyntaxList`1 attributeLists, SyntaxList`1& attributes, SyntaxList`1& returnAttributes) in /_/CodeConverter/VB/NodesVisitor.cs:line 718
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.ConvertPropertyBlock(BasePropertyDeclarationSyntax node, SyntaxToken id, SyntaxTokenList modifiers, ParameterListSyntax parameterListSyntax, ArrowExpressionClauseSyntax arrowExpressionClauseSyntax, EqualsValueSyntax initializerOrNull) in /_/CodeConverter/VB/NodesVisitor.cs:line 534
'''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitPropertyDeclaration(PropertyDeclarationSyntax node) in /_/CodeConverter/VB/NodesVisitor.cs:line 514
'''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
'''    at ICSharpCode.CodeConverter.VB.CommentConvertingVisitorWrapper`1.Accept(SyntaxNode csNode, Boolean addSourceMapping) in /_/CodeConverter/VB/CommentConvertingVisitorWrapper.cs:line 20
''' 
''' Input:
''' 
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("LabelRuntime")]
''' 	internal virtual System.Windows.Forms.Label LabelRuntime
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TextBoxhour")]
''' 	internal virtual System.Windows.Forms.TextBox TextBoxhour
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TextBoxminute")]
''' 	internal virtual System.Windows.Forms.TextBox TextBoxminute
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("TextBoxsecond")]
''' 	internal virtual System.Windows.Forms.TextBox TextBoxsecond
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Days")]
''' 	internal virtual System.Windows.Forms.TextBox Days
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("CheckBox是否关服备份")]
''' 	internal virtual System.Windows.Forms.CheckBox CheckBox是否关服备份
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("WaitingSeconds")]
''' 	internal virtual System.Windows.Forms.TextBox WaitingSeconds
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("FPS")]
''' 	internal virtual System.Windows.Forms.TextBox FPS
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("CheckBox1")]
''' 	internal virtual System.Windows.Forms.CheckBox CheckBox1
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label6")]
''' 	internal virtual System.Windows.Forms.Label Label6
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Public Sub New()
            AddHandler Load, AddressOf MainSettingsForm_Load
            AddHandler Activated, AddressOf MainSettingsForm_Activated
            AddHandler Move, AddressOf MainSettingsForm_Move
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
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(MainSettingsForm))
            ButtonSaveAndExit = New Button()
            ButtonCancle = New Button()
            Me.LabelRuntime = New Label()
            Me.TextBoxhour = New TextBox()
            Me.TextBoxminute = New TextBox()
            Me.TextBoxsecond = New TextBox()
            Me.Label1 = New Label()
            Me.Days = New TextBox()
            Me.CheckBox是否关服备份 = New CheckBox()
            Me.WaitingSeconds = New TextBox()
            Me.Label5 = New Label()
            Me.FPS = New TextBox()
            Me.Label2 = New Label()
            Me.CheckBox1 = New CheckBox()
            Me.TextBox1 = New TextBox()
            Me.Label3 = New Label()
            Me.CheckBox2 = New CheckBox()
            Me.Label4 = New Label()
            Me.TextBox2 = New TextBox()
            Me.Label6 = New Label()
            SuspendLayout()
            ButtonSaveAndExit.Location = New Point(800, 440)
            ButtonSaveAndExit.Name = "ButtonSaveAndExit"
            ButtonSaveAndExit.Size = New Size(93, 50)
            ButtonSaveAndExit.TabIndex = 0
            ButtonSaveAndExit.Text = "保存并关闭"
            ButtonSaveAndExit.UseVisualStyleBackColor = True
            ButtonCancle.Location = New Point(680, 440)
            ButtonCancle.Name = "ButtonCancle"
            ButtonCancle.Size = New Size(93, 50)
            ButtonCancle.TabIndex = 1
            ButtonCancle.Text = "取消"
            ButtonCancle.UseVisualStyleBackColor = True
            Me.LabelRuntime.AutoSize = True
            Me.LabelRuntime.Location = New Point(43, 92)
            Me.LabelRuntime.Name = "LabelRuntime"
            Me.LabelRuntime.Size = New Size(386, 19)
            Me.LabelRuntime.TabIndex = 2
            Me.LabelRuntime.Text = "[每次运行的间隔时长(上方选择框不选中)]：       时       分       秒"
            Me.TextBoxhour.Location = New Point(301, 90)
            Me.TextBoxhour.Name = "TextBoxhour"
            Me.TextBoxhour.Size = New Size(21, 24)
            Me.TextBoxhour.TabIndex = 3
            Me.TextBoxhour.Text = "04"
            Me.TextBoxminute.Location = New Point(346, 90)
            Me.TextBoxminute.Name = "TextBoxminute"
            Me.TextBoxminute.Size = New Size(21, 24)
            Me.TextBoxminute.TabIndex = 5
            Me.TextBoxminute.Text = "00"
            Me.TextBoxsecond.Location = New Point(387, 90)
            Me.TextBoxsecond.Name = "TextBoxsecond"
            Me.TextBoxsecond.Size = New Size(21, 24)
            Me.TextBoxsecond.TabIndex = 7
            Me.TextBoxsecond.Text = "00"
            Me.Label1.AutoSize = True
            Me.Label1.Location = New Point(43, 35)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(127, 19)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "每          天运行一次"
            Me.Days.Location = New Point(63, 32)
            Me.Days.Name = "Days"
            Me.Days.Size = New Size(33, 24)
            Me.Days.TabIndex = 11
            Me.CheckBox是否关服备份.AutoSize = True
            Me.CheckBox是否关服备份.Location = New Point(215, 147)
            Me.CheckBox是否关服备份.Name = "CheckBox是否关服备份"
            Me.CheckBox是否关服备份.Size = New Size(80, 23)
            Me.CheckBox是否关服备份.TabIndex = 12
            Me.CheckBox是否关服备份.Text = "关服备份"
            Me.CheckBox是否关服备份.UseVisualStyleBackColor = True
            Me.WaitingSeconds.Location = New Point(157, 145)
            Me.WaitingSeconds.Name = "WaitingSeconds"
            Me.WaitingSeconds.Size = New Size(32, 24)
            Me.WaitingSeconds.TabIndex = 17
            Me.WaitingSeconds.Text = "15"
            Me.Label5.AutoSize = True
            Me.Label5.Location = New Point(43, 148)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(166, 19)
            Me.Label5.TabIndex = 16
            Me.Label5.Text = "等待关服完成时长:         秒"
            Me.FPS.Location = New Point(224, 173)
            Me.FPS.Name = "FPS"
            Me.FPS.Size = New Size(33, 24)
            Me.FPS.TabIndex = 19
            Me.Label2.AutoSize = True
            Me.Label2.Location = New Point(43, 176)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(291, 19)
            Me.Label2.TabIndex = 18
            Me.Label2.Text = "执行长耗时任务时的界面帧数：      （0~1000）"
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Location = New Point(176, 34)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New Size(181, 23)
            Me.CheckBox1.TabIndex = 20
            Me.CheckBox1.Text = "每{设置的天数}日运行一次"
            Me.CheckBox1.UseVisualStyleBackColor = True
            Me.TextBox1.Location = New Point(172, 203)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New Size(33, 24)
            Me.TextBox1.TabIndex = 22
            Me.Label3.AutoSize = True
            Me.Label3.Location = New Point(43, 206)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(239, 19)
            Me.Label3.TabIndex = 21
            Me.Label3.Text = "日志框位置更新频率：      （0~1000）"
            Me.CheckBox2.AutoSize = True
            Me.CheckBox2.Location = New Point(43, 119)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New Size(609, 23)
            Me.CheckBox2.TabIndex = 23
            Me.CheckBox2.Text = "增量备份模式，选中为仅备份文件变化部分(新功能,谨慎使用,不要用,用不了)，不选中为备份整个文件"
            Me.CheckBox2.UseVisualStyleBackColor = True
            Me.Label4.AutoSize = True
            Me.Label4.Location = New Point(43, 63)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(288, 19)
            Me.Label4.TabIndex = 24
            Me.Label4.Text = "[要运行当天的运行时间点(上方选择框选中)]   或"
            Me.TextBox2.Location = New Point(238, 233)
            Me.TextBox2.Name = "TextBox2"
            Me.TextBox2.Size = New Size(33, 24)
            Me.TextBox2.TabIndex = 26
            Me.Label6.AutoSize = True
            Me.Label6.Location = New Point(43, 236)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Size(591, 38)
            Me.Label6.TabIndex = 25
            Me.Label6.Text = "Sftp客户端上传读取缓冲区大小：      （1~2047）MB" & vbCrLf & "（较大的值可以减少硬盘读写频率，提升发送速度，所需内存=缓冲区大小，上传完会自动回收内存）"
            AcceptButton = ButtonSaveAndExit
            AutoScaleDimensions = New SizeF(8F, 19F)
            AutoScaleMode = AutoScaleMode.Font
            CancelButton = ButtonCancle
            ClientSize = New Size(934, 521)
            ControlBox = False
            Controls.Add(Me.TextBox2)
            Controls.Add(Me.Label6)
            Controls.Add(Me.Label4)
            Controls.Add(Me.CheckBox2)
            Controls.Add(Me.TextBox1)
            Controls.Add(Me.Label3)
            Controls.Add(Me.CheckBox1)
            Controls.Add(Me.FPS)
            Controls.Add(Me.Label2)
            Controls.Add(Me.WaitingSeconds)
            Controls.Add(Me.Label5)
            Controls.Add(Me.CheckBox是否关服备份)
            Controls.Add(Me.Days)
            Controls.Add(Me.Label1)
            Controls.Add(Me.TextBoxsecond)
            Controls.Add(Me.TextBoxminute)
            Controls.Add(Me.TextBoxhour)
            Controls.Add(Me.LabelRuntime)
            Controls.Add(ButtonCancle)
            Controls.Add(ButtonSaveAndExit)
            Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134)
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Location = New Point(800, 300)
            MaximizeBox = False
            MinimizeBox = False
            Name = "MainSettingsForm"
            ShowIcon = False
            ShowInTaskbar = False
            StartPosition = FormStartPosition.Manual
            Text = "主程序配置"
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Private Sub ButtonCancle_Click(sender As Object, e As EventArgs)
            Dim dialogResult = MessageBox.Show("是否放弃保存设置并退出?", "提示", MessageBoxButtons.YesNo)
            If dialogResult = DialogResult.Yes Then
                日志窗口.添加日志("关闭主程序设置窗口", 5)
                Close()
            End If
        End Sub

        Private Sub ButtonSaveAndExit_Click(sender As Object, e As EventArgs)
            Dim dialogResult = MessageBox.Show("是否保存设置并退出?", "提示", MessageBoxButtons.YesNo)
            If dialogResult = DialogResult.Yes Then
                Dim 运行时间 As String = Me.TextBoxhour.Text & ":" & Me.TextBoxminute.Text & ":" & Me.TextBoxsecond.Text
                If Operators.CompareString(Me.TextBox1.Text, "", TextCompare:=False) = 0 Then
                    Me.TextBox1.Text = "0"
                End If
                配置文件操作模块.写入主程序配置(Me.Days.Text, 运行时间, Me.CheckBox是否关服备份.Checked, Conversions.ToInteger(Me.WaitingSeconds.Text), Conversions.ToInteger(Me.FPS.Text), Me.CheckBox1.Checked, Conversions.ToInteger(Me.TextBox1.Text), Me.CheckBox2.Checked, Conversions.ToInteger(Me.TextBox2.Text))
                Call 日志窗口.日志输出主程序配置()
                日志窗口.添加日志("关闭主程序设置窗口", 5)
                Close()
            End If
        End Sub

        Private Sub MainSettingsForm_Load(sender As Object, e As EventArgs)
            配置文件操作模块.读取主程序配置()
            Me.Days.Text = 配置文件操作模块.间隔天数
            Me.TextBoxhour.Text = 配置文件操作模块.运行时间.Split(":")(0)
            Me.TextBoxminute.Text = 配置文件操作模块.运行时间.Split(":")(1)
            Me.TextBoxsecond.Text = 配置文件操作模块.运行时间.Split(":")(2)
            Me.CheckBox是否关服备份.Checked = 配置文件操作模块.是否关服备份
            Me.WaitingSeconds.Text = 配置文件操作模块.等待服务端关闭时长.ToString()
            Me.CheckBox1.Checked = 配置文件操作模块.运行模式
            Me.FPS.Text = 配置文件操作模块.帧数.ToString()
            Me.TextBox1.Text = 配置文件操作模块.日志窗口位置更新频率.ToString()
            Me.CheckBox2.Checked = 配置文件操作模块.备份模式
            Me.TextBox2.Text = Conversions.ToString(配置文件操作模块.读取缓冲区大小)
        End Sub

        Private Sub MainSettingsForm_Activated(sender As Object, e As EventArgs)
            If Owner IsNot Nothing AndAlso TypeOf Owner Is MainForm Then
                日志窗口.更新停靠位置(Me)
            End If
        End Sub

        Private Sub MainSettingsForm_Move(sender As Object, e As EventArgs)
            If Owner IsNot Nothing AndAlso TypeOf Owner Is MainForm Then
                日志窗口.更新停靠位置(Me)
            End If
        End Sub
    End Class
End Namespace
