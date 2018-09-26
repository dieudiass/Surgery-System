Public Class frmViewPatient
    Public valueID As Boolean
   

    Private Sub frmViewPatient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        PatientView.Show()
       
        

    End Sub

    
    Private Sub frmViewPatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PatientView.Show()

        
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        If valueID = True Then
            Me.tblPatientTableAdapter.FillByIDNumber(Me.McKelviSurgDBDataSet.tblPatient, Me.Tag)
        Else
            Me.tblPatientTableAdapter.FillByPhoneNumber(Me.McKelviSurgDBDataSet.tblPatient, Me.Tag)
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class