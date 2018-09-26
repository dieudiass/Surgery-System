Imports System.Data.SqlClient

Public Class MedicationClass


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


    Private _Description As String
    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property


    Private _Price As Integer
    Public Property Price() As Integer
        Get
            Return _Price
        End Get
        Set(ByVal value As Integer)
            _Price = value
        End Set
    End Property


    Private _ExpireDate As Date

    Public Property ExpireDate() As Date
        Get
            Return _ExpireDate
        End Get
        Set(ByVal value As Date)
            _ExpireDate = value
        End Set
    End Property


    Private _ProdDate As Date
    Public Property ProdDate() As Date
        Get
            Return _ProdDate
        End Get
        Set(ByVal value As Date)
            _ProdDate = value
        End Set
    End Property


End Class
