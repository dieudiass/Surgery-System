Imports System.Data.SqlClient

Public Class PaymentClass


    Private ConnString As String
    Public Property _ConnString() As String
        Get
            Return ConnString
        End Get
        Set(ByVal value As String)
            ConnString = value
        End Set
    End Property


    Private PaymentNo As Integer
    Public Property _PaymentNo() As Integer
        Get
            Return PaymentNo
        End Get
        Set(ByVal value As Integer)
            PaymentNo = value
        End Set
    End Property

    Private PaymentType As String
    Public Property _PaymentType() As String
        Get
            Return PaymentType
        End Get
        Set(ByVal value As String)
            PaymentType = value
        End Set
    End Property


    Private PaymentDate As String
    Public Property _PaymentDate() As String
        Get
            Return PaymentDate
        End Get
        Set(ByVal value As String)
            PaymentDate = value
        End Set
    End Property


    Private AmountDate As String
    Public Property _AmountDate() As String
        Get
            Return AmountDate
        End Get
        Set(ByVal value As String)
            AmountDate = value
        End Set
    End Property


    Private PatientID As String
    Public Property _PatientID() As String
        Get
            Return PatientID
        End Get
        Set(ByVal value As String)
            PatientID = value
        End Set
    End Property

    Public Sub New()

        ConnString = My.Settings.McKelviSurgDBConnectionStrin
        PaymentNo = 0
        PaymentType = Nothing
        PaymentDate = Nothing
        AmountDate = 0
        PatientID = 0

    End Sub

    Public Sub New(ByVal ThePaymentNo As Integer, ByVal ThePaymentType As String, ByVal ThePaymentDate As String, ByVal theAmountPaid As Integer, ByVal ThePatientID As Integer)

        ConnString = My.Settings.McKelviSurgDBConnectionStrin
        PaymentNo = ThePaymentNo
        PaymentType = ThePaymentType
        PaymentDate = ThePaymentDate
        AmountDate = theAmountPaid
        PatientID = ThePatientID


    End Sub
End Class
