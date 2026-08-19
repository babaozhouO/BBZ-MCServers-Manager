Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    <DesignerGenerated>
    Partial Public Class MainForm
        Inherits Form
        Private _IntroductionLabel As Label
        Friend Property IntroductionLabel As Label
            Get
                Return _IntroductionLabel
            End Get
            Set(value As Label)
                _IntroductionLabel = value
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
        Private _LogsLabel As Label
        Friend Property LogsLabel As Label
            Get
                Return _LogsLabel
            End Get
            Set(value As Label)
                _LogsLabel = value
            End Set
        End Property
        Private _PictureBox As PictureBox
        Friend Property PictureBox As PictureBox
            Get
                Return _PictureBox
            End Get
            Set(value As PictureBox)
                _PictureBox = value
            End Set
        End Property
        Private _倒计时进度条 As ProgressBar
        Friend Property 倒计时进度条 As ProgressBar
            Get
                Return _倒计时进度条
            End Get
            Set(value As ProgressBar)
                _倒计时进度条 = value
            End Set
        End Property
        Private _倒计时数字显示 As Label
        Friend Property 倒计时数字显示 As Label
            Get
                Return _倒计时数字显示
            End Get
            Set(value As Label)
                _倒计时数字显示 = value
            End Set
        End Property
        Private _分任务进度条 As ProgressBar
        Friend Property 分任务进度条 As ProgressBar
            Get
                Return _分任务进度条
            End Get
            Set(value As ProgressBar)
                _分任务进度条 = value
            End Set
        End Property
        Private _执行中的分任务 As Label
        Friend Property 执行中的分任务 As Label
            Get
                Return _执行中的分任务
            End Get
            Set(value As Label)
                _执行中的分任务 = value
            End Set
        End Property
        Private _执行中的主任务 As Label
        Friend Property 执行中的主任务 As Label
            Get
                Return _执行中的主任务
            End Get
            Set(value As Label)
                _执行中的主任务 = value
            End Set
        End Property
        Private _主任务进度条 As ProgressBar
        Friend Property 主任务进度条 As ProgressBar
            Get
                Return _主任务进度条
            End Get
            Set(value As ProgressBar)
                _主任务进度条 = value
            End Set
        End Property

        Private components As IContainer

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("NowTimer")>
        Private _NowTimer As Timer

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ExitButton")>
        Private _ExitButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("TestsftpButton")>
        Private _TestsftpButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ServiceButton")>
        Private _ServiceButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("SettingsButton")>
        Private _SettingsButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("Button7z")>
        Private _Button7z As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("SftpButton")>
        Private _SftpButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ClearlogButton")>
        Private _ClearlogButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ButtonMC")>
        Private _ButtonMC As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("TestRCONButton")>
        Private _TestRCONButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("RunButton")>
        Private _RunButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("StopButton")>
        Private _StopButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ToolsButton")>
        Private _ToolsButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ButtonSightseeing")>
        Private _ButtonSightseeing As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ReturnButton")>
        Private _ReturnButton As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ChanegeImageTimer")>
        Private _ChanegeImageTimer As Timer

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("RunImmediately")>
        Private _RunImmediately As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("LogsFolder")>
        Private _LogsFolder As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("PicturesFolder")>
        Private _PicturesFolder As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("ConfigFolder")>
        Private _ConfigFolder As Button

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("LinkLabel1")>
        Private _LinkLabel1 As LinkLabel

        <CompilerGenerated>
        <DebuggerBrowsable(DebuggerBrowsableState.Never)>
        <AccessedThroughProperty("Timer5s")>
        Private _Timer5s As Timer

        Private ReadOnly 支持的文件格式 As String()

        Private 图片列表 As List(Of String)

        Private 图片序号 As Integer

        Private 下一次切换的时间点 As Date

        Private 服务 As 核心功能模块.间隔任务执行器

        Private Shared 当前MainForm实例 As MainForm

        Private 上次进度条值 As Integer

        Friend Overridable Property NowTimer As Timer
            <CompilerGenerated>
            Get
                Return _NowTimer
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf NowTimer_Tick
                Dim lNowTimer = _NowTimer
                If lNowTimer IsNot Nothing Then
                    RemoveHandler lNowTimer.Tick, value2
                End If
                _NowTimer = value
                lNowTimer = _NowTimer
                If lNowTimer IsNot Nothing Then
                    AddHandler lNowTimer.Tick, value2
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("IntroductionLabel")]
''' 	internal virtual System.Windows.Forms.Label IntroductionLabel
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("LogsLabel")]
''' 	internal virtual System.Windows.Forms.Label LogsLabel
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property ExitButton As Button
            <CompilerGenerated>
            Get
                Return _ExitButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ExitButton_Click
                Dim lExitButton = _ExitButton
                If lExitButton IsNot Nothing Then
                    RemoveHandler lExitButton.Click, value2
                End If
                _ExitButton = value
                lExitButton = _ExitButton
                If lExitButton IsNot Nothing Then
                    AddHandler lExitButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property TestsftpButton As Button
            <CompilerGenerated>
            Get
                Return _TestsftpButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf TestsftpButton_Click
                Dim lTestsftpButton = _TestsftpButton
                If lTestsftpButton IsNot Nothing Then
                    RemoveHandler lTestsftpButton.Click, value2
                End If
                _TestsftpButton = value
                lTestsftpButton = _TestsftpButton
                If lTestsftpButton IsNot Nothing Then
                    AddHandler lTestsftpButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ServiceButton As Button
            <CompilerGenerated>
            Get
                Return _ServiceButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ServiceButton_Click
                Dim lServiceButton = _ServiceButton
                If lServiceButton IsNot Nothing Then
                    RemoveHandler lServiceButton.Click, value2
                End If
                _ServiceButton = value
                lServiceButton = _ServiceButton
                If lServiceButton IsNot Nothing Then
                    AddHandler lServiceButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property SettingsButton As Button
            <CompilerGenerated>
            Get
                Return _SettingsButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf SettingsButton_Click
                Dim lSettingsButton = _SettingsButton
                If lSettingsButton IsNot Nothing Then
                    RemoveHandler lSettingsButton.Click, value2
                End If
                _SettingsButton = value
                lSettingsButton = _SettingsButton
                If lSettingsButton IsNot Nothing Then
                    AddHandler lSettingsButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property Button7z As Button
            <CompilerGenerated>
            Get
                Return _Button7z
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf Button7z_Click
                Dim lButton7z = _Button7z
                If lButton7z IsNot Nothing Then
                    RemoveHandler lButton7z.Click, value2
                End If
                _Button7z = value
                lButton7z = _Button7z
                If lButton7z IsNot Nothing Then
                    AddHandler lButton7z.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property SftpButton As Button
            <CompilerGenerated>
            Get
                Return _SftpButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf SftpButton_Click
                Dim lSftpButton = _SftpButton
                If lSftpButton IsNot Nothing Then
                    RemoveHandler lSftpButton.Click, value2
                End If
                _SftpButton = value
                lSftpButton = _SftpButton
                If lSftpButton IsNot Nothing Then
                    AddHandler lSftpButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ClearlogButton As Button
            <CompilerGenerated>
            Get
                Return _ClearlogButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ClearlogButton_Click
                Dim lClearlogButton = _ClearlogButton
                If lClearlogButton IsNot Nothing Then
                    RemoveHandler lClearlogButton.Click, value2
                End If
                _ClearlogButton = value
                lClearlogButton = _ClearlogButton
                If lClearlogButton IsNot Nothing Then
                    AddHandler lClearlogButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ButtonMC As Button
            <CompilerGenerated>
            Get
                Return _ButtonMC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ButtonMC_Click
                Dim lButtonMC = _ButtonMC
                If lButtonMC IsNot Nothing Then
                    RemoveHandler lButtonMC.Click, value2
                End If
                _ButtonMC = value
                lButtonMC = _ButtonMC
                If lButtonMC IsNot Nothing Then
                    AddHandler lButtonMC.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property TestRCONButton As Button
            <CompilerGenerated>
            Get
                Return _TestRCONButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf TestRCONButton_Click
                Dim lTestRCONButton = _TestRCONButton
                If lTestRCONButton IsNot Nothing Then
                    RemoveHandler lTestRCONButton.Click, value2
                End If
                _TestRCONButton = value
                lTestRCONButton = _TestRCONButton
                If lTestRCONButton IsNot Nothing Then
                    AddHandler lTestRCONButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property RunButton As Button
            <CompilerGenerated>
            Get
                Return _RunButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf RunButton_Click
                Dim lRunButton = _RunButton
                If lRunButton IsNot Nothing Then
                    RemoveHandler lRunButton.Click, value2
                End If
                _RunButton = value
                lRunButton = _RunButton
                If lRunButton IsNot Nothing Then
                    AddHandler lRunButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property StopButton As Button
            <CompilerGenerated>
            Get
                Return _StopButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf StopButton_Click
                Dim lStopButton = _StopButton
                If lStopButton IsNot Nothing Then
                    RemoveHandler lStopButton.Click, value2
                End If
                _StopButton = value
                lStopButton = _StopButton
                If lStopButton IsNot Nothing Then
                    AddHandler lStopButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ToolsButton As Button
            <CompilerGenerated>
            Get
                Return _ToolsButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ToolsButton_Click
                Dim lToolsButton = _ToolsButton
                If lToolsButton IsNot Nothing Then
                    RemoveHandler lToolsButton.Click, value2
                End If
                _ToolsButton = value
                lToolsButton = _ToolsButton
                If lToolsButton IsNot Nothing Then
                    AddHandler lToolsButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ButtonSightseeing As Button
            <CompilerGenerated>
            Get
                Return _ButtonSightseeing
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ButtonSightseeing_Click
                Dim lButtonSightseeing = _ButtonSightseeing
                If lButtonSightseeing IsNot Nothing Then
                    RemoveHandler lButtonSightseeing.Click, value2
                End If
                _ButtonSightseeing = value
                lButtonSightseeing = _ButtonSightseeing
                If lButtonSightseeing IsNot Nothing Then
                    AddHandler lButtonSightseeing.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ReturnButton As Button
            <CompilerGenerated>
            Get
                Return _ReturnButton
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ReturnButton_Click
                Dim lReturnButton = _ReturnButton
                If lReturnButton IsNot Nothing Then
                    RemoveHandler lReturnButton.Click, value2
                End If
                _ReturnButton = value
                lReturnButton = _ReturnButton
                If lReturnButton IsNot Nothing Then
                    AddHandler lReturnButton.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ChanegeImageTimer As Timer
            <CompilerGenerated>
            Get
                Return _ChanegeImageTimer
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Timer)
                Dim value2 As EventHandler = AddressOf 切换图片并重置倒计时
                Dim lChanegeImageTimer = _ChanegeImageTimer
                If lChanegeImageTimer IsNot Nothing Then
                    RemoveHandler lChanegeImageTimer.Tick, value2
                End If
                _ChanegeImageTimer = value
                lChanegeImageTimer = _ChanegeImageTimer
                If lChanegeImageTimer IsNot Nothing Then
                    AddHandler lChanegeImageTimer.Tick, value2
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("PictureBox")]
''' 	internal virtual System.Windows.Forms.PictureBox PictureBox
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("倒计时进度条")]
''' 	internal virtual System.Windows.Forms.ProgressBar 倒计时进度条
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("倒计时数字显示")]
''' 	internal virtual System.Windows.Forms.Label 倒计时数字显示
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property RunImmediately As Button
            <CompilerGenerated>
            Get
                Return _RunImmediately
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf RunImmediately_Click
                Dim lRunImmediately = _RunImmediately
                If lRunImmediately IsNot Nothing Then
                    RemoveHandler lRunImmediately.Click, value2
                End If
                _RunImmediately = value
                lRunImmediately = _RunImmediately
                If lRunImmediately IsNot Nothing Then
                    AddHandler lRunImmediately.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property LogsFolder As Button
            <CompilerGenerated>
            Get
                Return _LogsFolder
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf LogsPath_Click
                Dim lLogsFolder = _LogsFolder
                If lLogsFolder IsNot Nothing Then
                    RemoveHandler lLogsFolder.Click, value2
                End If
                _LogsFolder = value
                lLogsFolder = _LogsFolder
                If lLogsFolder IsNot Nothing Then
                    AddHandler lLogsFolder.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property PicturesFolder As Button
            <CompilerGenerated>
            Get
                Return _PicturesFolder
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf PicturesFolder_Click
                Dim lPicturesFolder = _PicturesFolder
                If lPicturesFolder IsNot Nothing Then
                    RemoveHandler lPicturesFolder.Click, value2
                End If
                _PicturesFolder = value
                lPicturesFolder = _PicturesFolder
                If lPicturesFolder IsNot Nothing Then
                    AddHandler lPicturesFolder.Click, value2
                End If
            End Set
        End Property

        Friend Overridable Property ConfigFolder As Button
            <CompilerGenerated>
            Get
                Return _ConfigFolder
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Button)
                Dim value2 As EventHandler = AddressOf ConfigFolder_Click
                Dim lConfigFolder = _ConfigFolder
                If lConfigFolder IsNot Nothing Then
                    RemoveHandler lConfigFolder.Click, value2
                End If
                _ConfigFolder = value
                lConfigFolder = _ConfigFolder
                If lConfigFolder IsNot Nothing Then
                    AddHandler lConfigFolder.Click, value2
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("主任务进度条")]
''' 	internal virtual System.Windows.Forms.ProgressBar 主任务进度条
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("分任务进度条")]
''' 	internal virtual System.Windows.Forms.ProgressBar 分任务进度条
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("执行中的分任务")]
''' 	internal virtual System.Windows.Forms.Label 执行中的分任务
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
''' 	[field: System.Runtime.CompilerServices.@AccessedThroughPropertyAttribute("执行中的主任务")]
''' 	internal virtual System.Windows.Forms.Label 执行中的主任务
''' 	{
''' 		get; [System.Runtime.CompilerServices.@MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
''' 		set;
''' 	}
''' 
''' 

        Friend Overridable Property LinkLabel1 As LinkLabel
            <CompilerGenerated>
            Get
                Return _LinkLabel1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As LinkLabel)
                Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf LinkLabel1_LinkClicked
                Dim linkLabel = _LinkLabel1
                If linkLabel IsNot Nothing Then
                    RemoveHandler linkLabel.LinkClicked, value2
                End If
                _LinkLabel1 = value
                linkLabel = _LinkLabel1
                If linkLabel IsNot Nothing Then
                    AddHandler linkLabel.LinkClicked, value2
                End If
            End Set
        End Property

        Friend Overridable Property Timer5s As Timer
            <CompilerGenerated>
            Get
                Return _Timer5s
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)>
            <CompilerGenerated>
            Set(value As Timer)
                Dim value2 As EventHandler = Sub(a0, a1) 上传文件时检测进度条()
                Dim lTimer5s = _Timer5s
                If lTimer5s IsNot Nothing Then
                    RemoveHandler lTimer5s.Tick, value2
                End If
                _Timer5s = value
                lTimer5s = _Timer5s
                If lTimer5s IsNot Nothing Then
                    AddHandler lTimer5s.Tick, value2
                End If
            End Set
        End Property

        Public Sub New()
            ' 只在首次创建时记录（UI 线程实例），避免后台线程的 My.Forms.MainForm 默认实例覆盖
            If 当前MainForm实例 Is Nothing Then
                当前MainForm实例 = Me
            End If
            AddHandler Load, AddressOf 主窗口_Load
            AddHandler Shown, AddressOf 主窗口_Shown
            AddHandler Activated, AddressOf MainForm_Activated
            AddHandler Closed, AddressOf MainForm_Closed
            支持的文件格式 = New String(2) {".jpg", ".png", ".bmp"}
            图片列表 = New List(Of String)()
            图片序号 = 0
            上次进度条值 = 0
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
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(MainForm))
            NowTimer = New Timer(components)
            Me.IntroductionLabel = New Label()
            Me.LogsLabel = New Label()
            ExitButton = New Button()
            TestsftpButton = New Button()
            ServiceButton = New Button()
            SettingsButton = New Button()
            Button7z = New Button()
            SftpButton = New Button()
            ClearlogButton = New Button()
            ButtonMC = New Button()
            TestRCONButton = New Button()
            RunButton = New Button()
            StopButton = New Button()
            ToolsButton = New Button()
            ButtonSightseeing = New Button()
            ReturnButton = New Button()
            ChanegeImageTimer = New Timer(components)
            Me.PictureBox = New PictureBox()
            Me.倒计时进度条 = New ProgressBar()
            Me.倒计时数字显示 = New Label()
            RunImmediately = New Button()
            LogsFolder = New Button()
            PicturesFolder = New Button()
            ConfigFolder = New Button()
            Me.主任务进度条 = New ProgressBar()
            Me.Label1 = New Label()
            Me.Label2 = New Label()
            Me.分任务进度条 = New ProgressBar()
            Me.执行中的分任务 = New Label()
            Me.执行中的主任务 = New Label()
            LinkLabel1 = New LinkLabel()
            Timer5s = New Timer(components)
            CType(Me.PictureBox, ISupportInitialize).BeginInit()
            SuspendLayout()
            NowTimer.Enabled = True
            NowTimer.Interval = 1000
            Me.IntroductionLabel.AutoSize = True
            Me.IntroductionLabel.BackColor = Color.Transparent
            Me.IntroductionLabel.ForeColor = Color.Cyan
            Me.IntroductionLabel.Location = New Point(30, 446)
            Me.IntroductionLabel.Name = "IntroductionLabel"
            Me.IntroductionLabel.Size = New Size(557, 38)
            Me.IntroductionLabel.TabIndex = 1
            Me.IntroductionLabel.Text = "程序名称:八宝粥的多MC服务端管理面板             作者:八宝粥" & vbCrLf & "程序功能:可定时自动(关闭MC服务端)增量备份文件并发送至远程sftp服务端(并开启MC服务端)"
            Me.LogsLabel.AutoSize = True
            Me.LogsLabel.BackColor = Color.Transparent
            Me.LogsLabel.ForeColor = Color.Cyan
            Me.LogsLabel.Location = New Point(30, 9)
            Me.LogsLabel.Name = "LogsLabel"
            Me.LogsLabel.Size = New Size(35, 19)
            Me.LogsLabel.TabIndex = 2
            Me.LogsLabel.Text = "日志"
            ExitButton.BackColor = SystemColors.Control
            ExitButton.Location = New Point(710, 330)
            ExitButton.Name = "ExitButton"
            ExitButton.Size = New Size(100, 50)
            ExitButton.TabIndex = 3
            ExitButton.TabStop = False
            ExitButton.Text = "退出"
            ExitButton.UseVisualStyleBackColor = False
            TestsftpButton.Location = New Point(710, 90)
            TestsftpButton.Name = "TestsftpButton"
            TestsftpButton.Size = New Size(100, 50)
            TestsftpButton.TabIndex = 4
            TestsftpButton.Text = "测试sftp" & vbCrLf & "服务器连接"
            TestsftpButton.UseVisualStyleBackColor = True
            ServiceButton.BackColor = SystemColors.Control
            ServiceButton.BackgroundImageLayout = ImageLayout.None
            ServiceButton.Location = New Point(830, 30)
            ServiceButton.Name = "ServiceButton"
            ServiceButton.Size = New Size(100, 50)
            ServiceButton.TabIndex = 5
            ServiceButton.Text = "安装/卸载" & vbCrLf & "系统服务"
            ServiceButton.UseVisualStyleBackColor = False
            SettingsButton.Location = New Point(830, 90)
            SettingsButton.Name = "SettingsButton"
            SettingsButton.Size = New Size(100, 50)
            SettingsButton.TabIndex = 6
            SettingsButton.Text = "主程序" & vbCrLf & "配置界面"
            SettingsButton.UseVisualStyleBackColor = True
            Button7z.Location = New Point(830, 150)
            Button7z.Name = "Button7z"
            Button7z.Size = New Size(100, 50)
            Button7z.TabIndex = 7
            Button7z.Text = "7-Zip" & vbCrLf & "配置界面"
            Button7z.UseVisualStyleBackColor = True
            SftpButton.Location = New Point(830, 210)
            SftpButton.Name = "SftpButton"
            SftpButton.Size = New Size(100, 50)
            SftpButton.TabIndex = 8
            SftpButton.Text = "Sftp(cli)" & vbCrLf & "配置界面"
            SftpButton.UseVisualStyleBackColor = True
            ClearlogButton.Location = New Point(710, 270)
            ClearlogButton.Name = "ClearlogButton"
            ClearlogButton.Size = New Size(100, 50)
            ClearlogButton.TabIndex = 9
            ClearlogButton.Text = "清除日志"
            ClearlogButton.UseVisualStyleBackColor = True
            ButtonMC.Location = New Point(830, 270)
            ButtonMC.Name = "ButtonMC"
            ButtonMC.Size = New Size(100, 50)
            ButtonMC.TabIndex = 11
            ButtonMC.Text = "MC服务端" & vbCrLf & "配置界面"
            ButtonMC.UseVisualStyleBackColor = True
            TestRCONButton.BackColor = SystemColors.Control
            TestRCONButton.Location = New Point(710, 30)
            TestRCONButton.Name = "TestRCONButton"
            TestRCONButton.Size = New Size(100, 50)
            TestRCONButton.TabIndex = 12
            TestRCONButton.Text = "测试RCON" & vbCrLf & "服务器连接"
            TestRCONButton.UseVisualStyleBackColor = False
            RunButton.Location = New Point(710, 150)
            RunButton.Name = "RunButton"
            RunButton.Size = New Size(50, 50)
            RunButton.TabIndex = 13
            RunButton.Text = "启动"
            RunButton.UseVisualStyleBackColor = True
            StopButton.Enabled = False
            StopButton.Location = New Point(710, 210)
            StopButton.Name = "StopButton"
            StopButton.Size = New Size(100, 50)
            StopButton.TabIndex = 14
            StopButton.Text = "停止"
            StopButton.UseVisualStyleBackColor = True
            ToolsButton.Location = New Point(830, 330)
            ToolsButton.Name = "ToolsButton"
            ToolsButton.Size = New Size(100, 50)
            ToolsButton.TabIndex = 15
            ToolsButton.Text = "没用的" & vbCrLf & "小工具"
            ToolsButton.UseVisualStyleBackColor = True
            ButtonSightseeing.Location = New Point(710, 390)
            ButtonSightseeing.Name = "ButtonSightseeing"
            ButtonSightseeing.Size = New Size(220, 80)
            ButtonSightseeing.TabIndex = 17
            ButtonSightseeing.Text = "你想看风景嘛"
            ButtonSightseeing.UseVisualStyleBackColor = True
            ReturnButton.Font = New Font("微软雅黑", 5.25F, FontStyle.Bold, GraphicsUnit.Point, 134)
            ReturnButton.Location = New Point(922, 476)
            ReturnButton.Name = "ReturnButton"
            ReturnButton.Size = New Size(30, 30)
            ReturnButton.TabIndex = 18
            ReturnButton.Text = "不看了"
            ReturnButton.UseVisualStyleBackColor = True
            ReturnButton.Visible = False
            ChanegeImageTimer.Enabled = True
            ChanegeImageTimer.Interval = 60000
            Me.PictureBox.BackgroundImageLayout = ImageLayout.Stretch
            Me.PictureBox.Dock = DockStyle.Fill
            Me.PictureBox.ErrorImage = Nothing
            Me.PictureBox.InitialImage = Nothing
            Me.PictureBox.Location = New Point(0, 0)
            Me.PictureBox.Name = "PictureBox"
            Me.PictureBox.Size = New Size(964, 610)
            Me.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            Me.PictureBox.TabIndex = 19
            Me.PictureBox.TabStop = False
            Me.倒计时进度条.Location = New Point(736, 486)
            Me.倒计时进度条.Maximum = 60
            Me.倒计时进度条.Name = "倒计时进度条"
            Me.倒计时进度条.Size = New Size(180, 20)
            Me.倒计时进度条.Step = 1
            Me.倒计时进度条.Style = ProgressBarStyle.Continuous
            Me.倒计时进度条.TabIndex = 21
            Me.倒计时数字显示.AutoSize = True
            Me.倒计时数字显示.BackColor = Color.Transparent
            Me.倒计时数字显示.ForeColor = Color.Cyan
            Me.倒计时数字显示.Location = New Point(603, 487)
            Me.倒计时数字显示.Name = "倒计时数字显示"
            Me.倒计时数字显示.Size = New Size(127, 19)
            Me.倒计时数字显示.TabIndex = 22
            Me.倒计时数字显示.Text = "N/A秒后切换下一张"
            RunImmediately.Location = New Point(760, 150)
            RunImmediately.Name = "RunImmediately"
            RunImmediately.Size = New Size(50, 50)
            RunImmediately.TabIndex = 23
            RunImmediately.Text = "运行一次"
            RunImmediately.UseVisualStyleBackColor = True
            LogsFolder.Location = New Point(936, 30)
            LogsFolder.Name = "LogsFolder"
            LogsFolder.Size = New Size(28, 110)
            LogsFolder.TabIndex = 29
            LogsFolder.Text = "日志文件夹"
            LogsFolder.UseVisualStyleBackColor = True
            PicturesFolder.Location = New Point(936, 298)
            PicturesFolder.Name = "PicturesFolder"
            PicturesFolder.Size = New Size(28, 145)
            PicturesFolder.TabIndex = 28
            PicturesFolder.Text = "背景图片文件夹"
            PicturesFolder.UseVisualStyleBackColor = True
            ConfigFolder.Location = New Point(936, 146)
            ConfigFolder.Name = "ConfigFolder"
            ConfigFolder.Size = New Size(28, 146)
            ConfigFolder.TabIndex = 27
            ConfigFolder.Text = "配置文件文件夹"
            ConfigFolder.UseVisualStyleBackColor = True
            Me.主任务进度条.Location = New Point(12, 526)
            Me.主任务进度条.Name = "主任务进度条"
            Me.主任务进度条.Size = New Size(940, 22)
            Me.主任务进度条.Style = ProgressBarStyle.Continuous
            Me.主任务进度条.TabIndex = 30
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = Color.Transparent
            Me.Label1.ForeColor = Color.Cyan
            Me.Label1.Location = New Point(12, 504)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(87, 19)
            Me.Label1.TabIndex = 31
            Me.Label1.Text = "主任务进度："
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = Color.Transparent
            Me.Label2.ForeColor = Color.Cyan
            Me.Label2.Location = New Point(12, 551)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(87, 19)
            Me.Label2.TabIndex = 33
            Me.Label2.Text = "分任务进度："
            Me.分任务进度条.Location = New Point(12, 573)
            Me.分任务进度条.Name = "分任务进度条"
            Me.分任务进度条.Size = New Size(940, 22)
            Me.分任务进度条.Style = ProgressBarStyle.Continuous
            Me.分任务进度条.TabIndex = 32
            Me.执行中的分任务.AutoSize = True
            Me.执行中的分任务.BackColor = Color.Transparent
            Me.执行中的分任务.ForeColor = Color.Cyan
            Me.执行中的分任务.Location = New Point(95, 551)
            Me.执行中的分任务.Name = "执行中的分任务"
            Me.执行中的分任务.Size = New Size(48, 19)
            Me.执行中的分任务.TabIndex = 35
            Me.执行中的分任务.Text = "分任务"
            Me.执行中的主任务.AutoSize = True
            Me.执行中的主任务.BackColor = Color.Transparent
            Me.执行中的主任务.ForeColor = Color.Cyan
            Me.执行中的主任务.Location = New Point(95, 504)
            Me.执行中的主任务.Name = "执行中的主任务"
            Me.执行中的主任务.Size = New Size(48, 19)
            Me.执行中的主任务.TabIndex = 34
            Me.执行中的主任务.Text = "主任务"
            LinkLabel1.ActiveLinkColor = Color.Cyan
            LinkLabel1.AutoSize = True
            LinkLabel1.BackColor = Color.Transparent
            LinkLabel1.Cursor = Cursors.Hand
            LinkLabel1.LinkColor = Color.SpringGreen
            LinkLabel1.Location = New Point(30, 484)
            LinkLabel1.Name = "LinkLabel1"
            LinkLabel1.Size = New Size(502, 19)
            LinkLabel1.TabIndex = 36
            LinkLabel1.TabStop = True
            LinkLabel1.Text = "Github仓库链接:https://github.com/babaozhouO/BBZ-MCServers-Manager"
            LinkLabel1.VisitedLinkColor = Color.Cyan
            Timer5s.Interval = 5000
            AutoScaleMode = AutoScaleMode.None
            AutoScroll = True
            AutoSize = True
            BackgroundImageLayout = ImageLayout.Stretch
            ClientSize = New Size(964, 610)
            Controls.Add(LinkLabel1)
            Controls.Add(Me.执行中的分任务)
            Controls.Add(Me.执行中的主任务)
            Controls.Add(Me.Label2)
            Controls.Add(Me.分任务进度条)
            Controls.Add(Me.Label1)
            Controls.Add(Me.主任务进度条)
            Controls.Add(LogsFolder)
            Controls.Add(PicturesFolder)
            Controls.Add(ConfigFolder)
            Controls.Add(RunImmediately)
            Controls.Add(Me.倒计时数字显示)
            Controls.Add(Me.倒计时进度条)
            Controls.Add(Me.IntroductionLabel)
            Controls.Add(ReturnButton)
            Controls.Add(ButtonSightseeing)
            Controls.Add(ToolsButton)
            Controls.Add(StopButton)
            Controls.Add(RunButton)
            Controls.Add(TestRCONButton)
            Controls.Add(ButtonMC)
            Controls.Add(ClearlogButton)
            Controls.Add(SftpButton)
            Controls.Add(Button7z)
            Controls.Add(SettingsButton)
            Controls.Add(ServiceButton)
            Controls.Add(TestsftpButton)
            Controls.Add(ExitButton)
            Controls.Add(Me.LogsLabel)
            Controls.Add(Me.PictureBox)
            DoubleBuffered = True
            Font = New Font("微软雅黑", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134)
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
            MaximizeBox = False
            MaximumSize = New Size(980, 700)
            MinimumSize = New Size(980, 550)
            Name = "MainForm"
            StartPosition = FormStartPosition.CenterScreen
            Text = "八宝粥的多MC服务端管理面板"
            CType(Me.PictureBox, ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Private Sub 设置窗体所有者()
            ' 日志窗口设为 owned（跟随主窗口、显示在主窗口之上、但可被其它窗口挡住），与 C# 原版一致
            日志窗口.Owner = Me
            SevenZipSettingsForm.Owner = Me
            MainSettingsForm.Owner = Me
            MCServerSettingsForm.Owner = Me
            ServiceSettingsForm.Owner = Me
            SftpSettingsForm.Owner = Me
            UselessToolsForm.Owner = Me
        End Sub

        Private Sub 主窗口_Load(sender As Object, e As EventArgs)
            配置文件操作模块.程序版本 = Not Directory.Exists(Path.Combine(Application.StartupPath, "配置文件"))
            If 配置文件操作模块.程序版本 Then
                配置文件操作模块.程序数据目录 = 配置文件操作模块.MSI版本目录
                配置文件操作模块.版本名称 = "MSI自动安装版"
            Else
                配置文件操作模块.程序数据目录 = 配置文件操作模块.散文件版本目录
                配置文件操作模块.版本名称 = "零散文件版打包版"
            End If
            配置文件操作模块.图片目录 = Path.Combine(配置文件操作模块.程序数据目录, "背景图片")
            配置文件操作模块.程序路径 = Path.Combine(配置文件操作模块.程序数据目录, "资源", "7z.exe")
            配置文件操作模块.日志文件夹 = Path.Combine(配置文件操作模块.程序数据目录, "日志")
            配置文件操作模块.配置文件目录 = Path.Combine(配置文件操作模块.程序数据目录, "配置文件")
            Call 日志窗口.Show()
            设置窗体所有者()
            Me.IntroductionLabel.Parent = Me.PictureBox
            Me.LogsLabel.Parent = Me.PictureBox
            LinkLabel1.Parent = Me.PictureBox
            Me.倒计时数字显示.Parent = Me.PictureBox
            Me.Label1.Parent = Me.PictureBox
            Me.Label2.Parent = Me.PictureBox
            Me.执行中的主任务.Parent = Me.PictureBox
            Me.执行中的分任务.Parent = Me.PictureBox
            AddHandler FormClosing, AddressOf 窗体关闭确认
            If Directory.Exists(配置文件操作模块.图片目录) Then
                Dim files = Directory.GetFiles(配置文件操作模块.图片目录)
                图片列表 = files.Where(Function(file) 支持的文件格式.Contains(Path.GetExtension(file).ToLower())).ToList()
            End If
            If 图片列表.Count > 0 Then
                加载图片(图片列表(图片序号))
                下一次切换的时间点 = Date.Now.AddMinutes(1.0)
                更新图片切换倒计时显示()
            Else
                日志窗口.添加日志("未找到图片文件！", 2)
            End If
        End Sub

        Private Sub 主窗口_Shown(sender As Object, e As EventArgs)
            日志窗口.更新停靠位置(Me)
            Call 日志窗口.测试日志()
            Call 日志窗口.日志输出软件信息()
            Call 日志窗口.日志输出主程序配置()
            Call 日志窗口.日志输出MC服务端配置()
            Call 日志窗口.日志输出SFTP配置()
            Call 日志窗口.日志输出7zip配置()
            日志窗口.添加日志("", 7)
            If Environment.GetCommandLineArgs().Any(Function(a) a.ToLower() = "--selftest") Then
                ' 异步改造：自测放到后台线程执行
                System.Threading.Tasks.Task.Run(Sub() 自测功能())
            ElseIf Environment.GetCommandLineArgs().Any(Function(a) a.ToLower() = "--selftest-backup") Then
                ' 异步改造：自测备份放到后台线程执行
                System.Threading.Tasks.Task.Run(Sub() 自测备份功能())
            Else
                日志窗口.添加日志("已启用异步后台执行：耗时操作不再阻塞UI，已移除高CPU的DoEvents轮询刷新", 3)
            End If
        End Sub

        Private Sub 自测功能()
            Try
                日志窗口.添加日志("", 7)
                日志窗口.添加日志("========== 自测开始 ==========", 6)
                ' 1. 测试 RCON 连接与指令
                日志窗口.添加日志("【自测】测试RCON连接与指令", 5)
                Dim rcon As New RCON客户端(1)
                rcon.连接RCON(配置文件操作模块.RCON1地址, CInt(配置文件操作模块.RCON1端口), 配置文件操作模块.RCON1密码)
                rcon.发送指令并返回响应("list")
                rcon.软断开()
                ' 2. 测试 SFTP 上传与删除
                日志窗口.添加日志("【自测】测试SFTP上传与删除", 5)
                Call Sftp服务器测试器()
                日志窗口.添加日志("========== 自测完成 ==========", 6)
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                日志窗口.添加日志("自测发生异常: " & ex.ToString(), 2)
                Call ProjectData.ClearProjectError()
            Finally
                配置文件操作模块.备份操作进行状态 = False
            End Try
        End Sub

        Private Sub 自测备份功能()
            Try
                日志窗口.添加日志("", 7)
                日志窗口.添加日志("========== 自测：完整备份流程开始 ==========", 6)
                Dim 核心功能类 As New 核心功能模块.核心功能类()
                核心功能类.核心功能方法()
                日志窗口.添加日志("========== 自测：完整备份流程结束 ==========", 6)
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                日志窗口.添加日志("自测备份发生异常: " & ex.ToString(), 2)
                Call ProjectData.ClearProjectError()
            Finally
                配置文件操作模块.备份操作进行状态 = False
            End Try
        End Sub

        Private Sub MainForm_Activated(sender As Object, e As EventArgs)
            日志窗口.更新停靠位置(Me)
        End Sub

        Private Sub MainForm_Closed(sender As Object, e As EventArgs)
            NowTimer.Stop()
            ChanegeImageTimer.Stop()
            Me.PictureBox.Image?.Dispose()
            If 服务 IsNot Nothing Then
                服务.停止任务()
            End If
            ' 日志窗口为 owned（Owner=主窗口），主窗口关闭时会自动关闭
        End Sub

        Private Sub 窗体关闭确认(sender As Object, e As FormClosingEventArgs)
            If e.CloseReason = CloseReason.UserClosing Then
                Dim dialogResult = MessageBox.Show("确定退出？", "你真的要关闭八宝粥备份吗", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialogResult = DialogResult.No Then
                    e.Cancel = True
                End If
            End If
        End Sub

        Private Sub ServiceButton_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("打开安装/卸载系统服务窗口", 5)
            设置窗体所有者()
            Call ServiceSettingsForm.Show()
            日志窗口.更新停靠位置(ServiceSettingsForm)
            Call ServiceSettingsForm.Activate()
        End Sub

        Private Sub SettingsButton_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("打开主程序配置界面", 5)
            设置窗体所有者()
            Call MainSettingsForm.Show()
            日志窗口.更新停靠位置(MainSettingsForm)
            Call MainSettingsForm.Activate()
        End Sub

        Private Sub Button7z_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("打开7z压缩程序配置界面", 5)
            设置窗体所有者()
            Call SevenZipSettingsForm.Show()
            日志窗口.更新停靠位置(SevenZipSettingsForm)
            Call SevenZipSettingsForm.Activate()
        End Sub

        Private Sub SftpButton_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("打开内置sftp客户端配置界面", 5)
            设置窗体所有者()
            Call SftpSettingsForm.Show()
            日志窗口.更新停靠位置(SftpSettingsForm)
            Call SftpSettingsForm.Activate()
        End Sub

        Private Sub ButtonMC_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("打开MC服务器配置界面", 5)
            设置窗体所有者()
            Call MCServerSettingsForm.Show()
            日志窗口.更新停靠位置(MCServerSettingsForm)
            Call MCServerSettingsForm.Activate()
        End Sub

        Private Sub ToolsButton_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("打开没用的小工具界面", 5)
            设置窗体所有者()
            Call UselessToolsForm.Show()
            日志窗口.更新停靠位置(UselessToolsForm)
            Call UselessToolsForm.Activate()
        End Sub

        Public Sub ButtonSightseeing_Click(sender As Object, e As EventArgs)
            配置文件操作模块.日志窗口隐藏状态 = True
            Me.IntroductionLabel.Visible = False
            日志窗口.Visible = False
            ExitButton.Visible = False
            ClearlogButton.Visible = False
            ServiceButton.Visible = False
            SettingsButton.Visible = False
            Button7z.Visible = False
            SftpButton.Visible = False
            TestsftpButton.Visible = False
            TestRCONButton.Visible = False
            RunButton.Visible = False
            ButtonSightseeing.Visible = False
            ServiceButton.Visible = False
            ToolsButton.Visible = False
            StopButton.Visible = False
            Me.LogsLabel.Visible = False
            ButtonMC.Visible = False
            ReturnButton.Visible = True
            RunImmediately.Visible = False
            LogsFolder.Visible = False
            ConfigFolder.Visible = False
            PicturesFolder.Visible = False
        End Sub

        Public Shared Sub 看风景模式()
            配置文件操作模块.日志窗口隐藏状态 = True
            MainForm.IntroductionLabel.Visible = False
            日志窗口.Visible = False
            MainForm.ExitButton.Visible = False
            MainForm.ClearlogButton.Visible = False
            MainForm.ServiceButton.Visible = False
            MainForm.SettingsButton.Visible = False
            MainForm.Button7z.Visible = False
            MainForm.SftpButton.Visible = False
            MainForm.TestsftpButton.Visible = False
            MainForm.TestRCONButton.Visible = False
            MainForm.RunButton.Visible = False
            MainForm.ButtonSightseeing.Visible = False
            MainForm.ServiceButton.Visible = False
            MainForm.ToolsButton.Visible = False
            MainForm.StopButton.Visible = False
            MainForm.LogsLabel.Visible = False
            MainForm.ButtonMC.Visible = False
            MainForm.ReturnButton.Visible = True
            MainForm.RunImmediately.Visible = False
            MainForm.LogsFolder.Visible = False
            MainForm.ConfigFolder.Visible = False
            MainForm.PicturesFolder.Visible = False
        End Sub

        Private Sub ReturnButton_Click(sender As Object, e As EventArgs)
            配置文件操作模块.日志窗口隐藏状态 = False
            Me.IntroductionLabel.Visible = True
            日志窗口.Visible = True
            ExitButton.Visible = True
            ClearlogButton.Visible = True
            ServiceButton.Visible = True
            SettingsButton.Visible = True
            Button7z.Visible = True
            SftpButton.Visible = True
            TestsftpButton.Visible = True
            TestRCONButton.Visible = True
            RunButton.Visible = True
            ButtonSightseeing.Visible = True
            RunButton.Visible = True
            ServiceButton.Visible = True
            ToolsButton.Visible = True
            StopButton.Visible = True
            Me.LogsLabel.Visible = True
            ButtonMC.Visible = True
            ReturnButton.Visible = False
            RunImmediately.Visible = True
            LogsFolder.Visible = True
            ConfigFolder.Visible = True
            PicturesFolder.Visible = True
        End Sub

        Private Sub TestRCONButton_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("", 7)
            日志窗口.添加日志("测试RCON服务器连接", 5)
            ' 异步改造：耗时测试放到后台线程，不阻塞 UI
            System.Threading.Tasks.Task.Run(Sub() RCON服务器测试器())
        End Sub

        Private Sub TestsftpButton_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("", 7)
            日志窗口.添加日志("测试sftp服务器连接", 5)
            ' 异步改造：耗时测试放到后台线程，不阻塞 UI
            System.Threading.Tasks.Task.Run(Sub() Sftp服务器测试器())
        End Sub

        Private Sub RunButton_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("启动服务", 5)
            日志窗口.添加日志("正在读取配置文件", 6)
            Call 日志窗口.日志输出主程序配置()
            Call 日志窗口.日志输出MC服务端配置()
            Call 日志窗口.日志输出7zip配置()
            Call 日志窗口.日志输出SFTP配置()
            日志窗口.添加日志("", 7)
            日志窗口.添加日志("尚未经过严格测试，谨慎使用", 1)
            If String.IsNullOrEmpty(配置文件操作模块.间隔天数) Then
                配置文件操作模块.间隔天数 = "1"
            End If
            服务 = New 核心功能模块.间隔任务执行器()
            日志窗口.添加日志("[提示]:在等待执行时可更改配置(最好不要踩点修改)", 0)
            RunButton.Enabled = False
            StopButton.Enabled = True
        End Sub

        Private Sub RunImmediately_Click(sender As Object, e As EventArgs)
            ' 异步改造：完整备份流程放到后台线程执行，不阻塞 UI
            System.Threading.Tasks.Task.Run(Sub()
                Dim 核心功能类 As 核心功能模块.核心功能类 = New 核心功能模块.核心功能类()
                核心功能类.核心功能方法()
            End Sub)
        End Sub

        Private Sub StopButton_Click(sender As Object, e As EventArgs)
            日志窗口.添加日志("停止服务", 5)
            服务.停止任务()
            日志窗口.添加日志("已停止服务", 3)
            Me.主任务进度条.Maximum = 100
            Me.主任务进度条.Value = 0
            Me.执行中的主任务.Text = "无"
            RunButton.Enabled = True
            StopButton.Enabled = False
        End Sub

        Private Sub ClearlogButton_Click(sender As Object, e As EventArgs)
            Call 日志窗口.LogsRichTextBox.Clear()
            日志窗口.添加日志("清空日志", 5)
        End Sub

        Private Sub ExitButton_Click(sender As Object, e As EventArgs)
            Close()
        End Sub

        Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
            LinkLabel1.LinkVisited = True
            Try
                Dim startInfo As ProcessStartInfo = New ProcessStartInfo With {
        .FileName = "https://github.com/babaozhouO/BBZ-MCServers-Manager",
        .UseShellExecute = True
    }
                Process.Start(startInfo)
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim ex2 = ex
                日志窗口.添加日志("无法打开项目网址", 2)
                Call ProjectData.ClearProjectError()
            End Try
        End Sub

        Private Sub LogsPath_Click(sender As Object, e As EventArgs)
            Process.Start("explorer.exe", Path.Combine(配置文件操作模块.程序数据目录, "日志"))
        End Sub

        Private Sub ConfigFolder_Click(sender As Object, e As EventArgs)
            Process.Start("explorer.exe", Path.Combine(配置文件操作模块.程序数据目录, "配置文件"))
        End Sub

        Private Sub PicturesFolder_Click(sender As Object, e As EventArgs)
            Process.Start("explorer.exe", Path.Combine(配置文件操作模块.程序数据目录, "背景图片"))
        End Sub

        Private Sub 上传文件时检测进度条()
            If Me.执行中的分任务.Text.Contains("上传文件中") Then
                Dim value As Integer = Me.分任务进度条.Value
                If value - 上次进度条值 = 0 Then
                    日志窗口.添加日志("疑似Sftp客户端上传进度无变化，请检查网络连接", 1)
                    日志窗口.添加日志("也或许是文件过大,每秒传输数据量小于进度条1%所代表的数据量", 0)
                End If
                上次进度条值 = value
            End If
        End Sub

        Public Sub 更新压缩进度(百分比 As Integer)
            Me.分任务进度条.Value = Math.Min(百分比, 100)
        End Sub

        Public Shared Sub 备份运行时更改控件状态(运行状态 As Boolean)
            If 运行状态 Then
                MainForm.ExitButton.Enabled = False
                MainForm.TestRCONButton.Enabled = False
                MainForm.TestsftpButton.Enabled = False
                MainForm.ServiceButton.Enabled = False
                MainForm.SettingsButton.Enabled = False
                MainForm.Button7z.Enabled = False
                MainForm.SftpButton.Enabled = False
                配置文件操作模块.服务运行状态 = False
                If MainForm.服务 IsNot Nothing AndAlso MainForm.服务.获取计时器状态() Then
                    Call MainForm.服务.停止计时()
                    日志窗口.添加日志("已停止备份计划计时", 0)
                End If
                MainForm.StopButton.Enabled = False
                MainForm.ToolsButton.Enabled = False
                MainForm.ButtonMC.Enabled = False
                MainForm.RunImmediately.Enabled = False
                MainForm.更新标签("主任务", "无")
                MainForm.更新进度条("主任务", 0)
                MainForm.更新标签("主任务", "无")
                MainForm.更新进度条("主任务", 0)
                Return
            End If
            MainForm.ExitButton.Enabled = True
            MainForm.TestRCONButton.Enabled = True
            MainForm.TestsftpButton.Enabled = True
            MainForm.ServiceButton.Enabled = True
            MainForm.SettingsButton.Enabled = True
            MainForm.Button7z.Enabled = True
            MainForm.SftpButton.Enabled = True
            If 配置文件操作模块.服务运行状态 Then
                If MainForm.服务 IsNot Nothing Then
                    Call MainForm.服务.开始计时()
                    MainForm.StopButton.Enabled = True
                    日志窗口.添加日志("已恢复备份计划计时", 0)
                End If
            Else
                MainForm.StopButton.Enabled = False
            End If
            MainForm.ToolsButton.Enabled = True
            MainForm.ButtonMC.Enabled = True
            MainForm.RunImmediately.Enabled = True
            MainForm.更新标签("主任务", "无")
            MainForm.更新进度条("主任务", 0)
            MainForm.更新标签("主任务", "无")
            MainForm.更新进度条("主任务", 0)
        End Sub

        Private Sub RCON服务器测试器()
            Dim 服务运行状态 = 配置文件操作模块.服务运行状态
            配置文件操作模块.服务运行状态 = False
            MainForm.更新标签("主任务", "测试MC服务端的RCON连接")
            MainForm.更新进度条("主任务", 0)
            Dim list As List(Of Integer) = New List(Of Integer)()
            If 配置文件操作模块.是否控制MC服务端1 Then
                日志窗口.添加日志("", 7)
                list.Add(1)
                处理单个RCON服务端.处理单个RCON服务端_发送指令(配置文件操作模块.RCON1地址, Conversions.ToInteger(配置文件操作模块.RCON1端口), 配置文件操作模块.RCON1密码, "list", "1")
            End If
            MainForm.更新进度条("主任务", 0, 1)
            If 配置文件操作模块.是否控制MC服务端2 Then
                日志窗口.添加日志("", 7)
                list.Add(2)
                处理单个RCON服务端.处理单个RCON服务端_发送指令(配置文件操作模块.RCON2地址, Conversions.ToInteger(配置文件操作模块.RCON2端口), 配置文件操作模块.RCON2密码, "list", "2")
            End If
            MainForm.更新进度条("主任务", 0, 1)
            If 配置文件操作模块.是否控制MC服务端3 Then
                日志窗口.添加日志("", 7)
                list.Add(3)
                处理单个RCON服务端.处理单个RCON服务端_发送指令(配置文件操作模块.RCON3地址, Conversions.ToInteger(配置文件操作模块.RCON3端口), 配置文件操作模块.RCON3密码, "list", "3")
            End If
            MainForm.更新进度条("主任务", 0, 1)
            If 配置文件操作模块.是否控制MC服务端4 Then
                日志窗口.添加日志("", 7)
                list.Add(4)
                处理单个RCON服务端.处理单个RCON服务端_发送指令(配置文件操作模块.RCON4地址, Conversions.ToInteger(配置文件操作模块.RCON4端口), 配置文件操作模块.RCON4密码, "list", "4")
            End If
            MainForm.更新进度条("主任务", 0, 1)
            If 配置文件操作模块.是否控制MC服务端5 Then
                日志窗口.添加日志("", 7)
                list.Add(5)
                处理单个RCON服务端.处理单个RCON服务端_发送指令(配置文件操作模块.RCON5地址, Conversions.ToInteger(配置文件操作模块.RCON5端口), 配置文件操作模块.RCON5密码, "list", "5")
            End If
            MainForm.更新进度条("主任务", 0, 1)
            If 配置文件操作模块.是否控制MC服务端6 Then
                日志窗口.添加日志("", 7)
                list.Add(6)
                处理单个RCON服务端.处理单个RCON服务端_发送指令(配置文件操作模块.RCON6地址, Conversions.ToInteger(配置文件操作模块.RCON6端口), 配置文件操作模块.RCON6密码, "list", "6")
            End If
            MainForm.更新进度条("主任务", 0, 1)
            If 配置文件操作模块.是否控制MC服务端7 Then
                日志窗口.添加日志("", 7)
                list.Add(7)
                处理单个RCON服务端.处理单个RCON服务端_发送指令(配置文件操作模块.RCON7地址, Conversions.ToInteger(配置文件操作模块.RCON7端口), 配置文件操作模块.RCON7密码, "list", "7")
            End If
            MainForm.更新进度条("主任务", 0, 1)
            If 配置文件操作模块.是否控制MC服务端8 Then
                日志窗口.添加日志("", 7)
                list.Add(8)
                处理单个RCON服务端.处理单个RCON服务端_发送指令(配置文件操作模块.RCON8地址, Conversions.ToInteger(配置文件操作模块.RCON8端口), 配置文件操作模块.RCON8密码, "list", "8")
            End If
            MainForm.更新进度条("主任务", 0, 1)
            If 配置文件操作模块.是否控制MC服务端9 Then
                日志窗口.添加日志("", 7)
                list.Add(9)
                处理单个RCON服务端.处理单个RCON服务端_发送指令(配置文件操作模块.RCON9地址, Conversions.ToInteger(配置文件操作模块.RCON9端口), 配置文件操作模块.RCON9密码, "list", "9")
            End If
            MainForm.更新进度条("主任务", 0, 1)
            If 配置文件操作模块.是否控制MC服务端10 Then
                日志窗口.添加日志("", 7)
                list.Add(10)
                处理单个RCON服务端.处理单个RCON服务端_发送指令(配置文件操作模块.RCON10地址, Conversions.ToInteger(配置文件操作模块.RCON10端口), 配置文件操作模块.RCON10密码, "list", "10")
            End If
            日志窗口.添加日志("", 7)
            MainForm.更新进度条("主任务", 0, 1)
            MainForm.更新标签("主任务", "无")
            MainForm.更新进度条("主任务", 0)
            配置文件操作模块.服务运行状态 = 服务运行状态
            If list.Count = 0 Then
                日志窗口.添加日志("没有可用的RCON服务器", 1)
            End If
        End Sub

        Private Sub Sftp服务器测试器()
            Dim 服务运行状态 = 配置文件操作模块.服务运行状态
            配置文件操作模块.服务运行状态 = False
            MainForm.更新标签("主任务", "测试Sftp服务器连接")
            MainForm.更新进度条("主任务", 0)
            Dim list As List(Of Integer) = New List(Of Integer)()
            Dim 本地文件路径 = Path.Combine(配置文件操作模块.程序数据目录, "八宝粥.ico")
            If 配置文件操作模块.Sftp1开关 Then
                list.Add(1)
                日志窗口.添加日志("", 7)
                日志窗口.添加日志("测试SFTP1服务器", 5)
                处理单个Sftp服务端功能.测试单个Sftp服务端_上传和删除(配置文件操作模块.Sftp1地址, 配置文件操作模块.Sftp1端口, 配置文件操作模块.Sftp1用户名, 配置文件操作模块.Sftp1密码, "1", 本地文件路径, "/", "/八宝粥.ico")
            End If
            MainForm.更新进度条("主任务", 33)
            If 配置文件操作模块.Sftp2开关 Then
                list.Add(2)
                日志窗口.添加日志("", 7)
                日志窗口.添加日志("测试SFTP2服务器", 5)
                处理单个Sftp服务端功能.测试单个Sftp服务端_上传和删除(配置文件操作模块.Sftp2地址, 配置文件操作模块.Sftp2端口, 配置文件操作模块.Sftp2用户名, 配置文件操作模块.Sftp2密码, "2", 本地文件路径, "/", "/八宝粥.ico")
            End If
            MainForm.更新进度条("主任务", 66)
            If 配置文件操作模块.Sftp3开关 Then
                list.Add(3)
                日志窗口.添加日志("", 7)
                日志窗口.添加日志("测试SFTP3服务器", 5)
                处理单个Sftp服务端功能.测试单个Sftp服务端_上传和删除(配置文件操作模块.Sftp3地址, 配置文件操作模块.Sftp3端口, 配置文件操作模块.Sftp3用户名, 配置文件操作模块.Sftp3密码, "3", 本地文件路径, "/", "/八宝粥.ico")
            End If
            日志窗口.添加日志("", 7)
            MainForm.更新标签("主任务", "无")
            MainForm.更新进度条("主任务", 0)
            MainForm.更新进度条("分任务", 0)
            配置文件操作模块.服务运行状态 = 服务运行状态
            If list.Count = 0 Then
                日志窗口.添加日志("没有可用的SFTP服务器", 1)
            End If
        End Sub

        Private Sub 切换图片并重置倒计时(sender As Object, e As EventArgs)
            图片序号 = 图片序号 + 1 Mod 图片列表.Count
            加载图片(图片列表(图片序号))
            下一次切换的时间点 = Date.Now.AddMinutes(1.0)
            更新图片切换倒计时显示()
        End Sub

        Private Sub 更新图片切换倒计时显示()
            Dim num As Integer = Math.Round(Math.Max(0, (下一次切换的时间点 - Date.Now).TotalSeconds))
            Me.倒计时数字显示.Text = $"{num} 秒后切换下一张"
            Me.倒计时进度条.Value = If(Math.Max(0, num) <= 60, Math.Max(0, num), 60)
        End Sub

        Private Sub 加载图片(图片目录 As String)
            Try
                Me.PictureBox.Image?.Dispose()
                Me.PictureBox.Image = Image.FromFile(图片目录)
            Catch ex As Exception
                ProjectData.SetProjectError(ex)
                Dim ex2 = ex
                MessageBox.Show($"加载图片失败：{ex2.Message}")
                Call ProjectData.ClearProjectError()
            End Try
        End Sub

        Private Sub NowTimer_Tick(sender As Object, e As EventArgs)
            更新图片切换倒计时显示()
            更新任务执行倒计时显示()
        End Sub

        Private Sub 更新任务执行倒计时显示()
            If 配置文件操作模块.服务运行状态 AndAlso Not 配置文件操作模块.备份操作进行状态 Then
                Dim item As Integer = 服务.获取剩余秒数().Item2
                Dim item2 As Integer = 服务.获取剩余秒数().Item1
                Dim num As Integer = item2 / 60 / 60 / 24
                Dim num2 As Integer = item2 / 60 / 60
                Dim num3 = num2 - num * 24
                Dim num4 As Integer = item2 / 60
                Dim num5 = num4 - num2 * 60
                Dim num6 = item2 - num4 * 60
                Dim num7 = item / 100.0
                Me.主任务进度条.Maximum = 100
                Me.执行中的主任务.Text = $"等待备份运行时间的到来,倒计时:[{num}:{num3}:{num5}:{num6}]"
                Me.主任务进度条.Value = Math.Round(item2 / num7)
            End If
        End Sub

        Public Shared Sub 更新进度条(进度条名 As String, 值 As Integer, Optional 操作 As Integer = 0)
            ' 异步改造：进度条更新 marshal 回 UI 线程，并使用 UI 线程的 MainForm 实例
            '（后台线程通过 My.Forms 默认实例会拿到错误实例，必须用 当前MainForm实例）
            ' 操作: 0=Value, 1=PerformStep, 2=Maximum
            Dim inst = 当前MainForm实例
            If inst Is Nothing Then
                Return
            End If
            Dim 进度条 As System.Windows.Forms.ProgressBar = Nothing
            Select Case 进度条名
                Case "主任务"
                    进度条 = inst.主任务进度条
                Case "分任务"
                    进度条 = inst.分任务进度条
            End Select
            If 进度条 Is Nothing Then
                Return
            End If
            Dim act As Action = Sub()
                                     Select Case 操作
                                         Case 0
                                             进度条.Value = 值
                                         Case 1
                                             进度条.PerformStep()
                                         Case 2
                                             进度条.Maximum = 值
                                     End Select
                                 End Sub
            If 进度条.InvokeRequired Then
                Try
                    进度条.Invoke(act)
                Catch
                End Try
            Else
                act()
            End If
        End Sub

        Public Shared Sub 更新标签(标签名 As String, 文本 As String)
            ' 异步改造：标签文本更新 marshal 回 UI 线程，并使用 UI 线程的 MainForm 实例
            Dim inst = 当前MainForm实例
            If inst Is Nothing Then
                Return
            End If
            Dim lbl As Label = Nothing
            If 标签名 = "主任务" Then
                lbl = inst.执行中的主任务
            ElseIf 标签名 = "分任务" Then
                lbl = inst.执行中的分任务
            End If
            If lbl Is Nothing Then
                Return
            End If
            If lbl.InvokeRequired Then
                Try
                    lbl.Invoke(Sub() lbl.Text = 文本)
                Catch
                End Try
            Else
                lbl.Text = 文本
            End If
        End Sub
    End Class
End Namespace
