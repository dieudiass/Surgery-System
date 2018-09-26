Imports System.Data.SqlClient

Public Class frmAddConsultation
    Public patientID As Integer
    Public appID As Integer
    Private Sub TblConsultationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblConsultationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub frmAddConsultation_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmConsultation.Show()
        Me.Hide()
    End Sub

    Private Sub frmAddConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        Me.TblPatientTableAdapter.FillByAppID(Me.McKelviSurgDBDataSet.tblPatient, Me.Tag)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        Me.TblAppointmentTableAdapter.FillByAppID(Me.McKelviSurgDBDataSet.tblAppointment, Me.Tag)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        'Me.TblAppointmentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblAppointment)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblConsultation' table. You can move, or remove it, as needed.
        ' Me.TblConsultationTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblConsultation)
        MainForm.hideButtons()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim obj As New frmTreatment
        Me.TblConsultationTableAdapter.Insert(SymptomsTextBox.Text, AppIDTextBox.Text, "COMPLETED")
        UpdateAppointmentInfo("COMPLETED", AppIDTextBox.Text)
        MessageBox.Show("Consultation information was successfully captured", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'obj.MdiParent = MainForm
        obj.Tag = TblConsultationTableAdapter.LastID
        obj.Show()
        Me.Hide()
    End Sub
    Public Sub UpdateAppointmentInfo(ByVal theStatus As String, ByVal theAppID As Integer)
        Dim myConn As New SqlConnection(My.Settings.McKelviSurgDBConnectionStrin)
        Dim myCommand As New SqlCommand("UPDATE tblAppointment SET  Status= @parStatus WHERE AppID = @parAppID ", myConn)
        myCommand.Parameters.Add("@parAppID", SqlDbType.Int).Value = theAppID
        myCommand.Parameters.Add("@parStatus", SqlDbType.VarChar).Value = theStatus


        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub
End Class