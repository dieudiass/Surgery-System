Imports System.Data.SqlClient
Public Class frmAppointment
    Private appointmentDateError As Boolean = True
    Private patientError As Boolean = True
    Private doctorError As Boolean = True
    Private objAppointment As New AppointmentClass
    Private objViewAppoint As New frmViewAppoitment
    Private DoctorID As Integer
    Private Sub frmAppointment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.AppearButtons()

        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()
        Me.Hide()
    End Sub
    Public Sub ViewByAppointmentDate(ByVal theDate As Date)
        Dim myConn As New SqlConnection(My.Settings.McKelviSurgDBConnectionStrin)
        Dim myCommand As New SqlCommand("SELECT * FROM tblAppointment WHERE AppointmentDate= @parAppointmentDate", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parAppointmentDate", SqlDbType.Date).Value = theDate

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
    Public Sub ViewByDoctorAvailability()
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
                lstDoctorAll.Items.Add(oRow("Firstname") & " " & oRow("Surname"))
                cmbDoctor.Items.Add(oRow("Firstname") & " " & oRow("Surname"))
                lstDoctorID.Items.Add(oRow("EmployeeID"))
                'lstTakenTimes.Items.Add(oRow("StartingTime"))
                'For i As Integer = 0 To myTable.Rows.Count - 1
                '    myRow = myTable.Rows(i)
                '    If oRow("EmployeeID") = myRow("EmployeeID") Then
                '        lstDoctor.Items.Add(oRow("Firstname") & " " & oRow("Surname"))
                '    End If
                'Next '
            Next
        End If

        '  End If


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
    Private Sub frmAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()
        'TODO: This line of code loads data into the 'McKelviSurgDBDataSet2.tblDiseas' table. You can move, or remove it, as needed.
        Me.TblDiseasTableAdapter.Fill(Me.McKelviSurgDBDataSet2.tblDiseas)
        grpAssignDoctor.Enabled = False
        '  MessageBox.Show(AppointmentDateDateTimePicker.Value.Month)
        ' MessageBox.Show(Date.Now.ToString)
        lstStartingTime.Enabled = False
        MainForm.hideButtons()
        ViewByDiseasePrice(cmbDisease.SelectedValue)
        chkDoctor.Enabled = False
        AppointmentDateDateTimePicker.MaxDate = Date.Today.AddMonths(5)
        'cmbDoctor.DataSource = Me.TblEmployeeTableAdapter1.GetDataByDoctor()
        'cmbDoctor.ValueMember = "EmployeeID"
        'cmbDoctor.DisplayMember = "Surname"

        'lstDoctorAll.DataSource = Me.TblEmployeeTableAdapter1.GetDataByDoctor()
        'lstDoctorAll.ValueMember = "EmployeeID"
        'lstDoctorAll.DisplayMember = "Surname"


        btnSubmit.Enabled = True

        AppointmentDateDateTimePicker.MinDate = Date.Today
        'dtpStartingTime.MinDate = DateTime.Parse("8:00 AM")
        'dtpStartingTime.MaxDate = DateTime.Parse("3:30 PM")
        ''dtpStartingTime.MinDate = AppointmentDateDateTimePicker.Value
        'dtpFinishTime.MinDate = DateTime.Parse("8:30 AM")
        'dtpFinishTime.MaxDate = DateTime.Parse("4:00 PM")
        ''dtpStartingTime.Format = DateTimePickerFormat.Time
        'If dtpStartingTime.Value.Minute > 0 And dtpStartingTime.Value.Minute < 30 Then
        '    For x As Integer = 1 To 29
        '        If dtpStartingTime.Value.Minute = x Then
        '            dtpStartingTime.Value = dtpStartingTime.Value.AddMinutes(30 - x)
        '            dtpFinishTime.Value = dtpStartingTime.Value.AddMinutes(30)
        '        End If
        '    Next
        'ElseIf dtpStartingTime.Value.Minute > 30 And dtpStartingTime.Value.Minute < 60 Then
        '    For x As Integer = 31 To 59
        '        If dtpStartingTime.Value.Minute = x Then
        '            dtpStartingTime.Value = dtpStartingTime.Value.AddMinutes(60 - x)
        '            dtpFinishTime.Value = dtpStartingTime.Value.AddMinutes(30)
        '        End If
        '    Next
        'End If

        'objAppointment.ViewByPatientID(PatientIDTextBox.Text)

        'If PatientIDTextBox.Text = objAppointment.PatientID Then
        '    lblPatientError.Text = "The patient already has an appointment"
        '    btnSubmit.Enabled = False
        '    patientError = True
        'Else
        '    patientError = False
        '    lblPatientError.Text = ""
        'End If

    End Sub

  
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim row As Integer

        row = Me.TblAppointmentTableAdapter1.Insert(AppointmentDateDateTimePicker.Value, txtStarting.Text, txtFinish.Text, DoctorID, PatientIDTextBox.Text, cmbDisease.SelectedValue, "PENDING")
        Me.TblDiseasTableAdapter.FillByDiseasePrice(Me.McKelviSurgDBDataSet2.tblDiseas, cmbDisease.SelectedValue)
        If row = 1 Then

            Me.TblPaymentTableAdapter1.Insert(PatientIDTextBox.Text, Me.TblAppointmentTableAdapter1.LastID, "PENDING", Date.Today, CDec(txtPrice.Text), "", LOGIN.objEmployeeClass.EmployeeID)
            MessageBox.Show("Appointment was successfully made", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'If MessageBox.Show("View Patient Appointment report", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            objViewAppoint.Tag = PatientIDTextBox.Text
            objViewAppoint.name = txtPatientName.Text
            objViewAppoint.ShowDialog()
            Me.Hide()
           

        End If


    End Sub

    Private Sub dtpFinishTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim myConn As New SqlConnection(My.Settings.McKelviDBConnectionString)
        'Dim myCommand As New SqlCommand("SELECT * FROM tblAppointment WHERE EmployeeID= @parEmployeeID", myConn)
        'Dim myAdapter As New SqlDataAdapter(myCommand)
        'Dim myTable As New DataTable
        'Dim oRow As DataRow

        'myCommand.Parameters.Add("@parEmployeeID", SqlDbType.Int).Value = cmbDoctor.SelectedValue

        'myConn.Open()
        'myAdapter.Fill(myTable)
        'myConn.Close()


        'If myTable.Rows.Count <> 0 Then

        '    For x As Integer = 0 To myTable.Rows.Count
        '        oRow = myTable.Rows(x)
        '        If AppointmentDateDateTimePicker.Value = oRow("AppointmentDate") And (dtpStartingTime.Value.TimeOfDay = oRow("StartingTime")) Then

        '        End If
        '    Next


        'End If


    End Sub

   
   


    Private Sub dtpStartingTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If dtpStartingTime.Value <= dtpStartingTime.MaxDate And dtpStartingTime.Value >= dtpStartingTime.MinDate Then

        '    If dtpStartingTime.Value.AddMinutes(29) <= dtpStartingTime.MaxDate And dtpStartingTime.Value.AddMinutes(29) >= dtpStartingTime.MinDate Then
        '        If dtpStartingTime.Value.Minute > 0 And dtpStartingTime.Value.Minute < 30 Then
        '            For x As Integer = 0 To 29
        '                If dtpStartingTime.Value.Minute = x Then
        '                    dtpStartingTime.Value = dtpStartingTime.Value.AddMinutes(30 - x)
        '                    dtpFinishTime.Value = dtpStartingTime.Value.AddMinutes(30)
        '                End If
        '            Next
        '        ElseIf dtpStartingTime.Value.Minute > 30 And dtpStartingTime.Value.Minute < 60 Then
        '            For x As Integer = 31 To 59
        '                If dtpStartingTime.Value.Minute = x Then
        '                    dtpStartingTime.Value = dtpStartingTime.Value.AddMinutes(60 - x)
        '                    dtpFinishTime.Value = dtpStartingTime.Value.AddMinutes(30)
        '                End If
        '            Next
        '        End If
        '    Else
        '        dtpStartingTime.Value = Date.Today.Date & " 3:30 PM"
        '        dtpFinishTime.Value = Date.Today.Date & " 4:00 PM"
        '        If dtpStartingTime.Value.Minute > 0 And dtpStartingTime.Value.Minute <= 30 Then
        '            For x As Integer = 1 To 29
        '                If dtpStartingTime.Value.Minute = x Then
        '                    dtpStartingTime.Value = dtpStartingTime.Value.AddMinutes(x)
        '                    dtpFinishTime.Value = dtpStartingTime.Value.AddMinutes(30)
        '                End If
        '            Next
        '        End If
        '    End If
        'Select Case dtpStartingTime.Value.Hour
        '    Case 8, 9, 10, 11, 12, 1, 2, 3, 4
        '        If dtpStartingTime.Value.AddMinutes(29) <= dtpStartingTime.MaxDate And dtpStartingTime.Value.AddMinutes(29) >= dtpStartingTime.MinDate Then
        '            dtpStartingTime.Value = dtpStartingTime.Value.AddMinutes(29)
        '            dtpFinishTime.Value = dtpStartingTime.Value.AddMinutes(30)
        '        End If

        '    Case 29
        '        If dtpStartingTime.Value.AddMinutes(30) <= dtpStartingTime.MaxDate And dtpStartingTime.Value.AddMinutes(30) >= dtpStartingTime.MinDate Then
        '            dtpStartingTime.Value = dtpStartingTime.Value.AddMinutes(30)
        '            dtpFinishTime.Value = dtpStartingTime.Value.AddMinutes(-29)
        '        End If


        'End Select
        'Else

        'End If
        'loadData()
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
        Dim cnt As Integer
        Dim time As DateTime

        'MessageBox.Show(Date.Now.ToShortTimeString)
        'If Date.Now < Convert.ToDateTime(lstStartingTime.Items.Item(0).ToString) Then
        '    MessageBox.Show("Current Time is smaller!!!!")
        'Else
        '    MessageBox.Show("Current Time is greater!!!!")
        'End If
        cnt = lstStartingTime.Items.Count
        If AppointmentDateDateTimePicker.Value.Date = Date.Today Then

            'MessageBox.Show(lstStartingTime.Items.Item(x).ToString.Substring(0, 1))
            cnt = lstStartingTime.Items.Count

            For i As Integer = 0 To lstStartingTime.Items.Count - 1

                If i < lstStartingTime.Items.Count Then
                    ' MessageBox.Show(DateTime.Now)
                    time = Convert.ToDateTime(lstStartingTime.Items.Item(i).ToString)
                    If DateTime.Now >= time Then
                        i = 0
                        lstStartingTime.Items.RemoveAt(i)

                    End If

                End If
            Next



        End If
       



    End Sub

    Private Sub AppointmentDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentDateDateTimePicker.ValueChanged
        Dim cnt As Integer
        lstStartingTime.Items.Clear()
        lstTakenTimes.Items.Clear()
        lstDoctor.Items.Clear()
        txtDoctor.Clear()
        lstDoctorAll.Items.Clear()
        cmbDoctor.Items.Clear()
        txtStarting.Text = ""
        txtFinish.Text = ""

        chkDoctor.Enabled = False
        chkDoctor.Checked = False


        If AppointmentDateDateTimePicker.Value.DayOfWeek = DayOfWeek.Sunday Or AppointmentDateDateTimePicker.Value.DayOfWeek = DayOfWeek.Saturday Then
            lblAppointDateError.Text = "The surgery is not open on Sundays and Saturdays"
            lstStartingTime.Enabled = False
            appointmentDateError = True
        ElseIf AppointmentDateDateTimePicker.Value.Day = 25 And AppointmentDateDateTimePicker.Value.Month = 12 Then
            lblAppointDateError.Text = "The surgery is not open on Christmas day : " & AppointmentDateDateTimePicker.Value.Date
            lstStartingTime.Enabled = False
            appointmentDateError = True
        ElseIf AppointmentDateDateTimePicker.Value.Day = 1 And AppointmentDateDateTimePicker.Value.Month = 1 Then
            lblAppointDateError.Text = "The surgery is not open on New Year : " & AppointmentDateDateTimePicker.Value.Date
            lstStartingTime.Enabled = False
            appointmentDateError = True
        ElseIf AppointmentDateDateTimePicker.Value.Day = 2 And AppointmentDateDateTimePicker.Value.Month = 1 Then
            lblAppointDateError.Text = "The surgery is not open on New Year Holiday : " & AppointmentDateDateTimePicker.Value.Date
            lstStartingTime.Enabled = False
            appointmentDateError = True
        ElseIf AppointmentDateDateTimePicker.Value.Day = 21 And AppointmentDateDateTimePicker.Value.Month = 3 Then
            lblAppointDateError.Text = "The surgery is open half day on Human Rights Day : " & AppointmentDateDateTimePicker.Value.Date
            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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

        ElseIf AppointmentDateDateTimePicker.Value.Day = 14 And AppointmentDateDateTimePicker.Value.Month = 4 Then
            lblAppointDateError.Text = "The surgery is open half day on Good Friday : " & AppointmentDateDateTimePicker.Value.Date
            ' lstStartingTime.Enabled = False
            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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

        ElseIf AppointmentDateDateTimePicker.Value.Day = 17 And AppointmentDateDateTimePicker.Value.Month = 4 Then
            lblAppointDateError.Text = "The surgery is open half on Familly Day: " & AppointmentDateDateTimePicker.Value.Date
            ' lstStartingTime.Enabled = False
            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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

        ElseIf AppointmentDateDateTimePicker.Value.Day = 27 And AppointmentDateDateTimePicker.Value.Month = 4 Then
            lblAppointDateError.Text = "The surgery is open half day on Freedom Day : " & AppointmentDateDateTimePicker.Value.Date

            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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
            appointmentDateError = True
        ElseIf AppointmentDateDateTimePicker.Value.Day = 1 And AppointmentDateDateTimePicker.Value.Month = 5 Then
            lblAppointDateError.Text = "The surgery is open half day on Workers' Day: " & AppointmentDateDateTimePicker.Value.Date

            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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
            appointmentDateError = True
        ElseIf AppointmentDateDateTimePicker.Value.Day = 16 And AppointmentDateDateTimePicker.Value.Month = 6 Then
            lblAppointDateError.Text = "The surgery is open half day on Youth Day: " & AppointmentDateDateTimePicker.Value.Date
            ' lstStartingTime.Enabled = False
            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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

        ElseIf AppointmentDateDateTimePicker.Value.Day = 9 And AppointmentDateDateTimePicker.Value.Month = 9 Then
            lblAppointDateError.Text = "The surgery is open half day on National Women's Day : " & AppointmentDateDateTimePicker.Value.Date
            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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
        ElseIf AppointmentDateDateTimePicker.Value.Day = 24 And AppointmentDateDateTimePicker.Value.Month = 9 Then
            lblAppointDateError.Text = "The surgery is open half day on 	Heritage Day : " & AppointmentDateDateTimePicker.Value.Date
            'lstStartingTime.Enabled = False
            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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

        ElseIf AppointmentDateDateTimePicker.Value.Day = 25 And AppointmentDateDateTimePicker.Value.Month = 9 Then
            lblAppointDateError.Text = "The surgery is open half day on Heritage Day's Holiday : " & AppointmentDateDateTimePicker.Value.Date

            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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
        ElseIf AppointmentDateDateTimePicker.Value.Day = 16 And AppointmentDateDateTimePicker.Value.Month = 12 Then
            lblAppointDateError.Text = "The surgery is openhalf day on 	Day of Reconciliation : " & AppointmentDateDateTimePicker.Value.Date

            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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

        ElseIf AppointmentDateDateTimePicker.Value.Day = 26 And AppointmentDateDateTimePicker.Value.Month = 12 Then
            lblAppointDateError.Text = "The surgery is open half day on 	Day of Goodwill : " & AppointmentDateDateTimePicker.Value.Date

            lstStartingTime.Items.Add("09:00 AM")
            lstStartingTime.Items.Add("09:30 AM")
            lstStartingTime.Items.Add("10:00 AM")
            lstStartingTime.Items.Add("10:30 AM")
            lstStartingTime.Items.Add("11:00 AM")
            lstStartingTime.Items.Add("11:30 AM")
            lstStartingTime.Items.Add("12:00 PM")
            lstStartingTime.Items.Add("12:30 PM")
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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
            appointmentDateError = True
        Else
            loadData()
            lblAppointDateError.Text = ""
            ViewByAppointmentDate(AppointmentDateDateTimePicker.Value)
            ViewByDoctorAvailability()
            lstStartingTime.Enabled = True
            cmbDoctor.SelectedIndex = 0
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

    Public Function validateForm() As Boolean
        Dim validateSave As Boolean = False
        If appointmentDateError = False And doctorError = False And patientError = False Then
            validateSave = True
        End If
        Return validateSave
    End Function


   
    Private Sub lstStartingTime_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstStartingTime.SelectedIndexChanged
        txtStarting.Clear()
        txtFinish.Clear()
        txtDoctor.Clear()
        chkDoctor.Enabled = True
        Dim randomIndex As Integer
        randomIndex = CInt(Math.Ceiling(Rnd() * (lstDoctorAll.Items.Count - 1)) + 0)
        txtDoctor.Text = lstDoctorAll.Items.Item(randomIndex)
        DoctorID = lstDoctorID.Items.Item(randomIndex)

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

    Private Sub chkDoctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDoctor.CheckedChanged
        txtDoctor.Clear()

        If chkDoctor.Checked Then
            grpAssignDoctor.Enabled = True
        Else
            grpAssignDoctor.Enabled = False
        End If
    End Sub

    
    Private Sub cmbDoctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDoctor.SelectedIndexChanged
        txtDoctor.Text = cmbDoctor.SelectedItem
        DoctorID = lstDoctorID.Items.Item(cmbDoctor.SelectedIndex)
    End Sub

    Private Sub cmbDisease_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDisease.SelectedIndexChanged
        ViewByDiseasePrice(cmbDisease.SelectedValue)
    End Sub

    Private Sub grpAppointment_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpAppointment.Enter

    End Sub
End Class