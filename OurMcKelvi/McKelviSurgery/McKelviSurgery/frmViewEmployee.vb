Public Class frmViewEmployee
    Private objEmployeeClass As New EmployeeClass
    Public valueID As Boolean
    Private Sub frmViewEmployee_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
        '  ReportViewer1.Dispose()
    End Sub

    Private Sub frmViewEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()
        '  ReportViewer1.Show()

        If valueID = True Then
            Me.TblEmployeeTableAdapter1.FillByIDNumber(McKelviSurgDBDataSet2.tblEmployee, Me.Tag)
        Else
            Me.TblEmployeeTableAdapter1.FillByEmployeeEmail(McKelviSurgDBDataSet2.tblEmployee, Me.Tag)
        End If


        Me.ReportViewer1.RefreshReport()
    End Sub

   
    
End Class