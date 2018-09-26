Imports System.Data.SqlClient

Public Class LOGIN
    Public objEmployeeClass As New EmployeeClass
    Private Attempt As Integer = 4
    Private cnt As Integer = 0
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtEmail.Text = "" Then
            MessageBox.Show("Please enter a email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            txtEmail.Focus()
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter a password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            txtPassword.Focus()
        Else
            If FrmEmployee.isValidEmailFormat(txtEmail.Text) Then
                objEmployeeClass.ViewEmployeeByEmail(txtEmail.Text.ToUpper)
                If txtEmail.Text.ToUpper = objEmployeeClass.Email And txtPassword.Text = objEmployeeClass.Password Then
                    If objEmployeeClass.Attempt = "false" Then
                       
                        If objEmployeeClass.Type = "MANAGER" Then
                            MainFormManager.Text = " Welcome " & objEmployeeClass.Firstname & " to Dr Batubenga Surgery"
                            MainFormManager.lblUserInfo.Text = objEmployeeClass.Firstname & " " & objEmployeeClass.Surname & "  [ " & objEmployeeClass.Type & " ]"
                            MainFormManager.Show()

                        ElseIf objEmployeeClass.Type = "DOCTOR" Then
                            MainFormDoctor.Text = " Welcome " & objEmployeeClass.Firstname & " to Dr Batubenga Surgery"
                            MainFormDoctor.lblUserInfo.Text = objEmployeeClass.Firstname & " " & objEmployeeClass.Surname & "  [ " & objEmployeeClass.Type & " ]"
                            MainFormDoctor.Show()
                        ElseIf objEmployeeClass.Type = "RECEPTIONIST" Then
                            MainForm.Text = " Welcome " & objEmployeeClass.Firstname & " to Dr Batubenga Surgery"
                            MainForm.lblUserInfo.Text = objEmployeeClass.Firstname & " " & objEmployeeClass.Surname & "  [ " & objEmployeeClass.Type & " ]"
                            MainForm.Show()

                        End If
                        Me.Hide()

                    Else
                        MessageBox.Show("Account Blocked. Too many attempts. Reset Password ", "Login Dr Batubenga Surgery", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                Else
                    Attempt -= 1
                    MessageBox.Show("Invalid email or Password. Remaining attempt : " & Attempt, "Login Dr Batubenga Surgery", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    txtPassword.Clear()
                    txtEmail.Clear()
                    txtEmail.SelectAll()
                    txtEmail.Focus()
                    If Attempt = 0 Then
                        objEmployeeClass.ResetAttempt(txtEmail.Text, "true")
                    End If
                End If
            Else
                MessageBox.Show("Please enter a valid email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                txtEmail.SelectAll()
                txtEmail.Focus()
            End If
        End If




    End Sub


    Private Sub btnForgot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForgot.Click
        Dim obj As New frmForgot
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged
        If txtEmail.Text = "" Or txtPassword.Text = "" Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True
        End If
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        If txtEmail.Text = "" Or txtPassword.Text = "" Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True
        End If
    End Sub

    Private Sub LOGIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPayment' table. You can move, or remove it, as needed.
        Me.TblPaymentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblPayment)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        '  Me.TblAppointmentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblAppointment)
        btnLogin.Enabled = False
        TblAppointmentTableAdapter.UpdateAppointment(Date.Now.ToShortTimeString, Date.Today)
        TblPaymentTableAdapter.UpdatePaymentStatus(Date.Now.ToShortTimeString, Date.Today)

    End Sub

    Private Sub TblAppointmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblAppointmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub
End Class