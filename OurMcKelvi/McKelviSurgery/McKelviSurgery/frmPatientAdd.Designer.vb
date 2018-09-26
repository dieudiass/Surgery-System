<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientAdd
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
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.chkMedicalAid = New System.Windows.Forms.CheckBox()
        Me.grpMedicalAid = New System.Windows.Forms.GroupBox()
        Me.cmbMedicalNames = New System.Windows.Forms.ComboBox()
        Me.txtMedicalAidDepend = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txxMedicalAidOptions = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMedicalAidNo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.cmbProvince = New System.Windows.Forms.ComboBox()
        Me.cmbMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblPhoneNumberError = New System.Windows.Forms.Label()
        Me.lblPostalCodeError = New System.Windows.Forms.Label()
        Me.lblStreetError = New System.Windows.Forms.Label()
        Me.lblProvinceError = New System.Windows.Forms.Label()
        Me.lblCityError = New System.Windows.Forms.Label()
        Me.lblDOBError = New System.Windows.Forms.Label()
        Me.lblMaritalStatusError = New System.Windows.Forms.Label()
        Me.lblGenderError = New System.Windows.Forms.Label()
        Me.lblSurnameError = New System.Windows.Forms.Label()
        Me.lblFirstnameError = New System.Windows.Forms.Label()
        Me.lblIDerror = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dptDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoNational = New System.Windows.Forms.RadioButton()
        Me.rdoInternational = New System.Windows.Forms.RadioButton()
        Me.grpID = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grpDetails.SuspendLayout()
        Me.grpMedicalAid.SuspendLayout()
        Me.grpID.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDetails
        '
        Me.grpDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpDetails.Controls.Add(Me.chkMedicalAid)
        Me.grpDetails.Controls.Add(Me.grpMedicalAid)
        Me.grpDetails.Controls.Add(Me.cmbCity)
        Me.grpDetails.Controls.Add(Me.cmbProvince)
        Me.grpDetails.Controls.Add(Me.cmbMaritalStatus)
        Me.grpDetails.Controls.Add(Me.cmbGender)
        Me.grpDetails.Controls.Add(Me.btnAppointment)
        Me.grpDetails.Controls.Add(Me.btnSave)
        Me.grpDetails.Controls.Add(Me.lblPhoneNumberError)
        Me.grpDetails.Controls.Add(Me.lblPostalCodeError)
        Me.grpDetails.Controls.Add(Me.lblStreetError)
        Me.grpDetails.Controls.Add(Me.lblProvinceError)
        Me.grpDetails.Controls.Add(Me.lblCityError)
        Me.grpDetails.Controls.Add(Me.lblDOBError)
        Me.grpDetails.Controls.Add(Me.lblMaritalStatusError)
        Me.grpDetails.Controls.Add(Me.lblGenderError)
        Me.grpDetails.Controls.Add(Me.lblSurnameError)
        Me.grpDetails.Controls.Add(Me.lblFirstnameError)
        Me.grpDetails.Controls.Add(Me.lblIDerror)
        Me.grpDetails.Controls.Add(Me.txtPhoneNumber)
        Me.grpDetails.Controls.Add(Me.txtIDNumber)
        Me.grpDetails.Controls.Add(Me.Label12)
        Me.grpDetails.Controls.Add(Me.txtZipCode)
        Me.grpDetails.Controls.Add(Me.Label11)
        Me.grpDetails.Controls.Add(Me.dptDOB)
        Me.grpDetails.Controls.Add(Me.txtStreet)
        Me.grpDetails.Controls.Add(Me.txtSurname)
        Me.grpDetails.Controls.Add(Me.txtFirstname)
        Me.grpDetails.Controls.Add(Me.txtPatientID)
        Me.grpDetails.Controls.Add(Me.Label3)
        Me.grpDetails.Controls.Add(Me.Label7)
        Me.grpDetails.Controls.Add(Me.Label8)
        Me.grpDetails.Controls.Add(Me.Label10)
        Me.grpDetails.Controls.Add(Me.Label9)
        Me.grpDetails.Controls.Add(Me.Label6)
        Me.grpDetails.Controls.Add(Me.Label5)
        Me.grpDetails.Controls.Add(Me.Label4)
        Me.grpDetails.Controls.Add(Me.Label2)
        Me.grpDetails.Controls.Add(Me.Label1)
        Me.grpDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetails.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpDetails.Location = New System.Drawing.Point(59, 132)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(973, 540)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        '
        'chkMedicalAid
        '
        Me.chkMedicalAid.AutoSize = True
        Me.chkMedicalAid.Location = New System.Drawing.Point(613, 32)
        Me.chkMedicalAid.Name = "chkMedicalAid"
        Me.chkMedicalAid.Size = New System.Drawing.Size(256, 19)
        Me.chkMedicalAid.TabIndex = 4
        Me.chkMedicalAid.Text = "Does the patient have Medical Aid ?"
        Me.chkMedicalAid.UseVisualStyleBackColor = True
        '
        'grpMedicalAid
        '
        Me.grpMedicalAid.BackColor = System.Drawing.Color.FloralWhite
        Me.grpMedicalAid.Controls.Add(Me.cmbMedicalNames)
        Me.grpMedicalAid.Controls.Add(Me.txtMedicalAidDepend)
        Me.grpMedicalAid.Controls.Add(Me.Label17)
        Me.grpMedicalAid.Controls.Add(Me.txxMedicalAidOptions)
        Me.grpMedicalAid.Controls.Add(Me.Label16)
        Me.grpMedicalAid.Controls.Add(Me.txtMedicalAidNo)
        Me.grpMedicalAid.Controls.Add(Me.Label15)
        Me.grpMedicalAid.Controls.Add(Me.Label14)
        Me.grpMedicalAid.Location = New System.Drawing.Point(585, 73)
        Me.grpMedicalAid.Name = "grpMedicalAid"
        Me.grpMedicalAid.Size = New System.Drawing.Size(371, 280)
        Me.grpMedicalAid.TabIndex = 42
        Me.grpMedicalAid.TabStop = False
        Me.grpMedicalAid.Text = "Medical Aid"
        '
        'cmbMedicalNames
        '
        Me.cmbMedicalNames.FormattingEnabled = True
        Me.cmbMedicalNames.Items.AddRange(New Object() {"BESTMED MEDICAL SCHEME ", "BONITAS MEDICAL FUND ", "CAPE MEDICAL PLAN ", "COMMUNITY MEDICAL AID SCHEME (COMMED)  ", "COMPCARE WELLNESS MEDICAL SCHEME ", "DISCOVERY HEALTH MEDICAL SCHEME  ", "FEDHEALTH MEDICAL SCHEME ", "GENESIS MEDICAL SCHEME ", "HOSMED MEDICAL AID SCHEME  ", "KEYHEALTH  ", "LIBERTY MEDICAL SCHEME  ", "MAKOTI MEDICAL SCHEME  ", "MEDIHELP ", "MEDIMED MEDICAL SCHEME  ", "MEDSHIELD MEDICAL SCHEME ", "MOMENTUM HEALTH ", "NATIONAL INDEPENDENT MEDICAL AID SOCIETY (NIMAS) ", "PHAROS MEDICAL PLAN ", "PRO SANO MEDICAL SCHEME  ", "RESOLUTION HEALTH MEDICAL SCHEME  ", "SELFMED MEDICAL SCHEME ", "SIZWE MEDICAL FUND  ", "SPECTRAMED  ", "SUREMED HEALTH ", "THEBEMED ", "OTHER"})
        Me.cmbMedicalNames.Location = New System.Drawing.Point(172, 109)
        Me.cmbMedicalNames.Name = "cmbMedicalNames"
        Me.cmbMedicalNames.Size = New System.Drawing.Size(181, 23)
        Me.cmbMedicalNames.TabIndex = 8
        '
        'txtMedicalAidDepend
        '
        Me.txtMedicalAidDepend.Location = New System.Drawing.Point(173, 232)
        Me.txtMedicalAidDepend.Name = "txtMedicalAidDepend"
        Me.txtMedicalAidDepend.Size = New System.Drawing.Size(180, 21)
        Me.txtMedicalAidDepend.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 235)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 15)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Medical Aid Depend"
        '
        'txxMedicalAidOptions
        '
        Me.txxMedicalAidOptions.Location = New System.Drawing.Point(173, 173)
        Me.txxMedicalAidOptions.Name = "txxMedicalAidOptions"
        Me.txxMedicalAidOptions.Size = New System.Drawing.Size(180, 21)
        Me.txxMedicalAidOptions.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 176)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 15)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Medical Aid Options"
        '
        'txtMedicalAidNo
        '
        Me.txtMedicalAidNo.Location = New System.Drawing.Point(168, 46)
        Me.txtMedicalAidNo.Name = "txtMedicalAidNo"
        Me.txtMedicalAidNo.Size = New System.Drawing.Size(185, 21)
        Me.txtMedicalAidNo.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(24, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Medical Aid Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Medical Aid Number"
        '
        'cmbCity
        '
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(158, 370)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(160, 23)
        Me.cmbCity.TabIndex = 41
        '
        'cmbProvince
        '
        Me.cmbProvince.FormattingEnabled = True
        Me.cmbProvince.Items.AddRange(New Object() {"Eastern Cape", "Free State", "Gauteng", "Kwazulu-Natal", "Limpopo", "Mpumalanga", "Northern Cape", "North West"})
        Me.cmbProvince.Location = New System.Drawing.Point(158, 327)
        Me.cmbProvince.Name = "cmbProvince"
        Me.cmbProvince.Size = New System.Drawing.Size(160, 23)
        Me.cmbProvince.TabIndex = 40
        '
        'cmbMaritalStatus
        '
        Me.cmbMaritalStatus.FormattingEnabled = True
        Me.cmbMaritalStatus.Items.AddRange(New Object() {"Married", "Single", "Divorced", "Widowed"})
        Me.cmbMaritalStatus.Location = New System.Drawing.Point(158, 237)
        Me.cmbMaritalStatus.Name = "cmbMaritalStatus"
        Me.cmbMaritalStatus.Size = New System.Drawing.Size(160, 23)
        Me.cmbMaritalStatus.TabIndex = 39
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(158, 197)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(160, 23)
        Me.cmbGender.TabIndex = 38
        '
        'btnAppointment
        '
        Me.btnAppointment.Location = New System.Drawing.Point(671, 381)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(96, 68)
        Me.btnAppointment.TabIndex = 22
        Me.btnAppointment.Text = "Make Appointment"
        Me.btnAppointment.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(507, 381)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 68)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save Patient"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblPhoneNumberError
        '
        Me.lblPhoneNumberError.AutoSize = True
        Me.lblPhoneNumberError.ForeColor = System.Drawing.Color.Red
        Me.lblPhoneNumberError.Location = New System.Drawing.Point(155, 517)
        Me.lblPhoneNumberError.Name = "lblPhoneNumberError"
        Me.lblPhoneNumberError.Size = New System.Drawing.Size(0, 15)
        Me.lblPhoneNumberError.TabIndex = 37
        '
        'lblPostalCodeError
        '
        Me.lblPostalCodeError.AutoSize = True
        Me.lblPostalCodeError.ForeColor = System.Drawing.Color.Red
        Me.lblPostalCodeError.Location = New System.Drawing.Point(155, 475)
        Me.lblPostalCodeError.Name = "lblPostalCodeError"
        Me.lblPostalCodeError.Size = New System.Drawing.Size(0, 15)
        Me.lblPostalCodeError.TabIndex = 36
        '
        'lblStreetError
        '
        Me.lblStreetError.AutoSize = True
        Me.lblStreetError.ForeColor = System.Drawing.Color.Red
        Me.lblStreetError.Location = New System.Drawing.Point(155, 434)
        Me.lblStreetError.Name = "lblStreetError"
        Me.lblStreetError.Size = New System.Drawing.Size(0, 15)
        Me.lblStreetError.TabIndex = 35
        '
        'lblProvinceError
        '
        Me.lblProvinceError.AutoSize = True
        Me.lblProvinceError.ForeColor = System.Drawing.Color.Red
        Me.lblProvinceError.Location = New System.Drawing.Point(155, 392)
        Me.lblProvinceError.Name = "lblProvinceError"
        Me.lblProvinceError.Size = New System.Drawing.Size(0, 15)
        Me.lblProvinceError.TabIndex = 34
        '
        'lblCityError
        '
        Me.lblCityError.AutoSize = True
        Me.lblCityError.ForeColor = System.Drawing.Color.Red
        Me.lblCityError.Location = New System.Drawing.Point(155, 351)
        Me.lblCityError.Name = "lblCityError"
        Me.lblCityError.Size = New System.Drawing.Size(0, 15)
        Me.lblCityError.TabIndex = 33
        '
        'lblDOBError
        '
        Me.lblDOBError.AutoSize = True
        Me.lblDOBError.ForeColor = System.Drawing.Color.Red
        Me.lblDOBError.Location = New System.Drawing.Point(155, 305)
        Me.lblDOBError.Name = "lblDOBError"
        Me.lblDOBError.Size = New System.Drawing.Size(0, 15)
        Me.lblDOBError.TabIndex = 32
        '
        'lblMaritalStatusError
        '
        Me.lblMaritalStatusError.AutoSize = True
        Me.lblMaritalStatusError.ForeColor = System.Drawing.Color.Red
        Me.lblMaritalStatusError.Location = New System.Drawing.Point(155, 263)
        Me.lblMaritalStatusError.Name = "lblMaritalStatusError"
        Me.lblMaritalStatusError.Size = New System.Drawing.Size(0, 15)
        Me.lblMaritalStatusError.TabIndex = 31
        '
        'lblGenderError
        '
        Me.lblGenderError.AutoSize = True
        Me.lblGenderError.ForeColor = System.Drawing.Color.Red
        Me.lblGenderError.Location = New System.Drawing.Point(155, 218)
        Me.lblGenderError.Name = "lblGenderError"
        Me.lblGenderError.Size = New System.Drawing.Size(0, 15)
        Me.lblGenderError.TabIndex = 30
        '
        'lblSurnameError
        '
        Me.lblSurnameError.AutoSize = True
        Me.lblSurnameError.ForeColor = System.Drawing.Color.Red
        Me.lblSurnameError.Location = New System.Drawing.Point(155, 176)
        Me.lblSurnameError.Name = "lblSurnameError"
        Me.lblSurnameError.Size = New System.Drawing.Size(0, 15)
        Me.lblSurnameError.TabIndex = 29
        '
        'lblFirstnameError
        '
        Me.lblFirstnameError.AutoSize = True
        Me.lblFirstnameError.ForeColor = System.Drawing.Color.Red
        Me.lblFirstnameError.Location = New System.Drawing.Point(155, 135)
        Me.lblFirstnameError.Name = "lblFirstnameError"
        Me.lblFirstnameError.Size = New System.Drawing.Size(0, 15)
        Me.lblFirstnameError.TabIndex = 28
        '
        'lblIDerror
        '
        Me.lblIDerror.AutoSize = True
        Me.lblIDerror.ForeColor = System.Drawing.Color.Red
        Me.lblIDerror.Location = New System.Drawing.Point(155, 93)
        Me.lblIDerror.Name = "lblIDerror"
        Me.lblIDerror.Size = New System.Drawing.Size(0, 15)
        Me.lblIDerror.TabIndex = 27
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(158, 493)
        Me.txtPhoneNumber.MaxLength = 10
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(160, 21)
        Me.txtPhoneNumber.TabIndex = 21
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(158, 70)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(160, 21)
        Me.txtIDNumber.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ID Number/Passport"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(158, 453)
        Me.txtZipCode.MaxLength = 5
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.ReadOnly = True
        Me.txtZipCode.Size = New System.Drawing.Size(160, 21)
        Me.txtZipCode.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 456)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Postal Code"
        '
        'dptDOB
        '
        Me.dptDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptDOB.Location = New System.Drawing.Point(158, 281)
        Me.dptDOB.Name = "dptDOB"
        Me.dptDOB.Size = New System.Drawing.Size(160, 21)
        Me.dptDOB.TabIndex = 11
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(158, 410)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(160, 21)
        Me.txtStreet.TabIndex = 17
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(158, 152)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(160, 21)
        Me.txtSurname.TabIndex = 5
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(158, 111)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(160, 21)
        Me.txtFirstname.TabIndex = 3
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(158, 29)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(160, 21)
        Me.txtPatientID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Firstname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Date Of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 378)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Town"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 493)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Phone Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 413)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "No and Street Name "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Province"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Marital Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Surname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient ID"
        '
        'rdoNational
        '
        Me.rdoNational.AutoSize = True
        Me.rdoNational.Checked = True
        Me.rdoNational.Location = New System.Drawing.Point(98, 20)
        Me.rdoNational.Name = "rdoNational"
        Me.rdoNational.Size = New System.Drawing.Size(168, 19)
        Me.rdoNational.TabIndex = 0
        Me.rdoNational.TabStop = True
        Me.rdoNational.Text = "National South African"
        Me.rdoNational.UseVisualStyleBackColor = True
        '
        'rdoInternational
        '
        Me.rdoInternational.AutoSize = True
        Me.rdoInternational.Location = New System.Drawing.Point(360, 20)
        Me.rdoInternational.Name = "rdoInternational"
        Me.rdoInternational.Size = New System.Drawing.Size(106, 19)
        Me.rdoInternational.TabIndex = 1
        Me.rdoInternational.Text = "International"
        Me.rdoInternational.UseVisualStyleBackColor = True
        '
        'grpID
        '
        Me.grpID.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpID.Controls.Add(Me.rdoInternational)
        Me.grpID.Controls.Add(Me.rdoNational)
        Me.grpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpID.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpID.Location = New System.Drawing.Point(59, 56)
        Me.grpID.Name = "grpID"
        Me.grpID.Size = New System.Drawing.Size(628, 70)
        Me.grpID.TabIndex = 0
        Me.grpID.TabStop = False
        Me.grpID.Text = "Identification"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(282, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(186, 26)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Add New Patient"
        '
        'frmPatientAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundtwo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1037, 708)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.grpID)
        Me.Controls.Add(Me.grpDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPatientAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Patient"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpMedicalAid.ResumeLayout(False)
        Me.grpMedicalAid.PerformLayout()
        Me.grpID.ResumeLayout(False)
        Me.grpID.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dptDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAppointment As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblPhoneNumberError As System.Windows.Forms.Label
    Friend WithEvents lblPostalCodeError As System.Windows.Forms.Label
    Friend WithEvents lblStreetError As System.Windows.Forms.Label
    Friend WithEvents lblProvinceError As System.Windows.Forms.Label
    Friend WithEvents lblCityError As System.Windows.Forms.Label
    Friend WithEvents lblDOBError As System.Windows.Forms.Label
    Friend WithEvents lblMaritalStatusError As System.Windows.Forms.Label
    Friend WithEvents lblGenderError As System.Windows.Forms.Label
    Friend WithEvents lblSurnameError As System.Windows.Forms.Label
    Friend WithEvents lblFirstnameError As System.Windows.Forms.Label
    Friend WithEvents lblIDerror As System.Windows.Forms.Label
    Friend WithEvents rdoNational As System.Windows.Forms.RadioButton
    Friend WithEvents rdoInternational As System.Windows.Forms.RadioButton
    Friend WithEvents grpID As System.Windows.Forms.GroupBox
    Friend WithEvents cmbProvince As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMaritalStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
    Friend WithEvents chkMedicalAid As System.Windows.Forms.CheckBox
    Friend WithEvents grpMedicalAid As System.Windows.Forms.GroupBox
    Friend WithEvents txtMedicalAidNo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbMedicalNames As System.Windows.Forms.ComboBox
    Friend WithEvents txtMedicalAidDepend As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txxMedicalAidOptions As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
