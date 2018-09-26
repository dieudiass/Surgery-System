Public Class frmTreatmentReport

    Private Sub TblPatientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblPatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub frmTreatmentReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()

        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
    End Sub

    Private Sub frmTreatmentReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()

        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblConsultation' table. You can move, or remove it, as needed.
        Me.TblConsultationTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblConsultation)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        Me.TblAppointmentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblAppointment)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblConsultation' table. You can move, or remove it, as needed.
        Me.TblConsultationTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblConsultation)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        Me.TblPatientTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblPatient)

    End Sub

    Private Sub TblConsultationDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblConsultationDataGridView.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim obj As New viewMedication
            obj.Tag = TblConsultationDataGridView.Rows(e.RowIndex).Cells(0).Value
            obj.ShowDialog()

        End If
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
        ' TblPatientDataGridView.Visible = False
        lblPhoneError.Text = ""
    End Sub

    Private Sub rdoIDNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoIDNumber.CheckedChanged
        txtPhoneNumber.Text = ""
        lblPhoneError.Text = ""
        txtPhoneNumber.Focus()
    End Sub

    Private Sub rdoPassportNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoPassportNo.CheckedChanged
        txtPhoneNumber.Text = ""
        txtPhoneNumber.Focus()
        ' TblPatientDataGridView.Visible = False
        lblPhoneError.Text = ""
    End Sub

    Private Sub rdoSurname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSurname.CheckedChanged
        txtPhoneNumber.Text = ""
        txtPhoneNumber.Focus()
        ' TblPatientDataGridView.Visible = False
        lblPhoneError.Text = ""
    End Sub
End Class