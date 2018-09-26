Public Class frmNewPassword
    Private objEmployee As New EmployeeClass
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            LOGIN.Show()
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If txtNewPassword.Text = txtConfirm.Text Then
            objEmployee.ResetPassword(txtEmail.Text, txtNewPassword.Text)
            objEmployee.ResetAttempt(txtEmail.Text, "false")
            MessageBox.Show("The password was successlly reset", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            LOGIN.Show()
        End If
    End Sub

    Private Sub txtConfirm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirm.TextChanged
        lblConfirm.Text = ""
        lblPassword.Text = ""
        If txtNewPassword.Text <> "" Then
            lblPassword.Text = ""
            If txtConfirm.Text <> txtNewPassword.Text Then
                lblConfirm.Text = "Password do not match"
                btnReset.Enabled = False
            Else
                lblConfirm.Text = ""
                btnReset.Enabled = True
            End If
        Else
            lblPassword.Text = "Please provide a password"
            btnReset.Enabled = False
        End If
        
    End Sub
End Class