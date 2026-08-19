Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace BBZ_MCServers_Manager

    Public Class 开关控件
        Inherits Control
        Public Delegate Sub 状态变化EventHandler(新状态 As Boolean)

        Public 当前状态 As Boolean

        Private 滑块位置 As Integer

        Private ReadOnly 动画计时器 As Timer

        Public Event 状态变化 As 开关控件.状态变化EventHandler

        Public Sub New()
            当前状态 = False
            滑块位置 = 0
            动画计时器 = New Timer With {
        .Interval = 15
    }
            Size = New Size(100, 40)
            MyBase.DoubleBuffered = True
            AddHandler 动画计时器.Tick, AddressOf 执行动画
        End Sub

        Protected Overrides Sub OnClick(e As EventArgs)
            MyBase.OnClick(e)
            切换状态()
        End Sub

        Public Sub 切换状态()
            当前状态 = Not 当前状态
            动画计时器.Start()
            RaiseEvent 状态变化(当前状态)
        End Sub

        Private Sub 执行动画(sender As Object, e As EventArgs)
            Dim num = If(当前状态, Width - 30, 0)
            滑块位置 = CInt(Math.Round(滑块位置 + (num - 滑块位置) * 0.2))
            If Math.Abs(滑块位置 - num) < 2 Then
                滑块位置 = num
                动画计时器.Stop()
            End If
            Invalidate()
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
            Using brush As SolidBrush = New SolidBrush(If(当前状态, Color.FromArgb(100, 200, 100), Color.FromArgb(200, 100, 100)))
                e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
            End Using
            Using brush2 As SolidBrush = New SolidBrush(Color.White)
                e.Graphics.FillRectangle(brush2, 滑块位置, 2, 28, Height - 4)
            End Using
            Dim s = Conversions.ToString(If(当前状态, CObj(True), "False"))
            Dim brush3 As SolidBrush = New SolidBrush(MyBase.ForeColor)
            e.Graphics.DrawString(s, MyBase.Font, brush3, New PointF(Width / 2.0 - 10.0, Height / 2.0 - 8.0))
        End Sub
    End Class
End Namespace
