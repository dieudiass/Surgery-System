Public Class frmUpdatePatient

    Private Sub TblPatientBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblPatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub


    Private Sub TblPatientBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblPatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub frmUpdatePatient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()

    End Sub

    Private Sub frmUpdatePatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        Me.TblPatientTableAdapter.FillByPatientID(Me.McKelviSurgDBDataSet.tblPatient, Me.Tag)

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Me.Validate()
        Me.TblPatientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)
        MessageBox.Show(FirstnameTextBox.Text & " " & SurnameTextBox.Text & " information was successfully updated", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class