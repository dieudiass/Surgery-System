Public Class viewMedication

    Private Sub viewMedication_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
    End Sub

    Private Sub viewMedication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Me.tblPatientTableAdapter.FillByConsultID(Me.McKelviSurgDBDataSet.tblPatient, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblMedication' table. You can move, or remove it, as needed.
        Me.tblMedicationTableAdapter.FillByConsultID(Me.McKelviSurgDBDataSet.tblMedication, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblTreatment' table. You can move, or remove it, as needed.
        Me.tblTreatmentTableAdapter.FillByConsultID(Me.McKelviSurgDBDataSet.tblTreatment, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblConsultation' table. You can move, or remove it, as needed.
        Me.tblConsultationTableAdapter.FillByConsultID(Me.McKelviSurgDBDataSet.tblConsultation, CInt(Me.Tag))

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class