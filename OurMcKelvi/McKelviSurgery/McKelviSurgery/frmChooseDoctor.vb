Imports System.Data.SqlClient

Public Class frmChooseDoctor
    Public patientID As String
    Public patientName As String
    Private obj As New RegularPatients

    Private Sub frmChooseDoctor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
    End Sub
    Public Sub ViewByDoctor()
        Dim myConn As New SqlConnection(My.Settings.McKelviSurgDBConnectionStrin)
        'Dim myCommand As New SqlCommand("SELECT DISTINCT(EmployeeID) FROM tblAppointment WHERE AppointmentDate= @parAppointmentDate", myConn)
        Dim newCommand As New SqlCommand("SELECT * FROM tblEmployee WHERE Type = 'DOCTOR'", myConn)
        Dim newAdapter As New SqlDataAdapter(newCommand)
        'Dim myAdapter As New SqlDataAdapter(myCommand)
        'Dim myTable As New DataTable
        Dim newTable As New DataTable
        'Dim myRow As DataRow
        Dim oRow As DataRow

        '  myCommand.Parameters.Add("@parAppointmentDate", SqlDbType.Date).Value = theDate

        myConn.Open()
        'Fill(myTable)
        newAdapter.Fill(newTable)
        myConn.Close()


        'If myTable.Rows.Count <> 0 Then
        If newTable.Rows.Count <> 0 Then
            For x As Integer = 0 To newTable.Rows.Count - 1
                oRow = newTable.Rows(x)
                cmbDoctor.Items.Add(oRow("Firstname") & " " & oRow("Surname"))
                lstDoctor.Items.Add(oRow("EmployeeID"))
            Next
        End If

        '  End If


    End Sub
    Private Sub frmChooseDoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblAppointment' table. You can move, or remove it, as needed.
        Me.TblEmployeeTableAdapter1.FillByPatientEmp(Me.McKelviSurgDBDataSet.tblEmployee, patientID)
       
        ViewByDoctor()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        obj.MdiParent = MainForm
        obj.PatientIDTextBox.Text = patientID
        obj.txtPatientName.Text = patientName
        obj.txtDoctor.Text = cmbDoctor.Text
        obj.doctorID = lstDoctor.Items.Item(cmbDoctor.SelectedIndex)
        obj.Show()
        Me.Hide()
    End Sub



    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        MainForm.AppearButtons()
    End Sub

    Private Sub TblEmployeeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblEmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub TblEmployeeBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblEmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub TblEmployeeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblEmployeeDataGridView.CellContentClick
        Me.TblAppointmentTableAdapter.FillByAppointment(Me.McKelviSurgDBDataSet.tblAppointment, TblEmployeeDataGridView.Rows(e.RowIndex).Cells(0).Value, patientID)
    End Sub
End Class