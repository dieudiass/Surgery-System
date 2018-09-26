<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePatient
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
        Me.components = New System.ComponentModel.Container()
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim IDNumberLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim ProvinceLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim MaritalStatusLabel As System.Windows.Forms.Label
        Dim MedicalAidNameLabel As System.Windows.Forms.Label
        Dim MedicalAidNoLabel As System.Windows.Forms.Label
        Dim MedicalAidDependLabel As System.Windows.Forms.Label
        Dim MedicalAidOptionsLabel As System.Windows.Forms.Label
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.TblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPatientTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter()
        Me.TableAdapterManager = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.IDNumberTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MaritalStatusTextBox = New System.Windows.Forms.TextBox()
        Me.MedicalAidNameTextBox = New System.Windows.Forms.TextBox()
        Me.MedicalAidNoTextBox = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.MedicalAidDependTextBox = New System.Windows.Forms.TextBox()
        Me.MedicalAidOptionsTextBox = New System.Windows.Forms.TextBox()
        PatientIDLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        IDNumberLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        ProvinceLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        ZipCodeLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        MaritalStatusLabel = New System.Windows.Forms.Label()
        MedicalAidNameLabel = New System.Windows.Forms.Label()
        MedicalAidNoLabel = New System.Windows.Forms.Label()
        MedicalAidDependLabel = New System.Windows.Forms.Label()
        MedicalAidOptionsLabel = New System.Windows.Forms.Label()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(28, 25)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(57, 13)
        PatientIDLabel.TabIndex = 1
        PatientIDLabel.Text = "Patient ID:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(28, 51)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(55, 13)
        FirstnameLabel.TabIndex = 3
        FirstnameLabel.Text = "Firstname:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(28, 77)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 5
        SurnameLabel.Text = "Surname:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(28, 103)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'IDNumberLabel
        '
        IDNumberLabel.AutoSize = True
        IDNumberLabel.Location = New System.Drawing.Point(28, 129)
        IDNumberLabel.Name = "IDNumberLabel"
        IDNumberLabel.Size = New System.Drawing.Size(58, 13)
        IDNumberLabel.TabIndex = 9
        IDNumberLabel.Text = "IDNumber:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(28, 156)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 11
        DOBLabel.Text = "DOB:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(28, 181)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 13
        CityLabel.Text = "City:"
        '
        'ProvinceLabel
        '
        ProvinceLabel.AutoSize = True
        ProvinceLabel.Location = New System.Drawing.Point(28, 207)
        ProvinceLabel.Name = "ProvinceLabel"
        ProvinceLabel.Size = New System.Drawing.Size(52, 13)
        ProvinceLabel.TabIndex = 15
        ProvinceLabel.Text = "Province:"
        '
        'StreetLabel
        '
        StreetLabel.AutoSize = True
        StreetLabel.Location = New System.Drawing.Point(28, 233)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(38, 13)
        StreetLabel.TabIndex = 17
        StreetLabel.Text = "Street:"
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(28, 259)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(53, 13)
        ZipCodeLabel.TabIndex = 19
        ZipCodeLabel.Text = "Zip Code:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(28, 285)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 21
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'MaritalStatusLabel
        '
        MaritalStatusLabel.AutoSize = True
        MaritalStatusLabel.Location = New System.Drawing.Point(28, 311)
        MaritalStatusLabel.Name = "MaritalStatusLabel"
        MaritalStatusLabel.Size = New System.Drawing.Size(74, 13)
        MaritalStatusLabel.TabIndex = 23
        MaritalStatusLabel.Text = "Marital Status:"
        '
        'MedicalAidNameLabel
        '
        MedicalAidNameLabel.AutoSize = True
        MedicalAidNameLabel.Location = New System.Drawing.Point(28, 337)
        MedicalAidNameLabel.Name = "MedicalAidNameLabel"
        MedicalAidNameLabel.Size = New System.Drawing.Size(96, 13)
        MedicalAidNameLabel.TabIndex = 25
        MedicalAidNameLabel.Text = "Medical Aid Name:"
        '
        'MedicalAidNoLabel
        '
        MedicalAidNoLabel.AutoSize = True
        MedicalAidNoLabel.Location = New System.Drawing.Point(28, 363)
        MedicalAidNoLabel.Name = "MedicalAidNoLabel"
        MedicalAidNoLabel.Size = New System.Drawing.Size(82, 13)
        MedicalAidNoLabel.TabIndex = 27
        MedicalAidNoLabel.Text = "Medical Aid No:"
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatientBindingSource
        '
        Me.TblPatientBindingSource.DataMember = "tblPatient"
        Me.TblPatientBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'TblPatientTableAdapter
        '
        Me.TblPatientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAppointmentTableAdapter = Nothing
        Me.TableAdapterManager.tblConsultationTableAdapter = Nothing
        Me.TableAdapterManager.tblDiseasTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblMedicationTableAdapter = Nothing
        Me.TableAdapterManager.tblPatientTableAdapter = Me.TblPatientTableAdapter
        Me.TableAdapterManager.tblPaymentTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentLineTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Enabled = False
        Me.PatientIDTextBox.Location = New System.Drawing.Point(130, 22)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PatientIDTextBox.TabIndex = 2
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "Firstname", True))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(130, 48)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstnameTextBox.TabIndex = 4
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(130, 74)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SurnameTextBox.TabIndex = 6
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(130, 100)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 8
        '
        'IDNumberTextBox
        '
        Me.IDNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "IDNumber", True))
        Me.IDNumberTextBox.Location = New System.Drawing.Point(130, 126)
        Me.IDNumberTextBox.Name = "IDNumberTextBox"
        Me.IDNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDNumberTextBox.TabIndex = 10
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblPatientBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(130, 152)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 12
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(130, 178)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CityTextBox.TabIndex = 14
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "Province", True))
        Me.ProvinceTextBox.Location = New System.Drawing.Point(130, 204)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProvinceTextBox.TabIndex = 16
        '
        'StreetTextBox
        '
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "Street", True))
        Me.StreetTextBox.Location = New System.Drawing.Point(130, 230)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StreetTextBox.TabIndex = 18
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(130, 256)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ZipCodeTextBox.TabIndex = 20
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(130, 282)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneNumberTextBox.TabIndex = 22
        '
        'MaritalStatusTextBox
        '
        Me.MaritalStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "MaritalStatus", True))
        Me.MaritalStatusTextBox.Location = New System.Drawing.Point(130, 308)
        Me.MaritalStatusTextBox.Name = "MaritalStatusTextBox"
        Me.MaritalStatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MaritalStatusTextBox.TabIndex = 24
        '
        'MedicalAidNameTextBox
        '
        Me.MedicalAidNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "MedicalAidName", True))
        Me.MedicalAidNameTextBox.Location = New System.Drawing.Point(130, 334)
        Me.MedicalAidNameTextBox.Name = "MedicalAidNameTextBox"
        Me.MedicalAidNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MedicalAidNameTextBox.TabIndex = 26
        '
        'MedicalAidNoTextBox
        '
        Me.MedicalAidNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "MedicalAidNo", True))
        Me.MedicalAidNoTextBox.Location = New System.Drawing.Point(130, 360)
        Me.MedicalAidNoTextBox.Name = "MedicalAidNoTextBox"
        Me.MedicalAidNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MedicalAidNoTextBox.TabIndex = 28
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(414, 146)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'MedicalAidDependLabel
        '
        MedicalAidDependLabel.AutoSize = True
        MedicalAidDependLabel.Location = New System.Drawing.Point(18, 389)
        MedicalAidDependLabel.Name = "MedicalAidDependLabel"
        MedicalAidDependLabel.Size = New System.Drawing.Size(106, 13)
        MedicalAidDependLabel.TabIndex = 29
        MedicalAidDependLabel.Text = "Medical Aid Depend:"
        '
        'MedicalAidDependTextBox
        '
        Me.MedicalAidDependTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "MedicalAidDepend", True))
        Me.MedicalAidDependTextBox.Location = New System.Drawing.Point(130, 386)
        Me.MedicalAidDependTextBox.Name = "MedicalAidDependTextBox"
        Me.MedicalAidDependTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MedicalAidDependTextBox.TabIndex = 30
        '
        'MedicalAidOptionsLabel
        '
        MedicalAidOptionsLabel.AutoSize = True
        MedicalAidOptionsLabel.Location = New System.Drawing.Point(20, 419)
        MedicalAidOptionsLabel.Name = "MedicalAidOptionsLabel"
        MedicalAidOptionsLabel.Size = New System.Drawing.Size(104, 13)
        MedicalAidOptionsLabel.TabIndex = 31
        MedicalAidOptionsLabel.Text = "Medical Aid Options:"
        '
        'MedicalAidOptionsTextBox
        '
        Me.MedicalAidOptionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "MedicalAidOptions", True))
        Me.MedicalAidOptionsTextBox.Location = New System.Drawing.Point(130, 416)
        Me.MedicalAidOptionsTextBox.Name = "MedicalAidOptionsTextBox"
        Me.MedicalAidOptionsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MedicalAidOptionsTextBox.TabIndex = 32
        '
        'frmUpdatePatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(534, 458)
        Me.Controls.Add(MedicalAidOptionsLabel)
        Me.Controls.Add(Me.MedicalAidOptionsTextBox)
        Me.Controls.Add(MedicalAidDependLabel)
        Me.Controls.Add(Me.MedicalAidDependTextBox)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(FirstnameLabel)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(IDNumberLabel)
        Me.Controls.Add(Me.IDNumberTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(ProvinceLabel)
        Me.Controls.Add(Me.ProvinceTextBox)
        Me.Controls.Add(StreetLabel)
        Me.Controls.Add(Me.StreetTextBox)
        Me.Controls.Add(ZipCodeLabel)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(MaritalStatusLabel)
        Me.Controls.Add(Me.MaritalStatusTextBox)
        Me.Controls.Add(MedicalAidNameLabel)
        Me.Controls.Add(Me.MedicalAidNameTextBox)
        Me.Controls.Add(MedicalAidNoLabel)
        Me.Controls.Add(Me.MedicalAidNoTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmUpdatePatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Patient Information"
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents TableAdapterManager As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StreetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaritalStatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedicalAidNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedicalAidNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents MedicalAidDependTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedicalAidOptionsTextBox As System.Windows.Forms.TextBox
End Class
