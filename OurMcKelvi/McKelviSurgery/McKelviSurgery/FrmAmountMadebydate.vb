Imports Microsoft.Reporting.WinForms
Public Class FrmAmountMadebydate
    Public dateFrom As Date
    Public dateTo As Date
    Public status As String
    Public type As String

    Private Sub FrmAmountMadebydate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPayment' table. You can move, or remove it, as needed.
        Me.tblPaymentTableAdapter.FillByFromDateTo(Me.McKelviSurgDBDataSet.tblPayment, dateFrom, dateTo, status, type)
        Dim dateFrom1 As New ReportParameter("dateFrom", dateFrom)
        Dim dateTo1 As New ReportParameter("dateTo", dateTo)
        Me.ReportViewer1.LocalReport.SetParameters(dateFrom1)
        Me.ReportViewer1.LocalReport.SetParameters(dateTo1)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class