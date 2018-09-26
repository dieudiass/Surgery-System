Imports System.Data.SqlClient

Public Class ConsultationClass


    Private _ConnString As String
    Public Property ConnString() As String
        Get
            Return _ConnString
        End Get
        Set(ByVal value As String)
            _ConnString = value
        End Set
    End Property


    Private _ConsultationNo As Integer
    Public Property ConsultationNo() As Integer
        Get
            Return _ConsultationNo
        End Get
        Set(ByVal value As Integer)
            _ConsultationNo = value
        End Set
    End Property


    Private _Fees As Integer
    Public Property Fees() As Integer
        Get
            Return _Fees
        End Get
        Set(ByVal value As Integer)
            _Fees = value
        End Set
    End Property


    Private _ConsultationDate As String
    Public Property ConsultationDate() As String
        Get
            Return _ConsultationDate
        End Get
        Set(ByVal value As String)
            _ConsultationDate = value
        End Set
    End Property


    Private _ConsultationTime As String
    Public Property ConsultationTime() As String
        Get
            Return _ConsultationTime
        End Get
        Set(ByVal value As String)
            _ConsultationTime = value
        End Set
    End Property


    Private _PaymentNo As Integer
    Public Property PaymentNo() As String
        Get
            Return _PaymentNo
        End Get
        Set(ByVal value As String)
            _PaymentNo = value
        End Set
    End Property


    Private _BookingNo As Integer
    Public Property BookingNo() As Integer
        Get
            Return _BookingNo
        End Get
        Set(ByVal value As Integer)
            _BookingNo = value
        End Set
    End Property

    Public Sub New()

        ConnString = My.Settings.McKelviSurgDBConnectionStrin
        ConsultationNo = 0
        Fees = 0
        ConsultationDate = Nothing
        ConsultationTime = Nothing
        PaymentNo = 0
        BookingNo = 0

    End Sub

    Public Sub New(ByVal TheConsultationNo As Integer, ByVal Thefee As Integer, ByVal TheConsultationDate As String, ByVal TheConsultationTime As String, ByVal ThePaymentNO As Integer, ByVal TheBookingNo As Integer)

        ConnString = My.Settings.McKelviSurgDBConnectionStrin
        ConsultationNo = TheConsultationNo
        Fees = Thefee
        ConsultationDate = TheConsultationDate
        ConsultationTime = TheConsultationTime
        PaymentNo = ThePaymentNO
        BookingNo = TheBookingNo

    End Sub


End Class
