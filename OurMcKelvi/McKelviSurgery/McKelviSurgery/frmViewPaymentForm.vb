Public Class frmViewPaymentForm
    Private objPayment As New frmPayment
    Private Sub TblPatientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblPatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub frmViewPaymentForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()

    End Sub

    Private Sub frmViewPaymentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        Me.TblAppointmentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblAppointment)
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        Me.TblPatientTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblPatient)

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

    Private Sub TblPatientDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblPatientDataGridView.CellContentClick
        If e.ColumnIndex = 14 Then
            If Me.TblPaymentTableAdapter1.FillByPendingPayment(Me.McKelviSurgDBDataSet.tblPayment, TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value) = 1 Then

                If MessageBox.Show(TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value & " have a awaiting payment. Want to proceed to payment?", "McKelvi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'objPayment.MdiParent = MainForm
                    objPayment.Tag = TblPatientDataGridView.Rows(e.RowIndex).Cells(0).Value
                    objPayment.txtPatientName.Text = TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString.ToUpper & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString.ToUpper
                    objPayment.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show(TblPatientDataGridView.Rows(e.RowIndex).Cells(1).Value & " " & TblPatientDataGridView.Rows(e.RowIndex).Cells(2).Value & " does not have a awaiting payment", "MCKelvi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        End If
    End Sub

    Private Sub rdoSurname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoSurname.CheckedChanged
        txtPhoneNumber.Text = ""
        txtPhoneNumber.Focus()
        ' TblPatientDataGridView.Visible = False
        lblPhoneError.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class