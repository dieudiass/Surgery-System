Imports System.Data.SqlClient

Public Class viewPatientAppointment
    Private objViewAppoint As New FrmViewAppointment
    Private obj As New frmUpdatePatient
    Private Sub TblPatientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblPatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub viewPatientAppointment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormManager.AppearButtons()
        MainFormDoctor.AppearButtons()
        Me.Hide()
    End Sub

    Private Sub viewPatientAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblEmployee' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        'Me.TblAppointmentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblAppointment)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        ' Me.TblPatientTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblPatient)
        '  Me.TblPatientTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblPatient)
    End Sub

    Private Sub txtPhoneNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If rdoIDNumber.Checked Or rdoPhoneNumber.Checked Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtPhoneNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhoneNumber.TextChanged
        If rdoIDNumber.Checked Then
            txtPhoneNumber.MaxLength = 13
            If txtPhoneNumber.Text = "" Then
                lblPhoneError.Text = "Please provide a South African ID"
            Else
                lblPhoneError.Text = ""
                Me.TblPatientTableAdapter.FillByIDNumber(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text)

            End If

        ElseIf rdoPassportNo.Checked Then
            txtPhoneNumber.MaxLength = 13
            If txtPhoneNumber.Text = "" Then
                lblPhoneError.Text = "Please provide a passport number"
            Else
                lblPhoneError.Text = ""
                Me.TblPatientTableAdapter.FillByIDNumber(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text)
            End If
        ElseIf rdoSurname.Checked Then

            If txtPhoneNumber.Text = "" Then
                lblPhoneError.Text = "Please provide a surname"
                '   TblPatientDataGridView.Visible = False
            Else
                lblPhoneError.Text = ""
                Me.TblPatientTableAdapter.FillBySurname(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text)
            End If


        ElseIf rdoPhoneNumber.Checked Then
            txtPhoneNumber.MaxLength = 10
            If txtPhoneNumber.Text = "" Then
                lblPhoneError.Text = "Please provide a phone number"
            Else
                lblPhoneError.Text = ""
                Me.TblPatientTableAdapter.FillByPhoneNumber(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text)
            End If

            End If
    End Sub

    Private Sub rdoPhoneNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPhoneNumber.CheckedChanged
        txtPhoneNumber.Text = ""
        txtPhoneNumber.Focus()
        lblPhoneError.Text = ""
    End Sub

    Private Sub rdoIDNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoIDNumber.CheckedChanged
        txtPhoneNumber.Text = ""
        txtPhoneNumber.Focus()
        lblPhoneError.Text = ""
    End Sub

    Private Sub rdoPassportNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPassportNo.CheckedChanged
        txtPhoneNumber.Text = ""
        txtPhoneNumber.Focus()
        lblPhoneError.Text = ""
    End Sub
    Public Sub DeleteAppointment(ByVal patientID As Integer)
        Dim myConn As New SqlConnection(My.Settings.McKelviSurgDBConnectionStrin)
        Dim myCommand As New SqlCommand("DELETE FROM tblAppointment WHERE  PatientID = @parPatientID ", myConn)
        Dim mewCommand As New SqlCommand("DELETE FROM tblPayment WHERE  PatientID = @parPatientID ", myConn)
      

        myCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = patientID
        mewCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = patientID
        myConn.Open()
        myCommand.ExecuteNonQuery()
        mewCommand.ExecuteNonQuery()
        myConn.Close()


    End Sub

    Private Sub TblPatientDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPatientDataGridView.CellContentClick
        If e.ColumnIndex = 12 Then
            If Me.TblAppointmentTableAdapter.FillByAwaitingAppointment(Me.McKelviSurgDBDataSet.tblAppointment, TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value) = 0 Then
                MessageBox.Show(TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value & " does not have a awaiting appointment", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("View Appointment report of " & TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value, "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objViewAppoint.Tag = TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value
                    objViewAppoint.ShowDialog()
                    Me.Hide()
                End If
            End If


        End If
        If e.ColumnIndex = 13 Then
            If Me.TblAppointmentTableAdapter.FillByAwaitingAppointment(Me.McKelviSurgDBDataSet.tblAppointment, TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value) = 0 Then
                MessageBox.Show(TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value & " does not have a awaiting appointment", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Are sure you want to cancel appointment of " & TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value, "MDr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    DeleteAppointment(TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value)
                    MessageBox.Show("Appointment of " & TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value & " was successfully deleted", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        End If
        If e.ColumnIndex = 14 Then
           
            If MessageBox.Show("Are sure you want to update information of " & TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value, "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                obj.Tag = TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value
                obj.MdiParent = MainForm
                MainForm.hideButtons()
                obj.Show()
            End If
        End If


    End Sub

    Private Sub rdoSurname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSurname.CheckedChanged
        txtPhoneNumber.Text = ""
        txtPhoneNumber.Focus()
        ' TblPatientDataGridView.Visible = False
        lblPhoneError.Text = ""
    End Sub
End Class