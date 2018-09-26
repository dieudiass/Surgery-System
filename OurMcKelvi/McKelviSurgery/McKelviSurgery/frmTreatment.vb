Imports System.Data.SqlClient

Public Class frmTreatment

    Private Sub frmTreatment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
    End Sub


    Private Sub frmTreatment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblMedication' table. You can move, or remove it, as needed.
        Me.TblMedicationTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblMedication)
        'btnRemove.Enabled = False
        'btnAdd.Enabled = False
        ''TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        Me.TblPatientTableAdapter.FillByConsultID(Me.McKelviSurgDBDataSet.tblPatient, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblTreatment' table. You can move, or remove it, as needed.
        Me.TblTreatmentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblTreatment)

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblTreatment' table. You can move, or remove it, as needed.
        'Me.TblTreatmentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblTreatment)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblTreatment1' table. You can move, or remove it, as needed.
        DurationFromDateTimePicker.MinDate = Date.Today
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblTreatment' table. You can move, or remove it, as needed.
        ' Me.TblTreatmentTableAdapter.Fill(Mbe.McKelviSurgDBDataSet.tblTreatment)
        'TreatmentDurationDateTimePicker.MinDate = Date.Today
        ''  ViewAllDisease()
        Me.TblConsultationTableAdapter.FillByConsultID(Me.McKelviSurgDBDataSet.tblConsultation, Me.Tag)

    End Sub

    Public Sub ViewAllDisease()
        Dim myConn As New SqlConnection(My.Settings.McKelviSurgDBConnectionStrin)
        Dim myCommand As New SqlCommand("SELECT * FROM tblMedication ", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow



        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()


        If myTable.Rows.Count <> 0 Then

            For x As Integer = 0 To myTable.Rows.Count - 1
                oRow = myTable.Rows(x)
                ' lstMedication.Items.Add(oRow("MedDescription"))
            Next


        End If


    End Sub
    Private Sub btnTreatment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Me.TblTreatmentTableAdapter.Insert(TreatmentDurationDateTimePicker.Value, TreatmentPosologieTextBox.Text, TotalPriceTextBox.Text, ConsultIDTextBox.Text)
        MessageBox.Show("Successfully captured", "Treatment", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Me.Hide()
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
       
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Me.TblMedicationTableAdapter.FillByMedicationName(Me.McKelviSurgDBDataSet.tblMedication, txtSearch.Text)
    End Sub

    Private Sub TblMedicationDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblMedicationDataGridView.CellContentClick
        If e.ColumnIndex = 4 Then
            If lstPrescribedMedication.Items.Count = 0 Then
                lstPrescribedMedication.Items.Add(TblMedicationDataGridView.Rows(e.RowIndex).Cells(1).Value)
                lstMedicationID.Items.Add(TblMedicationDataGridView.Rows(e.RowIndex).Cells(0).Value)
                grpTreatment.Enabled = True
            Else
                For x As Integer = 0 To lstPrescribedMedication.Items.Count - 1
                    If lstPrescribedMedication.Items.Item(x) = TblMedicationDataGridView.Rows(e.RowIndex).Cells(1).Value Then
                        MessageBox.Show("Medication already added", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                Next
                lstPrescribedMedication.Items.Add(TblMedicationDataGridView.Rows(e.RowIndex).Cells(1).Value)
                lstMedicationID.Items.Add(TblMedicationDataGridView.Rows(e.RowIndex).Cells(0).Value)
                grpTreatment.Enabled = True
                Return
            End If
        End If
        If e.ColumnIndex = 5 Then
            If lstPrescribedMedication.Items.Count <> 0 Then
                For x As Integer = 0 To lstPrescribedMedication.Items.Count - 1
                    If lstPrescribedMedication.Items.Item(x) = TblMedicationDataGridView.Rows(e.RowIndex).Cells(1).Value Then
                        If MessageBox.Show("Are you sure you want to remove " & TblMedicationDataGridView.Rows(e.RowIndex).Cells(1).Value & " from the list", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            lstPrescribedMedication.Items.RemoveAt(x)
                            lstMedicationID.Items.RemoveAt(x)
                            Return
                        End If

                    End If
                Next
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim obj As New viewMedication

        ' TblTreatmentTableAdapter.Insert(TreatmentDurationDateTimePicker.Value, TreatmentPosologieTextBox.Text, ConsultIDTextBox.Text)

        MessageBox.Show("Medication have been successfully dispensed", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)
        obj.Tag = ConsultIDTextBox.Text
        obj.ShowDialog()
        Me.Hide()
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DurationFromDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DurationFromDateTimePicker.ValueChanged
        DurationToDateTimePicker.MinDate = DurationFromDateTimePicker.Value
    End Sub

    Private Sub btnSa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSa.Click
        TblTreatmentTableAdapter.Insert(DurationFromDateTimePicker.Value, DurationToDateTimePicker.Value, TreatmentPosologieTextBox.Text, ConsultIDTextBox.Text)
        If lstMedicationID.Items.Count > 0 Then
            TblTreatmentLineTableAdapter1.Insert(lstMedicationID.Items.Item(lstMedicationID.Items.Count - 1), TblTreatmentTableAdapter.LastID)
        End If
        MessageBox.Show("Treatement successfully captured", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information)
        grpTreatment.Enabled = False
        TreatmentPosologieTextBox.Clear()
        DurationFromDateTimePicker.Value = Today
        DurationToDateTimePicker.Value = Today
    End Sub
End Class