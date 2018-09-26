Imports System.Data.SqlClient

Public Class frmPayment
    Public objView As New frmViewPaymentReport
    Private objPatient As New PatientClass
    Private Sub frmPayment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormManager.AppearButtons()
        MainFormDoctor.AppearButtons()
    End Sub



    Private Sub frmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPatient' table. You can move, or remove it, as needed.
        Me.TblPatientTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblPatient)
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()


        AmountDueTextBox.Focus()
        Me.TblPaymentTableAdapter.FillByAwaitingPaymentPatientID(Me.McKelviSurgDBDataSet.tblPayment, CInt(Me.Tag))
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblPayment' table. You can move, or remove it, as needed.
        'Me.TblPaymentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblPayment)
        'PaymentDateDateTimePicker.MinDate = Today.Date
        EmployeeIDTextBox.Text = LOGIN.objEmployeeClass.EmployeeID

        objPatient.ViewPatient(CInt(PatientIDTextBox.Text))
        If objPatient.MedicalAidName = "" Then
            PaymentTypeTextBox.Text = "CASH"
        Else
            PaymentTypeTextBox.Text = "MEDICAL AID"
            lblMedicalAid.Text = "Medical No : " & objPatient.MedicalAidNumber & vbLf & " Medical Name : " & objPatient.MedicalAidName
        End If
        txtEmployeeName.Text = LOGIN.objEmployeeClass.Firstname & " " & LOGIN.objEmployeeClass.Surname

    End Sub

    Private Sub TblPaymentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        'Me.TblPaymentBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub TblPaymentBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblPaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub

    Private Sub TblPaymentBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblPaymentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.McKelviSurgDBDataSet)

    End Sub


    Public Sub UpdatePaymentInfo(ByVal thePaymentID As Integer, ByVal thePaymentDate As Date, ByVal theAmount As Decimal, ByVal thepaymentType As String, ByVal theEmployeID As Integer, ByVal thePatientID As Integer, ByVal theAppID As Integer, ByVal theStatus As String)
        Dim myConn As New SqlConnection(My.Settings.McKelviSurgDBConnectionStrin)
        Dim myCommand As New SqlCommand("UPDATE tblPayment SET  PaymentDate = @parPaymentDate, AmountDue = @parAmountDue, PaymentType = @parPaymentType, EmployeeID = @parEmployeeID, PatientID = @parPatientID, AppID = @parAppID, Status = @parStatus WHERE PaymentID = @parPaymentID ", myConn)
        myCommand.Parameters.Add("@parPaymentID", SqlDbType.Int).Value = thePaymentID
        myCommand.Parameters.Add("@parPaymentDate", SqlDbType.Date).Value = thePaymentDate
        myCommand.Parameters.Add("@parAmountDue", SqlDbType.Int).Value = theAmount
        myCommand.Parameters.Add("@parPaymentType", SqlDbType.VarChar).Value = thepaymentType
        myCommand.Parameters.Add("@parEmployeeID", SqlDbType.Int).Value = theEmployeID
        myCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = thePatientID
        myCommand.Parameters.Add("@parAppID", SqlDbType.Int).Value = theAppID
        myCommand.Parameters.Add("@parStatus", SqlDbType.VarChar).Value = theStatus

        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub
    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        UpdatePaymentInfo(txtPaymentID.Text, Date.Today, AmountDueTextBox.Text, PaymentTypeTextBox.Text, EmployeeIDTextBox.Text, PatientIDTextBox.Text, AppIDTextBox.Text, "PAID")
        MessageBox.Show("Payment was successfully captured", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'If MessageBox.Show("View Payment Report", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        objView.Tag = txtPaymentID.Text
        objView.ShowDialog()
        Me.Close()
        ' Else
        ' Me.Hide()
        'MainForm.AppearButtons()

        'MainFormDoctor.AppearButtons()
        'MainFormManager.AppearButtons()
        'End If
    End Sub

    Private Sub chckPatientCash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckPatientCash.CheckedChanged
        If chckPatientCash.Checked Then
            PaymentTypeTextBox.Text = "CASH"
        Else
            PaymentTypeTextBox.Text = "MEDICAL AID"
            lblMedicalAid.Text = "Medical No : " & objPatient.MedicalAidNumber & vbLf & " Medical Name : " & objPatient.MedicalAidName
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        MainForm.AppearButtons()

        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Close()
    End Sub
End Class