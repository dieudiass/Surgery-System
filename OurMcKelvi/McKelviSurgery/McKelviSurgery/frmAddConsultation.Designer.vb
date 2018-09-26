<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddConsultation
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
        Dim SymptomsLabel As System.Windows.Forms.Label
        Dim AppIDLabel As System.Windows.Forms.Label
        Dim AppointmentDateLabel As System.Windows.Forms.Label
        Dim StartingTimeLabel As System.Windows.Forms.Label
        Dim FinishTimeLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.TblConsultationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblConsultationTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblConsultationTableAdapter()
        Me.TableAdapterManager = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager()
        Me.TblAppointmentTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter()
        Me.TblPatientTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter()
        Me.SymptomsTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AppIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblAppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartingTimeTextBox = New System.Windows.Forms.TextBox()
        Me.FinishTimeTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        SymptomsLabel = New System.Windows.Forms.Label()
        AppIDLabel = New System.Windows.Forms.Label()
        AppointmentDateLabel = New System.Windows.Forms.Label()
        StartingTimeLabel = New System.Windows.Forms.Label()
        FinishTimeLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblConsultationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SymptomsLabel
        '
        SymptomsLabel.AutoSize = True
        SymptomsLabel.Location = New System.Drawing.Point(138, 271)
        SymptomsLabel.Name = "SymptomsLabel"
        SymptomsLabel.Size = New System.Drawing.Size(58, 13)
        SymptomsLabel.TabIndex = 3
        SymptomsLabel.Text = "Symptoms:"
        '
        'AppIDLabel
        '
        AppIDLabel.AutoSize = True
        AppIDLabel.Location = New System.Drawing.Point(18, 32)
        AppIDLabel.Name = "AppIDLabel"
        AppIDLabel.Size = New System.Drawing.Size(43, 13)
        AppIDLabel.TabIndex = 0
        AppIDLabel.Text = "App ID:"
        '
        'AppointmentDateLabel
        '
        AppointmentDateLabel.AutoSize = True
        AppointmentDateLabel.Location = New System.Drawing.Point(18, 59)
        AppointmentDateLabel.Name = "AppointmentDateLabel"
        AppointmentDateLabel.Size = New System.Drawing.Size(95, 13)
        AppointmentDateLabel.TabIndex = 2
        AppointmentDateLabel.Text = "Appointment Date:"
        '
        'StartingTimeLabel
        '
        StartingTimeLabel.AutoSize = True
        StartingTimeLabel.Location = New System.Drawing.Point(18, 84)
        StartingTimeLabel.Name = "StartingTimeLabel"
        StartingTimeLabel.Size = New System.Drawing.Size(72, 13)
        StartingTimeLabel.TabIndex = 4
        StartingTimeLabel.Text = "Starting Time:"
        '
        'FinishTimeLabel
        '
        FinishTimeLabel.AutoSize = True
        FinishTimeLabel.Location = New System.Drawing.Point(18, 110)
        FinishTimeLabel.Name = "FinishTimeLabel"
        FinishTimeLabel.Size = New System.Drawing.Size(63, 13)
        FinishTimeLabel.TabIndex = 6
        FinishTimeLabel.Text = "Finish Time:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(18, 136)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 14
        StatusLabel.Text = "Status:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(52, 35)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(57, 13)
        PatientIDLabel.TabIndex = 0
        PatientIDLabel.Text = "Patient ID:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(52, 61)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(55, 13)
        FirstnameLabel.TabIndex = 2
        FirstnameLabel.Text = "Firstname:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(52, 87)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 4
        SurnameLabel.Text = "Surname:"
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblConsultationBindingSource
        '
        Me.TblConsultationBindingSource.DataMember = "tblConsultation"
        Me.TblConsultationBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'TblConsultationTableAdapter
        '
        Me.TblConsultationTableAdapter.ClearBeforeFill = True
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
        'TblPatientTableAdapter
        '
        Me.TblPatientTableAdapter.ClearBeforeFill = True
        '
        'SymptomsTextBox
        '
        Me.SymptomsTextBox.Location = New System.Drawing.Point(230, 271)
        Me.SymptomsTextBox.Multiline = True
        Me.SymptomsTextBox.Name = "SymptomsTextBox"
        Me.SymptomsTextBox.Size = New System.Drawing.Size(257, 144)
        Me.SymptomsTextBox.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(AppIDLabel)
        Me.GroupBox1.Controls.Add(Me.AppIDTextBox)
        Me.GroupBox1.Controls.Add(AppointmentDateLabel)
        Me.GroupBox1.Controls.Add(Me.AppointmentDateDateTimePicker)
        Me.GroupBox1.Controls.Add(StartingTimeLabel)
        Me.GroupBox1.Controls.Add(Me.StartingTimeTextBox)
        Me.GroupBox1.Controls.Add(FinishTimeLabel)
        Me.GroupBox1.Controls.Add(Me.FinishTimeTextBox)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 207)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Appointment"
        '
        'AppIDTextBox
        '
        Me.AppIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAppointmentBindingSource, "AppID", True))
        Me.AppIDTextBox.Enabled = False
        Me.AppIDTextBox.Location = New System.Drawing.Point(119, 29)
        Me.AppIDTextBox.Name = "AppIDTextBox"
        Me.AppIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AppIDTextBox.TabIndex = 1
        '
        'TblAppointmentBindingSource
        '
        Me.TblAppointmentBindingSource.DataMember = "tblAppointment"
        Me.TblAppointmentBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'AppointmentDateDateTimePicker
        '
        Me.AppointmentDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblAppointmentBindingSource, "AppointmentDate", True))
        Me.AppointmentDateDateTimePicker.Enabled = False
        Me.AppointmentDateDateTimePicker.Location = New System.Drawing.Point(119, 55)
        Me.AppointmentDateDateTimePicker.Name = "AppointmentDateDateTimePicker"
        Me.AppointmentDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AppointmentDateDateTimePicker.TabIndex = 3
        '
        'StartingTimeTextBox
        '
        Me.StartingTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAppointmentBindingSource, "StartingTime", True))
        Me.StartingTimeTextBox.Enabled = False
        Me.StartingTimeTextBox.Location = New System.Drawing.Point(119, 81)
        Me.StartingTimeTextBox.Name = "StartingTimeTextBox"
        Me.StartingTimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StartingTimeTextBox.TabIndex = 5
        '
        'FinishTimeTextBox
        '
        Me.FinishTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAppointmentBindingSource, "FinishTime", True))
        Me.FinishTimeTextBox.Enabled = False
        Me.FinishTimeTextBox.Location = New System.Drawing.Point(119, 107)
        Me.FinishTimeTextBox.Name = "FinishTimeTextBox"
        Me.FinishTimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FinishTimeTextBox.TabIndex = 7
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblAppointmentBindingSource, "Status", True))
        Me.StatusTextBox.Enabled = False
        Me.StatusTextBox.Location = New System.Drawing.Point(119, 133)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(572, 311)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 34)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(PatientIDLabel)
        Me.GroupBox2.Controls.Add(Me.PatientIDTextBox)
        Me.GroupBox2.Controls.Add(FirstnameLabel)
        Me.GroupBox2.Controls.Add(Me.FirstnameTextBox)
        Me.GroupBox2.Controls.Add(SurnameLabel)
        Me.GroupBox2.Controls.Add(Me.SurnameTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(386, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 207)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Information"
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Enabled = False
        Me.PatientIDTextBox.Location = New System.Drawing.Point(154, 32)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PatientIDTextBox.TabIndex = 1
        '
        'TblPatientBindingSource
        '
        Me.TblPatientBindingSource.DataMember = "tblPatient"
        Me.TblPatientBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "Firstname", True))
        Me.FirstnameTextBox.Enabled = False
        Me.FirstnameTextBox.Location = New System.Drawing.Point(154, 58)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstnameTextBox.TabIndex = 3
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "Surname", True))
        Me.SurnameTextBox.Enabled = False
        Me.SurnameTextBox.Location = New System.Drawing.Point(154, 84)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SurnameTextBox.TabIndex = 5
        '
        'frmAddConsultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 516)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(SymptomsLabel)
        Me.Controls.Add(Me.SymptomsTextBox)
        Me.Name = "frmAddConsultation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultation  Form"
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblConsultationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblConsultationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblConsultationTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblConsultationTableAdapter
    Friend WithEvents TableAdapterManager As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SymptomsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TblAppointmentTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter
    Friend WithEvents TblAppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AppointmentDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartingTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FinishTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
End Class
