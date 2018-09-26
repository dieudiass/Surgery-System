
Imports System.Data.SqlClient
Public Class AppointmentClass


    Private _appID As Integer
    Public Property AppID() As Integer
        Get
            Return _appID
        End Get
        Set(ByVal value As Integer)
            _appID = value
        End Set
    End Property

    Private _EmployeeID As Integer
    Public Property EmployeeID() As Integer
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Integer)
            _EmployeeID = value
        End Set
    End Property


    Private _PatientID As Integer
    Public Property PatientID() As Integer
        Get
            Return _PatientID
        End Get
        Set(ByVal value As Integer)
            _PatientID = value
        End Set
    End Property

    Private _appointmentDate As Date
    Public Property AppointmentDate() As Date
        Get
            Return _appointmentDate
        End Get
        Set(ByVal value As Date)
            _appointmentDate = value
        End Set
    End Property

    Private _StartingTime As String
    Public Property StartingTime() As String
        Get
            Return _StartingTime
        End Get
        Set(ByVal value As String)
            _StartingTime = value
        End Set
    End Property

    Private _FinishTime As String
    Public Property FinishTime() As String
        Get
            Return _FinishTime
        End Get
        Set(ByVal value As String)
            _FinishTime = value
        End Set
    End Property


    Private _Conn As String
    Public Property Conn() As String
        Get
            Return _Conn
        End Get
        Set(ByVal value As String)
            _Conn = value
        End Set
    End Property



    Public Sub New()
        Conn = My.Settings.McKelviSurgDBConnectionStrin
        AppID = 0
        EmployeeID = 0
        PatientID = 0
        FinishTime = ""
        StartingTime = ""
        AppointmentDate = Nothing
    End Sub

    Public Sub ViewByEmployeeID(ByVal theEmployeeID As Integer)
        Dim myConn As New SqlConnection(Conn)
        Dim myCommand As New SqlCommand("SELECT * FROM tblAppointment WHERE EmployeeID= @parEmployeeID", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parEmployeeID", SqlDbType.Int).Value = theEmployeeID

        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()


        If myTable.Rows.Count <> 0 Then

            For x As Integer = 0 To myTable.Rows.Count
                oRow = myTable.Rows(x)
                AppID = oRow("AppID")
                AppointmentDate = oRow("AppointmentDate")
                StartingTime = oRow("StartingTime")
                FinishTime = oRow("FinishTime")
                PatientID = oRow("PatientID")
                EmployeeID = oRow("EmployeeID")
            Next


        End If

    End Sub
    Public Sub ViewByPatientID(ByVal thePatientID As Integer)
        Dim myConn As New SqlConnection(Conn)
        Dim myCommand As New SqlCommand("SELECT * FROM tblAppointment WHERE PatientID= @parPatientID", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = thePatientID

        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()


        If myTable.Rows.Count <> 0 Then

            oRow = myTable.Rows(0)
            AppID = oRow("AppID")
            AppointmentDate = oRow("AppointmentDate")
            StartingTime = oRow("StartingTime")
            FinishTime = oRow("FinishTime")
            PatientID = oRow("PatientID")
            EmployeeID = oRow("EmployeeID")

        End If


    End Sub

End Class
