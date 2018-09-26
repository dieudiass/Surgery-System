<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreatment
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
        Dim ConsultIDLabel As System.Windows.Forms.Label
        Dim SymptomsLabel As System.Windows.Forms.Label
        Dim AppIDLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim TreatmentPosologieLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DurationFromLabel As System.Windows.Forms.Label
        Dim DurationToLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ConsultIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblConsultationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.SymptomsTextBox = New System.Windows.Forms.TextBox()
        Me.AppIDTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.TblTreatmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TreatmentPosologieTextBox = New System.Windows.Forms.TextBox()
        Me.grpTreatment = New System.Windows.Forms.GroupBox()
        Me.btnSa = New System.Windows.Forms.Button()
        Me.DurationToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DurationFromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.TblMedicationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnRemove = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TblMedicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstPrescribedMedication = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.TblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.lstMedicationID = New System.Windows.Forms.ListBox()
        Me.TblConsultationTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblConsultationTableAdapter()
        Me.TableAdapterManager = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager()
        Me.TblTreatmentTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblTreatmentTableAdapter()
        Me.TblPatientTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter()
        Me.TblMedicationTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblMedicationTableAdapter()
        Me.TblTreatmentLineTableAdapter1 = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblTreatmentLineTableAdapter()
        ConsultIDLabel = New System.Windows.Forms.Label()
        SymptomsLabel = New System.Windows.Forms.Label()
        AppIDLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        TreatmentPosologieLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DurationFromLabel = New System.Windows.Forms.Label()
        DurationToLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblConsultationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTreatmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTreatment.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TblMedicationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMedicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultIDLabel
        '
        ConsultIDLabel.AutoSize = True
        ConsultIDLabel.Location = New System.Drawing.Point(28, 22)
        ConsultIDLabel.Name = "ConsultIDLabel"
        ConsultIDLabel.Size = New System.Drawing.Size(59, 13)
        ConsultIDLabel.TabIndex = 0
        ConsultIDLabel.Text = "Consult ID:"
        '
        'SymptomsLabel
        '
        SymptomsLabel.AutoSize = True
        SymptomsLabel.Location = New System.Drawing.Point(29, 48)
        SymptomsLabel.Name = "SymptomsLabel"
        SymptomsLabel.Size = New System.Drawing.Size(58, 13)
        SymptomsLabel.TabIndex = 2
        SymptomsLabel.Text = "Symptoms:"
        '
        'AppIDLabel
        '
        AppIDLabel.AutoSize = True
        AppIDLabel.Location = New System.Drawing.Point(29, 166)
        AppIDLabel.Name = "AppIDLabel"
        AppIDLabel.Size = New System.Drawing.Size(43, 13)
        AppIDLabel.TabIndex = 4
        AppIDLabel.Text = "App ID:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(29, 192)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 6
        StatusLabel.Text = "Status:"
        '
        'TreatmentPosologieLabel
        '
        TreatmentPosologieLabel.AutoSize = True
        TreatmentPosologieLabel.Location = New System.Drawing.Point(29, 93)
        TreatmentPosologieLabel.Name = "TreatmentPosologieLabel"
        TreatmentPosologieLabel.Size = New System.Drawing.Size(53, 13)
        TreatmentPosologieLabel.TabIndex = 5
        TreatmentPosologieLabel.Text = "Posology:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(59, 55)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(57, 13)
        PatientIDLabel.TabIndex = 0
        PatientIDLabel.Text = "Patient ID:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(59, 78)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(55, 13)
        FirstnameLabel.TabIndex = 2
        FirstnameLabel.Text = "Firstname:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(62, 104)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(52, 13)
        SurnameLabel.TabIndex = 4
        SurnameLabel.Text = "Surname:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(62, 130)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 6
        GenderLabel.Text = "Gender:"
        '
        'DurationFromLabel
        '
        DurationFromLabel.AutoSize = True
        DurationFromLabel.Location = New System.Drawing.Point(17, 23)
        DurationFromLabel.Name = "DurationFromLabel"
        DurationFromLabel.Size = New System.Drawing.Size(76, 13)
        DurationFromLabel.TabIndex = 6
        DurationFromLabel.Text = "Duration From:"
        '
        'DurationToLabel
        '
        DurationToLabel.AutoSize = True
        DurationToLabel.Location = New System.Drawing.Point(27, 52)
        DurationToLabel.Name = "DurationToLabel"
        DurationToLabel.Size = New System.Drawing.Size(66, 13)
        DurationToLabel.TabIndex = 7
        DurationToLabel.Text = "Duration To:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(ConsultIDLabel)
        Me.GroupBox1.Controls.Add(Me.ConsultIDTextBox)
        Me.GroupBox1.Controls.Add(SymptomsLabel)
        Me.GroupBox1.Controls.Add(Me.SymptomsTextBox)
        Me.GroupBox1.Controls.Add(AppIDLabel)
        Me.GroupBox1.Controls.Add(Me.AppIDTextBox)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 271)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultation"
        '
        'ConsultIDTextBox
        '
        Me.ConsultIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblConsultationBindingSource, "ConsultID", True))
        Me.ConsultIDTextBox.Location = New System.Drawing.Point(112, 19)
        Me.ConsultIDTextBox.Name = "ConsultIDTextBox"
        Me.ConsultIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ConsultIDTextBox.TabIndex = 1
        '
        'TblConsultationBindingSource
        '
        Me.TblConsultationBindingSource.DataMember = "tblConsultation"
        Me.TblConsultationBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SymptomsTextBox
        '
        Me.SymptomsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblConsultationBindingSource, "Symptoms", True))
        Me.SymptomsTextBox.Location = New System.Drawing.Point(112, 48)
        Me.SymptomsTextBox.Multiline = True
        Me.SymptomsTextBox.Name = "SymptomsTextBox"
        Me.SymptomsTextBox.Size = New System.Drawing.Size(233, 109)
        Me.SymptomsTextBox.TabIndex = 3
        '
        'AppIDTextBox
        '
        Me.AppIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblConsultationBindingSource, "AppID", True))
        Me.AppIDTextBox.Location = New System.Drawing.Point(112, 163)
        Me.AppIDTextBox.Name = "AppIDTextBox"
        Me.AppIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AppIDTextBox.TabIndex = 5
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblConsultationBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(112, 189)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StatusTextBox.TabIndex = 7
        '
        'TblTreatmentBindingSource
        '
        Me.TblTreatmentBindingSource.DataMember = "FK_tblTreatment_tblConsultation"
        Me.TblTreatmentBindingSource.DataSource = Me.TblConsultationBindingSource
        '
        'TreatmentPosologieTextBox
        '
        Me.TreatmentPosologieTextBox.Location = New System.Drawing.Point(112, 90)
        Me.TreatmentPosologieTextBox.Multiline = True
        Me.TreatmentPosologieTextBox.Name = "TreatmentPosologieTextBox"
        Me.TreatmentPosologieTextBox.Size = New System.Drawing.Size(200, 183)
        Me.TreatmentPosologieTextBox.TabIndex = 6
        '
        'grpTreatment
        '
        Me.grpTreatment.Controls.Add(Me.btnSa)
        Me.grpTreatment.Controls.Add(DurationToLabel)
        Me.grpTreatment.Controls.Add(Me.DurationToDateTimePicker)
        Me.grpTreatment.Controls.Add(DurationFromLabel)
        Me.grpTreatment.Controls.Add(Me.DurationFromDateTimePicker)
        Me.grpTreatment.Controls.Add(Me.TreatmentPosologieTextBox)
        Me.grpTreatment.Controls.Add(TreatmentPosologieLabel)
        Me.grpTreatment.Location = New System.Drawing.Point(12, 321)
        Me.grpTreatment.Name = "grpTreatment"
        Me.grpTreatment.Size = New System.Drawing.Size(385, 310)
        Me.grpTreatment.TabIndex = 7
        Me.grpTreatment.TabStop = False
        Me.grpTreatment.Text = "Treatment Info"
        '
        'btnSa
        '
        Me.btnSa.Location = New System.Drawing.Point(157, 276)
        Me.btnSa.Name = "btnSa"
        Me.btnSa.Size = New System.Drawing.Size(75, 23)
        Me.btnSa.TabIndex = 9
        Me.btnSa.Text = "Save"
        Me.btnSa.UseVisualStyleBackColor = True
        '
        'DurationToDateTimePicker
        '
        Me.DurationToDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblTreatmentBindingSource, "DurationTo", True))
        Me.DurationToDateTimePicker.Location = New System.Drawing.Point(99, 48)
        Me.DurationToDateTimePicker.Name = "DurationToDateTimePicker"
        Me.DurationToDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DurationToDateTimePicker.TabIndex = 8
        '
        'DurationFromDateTimePicker
        '
        Me.DurationFromDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblTreatmentBindingSource, "DurationFrom", True))
        Me.DurationFromDateTimePicker.Location = New System.Drawing.Point(99, 19)
        Me.DurationFromDateTimePicker.Name = "DurationFromDateTimePicker"
        Me.DurationFromDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DurationFromDateTimePicker.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.TblMedicationDataGridView)
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lstPrescribedMedication)
        Me.GroupBox3.Location = New System.Drawing.Point(395, 321)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(840, 310)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Medication"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Enter Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(450, 71)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(208, 20)
        Me.txtSearch.TabIndex = 7
        '
        'TblMedicationDataGridView
        '
        Me.TblMedicationDataGridView.AllowUserToAddRows = False
        Me.TblMedicationDataGridView.AllowUserToDeleteRows = False
        Me.TblMedicationDataGridView.AutoGenerateColumns = False
        Me.TblMedicationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblMedicationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.btnAdd, Me.btnRemove})
        Me.TblMedicationDataGridView.DataSource = Me.TblMedicationBindingSource
        Me.TblMedicationDataGridView.Location = New System.Drawing.Point(312, 114)
        Me.TblMedicationDataGridView.Name = "TblMedicationDataGridView"
        Me.TblMedicationDataGridView.ReadOnly = True
        Me.TblMedicationDataGridView.Size = New System.Drawing.Size(484, 179)
        Me.TblMedicationDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MedicationID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MedicationID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MedDescription"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MedDescription"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "QuantityStock"
        Me.DataGridViewTextBoxColumn3.HeaderText = "QuantityStock"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MedPrice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MedPrice"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.HeaderText = "Add"
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ReadOnly = True
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseColumnTextForButtonValue = True
        '
        'btnRemove
        '
        Me.btnRemove.HeaderText = "Remove"
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.ReadOnly = True
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseColumnTextForButtonValue = True
        '
        'TblMedicationBindingSource
        '
        Me.TblMedicationBindingSource.DataMember = "tblMedication"
        Me.TblMedicationBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(85, 263)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(135, 30)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(481, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Available Medication"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Prescribed Medication"
        '
        'lstPrescribedMedication
        '
        Me.lstPrescribedMedication.FormattingEnabled = True
        Me.lstPrescribedMedication.Location = New System.Drawing.Point(28, 74)
        Me.lstPrescribedMedication.Name = "lstPrescribedMedication"
        Me.lstPrescribedMedication.Size = New System.Drawing.Size(208, 160)
        Me.lstPrescribedMedication.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox4.Controls.Add(GenderLabel)
        Me.GroupBox4.Controls.Add(Me.GenderTextBox)
        Me.GroupBox4.Controls.Add(SurnameLabel)
        Me.GroupBox4.Controls.Add(Me.SurnameTextBox)
        Me.GroupBox4.Controls.Add(FirstnameLabel)
        Me.GroupBox4.Controls.Add(Me.FirstnameTextBox)
        Me.GroupBox4.Controls.Add(PatientIDLabel)
        Me.GroupBox4.Controls.Add(Me.PatientIDTextBox)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(439, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(346, 271)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Patient Information"
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(122, 127)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(131, 20)
        Me.GenderTextBox.TabIndex = 7
        '
        'TblPatientBindingSource
        '
        Me.TblPatientBindingSource.DataMember = "tblPatient"
        Me.TblPatientBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(122, 104)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(131, 20)
        Me.SurnameTextBox.TabIndex = 5
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "Firstname", True))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(122, 78)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(131, 20)
        Me.FirstnameTextBox.TabIndex = 3
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPatientBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Location = New System.Drawing.Point(122, 52)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(131, 20)
        Me.PatientIDTextBox.TabIndex = 1
        '
        'lstMedicationID
        '
        Me.lstMedicationID.FormattingEnabled = True
        Me.lstMedicationID.Location = New System.Drawing.Point(914, 167)
        Me.lstMedicationID.Name = "lstMedicationID"
        Me.lstMedicationID.Size = New System.Drawing.Size(143, 147)
        Me.lstMedicationID.TabIndex = 10
        Me.lstMedicationID.Visible = False
        '
        'TblConsultationTableAdapter
        '
        Me.TblConsultationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAppointmentTableAdapter = Nothing
        Me.TableAdapterManager.tblConsultationTableAdapter = Me.TblConsultationTableAdapter
        Me.TableAdapterManager.tblDiseasTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblMedicationTableAdapter = Nothing
        Me.TableAdapterManager.tblPatientTableAdapter = Nothing
        Me.TableAdapterManager.tblPaymentTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentLineTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblTreatmentTableAdapter
        '
        Me.TblTreatmentTableAdapter.ClearBeforeFill = True
        '
        'TblPatientTableAdapter
        '
        Me.TblPatientTableAdapter.ClearBeforeFill = True
        '
        'TblMedicationTableAdapter
        '
        Me.TblMedicationTableAdapter.ClearBeforeFill = True
        '
        'TblTreatmentLineTableAdapter1
        '
        Me.TblTreatmentLineTableAdapter1.ClearBeforeFill = True
        '
        'frmTreatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1298, 638)
        Me.Controls.Add(Me.lstMedicationID)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpTreatment)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmTreatment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Treatment Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblConsultationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTreatmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTreatment.ResumeLayout(False)
        Me.grpTreatment.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TblMedicationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMedicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblConsultationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblConsultationTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblConsultationTableAdapter
    Friend WithEvents TableAdapterManager As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ConsultIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SymptomsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AppIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblTreatmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTreatmentTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblTreatmentTableAdapter
    Friend WithEvents TreatmentPosologieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents grpTreatment As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstPrescribedMedication As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TblMedicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMedicationTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblMedicationTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents TblMedicationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnRemove As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TblTreatmentLineTableAdapter1 As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblTreatmentLineTableAdapter
    Friend WithEvents lstMedicationID As System.Windows.Forms.ListBox
    Friend WithEvents DurationToDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DurationFromDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSa As System.Windows.Forms.Button
End Class
