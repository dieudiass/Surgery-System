Imports Microsoft.Reporting.WinForms
Public Class FrmNoOfCashAndMedicalaid
    Public dateFrom As Date
    Public dateTo As Date

    Private Sub FrmNoOfCashAndMedicalaid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()

    End Sub
    Private Sub FrmNoOfCashAndMedicalaid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class