<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultation))
        Me.TblConsultationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTreatmentLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTreatmentLineBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPatientTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter()
        Me.TblConsultationTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblConsultationTableAdapter()
        Me.TblTreatmentLineTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblTreatmentLineTableAdapter()
        Me.TblTreatmentTableAdapter1 = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblTreatmentTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoFuture = New System.Windows.Forms.RadioButton()
        Me.rdoToday = New System.Windows.Forms.RadioButton()
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.TblPatientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager()
        Me.TblAppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAppointmentTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter()
        Me.TblAppointmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRecordTreatment = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TblPaymentTableAdapter1 = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPaymentTableAdapter()
        CType(Me.TblConsultationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTreatmentLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTreatmentLineBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAppointmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblPatientTableAdapter
        '
        Me.TblPatientTableAdapter.ClearBeforeFill = True
        '
        'TblConsultationTableAdapter
        '
        Me.TblConsultationTableAdapter.ClearBeforeFill = True
        '
        'TblTreatmentLineTableAdapter
        '
        Me.TblTreatmentLineTableAdapter.ClearBeforeFill = True
        '
        'TblTreatmentTableAdapter1
        '
        Me.TblTreatmentTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoFuture)
        Me.GroupBox1.Controls.Add(Me.rdoToday)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appointment"
        '
        'rdoFuture
        '
        Me.rdoFuture.AutoSize = True
        Me.rdoFuture.Location = New System.Drawing.Point(379, 32)
        Me.rdoFuture.Name = "rdoFuture"
        Me.rdoFuture.Size = New System.Drawing.Size(117, 17)
        Me.rdoFuture.TabIndex = 1
        Me.rdoFuture.Text = "Future Appointment"
        Me.rdoFuture.UseVisualStyleBackColor = True
        '
        'rdoToday
        '
        Me.rdoToday.AutoSize = True
        Me.rdoToday.Checked = True
        Me.rdoToday.Location = New System.Drawing.Point(141, 32)
        Me.rdoToday.Name = "rdoToday"
        Me.rdoToday.Size = New System.Drawing.Size(119, 17)
        Me.rdoToday.TabIndex = 0
        Me.rdoToday.TabStop = True
        Me.rdoToday.Text = "Today Appoinments"
        Me.rdoToday.UseVisualStyleBackColor = True
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.EnforceConstraints = False
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatientBindingSource1
        '
        Me.TblPatientBindingSource1.DataMember = "tblPatient"
        Me.TblPatientBindingSource1.DataSource = Me.McKelviSurgDBDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAppointmentTableAdapter = Nothing
        Me.TableAdapterManager.tblConsultationTableAdapter = Me.TblConsultationTableAdapter
        Me.TableAdapterManager.tblDiseasTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblMedicationTableAdapter = Nothing
        Me.TableAdapterManager.tblPatientTableAdapter = Me.TblPatientTableAdapter
        Me.TableAdapterManager.tblPaymentTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentLineTableAdapter = Me.TblTreatmentLineTableAdapter
        Me.TableAdapterManager.tblTreatmentTableAdapter = Me.TblTreatmentTableAdapter1
        Me.TableAdapterManager.UpdateOrder = McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblAppointmentBindingSource
        '
        Me.TblAppointmentBindingSource.DataMember = "tblAppointment"
        Me.TblAppointmentBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'TblAppointmentTableAdapter
        '
        Me.TblAppointmentTableAdapter.ClearBeforeFill = True
        '
        'TblAppointmentDataGridView
        '
        Me.TblAppointmentDataGridView.AllowUserToAddRows = False
        Me.TblAppointmentDataGridView.AllowUserToDeleteRows = False
        Me.TblAppointmentDataGridView.AutoGenerateColumns = False
        Me.TblAppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblAppointmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.btnRecordTreatment})
        Me.TblAppointmentDataGridView.DataSource = Me.TblAppointmentBindingSource
        Me.TblAppointmentDataGridView.Location = New System.Drawing.Point(24, 148)
        Me.TblAppointmentDataGridView.Name = "TblAppointmentDataGridView"
        Me.TblAppointmentDataGridView.ReadOnly = True
        Me.TblAppointmentDataGridView.Size = New System.Drawing.Size(625, 220)
        Me.TblAppointmentDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AppID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AppID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AppointmentDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AppointmentDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StartingTime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StartingTime"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FinishTime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FinishTime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EmployeeID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "EmployeeID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DiseasID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DiseasID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'btnRecordTreatment
        '
        Me.btnRecordTreatment.HeaderText = "Record Treatment"
        Me.btnRecordTreatment.Name = "btnRecordTreatment"
        Me.btnRecordTreatment.ReadOnly = True
        Me.btnRecordTreatment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnRecordTreatment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnRecordTreatment.Text = "Record Treatment"
        Me.btnRecordTreatment.UseColumnTextForButtonValue = True
        Me.btnRecordTreatment.Width = 120
        '
        'TblPaymentTableAdapter1
        '
        Me.TblPaymentTableAdapter1.ClearBeforeFill = True
        '
        'frmConsultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(880, 497)
        Me.Controls.Add(Me.TblAppointmentDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConsultation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultation Form"
        CType(Me.TblConsultationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTreatmentLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTreatmentLineBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAppointmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblConsultationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblConsultationTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblConsultationTableAdapter
    Friend WithEvents TblTreatmentLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTreatmentLineTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblTreatmentLineTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblTreatmentTableAdapter1 As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblTreatmentTableAdapter
    Friend WithEvents TblTreatmentLineBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoFuture As System.Windows.Forms.RadioButton
    Friend WithEvents rdoToday As System.Windows.Forms.RadioButton
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblPatientBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblAppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAppointmentTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter
    Friend WithEvents TblAppointmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRecordTreatment As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TblPaymentTableAdapter1 As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPaymentTableAdapter
End Class
