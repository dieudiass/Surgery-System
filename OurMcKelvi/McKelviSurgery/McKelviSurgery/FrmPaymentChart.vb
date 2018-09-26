Public Class FrmPaymentChart

    Private Sub FrmPaymentChart_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()

        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()

    End Sub

    Private Sub FrmPaymentChart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()

        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPayment' table. You can move, or remove it, as needed.
        Me.TblPaymentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblPayment)

    End Sub
End Class