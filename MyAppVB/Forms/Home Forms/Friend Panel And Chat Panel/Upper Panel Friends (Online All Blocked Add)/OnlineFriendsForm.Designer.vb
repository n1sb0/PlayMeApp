<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OnlineFriendsForm
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
        Me.pnlUnderTextOnlineFriends = New System.Windows.Forms.Panel()
        Me.lblFriendsOnlineNow = New System.Windows.Forms.Label()
        Me.pnlFriendsOnlineNow = New Guna.UI.WinForms.GunaPanel()
        Me.OnlineFriendScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.pnlFriendsOnlineNow.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlUnderTextOnlineFriends
        '
        Me.pnlUnderTextOnlineFriends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUnderTextOnlineFriends.BackColor = System.Drawing.Color.Gray
        Me.pnlUnderTextOnlineFriends.Location = New System.Drawing.Point(10, 1)
        Me.pnlUnderTextOnlineFriends.Name = "pnlUnderTextOnlineFriends"
        Me.pnlUnderTextOnlineFriends.Size = New System.Drawing.Size(865, 1)
        Me.pnlUnderTextOnlineFriends.TabIndex = 89
        '
        'lblFriendsOnlineNow
        '
        Me.lblFriendsOnlineNow.AutoSize = True
        Me.lblFriendsOnlineNow.BackColor = System.Drawing.Color.Transparent
        Me.lblFriendsOnlineNow.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFriendsOnlineNow.ForeColor = System.Drawing.Color.Silver
        Me.lblFriendsOnlineNow.Location = New System.Drawing.Point(32, 15)
        Me.lblFriendsOnlineNow.Name = "lblFriendsOnlineNow"
        Me.lblFriendsOnlineNow.Size = New System.Drawing.Size(65, 17)
        Me.lblFriendsOnlineNow.TabIndex = 90
        Me.lblFriendsOnlineNow.Text = "ONLINE -"
        '
        'pnlFriendsOnlineNow
        '
        Me.pnlFriendsOnlineNow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlFriendsOnlineNow.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.pnlFriendsOnlineNow.Controls.Add(Me.pnlUnderTextOnlineFriends)
        Me.pnlFriendsOnlineNow.Location = New System.Drawing.Point(15, 50)
        Me.pnlFriendsOnlineNow.Name = "pnlFriendsOnlineNow"
        Me.pnlFriendsOnlineNow.Size = New System.Drawing.Size(900, 600)
        Me.pnlFriendsOnlineNow.TabIndex = 92
        Me.pnlFriendsOnlineNow.Visible = False
        '
        'OnlineFriendScrollBar
        '
        Me.OnlineFriendScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OnlineFriendScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OnlineFriendScrollBar.LargeChange = 10
        Me.OnlineFriendScrollBar.Location = New System.Drawing.Point(920, 50)
        Me.OnlineFriendScrollBar.Maximum = 5000
        Me.OnlineFriendScrollBar.MouseWheelBarPartitions = 2
        Me.OnlineFriendScrollBar.Name = "OnlineFriendScrollBar"
        Me.OnlineFriendScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.OnlineFriendScrollBar.Size = New System.Drawing.Size(10, 595)
        Me.OnlineFriendScrollBar.TabIndex = 91
        Me.OnlineFriendScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OnlineFriendScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OnlineFriendScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.OnlineFriendScrollBar.Visible = False
        '
        'OnlineFriendsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.lblFriendsOnlineNow)
        Me.Controls.Add(Me.pnlFriendsOnlineNow)
        Me.Controls.Add(Me.OnlineFriendScrollBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OnlineFriendsForm"
        Me.Text = "OnlineFriendsForm"
        Me.pnlFriendsOnlineNow.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlUnderTextOnlineFriends As Panel
    Friend WithEvents lblFriendsOnlineNow As Label
    Friend WithEvents pnlFriendsOnlineNow As Guna.UI.WinForms.GunaPanel
    Friend WithEvents OnlineFriendScrollBar As Guna.UI.WinForms.GunaVScrollBar
End Class
