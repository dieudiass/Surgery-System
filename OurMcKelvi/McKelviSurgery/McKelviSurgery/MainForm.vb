Imports System.IO

Public Class MainForm

    Public objPatient As New cus
    Public objEmployee As New FrmEmployee
    Public email As String
    Public ID As String
    Public objViewEmployee As New frmViewEmployee
    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If (MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
            e.Cancel = True
        Else
            ' Application.Exit()
            frmViewEmployee.ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
            frmViewPatient.ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        End If


    End Sub


    Private Sub btnAddEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        objEmployee = New FrmEmployee
        objEmployee.MdiParent = Me
        objEmployee.Show()
        hideButtons()


    End Sub
    Public Sub hideButtons()

        btnAppointment.Visible = False
        btnPayment.Visible = False
        btnCreatePatient.Visible = False
    End Sub
    Public Sub AppearButtons()

        btnAppointment.Visible = True
        btnPayment.Visible = True
        btnCreatePatient.Visible = True
    End Sub

    Private Sub mnuAddEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        objEmployee = New FrmEmployee
        objEmployee.MdiParent = Me
        objEmployee.Show()
        hideButtons()

    End Sub


    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        If (MessageBox.Show("Are you sure to want to Log out?", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Hide()
            LOGIN.txtPassword.Text = ""
            LOGIN.txtEmail.SelectAll()
            LOGIN.txtEmail.Focus()

            LOGIN.Show()

        End If

    End Sub

    Private Sub ViewPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPatientToolStripMenuItem.Click
        Dim objViewPatient As New PatientView
        objViewPatient.MdiParent = Me
        objViewPatient.Text = "View Patient"
        objViewPatient.Show()
        hideButtons()
    End Sub

    Private Sub mnuViewAllEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objViewEmployee As New frmViewAllEmployee
        objViewEmployee.MdiParent = Me
        objViewEmployee.Text = "View All Employee"
        objViewEmployee.Show()
        hideButtons()


    End Sub
    Private Sub btnAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppointment.Click
        objPatient = New cus
        objPatient.MdiParent = Me
        objPatient.Show()
        hideButtons()
    End Sub

    Private Sub PersonalInforrmationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalInforrmationToolStripMenuItem.Click
        Dim objUpdate As New frmEmployeeUpdateInformayion
        objUpdate.MdiParent = Me
        objUpdate.Text = " Update Personal Information form"
        objUpdate.Show()
        hideButtons()
    End Sub

    Private Sub PrivacyInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrivacyInformationToolStripMenuItem.Click
        Dim objUpdate As New frmEmployeePrivacy
        objUpdate.MdiParent = Me
        objUpdate.Text = " Update Privacy Information form"
        objUpdate.Show()
        hideButtons()
    End Sub


    Private Sub AppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentToolStripMenuItem.Click
        Dim objAppoint As New viewPatientAppointment
        Me.hideButtons()
        objAppoint.Show()
    End Sub


    Private Sub mnuViewEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New EmployeeView
        obj.MdiParent = Me
        obj.Show()

    End Sub


    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim obj As New frmPatient
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()

    End Sub

    Private Sub btnConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New frmConsultation
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub ConsultationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New frmConsultation
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub btnMedication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New frmMedication
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        Dim obj As New frmViewPaymentForm
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub


    Private Sub ExitSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim obj As New frmAbout
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
        Dim obj As New frmDates
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub btnCreatePatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreatePatient.Click
        Dim obj As New frmPatientAdd
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub


    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click
        Dim obj As New frmViewPaymentForm
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub CreatePatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreatePatientToolStripMenuItem.Click
        Dim obj As New frmPatientAdd
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub UserManualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserManualToolStripMenuItem.Click
        Dim pdf As Byte() = My.Resources.Dr_Batubenga_End_User_BookPDF
        Using tmp As New FileStream("USER Manual.pdf", FileMode.Create)
            tmp.Write(pdf, 0, pdf.Length)

        End Using
        Process.Start("USER Manual.pdf")
    End Sub

   

    Private Sub PatientOwingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientOwingToolStripMenuItem.Click
        Dim obj As New FrmPatientOwingDate
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub



    Private Sub MedicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicationToolStripMenuItem.Click
        Dim obj As New frmTreatmentReport
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub PaymentToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem1.Click
        Dim obj As New frmPaymentReport
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub
End Class