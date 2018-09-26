Public Class frmReset
    Private objEmployee As New EmployeeClass
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            LOGIN.Show()
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If txtAnswer.Text <> "" Then
            objEmployee.ViewEmployeeByEmail(txtEmail.Text)
            If objEmployee.Email = txtEmail.Text Then
                If objEmployee.Answer = txtAnswer.Text Then
                    Dim obj As New frmNewPassword
                    obj.txtEmail.Text = objEmployee.Email
                    obj.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Wrong answer", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub frmReset_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnReset.Enabled = False
    End Sub

    Private Sub txtAnswer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAnswer.TextChanged
        If txtAnswer.Text = "" Then
            btnReset.Enabled = False
            lblAnswer.Text = "Please provide an answer"
        Else
            btnReset.Enabled = True
            lblAnswer.Text = ""
        End If
    End Sub
End Class