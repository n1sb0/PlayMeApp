<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteFriendForm
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
        Me.lblRemoveName = New System.Windows.Forms.Label()
        Me.lblMsgToDeleteUser = New System.Windows.Forms.Label()
        Me.btnCancel = New Guna.UI.WinForms.GunaButton()
        Me.btnDeleteFriend = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRemoveName
        '
        Me.lblRemoveName.AutoSize = True
        Me.lblRemoveName.BackColor = System.Drawing.Color.Transparent
        Me.lblRemoveName.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblRemoveName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblRemoveName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRemoveName.Location = New System.Drawing.Point(12, 9)
        Me.lblRemoveName.Name = "lblRemoveName"
        Me.lblRemoveName.Size = New System.Drawing.Size(75, 19)
        Me.lblRemoveName.TabIndex = 77
        Me.lblRemoveName.Text = "REMOVE"
        '
        'lblMsgToDeleteUser
        '
        Me.lblMsgToDeleteUser.BackColor = System.Drawing.Color.Transparent
        Me.lblMsgToDeleteUser.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgToDeleteUser.ForeColor = System.Drawing.Color.Silver
        Me.lblMsgToDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMsgToDeleteUser.Location = New System.Drawing.Point(12, 49)
        Me.lblMsgToDeleteUser.Name = "lblMsgToDeleteUser"
        Me.lblMsgToDeleteUser.Size = New System.Drawing.Size(376, 62)
        Me.lblMsgToDeleteUser.TabIndex = 78
        Me.lblMsgToDeleteUser.Text = "Are you sure you want to permanently "
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderSize = 1
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCancel.Image = Nothing
        Me.btnCancel.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnCancel.Location = New System.Drawing.Point(165, 17)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnCancel.Radius = 5
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.TabIndex = 103
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDeleteFriend
        '
        Me.btnDeleteFriend.Animated = True
        Me.btnDeleteFriend.AnimationHoverSpeed = 0.07!
        Me.btnDeleteFriend.AnimationSpeed = 0.03!
        Me.btnDeleteFriend.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteFriend.BaseColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteFriend.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteFriend.BorderSize = 1
        Me.btnDeleteFriend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteFriend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleteFriend.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleteFriend.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnDeleteFriend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnDeleteFriend.Image = Nothing
        Me.btnDeleteFriend.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnDeleteFriend.Location = New System.Drawing.Point(260, 17)
        Me.btnDeleteFriend.Name = "btnDeleteFriend"
        Me.btnDeleteFriend.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDeleteFriend.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDeleteFriend.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnDeleteFriend.OnHoverImage = Nothing
        Me.btnDeleteFriend.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleteFriend.Radius = 5
        Me.btnDeleteFriend.Size = New System.Drawing.Size(120, 36)
        Me.btnDeleteFriend.TabIndex = 102
        Me.btnDeleteFriend.Text = "Remove Friend"
        Me.btnDeleteFriend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnDeleteFriend)
        Me.Panel1.Location = New System.Drawing.Point(0, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 70)
        Me.Panel1.TabIndex = 104
        '
        'DeleteFriendForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblMsgToDeleteUser)
        Me.Controls.Add(Me.lblRemoveName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DeleteFriendForm"
        Me.Text = "cccc"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRemoveName As Label
    Friend WithEvents lblMsgToDeleteUser As Label
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDeleteFriend As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel1 As Panel
End Class
