<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddFriendForm
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
        Me.LogoName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FindFriendPanel = New System.Windows.Forms.Panel()
        Me.txtFindFriend = New System.Windows.Forms.TextBox()
        Me.btnSendFriendRequest = New Guna.UI.WinForms.GunaButton()
        Me.FindFriendPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoName
        '
        Me.LogoName.BackColor = System.Drawing.Color.Transparent
        Me.LogoName.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LogoName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LogoName.Location = New System.Drawing.Point(40, 30)
        Me.LogoName.Name = "LogoName"
        Me.LogoName.Size = New System.Drawing.Size(110, 20)
        Me.LogoName.TabIndex = 74
        Me.LogoName.Text = "ADD FRIEND"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(40, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 20)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "You can add a friend with thair Name. Be careful to write the Name in right way!"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 2)
        Me.Panel1.TabIndex = 76
        '
        'FindFriendPanel
        '
        Me.FindFriendPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FindFriendPanel.Controls.Add(Me.txtFindFriend)
        Me.FindFriendPanel.Controls.Add(Me.btnSendFriendRequest)
        Me.FindFriendPanel.Location = New System.Drawing.Point(40, 90)
        Me.FindFriendPanel.Name = "FindFriendPanel"
        Me.FindFriendPanel.Size = New System.Drawing.Size(870, 50)
        Me.FindFriendPanel.TabIndex = 77
        '
        'txtFindFriend
        '
        Me.txtFindFriend.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtFindFriend.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFindFriend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtFindFriend.ForeColor = System.Drawing.Color.Gray
        Me.txtFindFriend.Location = New System.Drawing.Point(15, 15)
        Me.txtFindFriend.Multiline = True
        Me.txtFindFriend.Name = "txtFindFriend"
        Me.txtFindFriend.Size = New System.Drawing.Size(650, 25)
        Me.txtFindFriend.TabIndex = 95
        Me.txtFindFriend.Text = "Enter a Username"
        '
        'btnSendFriendRequest
        '
        Me.btnSendFriendRequest.AnimationHoverSpeed = 0.07!
        Me.btnSendFriendRequest.AnimationSpeed = 0.03!
        Me.btnSendFriendRequest.BackColor = System.Drawing.Color.Transparent
        Me.btnSendFriendRequest.BaseColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnSendFriendRequest.BorderColor = System.Drawing.Color.Black
        Me.btnSendFriendRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendFriendRequest.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSendFriendRequest.Enabled = False
        Me.btnSendFriendRequest.FocusedColor = System.Drawing.Color.Empty
        Me.btnSendFriendRequest.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSendFriendRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSendFriendRequest.Image = Nothing
        Me.btnSendFriendRequest.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSendFriendRequest.Location = New System.Drawing.Point(680, 10)
        Me.btnSendFriendRequest.Name = "btnSendFriendRequest"
        Me.btnSendFriendRequest.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnSendFriendRequest.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSendFriendRequest.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnSendFriendRequest.OnHoverImage = Nothing
        Me.btnSendFriendRequest.OnPressedColor = System.Drawing.Color.Black
        Me.btnSendFriendRequest.Radius = 7
        Me.btnSendFriendRequest.Size = New System.Drawing.Size(175, 30)
        Me.btnSendFriendRequest.TabIndex = 94
        Me.btnSendFriendRequest.Text = "Send Friend Request"
        '
        'AddFriendForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.FindFriendPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddFriendForm"
        Me.Text = "AddFriendForm"
        Me.FindFriendPanel.ResumeLayout(False)
        Me.FindFriendPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FindFriendPanel As Panel
    Friend WithEvents btnSendFriendRequest As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtFindFriend As TextBox
End Class
