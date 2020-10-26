<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StateOnlineForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOnline = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pointOnline = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.btnAway = New Guna.UI.WinForms.GunaButton()
        Me.btnNotDisturb = New Guna.UI.WinForms.GunaButton()
        Me.btnOffline = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'btnOnline
        '
        Me.btnOnline.Animated = True
        Me.btnOnline.AnimationHoverSpeed = 0.07!
        Me.btnOnline.AnimationSpeed = 0.03!
        Me.btnOnline.BackColor = System.Drawing.Color.Transparent
        Me.btnOnline.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnOnline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnOnline.BorderSize = 1
        Me.btnOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOnline.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOnline.FocusedColor = System.Drawing.Color.Empty
        Me.btnOnline.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOnline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnOnline.Image = Nothing
        Me.btnOnline.ImageSize = New System.Drawing.Size(10, 10)
        Me.btnOnline.Location = New System.Drawing.Point(30, 10)
        Me.btnOnline.Name = "btnOnline"
        Me.btnOnline.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnOnline.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnOnline.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnOnline.OnHoverImage = Nothing
        Me.btnOnline.OnPressedColor = System.Drawing.Color.Black
        Me.btnOnline.Radius = 3
        Me.btnOnline.Size = New System.Drawing.Size(110, 30)
        Me.btnOnline.TabIndex = 105
        Me.btnOnline.Text = "Online"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(5, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 2)
        Me.Panel1.TabIndex = 107
        '
        'pointOnline
        '
        Me.pointOnline.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pointOnline.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pointOnline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pointOnline.BorderWidth = 3
        Me.pointOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pointOnline.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.pointOnline.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.pointOnline.Location = New System.Drawing.Point(12, 19)
        Me.pointOnline.Name = "pointOnline"
        Me.pointOnline.SelectionColor = System.Drawing.Color.Transparent
        Me.pointOnline.Size = New System.Drawing.Size(12, 12)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape4, Me.OvalShape3, Me.OvalShape1, Me.pointOnline})
        Me.ShapeContainer1.Size = New System.Drawing.Size(150, 160)
        Me.ShapeContainer1.TabIndex = 108
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape4
        '
        Me.OvalShape4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.OvalShape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OvalShape4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OvalShape4.BorderWidth = 3
        Me.OvalShape4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape4.FillColor = System.Drawing.Color.Silver
        Me.OvalShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape4.Location = New System.Drawing.Point(13, 134)
        Me.OvalShape4.Name = "OvalShape4"
        Me.OvalShape4.SelectionColor = System.Drawing.Color.Transparent
        Me.OvalShape4.Size = New System.Drawing.Size(12, 12)
        '
        'OvalShape3
        '
        Me.OvalShape3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.OvalShape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OvalShape3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OvalShape3.BorderWidth = 3
        Me.OvalShape3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape3.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.OvalShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape3.Location = New System.Drawing.Point(12, 104)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.OvalShape3.Size = New System.Drawing.Size(12, 12)
        '
        'OvalShape1
        '
        Me.OvalShape1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.OvalShape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OvalShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OvalShape1.BorderWidth = 3
        Me.OvalShape1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OvalShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.OvalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.OvalShape1.Location = New System.Drawing.Point(12, 69)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.OvalShape1.Size = New System.Drawing.Size(12, 12)
        '
        'btnAway
        '
        Me.btnAway.Animated = True
        Me.btnAway.AnimationHoverSpeed = 0.07!
        Me.btnAway.AnimationSpeed = 0.03!
        Me.btnAway.BackColor = System.Drawing.Color.Transparent
        Me.btnAway.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAway.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnAway.BorderSize = 1
        Me.btnAway.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAway.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAway.FocusedColor = System.Drawing.Color.Empty
        Me.btnAway.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAway.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnAway.Image = Nothing
        Me.btnAway.ImageSize = New System.Drawing.Size(10, 10)
        Me.btnAway.Location = New System.Drawing.Point(30, 60)
        Me.btnAway.Name = "btnAway"
        Me.btnAway.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnAway.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnAway.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnAway.OnHoverImage = Nothing
        Me.btnAway.OnPressedColor = System.Drawing.Color.Black
        Me.btnAway.Radius = 3
        Me.btnAway.Size = New System.Drawing.Size(110, 30)
        Me.btnAway.TabIndex = 109
        Me.btnAway.Text = "Away"
        '
        'btnNotDisturb
        '
        Me.btnNotDisturb.Animated = True
        Me.btnNotDisturb.AnimationHoverSpeed = 0.07!
        Me.btnNotDisturb.AnimationSpeed = 0.03!
        Me.btnNotDisturb.BackColor = System.Drawing.Color.Transparent
        Me.btnNotDisturb.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnNotDisturb.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnNotDisturb.BorderSize = 1
        Me.btnNotDisturb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNotDisturb.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNotDisturb.FocusedColor = System.Drawing.Color.Empty
        Me.btnNotDisturb.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnNotDisturb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnNotDisturb.Image = Nothing
        Me.btnNotDisturb.ImageSize = New System.Drawing.Size(10, 10)
        Me.btnNotDisturb.Location = New System.Drawing.Point(30, 95)
        Me.btnNotDisturb.Name = "btnNotDisturb"
        Me.btnNotDisturb.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnNotDisturb.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnNotDisturb.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnNotDisturb.OnHoverImage = Nothing
        Me.btnNotDisturb.OnPressedColor = System.Drawing.Color.Black
        Me.btnNotDisturb.Radius = 3
        Me.btnNotDisturb.Size = New System.Drawing.Size(110, 30)
        Me.btnNotDisturb.TabIndex = 110
        Me.btnNotDisturb.Text = "Not Disturb"
        '
        'btnOffline
        '
        Me.btnOffline.Animated = True
        Me.btnOffline.AnimationHoverSpeed = 0.07!
        Me.btnOffline.AnimationSpeed = 0.03!
        Me.btnOffline.BackColor = System.Drawing.Color.Transparent
        Me.btnOffline.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnOffline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnOffline.BorderSize = 1
        Me.btnOffline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOffline.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOffline.FocusedColor = System.Drawing.Color.Empty
        Me.btnOffline.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOffline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnOffline.Image = Nothing
        Me.btnOffline.ImageSize = New System.Drawing.Size(10, 10)
        Me.btnOffline.Location = New System.Drawing.Point(30, 125)
        Me.btnOffline.Name = "btnOffline"
        Me.btnOffline.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnOffline.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnOffline.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnOffline.OnHoverImage = Nothing
        Me.btnOffline.OnPressedColor = System.Drawing.Color.Black
        Me.btnOffline.Radius = 3
        Me.btnOffline.Size = New System.Drawing.Size(110, 30)
        Me.btnOffline.TabIndex = 111
        Me.btnOffline.Text = "Offline"
        '
        'StateOnlineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(150, 160)
        Me.Controls.Add(Me.btnOffline)
        Me.Controls.Add(Me.btnNotDisturb)
        Me.Controls.Add(Me.btnAway)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnOnline)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StateOnlineForm"
        Me.Text = "StateOnlineForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOnline As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pointOnline As PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents btnAway As Guna.UI.WinForms.GunaButton
    Friend WithEvents OvalShape3 As PowerPacks.OvalShape
    Friend WithEvents btnNotDisturb As Guna.UI.WinForms.GunaButton
    Friend WithEvents OvalShape4 As PowerPacks.OvalShape
    Friend WithEvents btnOffline As Guna.UI.WinForms.GunaButton
End Class
