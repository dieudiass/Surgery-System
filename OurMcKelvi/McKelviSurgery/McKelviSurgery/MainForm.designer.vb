<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalInforrmationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrivacyInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatePatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinancilaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientOwingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.btnCreatePatient = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1084, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.PatientToolStripMenuItem, Me.AppointmentToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowsToolStripMenuItem.Image = CType(resources.GetObject("WindowsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(58, 22)
        Me.WindowsToolStripMenuItem.Text = "&File"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateInformationToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.EmployeeToolStripMenuItem.Text = "&Employee"
        '
        'UpdateInformationToolStripMenuItem
        '
        Me.UpdateInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalInforrmationToolStripMenuItem, Me.PrivacyInformationToolStripMenuItem})
        Me.UpdateInformationToolStripMenuItem.Name = "UpdateInformationToolStripMenuItem"
        Me.UpdateInformationToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.UpdateInformationToolStripMenuItem.Text = "Update Information"
        '
        'PersonalInforrmationToolStripMenuItem
        '
        Me.PersonalInforrmationToolStripMenuItem.Name = "PersonalInforrmationToolStripMenuItem"
        Me.PersonalInforrmationToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.PersonalInforrmationToolStripMenuItem.Text = "Personal Inforrmation"
        '
        'PrivacyInformationToolStripMenuItem
        '
        Me.PrivacyInformationToolStripMenuItem.Name = "PrivacyInformationToolStripMenuItem"
        Me.PrivacyInformationToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.PrivacyInformationToolStripMenuItem.Text = "Private Information"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPatientToolStripMenuItem, Me.CreatePatientToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PatientToolStripMenuItem.Text = "&Patient"
        '
        'ViewPatientToolStripMenuItem
        '
        Me.ViewPatientToolStripMenuItem.Name = "ViewPatientToolStripMenuItem"
        Me.ViewPatientToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ViewPatientToolStripMenuItem.Text = "View Patient"
        '
        'CreatePatientToolStripMenuItem
        '
        Me.CreatePatientToolStripMenuItem.Name = "CreatePatientToolStripMenuItem"
        Me.CreatePatientToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CreatePatientToolStripMenuItem.Text = "Create Patient"
        '
        'AppointmentToolStripMenuItem
        '
        Me.AppointmentToolStripMenuItem.Name = "AppointmentToolStripMenuItem"
        Me.AppointmentToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.AppointmentToolStripMenuItem.Text = "&View Appointments"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PaymentToolStripMenuItem.Text = "&Payment"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.FinancilaToolStripMenuItem, Me.MedicationToolStripMenuItem, Me.PaymentToolStripMenuItem1})
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.Image = CType(resources.GetObject("ReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(74, 22)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AToolStripMenuItem.Text = "&Appointment By Date"
        '
        'FinancilaToolStripMenuItem
        '
        Me.FinancilaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientOwingToolStripMenuItem})
        Me.FinancilaToolStripMenuItem.Name = "FinancilaToolStripMenuItem"
        Me.FinancilaToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.FinancilaToolStripMenuItem.Text = "&Financial"
        '
        'PatientOwingToolStripMenuItem
        '
        Me.PatientOwingToolStripMenuItem.Name = "PatientOwingToolStripMenuItem"
        Me.PatientOwingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PatientOwingToolStripMenuItem.Text = "&Payment "
        '
        'MedicationToolStripMenuItem
        '
        Me.MedicationToolStripMenuItem.Name = "MedicationToolStripMenuItem"
        Me.MedicationToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.MedicationToolStripMenuItem.Text = "Medication"
        '
        'PaymentToolStripMenuItem1
        '
        Me.PaymentToolStripMenuItem1.Name = "PaymentToolStripMenuItem1"
        Me.PaymentToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.PaymentToolStripMenuItem1.Text = "Payment"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(70, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(62, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManualToolStripMenuItem})
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ContentsToolStripMenuItem.Text = "Contents"
        '
        'UserManualToolStripMenuItem
        '
        Me.UserManualToolStripMenuItem.Name = "UserManualToolStripMenuItem"
        Me.UserManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.UserManualToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.UserManualToolStripMenuItem.Text = "User Manual"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutToolStripMenuItem.Image = CType(resources.GetObject("LogOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(76, 22)
        Me.LogOutToolStripMenuItem.Text = "&LogOut"
        '
        'btnAppointment
        '
        Me.btnAppointment.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.appointment
        Me.btnAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointment.Location = New System.Drawing.Point(423, 60)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(305, 289)
        Me.btnAppointment.TabIndex = 35
        Me.btnAppointment.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.payment
        Me.btnPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Location = New System.Drawing.Point(31, 381)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(305, 289)
        Me.btnPayment.TabIndex = 35
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'lblUserInfo
        '
        Me.lblUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserInfo.Location = New System.Drawing.Point(448, 3)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(316, 23)
        Me.lblUserInfo.TabIndex = 37
        Me.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCreatePatient
        '
        Me.btnCreatePatient.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.createpatient
        Me.btnCreatePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreatePatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreatePatient.Location = New System.Drawing.Point(31, 60)
        Me.btnCreatePatient.Name = "btnCreatePatient"
        Me.btnCreatePatient.Size = New System.Drawing.Size(305, 289)
        Me.btnCreatePatient.TabIndex = 39
        Me.btnCreatePatient.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundtwo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1084, 698)
        Me.Controls.Add(Me.btnCreatePatient)
        Me.Controls.Add(Me.lblUserInfo)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnAppointment)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Dr Batubenga  Surgery"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents WindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppointmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAppointment As System.Windows.Forms.Button
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents ViewPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalInforrmationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrivacyInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCreatePatient As System.Windows.Forms.Button
    Friend WithEvents CreatePatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinancilaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientOwingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
