<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreatmentReport
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
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.TblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPatientTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter()
        Me.TableAdapterManager = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager()
        Me.TblAppointmentTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter()
        Me.TblConsultationTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblConsultationTableAdapter()
        Me.TblPatientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblAppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAppointmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblConsultationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblConsultationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rdoSurname = New System.Windows.Forms.RadioButton()
        Me.rdoPassportNo = New System.Windows.Forms.RadioButton()
        Me.rdoIDNumber = New System.Windows.Forms.RadioButton()
        Me.rdoPhoneNumber = New System.Windows.Forms.RadioButton()
        Me.lblPhoneError = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblConsultationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblConsultationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.tblAppointmentTableAdapter = Me.TblAppointmentTableAdapter
        Me.TableAdapterManager.tblConsultationTableAdapter = Me.TblConsultationTableAdapter
        Me.TableAdapterManager.tblDiseasTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblMedicationTableAdapter = Nothing
        Me.TableAdapterManager.tblPatientTableAdapter = Me.TblPatientTableAdapter
        Me.TableAdapterManager.tblPaymentTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentLineTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblAppointmentTableAdapter
        '
        Me.TblAppointmentTableAdapter.ClearBeforeFill = True
        '
        'TblConsultationTableAdapter
        '
        Me.TblConsultationTableAdapter.ClearBeforeFill = True
        '
        'TblPatientDataGridView
        '
        Me.TblPatientDataGridView.AllowUserToAddRows = False
        Me.TblPatientDataGridView.AllowUserToDeleteRows = False
        Me.TblPatientDataGridView.AutoGenerateColumns = False
        Me.TblPatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.TblPatientDataGridView.DataSource = Me.TblPatientBindingSource
        Me.TblPatientDataGridView.Location = New System.Drawing.Point(12, 111)
        Me.TblPatientDataGridView.Name = "TblPatientDataGridView"
        Me.TblPatientDataGridView.ReadOnly = True
        Me.TblPatientDataGridView.Size = New System.Drawing.Size(639, 211)
        Me.TblPatientDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Firstname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Firstname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IDNumber"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IDNumber"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn7.HeaderText = "City"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Province"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Province"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Street"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Street"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ZipCode"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ZipCode"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "MaritalStatus"
        Me.DataGridViewTextBoxColumn12.HeaderText = "MaritalStatus"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "MedicalAidName"
        Me.DataGridViewTextBoxColumn13.HeaderText = "MedicalAidName"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "MedicalAidNo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "MedicalAidNo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "MedicalAidDepend"
        Me.DataGridViewTextBoxColumn15.HeaderText = "MedicalAidDepend"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "MedicalAidOptions"
        Me.DataGridViewTextBoxColumn16.HeaderText = "MedicalAidOptions"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'TblAppointmentBindingSource
        '
        Me.TblAppointmentBindingSource.DataMember = "FK_tblAppointment_tblPatient"
        Me.TblAppointmentBindingSource.DataSource = Me.TblPatientBindingSource
        '
        'TblAppointmentDataGridView
        '
        Me.TblAppointmentDataGridView.AllowUserToAddRows = False
        Me.TblAppointmentDataGridView.AllowUserToDeleteRows = False
        Me.TblAppointmentDataGridView.AutoGenerateColumns = False
        Me.TblAppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblAppointmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.TblAppointmentDataGridView.DataSource = Me.TblAppointmentBindingSource
        Me.TblAppointmentDataGridView.Location = New System.Drawing.Point(12, 328)
        Me.TblAppointmentDataGridView.Name = "TblAppointmentDataGridView"
        Me.TblAppointmentDataGridView.ReadOnly = True
        Me.TblAppointmentDataGridView.Size = New System.Drawing.Size(639, 174)
        Me.TblAppointmentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "AppID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "AppID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "AppointmentDate"
        Me.DataGridViewTextBoxColumn18.HeaderText = "AppointmentDate"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "StartingTime"
        Me.DataGridViewTextBoxColumn19.HeaderText = "StartingTime"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "FinishTime"
        Me.DataGridViewTextBoxColumn20.HeaderText = "FinishTime"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "EmployeeID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "EmployeeID"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn22.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Visible = False
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "DiseasID"
        Me.DataGridViewTextBoxColumn23.HeaderText = "DiseasID"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'TblConsultationBindingSource
        '
        Me.TblConsultationBindingSource.DataMember = "FK_tblConsultation_tblAppointment"
        Me.TblConsultationBindingSource.DataSource = Me.TblAppointmentBindingSource
        '
        'TblConsultationDataGridView
        '
        Me.TblConsultationDataGridView.AllowUserToAddRows = False
        Me.TblConsultationDataGridView.AllowUserToDeleteRows = False
        Me.TblConsultationDataGridView.AutoGenerateColumns = False
        Me.TblConsultationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblConsultationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.btnPrint})
        Me.TblConsultationDataGridView.DataSource = Me.TblConsultationBindingSource
        Me.TblConsultationDataGridView.Location = New System.Drawing.Point(12, 508)
        Me.TblConsultationDataGridView.Name = "TblConsultationDataGridView"
        Me.TblConsultationDataGridView.ReadOnly = True
        Me.TblConsultationDataGridView.Size = New System.Drawing.Size(639, 228)
        Me.TblConsultationDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "ConsultID"
        Me.DataGridViewTextBoxColumn25.HeaderText = "ConsultID"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Symptoms"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Symptoms"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "AppID"
        Me.DataGridViewTextBoxColumn27.HeaderText = "AppID"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'btnPrint
        '
        Me.btnPrint.HeaderText = "Print Report"
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ReadOnly = True
        Me.btnPrint.Text = "Print Report"
        Me.btnPrint.UseColumnTextForButtonValue = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(219, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(267, 26)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Print Medication Report"
        '
        'rdoSurname
        '
        Me.rdoSurname.AutoSize = True
        Me.rdoSurname.Location = New System.Drawing.Point(578, 50)
        Me.rdoSurname.Name = "rdoSurname"
        Me.rdoSurname.Size = New System.Drawing.Size(67, 17)
        Me.rdoSurname.TabIndex = 17
        Me.rdoSurname.Text = "Surname"
        Me.rdoSurname.UseVisualStyleBackColor = True
        '
        'rdoPassportNo
        '
        Me.rdoPassportNo.AutoSize = True
        Me.rdoPassportNo.Location = New System.Drawing.Point(415, 50)
        Me.rdoPassportNo.Name = "rdoPassportNo"
        Me.rdoPassportNo.Size = New System.Drawing.Size(106, 17)
        Me.rdoPassportNo.TabIndex = 16
        Me.rdoPassportNo.Text = "Passport Number"
        Me.rdoPassportNo.UseVisualStyleBackColor = True
        '
        'rdoIDNumber
        '
        Me.rdoIDNumber.AutoSize = True
        Me.rdoIDNumber.Location = New System.Drawing.Point(254, 50)
        Me.rdoIDNumber.Name = "rdoIDNumber"
        Me.rdoIDNumber.Size = New System.Drawing.Size(103, 17)
        Me.rdoIDNumber.TabIndex = 15
        Me.rdoIDNumber.Text = "ID South African" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rdoIDNumber.UseVisualStyleBackColor = True
        '
        'rdoPhoneNumber
        '
        Me.rdoPhoneNumber.AutoSize = True
        Me.rdoPhoneNumber.Checked = True
        Me.rdoPhoneNumber.Location = New System.Drawing.Point(95, 50)
        Me.rdoPhoneNumber.Name = "rdoPhoneNumber"
        Me.rdoPhoneNumber.Size = New System.Drawing.Size(96, 17)
        Me.rdoPhoneNumber.TabIndex = 14
        Me.rdoPhoneNumber.TabStop = True
        Me.rdoPhoneNumber.Text = "Phone Number"
        Me.rdoPhoneNumber.UseVisualStyleBackColor = True
        '
        'lblPhoneError
        '
        Me.lblPhoneError.AutoSize = True
        Me.lblPhoneError.Location = New System.Drawing.Point(435, 85)
        Me.lblPhoneError.Name = "lblPhoneError"
        Me.lblPhoneError.Size = New System.Drawing.Size(10, 13)
        Me.lblPhoneError.TabIndex = 19
        Me.lblPhoneError.Text = " "
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(206, 85)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(204, 20)
        Me.txtPhoneNumber.TabIndex = 18
        '
        'frmTreatmentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(798, 737)
        Me.Controls.Add(Me.lblPhoneError)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.rdoSurname)
        Me.Controls.Add(Me.rdoPassportNo)
        Me.Controls.Add(Me.rdoIDNumber)
        Me.Controls.Add(Me.rdoPhoneNumber)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TblConsultationDataGridView)
        Me.Controls.Add(Me.TblAppointmentDataGridView)
        Me.Controls.Add(Me.TblPatientDataGridView)
        Me.Name = "frmTreatmentReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Individual Medication Report Form"
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblConsultationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblConsultationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents TableAdapterManager As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblPatientDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblAppointmentTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter
    Friend WithEvents TblAppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblConsultationTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblConsultationTableAdapter
    Friend WithEvents TblAppointmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblConsultationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblConsultationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rdoSurname As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPassportNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIDNumber As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPhoneNumber As System.Windows.Forms.RadioButton
    Friend WithEvents lblPhoneError As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
End Class
