<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ckBoxRememberMe = New System.Windows.Forms.CheckBox()
        Me.lblCreaAcc = New System.Windows.Forms.Label()
        Me.lblResetAcc = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.panelPass = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.myMoveForm = New System.Windows.Forms.Label()
        Me.AppLogo = New System.Windows.Forms.PictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.panelLogin = New System.Windows.Forms.Panel()
        Me.lblErroreMsg = New System.Windows.Forms.Label()
        Me.confLogin = New System.Windows.Forms.Label()
        Me.confPassword = New System.Windows.Forms.Label()
        Me.btnSeePassword = New FontAwesome.Sharp.IconPictureBox()
        Me.btnExit = New FontAwesome.Sharp.IconPictureBox()
        Me.btnHide = New FontAwesome.Sharp.IconPictureBox()
        Me.btnLogin = New Guna.UI.WinForms.GunaButton()
        CType(Me.AppLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSeePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(413, 213)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ckBoxRememberMe
        '
        Me.ckBoxRememberMe.BackColor = System.Drawing.Color.Transparent
        Me.ckBoxRememberMe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ckBoxRememberMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ckBoxRememberMe.ForeColor = System.Drawing.Color.White
        Me.ckBoxRememberMe.Location = New System.Drawing.Point(80, 315)
        Me.ckBoxRememberMe.Name = "ckBoxRememberMe"
        Me.ckBoxRememberMe.Size = New System.Drawing.Size(240, 25)
        Me.ckBoxRememberMe.TabIndex = 9
        Me.ckBoxRememberMe.Text = "Remember Login"
        Me.ckBoxRememberMe.UseVisualStyleBackColor = False
        '
        'lblCreaAcc
        '
        Me.lblCreaAcc.AutoSize = True
        Me.lblCreaAcc.BackColor = System.Drawing.Color.Transparent
        Me.lblCreaAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCreaAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCreaAcc.ForeColor = System.Drawing.Color.White
        Me.lblCreaAcc.Location = New System.Drawing.Point(80, 400)
        Me.lblCreaAcc.Name = "lblCreaAcc"
        Me.lblCreaAcc.Size = New System.Drawing.Size(151, 16)
        Me.lblCreaAcc.TabIndex = 18
        Me.lblCreaAcc.Text = "- I don't have an account"
        '
        'lblResetAcc
        '
        Me.lblResetAcc.AutoSize = True
        Me.lblResetAcc.BackColor = System.Drawing.Color.Transparent
        Me.lblResetAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResetAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblResetAcc.ForeColor = System.Drawing.Color.White
        Me.lblResetAcc.Location = New System.Drawing.Point(80, 430)
        Me.lblResetAcc.Name = "lblResetAcc"
        Me.lblResetAcc.Size = New System.Drawing.Size(138, 16)
        Me.lblResetAcc.TabIndex = 19
        Me.lblResetAcc.Text = "- I forgot my password"
        '
        'txtLogin
        '
        Me.txtLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtLogin.ForeColor = System.Drawing.Color.Gray
        Me.txtLogin.Location = New System.Drawing.Point(80, 195)
        Me.txtLogin.Multiline = True
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(240, 25)
        Me.txtLogin.TabIndex = 20
        Me.txtLogin.Text = "USERNAME OR EMAIL"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.Location = New System.Drawing.Point(80, 265)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(212, 20)
        Me.txtPassword.TabIndex = 21
        Me.txtPassword.Text = "PASSWORD"
        '
        'panelPass
        '
        Me.panelPass.BackColor = System.Drawing.Color.White
        Me.panelPass.Location = New System.Drawing.Point(80, 290)
        Me.panelPass.Name = "panelPass"
        Me.panelPass.Size = New System.Drawing.Size(240, 1)
        Me.panelPass.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(170, 470)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "B.S 2020"
        '
        'myMoveForm
        '
        Me.myMoveForm.BackColor = System.Drawing.Color.Transparent
        Me.myMoveForm.Location = New System.Drawing.Point(1, 0)
        Me.myMoveForm.Name = "myMoveForm"
        Me.myMoveForm.Size = New System.Drawing.Size(399, 33)
        Me.myMoveForm.TabIndex = 29
        '
        'AppLogo
        '
        Me.AppLogo.BackColor = System.Drawing.Color.Transparent
        Me.AppLogo.Image = CType(resources.GetObject("AppLogo.Image"), System.Drawing.Image)
        Me.AppLogo.Location = New System.Drawing.Point(150, 35)
        Me.AppLogo.Name = "AppLogo"
        Me.AppLogo.Size = New System.Drawing.Size(115, 110)
        Me.AppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppLogo.TabIndex = 32
        Me.AppLogo.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(80, 170)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(136, 15)
        Me.lblLogin.TabIndex = 33
        Me.lblLogin.Text = "USERNAME OR EMAIL"
        Me.lblLogin.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(80, 240)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(76, 15)
        Me.lblPassword.TabIndex = 34
        Me.lblPassword.Text = "PASSWORD"
        Me.lblPassword.Visible = False
        '
        'panelLogin
        '
        Me.panelLogin.BackColor = System.Drawing.Color.White
        Me.panelLogin.Location = New System.Drawing.Point(80, 220)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(240, 1)
        Me.panelLogin.TabIndex = 23
        '
        'lblErroreMsg
        '
        Me.lblErroreMsg.AutoSize = True
        Me.lblErroreMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblErroreMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblErroreMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblErroreMsg.Location = New System.Drawing.Point(129, 146)
        Me.lblErroreMsg.Name = "lblErroreMsg"
        Me.lblErroreMsg.Size = New System.Drawing.Size(151, 15)
        Me.lblErroreMsg.TabIndex = 63
        Me.lblErroreMsg.Text = "Wrong Password or Login!"
        Me.lblErroreMsg.Visible = False
        '
        'confLogin
        '
        Me.confLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confLogin.ForeColor = System.Drawing.Color.Transparent
        Me.confLogin.Location = New System.Drawing.Point(35, 195)
        Me.confLogin.Name = "confLogin"
        Me.confLogin.Size = New System.Drawing.Size(25, 25)
        Me.confLogin.TabIndex = 64
        Me.confLogin.Text = "✖"
        Me.confLogin.Visible = False
        '
        'confPassword
        '
        Me.confPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confPassword.ForeColor = System.Drawing.Color.Transparent
        Me.confPassword.Location = New System.Drawing.Point(35, 265)
        Me.confPassword.Name = "confPassword"
        Me.confPassword.Size = New System.Drawing.Size(25, 25)
        Me.confPassword.TabIndex = 65
        Me.confPassword.Text = "✖"
        Me.confPassword.Visible = False
        '
        'btnSeePassword
        '
        Me.btnSeePassword.BackColor = System.Drawing.Color.Transparent
        Me.btnSeePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.btnSeePassword.IconColor = System.Drawing.Color.White
        Me.btnSeePassword.IconSize = 25
        Me.btnSeePassword.Location = New System.Drawing.Point(298, 260)
        Me.btnSeePassword.Name = "btnSeePassword"
        Me.btnSeePassword.Size = New System.Drawing.Size(25, 25)
        Me.btnSeePassword.TabIndex = 66
        Me.btnSeePassword.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnExit.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnExit.IconSize = 20
        Me.btnExit.Location = New System.Drawing.Point(375, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 20)
        Me.btnExit.TabIndex = 67
        Me.btnExit.TabStop = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.Transparent
        Me.btnHide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnHide.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btnHide.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnHide.IconSize = 20
        Me.btnHide.Location = New System.Drawing.Point(349, 7)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(20, 20)
        Me.btnHide.TabIndex = 68
        Me.btnHide.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnLogin.BorderSize = 1
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnLogin.Location = New System.Drawing.Point(80, 350)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Radius = 5
        Me.btnLogin.Size = New System.Drawing.Size(240, 40)
        Me.btnLogin.TabIndex = 69
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(400, 500)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSeePassword)
        Me.Controls.Add(Me.confPassword)
        Me.Controls.Add(Me.confLogin)
        Me.Controls.Add(Me.lblErroreMsg)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.AppLogo)
        Me.Controls.Add(Me.myMoveForm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelLogin)
        Me.Controls.Add(Me.panelPass)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.lblResetAcc)
        Me.Controls.Add(Me.lblCreaAcc)
        Me.Controls.Add(Me.ckBoxRememberMe)
        Me.Controls.Add(Me.TextBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.AppLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSeePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ckBoxRememberMe As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblCreaAcc As Label
    Friend WithEvents lblResetAcc As Label
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents panelPass As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents myMoveForm As Label
    Friend WithEvents AppLogo As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents panelLogin As Panel
    Friend WithEvents lblErroreMsg As Label
    Friend WithEvents confLogin As Label
    Friend WithEvents confPassword As Label
    Friend WithEvents btnSeePassword As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnExit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnHide As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaButton
End Class
