Imports System.Text.RegularExpressions

Public Class EmployeeView
    Private objEmployee As New EmployeeClass
    Private obViewReport As New frmViewEmployee
    Private Sub txtSearchPatient_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchPatient.KeyPress
        If rdoByIDNumber.Checked Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtSearchPatient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchPatient.TextChanged
        If rdoByIDNumber.Checked Then
            txtSearchPatient.MaxLength = 13
            If txtSearchPatient.TextLength < 13 Then
                lblSearchError.Text = "Please a valid South African ID with 13 digits"
                btnFind.Enabled = False
            ElseIf txtSearchPatient.Text = "" Then
                lblSearchError.Text = "Please provide a South African ID"
                btnFind.Enabled = False
            Else
                lblSearchError.Text = ""
                btnFind.Enabled = True
            End If
        ElseIf rdoByPassportNo.Checked Then
            txtSearchPatient.MaxLength = 20
            If txtSearchPatient.Text = "" Then
                lblSearchError.Text = "Please provide a passport number"
                btnFind.Enabled = False
            Else
                lblSearchError.Text = ""
                btnFind.Enabled = True
            End If

        ElseIf rdoByEmailAddress.Checked Then

            If txtSearchPatient.Text = "" Then
                lblSearchError.Text = "Please provide a email address"
                btnFind.Enabled = False
            ElseIf isValidEmailFormat(txtSearchPatient.Text) = False Then
                lblSearchError.Text = "Please provide a valid email address"
                btnFind.Enabled = False
            Else
                lblSearchError.Text = ""
                btnFind.Enabled = True
            End If

        End If
    End Sub
    Public Function isValidEmailFormat(ByVal email As String) As Boolean
        Return Regex.IsMatch(email, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If rdoByIDNumber.Checked Then
            objEmployee.ViewEmployeeByIDNumber(txtSearchPatient.Text)
            If (txtSearchPatient.Text.ToUpper = objEmployee.IDNumber) Then
                obViewReport.valueID = True
                obViewReport.Tag = txtSearchPatient.Text
                obViewReport.ShowDialog()
                Me.Hide()
            Else
                MessageBox.Show("Employee with ID Number: " & txtSearchPatient.Text & " does not exist", "Patient MC Kelvi Surgery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
               

        ElseIf rdoByPassportNo.Checked Then
        objEmployee.ViewEmployeeByIDNumber(txtSearchPatient.Text)
            If (txtSearchPatient.Text.ToUpper = objEmployee.IDNumber) Then
                obViewReport.valueID = True
                obViewReport.Tag = txtSearchPatient.Text
                obViewReport.ShowDialog()
                Me.Hide()
            Else
                MessageBox.Show("Employee with Passport No : " & txtSearchPatient.Text & " does not exist", "Patient MC Kelvi Surgery", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearchPatient.Focus()
            End If

        ElseIf rdoByEmailAddress.Checked Then
        objEmployee.ViewEmployeeByEmail(txtSearchPatient.Text)
            If (txtSearchPatient.Text.ToUpper = objEmployee.Email) Then
                obViewReport.valueID = False
                obViewReport.Tag = txtSearchPatient.Text
                obViewReport.ShowDialog()
                Me.Hide()
            Else
                MessageBox.Show("Employee with Email Address : " & txtSearchPatient.Text & " does not exist", "Patient MC Kelvi Surgery", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearchPatient.Focus()

            End If
        End If
    End Sub



    Private Sub EmployeeView_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()

        Me.Hide()
    End Sub

    Private Sub EmployeeView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnFind.Enabled = False
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()
    End Sub

    Private Sub rdoByEmailAddress_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoByEmailAddress.CheckedChanged
        txtSearchPatient.Text = ""
        txtSearchPatient.Focus()
        lblSearchError.Text = ""
    End Sub

    Private Sub rdoByIDNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoByIDNumber.CheckedChanged
        txtSearchPatient.Text = ""
        txtSearchPatient.Focus()
        lblSearchError.Text = ""
    End Sub

    Private Sub rdoByPassportNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoByPassportNo.CheckedChanged
        txtSearchPatient.Text = ""
        lblSearchError.Text = ""
        txtSearchPatient.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MessageBox.Show("Are sure you want to exit the search", "McKeclvi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            MainForm.AppearButtons()
            MainFormDoctor.AppearButtons()
            MainFormManager.AppearButtons()
        End If
    End Sub
End Class