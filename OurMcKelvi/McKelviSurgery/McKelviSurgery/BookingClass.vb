Imports System.Data.SqlClient

Public Class BookingClass

    Private ConnString As String
    Public Property _ConnString() As String
        Get
            Return ConnString
        End Get
        Set(ByVal value As String)
            ConnString = value
        End Set
    End Property


    Private BookingNo As Integer
    Public Property _BookingNo() As Integer
        Get
            Return BookingNo
        End Get
        Set(ByVal value As Integer)
            BookingNo = value
        End Set
    End Property


    Private BookingDate As Date
    Public Property _BookingDate() As Date
        Get
            Return BookingDate
        End Get
        Set(ByVal value As Date)
            BookingDate = value
        End Set
    End Property


    Private BookingTime As String
    Public Property _BookingTime() As String
        Get
            Return BookingTime
        End Get
        Set(ByVal value As String)
            BookingTime = value
        End Set
    End Property


    Private EmployeeNo As Integer
    Public Property _EmployeeNo() As Integer
        Get
            Return EmployeeNo
        End Get
        Set(ByVal value As Integer)
            EmployeeNo = value
        End Set
    End Property


    Private PatientID As Integer
    Public Property _PatientID() As Integer
        Get
            Return PatientID
        End Get
        Set(ByVal value As Integer)
            PatientID = value
        End Set
    End Property

    Public Sub New()

        ConnString = My.Settings.McKelviSurgDBConnectionStrin
        BookingNo = 0
        BookingDate = Nothing
        BookingTime = Nothing
        EmployeeNo = 0
        PatientID = 0

    End Sub

    Public Sub New(ByVal TheBookingNo As Integer, ByVal TheBookingDate As String, ByVal TheBookingTime As String, ByVal TheEmployeeNo As Integer, ByVal ThePatientID As Integer)

        ConnString = My.Settings.McKelviSurgDBConnectionStrin
        BookingNo = TheBookingNo
        BookingDate = TheBookingDate
        BookingTime = TheBookingTime
        EmployeeNo = TheEmployeeNo
        PatientID = ThePatientID
    End Sub


End Class
