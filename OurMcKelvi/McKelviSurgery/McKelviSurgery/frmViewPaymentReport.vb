Public Class frmViewPaymentReport

    Private Sub frmViewPaymentReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'MainForm.AppearButtons()

        'MainFormDoctor.AppearButtons()
        'MainFormManager.AppearButtons()
        Me.Hide()

    End Sub

    Private Sub frmViewPaymentReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()



        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        Me.tblAppointmentTableAdapter.FillByPaymentID(Me.McKelviSurgDBDataSet.tblAppointment, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPayment' table. You can move, or remove it, as needed.
        Me.tblPaymentTableAdapter.FillByPaymentID(Me.McKelviSurgDBDataSet.tblPayment, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        Me.tblPatientTableAdapter.FillByPaymentID(Me.McKelviSurgDBDataSet.tblPatient, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.tblEmployeeTableAdapter.FillByPaymentID(Me.McKelviSurgDBDataSet.tblEmployee, CInt(Me.Tag))

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class