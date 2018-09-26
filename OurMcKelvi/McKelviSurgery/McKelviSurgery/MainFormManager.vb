Imports System.IO

Public Class MainFormManager
    Public objPatient As New cus
    Public objEmployee As New FrmEmployee
    Public email As String
    Public ID As String
    Public objViewEmployee As New frmViewEmployee


    Private Sub btnAddEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEmployee.Click
        objEmployee = New FrmEmployee
        objEmployee.MdiParent = Me
        objEmployee.Show()
        hideButtons()
    End Sub

    Private Sub btnAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppointment.Click
        objPatient = New cus
        'objPatient.MdiParent = Me
        objPatient.Show()
        hideButtons()
    End Sub

    Private Sub btnCreatePatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreatePatient.Click
        Dim obj As New frmPatientAdd
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()

    End Sub

    'Private Sub btnConsultation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim obj As New frmConsultation
    '    obj.MdiParent = Me
    '    obj.Show()
    '    Me.hideButtons()
    'End Sub

    Private Sub btnPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayment.Click
        Dim obj As New frmViewPaymentForm
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

    Private Sub AddNewEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewEmployeeToolStripMenuItem.Click
        objEmployee = New FrmEmployee
        objEmployee.MdiParent = Me
        objEmployee.Show()
        hideButtons()
    End Sub

    Private Sub ViewAnEmployeeInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAnEmployeeInformationToolStripMenuItem.Click
        Dim obj As New EmployeeView
        obj.MdiParent = Me
        obj.Show()

    End Sub

    Private Sub PersonelInformatioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonelInformatioToolStripMenuItem.Click
        Dim objUpdate As New frmEmployeeUpdateInformayion
        objUpdate.MdiParent = Me
        objUpdate.Text = " Update Personal Information form"
        objUpdate.Show()
        hideButtons()
    End Sub

    Private Sub PrivateInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrivateInformationToolStripMenuItem.Click
        Dim objUpdate As New frmEmployeePrivacy
        objUpdate.MdiParent = Me
        objUpdate.Text = " Update Privacy Information form"
        objUpdate.Show()
        hideButtons()
    End Sub

    Private Sub ViewPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPatientToolStripMenuItem.Click
        Dim objViewPatient As New PatientView
        objViewPatient.MdiParent = Me
        objViewPatient.Text = "View Patient"
        objViewPatient.Show()
        hideButtons()
    End Sub

    Private Sub BackupDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDataToolStripMenuItem.Click
        Dim objAppoint As New viewPatientAppointment
        Me.hideButtons()
        objAppoint.Show()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim obj As New frmPatient
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub
    Public Sub hideButtons()
        btnAddEmployee.Visible = False
        '  btnConsultation.Visible = False
        btnMedication.Visible = False
        btnAppointment.Visible = False
        btnPayment.Visible = False
        btnCreatePatient.Visible = False
    End Sub
    Public Sub AppearButtons()
        btnAddEmployee.Visible = True
        ' btnConsultation.Visible = True
        btnMedication.Visible = True
        btnAppointment.Visible = True
        btnPayment.Visible = True
        btnCreatePatient.Visible = True
    End Sub

    Private Sub CreatePatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreatePatientToolStripMenuItem.Click
        Dim obj As New frmPatientAdd
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub ConsultationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' ConsultationToolStripMenuItem.Enabled = False
        Dim obj As New frmConsultation
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click
        Dim obj As New frmViewPaymentForm
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



    Private Sub PaymentToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New FrmPaymentChart
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()

    End Sub



    'Private Sub TreatmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreatmentToolStripMenuItem.Click
    '    TreatmentToolStripMenuItem.Enabled = False
    'End Sub

    Private Sub UserManualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserManualToolStripMenuItem.Click
        Dim pdf As Byte() = My.Resources.Dr_Batubenga_End_User_BookPDF
        Using tmp As New FileStream("USER Manual.pdf", FileMode.Create)
            tmp.Write(pdf, 0, pdf.Length)

        End Using
        Process.Start("USER Manual.pdf")
    End Sub

    Private Sub AppointmentByDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentByDateToolStripMenuItem.Click
        Dim obj As New frmDates
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    

    Private Sub PatientOwingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientOwingToolStripMenuItem.Click
        Dim obj As New FrmPatientOwingDate
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    
    Private Sub NoOfPatientTreatedByDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New frmDates
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub


    Private Sub MedicationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicationToolStripMenuItem1.Click
        Dim obj As New frmTreatmentReport
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub

    Private Sub PayementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayementToolStripMenuItem.Click
        Dim obj As New frmPaymentReport
        obj.MdiParent = Me
        obj.Show()
        Me.hideButtons()
    End Sub
End Class