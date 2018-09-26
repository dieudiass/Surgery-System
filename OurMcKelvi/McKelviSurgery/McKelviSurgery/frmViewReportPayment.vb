Public Class frmViewReportPayment

    Private Sub frmViewReportPayment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()

        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
    End Sub

    Private Sub frmViewReportPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()

        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class