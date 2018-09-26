<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegularPatients
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
        Dim Label1 As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim AppointmentDateLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim StartingTimeLabel As System.Windows.Forms.Label
        Dim FinishTimeLabel As System.Windows.Forms.Label
        Me.grpAppointment = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cmbDisease = New System.Windows.Forms.ComboBox()
        Me.TblDiseasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.TblDiseasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDoctor = New System.Windows.Forms.TextBox()
        Me.lstTakenTimes = New System.Windows.Forms.ListBox()
        Me.txtFinish = New System.Windows.Forms.TextBox()
        Me.txtStarting = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstStartingTime = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDoctorname = New System.Windows.Forms.Label()
        Me.lblPatientError = New System.Windows.Forms.Label()
        Me.lblDoctorError = New System.Windows.Forms.Label()
        Me.lblFinishTimeError = New System.Windows.Forms.Label()
        Me.lblStartingTimeError = New System.Windows.Forms.Label()
        Me.lblAppointDateError = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.AppointmentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblAppointmentTableAdapter1 = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter()
        Me.TblDiseasTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblDiseasTableAdapter()
        Me.TblPaymentTableAdapter1 = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPaymentTableAdapter()
        Label1 = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        AppointmentDateLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        StartingTimeLabel = New System.Windows.Forms.Label()
        FinishTimeLabel = New System.Windows.Forms.Label()
        Me.grpAppointment.SuspendLayout()
        CType(Me.TblDiseasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDiseasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(58, 296)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 13)
        Label1.TabIndex = 15
        Label1.Text = "Patient Name:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(58, 254)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(57, 13)
        PatientIDLabel.TabIndex = 11
        PatientIDLabel.Text = "Patient ID:"
        '
        'AppointmentDateLabel
        '
        AppointmentDateLabel.AutoSize = True
        AppointmentDateLabel.Location = New System.Drawing.Point(58, 76)
        AppointmentDateLabel.Name = "AppointmentDateLabel"
        AppointmentDateLabel.Size = New System.Drawing.Size(95, 13)
        AppointmentDateLabel.TabIndex = 3
        AppointmentDateLabel.Text = "Appointment Date:"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(58, 213)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(45, 13)
        EmployeeIDLabel.TabIndex = 9
        EmployeeIDLabel.Text = "Doctor :"
        '
        'StartingTimeLabel
        '
        StartingTimeLabel.AutoSize = True
        StartingTimeLabel.Location = New System.Drawing.Point(58, 135)
        StartingTimeLabel.Name = "StartingTimeLabel"
        StartingTimeLabel.Size = New System.Drawing.Size(72, 13)
        StartingTimeLabel.TabIndex = 5
        StartingTimeLabel.Text = "Starting Time:"
        '
        'FinishTimeLabel
        '
        FinishTimeLabel.AutoSize = True
        FinishTimeLabel.Location = New System.Drawing.Point(58, 164)
        FinishTimeLabel.Name = "FinishTimeLabel"
        FinishTimeLabel.Size = New System.Drawing.Size(63, 13)
        FinishTimeLabel.TabIndex = 7
        FinishTimeLabel.Text = "Finish Time:"
        '
        'grpAppointment
        '
        Me.grpAppointment.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpAppointment.Controls.Add(Me.txtPrice)
        Me.grpAppointment.Controls.Add(Me.btnClose)
        Me.grpAppointment.Controls.Add(Me.cmbDisease)
        Me.grpAppointment.Controls.Add(Me.txtDoctor)
        Me.grpAppointment.Controls.Add(Me.lstTakenTimes)
        Me.grpAppointment.Controls.Add(Me.txtFinish)
        Me.grpAppointment.Controls.Add(Me.txtStarting)
        Me.grpAppointment.Controls.Add(Me.Label4)
        Me.grpAppointment.Controls.Add(Me.Label3)
        Me.grpAppointment.Controls.Add(Me.lstStartingTime)
        Me.grpAppointment.Controls.Add(Me.Label2)
        Me.grpAppointment.Controls.Add(Me.lblDoctorname)
        Me.grpAppointment.Controls.Add(Me.lblPatientError)
        Me.grpAppointment.Controls.Add(Me.lblDoctorError)
        Me.grpAppointment.Controls.Add(Me.lblFinishTimeError)
        Me.grpAppointment.Controls.Add(Me.lblStartingTimeError)
        Me.grpAppointment.Controls.Add(Me.lblAppointDateError)
        Me.grpAppointment.Controls.Add(Me.btnSubmit)
        Me.grpAppointment.Controls.Add(Me.txtPatientName)
        Me.grpAppointment.Controls.Add(Label1)
        Me.grpAppointment.Controls.Add(Me.AppointmentDateDateTimePicker)
        Me.grpAppointment.Controls.Add(Me.PatientIDTextBox)
        Me.grpAppointment.Controls.Add(PatientIDLabel)
        Me.grpAppointment.Controls.Add(AppointmentDateLabel)
        Me.grpAppointment.Controls.Add(EmployeeIDLabel)
        Me.grpAppointment.Controls.Add(StartingTimeLabel)
        Me.grpAppointment.Controls.Add(FinishTimeLabel)
        Me.grpAppointment.Location = New System.Drawing.Point(26, 22)
        Me.grpAppointment.Name = "grpAppointment"
        Me.grpAppointment.Size = New System.Drawing.Size(749, 430)
        Me.grpAppointment.TabIndex = 14
        Me.grpAppointment.TabStop = False
        Me.grpAppointment.Text = "Make Appointment"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(371, 284)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 37
        Me.txtPrice.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(358, 364)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(144, 35)
        Me.btnClose.TabIndex = 36
        Me.btnClose.Text = "Go back"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cmbDisease
        '
        Me.cmbDisease.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblDiseasBindingSource, "DiseaseID", True))
        Me.cmbDisease.DataSource = Me.TblDiseasBindingSource1
        Me.cmbDisease.DisplayMember = "DiseaseName"
        Me.cmbDisease.FormattingEnabled = True
        Me.cmbDisease.Location = New System.Drawing.Point(159, 337)
        Me.cmbDisease.Name = "cmbDisease"
        Me.cmbDisease.Size = New System.Drawing.Size(158, 21)
        Me.cmbDisease.TabIndex = 35
        Me.cmbDisease.ValueMember = "DiseaseID"
        '
        'TblDiseasBindingSource
        '
        Me.TblDiseasBindingSource.DataMember = "tblDiseas"
        Me.TblDiseasBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDiseasBindingSource1
        '
        Me.TblDiseasBindingSource1.DataMember = "tblDiseas"
        Me.TblDiseasBindingSource1.DataSource = Me.McKelviSurgDBDataSet
        '
        'txtDoctor
        '
        Me.txtDoctor.Location = New System.Drawing.Point(159, 210)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.ReadOnly = True
        Me.txtDoctor.Size = New System.Drawing.Size(158, 20)
        Me.txtDoctor.TabIndex = 33
        '
        'lstTakenTimes
        '
        Me.lstTakenTimes.Enabled = False
        Me.lstTakenTimes.FormattingEnabled = True
        Me.lstTakenTimes.Location = New System.Drawing.Point(412, 58)
        Me.lstTakenTimes.Name = "lstTakenTimes"
        Me.lstTakenTimes.Size = New System.Drawing.Size(109, 173)
        Me.lstTakenTimes.TabIndex = 32
        '
        'txtFinish
        '
        Me.txtFinish.Location = New System.Drawing.Point(159, 161)
        Me.txtFinish.Name = "txtFinish"
        Me.txtFinish.ReadOnly = True
        Me.txtFinish.Size = New System.Drawing.Size(158, 20)
        Me.txtFinish.TabIndex = 31
        '
        'txtStarting
        '
        Me.txtStarting.Location = New System.Drawing.Point(159, 132)
        Me.txtStarting.Name = "txtStarting"
        Me.txtStarting.ReadOnly = True
        Me.txtStarting.Size = New System.Drawing.Size(158, 20)
        Me.txtStarting.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(421, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Taken Times"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Available Times"
        '
        'lstStartingTime
        '
        Me.lstStartingTime.FormattingEnabled = True
        Me.lstStartingTime.Location = New System.Drawing.Point(543, 58)
        Me.lstStartingTime.Name = "lstStartingTime"
        Me.lstStartingTime.Size = New System.Drawing.Size(109, 173)
        Me.lstStartingTime.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Service"
        '
        'lblDoctorname
        '
        Me.lblDoctorname.AutoSize = True
        Me.lblDoctorname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctorname.ForeColor = System.Drawing.Color.Lime
        Me.lblDoctorname.Location = New System.Drawing.Point(272, 219)
        Me.lblDoctorname.Name = "lblDoctorname"
        Me.lblDoctorname.Size = New System.Drawing.Size(0, 16)
        Me.lblDoctorname.TabIndex = 24
        '
        'lblPatientError
        '
        Me.lblPatientError.AutoSize = True
        Me.lblPatientError.ForeColor = System.Drawing.Color.Red
        Me.lblPatientError.Location = New System.Drawing.Point(164, 322)
        Me.lblPatientError.Name = "lblPatientError"
        Me.lblPatientError.Size = New System.Drawing.Size(0, 13)
        Me.lblPatientError.TabIndex = 22
        '
        'lblDoctorError
        '
        Me.lblDoctorError.AutoSize = True
        Me.lblDoctorError.ForeColor = System.Drawing.Color.Red
        Me.lblDoctorError.Location = New System.Drawing.Point(165, 235)
        Me.lblDoctorError.Name = "lblDoctorError"
        Me.lblDoctorError.Size = New System.Drawing.Size(0, 13)
        Me.lblDoctorError.TabIndex = 21
        '
        'lblFinishTimeError
        '
        Me.lblFinishTimeError.AutoSize = True
        Me.lblFinishTimeError.ForeColor = System.Drawing.Color.Red
        Me.lblFinishTimeError.Location = New System.Drawing.Point(165, 194)
        Me.lblFinishTimeError.Name = "lblFinishTimeError"
        Me.lblFinishTimeError.Size = New System.Drawing.Size(0, 13)
        Me.lblFinishTimeError.TabIndex = 20
        '
        'lblStartingTimeError
        '
        Me.lblStartingTimeError.AutoSize = True
        Me.lblStartingTimeError.ForeColor = System.Drawing.Color.Red
        Me.lblStartingTimeError.Location = New System.Drawing.Point(165, 148)
        Me.lblStartingTimeError.Name = "lblStartingTimeError"
        Me.lblStartingTimeError.Size = New System.Drawing.Size(0, 13)
        Me.lblStartingTimeError.TabIndex = 19
        '
        'lblAppointDateError
        '
        Me.lblAppointDateError.AutoSize = True
        Me.lblAppointDateError.ForeColor = System.Drawing.Color.Red
        Me.lblAppointDateError.Location = New System.Drawing.Point(121, 105)
        Me.lblAppointDateError.Name = "lblAppointDateError"
        Me.lblAppointDateError.Size = New System.Drawing.Size(0, 13)
        Me.lblAppointDateError.TabIndex = 18
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(543, 364)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(174, 35)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtPatientName
        '
        Me.txtPatientName.Location = New System.Drawing.Point(159, 293)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.ReadOnly = True
        Me.txtPatientName.Size = New System.Drawing.Size(158, 20)
        Me.txtPatientName.TabIndex = 16
        '
        'AppointmentDateDateTimePicker
        '
        Me.AppointmentDateDateTimePicker.Location = New System.Drawing.Point(159, 72)
        Me.AppointmentDateDateTimePicker.Name = "AppointmentDateDateTimePicker"
        Me.AppointmentDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AppointmentDateDateTimePicker.TabIndex = 4
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.Location = New System.Drawing.Point(159, 251)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.ReadOnly = True
        Me.PatientIDTextBox.Size = New System.Drawing.Size(158, 20)
        Me.PatientIDTextBox.TabIndex = 12
        '
        'TblAppointmentTableAdapter1
        '
        Me.TblAppointmentTableAdapter1.ClearBeforeFill = True
        '
        'TblDiseasTableAdapter
        '
        Me.TblDiseasTableAdapter.ClearBeforeFill = True
        '
        'TblPaymentTableAdapter1
        '
        Me.TblPaymentTableAdapter1.ClearBeforeFill = True
        '
        'RegularPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(808, 476)
        Me.Controls.Add(Me.grpAppointment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RegularPatients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegularPatients"
        Me.grpAppointment.ResumeLayout(False)
        Me.grpAppointment.PerformLayout()
        CType(Me.TblDiseasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDiseasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAppointment As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDisease As System.Windows.Forms.ComboBox
    Friend WithEvents txtDoctor As System.Windows.Forms.TextBox
    Friend WithEvents lstTakenTimes As System.Windows.Forms.ListBox
    Friend WithEvents txtFinish As System.Windows.Forms.TextBox
    Friend WithEvents txtStarting As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstStartingTime As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDoctorname As System.Windows.Forms.Label
    Friend WithEvents lblPatientError As System.Windows.Forms.Label
    Friend WithEvents lblDoctorError As System.Windows.Forms.Label
    Friend WithEvents lblFinishTimeError As System.Windows.Forms.Label
    Friend WithEvents lblStartingTimeError As System.Windows.Forms.Label
    Friend WithEvents lblAppointDateError As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents AppointmentDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PatientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblAppointmentTableAdapter1 As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblDiseasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDiseasTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblDiseasTableAdapter
    Friend WithEvents TblPaymentTableAdapter1 As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPaymentTableAdapter
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents TblDiseasBindingSource1 As System.Windows.Forms.BindingSource
End Class
