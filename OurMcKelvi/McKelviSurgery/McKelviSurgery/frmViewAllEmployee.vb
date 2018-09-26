Public Class frmViewAllEmployee

    Private Sub TblEmployeeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblEmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub frmViewAllEmployee_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
    End Sub

    Private Sub frmViewAllEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblEmployee)
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblEmployee' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblEmployee)

    End Sub

    Private Sub TblEmployeeBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblEmployeeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblEmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub
End Class