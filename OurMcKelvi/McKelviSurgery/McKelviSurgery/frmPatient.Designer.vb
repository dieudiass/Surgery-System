<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatient
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
        Me.btnNextStep = New System.Windows.Forms.Button()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.cmbMaritalStatus = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.TextBox()
        Me.cmbProvince = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dptDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
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
        Me.grpSearchPatient = New System.Windows.Forms.GroupBox()
        Me.lblSearchError = New System.Windows.Forms.Label()
        Me.rdoByPassportNo = New System.Windows.Forms.RadioButton()
        Me.rdoByIDNumber = New System.Windows.Forms.RadioButton()
        Me.rdoByPhoneNumber = New System.Windows.Forms.RadioButton()
        Me.txtSearchPatient = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TblPatientTableAdapter1 = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter()
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.TblAppointmentTableAdapter1 = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter()
        Me.grpDetails.SuspendLayout()
        Me.grpSearchPatient.SuspendLayout()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNextStep
        '
        Me.btnNextStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextStep.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnNextStep.Location = New System.Drawing.Point(598, 289)
        Me.btnNextStep.Name = "btnNextStep"
        Me.btnNextStep.Size = New System.Drawing.Size(119, 55)
        Me.btnNextStep.TabIndex = 5
        Me.btnNextStep.Text = "Check if Patient has an appointment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnNextStep.UseVisualStyleBackColor = True
        '
        'grpDetails
        '
        Me.grpDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpDetails.Controls.Add(Me.cmbMaritalStatus)
        Me.grpDetails.Controls.Add(Me.cmbGender)
        Me.grpDetails.Controls.Add(Me.cmbProvince)
        Me.grpDetails.Controls.Add(Me.txtPhoneNumber)
        Me.grpDetails.Controls.Add(Me.txtIDNumber)
        Me.grpDetails.Controls.Add(Me.Label12)
        Me.grpDetails.Controls.Add(Me.txtZipCode)
        Me.grpDetails.Controls.Add(Me.Label11)
        Me.grpDetails.Controls.Add(Me.dptDOB)
        Me.grpDetails.Controls.Add(Me.txtStreet)
        Me.grpDetails.Controls.Add(Me.txtCity)
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
        Me.grpDetails.Location = New System.Drawing.Point(125, 187)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(453, 429)
        Me.grpDetails.TabIndex = 4
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        '
        'cmbMaritalStatus
        '
        Me.cmbMaritalStatus.Location = New System.Drawing.Point(158, 181)
        Me.cmbMaritalStatus.Name = "cmbMaritalStatus"
        Me.cmbMaritalStatus.ReadOnly = True
        Me.cmbMaritalStatus.Size = New System.Drawing.Size(160, 21)
        Me.cmbMaritalStatus.TabIndex = 26
        '
        'cmbGender
        '
        Me.cmbGender.Location = New System.Drawing.Point(158, 152)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.ReadOnly = True
        Me.cmbGender.Size = New System.Drawing.Size(160, 21)
        Me.cmbGender.TabIndex = 25
        '
        'cmbProvince
        '
        Me.cmbProvince.Location = New System.Drawing.Point(158, 292)
        Me.cmbProvince.Name = "cmbProvince"
        Me.cmbProvince.ReadOnly = True
        Me.cmbProvince.Size = New System.Drawing.Size(160, 21)
        Me.cmbProvince.TabIndex = 24
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(158, 393)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(160, 21)
        Me.txtPhoneNumber.TabIndex = 23
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(158, 60)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.ReadOnly = True
        Me.txtIDNumber.Size = New System.Drawing.Size(160, 21)
        Me.txtIDNumber.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "ID Number/Passport"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(158, 360)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.ReadOnly = True
        Me.txtZipCode.Size = New System.Drawing.Size(160, 21)
        Me.txtZipCode.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 363)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Postal Code"
        '
        'dptDOB
        '
        Me.dptDOB.Enabled = False
        Me.dptDOB.Location = New System.Drawing.Point(158, 213)
        Me.dptDOB.Name = "dptDOB"
        Me.dptDOB.Size = New System.Drawing.Size(247, 21)
        Me.dptDOB.TabIndex = 13
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(158, 330)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.ReadOnly = True
        Me.txtStreet.Size = New System.Drawing.Size(160, 21)
        Me.txtStreet.TabIndex = 19
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(158, 254)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(160, 21)
        Me.txtCity.TabIndex = 15
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(158, 119)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(160, 21)
        Me.txtSurname.TabIndex = 7
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(158, 90)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.ReadOnly = True
        Me.txtFirstname.Size = New System.Drawing.Size(160, 21)
        Me.txtFirstname.TabIndex = 5
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
        Me.Label3.Location = New System.Drawing.Point(7, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Firstname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Date Of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "City"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 393)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Phone Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Street"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Province"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Marital Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 6
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
        'grpSearchPatient
        '
        Me.grpSearchPatient.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpSearchPatient.Controls.Add(Me.lblSearchError)
        Me.grpSearchPatient.Controls.Add(Me.rdoByPassportNo)
        Me.grpSearchPatient.Controls.Add(Me.rdoByIDNumber)
        Me.grpSearchPatient.Controls.Add(Me.rdoByPhoneNumber)
        Me.grpSearchPatient.Controls.Add(Me.txtSearchPatient)
        Me.grpSearchPatient.Controls.Add(Me.btnFind)
        Me.grpSearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchPatient.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpSearchPatient.Location = New System.Drawing.Point(23, 57)
        Me.grpSearchPatient.Name = "grpSearchPatient"
        Me.grpSearchPatient.Size = New System.Drawing.Size(627, 124)
        Me.grpSearchPatient.TabIndex = 3
        Me.grpSearchPatient.TabStop = False
        Me.grpSearchPatient.Text = "Search Patient"
        '
        'lblSearchError
        '
        Me.lblSearchError.AutoSize = True
        Me.lblSearchError.ForeColor = System.Drawing.Color.Red
        Me.lblSearchError.Location = New System.Drawing.Point(62, 95)
        Me.lblSearchError.Name = "lblSearchError"
        Me.lblSearchError.Size = New System.Drawing.Size(0, 15)
        Me.lblSearchError.TabIndex = 5
        '
        'rdoByPassportNo
        '
        Me.rdoByPassportNo.AutoSize = True
        Me.rdoByPassportNo.Location = New System.Drawing.Point(426, 18)
        Me.rdoByPassportNo.Name = "rdoByPassportNo"
        Me.rdoByPassportNo.Size = New System.Drawing.Size(170, 19)
        Me.rdoByPassportNo.TabIndex = 4
        Me.rdoByPassportNo.Text = "Search by Passport No"
        Me.rdoByPassportNo.UseVisualStyleBackColor = True
        '
        'rdoByIDNumber
        '
        Me.rdoByIDNumber.AutoSize = True
        Me.rdoByIDNumber.Location = New System.Drawing.Point(235, 18)
        Me.rdoByIDNumber.Name = "rdoByIDNumber"
        Me.rdoByIDNumber.Size = New System.Drawing.Size(161, 19)
        Me.rdoByIDNumber.TabIndex = 3
        Me.rdoByIDNumber.Text = "Search by ID Number"
        Me.rdoByIDNumber.UseVisualStyleBackColor = True
        '
        'rdoByPhoneNumber
        '
        Me.rdoByPhoneNumber.AutoSize = True
        Me.rdoByPhoneNumber.Checked = True
        Me.rdoByPhoneNumber.Location = New System.Drawing.Point(22, 18)
        Me.rdoByPhoneNumber.Name = "rdoByPhoneNumber"
        Me.rdoByPhoneNumber.Size = New System.Drawing.Size(188, 19)
        Me.rdoByPhoneNumber.TabIndex = 2
        Me.rdoByPhoneNumber.TabStop = True
        Me.rdoByPhoneNumber.Text = "Search by Phone Number"
        Me.rdoByPhoneNumber.UseVisualStyleBackColor = True
        '
        'txtSearchPatient
        '
        Me.txtSearchPatient.Location = New System.Drawing.Point(63, 71)
        Me.txtSearchPatient.Name = "txtSearchPatient"
        Me.txtSearchPatient.Size = New System.Drawing.Size(284, 21)
        Me.txtSearchPatient.TabIndex = 0
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(405, 66)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(102, 30)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(271, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(169, 26)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Search  Patient"
        '
        'TblPatientTableAdapter1
        '
        Me.TblPatientTableAdapter1.ClearBeforeFill = True
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAppointmentTableAdapter1
        '
        Me.TblAppointmentTableAdapter1.ClearBeforeFill = True
        '
        'frmPatient
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundtwo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(768, 636)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnNextStep)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.grpSearchPatient)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Form"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpSearchPatient.ResumeLayout(False)
        Me.grpSearchPatient.PerformLayout()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNextStep As System.Windows.Forms.Button
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMaritalStatus As System.Windows.Forms.TextBox
    Friend WithEvents cmbGender As System.Windows.Forms.TextBox
    Friend WithEvents cmbProvince As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtIDNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dptDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
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
    Friend WithEvents grpSearchPatient As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearchPatient As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents rdoByPassportNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoByIDNumber As System.Windows.Forms.RadioButton
    Friend WithEvents rdoByPhoneNumber As System.Windows.Forms.RadioButton
    Friend WithEvents lblSearchError As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TblPatientTableAdapter1 As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblAppointmentTableAdapter1 As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter
End Class
