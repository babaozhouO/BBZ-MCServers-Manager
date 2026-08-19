Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <DesignerGenerated>
    Partial Public Class UselessToolsForm
        Inherits Form
        Private _ComboBoxRCON As ComboBox
        Friend Property ComboBoxRCON As ComboBox
            Get
                Return _ComboBoxRCON
            End Get
            Set(value As ComboBox)
                _ComboBoxRCON = value
            End Set
        End Property
        Private _ComboBoxSftp As ComboBox
        Friend Property ComboBoxSftp As ComboBox
            Get
                Return _ComboBoxSftp
            End Get
            Set(value As ComboBox)
                _ComboBoxSftp = value
            End Set
        End Property
        Private _Command As TextBox
        Friend Property Command As TextBox
            Get
                Return _Command
            End Get
            Set(value As TextBox)
                _Command = value
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
        Private _WaitingSeconds As TextBox
        Friend Property WaitingSeconds As TextBox
            Get
                Return _WaitingSeconds
            End Get
            Set(value As TextBox)
                _WaitingSeconds = value
            End Set
        End Property
        Private _选择文件 As OpenFileDialog
        Friend Property 选择文件 As OpenFileDialog
            Get
                Return _选择文件
            End Get
            Set(value As OpenFileDialog)
                _选择文件 = value
            End Set
        End Property
        Private _远程目录 As TextBox
        Friend Property 远程目录 As TextBox
            Get
                Return _远程目录
            End Get
            Set(value As TextBox)
                _远程目录 = value
            End Set
        End Property

        Private components As IContainer

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("安装7Zip")>
        Private _安装7Zip As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("退出")>
        Private _退出 As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("Connect")>
        Private _Connect As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ChooseFile")>
        Private _ChooseFile As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("FileSend")>
        Private _FileSend As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("启动MC服务端")>
        Private _启动MC服务端 As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("倒计时冷却")>
        Private _倒计时冷却 As Timer

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("GetMissedMessage")>
        Private _GetMissedMessage As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("DisConnect")>
        Private _DisConnect As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("Send")>
        Private _Send As Button

        Private RCON实例1 As RCON客户端

        Private RCON实例2 As RCON客户端

        Private RCON实例3 As RCON客户端

        Private RCON实例4 As RCON客户端

        Private RCON实例5 As RCON客户端

        Private RCON实例6 As RCON客户端

        Private RCON实例7 As RCON客户端

        Private RCON实例8 As RCON客户端

        Private RCON实例9 As RCON客户端

        Private RCON实例10 As RCON客户端

        Friend Overridable Property 安装7Zip As Button
            <CompilerGenerated>
            Get
                Return _安装7Zip
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf 安装7Zip_Click
                Dim button = _安装7Zip
                If button IsNot Nothing Then
                    RemoveHandler button.Click, value2
                End If
                _安装7Zip = value
                button = _安装7Zip
                If button IsNot Nothing Then
                    AddHandler button.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property 退出 As Button
            <CompilerGenerated>
            Get
                Return _退出
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf 退出_Click
                Dim button = _退出
                If button IsNot Nothing Then
                    RemoveHandler button.Click, value2
                End If
                _退出 = value
                button = _退出
                If button IsNot Nothing Then
                    AddHandler button.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Connect As Button
            <CompilerGenerated>
            Get
                Return _Connect
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf Connect_Click
                Dim lConnect = _Connect
                If lConnect IsNot Nothing Then
                    RemoveHandler lConnect.Click, value2
                End If
                _Connect = value
                lConnect = _Connect
                If lConnect IsNot Nothing Then
                    AddHandler lConnect.Click, value2
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("ComboBoxRCON")]
''' 	internal virtual System.Windows.Forms.ComboBox ComboBoxRCON
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Command")]
''' 	internal virtual System.Windows.Forms.TextBox Command
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("ComboBoxSftp")]
''' 	internal virtual System.Windows.Forms.ComboBox ComboBoxSftp
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property ChooseFile As Button
            <CompilerGenerated>
            Get
                Return _ChooseFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ChooseFile_Click
                Dim lChooseFile = _ChooseFile
                If lChooseFile IsNot Nothing Then
                    RemoveHandler lChooseFile.Click, value2
                End If
                _ChooseFile = value
                lChooseFile = _ChooseFile
                If lChooseFile IsNot Nothing Then
                    AddHandler lChooseFile.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property FileSend As Button
            <CompilerGenerated>
            Get
                Return _FileSend
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf FileSend_Click
                Dim lFileSend = _FileSend
                If lFileSend IsNot Nothing Then
                    RemoveHandler lFileSend.Click, value2
                End If
                _FileSend = value
                lFileSend = _FileSend
                If lFileSend IsNot Nothing Then
                    AddHandler lFileSend.Click, value2
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("选择文件")]
''' 	internal virtual System.Windows.Forms.OpenFileDialog 选择文件
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("远程目录")]
''' 	internal virtual System.Windows.Forms.TextBox 远程目录
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property 启动MC服务端 As Button
            <CompilerGenerated>
            Get
                Return _启动MC服务端
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf 启动MC服务端_Click
                Dim button = _启动MC服务端
                If button IsNot Nothing Then
                    RemoveHandler button.Click, value2
                End If
                _启动MC服务端 = value
                button = _启动MC服务端
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("WaitingSeconds")]
''' 	internal virtual System.Windows.Forms.TextBox WaitingSeconds
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property 倒计时冷却 As Timer
            <CompilerGenerated>
            Get
                Return _倒计时冷却
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Timer)
                Dim value2 As EventHandler = Sub(a0, a1) 冷却结束()
                Dim timer = _倒计时冷却
                If timer IsNot Nothing Then
                    RemoveHandler timer.Tick, value2
                End If
                _倒计时冷却 = value
                timer = _倒计时冷却
                If timer IsNot Nothing Then
                    AddHandler timer.Tick, value2
                End If
            End Set
        End Property

        Friend Overridable Property GetMissedMessage As Button
            <CompilerGenerated>
            Get
                Return _GetMissedMessage
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf GetMissedMessage_Click
                Dim lGetMissedMessage = _GetMissedMessage
                If lGetMissedMessage IsNot Nothing Then
                    RemoveHandler lGetMissedMessage.Click, value2
                End If
                _GetMissedMessage = value
                lGetMissedMessage = _GetMissedMessage
                If lGetMissedMessage IsNot Nothing Then
                    AddHandler lGetMissedMessage.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property DisConnect As Button
            <CompilerGenerated>
            Get
                Return _DisConnect
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf DisConnect_Click
                Dim lDisConnect = _DisConnect
                If lDisConnect IsNot Nothing Then
                    RemoveHandler lDisConnect.Click, value2
                End If
                _DisConnect = value
                lDisConnect = _DisConnect
                If lDisConnect IsNot Nothing Then
                    AddHandler lDisConnect.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Send As Button
            <CompilerGenerated>
            Get
                Return _Send
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf Send_Click
                Dim lSend = _Send
                If lSend IsNot Nothing Then
                    RemoveHandler lSend.Click, value2
                End If
                _Send = value
                lSend = _Send
                If lSend IsNot Nothing Then
                    AddHandler lSend.Click, value2
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("Label8")]
''' 	internal virtual System.Windows.Forms.Label Label8
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Public Sub New()
            AddHandler Load, AddressOf UselessToolsForm_Load
            AddHandler Activated, AddressOf UselessToolsForm_Activated
            AddHandler Move, AddressOf UselessToolsForm_Move
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
            components = New Container()
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(UselessToolsForm))
            安装7Zip = New Button()
            退出 = New Button()
            Connect = New Button()
            Me.ComboBoxRCON = New ComboBox()
            Me.Command = New TextBox()
            Me.Label1 = New Label()
            Me.ComboBoxSftp = New ComboBox()
            ChooseFile = New Button()
            FileSend = New Button()
            Me.选择文件 = New OpenFileDialog()
            Me.Label2 = New Label()
            Me.Label3 = New Label()
            Me.Label4 = New Label()
            Me.远程目录 = New TextBox()
            启动MC服务端 = New Button()
            Me.Label5 = New Label()
            Me.WaitingSeconds = New TextBox()
            倒计时冷却 = New Timer(components)
            GetMissedMessage = New Button()
            DisConnect = New Button()
            Send = New Button()
            Me.Label7 = New Label()
            Me.Label8 = New Label()
            SuspendLayout()
            安装7Zip.Location = New Point(32, 215)
            安装7Zip.Name = "安装7Zip"
            安装7Zip.Size = New Size(226, 49)
            安装7Zip.TabIndex = 0
            安装7Zip.Text = "安装7-Zip(需要以管理员身份运行本程序)"
            安装7Zip.UseVisualStyleBackColor = True
            退出.Location = New Point(550, 306)
            退出.Name = "退出"
            退出.Size = New Size(132, 73)
            退出.TabIndex = 1
            退出.Text = "关掉这个破玩意"
            退出.UseVisualStyleBackColor = True
            Connect.Location = New Point(148, 41)
            Connect.Name = "Connect"
            Connect.Size = New Size(37, 54)
            Connect.TabIndex = 2
            Connect.Text = "连接"
            Connect.UseVisualStyleBackColor = True
            Me.ComboBoxRCON.FormattingEnabled = True
            Me.ComboBoxRCON.Location = New Point(32, 41)
            Me.ComboBoxRCON.Name = "ComboBoxRCON"
            Me.ComboBoxRCON.Size = New Size(110, 27)
            Me.ComboBoxRCON.TabIndex = 3
            Me.Command.Location = New Point(32, 71)
            Me.Command.Name = "Command"
            Me.Command.Size = New Size(110, 24)
            Me.Command.TabIndex = 4
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = Color.Transparent
            Me.Label1.ForeColor = SystemColors.ControlDark
            Me.Label1.Location = New Point(32, 98)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(61, 19)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "无需斜杠"
            Me.ComboBoxSftp.FormattingEnabled = True
            Me.ComboBoxSftp.Location = New Point(345, 41)
            Me.ComboBoxSftp.Name = "ComboBoxSftp"
            Me.ComboBoxSftp.Size = New Size(110, 27)
            Me.ComboBoxSftp.TabIndex = 6
            ChooseFile.Location = New Point(345, 71)
            ChooseFile.Name = "ChooseFile"
            ChooseFile.Size = New Size(110, 24)
            ChooseFile.TabIndex = 7
            ChooseFile.Text = "选择文件"
            ChooseFile.UseVisualStyleBackColor = True
            FileSend.Location = New Point(461, 41)
            FileSend.Name = "FileSend"
            FileSend.Size = New Size(110, 54)
            FileSend.TabIndex = 8
            FileSend.Text = "发送"
            FileSend.UseVisualStyleBackColor = True
            Me.选择文件.ShowHiddenFiles = True
            Me.选择文件.Title = "选择要发送的文件"
            Me.Label2.AutoSize = True
            Me.Label2.Location = New Point(32, 19)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(213, 19)
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "向选中的MC服务器发送自定义指令"
            Me.Label3.AutoSize = True
            Me.Label3.Location = New Point(345, 19)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(127, 19)
            Me.Label3.TabIndex = 10
            Me.Label3.Text = "向选中的Sftp服务器"
            Me.Label4.AutoSize = True
            Me.Label4.Location = New Point(595, 19)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(87, 19)
            Me.Label4.TabIndex = 11
            Me.Label4.Text = "目录发送文件"
            Me.远程目录.Location = New Point(478, 16)
            Me.远程目录.Name = "远程目录"
            Me.远程目录.Size = New Size(111, 24)
            Me.远程目录.TabIndex = 12
            启动MC服务端.Location = New Point(32, 174)
            启动MC服务端.Name = "启动MC服务端"
            启动MC服务端.Size = New Size(226, 35)
            启动MC服务端.TabIndex = 13
            启动MC服务端.Text = "启动已启用的MC服务端"
            启动MC服务端.UseVisualStyleBackColor = True
            Me.Label5.AutoSize = True
            Me.Label5.Location = New Point(99, 98)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(166, 19)
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "等待响应返回时长:         秒"
            Me.WaitingSeconds.Location = New Point(212, 95)
            Me.WaitingSeconds.Name = "WaitingSeconds"
            Me.WaitingSeconds.Size = New Size(32, 24)
            Me.WaitingSeconds.TabIndex = 15
            Me.WaitingSeconds.Text = "3"
            倒计时冷却.Interval = 30000
            GetMissedMessage.Enabled = False
            GetMissedMessage.Location = New Point(33, 120)
            GetMissedMessage.Name = "GetMissedMessage"
            GetMissedMessage.Size = New Size(225, 48)
            GetMissedMessage.TabIndex = 16
            GetMissedMessage.Text = "如果输出不完整" & vbCrLf & "点我"
            GetMissedMessage.UseVisualStyleBackColor = True
            DisConnect.Enabled = False
            DisConnect.Location = New Point(221, 41)
            DisConnect.Name = "DisConnect"
            DisConnect.Size = New Size(37, 54)
            DisConnect.TabIndex = 17
            DisConnect.Text = "断开"
            DisConnect.UseVisualStyleBackColor = True
            Send.Enabled = False
            Send.Location = New Point(184, 41)
            Send.Name = "Send"
            Send.Size = New Size(38, 54)
            Send.TabIndex = 18
            Send.Text = "发送"
            Send.UseVisualStyleBackColor = True
            Me.Label7.AutoSize = True
            Me.Label7.Location = New Point(345, 150)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Size(243, 114)
            Me.Label7.TabIndex = 20
            Me.Label7.Text = "得益于八宝粥设计的强大的路径修正机制" & vbCrLf & "你可以输入这样的路径：" & vbCrLf & "1.不以斜杠开头" & vbCrLf & "2.混合使用正反斜杠" & vbCrLf & "3.以任意斜杠结尾" & vbCrLf & "4.不输入根目录斜杠"
            Me.Label8.AutoSize = True
            Me.Label8.Location = New Point(345, 98)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Size(153, 38)
            Me.Label8.TabIndex = 21
            Me.Label8.Text = "正确示范：" & vbCrLf & ChrW(8220) & "/path1/path2/path3" & ChrW(8221)
            AutoScaleDimensions = New SizeF(8F, 19F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(694, 391)
            ControlBox = False
            Controls.Add(Me.Label8)
            Controls.Add(Me.Label7)
            Controls.Add(Send)
            Controls.Add(DisConnect)
            Controls.Add(GetMissedMessage)
            Controls.Add(Me.WaitingSeconds)
            Controls.Add(Me.Label5)
            Controls.Add(启动MC服务端)
            Controls.Add(Me.远程目录)
            Controls.Add(Me.Label4)
            Controls.Add(Me.Label3)
            Controls.Add(Me.Label2)
            Controls.Add(FileSend)
            Controls.Add(ChooseFile)
            Controls.Add(Me.ComboBoxSftp)
            Controls.Add(Me.Label1)
            Controls.Add(Me.Command)
            Controls.Add(Me.ComboBoxRCON)
            Controls.Add(Connect)
            Controls.Add(退出)
            Controls.Add(安装7Zip)
            Font = New Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134)
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            Location = New Point(800, 300)
            Name = "UselessToolsForm"
            ShowIcon = False
            ShowInTaskbar = False
            StartPosition = FormStartPosition.Manual
            Text = "没用的小工具"
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Private Sub UselessToolsForm_Load(sender As Object, e As EventArgs)
            初始化RCON选择项()
            初始化Sftp选择项()
        End Sub

        Private Sub UselessToolsForm_Activated(sender As Object, e As EventArgs)
            If Owner IsNot Nothing AndAlso TypeOf Owner Is MainForm Then
                日志窗口.更新停靠位置(Me)
            End If
        End Sub

        Private Sub UselessToolsForm_Move(sender As Object, e As EventArgs)
            If Owner IsNot Nothing AndAlso TypeOf Owner Is MainForm Then
                日志窗口.更新停靠位置(Me)
            End If
        End Sub

        Private Sub 安装7Zip_Click(sender As Object, e As EventArgs)
            Dim text = Path.Combine(配置文件操作模块.程序数据目录, "资源", "7z2409-x64.exe")
            If Not File.Exists(text) Then
                日志窗口.添加日志("资源文件被你删了", 2)
                MsgBox("你个坏蛋,把我的资源文件删了！", MsgBoxStyle.Critical, "坏蛋！")
            ElseIf Not 管理员身份运行检测.是否以管理员身份运行() Then
                日志窗口.添加日志("都叫你用管理员身份运行此程序了,你就是不听", 2)
                MsgBox("都叫你用管理员身份运行此程序了,你就是不听", MsgBoxStyle.Critical, "错误")
            Else
                Process.Start(text)
            End If
        End Sub

        Private Sub 退出_Click(sender As Object, e As EventArgs)
            Dim dialogResult = MessageBox.Show("确认退出?", "提示", MessageBoxButtons.YesNo)
            If dialogResult = DialogResult.Yes Then
                If RCON实例1 IsNot Nothing Then
                    RCON实例1.释放资源()
                    RCON实例1 = Nothing
                End If
                If RCON实例2 IsNot Nothing Then
                    RCON实例2.释放资源()
                    RCON实例2 = Nothing
                End If
                If RCON实例3 IsNot Nothing Then
                    RCON实例3.释放资源()
                    RCON实例3 = Nothing
                End If
                If RCON实例4 IsNot Nothing Then
                    RCON实例4.释放资源()
                    RCON实例4 = Nothing
                End If
                If RCON实例5 IsNot Nothing Then
                    RCON实例5.释放资源()
                    RCON实例5 = Nothing
                End If
                If RCON实例6 IsNot Nothing Then
                    RCON实例6.释放资源()
                    RCON实例6 = Nothing
                End If
                If RCON实例7 IsNot Nothing Then
                    RCON实例7.释放资源()
                    RCON实例7 = Nothing
                End If
                If RCON实例8 IsNot Nothing Then
                    RCON实例8.释放资源()
                    RCON实例8 = Nothing
                End If
                If RCON实例9 IsNot Nothing Then
                    RCON实例9.释放资源()
                    RCON实例9 = Nothing
                End If
                If RCON实例10 IsNot Nothing Then
                    RCON实例10.释放资源()
                    RCON实例10 = Nothing
                End If
                Close()
            End If
        End Sub

        Private Sub 初始化RCON选择项()
            Me.ComboBoxRCON.Items.Clear()
            If 配置文件操作模块.是否控制MC服务端1 Then
                Me.ComboBoxRCON.Items.Add(配置文件操作模块.MC服务端1名称)
                RCON实例1 = New RCON客户端(1)
            End If
            If 配置文件操作模块.是否控制MC服务端2 Then
                Me.ComboBoxRCON.Items.Add(配置文件操作模块.MC服务端2名称)
                RCON实例2 = New RCON客户端(2)
            End If
            If 配置文件操作模块.是否控制MC服务端3 Then
                Me.ComboBoxRCON.Items.Add(配置文件操作模块.MC服务端3名称)
                RCON实例3 = New RCON客户端(3)
            End If
            If 配置文件操作模块.是否控制MC服务端4 Then
                Me.ComboBoxRCON.Items.Add(配置文件操作模块.MC服务端4名称)
                RCON实例4 = New RCON客户端(4)
            End If
            If 配置文件操作模块.是否控制MC服务端5 Then
                Me.ComboBoxRCON.Items.Add(配置文件操作模块.MC服务端5名称)
                RCON实例5 = New RCON客户端(5)
            End If
            If 配置文件操作模块.是否控制MC服务端6 Then
                Me.ComboBoxRCON.Items.Add(配置文件操作模块.MC服务端6名称)
                RCON实例6 = New RCON客户端(6)
            End If
            If 配置文件操作模块.是否控制MC服务端7 Then
                Me.ComboBoxRCON.Items.Add(配置文件操作模块.MC服务端7名称)
                RCON实例7 = New RCON客户端(7)
            End If
            If 配置文件操作模块.是否控制MC服务端8 Then
                Me.ComboBoxRCON.Items.Add(配置文件操作模块.MC服务端8名称)
                RCON实例8 = New RCON客户端(8)
            End If
            If 配置文件操作模块.是否控制MC服务端9 Then
                Me.ComboBoxRCON.Items.Add(配置文件操作模块.MC服务端9名称)
                RCON实例9 = New RCON客户端(9)
            End If
            If 配置文件操作模块.是否控制MC服务端10 Then
                Me.ComboBoxRCON.Items.Add(配置文件操作模块.MC服务端10名称)
                RCON实例10 = New RCON客户端(10)
            End If
            If Me.ComboBoxRCON.Items.Count = 0 Then
                Me.ComboBoxRCON.Items.Add("没有可用的RCON服务端,全给你关掉了(恼)")
            Else
                Me.ComboBoxRCON.Items.Add("所有已启用服务端")
            End If
            Me.ComboBoxRCON.SelectedIndex = 0
        End Sub

        Private Sub 初始化Sftp选择项()
            Me.ComboBoxSftp.Items.Clear()
            If 配置文件操作模块.Sftp1开关 Then
                Me.ComboBoxSftp.Items.Add(配置文件操作模块.Sftp1名称)
            End If
            If 配置文件操作模块.Sftp2开关 Then
                Me.ComboBoxSftp.Items.Add(配置文件操作模块.Sftp2名称)
            End If
            If 配置文件操作模块.Sftp3开关 Then
                Me.ComboBoxSftp.Items.Add(配置文件操作模块.Sftp3名称)
            End If
            If Me.ComboBoxSftp.Items.Count = 0 Then
                Me.ComboBoxSftp.Items.Add("没有可用的SFTP服务器,全给你关掉了(恼)")
            End If
            Me.ComboBoxSftp.SelectedIndex = 0
        End Sub

        Private Sub Connect_Click(sender As Object, e As EventArgs)
            Dim text As String = Me.ComboBoxRCON.Text
            Dim text2 As String = Me.Command.Text
            Dim num = Conversions.ToInteger(Me.WaitingSeconds.Text)
            Dim left = text
            If Operators.CompareString(left, 配置文件操作模块.MC服务端1名称, TextCompare:=False) = 0 Then
                RCON实例1.连接RCON(配置文件操作模块.RCON1地址, Conversions.ToInteger(配置文件操作模块.RCON1端口), 配置文件操作模块.RCON1密码)
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端2名称, TextCompare:=False) = 0 Then
                RCON实例2.连接RCON(配置文件操作模块.RCON2地址, Conversions.ToInteger(配置文件操作模块.RCON2端口), 配置文件操作模块.RCON2密码)
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端3名称, TextCompare:=False) = 0 Then
                RCON实例3.连接RCON(配置文件操作模块.RCON3地址, Conversions.ToInteger(配置文件操作模块.RCON3端口), 配置文件操作模块.RCON3密码)
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端4名称, TextCompare:=False) = 0 Then
                RCON实例4.连接RCON(配置文件操作模块.RCON4地址, Conversions.ToInteger(配置文件操作模块.RCON4端口), 配置文件操作模块.RCON4密码)
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端5名称, TextCompare:=False) = 0 Then
                RCON实例5.连接RCON(配置文件操作模块.RCON5地址, Conversions.ToInteger(配置文件操作模块.RCON5端口), 配置文件操作模块.RCON5密码)
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端6名称, TextCompare:=False) = 0 Then
                RCON实例6.连接RCON(配置文件操作模块.RCON6地址, Conversions.ToInteger(配置文件操作模块.RCON6端口), 配置文件操作模块.RCON6密码)
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端7名称, TextCompare:=False) = 0 Then
                RCON实例7.连接RCON(配置文件操作模块.RCON7地址, Conversions.ToInteger(配置文件操作模块.RCON7端口), 配置文件操作模块.RCON7密码)
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端8名称, TextCompare:=False) = 0 Then
                RCON实例8.连接RCON(配置文件操作模块.RCON8地址, Conversions.ToInteger(配置文件操作模块.RCON8端口), 配置文件操作模块.RCON8密码)
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端9名称, TextCompare:=False) = 0 Then
                RCON实例9.连接RCON(配置文件操作模块.RCON9地址, Conversions.ToInteger(配置文件操作模块.RCON9端口), 配置文件操作模块.RCON9密码)
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端10名称, TextCompare:=False) = 0 Then
                RCON实例10.连接RCON(配置文件操作模块.RCON10地址, Conversions.ToInteger(配置文件操作模块.RCON10端口), 配置文件操作模块.RCON10密码)
            Else
                If Operators.CompareString(left, "所有已启用服务端", TextCompare:=False) <> 0 Then
                    日志窗口.添加日志("无效服务端！", 1)
                    Me.ComboBoxRCON.SelectedIndex = 0
                    Return
                End If
                If 配置文件操作模块.是否控制MC服务端1 Then
                    RCON实例1.连接RCON(配置文件操作模块.RCON1地址, Conversions.ToInteger(配置文件操作模块.RCON1端口), 配置文件操作模块.RCON1密码)
                End If
                If 配置文件操作模块.是否控制MC服务端2 Then
                    RCON实例2.连接RCON(配置文件操作模块.RCON2地址, Conversions.ToInteger(配置文件操作模块.RCON2端口), 配置文件操作模块.RCON2密码)
                End If
                If 配置文件操作模块.是否控制MC服务端3 Then
                    RCON实例3.连接RCON(配置文件操作模块.RCON2地址, Conversions.ToInteger(配置文件操作模块.RCON2端口), 配置文件操作模块.RCON2密码)
                End If
                If 配置文件操作模块.是否控制MC服务端4 Then
                    RCON实例4.连接RCON(配置文件操作模块.RCON4地址, Conversions.ToInteger(配置文件操作模块.RCON4端口), 配置文件操作模块.RCON4密码)
                End If
                If 配置文件操作模块.是否控制MC服务端5 Then
                    RCON实例5.连接RCON(配置文件操作模块.RCON5地址, Conversions.ToInteger(配置文件操作模块.RCON5端口), 配置文件操作模块.RCON5密码)
                End If
                If 配置文件操作模块.是否控制MC服务端6 Then
                    RCON实例6.连接RCON(配置文件操作模块.RCON6地址, Conversions.ToInteger(配置文件操作模块.RCON6端口), 配置文件操作模块.RCON6密码)
                End If
                If 配置文件操作模块.是否控制MC服务端7 Then
                    RCON实例7.连接RCON(配置文件操作模块.RCON7地址, Conversions.ToInteger(配置文件操作模块.RCON7端口), 配置文件操作模块.RCON7密码)
                End If
                If 配置文件操作模块.是否控制MC服务端8 Then
                    RCON实例8.连接RCON(配置文件操作模块.RCON8地址, Conversions.ToInteger(配置文件操作模块.RCON8端口), 配置文件操作模块.RCON8密码)
                End If
                If 配置文件操作模块.是否控制MC服务端9 Then
                    RCON实例9.连接RCON(配置文件操作模块.RCON9地址, Conversions.ToInteger(配置文件操作模块.RCON9端口), 配置文件操作模块.RCON9密码)
                End If
                If 配置文件操作模块.是否控制MC服务端10 Then
                    RCON实例10.连接RCON(配置文件操作模块.RCON10地址, Conversions.ToInteger(配置文件操作模块.RCON10端口), 配置文件操作模块.RCON10密码)
                End If
            End If
            If RCON实例1 IsNot Nothing AndAlso RCON实例1.连接状态 Or RCON实例2 IsNot Nothing AndAlso RCON实例2.连接状态 Or RCON实例3 IsNot Nothing AndAlso RCON实例3.连接状态 Or RCON实例4 IsNot Nothing AndAlso RCON实例4.连接状态 Or RCON实例5 IsNot Nothing AndAlso RCON实例5.连接状态 Or RCON实例6 IsNot Nothing AndAlso RCON实例6.连接状态 Or RCON实例7 IsNot Nothing AndAlso RCON实例7.连接状态 Or RCON实例8 IsNot Nothing AndAlso RCON实例8.连接状态 Or RCON实例9 IsNot Nothing AndAlso RCON实例9.连接状态 Or RCON实例10 IsNot Nothing AndAlso RCON实例10.连接状态 Then
                Connect.Enabled = False
                Send.Enabled = True
                DisConnect.Enabled = True
                GetMissedMessage.Enabled = False
            End If
        End Sub

        Private Sub Send_Click(sender As Object, e As EventArgs)
            Dim 等待时长 = Conversions.ToInteger(Me.WaitingSeconds.Text)
            Dim text As String = Me.Command.Text
            Dim text2 As String = Me.ComboBoxRCON.Text
            If Operators.CompareString(text2, 配置文件操作模块.MC服务端1名称, TextCompare:=False) = 0 Then
                RCON实例1.发送指令并返回响应(text, 等待时长)
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端2名称, TextCompare:=False) = 0 Then
                RCON实例2.发送指令并返回响应(text, 等待时长)
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端3名称, TextCompare:=False) = 0 Then
                RCON实例3.发送指令并返回响应(text, 等待时长)
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端4名称, TextCompare:=False) = 0 Then
                RCON实例4.发送指令并返回响应(text, 等待时长)
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端5名称, TextCompare:=False) = 0 Then
                RCON实例5.发送指令并返回响应(text, 等待时长)
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端6名称, TextCompare:=False) = 0 Then
                RCON实例6.发送指令并返回响应(text, 等待时长)
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端7名称, TextCompare:=False) = 0 Then
                RCON实例7.发送指令并返回响应(text, 等待时长)
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端8名称, TextCompare:=False) = 0 Then
                RCON实例8.发送指令并返回响应(text, 等待时长)
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端9名称, TextCompare:=False) = 0 Then
                RCON实例9.发送指令并返回响应(text, 等待时长)
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端10名称, TextCompare:=False) = 0 Then
                RCON实例10.发送指令并返回响应(text, 等待时长)
            ElseIf Operators.CompareString(text2, "所有已启用服务端", TextCompare:=False) = 0 Then
                If 配置文件操作模块.是否控制MC服务端1 Then
                    RCON实例1.发送指令并返回响应(text, 等待时长)
                End If
                If 配置文件操作模块.是否控制MC服务端2 Then
                    RCON实例2.发送指令并返回响应(text, 等待时长)
                End If
                If 配置文件操作模块.是否控制MC服务端3 Then
                    RCON实例3.发送指令并返回响应(text, 等待时长)
                End If
                If 配置文件操作模块.是否控制MC服务端4 Then
                    RCON实例4.发送指令并返回响应(text, 等待时长)
                End If
                If 配置文件操作模块.是否控制MC服务端5 Then
                    RCON实例5.发送指令并返回响应(text, 等待时长)
                End If
                If 配置文件操作模块.是否控制MC服务端6 Then
                    RCON实例6.发送指令并返回响应(text, 等待时长)
                End If
                If 配置文件操作模块.是否控制MC服务端7 Then
                    RCON实例7.发送指令并返回响应(text, 等待时长)
                End If
                If 配置文件操作模块.是否控制MC服务端8 Then
                    RCON实例8.发送指令并返回响应(text, 等待时长)
                End If
                If 配置文件操作模块.是否控制MC服务端9 Then
                    RCON实例9.发送指令并返回响应(text, 等待时长)
                End If
                If 配置文件操作模块.是否控制MC服务端10 Then
                    RCON实例10.发送指令并返回响应(text, 等待时长)
                End If
            End If
            GetMissedMessage.Enabled = True
        End Sub

        Private Sub DisConnect_Click(sender As Object, e As EventArgs)
            Dim text As String = Me.ComboBoxRCON.Text
            Dim left = text
            If Operators.CompareString(left, 配置文件操作模块.MC服务端1名称, TextCompare:=False) = 0 Then
                RCON实例1.软断开()
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端2名称, TextCompare:=False) = 0 Then
                RCON实例2.软断开()
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端3名称, TextCompare:=False) = 0 Then
                RCON实例3.软断开()
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端4名称, TextCompare:=False) = 0 Then
                RCON实例4.软断开()
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端5名称, TextCompare:=False) = 0 Then
                RCON实例5.软断开()
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端6名称, TextCompare:=False) = 0 Then
                RCON实例6.软断开()
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端7名称, TextCompare:=False) = 0 Then
                RCON实例7.软断开()
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端8名称, TextCompare:=False) = 0 Then
                RCON实例8.软断开()
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端9名称, TextCompare:=False) = 0 Then
                RCON实例9.软断开()
            ElseIf Operators.CompareString(left, 配置文件操作模块.MC服务端10名称, TextCompare:=False) = 0 Then
                RCON实例10.软断开()
            ElseIf Operators.CompareString(left, "所有已启用服务端", TextCompare:=False) = 0 Then
                If 配置文件操作模块.是否控制MC服务端1 Then
                    RCON实例1.软断开()
                End If
                If 配置文件操作模块.是否控制MC服务端2 Then
                    RCON实例2.软断开()
                End If
                If 配置文件操作模块.是否控制MC服务端3 Then
                    RCON实例3.软断开()
                End If
                If 配置文件操作模块.是否控制MC服务端4 Then
                    RCON实例4.软断开()
                End If
                If 配置文件操作模块.是否控制MC服务端5 Then
                    RCON实例5.软断开()
                End If
                If 配置文件操作模块.是否控制MC服务端6 Then
                    RCON实例6.软断开()
                End If
                If 配置文件操作模块.是否控制MC服务端7 Then
                    RCON实例7.软断开()
                End If
                If 配置文件操作模块.是否控制MC服务端8 Then
                    RCON实例8.软断开()
                End If
                If 配置文件操作模块.是否控制MC服务端9 Then
                    RCON实例9.软断开()
                End If
                If 配置文件操作模块.是否控制MC服务端10 Then
                    RCON实例10.软断开()
                End If
            End If
            Connect.Enabled = True
            Send.Enabled = False
            DisConnect.Enabled = False
            GetMissedMessage.Enabled = False
        End Sub

        Private Sub GetMissedMessage_Click(sender As Object, e As EventArgs)
            Dim text = ""
            Dim text2 As String = Me.ComboBoxRCON.Text
            Dim num As Integer = Nothing
            If Operators.CompareString(text2, 配置文件操作模块.MC服务端1名称, TextCompare:=False) = 0 Then
                text = RCON实例1.读取返回数据包().Item2
                num = 1
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端2名称, TextCompare:=False) = 0 Then
                text = RCON实例1.读取返回数据包().Item2
                num = 2
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端3名称, TextCompare:=False) = 0 Then
                text = RCON实例1.读取返回数据包().Item2
                num = 3
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端4名称, TextCompare:=False) = 0 Then
                text = RCON实例1.读取返回数据包().Item2
                num = 4
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端5名称, TextCompare:=False) = 0 Then
                text = RCON实例1.读取返回数据包().Item2
                num = 5
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端6名称, TextCompare:=False) = 0 Then
                text = RCON实例1.读取返回数据包().Item2
                num = 6
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端7名称, TextCompare:=False) = 0 Then
                text = RCON实例1.读取返回数据包().Item2
                num = 7
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端8名称, TextCompare:=False) = 0 Then
                text = RCON实例1.读取返回数据包().Item2
                num = 8
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端9名称, TextCompare:=False) = 0 Then
                text = RCON实例1.读取返回数据包().Item2
                num = 9
            ElseIf Operators.CompareString(text2, 配置文件操作模块.MC服务端10名称, TextCompare:=False) = 0 Then
                text = RCON实例1.读取返回数据包().Item2
                num = 10
            End If
            If Operators.CompareString(text, "空", TextCompare:=False) <> 0 Then
                日志窗口.添加日志($"MC服务器{num}指令返回信息:", 0)
                日志窗口.添加日志(text, 0)
            End If
        End Sub

        Private Sub ChooseFile_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("选择要发送的文件", 5)
            Me.选择文件.ShowDialog()
        End Sub

        Private Sub FileSend_Click(sender As Object, e As EventArgs)
            Dim text As String = Me.ComboBoxSftp.Text
            Dim fileName As String = Me.选择文件.FileName
            Dim text2 As String = Me.远程目录.Text
            Dim left = text
            If Operators.CompareString(left, 配置文件操作模块.Sftp1名称, TextCompare:=False) = 0 Then
                处理单个Sftp服务端功能.处理单个Sftp服务端_上传文件(配置文件操作模块.Sftp1地址, 配置文件操作模块.Sftp1端口, 配置文件操作模块.Sftp1用户名, 配置文件操作模块.Sftp1密码, "1", fileName, text2)
                Return
            End If
            If Operators.CompareString(left, 配置文件操作模块.Sftp2名称, TextCompare:=False) = 0 Then
                处理单个Sftp服务端功能.处理单个Sftp服务端_上传文件(配置文件操作模块.Sftp2地址, 配置文件操作模块.Sftp2端口, 配置文件操作模块.Sftp2用户名, 配置文件操作模块.Sftp2密码, "2", fileName, text2)
                Return
            End If
            If Operators.CompareString(left, 配置文件操作模块.Sftp3名称, TextCompare:=False) = 0 Then
                处理单个Sftp服务端功能.处理单个Sftp服务端_上传文件(配置文件操作模块.Sftp3地址, 配置文件操作模块.Sftp3端口, 配置文件操作模块.Sftp3用户名, 配置文件操作模块.Sftp3密码, "3", fileName, text2)
                Return
            End If
            日志窗口.添加日志("无效服务器！", 1)
            Me.ComboBoxSftp.SelectedIndex = 0
        End Sub

        Private Sub 启动MC服务端_Click(sender As Object, e As EventArgs)
            倒计时冷却.Interval = 30000
            倒计时冷却.Enabled = True
            启动MC服务端.Enabled = False
            启动MC服务端.Text = "启动已启用的MC服务端(冷却中)"
            If Operators.CompareString(Me.ComboBoxRCON.Text, "没有可用的RCON服务端,全给你关掉了(恼)", TextCompare:=False) <> 0 Then
                日志窗口.添加日志("启动所有已启用的MC服务端", 5)
                Dim 核心功能类 As 核心功能模块.核心功能类 = New 核心功能模块.核心功能类()
                核心功能类.启动MC服务器()
                MainForm.分任务进度条.Value = 0
            Else
                日志窗口.添加日志("没有可用的MC服务端,全给你关掉了(恼)", 2)
            End If
        End Sub

        Private Sub 冷却结束()
            倒计时冷却.Enabled = False
            启动MC服务端.Enabled = True
            启动MC服务端.Text = "启动已启用的MC服务端"
        End Sub
    End Class
End Namespace
