Public Class frmMedication

    Private Sub TblMedicationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblMedicationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub


    Private Sub TblMedicationBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblMedicationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblMedicationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub frmMedication_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()

        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()

        Me.Hide()
    End Sub

    Private Sub frmMedication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblMedication' table. You can move, or remove it, as needed.
        Me.TblMedicationTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblMedication)

    End Sub

    Private Sub MedDescriptionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedDescriptionTextBox.TextChanged

    End Sub
End Class