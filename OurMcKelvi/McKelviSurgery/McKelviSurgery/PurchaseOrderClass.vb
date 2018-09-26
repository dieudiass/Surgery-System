Imports System.Data.SqlClient

Public Class PurchaseOrderClass


    Private _ConnString As String
    Public Property ConnString() As String
        Get
            Return _ConnString
        End Get
        Set(ByVal value As String)
            _ConnString = value
        End Set
    End Property

    Private _PoNo As Integer
    Public Property PoNo() As Integer
        Get
            Return _PoNo
        End Get
        Set(ByVal value As Integer)
            _PoNo = value
        End Set
    End Property


    Private _SupplierNo As Integer
    Public Property SupplierNo() As Integer
        Get
            Return _SupplierNo
        End Get
        Set(ByVal value As Integer)
            _SupplierNo = value
        End Set
    End Property


    Private _PoDate As String
    Public Property PoDate() As String
        Get
            Return _PoDate
        End Get
        Set(ByVal value As String)
            _PoDate = value
        End Set
    End Property

    Public Sub New()

        ' ConnString = My.Settings.McKelviSurgeryDBConnectionString
        PoNo = 0
        SupplierNo = 0
        PoDate = Nothing

    End Sub

    Public Sub New(ByVal ThePoNo As Integer, ByVal TheSupplierNo As Integer, ByVal ThePoDate As String)


        ' ConnString = My.Settings.McKelviSurgeryDBConnectionString
        PoNo = ThePoNo
        SupplierNo = TheSupplierNo
        PoDate = ThePoDate



    End Sub



End Class
