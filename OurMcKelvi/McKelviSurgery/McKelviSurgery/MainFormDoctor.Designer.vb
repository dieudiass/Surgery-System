<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFormDoctor
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
        Me.btnMedication = New System.Windows.Forms.Button()
        Me.btnConsultation = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateEmployeeInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrivateInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMedication
        '
        Me.btnMedication.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.medication
        Me.btnMedication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMedication.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedication.Location = New System.Drawing.Point(426, 90)
        Me.btnMedication.Name = "btnMedication"
        Me.btnMedication.Size = New System.Drawing.Size(332, 323)
        Me.btnMedication.TabIndex = 36
        Me.btnMedication.UseVisualStyleBackColor = True
        '
        'btnConsultation
        '
        Me.btnConsultation.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.consultation
        Me.btnConsultation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultation.Location = New System.Drawing.Point(53, 90)
        Me.btnConsultation.Name = "btnConsultation"
        Me.btnConsultation.Size = New System.Drawing.Size(340, 323)
        Me.btnConsultation.TabIndex = 35
        Me.btnConsultation.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(818, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.PatientToolStripMenuItem, Me.ConsultationToolStripMenuItem, Me.MedicationToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.McKelviSurgery.My.Resources.Resources.report1
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateEmployeeInformationToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EmployeeToolStripMenuItem.Text = "&Employee"
        '
        'UpdateEmployeeInformationToolStripMenuItem
        '
        Me.UpdateEmployeeInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalInformationToolStripMenuItem, Me.PrivateInformationToolStripMenuItem})
        Me.UpdateEmployeeInformationToolStripMenuItem.Name = "UpdateEmployeeInformationToolStripMenuItem"
        Me.UpdateEmployeeInformationToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.UpdateEmployeeInformationToolStripMenuItem.Text = "UpdateEmployee Information"
        '
        'PersonalInformationToolStripMenuItem
        '
        Me.PersonalInformationToolStripMenuItem.Name = "PersonalInformationToolStripMenuItem"
        Me.PersonalInformationToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PersonalInformationToolStripMenuItem.Text = "Personal Information"
        '
        'PrivateInformationToolStripMenuItem
        '
        Me.PrivateInformationToolStripMenuItem.Name = "PrivateInformationToolStripMenuItem"
        Me.PrivateInformationToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PrivateInformationToolStripMenuItem.Text = "Private Information"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPatientToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PatientToolStripMenuItem.Text = "&Patient"
        '
        'ViewPatientToolStripMenuItem
        '
        Me.ViewPatientToolStripMenuItem.Name = "ViewPatientToolStripMenuItem"
        Me.ViewPatientToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewPatientToolStripMenuItem.Text = "View Patient"
        '
        'ConsultationToolStripMenuItem
        '
        Me.ConsultationToolStripMenuItem.Name = "ConsultationToolStripMenuItem"
        Me.ConsultationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultationToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ConsultationToolStripMenuItem.Text = "&Consultation"
        '
        'MedicationToolStripMenuItem
        '
        Me.MedicationToolStripMenuItem.Name = "MedicationToolStripMenuItem"
        Me.MedicationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MedicationToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.MedicationToolStripMenuItem.Text = "&Medication"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.McKelviSurgery.My.Resources.Resources.about
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Image = Global.McKelviSurgery.My.Resources.Resources.help
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManualToolStripMenuItem})
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContentsToolStripMenuItem.Text = "Contents"
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
        Me.lblUserInfo.Location = New System.Drawing.Point(329, 1)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(316, 23)
        Me.lblUserInfo.TabIndex = 38
        Me.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainFormDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundtwo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(818, 527)
        Me.Controls.Add(Me.lblUserInfo)
        Me.Controls.Add(Me.btnMedication)
        Me.Controls.Add(Me.btnConsultation)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainFormDoctor"
        Me.Text = "Welcome To Dr Batubenga Surgery"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMedication As System.Windows.Forms.Button
    Friend WithEvents btnConsultation As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateEmployeeInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents PersonalInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrivateInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
