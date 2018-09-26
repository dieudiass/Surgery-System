Imports System.Data.SqlClient

Public Class frmConsultation
    Private objConsultation As New frmTreatment
    'Private Sub TblConsultationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.TblConsultationBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    'End Sub


    Private Sub TblAppointmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()


    End Sub

    Private Sub frmConsultation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
    End Sub
    Public Sub DeleteAppointment(ByVal patientID As Integer)
        Dim myConn As New SqlConnection(My.Settings.McKelviSurgDBConnectionString1)
        Dim myCommand As New SqlCommand("DELETE FROM tblAppointment WHERE  PatientID = @parPatientID ", myConn)
        Dim mewCommand As New SqlCommand("DELETE FROM tblPayment WHERE  PatientID = @parPatientID ", myConn)


        myCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = patientID
        ' myCommand.Parameters.Add(" @parStatus", SqlDbType.VarChar).Value = TheStatus
        'mewCommand.Parameters.Add(" @parStatus", SqlDbType.VarChar).Value = TheStatus
        mewCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = patientID
        myConn.Open()
        myCommand.ExecuteNonQuery()
        mewCommand.ExecuteNonQuery()
        myConn.Close()


    End Sub
    Private Sub frmConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        'Me.TblAppointmentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblAppointment)
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()
        TblAppointmentTableAdapter.UpdateAppointment(Date.Today, Date.Now.ToShortTimeString)
        TblPaymentTableAdapter1.UpdatePaymentStatus(Date.Today, Date.Now.ToShortTimeString)

    End Sub

    Private Sub rdoToday_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoToday.CheckedChanged
        Me.TblAppointmentTableAdapter.FillByTodayAppointment(Me.McKelviSurgDBDataSet.tblAppointment, LOGIN.objEmployeeClass.EmployeeID, Today.Date)
    End Sub

    Private Sub rdoFuture_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoFuture.CheckedChanged
        Me.TblAppointmentTableAdapter.FillByFutureAppointment(Me.McKelviSurgDBDataSet.tblAppointment, Today.Date, LOGIN.objEmployeeClass.EmployeeID)
    End Sub

    Private Sub TblAppointmentDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblAppointmentDataGridView.CellContentClick
        Dim obj As New frmAddConsultation
        If e.ColumnIndex = 8 Then
            If TblAppointmentDataGridView.Rows(e.RowIndex).Cells(1).Value = Date.Today Then
                If Date.Now < Convert.ToDateTime(TblAppointmentDataGridView.Rows(e.RowIndex).Cells(2).Value) Or Date.Now > Convert.ToDateTime(TblAppointmentDataGridView.Rows(e.RowIndex).Cells(3).Value) Then
                    MessageBox.Show("Cannot capture appointment. Time not yet arrived", "McKelvi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If MessageBox.Show("Are you sure you want to capture consultion information", "McKelvi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        obj.Tag = TblAppointmentDataGridView.Rows(e.RowIndex).Cells(0).Value
                        obj.Show()
                        Me.Hide()
                    End If
                End If
               
            Else
                MessageBox.Show("Cannot capture future appointment", "McKelvi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub
End Class