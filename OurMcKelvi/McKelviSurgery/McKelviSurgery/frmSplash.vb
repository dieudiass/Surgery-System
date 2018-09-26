
Option Explicit On
Option Infer Off
Option Strict On


Public Class frmSplash



    Private Sub FRMSPLASH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True


    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pgbSplash.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pgbSplash.Value = pgbSplash.Value + 5
        Dim x As Integer

        For x = 0 To pgbSplash.Maximum
            If x = 0 Then
                lblLoading.Text = "Loading ."
            End If
            If x = 3 Then
                lblLoading.Text = "Loading .."
            End If
            If x = 4 Then
                lblLoading.Text = "Loading ..."
            End If


        Next

        If (pgbSplash.Value = pgbSplash.Maximum) Then

            Timer1.Enabled = False
            LOGIN.Show()
            Me.Hide()




        End If
    End Sub
End Class
