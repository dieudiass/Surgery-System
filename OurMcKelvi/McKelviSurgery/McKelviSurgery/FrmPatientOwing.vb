Imports Microsoft.Reporting.WinForms


Public Class FrmPatientOwing
    Public dateFrom As Date
    Public dateTo As Date
    Public status As String
    Public type As String
    Private Sub FrmPatientOwing_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MainForm.AppearButtons()
        'MainFormDoctor.AppearButtons()
        'MainFormManager.AppearButtons()
        FrmPatientOwingDate.Show()
        Me.Hide()

    End Sub

    Private Sub FrmPatientOwing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()


        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPayment' table. You can move, or remove it, as needed.
        Me.tblPaymentTableAdapter.FillByFromDateTo(Me.McKelviSurgDBDataSet.tblPayment, dateFrom, dateTo, status, type)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        Me.tblPatientTableAdapter.FillByFromToDatePayment(Me.McKelviSurgDBDataSet.tblPatient, dateFrom, dateTo, status, type)
        Dim dateFrom1 As New ReportParameter("dateFrom", dateFrom)
        Dim dateTo1 As New ReportParameter("dateTo", dateTo)
        Dim status1 As New ReportParameter("status", status)
        Dim type1 As New ReportParameter("Type", type)
        Me.ReportViewer1.LocalReport.SetParameters(dateFrom1)
        Me.ReportViewer1.LocalReport.SetParameters(dateTo1)
        Me.ReportViewer1.LocalReport.SetParameters(status1)
        Me.ReportViewer1.LocalReport.SetParameters(type1)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class