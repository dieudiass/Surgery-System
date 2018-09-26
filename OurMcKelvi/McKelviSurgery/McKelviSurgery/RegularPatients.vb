Imports System.Data.SqlClient

Public Class RegularPatients
    Public doctorID As Integer
    Private objViewAppoint As New frmViewAppoitment
    Private Sub lstStartingTime_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstStartingTime.SelectedIndexChanged
        txtStarting.Clear()
        txtFinish.Clear()
        txtStarting.Text = lstStartingTime.SelectedItem
        If txtStarting.Text = "08:00 AM" Then
            txtFinish.Text = "08:30 AM"
        ElseIf txtStarting.Text = "08:30 AM" Then
            txtFinish.Text = "09:00 AM"
        ElseIf txtStarting.Text = "09:00 AM" Then
            txtFinish.Text = "09:30 AM"
        ElseIf txtStarting.Text = "09:30 AM" Then
            txtFinish.Text = "10:00 AM"
        ElseIf txtStarting.Text = "10:00 AM" Then
            txtFinish.Text = "10:30 AM"
        ElseIf txtStarting.Text = "10:30 AM" Then
            txtFinish.Text = "11:00 PM"
        ElseIf txtStarting.Text = "11:00 AM" Then
            txtFinish.Text = "11:30 AM"
        ElseIf txtStarting.Text = "11:30 AM" Then
            txtFinish.Text = "12:00 PM"
        ElseIf txtStarting.Text = "12:00 PM" Then
            txtFinish.Text = "12:30 PM"
        ElseIf txtStarting.Text = "12:30 PM" Then
            txtFinish.Text = "01:00 PM"
        ElseIf txtStarting.Text = "01:00 PM" Then
            txtFinish.Text = "01:30 PM"
        ElseIf txtStarting.Text = "01:30 PM" Then
            txtFinish.Text = "02:00 PM"
        ElseIf txtStarting.Text = "02:00 PM" Then
            txtFinish.Text = "02:30 PM"
        ElseIf txtStarting.Text = "02:30 PM" Then
            txtFinish.Text = "03:00 PM"
        ElseIf txtStarting.Text = "03:00 PM" Then
            txtFinish.Text = "03:30 PM"
        ElseIf txtStarting.Text = "03:30 PM" Then
            txtFinish.Text = "04:00 PM"
        ElseIf txtStarting.Text = "04:00 PM" Then
            txtFinish.Text = "04:30 PM"
        ElseIf txtStarting.Text = "04:30 PM" Then
            txtFinish.Text = "05:00 PM"
        End If
    End Sub

    Private Sub AppointmentDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentDateDateTimePicker.ValueChanged
        Dim cnt As Integer
        lstStartingTime.Items.Clear()
        lstTakenTimes.Items.Clear()
        txtStarting.Text = ""
        txtFinish.Text = ""

        If AppointmentDateDateTimePicker.Value.DayOfWeek = DayOfWeek.Sunday Or AppointmentDateDateTimePicker.Value.DayOfWeek = DayOfWeek.Saturday Then
            lblAppointDateError.Text = "The surgery is not open on Sundays and Saturdays"
            lstStartingTime.Enabled = False
        Else
            loadData()
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value, doctorID)

            lstStartingTime.Enabled = True

            cnt = lstStartingTime.Items.Count
            For x As Integer = 0 To lstTakenTimes.Items.Count - 1
                For i As Integer = 0 To lstStartingTime.Items.Count - 1

                    If i < lstStartingTime.Items.Count Then
                        If lstStartingTime.Items.Item(i).ToString = lstTakenTimes.Items.Item(x).ToString Then
                            lstStartingTime.Items.RemoveAt(i)
                        End If
                    End If
                Next
            Next



        End If
    End Sub
    Private Sub loadData()

        lstStartingTime.Items.Add("08:00 AM")
        lstStartingTime.Items.Add("08:30 AM")
        lstStartingTime.Items.Add("09:00 AM")
        lstStartingTime.Items.Add("09:30 AM")
        lstStartingTime.Items.Add("10:00 AM")
        lstStartingTime.Items.Add("10:30 AM")
        lstStartingTime.Items.Add("11:00 AM")
        lstStartingTime.Items.Add("11:30 AM")
        lstStartingTime.Items.Add("12:00 PM")
        lstStartingTime.Items.Add("12:30 PM")
        lstStartingTime.Items.Add("01:00 PM")
        lstStartingTime.Items.Add("01:30 PM")
        lstStartingTime.Items.Add("02:00 PM")
        lstStartingTime.Items.Add("02:30 PM")
        lstStartingTime.Items.Add("03:00 PM")
        lstStartingTime.Items.Add("03:30 PM")



        'If AppointmentDateDateTimePicker.Value.Date = Date.Today Then
        '    'For x As Integer = 0 To lstStartingTime.Items.Count - 1
        '    '    MessageBox.Show(lstStartingTime.Items.Item(x).ToString.Substring(0, 1))
        '    '    'If Date.Today.Hour >= lstStartingTime.Items.Item(x).ToString.Substring(0, 1) Then
        '    '    '    MessageBox.Show(lstStartingTime.Items.Item(x).ToString.Substring(0, 1))
        '    '    '    'lstStartingTime.Items.RemoveAt(x)
        '    '    'End If
        '    'Next

        '    For i As Integer = 0 To lstStartingTime.Items.Count - 1
        '        MessageBox.Show(lstStartingTime.Items.Item(i).ToString.Substring(3, 2))
        '        MessageBox.Show(lstStartingTime.Items.Item(i).ToString.Substring(5))
        '        MessageBox.Show(Date.Now.ToShortTimeString)
        '        MessageBox.Show(Date.Now.ToShortTimeString.Substring(3, 2))
        '        'If i < lstStartingTime.Items.Count Then
        '        '    If (lstStartingTime.Items.Item(i).ToString.Substring(5) = "AM" And Date.Today.ToShortTimeString.Substring(4) = "AM" And CInt(lstStartingTime.Items.Item(i).ToString.Substring(0, 2)) <= CInt(Date.Today.ToShortTimeString.Substring(0, 1)) And CInt(lstStartingTime.Items.Item(i).ToString.Substring(3, 2)) < CInt(Date.Today.ToShortTimeString.Substring(2, 2))) Then
        '        '        lstStartingTime.Items.RemoveAt(i)
        '        '    End If
        '        'End If
        '    Next

        'End If




    End Sub
    Public Sub ViewByAppointmentDate(ByVal theDate As Date, ByVal theDoctorID As Integer)
        Dim myConn As New SqlConnection(My.Settings.McKelviSurgDBConnectionStrin)
        Dim myCommand As New SqlCommand("SELECT * FROM tblAppointment WHERE AppointmentDate= @parAppointmentDate AND EmployeeID = @parEmployeeID ", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parAppointmentDate", SqlDbType.Date).Value = theDate
        myCommand.Parameters.Add("@parEmployeeID", SqlDbType.Int).Value = theDoctorID

        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()


        If myTable.Rows.Count <> 0 Then

            For x As Integer = 0 To myTable.Rows.Count - 1
                oRow = myTable.Rows(x)
                lstTakenTimes.Items.Add(oRow("StartingTime"))
            Next


        End If


    End Sub
    Public Sub ViewByDiseasePrice(ByVal theDiseaseId As Integer)
        Dim myConn As New SqlConnection(My.Settings.McKelviSurgDBConnectionStrin)
        Dim myCommand As New SqlCommand("SELECT * FROM tblDiseas WHERE  DiseaseID = @parDiseaseID ", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parDiseaseID", SqlDbType.Int).Value = theDiseaseId

        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()


        If myTable.Rows.Count <> 0 Then


            oRow = myTable.Rows(0)
            txtPrice.Text = oRow("DiseasePrice")

        End If


    End Sub
    Private Sub RegularPatients_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
    End Sub
    Private Sub RegularPatients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet.tblDiseas' table. You can move, or remove it, as needed.
        Me.TblDiseasTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblDiseas)
        lstStartingTime.Enabled = False
        MainForm.hideButtons()
        AppointmentDateDateTimePicker.MinDate = Date.Today
        ViewByDiseasePrice(cmbDisease.SelectedValue)
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim row As Integer

        row = Me.TblAppointmentTableAdapter1.Insert(AppointmentDateDateTimePicker.Value, txtStarting.Text, txtFinish.Text, doctorID, PatientIDTextBox.Text, cmbDisease.SelectedValue, "PENDING")
        Me.TblDiseasTableAdapter.FillByDiseasePrice(Me.McKelviSurgDBDataSet.tblDiseas, cmbDisease.SelectedValue)
        If row = 1 Then

            Me.TblPaymentTableAdapter1.Insert(PatientIDTextBox.Text, Me.TblAppointmentTableAdapter1.LastID, "PENDING", Date.Today, CDec(txtPrice.Text), "", LOGIN.objEmployeeClass.EmployeeID)
            MessageBox.Show("Appointment was successfully made", "MCKelvi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If MessageBox.Show("View Patient Appointment report", "McKelvi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                objViewAppoint.Tag = PatientIDTextBox.Text
                objViewAppoint.ShowDialog()
                Me.Hide()
            End If
            ' AppIDTextBox.Text = Me.TblAppointmentTableAdapter1.LastID

        End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
        frmChooseDoctor.Show()
    End Sub

    Private Sub cmbDisease_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDisease.SelectedIndexChanged
        ' MessageBox.Show(cmbDisease.SelectedValue)
        ViewByDiseasePrice(cmbDisease.SelectedValue)
    End Sub
End Class