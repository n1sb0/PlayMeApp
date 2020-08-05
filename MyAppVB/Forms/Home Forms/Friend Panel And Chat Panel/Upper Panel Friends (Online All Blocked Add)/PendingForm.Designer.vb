<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PendingForm
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
        Me.lblPendingReq = New System.Windows.Forms.Label()
        Me.pnlPendingReq = New Guna.UI.WinForms.GunaPanel()
        Me.iconPicUsers = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlUnderTextPeddingReq = New System.Windows.Forms.Panel()
        Me.PendingReqScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.pnlPendingReq.SuspendLayout()
        CType(Me.iconPicUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPendingReq
        '
        Me.lblPendingReq.AutoSize = True
        Me.lblPendingReq.BackColor = System.Drawing.Color.Transparent
        Me.lblPendingReq.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPendingReq.ForeColor = System.Drawing.Color.Silver
        Me.lblPendingReq.Location = New System.Drawing.Point(32, 15)
        Me.lblPendingReq.Name = "lblPendingReq"
        Me.lblPendingReq.Size = New System.Drawing.Size(142, 17)
        Me.lblPendingReq.TabIndex = 93
        Me.lblPendingReq.Text = "PENDING REQUESTS -"
        Me.lblPendingReq.Visible = False
        '
        'pnlPendingReq
        '
        Me.pnlPendingReq.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPendingReq.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.pnlPendingReq.Controls.Add(Me.iconPicUsers)
        Me.pnlPendingReq.Controls.Add(Me.Label1)
        Me.pnlPendingReq.Controls.Add(Me.pnlUnderTextPeddingReq)
        Me.pnlPendingReq.Location = New System.Drawing.Point(15, 50)
        Me.pnlPendingReq.Name = "pnlPendingReq"
        Me.pnlPendingReq.Size = New System.Drawing.Size(900, 600)
        Me.pnlPendingReq.TabIndex = 95
        '
        'iconPicUsers
        '
        Me.iconPicUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.iconPicUsers.ForeColor = System.Drawing.Color.Silver
        Me.iconPicUsers.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.iconPicUsers.IconColor = System.Drawing.Color.Silver
        Me.iconPicUsers.IconSize = 250
        Me.iconPicUsers.Location = New System.Drawing.Point(312, 100)
        Me.iconPicUsers.Name = "iconPicUsers"
        Me.iconPicUsers.Size = New System.Drawing.Size(250, 250)
        Me.iconPicUsers.TabIndex = 97
        Me.iconPicUsers.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(280, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 22)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "There are no pending friend requests."
        '
        'pnlUnderTextPeddingReq
        '
        Me.pnlUnderTextPeddingReq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUnderTextPeddingReq.BackColor = System.Drawing.Color.Gray
        Me.pnlUnderTextPeddingReq.Location = New System.Drawing.Point(10, 1)
        Me.pnlUnderTextPeddingReq.Name = "pnlUnderTextPeddingReq"
        Me.pnlUnderTextPeddingReq.Size = New System.Drawing.Size(865, 1)
        Me.pnlUnderTextPeddingReq.TabIndex = 89
        Me.pnlUnderTextPeddingReq.Visible = False
        '
        'PendingReqScrollBar
        '
        Me.PendingReqScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PendingReqScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PendingReqScrollBar.LargeChange = 10
        Me.PendingReqScrollBar.Location = New System.Drawing.Point(920, 50)
        Me.PendingReqScrollBar.Maximum = 5000
        Me.PendingReqScrollBar.MouseWheelBarPartitions = 2
        Me.PendingReqScrollBar.Name = "PendingReqScrollBar"
        Me.PendingReqScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PendingReqScrollBar.Size = New System.Drawing.Size(10, 595)
        Me.PendingReqScrollBar.TabIndex = 94
        Me.PendingReqScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PendingReqScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PendingReqScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PendingReqScrollBar.Visible = False
        '
        'PendingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.lblPendingReq)
        Me.Controls.Add(Me.pnlPendingReq)
        Me.Controls.Add(Me.PendingReqScrollBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PendingForm"
        Me.Text = "PandingForm"
        Me.pnlPendingReq.ResumeLayout(False)
        Me.pnlPendingReq.PerformLayout()
        CType(Me.iconPicUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPendingReq As Label
    Friend WithEvents pnlPendingReq As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pnlUnderTextPeddingReq As Panel
    Friend WithEvents PendingReqScrollBar As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents iconPicUsers As FontAwesome.Sharp.IconPictureBox
End Class
