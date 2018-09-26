Imports System.Data.SqlClient


Public Class POClass


    Private _ConnString As String
    Public Property ConnString() As String
        Get
            Return _ConnString
        End Get
        Set(ByVal value As String)
            _ConnString = value
        End Set
    End Property



    Private PoNo As Integer
    Public Property _PoNo() As Integer
        Get
            Return PoNo
        End Get
        Set(ByVal value As Integer)
            PoNo = value
        End Set
    End Property


    Private SupplierNo As Integer
    Public Property _SupplierNo() As Integer
        Get
            Return SupplierNo
        End Get
        Set(ByVal value As Integer)
            SupplierNo = value
        End Set
    End Property


    Private PoDate As String
    Public Property _PoDate() As String
        Get
            Return PoDate
        End Get
        Set(ByVal value As String)
            PoDate = value
        End Set
    End Property

    Public Sub New()

        'ConnString = My.Settings.McKelviSurgeryDBConnectionString1
        PoNo = 0
        SupplierNo = 0
        PoDate = Nothing



    End Sub

    Public Sub New(ByVal ThePoNo As Integer, ByVal TheSupplierNo As Integer, ByVal ThePoDate As String)

        'ConnString = My.Settings.McKelviSurgeryDBConnectionString
        PoNo = ThePoNo
        SupplierNo = TheSupplierNo
        PoDate = ThePoDate

    End Sub



End Class
