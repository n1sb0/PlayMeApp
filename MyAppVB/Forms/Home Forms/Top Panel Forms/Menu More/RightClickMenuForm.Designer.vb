<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RightClickMenuForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnProfile = New Guna.UI.WinForms.GunaButton()
        Me.btnMessage = New Guna.UI.WinForms.GunaButton()
        Me.btnCall = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRemove = New Guna.UI.WinForms.GunaButton()
        Me.btnBlock = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'btnProfile
        '
        Me.btnProfile.Animated = True
        Me.btnProfile.AnimationHoverSpeed = 0.07!
        Me.btnProfile.AnimationSpeed = 0.03!
        Me.btnProfile.BackColor = System.Drawing.Color.Transparent
        Me.btnProfile.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnProfile.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnProfile.BorderSize = 1
        Me.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProfile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnProfile.FocusedColor = System.Drawing.Color.Empty
        Me.btnProfile.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnProfile.Image = Nothing
        Me.btnProfile.ImageSize = New System.Drawing.Size(10, 10)
        Me.btnProfile.Location = New System.Drawing.Point(3, 4)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnProfile.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnProfile.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnProfile.OnHoverImage = Nothing
        Me.btnProfile.OnPressedColor = System.Drawing.Color.Black
        Me.btnProfile.Radius = 5
        Me.btnProfile.Size = New System.Drawing.Size(150, 30)
        Me.btnProfile.TabIndex = 104
        Me.btnProfile.Text = "Profile"
        '
        'btnMessage
        '
        Me.btnMessage.Animated = True
        Me.btnMessage.AnimationHoverSpeed = 0.07!
        Me.btnMessage.AnimationSpeed = 0.03!
        Me.btnMessage.BackColor = System.Drawing.Color.Transparent
        Me.btnMessage.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnMessage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnMessage.BorderSize = 1
        Me.btnMessage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMessage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMessage.FocusedColor = System.Drawing.Color.Empty
        Me.btnMessage.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnMessage.Image = Nothing
        Me.btnMessage.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnMessage.Location = New System.Drawing.Point(3, 39)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnMessage.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnMessage.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnMessage.OnHoverImage = Nothing
        Me.btnMessage.OnPressedColor = System.Drawing.Color.Black
        Me.btnMessage.Radius = 5
        Me.btnMessage.Size = New System.Drawing.Size(150, 30)
        Me.btnMessage.TabIndex = 103
        Me.btnMessage.Text = "Message"
        '
        'btnCall
        '
        Me.btnCall.Animated = True
        Me.btnCall.AnimationHoverSpeed = 0.07!
        Me.btnCall.AnimationSpeed = 0.03!
        Me.btnCall.BackColor = System.Drawing.Color.Transparent
        Me.btnCall.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnCall.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnCall.BorderSize = 1
        Me.btnCall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCall.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCall.FocusedColor = System.Drawing.Color.Empty
        Me.btnCall.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCall.Image = Nothing
        Me.btnCall.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCall.Location = New System.Drawing.Point(3, 74)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnCall.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnCall.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnCall.OnHoverImage = Nothing
        Me.btnCall.OnPressedColor = System.Drawing.Color.Black
        Me.btnCall.Radius = 5
        Me.btnCall.Size = New System.Drawing.Size(150, 30)
        Me.btnCall.TabIndex = 105
        Me.btnCall.Text = "Call"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(10, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(135, 2)
        Me.Panel1.TabIndex = 106
        '
        'btnRemove
        '
        Me.btnRemove.Animated = True
        Me.btnRemove.AnimationHoverSpeed = 0.07!
        Me.btnRemove.AnimationSpeed = 0.03!
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnRemove.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnRemove.BorderSize = 1
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRemove.FocusedColor = System.Drawing.Color.Empty
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnRemove.Image = Nothing
        Me.btnRemove.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnRemove.Location = New System.Drawing.Point(3, 117)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnRemove.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnRemove.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnRemove.OnHoverImage = Nothing
        Me.btnRemove.OnPressedColor = System.Drawing.Color.Black
        Me.btnRemove.Radius = 5
        Me.btnRemove.Size = New System.Drawing.Size(150, 30)
        Me.btnRemove.TabIndex = 107
        Me.btnRemove.Text = "Remove Friend"
        '
        'btnBlock
        '
        Me.btnBlock.Animated = True
        Me.btnBlock.AnimationHoverSpeed = 0.07!
        Me.btnBlock.AnimationSpeed = 0.03!
        Me.btnBlock.BackColor = System.Drawing.Color.Transparent
        Me.btnBlock.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBlock.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnBlock.BorderSize = 1
        Me.btnBlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBlock.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBlock.FocusedColor = System.Drawing.Color.Empty
        Me.btnBlock.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnBlock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnBlock.Image = Nothing
        Me.btnBlock.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnBlock.Location = New System.Drawing.Point(3, 152)
        Me.btnBlock.Name = "btnBlock"
        Me.btnBlock.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnBlock.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnBlock.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnBlock.OnHoverImage = Nothing
        Me.btnBlock.OnPressedColor = System.Drawing.Color.Black
        Me.btnBlock.Radius = 5
        Me.btnBlock.Size = New System.Drawing.Size(150, 30)
        Me.btnBlock.TabIndex = 108
        Me.btnBlock.Text = "Block"
        '
        'RightClickMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(156, 185)
        Me.Controls.Add(Me.btnBlock)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCall)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RightClickMenuForm"
        Me.Text = "RightClickMenuForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProfile As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMessage As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCall As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRemove As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnBlock As Guna.UI.WinForms.GunaButton
End Class
