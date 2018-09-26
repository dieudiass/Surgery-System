Public Class frmViewAppoitment
    Public employeeId As Integer
    Public patientid As Integer
    Public appointid As Integer
    Public name As String

    Private Sub frmViewAppoitment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Would you like to proceed with the payment ? ", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim obj As New frmPayment
            obj.txtPatientName.Text = name.ToUpper
            obj.Tag = Me.Tag
            obj.Show()
        Else
            MainForm.AppearButtons()

            MainFormDoctor.AppearButtons()
            MainFormManager.AppearButtons()
            Me.Hide()
        End If
        ' AppIDTextBox.Text = Me.TblAppointmentTableAdapter1.LastID
    End Sub

    Private Sub frmViewAppoitment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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