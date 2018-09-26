Imports System.IO

Public Class MainFormDoctor
    Public objPatient As New cus
    Public objEmployee As New FrmEmployee
    Public email As String
    Public ID As String
    Public objViewEmployee As New frmViewEmployee


    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If (MessageBox.Show("Are you sure to want to Log out?", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Hide()
            LOGIN.txtPassword.Text = ""
            LOGIN.txtEmail.SelectAll()
            LOGIN.txtEmail.Focus()

            LOGIN.Show()

        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim obj As New frmAbout
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub


    Private Sub AddNewEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        objEmployee = New FrmEmployee
        objEmployee.MdiParent = Me
        objEmployee.Show()
        hideButtons()

    End Sub

    Private Sub ViewAnEmployeeInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New EmployeeView
        obj.MdiParent = Me
        obj.Show()
    End Sub

    Private Sub PersonalInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalInformationToolStripMenuItem.Click
        Dim objUpdate As New frmEmployeeUpdateInformayion
        objUpdate.MdiParent = Me
        objUpdate.Text = " Update Personal Information form"
        objUpdate.Show()
        hideButtons()
    End Sub

    Private Sub ViewAppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objAppoint As New viewPatientAppointment
        Me.hideButtons()
        objAppoint.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New frmPatient
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()

    End Sub

    Private Sub ViewPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPatientToolStripMenuItem.Click
        Dim objViewPatient As New PatientView
        'objViewPatient.MdiParent = Me
        objViewPatient.Text = "View Patient"
        objViewPatient.Show()
        hideButtons()
    End Sub

    Private Sub ReportByDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New frmDates
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub btnConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultation.Click
        Dim obj As New frmConsultation
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()


    End Sub

    Private Sub btnMedication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedication.Click
        Dim obj As New frmMedication
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Public Sub hideButtons()

        btnConsultation.Visible = False
        btnMedication.Visible = False

    End Sub
    Public Sub AppearButtons()

        btnConsultation.Visible = True
        btnMedication.Visible = True

    End Sub

    Private Sub MainFormDoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PrivateInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrivateInformationToolStripMenuItem.Click
        Dim objUpdate As New frmEmployeePrivacy
        objUpdate.MdiParent = Me
        objUpdate.Text = " Update Privacy Information form"
        objUpdate.Show()
        hideButtons()
    End Sub

    Private Sub ConsultationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultationToolStripMenuItem.Click
        Dim obj As New frmConsultation
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub MedicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicationToolStripMenuItem.Click
        Dim obj As New frmMedication
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
End Class