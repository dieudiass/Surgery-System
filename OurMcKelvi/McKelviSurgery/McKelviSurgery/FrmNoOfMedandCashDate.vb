Public Class FrmNoOfMedandCashDate

    Private Property dateFrom As Date

    Private Property dateTo As Date

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click
        Dim obj As New FrmNoOfMedandCashDate
        obj.dateFrom = dtpFrom.Value
        obj.dateTo = dtpTo.Value
        obj.ShowDialog()
    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged
        dtpTo.MinDate = dtpFrom.Value
    End Sub

    Private Sub FrmNoOfMedandCashDate_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
    End Sub

    Private Sub FrmNoOfMedandCashDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        dtpTo.MinDate = dtpFrom.Value
    End Sub
End Class