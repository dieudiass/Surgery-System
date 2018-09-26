<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeUpdateInformayion
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
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
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblFirstnameError = New System.Windows.Forms.Label()
        Me.lblStreetError = New System.Windows.Forms.Label()
        Me.lblCityError = New System.Windows.Forms.Label()
        Me.lblSurnameError = New System.Windows.Forms.Label()
        Me.lblProvinceError = New System.Windows.Forms.Label()
        Me.lblPostalError = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneError = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Postal Code"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(134, 281)
        Me.txtZipCode.MaxLength = 5
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(81, 20)
        Me.txtZipCode.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ID/Passport"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(500, 43)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.ReadOnly = True
        Me.txtIDNumber.Size = New System.Drawing.Size(200, 20)
        Me.txtIDNumber.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Street"
        '
        'cmbProvince
        '
        Me.cmbProvince.FormattingEnabled = True
        Me.cmbProvince.Items.AddRange(New Object() {"Eastern Cape", "Free State", "Gauteng", "Kwazulu-Natal", "Limpopo", "Mpumalanga", "Northern Cape", "North West"})
        Me.cmbProvince.Location = New System.Drawing.Point(129, 140)
        Me.cmbProvince.Name = "cmbProvince"
        Me.cmbProvince.Size = New System.Drawing.Size(200, 21)
        Me.cmbProvince.TabIndex = 35
        '
        'cmbGender
        '
        Me.cmbGender.Enabled = False
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Female", "Male"})
        Me.cmbGender.Location = New System.Drawing.Point(500, 91)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(200, 21)
        Me.cmbGender.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Province"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "City"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(129, 42)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(200, 20)
        Me.txtFirstname.TabIndex = 25
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(129, 88)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(200, 20)
        Me.txtSurname.TabIndex = 27
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(129, 230)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(200, 20)
        Me.txtStreet.TabIndex = 37
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(357, 284)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(137, 42)
        Me.btnSave.TabIndex = 48
        Me.btnSave.Text = "Save Information"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(367, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 17)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Employee ID"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(500, 188)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(200, 20)
        Me.txtEmployeeID.TabIndex = 51
        '
        'lblFirstnameError
        '
        Me.lblFirstnameError.AutoSize = True
        Me.lblFirstnameError.ForeColor = System.Drawing.Color.Red
        Me.lblFirstnameError.Location = New System.Drawing.Point(131, 69)
        Me.lblFirstnameError.Name = "lblFirstnameError"
        Me.lblFirstnameError.Size = New System.Drawing.Size(0, 13)
        Me.lblFirstnameError.TabIndex = 52
        '
        'lblStreetError
        '
        Me.lblStreetError.AutoSize = True
        Me.lblStreetError.ForeColor = System.Drawing.Color.Red
        Me.lblStreetError.Location = New System.Drawing.Point(131, 210)
        Me.lblStreetError.Name = "lblStreetError"
        Me.lblStreetError.Size = New System.Drawing.Size(0, 13)
        Me.lblStreetError.TabIndex = 53
        '
        'lblCityError
        '
        Me.lblCityError.AutoSize = True
        Me.lblCityError.ForeColor = System.Drawing.Color.Red
        Me.lblCityError.Location = New System.Drawing.Point(131, 171)
        Me.lblCityError.Name = "lblCityError"
        Me.lblCityError.Size = New System.Drawing.Size(0, 13)
        Me.lblCityError.TabIndex = 54
        '
        'lblSurnameError
        '
        Me.lblSurnameError.AutoSize = True
        Me.lblSurnameError.ForeColor = System.Drawing.Color.Red
        Me.lblSurnameError.Location = New System.Drawing.Point(506, 74)
        Me.lblSurnameError.Name = "lblSurnameError"
        Me.lblSurnameError.Size = New System.Drawing.Size(0, 13)
        Me.lblSurnameError.TabIndex = 55
        '
        'lblProvinceError
        '
        Me.lblProvinceError.AutoSize = True
        Me.lblProvinceError.ForeColor = System.Drawing.Color.Red
        Me.lblProvinceError.Location = New System.Drawing.Point(506, 169)
        Me.lblProvinceError.Name = "lblProvinceError"
        Me.lblProvinceError.Size = New System.Drawing.Size(0, 13)
        Me.lblProvinceError.TabIndex = 57
        '
        'lblPostalError
        '
        Me.lblPostalError.AutoSize = True
        Me.lblPostalError.ForeColor = System.Drawing.Color.Red
        Me.lblPostalError.Location = New System.Drawing.Point(506, 210)
        Me.lblPostalError.Name = "lblPostalError"
        Me.lblPostalError.Size = New System.Drawing.Size(0, 13)
        Me.lblPostalError.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(370, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 17)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Phone Number"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(500, 135)
        Me.txtPhoneNumber.MaxLength = 10
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(200, 20)
        Me.txtPhoneNumber.TabIndex = 60
        '
        'lblPhoneError
        '
        Me.lblPhoneError.AutoSize = True
        Me.lblPhoneError.ForeColor = System.Drawing.Color.Red
        Me.lblPhoneError.Location = New System.Drawing.Point(319, 268)
        Me.lblPhoneError.Name = "lblPhoneError"
        Me.lblPhoneError.Size = New System.Drawing.Size(0, 13)
        Me.lblPhoneError.TabIndex = 61
        '
        'cmbCity
        '
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Items.AddRange(New Object() {"Eastern Cape", "Free State", "Gauteng", "Kwazulu-Natal", "Limpopo", "Mpumalanga", "Northern Cape", "North West"})
        Me.cmbCity.Location = New System.Drawing.Point(129, 184)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(200, 21)
        Me.cmbCity.TabIndex = 62
        '
        'frmEmployeeUpdateInformayion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(774, 373)
        Me.Controls.Add(Me.cmbCity)
        Me.Controls.Add(Me.lblPhoneError)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.lblPostalError)
        Me.Controls.Add(Me.lblProvinceError)
        Me.Controls.Add(Me.lblSurnameError)
        Me.Controls.Add(Me.lblCityError)
        Me.Controls.Add(Me.lblStreetError)
        Me.Controls.Add(Me.lblFirstnameError)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIDNumber)
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
        Me.Controls.Add(Me.txtStreet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEmployeeUpdateInformayion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Update Information  Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIDNumber As System.Windows.Forms.TextBox
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
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstnameError As System.Windows.Forms.Label
    Friend WithEvents lblStreetError As System.Windows.Forms.Label
    Friend WithEvents lblCityError As System.Windows.Forms.Label
    Friend WithEvents lblSurnameError As System.Windows.Forms.Label
    Friend WithEvents lblProvinceError As System.Windows.Forms.Label
    Friend WithEvents lblPostalError As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneError As System.Windows.Forms.Label
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
End Class
