Public Class frmEmployeePrivacy

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
       
        If txtPassword.Text = "" Then
            MessageBox.Show("Please enter a password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            txtPassword.Focus()
        Else
            LOGIN.objEmployeeClass.UpdatePrivacyEmployee(txtEmployeeID.Text, txtPassword.Text, dtpDOB.Value, cmbSecurity.SelectedItem, txtAnswer.Text)
            MessageBox.Show("Information was successfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmEmployeePrivacy_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()

        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
    End Sub

    Private Sub frmEmployeePrivacy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        txtType.Text = LOGIN.objEmployeeClass.Type
        txtPassword.Text = LOGIN.objEmployeeClass.Password
        txtEmail.Text = LOGIN.objEmployeeClass.Email
        txtEmployeeID.Text = LOGIN.objEmployeeClass.EmployeeID
        dtpDOB.Value = LOGIN.objEmployeeClass.DOB

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text = "" Then
            btnSave.Enabled = False
            lblError.Text = "Please provide a password"
        ElseIf txtPassword.TextLength < 4 Then
            btnSave.Enabled = False
            lblError.Text = "Password should have at least 4 characters"
        Else
            btnSave.Enabled = True
            lblError.Text = ""
        End If
    End Sub
End Class