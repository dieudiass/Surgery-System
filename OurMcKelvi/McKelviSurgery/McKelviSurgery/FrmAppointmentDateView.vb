Imports Microsoft.Reporting.WinForms

Public Class FrmAppointmentDateView
    Public dateFrom As Date
    Public dateTo As Date
    Public status As String
    Private Sub FrmAppointmentDateView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        Me.tblAppointmentTableAdapter.FillByFromToDate(Me.McKelviSurgDBDataSet.tblAppointment, dateFrom, dateTo, status)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        Me.tblPatientTableAdapter.FillByFromToDate(Me.McKelviSurgDBDataSet.tblPatient, dateFrom, dateTo, status)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.tblEmployeeTableAdapter.FillByFromToDate(Me.McKelviSurgDBDataSet.tblEmployee, dateFrom, dateTo, status)
        Dim dateFrom1 As New ReportParameter("dateFrom", dateFrom)
        Dim dateTo1 As New ReportParameter("dateTo", dateTo)
        Dim status1 As New ReportParameter("status", status)
        Me.ReportViewer1.LocalReport.SetParameters(dateFrom1)
        Me.ReportViewer1.LocalReport.SetParameters(dateTo1)
        Me.ReportViewer1.LocalReport.SetParameters(status1)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class