<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateDMForm
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblFindOrstartConv = New System.Windows.Forms.Label()
        Me.txtFindFriends = New System.Windows.Forms.TextBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.lblSelectFriends = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.dmFriendScrollBar = New Guna.UI.WinForms.GunaVScrollBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCreateGruopDM = New Guna.UI.WinForms.GunaButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlOfFriends = New Guna.UI.WinForms.GunaPanel()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.GunaButton1)
        Me.Panel4.Controls.Add(Me.GunaButton3)
        Me.Panel4.Controls.Add(Me.lblSelectFriends)
        Me.Panel4.Controls.Add(Me.lblMsg)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(400, 108)
        Me.Panel4.TabIndex = 132
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblFindOrstartConv)
        Me.Panel2.Controls.Add(Me.txtFindFriends)
        Me.Panel2.Location = New System.Drawing.Point(25, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(350, 30)
        Me.Panel2.TabIndex = 119
        '
        'lblFindOrstartConv
        '
        Me.lblFindOrstartConv.AutoSize = True
        Me.lblFindOrstartConv.BackColor = System.Drawing.Color.Transparent
        Me.lblFindOrstartConv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblFindOrstartConv.Enabled = False
        Me.lblFindOrstartConv.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFindOrstartConv.ForeColor = System.Drawing.Color.Gray
        Me.lblFindOrstartConv.Location = New System.Drawing.Point(11, 5)
        Me.lblFindOrstartConv.Name = "lblFindOrstartConv"
        Me.lblFindOrstartConv.Size = New System.Drawing.Size(207, 20)
        Me.lblFindOrstartConv.TabIndex = 80
        Me.lblFindOrstartConv.Text = "Find or start a conversation"
        '
        'txtFindFriends
        '
        Me.txtFindFriends.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFindFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtFindFriends.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFindFriends.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFindFriends.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.txtFindFriends.Location = New System.Drawing.Point(3, 5)
        Me.txtFindFriends.Multiline = True
        Me.txtFindFriends.Name = "txtFindFriends"
        Me.txtFindFriends.Size = New System.Drawing.Size(344, 20)
        Me.txtFindFriends.TabIndex = 95
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton1.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaButton1.Location = New System.Drawing.Point(359, 57)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaButton1.Radius = 10
        Me.GunaButton1.Size = New System.Drawing.Size(30, 30)
        Me.GunaButton1.TabIndex = 121
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.Cursor = System.Windows.Forms.Cursors.Default
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton3.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaButton3.Location = New System.Drawing.Point(10, 57)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaButton3.Radius = 10
        Me.GunaButton3.Size = New System.Drawing.Size(30, 30)
        Me.GunaButton3.TabIndex = 120
        '
        'lblSelectFriends
        '
        Me.lblSelectFriends.AutoSize = True
        Me.lblSelectFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSelectFriends.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblSelectFriends.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblSelectFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSelectFriends.Location = New System.Drawing.Point(12, 9)
        Me.lblSelectFriends.Name = "lblSelectFriends"
        Me.lblSelectFriends.Size = New System.Drawing.Size(133, 19)
        Me.lblSelectFriends.TabIndex = 77
        Me.lblSelectFriends.Text = "SELECT FRIENDS"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Gray
        Me.lblMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMsg.Location = New System.Drawing.Point(12, 29)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(174, 17)
        Me.lblMsg.TabIndex = 78
        Me.lblMsg.Text = "You can add 9 more friends."
        '
        'dmFriendScrollBar
        '
        Me.dmFriendScrollBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dmFriendScrollBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dmFriendScrollBar.LargeChange = 10
        Me.dmFriendScrollBar.Location = New System.Drawing.Point(386, 110)
        Me.dmFriendScrollBar.Maximum = 5000
        Me.dmFriendScrollBar.MouseWheelBarPartitions = 2
        Me.dmFriendScrollBar.Name = "dmFriendScrollBar"
        Me.dmFriendScrollBar.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.dmFriendScrollBar.Size = New System.Drawing.Size(10, 165)
        Me.dmFriendScrollBar.TabIndex = 127
        Me.dmFriendScrollBar.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dmFriendScrollBar.ThumbHoverColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dmFriendScrollBar.ThumbPressedColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCreateGruopDM)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(1, 275)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 77)
        Me.Panel1.TabIndex = 130
        '
        'btnCreateGruopDM
        '
        Me.btnCreateGruopDM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateGruopDM.Animated = True
        Me.btnCreateGruopDM.AnimationHoverSpeed = 0.07!
        Me.btnCreateGruopDM.AnimationSpeed = 0.03!
        Me.btnCreateGruopDM.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateGruopDM.BaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnCreateGruopDM.BorderColor = System.Drawing.Color.Black
        Me.btnCreateGruopDM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateGruopDM.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCreateGruopDM.FocusedColor = System.Drawing.Color.Empty
        Me.btnCreateGruopDM.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCreateGruopDM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnCreateGruopDM.Image = Nothing
        Me.btnCreateGruopDM.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCreateGruopDM.Location = New System.Drawing.Point(14, 20)
        Me.btnCreateGruopDM.Name = "btnCreateGruopDM"
        Me.btnCreateGruopDM.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnCreateGruopDM.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCreateGruopDM.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCreateGruopDM.OnHoverImage = Nothing
        Me.btnCreateGruopDM.OnPressedColor = System.Drawing.Color.Black
        Me.btnCreateGruopDM.Radius = 5
        Me.btnCreateGruopDM.Size = New System.Drawing.Size(369, 30)
        Me.btnCreateGruopDM.TabIndex = 125
        Me.btnCreateGruopDM.Text = "Create Group DM"
        Me.btnCreateGruopDM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(400, 1)
        Me.Panel3.TabIndex = 124
        '
        'pnlOfFriends
        '
        Me.pnlOfFriends.Location = New System.Drawing.Point(1, 105)
        Me.pnlOfFriends.Name = "pnlOfFriends"
        Me.pnlOfFriends.Size = New System.Drawing.Size(400, 170)
        Me.pnlOfFriends.TabIndex = 131
        '
        'CreateDMForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 350)
        Me.Controls.Add(Me.dmFriendScrollBar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlOfFriends)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateDMForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateDM"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFindOrstartConv As Label
    Friend WithEvents txtFindFriends As TextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblSelectFriends As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents dmFriendScrollBar As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCreateGruopDM As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlOfFriends As Guna.UI.WinForms.GunaPanel
End Class
