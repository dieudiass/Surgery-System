Public Class FrmViewAppointment

    Private Sub FrmViewAppointment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        'MainForm.AppearButtons()
        viewPatientAppointment.Show()
    End Sub

    Private Sub FrmViewAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        Me.tblPatientTableAdapter.FillByPatientID(Me.McKelviSurgDBDataSet.tblPatient, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        Me.tblAppointmentTableAdapter.FillByAwaitingAppointment(Me.McKelviSurgDBDataSet.tblAppointment, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.tblEmployeeTableAdapter.FillByPatientID(Me.McKelviSurgDBDataSet.tblEmployee, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblDiseas' table. You can move, or remove it, as needed.
        Me.tblDiseasTableAdapter.FillBylPatientID(Me.McKelviSurgDBDataSet.tblDiseas, CInt(Me.Tag))

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class