<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelPass = New System.Windows.Forms.Panel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblCreaAcc = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.panelLogin = New System.Windows.Forms.Panel()
        Me.pnlEmail = New System.Windows.Forms.Panel()
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.pnlConfPass = New System.Windows.Forms.Panel()
        Me.pnlUserName = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.confEmail = New System.Windows.Forms.Label()
        Me.confPass = New System.Windows.Forms.Label()
        Me.confConfPass = New System.Windows.Forms.Label()
        Me.confUserName = New System.Windows.Forms.Label()
        Me.confData = New System.Windows.Forms.Label()
        Me.confPrivicy = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.pnlLoad = New System.Windows.Forms.Panel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblConfPass = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMoth = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.cmbBoxDay = New System.Windows.Forms.ComboBox()
        Me.cmbBoxMonth = New System.Windows.Forms.ComboBox()
        Me.cmbBoxYear = New System.Windows.Forms.ComboBox()
        Me.ckBoxPrivacy = New System.Windows.Forms.CheckBox()
        Me.ckBoxMail = New System.Windows.Forms.CheckBox()
        Me.lblMsgPass = New System.Windows.Forms.Label()
        Me.lblMsgEmail = New System.Windows.Forms.Label()
        Me.lblMsgConfPass = New System.Windows.Forms.Label()
        Me.lblMsgUserName = New System.Windows.Forms.Label()
        Me.btnSeeConfPassword = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSeePassword = New FontAwesome.Sharp.IconPictureBox()
        Me.btnComeBack = New FontAwesome.Sharp.IconPictureBox()
        Me.btnContinue = New Guna.UI.WinForms.GunaButton()
        Me.Panel8.SuspendLayout()
        CType(Me.btnSeeConfPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSeePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnComeBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(295, 870)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "B.S 2020"
        '
        'panelPass
        '
        Me.panelPass.Location = New System.Drawing.Point(188, 175)
        Me.panelPass.Name = "panelPass"
        Me.panelPass.Size = New System.Drawing.Size(240, 1)
        Me.panelPass.TabIndex = 32
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Gray
        Me.txtEmail.Location = New System.Drawing.Point(175, 150)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(300, 25)
        Me.txtEmail.TabIndex = 31
        Me.txtEmail.Text = "EMAIL ADDRESS"
        '
        'lblCreaAcc
        '
        Me.lblCreaAcc.AutoSize = True
        Me.lblCreaAcc.BackColor = System.Drawing.Color.Transparent
        Me.lblCreaAcc.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblCreaAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCreaAcc.ForeColor = System.Drawing.Color.White
        Me.lblCreaAcc.Location = New System.Drawing.Point(124, 43)
        Me.lblCreaAcc.Name = "lblCreaAcc"
        Me.lblCreaAcc.Size = New System.Drawing.Size(401, 31)
        Me.lblCreaAcc.TabIndex = 30
        Me.lblCreaAcc.Text = "HELLO, NICE TO MEET YOU :)"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.Location = New System.Drawing.Point(175, 240)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(271, 25)
        Me.txtPassword.TabIndex = 36
        Me.txtPassword.Text = "PASSWORD"
        '
        'txtConfPassword
        '
        Me.txtConfPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtConfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConfPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtConfPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtConfPassword.Location = New System.Drawing.Point(175, 330)
        Me.txtConfPassword.Multiline = True
        Me.txtConfPassword.Name = "txtConfPassword"
        Me.txtConfPassword.Size = New System.Drawing.Size(271, 25)
        Me.txtConfPassword.TabIndex = 37
        Me.txtConfPassword.Text = "CONFIRM PASSWORD"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.Gray
        Me.txtUserName.Location = New System.Drawing.Point(175, 420)
        Me.txtUserName.Multiline = True
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(300, 25)
        Me.txtUserName.TabIndex = 38
        Me.txtUserName.Text = "USERNAME"
        '
        'panelLogin
        '
        Me.panelLogin.Location = New System.Drawing.Point(177, 172)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(300, 1)
        Me.panelLogin.TabIndex = 42
        '
        'pnlEmail
        '
        Me.pnlEmail.BackColor = System.Drawing.Color.White
        Me.pnlEmail.Location = New System.Drawing.Point(175, 180)
        Me.pnlEmail.Name = "pnlEmail"
        Me.pnlEmail.Size = New System.Drawing.Size(300, 1)
        Me.pnlEmail.TabIndex = 45
        '
        'pnlPass
        '
        Me.pnlPass.BackColor = System.Drawing.Color.White
        Me.pnlPass.Location = New System.Drawing.Point(175, 270)
        Me.pnlPass.Name = "pnlPass"
        Me.pnlPass.Size = New System.Drawing.Size(300, 1)
        Me.pnlPass.TabIndex = 46
        '
        'pnlConfPass
        '
        Me.pnlConfPass.BackColor = System.Drawing.Color.White
        Me.pnlConfPass.Location = New System.Drawing.Point(175, 360)
        Me.pnlConfPass.Name = "pnlConfPass"
        Me.pnlConfPass.Size = New System.Drawing.Size(300, 1)
        Me.pnlConfPass.TabIndex = 46
        '
        'pnlUserName
        '
        Me.pnlUserName.BackColor = System.Drawing.Color.White
        Me.pnlUserName.Location = New System.Drawing.Point(175, 450)
        Me.pnlUserName.Name = "pnlUserName"
        Me.pnlUserName.Size = New System.Drawing.Size(300, 1)
        Me.pnlUserName.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(175, 560)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(85, 1)
        Me.Panel2.TabIndex = 48
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(282, 560)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(85, 1)
        Me.Panel6.TabIndex = 49
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(390, 560)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(85, 1)
        Me.Panel7.TabIndex = 50
        '
        'confEmail
        '
        Me.confEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confEmail.ForeColor = System.Drawing.Color.Transparent
        Me.confEmail.Location = New System.Drawing.Point(125, 150)
        Me.confEmail.Name = "confEmail"
        Me.confEmail.Size = New System.Drawing.Size(25, 25)
        Me.confEmail.TabIndex = 59
        Me.confEmail.Text = "✖"
        Me.confEmail.Visible = False
        '
        'confPass
        '
        Me.confPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confPass.ForeColor = System.Drawing.Color.Transparent
        Me.confPass.Location = New System.Drawing.Point(125, 240)
        Me.confPass.Name = "confPass"
        Me.confPass.Size = New System.Drawing.Size(25, 25)
        Me.confPass.TabIndex = 60
        Me.confPass.Text = "✖"
        Me.confPass.Visible = False
        '
        'confConfPass
        '
        Me.confConfPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confConfPass.ForeColor = System.Drawing.Color.Transparent
        Me.confConfPass.Location = New System.Drawing.Point(125, 330)
        Me.confConfPass.Name = "confConfPass"
        Me.confConfPass.Size = New System.Drawing.Size(25, 25)
        Me.confConfPass.TabIndex = 61
        Me.confConfPass.Text = "✖"
        Me.confConfPass.Visible = False
        '
        'confUserName
        '
        Me.confUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confUserName.ForeColor = System.Drawing.Color.Transparent
        Me.confUserName.Location = New System.Drawing.Point(125, 420)
        Me.confUserName.Name = "confUserName"
        Me.confUserName.Size = New System.Drawing.Size(25, 25)
        Me.confUserName.TabIndex = 62
        Me.confUserName.Text = "✖"
        Me.confUserName.Visible = False
        '
        'confData
        '
        Me.confData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confData.ForeColor = System.Drawing.Color.Transparent
        Me.confData.Location = New System.Drawing.Point(125, 520)
        Me.confData.Name = "confData"
        Me.confData.Size = New System.Drawing.Size(25, 25)
        Me.confData.TabIndex = 63
        Me.confData.Text = "✖"
        Me.confData.Visible = False
        '
        'confPrivicy
        '
        Me.confPrivicy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.confPrivicy.ForeColor = System.Drawing.Color.Transparent
        Me.confPrivicy.Location = New System.Drawing.Point(125, 600)
        Me.confPrivicy.Name = "confPrivicy"
        Me.confPrivicy.Size = New System.Drawing.Size(25, 25)
        Me.confPrivicy.TabIndex = 64
        Me.confPrivicy.Text = "✖"
        Me.confPrivicy.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.pnlLoad)
        Me.Panel8.Location = New System.Drawing.Point(145, 725)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(360, 1)
        Me.Panel8.TabIndex = 47
        '
        'pnlLoad
        '
        Me.pnlLoad.BackColor = System.Drawing.Color.White
        Me.pnlLoad.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoad.Name = "pnlLoad"
        Me.pnlLoad.Size = New System.Drawing.Size(0, 5)
        Me.pnlLoad.TabIndex = 48
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(175, 120)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(104, 15)
        Me.lblEmail.TabIndex = 65
        Me.lblEmail.Text = "EMAIL ADDRESS"
        Me.lblEmail.Visible = False
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.White
        Me.lblPass.Location = New System.Drawing.Point(175, 210)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(76, 15)
        Me.lblPass.TabIndex = 66
        Me.lblPass.Text = "PASSWORD"
        Me.lblPass.Visible = False
        '
        'lblConfPass
        '
        Me.lblConfPass.AutoSize = True
        Me.lblConfPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblConfPass.ForeColor = System.Drawing.Color.White
        Me.lblConfPass.Location = New System.Drawing.Point(175, 300)
        Me.lblConfPass.Name = "lblConfPass"
        Me.lblConfPass.Size = New System.Drawing.Size(135, 15)
        Me.lblConfPass.TabIndex = 67
        Me.lblConfPass.Text = "CONFIRM PASSWORD"
        Me.lblConfPass.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(175, 390)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(76, 15)
        Me.lblUserName.TabIndex = 68
        Me.lblUserName.Text = "USERNAME"
        Me.lblUserName.Visible = False
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.White
        Me.lblYear.Location = New System.Drawing.Point(390, 485)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(38, 15)
        Me.lblYear.TabIndex = 69
        Me.lblYear.Text = "YEAR"
        Me.lblYear.Visible = False
        '
        'lblMoth
        '
        Me.lblMoth.AutoSize = True
        Me.lblMoth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMoth.ForeColor = System.Drawing.Color.White
        Me.lblMoth.Location = New System.Drawing.Point(282, 485)
        Me.lblMoth.Name = "lblMoth"
        Me.lblMoth.Size = New System.Drawing.Size(52, 15)
        Me.lblMoth.TabIndex = 70
        Me.lblMoth.Text = "MONTH"
        Me.lblMoth.Visible = False
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.White
        Me.lblDay.Location = New System.Drawing.Point(175, 485)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(30, 15)
        Me.lblDay.TabIndex = 71
        Me.lblDay.Text = "DAY"
        Me.lblDay.Visible = False
        '
        'cmbBoxDay
        '
        Me.cmbBoxDay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbBoxDay.DropDownHeight = 150
        Me.cmbBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmbBoxDay.ForeColor = System.Drawing.Color.White
        Me.cmbBoxDay.FormattingEnabled = True
        Me.cmbBoxDay.IntegralHeight = False
        Me.cmbBoxDay.ItemHeight = 20
        Me.cmbBoxDay.Items.AddRange(New Object() {"DAY", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbBoxDay.Location = New System.Drawing.Point(175, 520)
        Me.cmbBoxDay.MaxDropDownItems = 5
        Me.cmbBoxDay.Name = "cmbBoxDay"
        Me.cmbBoxDay.Size = New System.Drawing.Size(85, 28)
        Me.cmbBoxDay.TabIndex = 73
        '
        'cmbBoxMonth
        '
        Me.cmbBoxMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbBoxMonth.DropDownHeight = 150
        Me.cmbBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmbBoxMonth.ForeColor = System.Drawing.Color.White
        Me.cmbBoxMonth.FormattingEnabled = True
        Me.cmbBoxMonth.IntegralHeight = False
        Me.cmbBoxMonth.ItemHeight = 20
        Me.cmbBoxMonth.Items.AddRange(New Object() {"MONTH", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbBoxMonth.Location = New System.Drawing.Point(282, 520)
        Me.cmbBoxMonth.Name = "cmbBoxMonth"
        Me.cmbBoxMonth.Size = New System.Drawing.Size(85, 28)
        Me.cmbBoxMonth.TabIndex = 74
        '
        'cmbBoxYear
        '
        Me.cmbBoxYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbBoxYear.DropDownHeight = 150
        Me.cmbBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.cmbBoxYear.ForeColor = System.Drawing.Color.White
        Me.cmbBoxYear.FormattingEnabled = True
        Me.cmbBoxYear.IntegralHeight = False
        Me.cmbBoxYear.ItemHeight = 20
        Me.cmbBoxYear.Items.AddRange(New Object() {"YEAR", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925"})
        Me.cmbBoxYear.Location = New System.Drawing.Point(390, 520)
        Me.cmbBoxYear.Name = "cmbBoxYear"
        Me.cmbBoxYear.Size = New System.Drawing.Size(85, 28)
        Me.cmbBoxYear.TabIndex = 75
        '
        'ckBoxPrivacy
        '
        Me.ckBoxPrivacy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ckBoxPrivacy.ForeColor = System.Drawing.Color.White
        Me.ckBoxPrivacy.Location = New System.Drawing.Point(175, 589)
        Me.ckBoxPrivacy.Name = "ckBoxPrivacy"
        Me.ckBoxPrivacy.Size = New System.Drawing.Size(316, 46)
        Me.ckBoxPrivacy.TabIndex = 76
        Me.ckBoxPrivacy.Text = "I agree to the Terms of service and I have read and understood thePrivacy Policy." &
    "(Required)"
        Me.ckBoxPrivacy.UseVisualStyleBackColor = True
        '
        'ckBoxMail
        '
        Me.ckBoxMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ckBoxMail.ForeColor = System.Drawing.Color.White
        Me.ckBoxMail.Location = New System.Drawing.Point(175, 650)
        Me.ckBoxMail.Name = "ckBoxMail"
        Me.ckBoxMail.Size = New System.Drawing.Size(302, 55)
        Me.ckBoxMail.TabIndex = 77
        Me.ckBoxMail.Text = "This App can email me occasionally to let me know about news and limited time swa" &
    "g I can earn (Optional)"
        Me.ckBoxMail.UseVisualStyleBackColor = True
        '
        'lblMsgPass
        '
        Me.lblMsgPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgPass.ForeColor = System.Drawing.Color.White
        Me.lblMsgPass.Location = New System.Drawing.Point(125, 274)
        Me.lblMsgPass.Name = "lblMsgPass"
        Me.lblMsgPass.Size = New System.Drawing.Size(513, 15)
        Me.lblMsgPass.TabIndex = 80
        Me.lblMsgPass.Text = "Your password must contain:"
        Me.lblMsgPass.Visible = False
        '
        'lblMsgEmail
        '
        Me.lblMsgEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgEmail.ForeColor = System.Drawing.Color.White
        Me.lblMsgEmail.Location = New System.Drawing.Point(125, 184)
        Me.lblMsgEmail.Name = "lblMsgEmail"
        Me.lblMsgEmail.Size = New System.Drawing.Size(274, 15)
        Me.lblMsgEmail.TabIndex = 81
        Me.lblMsgEmail.Text = "Be careful to write your Email correct."
        Me.lblMsgEmail.Visible = False
        '
        'lblMsgConfPass
        '
        Me.lblMsgConfPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgConfPass.ForeColor = System.Drawing.Color.White
        Me.lblMsgConfPass.Location = New System.Drawing.Point(125, 364)
        Me.lblMsgConfPass.Name = "lblMsgConfPass"
        Me.lblMsgConfPass.Size = New System.Drawing.Size(154, 15)
        Me.lblMsgConfPass.TabIndex = 82
        Me.lblMsgConfPass.Text = "Wrong Confirm Password"
        Me.lblMsgConfPass.Visible = False
        '
        'lblMsgUserName
        '
        Me.lblMsgUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMsgUserName.ForeColor = System.Drawing.Color.White
        Me.lblMsgUserName.Location = New System.Drawing.Point(125, 454)
        Me.lblMsgUserName.Name = "lblMsgUserName"
        Me.lblMsgUserName.Size = New System.Drawing.Size(185, 15)
        Me.lblMsgUserName.TabIndex = 83
        Me.lblMsgUserName.Text = "This UserName already exists"
        Me.lblMsgUserName.Visible = False
        '
        'btnSeeConfPassword
        '
        Me.btnSeeConfPassword.BackColor = System.Drawing.Color.Transparent
        Me.btnSeeConfPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeeConfPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.btnSeeConfPassword.IconColor = System.Drawing.Color.White
        Me.btnSeeConfPassword.IconSize = 30
        Me.btnSeeConfPassword.Location = New System.Drawing.Point(445, 327)
        Me.btnSeeConfPassword.Name = "btnSeeConfPassword"
        Me.btnSeeConfPassword.Size = New System.Drawing.Size(30, 30)
        Me.btnSeeConfPassword.TabIndex = 118
        Me.btnSeeConfPassword.TabStop = False
        '
        'btnSeePassword
        '
        Me.btnSeePassword.BackColor = System.Drawing.Color.Transparent
        Me.btnSeePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeePassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.btnSeePassword.IconColor = System.Drawing.Color.White
        Me.btnSeePassword.IconSize = 30
        Me.btnSeePassword.Location = New System.Drawing.Point(445, 238)
        Me.btnSeePassword.Name = "btnSeePassword"
        Me.btnSeePassword.Size = New System.Drawing.Size(30, 30)
        Me.btnSeePassword.TabIndex = 117
        Me.btnSeePassword.TabStop = False
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
        Me.btnComeBack.TabIndex = 119
        Me.btnComeBack.TabStop = False
        '
        'btnContinue
        '
        Me.btnContinue.Animated = True
        Me.btnContinue.AnimationHoverSpeed = 0.07!
        Me.btnContinue.AnimationSpeed = 0.03!
        Me.btnContinue.BackColor = System.Drawing.Color.Transparent
        Me.btnContinue.BaseColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnContinue.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnContinue.BorderSize = 1
        Me.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContinue.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnContinue.FocusedColor = System.Drawing.Color.Empty
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnContinue.Image = Nothing
        Me.btnContinue.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnContinue.Location = New System.Drawing.Point(175, 770)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnContinue.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnContinue.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnContinue.OnHoverImage = Nothing
        Me.btnContinue.OnPressedColor = System.Drawing.Color.Black
        Me.btnContinue.Radius = 5
        Me.btnContinue.Size = New System.Drawing.Size(300, 50)
        Me.btnContinue.TabIndex = 120
        Me.btnContinue.Text = "CONTINUE"
        Me.btnContinue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(650, 900)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnComeBack)
        Me.Controls.Add(Me.btnSeeConfPassword)
        Me.Controls.Add(Me.btnSeePassword)
        Me.Controls.Add(Me.lblMsgUserName)
        Me.Controls.Add(Me.lblMsgConfPass)
        Me.Controls.Add(Me.lblMsgEmail)
        Me.Controls.Add(Me.lblMsgPass)
        Me.Controls.Add(Me.ckBoxMail)
        Me.Controls.Add(Me.ckBoxPrivacy)
        Me.Controls.Add(Me.cmbBoxYear)
        Me.Controls.Add(Me.cmbBoxMonth)
        Me.Controls.Add(Me.cmbBoxDay)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMoth)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblConfPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.confPrivicy)
        Me.Controls.Add(Me.confData)
        Me.Controls.Add(Me.confUserName)
        Me.Controls.Add(Me.confConfPass)
        Me.Controls.Add(Me.confPass)
        Me.Controls.Add(Me.confEmail)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlUserName)
        Me.Controls.Add(Me.pnlConfPass)
        Me.Controls.Add(Me.pnlPass)
        Me.Controls.Add(Me.pnlEmail)
        Me.Controls.Add(Me.panelLogin)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtConfPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.panelPass)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblCreaAcc)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Register Form"
        Me.Panel8.ResumeLayout(False)
        CType(Me.btnSeeConfPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSeePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnComeBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents panelPass As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblCreaAcc As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents panelLogin As Panel
    Friend WithEvents pnlEmail As Panel
    Friend WithEvents pnlPass As Panel
    Friend WithEvents pnlConfPass As Panel
    Friend WithEvents pnlUserName As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents confEmail As Label
    Friend WithEvents confPass As Label
    Friend WithEvents confConfPass As Label
    Friend WithEvents confUserName As Label
    Friend WithEvents confData As Label
    Friend WithEvents confPrivicy As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblConfPass As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents pnlLoad As Panel
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMoth As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents cmbBoxDay As ComboBox
    Friend WithEvents cmbBoxMonth As ComboBox
    Friend WithEvents cmbBoxYear As ComboBox
    Friend WithEvents ckBoxPrivacy As CheckBox
    Friend WithEvents ckBoxMail As CheckBox
    Friend WithEvents lblMsgPass As Label
    Friend WithEvents lblMsgEmail As Label
    Friend WithEvents lblMsgConfPass As Label
    Friend WithEvents lblMsgUserName As Label
    Friend WithEvents btnSeeConfPassword As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnSeePassword As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnComeBack As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnContinue As Guna.UI.WinForms.GunaButton
End Class
