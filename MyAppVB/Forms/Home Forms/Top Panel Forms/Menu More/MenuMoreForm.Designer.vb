<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMoreForm
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
        Me.btnStartVideoCall = New Guna.UI.WinForms.GunaButton()
        Me.btnStartVoiceCall = New Guna.UI.WinForms.GunaButton()
        Me.btnDeleteFriend = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'btnStartVideoCall
        '
        Me.btnStartVideoCall.Animated = True
        Me.btnStartVideoCall.AnimationHoverSpeed = 0.07!
        Me.btnStartVideoCall.AnimationSpeed = 0.03!
        Me.btnStartVideoCall.BackColor = System.Drawing.Color.Transparent
        Me.btnStartVideoCall.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnStartVideoCall.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnStartVideoCall.BorderSize = 1
        Me.btnStartVideoCall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartVideoCall.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStartVideoCall.FocusedColor = System.Drawing.Color.Empty
        Me.btnStartVideoCall.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnStartVideoCall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnStartVideoCall.Image = Nothing
        Me.btnStartVideoCall.ImageSize = New System.Drawing.Size(10, 10)
        Me.btnStartVideoCall.Location = New System.Drawing.Point(6, 8)
        Me.btnStartVideoCall.Name = "btnStartVideoCall"
        Me.btnStartVideoCall.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnStartVideoCall.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnStartVideoCall.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnStartVideoCall.OnHoverImage = Nothing
        Me.btnStartVideoCall.OnPressedColor = System.Drawing.Color.Black
        Me.btnStartVideoCall.Radius = 5
        Me.btnStartVideoCall.Size = New System.Drawing.Size(185, 30)
        Me.btnStartVideoCall.TabIndex = 101
        Me.btnStartVideoCall.Text = "Start Video Call"
        Me.btnStartVideoCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStartVoiceCall
        '
        Me.btnStartVoiceCall.Animated = True
        Me.btnStartVoiceCall.AnimationHoverSpeed = 0.07!
        Me.btnStartVoiceCall.AnimationSpeed = 0.03!
        Me.btnStartVoiceCall.BackColor = System.Drawing.Color.Transparent
        Me.btnStartVoiceCall.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnStartVoiceCall.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnStartVoiceCall.BorderSize = 1
        Me.btnStartVoiceCall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartVoiceCall.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStartVoiceCall.FocusedColor = System.Drawing.Color.Empty
        Me.btnStartVoiceCall.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnStartVoiceCall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnStartVoiceCall.Image = Nothing
        Me.btnStartVoiceCall.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnStartVoiceCall.Location = New System.Drawing.Point(6, 44)
        Me.btnStartVoiceCall.Name = "btnStartVoiceCall"
        Me.btnStartVoiceCall.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnStartVoiceCall.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnStartVoiceCall.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnStartVoiceCall.OnHoverImage = Nothing
        Me.btnStartVoiceCall.OnPressedColor = System.Drawing.Color.Black
        Me.btnStartVoiceCall.Radius = 5
        Me.btnStartVoiceCall.Size = New System.Drawing.Size(185, 30)
        Me.btnStartVoiceCall.TabIndex = 100
        Me.btnStartVoiceCall.Text = "Start Voice Call"
        Me.btnStartVoiceCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDeleteFriend
        '
        Me.btnDeleteFriend.Animated = True
        Me.btnDeleteFriend.AnimationHoverSpeed = 0.07!
        Me.btnDeleteFriend.AnimationSpeed = 0.03!
        Me.btnDeleteFriend.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteFriend.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnDeleteFriend.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnDeleteFriend.BorderSize = 1
        Me.btnDeleteFriend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteFriend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleteFriend.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleteFriend.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDeleteFriend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteFriend.Image = Nothing
        Me.btnDeleteFriend.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDeleteFriend.Location = New System.Drawing.Point(6, 80)
        Me.btnDeleteFriend.Name = "btnDeleteFriend"
        Me.btnDeleteFriend.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteFriend.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteFriend.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnDeleteFriend.OnHoverImage = Nothing
        Me.btnDeleteFriend.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleteFriend.Radius = 5
        Me.btnDeleteFriend.Size = New System.Drawing.Size(185, 30)
        Me.btnDeleteFriend.TabIndex = 99
        Me.btnDeleteFriend.Text = "Remove Friend"
        Me.btnDeleteFriend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuMoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(196, 116)
        Me.Controls.Add(Me.btnStartVideoCall)
        Me.Controls.Add(Me.btnStartVoiceCall)
        Me.Controls.Add(Me.btnDeleteFriend)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuMoreForm"
        Me.Text = "MenuMoreForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStartVideoCall As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnStartVoiceCall As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDeleteFriend As Guna.UI.WinForms.GunaButton
End Class
