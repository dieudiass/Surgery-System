<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Password = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbProvince = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblFirstnameError = New System.Windows.Forms.Label()
        Me.lblGenderError = New System.Windows.Forms.Label()
        Me.lblSurnameError = New System.Windows.Forms.Label()
        Me.lblCityError = New System.Windows.Forms.Label()
        Me.lblIDError = New System.Windows.Forms.Label()
        Me.lblProvinceError = New System.Windows.Forms.Label()
        Me.lblStreetError = New System.Windows.Forms.Label()
        Me.lblPostalError = New System.Windows.Forms.Label()
        Me.lblEmailError = New System.Windows.Forms.Label()
        Me.lblTypeError = New System.Windows.Forms.Label()
        Me.lblPasswordError = New System.Windows.Forms.Label()
        Me.lblPhoneError = New System.Windows.Forms.Label()
        Me.lblDOBError = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbSecurity = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegister
        '
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRegister.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnRegister.Location = New System.Drawing.Point(258, 597)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(141, 33)
        Me.btnRegister.TabIndex = 24
        Me.btnRegister.Text = "Save Employee"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(382, 466)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(66, 17)
        Me.Password.TabIndex = 20
        Me.Password.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 403)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 19)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Street"
        '
        'cmbProvince
        '
        Me.cmbProvince.FormattingEnabled = True
        Me.cmbProvince.Items.AddRange(New Object() {"Eastern Cape", "Free State", "Gauteng", "Kwazulu-Natal", "Limpopo", "Mpumalanga", "Northern Cape", "North West"})
        Me.cmbProvince.Location = New System.Drawing.Point(128, 286)
        Me.cmbProvince.Name = "cmbProvince"
        Me.cmbProvince.Size = New System.Drawing.Size(200, 21)
        Me.cmbProvince.TabIndex = 11
        '
        'cmbGender
        '
        Me.cmbGender.Enabled = False
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(506, 276)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(108, 21)
        Me.cmbGender.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Province"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Town"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(128, 163)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(200, 20)
        Me.txtFirstname.TabIndex = 1
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(128, 225)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(200, 20)
        Me.txtSurname.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(506, 463)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(200, 20)
        Me.txtPassword.TabIndex = 21
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(128, 402)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(200, 20)
        Me.txtStreet.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.McKelviSurgery.My.Resources.Resources.createemployee
        Me.PictureBox1.Location = New System.Drawing.Point(241, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(367, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID Number"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(481, 161)
        Me.txtIDNumber.MaxLength = 13
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(200, 20)
        Me.txtIDNumber.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 464)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Postal Code"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(128, 463)
        Me.txtZipCode.MaxLength = 5
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(81, 20)
        Me.txtZipCode.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(378, 403)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 19)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(506, 404)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(381, 339)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 19)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 532)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Phone Number"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Doctor", "Nurse", "Manager", "Receptionist"})
        Me.cmbType.Location = New System.Drawing.Point(506, 337)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(108, 21)
        Me.cmbType.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(371, 222)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "DOB"
        '
        'dtpDOB
        '
        Me.dtpDOB.Enabled = False
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(481, 222)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(108, 20)
        Me.dtpDOB.TabIndex = 38
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(128, 529)
        Me.txtPhoneNumber.MaxLength = 10
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(200, 20)
        Me.txtPhoneNumber.TabIndex = 39
        '
        'lblFirstnameError
        '
        Me.lblFirstnameError.AutoSize = True
        Me.lblFirstnameError.Location = New System.Drawing.Point(125, 199)
        Me.lblFirstnameError.Name = "lblFirstnameError"
        Me.lblFirstnameError.Size = New System.Drawing.Size(0, 13)
        Me.lblFirstnameError.TabIndex = 40
        '
        'lblGenderError
        '
        Me.lblGenderError.AutoSize = True
        Me.lblGenderError.Location = New System.Drawing.Point(125, 260)
        Me.lblGenderError.Name = "lblGenderError"
        Me.lblGenderError.Size = New System.Drawing.Size(0, 13)
        Me.lblGenderError.TabIndex = 41
        '
        'lblSurnameError
        '
        Me.lblSurnameError.AutoSize = True
        Me.lblSurnameError.Location = New System.Drawing.Point(503, 199)
        Me.lblSurnameError.Name = "lblSurnameError"
        Me.lblSurnameError.Size = New System.Drawing.Size(0, 13)
        Me.lblSurnameError.TabIndex = 42
        '
        'lblCityError
        '
        Me.lblCityError.AutoSize = True
        Me.lblCityError.Location = New System.Drawing.Point(125, 321)
        Me.lblCityError.Name = "lblCityError"
        Me.lblCityError.Size = New System.Drawing.Size(0, 13)
        Me.lblCityError.TabIndex = 43
        '
        'lblIDError
        '
        Me.lblIDError.AutoSize = True
        Me.lblIDError.Location = New System.Drawing.Point(503, 260)
        Me.lblIDError.Name = "lblIDError"
        Me.lblIDError.Size = New System.Drawing.Size(0, 13)
        Me.lblIDError.TabIndex = 44
        '
        'lblProvinceError
        '
        Me.lblProvinceError.AutoSize = True
        Me.lblProvinceError.Location = New System.Drawing.Point(503, 319)
        Me.lblProvinceError.Name = "lblProvinceError"
        Me.lblProvinceError.Size = New System.Drawing.Size(0, 13)
        Me.lblProvinceError.TabIndex = 45
        '
        'lblStreetError
        '
        Me.lblStreetError.AutoSize = True
        Me.lblStreetError.Location = New System.Drawing.Point(125, 386)
        Me.lblStreetError.Name = "lblStreetError"
        Me.lblStreetError.Size = New System.Drawing.Size(0, 13)
        Me.lblStreetError.TabIndex = 46
        '
        'lblPostalError
        '
        Me.lblPostalError.AutoSize = True
        Me.lblPostalError.Location = New System.Drawing.Point(503, 373)
        Me.lblPostalError.Name = "lblPostalError"
        Me.lblPostalError.Size = New System.Drawing.Size(0, 13)
        Me.lblPostalError.TabIndex = 47
        '
        'lblEmailError
        '
        Me.lblEmailError.AutoSize = True
        Me.lblEmailError.Location = New System.Drawing.Point(125, 439)
        Me.lblEmailError.Name = "lblEmailError"
        Me.lblEmailError.Size = New System.Drawing.Size(0, 13)
        Me.lblEmailError.TabIndex = 48
        '
        'lblTypeError
        '
        Me.lblTypeError.AutoSize = True
        Me.lblTypeError.Location = New System.Drawing.Point(503, 439)
        Me.lblTypeError.Name = "lblTypeError"
        Me.lblTypeError.Size = New System.Drawing.Size(0, 13)
        Me.lblTypeError.TabIndex = 49
        '
        'lblPasswordError
        '
        Me.lblPasswordError.AutoSize = True
        Me.lblPasswordError.Location = New System.Drawing.Point(125, 500)
        Me.lblPasswordError.Name = "lblPasswordError"
        Me.lblPasswordError.Size = New System.Drawing.Size(0, 13)
        Me.lblPasswordError.TabIndex = 50
        '
        'lblPhoneError
        '
        Me.lblPhoneError.AutoSize = True
        Me.lblPhoneError.Location = New System.Drawing.Point(503, 500)
        Me.lblPhoneError.Name = "lblPhoneError"
        Me.lblPhoneError.Size = New System.Drawing.Size(0, 13)
        Me.lblPhoneError.TabIndex = 51
        '
        'lblDOBError
        '
        Me.lblDOBError.AutoSize = True
        Me.lblDOBError.Location = New System.Drawing.Point(125, 559)
        Me.lblDOBError.Name = "lblDOBError"
        Me.lblDOBError.Size = New System.Drawing.Size(0, 13)
        Me.lblDOBError.TabIndex = 52
        '
        'cmbCity
        '
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(128, 337)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(200, 21)
        Me.cmbCity.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(382, 555)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 17)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Answer"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(506, 552)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAnswer.Size = New System.Drawing.Size(200, 20)
        Me.txtAnswer.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(379, 512)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 17)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Security question"
        '
        'cmbSecurity
        '
        Me.cmbSecurity.FormattingEnabled = True
        Me.cmbSecurity.Items.AddRange(New Object() {"What is the name of your town?", "Who is your idol?", "What is your dream country?", "What is your favourite color?", "What is middle name of your mother"})
        Me.cmbSecurity.Location = New System.Drawing.Point(506, 511)
        Me.cmbSecurity.Name = "cmbSecurity"
        Me.cmbSecurity.Size = New System.Drawing.Size(200, 21)
        Me.cmbSecurity.TabIndex = 57
        '
        'btnClose
        '
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.Location = New System.Drawing.Point(473, 597)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(141, 33)
        Me.btnClose.TabIndex = 58
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FrmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundtwo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(785, 658)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cmbSecurity)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.cmbCity)
        Me.Controls.Add(Me.lblDOBError)
        Me.Controls.Add(Me.lblPhoneError)
        Me.Controls.Add(Me.lblPasswordError)
        Me.Controls.Add(Me.lblTypeError)
        Me.Controls.Add(Me.lblEmailError)
        Me.Controls.Add(Me.lblPostalError)
        Me.Controls.Add(Me.lblStreetError)
        Me.Controls.Add(Me.lblProvinceError)
        Me.Controls.Add(Me.lblIDError)
        Me.Controls.Add(Me.lblCityError)
        Me.Controls.Add(Me.lblSurnameError)
        Me.Controls.Add(Me.lblGenderError)
        Me.Controls.Add(Me.lblFirstnameError)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIDNumber)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbProvince)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.btnRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents Password As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbProvince As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstnameError As System.Windows.Forms.Label
    Friend WithEvents lblGenderError As System.Windows.Forms.Label
    Friend WithEvents lblSurnameError As System.Windows.Forms.Label
    Friend WithEvents lblCityError As System.Windows.Forms.Label
    Friend WithEvents lblIDError As System.Windows.Forms.Label
    Friend WithEvents lblProvinceError As System.Windows.Forms.Label
    Friend WithEvents lblStreetError As System.Windows.Forms.Label
    Friend WithEvents lblPostalError As System.Windows.Forms.Label
    Friend WithEvents lblEmailError As System.Windows.Forms.Label
    Friend WithEvents lblTypeError As System.Windows.Forms.Label
    Friend WithEvents lblPasswordError As System.Windows.Forms.Label
    Friend WithEvents lblPhoneError As System.Windows.Forms.Label
    Friend WithEvents lblDOBError As System.Windows.Forms.Label
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbSecurity As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
