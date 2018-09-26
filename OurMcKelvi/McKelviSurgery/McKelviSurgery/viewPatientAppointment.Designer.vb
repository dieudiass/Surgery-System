<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewPatientAppointment
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
        Me.TblPatientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCancel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdoPassportNo = New System.Windows.Forms.RadioButton()
        Me.rdoIDNumber = New System.Windows.Forms.RadioButton()
        Me.rdoPhoneNumber = New System.Windows.Forms.RadioButton()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneError = New System.Windows.Forms.Label()
        Me.TblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblEmployeeTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblEmployeeTableAdapter()
        Me.TblAppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rdoSurname = New System.Windows.Forms.RadioButton()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TblAppointmentTableAdapter
        '
        Me.TblAppointmentTableAdapter.ClearBeforeFill = True
        '
        'TblPatientDataGridView
        '
        Me.TblPatientDataGridView.AllowUserToAddRows = False
        Me.TblPatientDataGridView.AllowUserToDeleteRows = False
        Me.TblPatientDataGridView.AutoGenerateColumns = False
        Me.TblPatientDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.TblPatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.PhoneNumber, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.btnPrint, Me.btnCancel, Me.btnUpdate})
        Me.TblPatientDataGridView.DataSource = Me.TblPatientBindingSource
        Me.TblPatientDataGridView.Location = New System.Drawing.Point(12, 155)
        Me.TblPatientDataGridView.Name = "TblPatientDataGridView"
        Me.TblPatientDataGridView.ReadOnly = True
        Me.TblPatientDataGridView.Size = New System.Drawing.Size(1171, 198)
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
        '
        'PhoneNumber
        '
        Me.PhoneNumber.DataPropertyName = "PhoneNumber"
        Me.PhoneNumber.HeaderText = "PhoneNumber"
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
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
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "MaritalStatus"
        Me.DataGridViewTextBoxColumn12.HeaderText = "MaritalStatus"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'btnPrint
        '
        Me.btnPrint.HeaderText = "Print"
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ReadOnly = True
        Me.btnPrint.Text = "Print Report"
        Me.btnPrint.UseColumnTextForButtonValue = True
        '
        'btnCancel
        '
        Me.btnCancel.HeaderText = "Cancel"
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ReadOnly = True
        Me.btnCancel.Text = "Cancel Appointment"
        Me.btnCancel.UseColumnTextForButtonValue = True
        Me.btnCancel.Width = 110
        '
        'btnUpdate
        '
        Me.btnUpdate.HeaderText = "Update"
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ReadOnly = True
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Patients Information"
        '
        'rdoPassportNo
        '
        Me.rdoPassportNo.AutoSize = True
        Me.rdoPassportNo.Location = New System.Drawing.Point(458, 22)
        Me.rdoPassportNo.Name = "rdoPassportNo"
        Me.rdoPassportNo.Size = New System.Drawing.Size(106, 17)
        Me.rdoPassportNo.TabIndex = 11
        Me.rdoPassportNo.Text = "Passport Number"
        Me.rdoPassportNo.UseVisualStyleBackColor = True
        '
        'rdoIDNumber
        '
        Me.rdoIDNumber.AutoSize = True
        Me.rdoIDNumber.Location = New System.Drawing.Point(274, 22)
        Me.rdoIDNumber.Name = "rdoIDNumber"
        Me.rdoIDNumber.Size = New System.Drawing.Size(103, 17)
        Me.rdoIDNumber.TabIndex = 10
        Me.rdoIDNumber.Text = "ID South African" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rdoIDNumber.UseVisualStyleBackColor = True
        '
        'rdoPhoneNumber
        '
        Me.rdoPhoneNumber.AutoSize = True
        Me.rdoPhoneNumber.Checked = True
        Me.rdoPhoneNumber.Location = New System.Drawing.Point(104, 22)
        Me.rdoPhoneNumber.Name = "rdoPhoneNumber"
        Me.rdoPhoneNumber.Size = New System.Drawing.Size(96, 17)
        Me.rdoPhoneNumber.TabIndex = 9
        Me.rdoPhoneNumber.TabStop = True
        Me.rdoPhoneNumber.Text = "Phone Number"
        Me.rdoPhoneNumber.UseVisualStyleBackColor = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(310, 61)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(219, 20)
        Me.txtPhoneNumber.TabIndex = 8
        '
        'lblPhoneError
        '
        Me.lblPhoneError.AutoSize = True
        Me.lblPhoneError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneError.ForeColor = System.Drawing.Color.Red
        Me.lblPhoneError.Location = New System.Drawing.Point(297, 84)
        Me.lblPhoneError.Name = "lblPhoneError"
        Me.lblPhoneError.Size = New System.Drawing.Size(0, 15)
        Me.lblPhoneError.TabIndex = 12
        '
        'TblEmployeeBindingSource
        '
        Me.TblEmployeeBindingSource.DataMember = "tblEmployee"
        Me.TblEmployeeBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'TblEmployeeTableAdapter
        '
        Me.TblEmployeeTableAdapter.ClearBeforeFill = True
        '
        'TblAppointmentBindingSource
        '
        Me.TblAppointmentBindingSource.DataMember = "FK_tblAppointment_tblPatient"
        Me.TblAppointmentBindingSource.DataSource = Me.TblPatientBindingSource
        '
        'rdoSurname
        '
        Me.rdoSurname.AutoSize = True
        Me.rdoSurname.Location = New System.Drawing.Point(643, 22)
        Me.rdoSurname.Name = "rdoSurname"
        Me.rdoSurname.Size = New System.Drawing.Size(67, 17)
        Me.rdoSurname.TabIndex = 21
        Me.rdoSurname.Text = "Surname"
        Me.rdoSurname.UseVisualStyleBackColor = True
        '
        'viewPatientAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 390)
        Me.Controls.Add(Me.rdoSurname)
        Me.Controls.Add(Me.lblPhoneError)
        Me.Controls.Add(Me.rdoPassportNo)
        Me.Controls.Add(Me.rdoIDNumber)
        Me.Controls.Add(Me.rdoPhoneNumber)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TblPatientDataGridView)
        Me.Name = "viewPatientAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "view Patient  Appointment"
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents TableAdapterManager As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblAppointmentTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter
    Friend WithEvents TblPatientDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblAppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdoPassportNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIDNumber As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPhoneNumber As System.Windows.Forms.RadioButton
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneError As System.Windows.Forms.Label
    Friend WithEvents TblEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEmployeeTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblEmployeeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnCancel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnUpdate As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents rdoSurname As System.Windows.Forms.RadioButton
End Class
