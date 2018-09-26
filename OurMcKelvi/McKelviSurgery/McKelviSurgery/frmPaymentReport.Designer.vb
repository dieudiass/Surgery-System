<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentReport
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
        Me.TblPaymentTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPaymentTableAdapter()
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
        Me.TblPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPaymentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rdoSurname = New System.Windows.Forms.RadioButton()
        Me.rdoPassportNo = New System.Windows.Forms.RadioButton()
        Me.rdoIDNumber = New System.Windows.Forms.RadioButton()
        Me.rdoPhoneNumber = New System.Windows.Forms.RadioButton()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneError = New System.Windows.Forms.Label()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPaymentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.tblAppointmentTableAdapter = Nothing
        Me.TableAdapterManager.tblConsultationTableAdapter = Nothing
        Me.TableAdapterManager.tblDiseasTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblMedicationTableAdapter = Nothing
        Me.TableAdapterManager.tblPatientTableAdapter = Me.TblPatientTableAdapter
        Me.TableAdapterManager.tblPaymentTableAdapter = Me.TblPaymentTableAdapter
        Me.TableAdapterManager.tblTreatmentLineTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPaymentTableAdapter
        '
        Me.TblPaymentTableAdapter.ClearBeforeFill = True
        '
        'TblPatientDataGridView
        '
        Me.TblPatientDataGridView.AllowUserToAddRows = False
        Me.TblPatientDataGridView.AllowUserToDeleteRows = False
        Me.TblPatientDataGridView.AutoGenerateColumns = False
        Me.TblPatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.TblPatientDataGridView.DataSource = Me.TblPatientBindingSource
        Me.TblPatientDataGridView.Location = New System.Drawing.Point(31, 145)
        Me.TblPatientDataGridView.Name = "TblPatientDataGridView"
        Me.TblPatientDataGridView.ReadOnly = True
        Me.TblPatientDataGridView.Size = New System.Drawing.Size(641, 243)
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
        Me.DataGridViewTextBoxColumn7.Visible = False
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
        Me.DataGridViewTextBoxColumn12.Visible = False
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
        'TblPaymentBindingSource
        '
        Me.TblPaymentBindingSource.DataMember = "FK_tblPayment_tblPatient"
        Me.TblPaymentBindingSource.DataSource = Me.TblPatientBindingSource
        '
        'TblPaymentDataGridView
        '
        Me.TblPaymentDataGridView.AllowUserToAddRows = False
        Me.TblPaymentDataGridView.AllowUserToDeleteRows = False
        Me.TblPaymentDataGridView.AutoGenerateColumns = False
        Me.TblPaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPaymentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.btnPrint})
        Me.TblPaymentDataGridView.DataSource = Me.TblPaymentBindingSource
        Me.TblPaymentDataGridView.Location = New System.Drawing.Point(31, 394)
        Me.TblPaymentDataGridView.Name = "TblPaymentDataGridView"
        Me.TblPaymentDataGridView.ReadOnly = True
        Me.TblPaymentDataGridView.Size = New System.Drawing.Size(641, 265)
        Me.TblPaymentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PaymentID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "PaymentID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PaymentDate"
        Me.DataGridViewTextBoxColumn18.HeaderText = "PaymentDate"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "AmountDue"
        Me.DataGridViewTextBoxColumn19.HeaderText = "AmountDue"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "PaymentType"
        Me.DataGridViewTextBoxColumn20.HeaderText = "PaymentType"
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
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "AppID"
        Me.DataGridViewTextBoxColumn23.HeaderText = "AppID"
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
        Me.Label13.Location = New System.Drawing.Point(220, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(251, 26)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Print Payement Report"
        '
        'rdoSurname
        '
        Me.rdoSurname.AutoSize = True
        Me.rdoSurname.Location = New System.Drawing.Point(560, 79)
        Me.rdoSurname.Name = "rdoSurname"
        Me.rdoSurname.Size = New System.Drawing.Size(67, 17)
        Me.rdoSurname.TabIndex = 13
        Me.rdoSurname.Text = "Surname"
        Me.rdoSurname.UseVisualStyleBackColor = True
        '
        'rdoPassportNo
        '
        Me.rdoPassportNo.AutoSize = True
        Me.rdoPassportNo.Location = New System.Drawing.Point(397, 79)
        Me.rdoPassportNo.Name = "rdoPassportNo"
        Me.rdoPassportNo.Size = New System.Drawing.Size(106, 17)
        Me.rdoPassportNo.TabIndex = 12
        Me.rdoPassportNo.Text = "Passport Number"
        Me.rdoPassportNo.UseVisualStyleBackColor = True
        '
        'rdoIDNumber
        '
        Me.rdoIDNumber.AutoSize = True
        Me.rdoIDNumber.Location = New System.Drawing.Point(236, 79)
        Me.rdoIDNumber.Name = "rdoIDNumber"
        Me.rdoIDNumber.Size = New System.Drawing.Size(103, 17)
        Me.rdoIDNumber.TabIndex = 11
        Me.rdoIDNumber.Text = "ID South African" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rdoIDNumber.UseVisualStyleBackColor = True
        '
        'rdoPhoneNumber
        '
        Me.rdoPhoneNumber.AutoSize = True
        Me.rdoPhoneNumber.Checked = True
        Me.rdoPhoneNumber.Location = New System.Drawing.Point(77, 79)
        Me.rdoPhoneNumber.Name = "rdoPhoneNumber"
        Me.rdoPhoneNumber.Size = New System.Drawing.Size(96, 17)
        Me.rdoPhoneNumber.TabIndex = 10
        Me.rdoPhoneNumber.TabStop = True
        Me.rdoPhoneNumber.Text = "Phone Number"
        Me.rdoPhoneNumber.UseVisualStyleBackColor = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(216, 119)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(204, 20)
        Me.txtPhoneNumber.TabIndex = 14
        '
        'lblPhoneError
        '
        Me.lblPhoneError.AutoSize = True
        Me.lblPhoneError.Location = New System.Drawing.Point(445, 119)
        Me.lblPhoneError.Name = "lblPhoneError"
        Me.lblPhoneError.Size = New System.Drawing.Size(10, 13)
        Me.lblPhoneError.TabIndex = 15
        Me.lblPhoneError.Text = " "
        '
        'frmPaymentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(768, 662)
        Me.Controls.Add(Me.lblPhoneError)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.rdoSurname)
        Me.Controls.Add(Me.rdoPassportNo)
        Me.Controls.Add(Me.rdoIDNumber)
        Me.Controls.Add(Me.rdoPhoneNumber)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TblPaymentDataGridView)
        Me.Controls.Add(Me.TblPatientDataGridView)
        Me.Name = "frmPaymentReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Individual Payment Report Form"
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPaymentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents TableAdapterManager As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblPaymentTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPaymentTableAdapter
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
    Friend WithEvents TblPaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPaymentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rdoSurname As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPassportNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIDNumber As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPhoneNumber As System.Windows.Forms.RadioButton
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneError As System.Windows.Forms.Label
End Class
