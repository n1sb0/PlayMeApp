<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllFriendsForm
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
        Me.pnlUnderlblAllFriends = New System.Windows.Forms.Panel()
        Me.lblAllFriends = New System.Windows.Forms.Label()
        Me.AllFriendScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.AllFriendsPanel = New Guna.UI.WinForms.GunaPanel()
        Me.AllFriendsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlUnderlblAllFriends
        '
        Me.pnlUnderlblAllFriends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUnderlblAllFriends.BackColor = System.Drawing.Color.Gray
        Me.pnlUnderlblAllFriends.Location = New System.Drawing.Point(10, 1)
        Me.pnlUnderlblAllFriends.Name = "pnlUnderlblAllFriends"
        Me.pnlUnderlblAllFriends.Size = New System.Drawing.Size(865, 1)
        Me.pnlUnderlblAllFriends.TabIndex = 77
        '
        'lblAllFriends
        '
        Me.lblAllFriends.AutoSize = True
        Me.lblAllFriends.BackColor = System.Drawing.Color.Transparent
        Me.lblAllFriends.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblAllFriends.ForeColor = System.Drawing.Color.Silver
        Me.lblAllFriends.Location = New System.Drawing.Point(30, 15)
        Me.lblAllFriends.Name = "lblAllFriends"
        Me.lblAllFriends.Size = New System.Drawing.Size(97, 17)
        Me.lblAllFriends.TabIndex = 78
        Me.lblAllFriends.Text = "ALL FRIENDS -"
        '
        'AllFriendScrollBar
        '
        Me.AllFriendScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllFriendScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AllFriendScrollBar.LargeChange = 10
        Me.AllFriendScrollBar.Location = New System.Drawing.Point(920, 50)
        Me.AllFriendScrollBar.Maximum = 5000
        Me.AllFriendScrollBar.MouseWheelBarPartitions = 2
        Me.AllFriendScrollBar.Name = "AllFriendScrollBar"
        Me.AllFriendScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.AllFriendScrollBar.Size = New System.Drawing.Size(10, 595)
        Me.AllFriendScrollBar.TabIndex = 79
        Me.AllFriendScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AllFriendScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AllFriendScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.AllFriendScrollBar.Visible = False
        '
        'AllFriendsPanel
        '
        Me.AllFriendsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllFriendsPanel.Controls.Add(Me.pnlUnderlblAllFriends)
        Me.AllFriendsPanel.Location = New System.Drawing.Point(15, 50)
        Me.AllFriendsPanel.Name = "AllFriendsPanel"
        Me.AllFriendsPanel.Size = New System.Drawing.Size(900, 600)
        Me.AllFriendsPanel.TabIndex = 80
        '
        'AllFriendsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.AllFriendsPanel)
        Me.Controls.Add(Me.AllFriendScrollBar)
        Me.Controls.Add(Me.lblAllFriends)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AllFriendsForm"
        Me.Text = "AllFriendsForm"
        Me.AllFriendsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlUnderlblAllFriends As Panel
    Friend WithEvents lblAllFriends As Label
    Friend WithEvents AllFriendScrollBar As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents AllFriendsPanel As Guna.UI.WinForms.GunaPanel
End Class
