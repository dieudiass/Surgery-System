<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cus
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
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
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMakeBooking = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCancel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblPhoneError = New System.Windows.Forms.Label()
        Me.rdoPhoneNumber = New System.Windows.Forms.RadioButton()
        Me.rdoIDNumber = New System.Windows.Forms.RadioButton()
        Me.rdoPassportNo = New System.Windows.Forms.RadioButton()
        Me.TblPatientTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter()
        Me.TableAdapterManager = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager()
        Me.TblAppointmentTableAdapter1 = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rdoSurname = New System.Windows.Forms.RadioButton()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblPatientBindingSource
        '
        Me.TblPatientBindingSource.DataMember = "tblPatient"
        Me.TblPatientBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatientDataGridView
        '
        Me.TblPatientDataGridView.AllowUserToAddRows = False
        Me.TblPatientDataGridView.AllowUserToDeleteRows = False
        Me.TblPatientDataGridView.AutoGenerateColumns = False
        Me.TblPatientDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.TblPatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.PhoneNumber, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.btnMakeBooking, Me.btnCancel})
        Me.TblPatientDataGridView.DataSource = Me.TblPatientBindingSource
        Me.TblPatientDataGridView.Location = New System.Drawing.Point(3, 147)
        Me.TblPatientDataGridView.Name = "TblPatientDataGridView"
        Me.TblPatientDataGridView.ReadOnly = True
        Me.TblPatientDataGridView.Size = New System.Drawing.Size(1069, 303)
        Me.TblPatientDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PatientID"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
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
        'PhoneNumber
        '
        Me.PhoneNumber.DataPropertyName = "PhoneNumber"
        Me.PhoneNumber.HeaderText = "Phone  Number"
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.ReadOnly = True
        Me.PhoneNumber.Width = 120
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
        'btnMakeBooking
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Make Booking"
        Me.btnMakeBooking.DefaultCellStyle = DataGridViewCellStyle2
        Me.btnMakeBooking.HeaderText = "Make Booking"
        Me.btnMakeBooking.Name = "btnMakeBooking"
        Me.btnMakeBooking.ReadOnly = True
        Me.btnMakeBooking.Text = "Make Booking"
        Me.btnMakeBooking.UseColumnTextForButtonValue = True
        Me.btnMakeBooking.Width = 150
        '
        'btnCancel
        '
        Me.btnCancel.HeaderText = "Cancel Appointment"
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.ReadOnly = True
        Me.btnCancel.Text = "Cancel Appointment"
        Me.btnCancel.UseColumnTextForButtonValue = True
        Me.btnCancel.Width = 110
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(200, 121)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(204, 20)
        Me.txtPhoneNumber.TabIndex = 2
        '
        'lblPhoneError
        '
        Me.lblPhoneError.AutoSize = True
        Me.lblPhoneError.ForeColor = System.Drawing.Color.Red
        Me.lblPhoneError.Location = New System.Drawing.Point(212, 105)
        Me.lblPhoneError.Name = "lblPhoneError"
        Me.lblPhoneError.Size = New System.Drawing.Size(0, 13)
        Me.lblPhoneError.TabIndex = 4
        '
        'rdoPhoneNumber
        '
        Me.rdoPhoneNumber.AutoSize = True
        Me.rdoPhoneNumber.Checked = True
        Me.rdoPhoneNumber.Location = New System.Drawing.Point(105, 73)
        Me.rdoPhoneNumber.Name = "rdoPhoneNumber"
        Me.rdoPhoneNumber.Size = New System.Drawing.Size(96, 17)
        Me.rdoPhoneNumber.TabIndex = 5
        Me.rdoPhoneNumber.TabStop = True
        Me.rdoPhoneNumber.Text = "Phone Number"
        Me.rdoPhoneNumber.UseVisualStyleBackColor = True
        '
        'rdoIDNumber
        '
        Me.rdoIDNumber.AutoSize = True
        Me.rdoIDNumber.Location = New System.Drawing.Point(264, 73)
        Me.rdoIDNumber.Name = "rdoIDNumber"
        Me.rdoIDNumber.Size = New System.Drawing.Size(103, 17)
        Me.rdoIDNumber.TabIndex = 6
        Me.rdoIDNumber.Text = "ID South African" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rdoIDNumber.UseVisualStyleBackColor = True
        '
        'rdoPassportNo
        '
        Me.rdoPassportNo.AutoSize = True
        Me.rdoPassportNo.Location = New System.Drawing.Point(425, 73)
        Me.rdoPassportNo.Name = "rdoPassportNo"
        Me.rdoPassportNo.Size = New System.Drawing.Size(106, 17)
        Me.rdoPassportNo.TabIndex = 7
        Me.rdoPassportNo.Text = "Passport Number"
        Me.rdoPassportNo.UseVisualStyleBackColor = True
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
        'TblAppointmentTableAdapter1
        '
        Me.TblAppointmentTableAdapter1.ClearBeforeFill = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(241, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 26)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Search Patient"
        '
        'rdoSurname
        '
        Me.rdoSurname.AutoSize = True
        Me.rdoSurname.Location = New System.Drawing.Point(588, 73)
        Me.rdoSurname.Name = "rdoSurname"
        Me.rdoSurname.Size = New System.Drawing.Size(67, 17)
        Me.rdoSurname.TabIndex = 9
        Me.rdoSurname.Text = "Surname"
        Me.rdoSurname.UseVisualStyleBackColor = True
        '
        'cus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1135, 485)
        Me.Controls.Add(Me.rdoSurname)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.rdoPassportNo)
        Me.Controls.Add(Me.rdoIDNumber)
        Me.Controls.Add(Me.rdoPhoneNumber)
        Me.Controls.Add(Me.lblPhoneError)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.TblPatientDataGridView)
        Me.Name = "cus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Patient Form"
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents TableAdapterManager As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblPatientDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneError As System.Windows.Forms.Label
    Friend WithEvents rdoPhoneNumber As System.Windows.Forms.RadioButton
    Friend WithEvents rdoIDNumber As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPassportNo As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblAppointmentTableAdapter1 As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnMakeBooking As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnCancel As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents rdoSurname As System.Windows.Forms.RadioButton
End Class
