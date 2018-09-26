Imports System.Data.SqlClient

Public Class PrescriptionClass


    Private _ConnString As String
    Public Property ConnString() As String
        Get
            Return _ConnString
        End Get
        Set(ByVal value As String)
            _ConnString = value
        End Set
    End Property

    Private _SN As Integer
    Public Property SN() As Integer
        Get
            Return _SN
        End Get
        Set(ByVal value As Integer)
            _SN = value
        End Set
    End Property


    Private _TreatmentCode As String
    Public Property TreatmentCode() As String
        Get
            Return _TreatmentCode
        End Get
        Set(ByVal value As String)
            _TreatmentCode = value
        End Set
    End Property


    Private _Comment As String
    Public Property Comment() As String
        Get
            Return _Comment
        End Get
        Set(ByVal value As String)
            _Comment = value
        End Set
    End Property

    Public Sub New()

        ' ConnString = My.Settings.McKelviSurgeryDBConnectionString
        SN = 0
        TreatmentCode = ""
        Comment = ""

    End Sub

    Public Sub New(ByVal TheSN As Integer, ByVal TheTreatmentCode As String, ByVal TheComment As String)

        ' ConnString = My.Settings.McKelviSurgeryDBConnectionString
        SN = TheSN
        TreatmentCode = TheTreatmentCode
        Comment = TheComment
    End Sub

End Class
