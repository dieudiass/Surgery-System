<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFormManager
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
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnCreatePatient = New System.Windows.Forms.Button()
        Me.btnMedication = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAnEmployeeInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonelInformatioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrivateInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinancialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientOwingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.addemployee
        Me.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAddEmployee.Location = New System.Drawing.Point(12, 69)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(273, 249)
        Me.btnAddEmployee.TabIndex = 32
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'btnAppointment
        '
        Me.btnAppointment.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.appointment
        Me.btnAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointment.Location = New System.Drawing.Point(339, 69)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(257, 249)
        Me.btnAppointment.TabIndex = 33
        Me.btnAppointment.UseVisualStyleBackColor = True
        '
        'btnCreatePatient
        '
        Me.btnCreatePatient.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.createpatient
        Me.btnCreatePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreatePatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreatePatient.Location = New System.Drawing.Point(622, 69)
        Me.btnCreatePatient.Name = "btnCreatePatient"
        Me.btnCreatePatient.Size = New System.Drawing.Size(267, 249)
        Me.btnCreatePatient.TabIndex = 40
        Me.btnCreatePatient.UseVisualStyleBackColor = True
        '
        'btnMedication
        '
        Me.btnMedication.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.medication
        Me.btnMedication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMedication.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedication.Location = New System.Drawing.Point(339, 351)
        Me.btnMedication.Name = "btnMedication"
        Me.btnMedication.Size = New System.Drawing.Size(257, 227)
        Me.btnMedication.TabIndex = 42
        Me.btnMedication.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.payment
        Me.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Location = New System.Drawing.Point(12, 351)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(273, 227)
        Me.btnPayment.TabIndex = 43
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(973, 24)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeToolStripMenuItem, Me.RestoreDatabaseToolStripMenuItem, Me.BackupDataToolStripMenuItem, Me.MedicationToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.McKelviSurgery.My.Resources.Resources.File
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewEmployeeToolStripMenuItem, Me.ViewAnEmployeeInformationToolStripMenuItem, Me.UpdateInformationToolStripMenuItem})
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ChangeToolStripMenuItem.Text = "&Employee"
        '
        'AddNewEmployeeToolStripMenuItem
        '
        Me.AddNewEmployeeToolStripMenuItem.Name = "AddNewEmployeeToolStripMenuItem"
        Me.AddNewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.AddNewEmployeeToolStripMenuItem.Text = "Add New Employee"
        '
        'ViewAnEmployeeInformationToolStripMenuItem
        '
        Me.ViewAnEmployeeInformationToolStripMenuItem.Name = "ViewAnEmployeeInformationToolStripMenuItem"
        Me.ViewAnEmployeeInformationToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ViewAnEmployeeInformationToolStripMenuItem.Text = "View an Employee Information"
        '
        'UpdateInformationToolStripMenuItem
        '
        Me.UpdateInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonelInformatioToolStripMenuItem, Me.PrivateInformationToolStripMenuItem})
        Me.UpdateInformationToolStripMenuItem.Name = "UpdateInformationToolStripMenuItem"
        Me.UpdateInformationToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.UpdateInformationToolStripMenuItem.Text = "Update Information"
        '
        'PersonelInformatioToolStripMenuItem
        '
        Me.PersonelInformatioToolStripMenuItem.Name = "PersonelInformatioToolStripMenuItem"
        Me.PersonelInformatioToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PersonelInformatioToolStripMenuItem.Text = "Personel Informatio"
        '
        'PrivateInformationToolStripMenuItem
        '
        Me.PrivateInformationToolStripMenuItem.Name = "PrivateInformationToolStripMenuItem"
        Me.PrivateInformationToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PrivateInformationToolStripMenuItem.Text = "Private Information"
        '
        'RestoreDatabaseToolStripMenuItem
        '
        Me.RestoreDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPatientToolStripMenuItem, Me.CreatePatientToolStripMenuItem})
        Me.RestoreDatabaseToolStripMenuItem.Name = "RestoreDatabaseToolStripMenuItem"
        Me.RestoreDatabaseToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.RestoreDatabaseToolStripMenuItem.Text = "&Patient"
        '
        'ViewPatientToolStripMenuItem
        '
        Me.ViewPatientToolStripMenuItem.Name = "ViewPatientToolStripMenuItem"
        Me.ViewPatientToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ViewPatientToolStripMenuItem.Text = "View Patient"
        '
        'CreatePatientToolStripMenuItem
        '
        Me.CreatePatientToolStripMenuItem.Name = "CreatePatientToolStripMenuItem"
        Me.CreatePatientToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CreatePatientToolStripMenuItem.Text = "Create Patient"
        '
        'BackupDataToolStripMenuItem
        '
        Me.BackupDataToolStripMenuItem.Name = "BackupDataToolStripMenuItem"
        Me.BackupDataToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.BackupDataToolStripMenuItem.Text = "&View Appointments"
        '
        'MedicationToolStripMenuItem
        '
        Me.MedicationToolStripMenuItem.Name = "MedicationToolStripMenuItem"
        Me.MedicationToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MedicationToolStripMenuItem.Text = "&Medication"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PaymentToolStripMenuItem.Text = "&Payment"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppointmentByDateToolStripMenuItem, Me.FinancialToolStripMenuItem, Me.MedicationToolStripMenuItem1, Me.PayementToolStripMenuItem})
        Me.ReportToolStripMenuItem.Image = Global.McKelviSurgery.My.Resources.Resources.report1
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'AppointmentByDateToolStripMenuItem
        '
        Me.AppointmentByDateToolStripMenuItem.Name = "AppointmentByDateToolStripMenuItem"
        Me.AppointmentByDateToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AppointmentByDateToolStripMenuItem.Text = "&Appointment By date"
        '
        'FinancialToolStripMenuItem
        '
        Me.FinancialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientOwingToolStripMenuItem})
        Me.FinancialToolStripMenuItem.Name = "FinancialToolStripMenuItem"
        Me.FinancialToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.FinancialToolStripMenuItem.Text = "&Financial"
        '
        'PatientOwingToolStripMenuItem
        '
        Me.PatientOwingToolStripMenuItem.Name = "PatientOwingToolStripMenuItem"
        Me.PatientOwingToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.PatientOwingToolStripMenuItem.Text = "Payment"
        '
        'MedicationToolStripMenuItem1
        '
        Me.MedicationToolStripMenuItem1.Name = "MedicationToolStripMenuItem1"
        Me.MedicationToolStripMenuItem1.Size = New System.Drawing.Size(187, 22)
        Me.MedicationToolStripMenuItem1.Text = "Medication"
        '
        'PayementToolStripMenuItem
        '
        Me.PayementToolStripMenuItem.Name = "PayementToolStripMenuItem"
        Me.PayementToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PayementToolStripMenuItem.Text = "Payement"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.McKelviSurgery.My.Resources.Resources.about
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentToolStripMenuItem})
        Me.HelpToolStripMenuItem.Image = Global.McKelviSurgery.My.Resources.Resources.help
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentToolStripMenuItem
        '
        Me.ContentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManualToolStripMenuItem})
        Me.ContentToolStripMenuItem.Name = "ContentToolStripMenuItem"
        Me.ContentToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ContentToolStripMenuItem.Text = "Content"
        '
        'UserManualToolStripMenuItem
        '
        Me.UserManualToolStripMenuItem.Name = "UserManualToolStripMenuItem"
        Me.UserManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.UserManualToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.UserManualToolStripMenuItem.Text = "User Manual"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.McKelviSurgery.My.Resources.Resources.LogOut
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'lblUserInfo
        '
        Me.lblUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserInfo.Location = New System.Drawing.Point(464, 0)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(316, 23)
        Me.lblUserInfo.TabIndex = 45
        Me.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainFormManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundtwo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(973, 590)
        Me.Controls.Add(Me.lblUserInfo)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnMedication)
        Me.Controls.Add(Me.btnCreatePatient)
        Me.Controls.Add(Me.btnAppointment)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainFormManager"
        Me.Text = "Welcome To Dr Batubenga Surgery"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddEmployee As System.Windows.Forms.Button
    Friend WithEvents btnAppointment As System.Windows.Forms.Button
    Friend WithEvents btnCreatePatient As System.Windows.Forms.Button
    Friend WithEvents btnMedication As System.Windows.Forms.Button
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAnEmployeeInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppointmentByDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents ContentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonelInformatioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrivateInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreatePatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinancialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientOwingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
