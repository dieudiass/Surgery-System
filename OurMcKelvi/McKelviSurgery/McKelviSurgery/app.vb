Public Class app
    Public patiendid As Integer
    Public employeeId As Integer
    Private Sub TblPatientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblPatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub app_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()

    End Sub

    Private Sub app_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        '  Me.TblAppointmentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblAppointment)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
        'Me.TblEmployeeTableAdapter.FillByAppointmentReport(Me.McKelviSurgDBDataSet.tblEmployee, employeeId, patiendid)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        ' Me.TblPatientTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblPatient)
        MainForm.hideButtons()


    End Sub
End Class