Public Class ControlChildForm

    Public Sub OpenChildForm(ByRef childForm As Form, ByRef displayPanel As Panel, ByRef currentChildForm As Form)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        displayPanel.Controls.Add(childForm)
        displayPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

End Class
