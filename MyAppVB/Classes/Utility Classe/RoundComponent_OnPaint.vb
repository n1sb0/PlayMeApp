Public Class RoundComponent_OnPaint

    Sub New()

    End Sub

    Public Sub On_Paint_Forms(sender As Object, e As PaintEventArgs, mForm As Form)
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.Clear(mForm.Parent.BackColor)
        Dim control As Control = mForm
        Dim radius As Integer = 12

        Using path As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath()
            path.AddLine(radius, 0, control.Width - radius, 0)
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90)
            path.AddLine(control.Width, radius, control.Width, control.Height - radius)
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90)
            path.AddLine(control.Width - radius, control.Height, radius, control.Height)
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90)
            path.AddLine(0, control.Height - radius, 0, radius)
            path.AddArc(0, 0, radius, radius, 180, 90)

            Using brush As SolidBrush = New SolidBrush(control.BackColor)
                e.Graphics.FillPath(brush, path)
            End Using
        End Using
    End Sub
End Class
