Imports System.Text.RegularExpressions

Public Class frmForgot
    Private objEmployee As New EmployeeClass
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            LOGIN.Show()
        End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If txtEmail.Text <> "" Then
            objEmployee.ViewEmployeeByEmail(txtEmail.Text)
            If txtEmail.Text.ToUpper = objEmployee.Email Then
                Dim obj As New frmReset
                obj.txtEmail.Text = objEmployee.Email
                obj.txtSecurity.Text = objEmployee.Security
                obj.Show()
                Me.Close()
            Else
                MessageBox.Show("Email is not registered", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub
    Public Function isValidEmailFormat(ByVal email As String) As Boolean
        Return Regex.IsMatch(email, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged
        If txtEmail.Text = "" Then
            btnReset.Enabled = False
            lblEmail.Text = "Please provide an email address"
        ElseIf (isValidEmailFormat(txtEmail.Text)) = False Then
            lblEmail.Text = "Please provide a valid email address"
            btnReset.Enabled = False

        Else
            lblEmail.Text = ""
            btnReset.Enabled = True
        End If
    End Sub

    Private Sub frmForgot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnReset.Enabled = False
    End Sub
End Class