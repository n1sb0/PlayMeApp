<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassRecForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PassRecForm))
        Me.lblCreaAcc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlEmail = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnVerifyCode = New System.Windows.Forms.Button()
        Me.pnlCode = New System.Windows.Forms.Panel()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.confCode = New System.Windows.Forms.Label()
        Me.lblMsgComfCode = New System.Windows.Forms.Label()
        Me.lblMsgEmail = New System.Windows.Forms.Label()
        Me.confEmail = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblMsgNewPassword = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.confNewPassword = New System.Windows.Forms.Label()
        Me.pnlNewPassword = New System.Windows.Forms.Panel()
        Me.txtConfPassword = New System.Windows.Forms.TextBox()
        Me.pnlConfPassword = New System.Windows.Forms.Panel()
        Me.lblMsgConfPassword = New System.Windows.Forms.Label()
        Me.lblConfPassword = New System.Windows.Forms.Label()
        Me.confConfPassword = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlVirCode = New System.Windows.Forms.Panel()
        Me.btnSeeNewPassword = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSeeConfPassword = New FontAwesome.Sharp.IconPictureBox()
        Me.btnComeBack = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlVirCode.SuspendLayout()
        CType(Me.btnSeeNewPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSeeConfPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnComeBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCreaAcc
        '
        Me.lblCreaAcc.AutoSize = True
        Me.lblCreaAcc.BackColor = System.Drawing.Color.Transparent
        Me.lblCreaAcc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCreaAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCreaAcc.ForeColor = System.Drawing.Color.White
        Me.lblCreaAcc.Location = New System.Drawing.Point(85, 75)
        Me.lblCreaAcc.Name = "lblCreaAcc"
        Me.lblCreaAcc.Size = New System.Drawing.Size(332, 31)
        Me.lblCreaAcc.TabIndex = 32
        Me.lblCreaAcc.Text = "PASSWORD RECOVERY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(110, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Enter your email and we'll send you password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(180, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "recovery instructions."
        '
        'pnlEmail
        '
        Me.pnlEmail.BackColor = System.Drawing.Color.White
        Me.pnlEmail.Location = New System.Drawing.Point(66, 270)
        Me.pnlEmail.Name = "pnlEmail"
        Me.pnlEmail.Size = New System.Drawing.Size(350, 1)
        Me.pnlEmail.TabIndex = 36
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Gray
        Me.txtEmail.Location = New System.Drawing.Point(66, 240)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(350, 25)
        Me.txtEmail.TabIndex = 35
        Me.txtEmail.Text = "EMAIL ADDRESS"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnSubmit.Location = New System.Drawing.Point(66, 350)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(350, 50)
        Me.btnSubmit.TabIndex = 37
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(66, 210)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(104, 15)
        Me.lblEmail.TabIndex = 38
        Me.lblEmail.Text = "EMAIL ADDRESS"
        Me.lblEmail.Visible = False
        '
        'btnVerifyCode
        '
        Me.btnVerifyCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnVerifyCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnVerifyCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerifyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerifyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnVerifyCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnVerifyCode.Location = New System.Drawing.Point(66, 130)
        Me.btnVerifyCode.Name = "btnVerifyCode"
        Me.btnVerifyCode.Size = New System.Drawing.Size(350, 50)
        Me.btnVerifyCode.TabIndex = 40
        Me.btnVerifyCode.Text = "VERIFY CODE"
        Me.btnVerifyCode.UseVisualStyleBackColor = False
        '
        'pnlCode
        '
        Me.pnlCode.BackColor = System.Drawing.Color.White
        Me.pnlCode.Location = New System.Drawing.Point(66, 69)
        Me.pnlCode.Name = "pnlCode"
        Me.pnlCode.Size = New System.Drawing.Size(350, 1)
        Me.pnlCode.TabIndex = 42
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtCode.ForeColor = System.Drawing.Color.Gray
        Me.txtCode.Location = New System.Drawing.Point(66, 39)
        Me.txtCode.Multiline = True
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(350, 25)
        Me.txtCode.TabIndex = 41
        Me.txtCode.Text = "CODE"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.White
        Me.lblCode.Location = New System.Drawing.Point(66, 9)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(41, 15)
        Me.lblCode.TabIndex = 43
        Me.lblCode.Text = "CODE"
        Me.lblCode.Visible = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnChangePassword.Location = New System.Drawing.Point(566, 505)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(350, 50)
        Me.btnChangePassword.TabIndex = 50
        Me.btnChangePassword.Text = "CHANGE PASSWORD"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(560, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 31)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "CREAT NEW PASSWORD"
        '
        'confCode
        '
        Me.confCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confCode.ForeColor = System.Drawing.Color.Transparent
        Me.confCode.Location = New System.Drawing.Point(16, 44)
        Me.confCode.Name = "confCode"
        Me.confCode.Size = New System.Drawing.Size(25, 25)
        Me.confCode.TabIndex = 60
        Me.confCode.Text = "✖"
        Me.confCode.Visible = False
        '
        'lblMsgComfCode
        '
        Me.lblMsgComfCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgComfCode.ForeColor = System.Drawing.Color.White
        Me.lblMsgComfCode.Location = New System.Drawing.Point(16, 73)
        Me.lblMsgComfCode.Name = "lblMsgComfCode"
        Me.lblMsgComfCode.Size = New System.Drawing.Size(154, 15)
        Me.lblMsgComfCode.TabIndex = 84
        Me.lblMsgComfCode.Text = "Wrong Confirm Code"
        Me.lblMsgComfCode.Visible = False
        '
        'lblMsgEmail
        '
        Me.lblMsgEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgEmail.ForeColor = System.Drawing.Color.White
        Me.lblMsgEmail.Location = New System.Drawing.Point(16, 274)
        Me.lblMsgEmail.Name = "lblMsgEmail"
        Me.lblMsgEmail.Size = New System.Drawing.Size(257, 15)
        Me.lblMsgEmail.TabIndex = 85
        Me.lblMsgEmail.Text = "Be careful to write your Email correct."
        Me.lblMsgEmail.Visible = False
        '
        'confEmail
        '
        Me.confEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confEmail.ForeColor = System.Drawing.Color.Transparent
        Me.confEmail.Location = New System.Drawing.Point(16, 240)
        Me.confEmail.Name = "confEmail"
        Me.confEmail.Size = New System.Drawing.Size(25, 25)
        Me.confEmail.TabIndex = 98
        Me.confEmail.Text = "✖"
        Me.confEmail.Visible = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtNewPassword.Location = New System.Drawing.Point(566, 230)
        Me.txtNewPassword.Multiline = True
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(320, 25)
        Me.txtNewPassword.TabIndex = 104
        Me.txtNewPassword.Text = "NEW PASSWORD"
        '
        'lblMsgNewPassword
        '
        Me.lblMsgNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblMsgNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgNewPassword.ForeColor = System.Drawing.Color.White
        Me.lblMsgNewPassword.Location = New System.Drawing.Point(516, 264)
        Me.lblMsgNewPassword.Name = "lblMsgNewPassword"
        Me.lblMsgNewPassword.Size = New System.Drawing.Size(350, 40)
        Me.lblMsgNewPassword.TabIndex = 105
        Me.lblMsgNewPassword.Text = "Your password must contain:"
        Me.lblMsgNewPassword.Visible = False
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblNewPassword.ForeColor = System.Drawing.Color.White
        Me.lblNewPassword.Location = New System.Drawing.Point(562, 200)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(107, 15)
        Me.lblNewPassword.TabIndex = 106
        Me.lblNewPassword.Text = "NEW PASSWORD"
        Me.lblNewPassword.Visible = False
        '
        'confNewPassword
        '
        Me.confNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.confNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confNewPassword.ForeColor = System.Drawing.Color.White
        Me.confNewPassword.Location = New System.Drawing.Point(516, 230)
        Me.confNewPassword.Name = "confNewPassword"
        Me.confNewPassword.Size = New System.Drawing.Size(25, 25)
        Me.confNewPassword.TabIndex = 107
        Me.confNewPassword.Text = "✖"
        Me.confNewPassword.Visible = False
        '
        'pnlNewPassword
        '
        Me.pnlNewPassword.BackColor = System.Drawing.Color.White
        Me.pnlNewPassword.Location = New System.Drawing.Point(566, 260)
        Me.pnlNewPassword.Name = "pnlNewPassword"
        Me.pnlNewPassword.Size = New System.Drawing.Size(350, 1)
        Me.pnlNewPassword.TabIndex = 108
        '
        'txtConfPassword
        '
        Me.txtConfPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtConfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtConfPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtConfPassword.Location = New System.Drawing.Point(566, 370)
        Me.txtConfPassword.Multiline = True
        Me.txtConfPassword.Name = "txtConfPassword"
        Me.txtConfPassword.Size = New System.Drawing.Size(320, 25)
        Me.txtConfPassword.TabIndex = 109
        Me.txtConfPassword.Text = "CONFIRM PASSWORD"
        '
        'pnlConfPassword
        '
        Me.pnlConfPassword.BackColor = System.Drawing.Color.White
        Me.pnlConfPassword.Location = New System.Drawing.Point(566, 400)
        Me.pnlConfPassword.Name = "pnlConfPassword"
        Me.pnlConfPassword.Size = New System.Drawing.Size(350, 1)
        Me.pnlConfPassword.TabIndex = 110
        '
        'lblMsgConfPassword
        '
        Me.lblMsgConfPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgConfPassword.ForeColor = System.Drawing.Color.White
        Me.lblMsgConfPassword.Location = New System.Drawing.Point(516, 404)
        Me.lblMsgConfPassword.Name = "lblMsgConfPassword"
        Me.lblMsgConfPassword.Size = New System.Drawing.Size(225, 23)
        Me.lblMsgConfPassword.TabIndex = 111
        Me.lblMsgConfPassword.Text = "Wrong Confirm Password"
        Me.lblMsgConfPassword.Visible = False
        '
        'lblConfPassword
        '
        Me.lblConfPassword.AutoSize = True
        Me.lblConfPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblConfPassword.ForeColor = System.Drawing.Color.White
        Me.lblConfPassword.Location = New System.Drawing.Point(566, 340)
        Me.lblConfPassword.Name = "lblConfPassword"
        Me.lblConfPassword.Size = New System.Drawing.Size(135, 15)
        Me.lblConfPassword.TabIndex = 112
        Me.lblConfPassword.Text = "CONFIRM PASSWORD"
        Me.lblConfPassword.Visible = False
        '
        'confConfPassword
        '
        Me.confConfPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confConfPassword.ForeColor = System.Drawing.Color.White
        Me.confConfPassword.Location = New System.Drawing.Point(516, 370)
        Me.confConfPassword.Name = "confConfPassword"
        Me.confConfPassword.Size = New System.Drawing.Size(25, 25)
        Me.confConfPassword.TabIndex = 113
        Me.confConfPassword.Text = "✖"
        Me.confConfPassword.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(500, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 600)
        Me.Panel1.TabIndex = 37
        '
        'pnlVirCode
        '
        Me.pnlVirCode.BackColor = System.Drawing.Color.Transparent
        Me.pnlVirCode.Controls.Add(Me.txtCode)
        Me.pnlVirCode.Controls.Add(Me.lblMsgComfCode)
        Me.pnlVirCode.Controls.Add(Me.confCode)
        Me.pnlVirCode.Controls.Add(Me.lblCode)
        Me.pnlVirCode.Controls.Add(Me.pnlCode)
        Me.pnlVirCode.Controls.Add(Me.btnVerifyCode)
        Me.pnlVirCode.Location = New System.Drawing.Point(0, 436)
        Me.pnlVirCode.Name = "pnlVirCode"
        Me.pnlVirCode.Size = New System.Drawing.Size(494, 214)
        Me.pnlVirCode.TabIndex = 114
        Me.pnlVirCode.Visible = False
        '
        'btnSeeNewPassword
        '
        Me.btnSeeNewPassword.BackColor = System.Drawing.Color.Transparent
        Me.btnSeeNewPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeeNewPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.btnSeeNewPassword.IconColor = System.Drawing.Color.White
        Me.btnSeeNewPassword.IconSize = 30
        Me.btnSeeNewPassword.Location = New System.Drawing.Point(886, 224)
        Me.btnSeeNewPassword.Name = "btnSeeNewPassword"
        Me.btnSeeNewPassword.Size = New System.Drawing.Size(30, 30)
        Me.btnSeeNewPassword.TabIndex = 115
        Me.btnSeeNewPassword.TabStop = False
        '
        'btnSeeConfPassword
        '
        Me.btnSeeConfPassword.BackColor = System.Drawing.Color.Transparent
        Me.btnSeeConfPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeeConfPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.btnSeeConfPassword.IconColor = System.Drawing.Color.White
        Me.btnSeeConfPassword.IconSize = 30
        Me.btnSeeConfPassword.Location = New System.Drawing.Point(886, 364)
        Me.btnSeeConfPassword.Name = "btnSeeConfPassword"
        Me.btnSeeConfPassword.Size = New System.Drawing.Size(30, 30)
        Me.btnSeeConfPassword.TabIndex = 116
        Me.btnSeeConfPassword.TabStop = False
        '
        'btnComeBack
        '
        Me.btnComeBack.BackColor = System.Drawing.Color.Transparent
        Me.btnComeBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComeBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnComeBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnComeBack.IconColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnComeBack.IconSize = 30
        Me.btnComeBack.Location = New System.Drawing.Point(10, 10)
        Me.btnComeBack.Name = "btnComeBack"
        Me.btnComeBack.Size = New System.Drawing.Size(30, 30)
        Me.btnComeBack.TabIndex = 117
        Me.btnComeBack.TabStop = False
        '
        'PassRecForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.btnComeBack)
        Me.Controls.Add(Me.btnSeeConfPassword)
        Me.Controls.Add(Me.btnSeeNewPassword)
        Me.Controls.Add(Me.pnlVirCode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblCreaAcc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.confConfPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblConfPassword)
        Me.Controls.Add(Me.pnlEmail)
        Me.Controls.Add(Me.lblMsgConfPassword)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.pnlConfPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtConfPassword)
        Me.Controls.Add(Me.pnlNewPassword)
        Me.Controls.Add(Me.confNewPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.lblMsgNewPassword)
        Me.Controls.Add(Me.confEmail)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.lblMsgEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChangePassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PassRecForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Recovery Form"
        Me.pnlVirCode.ResumeLayout(False)
        Me.pnlVirCode.PerformLayout()
        CType(Me.btnSeeNewPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSeeConfPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnComeBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCreaAcc As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlEmail As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnVerifyCode As Button
    Friend WithEvents pnlCode As Panel
    Friend WithEvents txtCode As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents confCode As Label
    Friend WithEvents lblMsgComfCode As Label
    Friend WithEvents lblMsgEmail As Label
    Friend WithEvents confEmail As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblMsgNewPassword As Label
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents confNewPassword As Label
    Friend WithEvents pnlNewPassword As Panel
    Friend WithEvents txtConfPassword As TextBox
    Friend WithEvents pnlConfPassword As Panel
    Friend WithEvents lblMsgConfPassword As Label
    Friend WithEvents lblConfPassword As Label
    Friend WithEvents confConfPassword As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlVirCode As Panel
    Friend WithEvents btnSeeNewPassword As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnSeeConfPassword As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnComeBack As FontAwesome.Sharp.IconPictureBox
End Class
