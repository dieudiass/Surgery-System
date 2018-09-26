Imports System.Data.SqlClient

Public Class cus

    Private objPatient As New PatientClass

    Private Sub TblPatientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblPatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub cus_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()

    End Sub

    Private Sub cus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()

        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        TblPatientDataGridView.Visible = True
        txtPhoneNumber.Focus()


        Me.TblPatientTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblPatient)

    End Sub

    Private Sub txtPhoneNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNumber.KeyPress

        If rdoIDNumber.Checked Or rdoPhoneNumber.Checked Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        ElseIf rdoSurname.Checked Then
            If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPhoneNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhoneNumber.TextChanged


        If rdoIDNumber.Checked Then
            txtPhoneNumber.MaxLength = 13
            If txtPhoneNumber.Text = "" Then
                lblPhoneError.Text = "Please provide a South African ID"
                'TblPatientDataGridView.Visible = False
            ElseIf txtPhoneNumber.TextLength = 13 Then
                If MessageBox.Show("Patient is not registered, Do you want to register the patient", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim objAddPatient As New frmPatientAdd
                    objAddPatient.MdiParent = MainForm
                    objAddPatient.txtIDNumber.Text = txtPhoneNumber.Text
                    objAddPatient.Show()
                    Me.Hide()
                End If
            Else
                ' TblPatientDataGridView.Visible = True
                lblPhoneError.Text = ""
                Me.TblPatientTableAdapter.FillByIDNumber(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text)

            End If

        ElseIf rdoPassportNo.Checked Then
            txtPhoneNumber.MaxLength = 13
            If txtPhoneNumber.Text = "" Then
                lblPhoneError.Text = "Please provide a passport number"
                TblPatientDataGridView.Visible = False
            ElseIf Me.TblPatientTableAdapter.FillByIDNumber(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text) = 0 Then
                If MessageBox.Show("Patient is not registered, Do you want to register the patient", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim objAddPatient As New frmPatientAdd
                    objAddPatient.MdiParent = MainForm
                    objAddPatient.txtIDNumber.Text = txtPhoneNumber.Text
                    objAddPatient.Show()
                    Me.Hide()
                End If
            Else
                'TblPatientDataGridView.Visible = True
                lblPhoneError.Text = ""
                Me.TblPatientTableAdapter.FillByIDNumber(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text)
            End If

        ElseIf rdoPhoneNumber.Checked Then
            txtPhoneNumber.MaxLength = 10
            If txtPhoneNumber.Text = "" Then
                lblPhoneError.Text = "Please provide a phone number"
                '   TblPatientDataGridView.Visible = False
            ElseIf txtPhoneNumber.Text.Substring(0, 1) <> 0 Then
                lblPhoneError.Text = "Please provide a valid phone number that start with 0"
                'btnFind.Enabled = False
                ' btnNextStep.Enabled = False
            ElseIf txtPhoneNumber.TextLength = 10 Then
                If MessageBox.Show("Patient is not registered, Do you want to register the patient", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim objAddPatient As New frmPatientAdd
                    objAddPatient.MdiParent = MainForm
                    objAddPatient.txtPhoneNumber.Text = txtPhoneNumber.Text
                    objAddPatient.Show()
                    Me.Hide()
                End If
            Else
                ' TblPatientDataGridView.Visible = True
                lblPhoneError.Text = ""
                Me.TblPatientTableAdapter.FillByPhoneNumber(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text)
            End If
        ElseIf rdoSurname.Checked Then

            If txtPhoneNumber.Text = "" Then
                lblPhoneError.Text = "Please provide a surname"
                '   TblPatientDataGridView.Visible = False
            Else
                lblPhoneError.Text = ""
                Me.TblPatientTableAdapter.FillBySurname(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text)
            End If
        ElseIf txtPhoneNumber.TextLength = 10 Then
            If MessageBox.Show("Patient is not registered, Do you want to register the patient", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim objAddPatient As New frmPatientAdd
                objAddPatient.MdiParent = MainForm
                objAddPatient.txtPhoneNumber.Text = txtPhoneNumber.Text
                objAddPatient.Show()
                Me.Hide()
            End If
        Else
            ' TblPatientDataGridView.Visible = True
            lblPhoneError.Text = ""
            Me.TblPatientTableAdapter.FillBySurname(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text)
        End If


    End Sub

    Private Sub rdoPhoneNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPhoneNumber.CheckedChanged
        txtPhoneNumber.Text = ""
        txtPhoneNumber.Focus()
        ' TblPatientDataGridView.Visible = False
        lblPhoneError.Text = ""
    End Sub

    Private Sub rdoIDNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoIDNumber.CheckedChanged
        txtPhoneNumber.Text = ""
        lblPhoneError.Text = ""
        txtPhoneNumber.Focus()
        'TblPatientDataGridView.Visible = False

    End Sub

    Private Sub rdoPassportNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPassportNo.CheckedChanged
        txtPhoneNumber.Text = ""
        txtPhoneNumber.Focus()
        ' TblPatientDataGridView.Visible = False
        lblPhoneError.Text = ""
    End Sub

    Private Sub TblPatientDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPatientDataGridView.CellContentClick
        Dim patientID As Integer
       
        If e.ColumnIndex = 12 Then
            patientID = TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value

            If Me.TblAppointmentTableAdapter1.FillByPassedAppointment(Me.McKelviSurgDBDataSet.tblAppointment, DateTime.Now, patientID) = 1 Then
                TblAppointmentTableAdapter1.UpdateStatus(TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value)
                UpdateAppointment(TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value)
            End If

            If Me.TblAppointmentTableAdapter1.FillByAwaitingAppointment(Me.McKelviSurgDBDataSet.tblAppointment, patientID) = 1 Then
                MessageBox.Show("Patient already has an appointment?", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                If MessageBox.Show("Are you sure you want to make a booking", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objPatient.ViewPatientByPatientID(patientID)

                    Dim objAppointment As New frmAppointment

                    objAppointment.PatientIDTextBox.Text = patientID
                    objAppointment.txtPatientName.Text = objPatient.Firstname & " " & objPatient.Surname
                    objAppointment.Show()
                    Me.Hide()
                End If

            End If


        End If
        If e.ColumnIndex = 13 Then
            If Me.TblAppointmentTableAdapter1.FillByAwaitingAppointment(Me.McKelviSurgDBDataSet.tblAppointment, TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value) = 0 Then
                MessageBox.Show(TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value & " does not have a awaiting appointment", "MCKelvi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Are sure you want to cancel appointment of " & TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value, "McKelvi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    UpdateAppointment(TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value)
                    MessageBox.Show("Appointment of " & TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value & " was successfully deleted", "McKelvi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        End If

    End Sub
    Public Sub UpdateAppointment(ByVal patientID As Integer)
        Dim myConn As New SqlConnection(My.Settings.McKelviSurgDBConnectionStrin)
        ' Dim myCommand As New SqlCommand("DELETE FROM tblAppointment WHERE  PatientID = @parPatientID ", myConn)
        Dim mewCommand As New SqlCommand("UPDATE tblPayment SET Status = 'CANCELLED' WHERE Status = 'PENDING' AND PatientID = @parPatientID ", myConn)


        ' myCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = patientID
        ' myCommand.Parameters.Add(" @parStatus", SqlDbType.VarChar).Value = TheStatus
        'mewCommand.Parameters.Add(" @parStatus", SqlDbType.VarChar).Value = TheStatus
        mewCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = patientID
        myConn.Open()
        'myCommand.ExecuteNonQuery()
        mewCommand.ExecuteNonQuery()
        myConn.Close()


    End Sub
    Private Sub TblPatientDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPatientDataGridView.CellValueChanged
        'TblPatientDataGridView(0, 12).Value = "Make Booking"
    End Sub

    Private Sub rdoSurname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSurname.CheckedChanged
        txtPhoneNumber.Text = ""
        txtPhoneNumber.Focus()
        ' TblPatientDataGridView.Visible = False
        lblPhoneError.Text = ""
    End Sub
End Class