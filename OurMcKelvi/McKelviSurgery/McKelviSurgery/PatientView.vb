Public Class PatientView
    Public objPatient As New PatientClass
    Private obViewReport As New frmViewPatient

    Private Sub PatientView_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
    End Sub
    

    Private Sub txtSearchPatient_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchPatient.KeyPress
        If rdoByIDNumber.Checked Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        ElseIf rdoByPhoneNumber.Checked Then
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

        ElseIf rdoByPhoneNumber.Checked Then
            txtSearchPatient.MaxLength = 10
            If txtSearchPatient.Text = "" Then
                lblSearchError.Text = "Please provide a phone number"
                btnFind.Enabled = False
            ElseIf txtSearchPatient.TextLength < 10 Then
                lblSearchError.Text = "Please provide a valid phone number with 10 digits"
                btnFind.Enabled = False
            Else
                lblSearchError.Text = ""
                btnFind.Enabled = True
            End If

        End If
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If rdoByIDNumber.Checked Then
            objPatient.ViewPatientByIDNumber(txtSearchPatient.Text)
            If (txtSearchPatient.Text.ToUpper = objPatient.IDNumber) Then
                obViewReport.valueID = True
                obViewReport.Tag = txtSearchPatient.Text
                obViewReport.ShowDialog()
                Me.Hide()
            Else
                MessageBox.Show("Patient with ID Number: " & txtSearchPatient.Text & " does not exist", "Patient MC Kelvi Surgery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf rdoByPassportNo.Checked Then
        objPatient.ViewPatientByIDNumber(txtSearchPatient.Text)
            If (txtSearchPatient.Text.ToUpper = objPatient.IDNumber) Then
                obViewReport.valueID = True
                obViewReport.Tag = txtSearchPatient.Text
                obViewReport.ShowDialog()
                Me.Hide()
            Else
                MessageBox.Show("Patient with Passport Number: " & txtSearchPatient.Text & " does not exist", "Patient MC Kelvi Surgery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf rdoByPhoneNumber.Checked Then
        objPatient.ViewPatientByPhoneNumber(txtSearchPatient.Text)
            If (txtSearchPatient.Text.ToUpper = objPatient.PhoneNumber) Then
                obViewReport.valueID = False
                obViewReport.Tag = txtSearchPatient.Text
                obViewReport.ShowDialog()
                Me.Hide()
            Else
                MessageBox.Show("Patient with Phone Number: " & txtSearchPatient.Text & " does not exist", "Patient MC Kelvi Surgery", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub rdoByPhoneNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoByPhoneNumber.CheckedChanged
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
        txtSearchPatient.Focus()
        lblSearchError.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If (MessageBox.Show("Are you sure you want to Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()

        End If
    End Sub

    Private Sub PatientView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class