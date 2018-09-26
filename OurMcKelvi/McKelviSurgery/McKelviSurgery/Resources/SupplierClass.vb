Imports System.Data.SqlClient
Public Class SupplierClass

    Private _connString As String
    Public Property connString() As String
        Get
            Return _connString
        End Get
        Set(ByVal value As String)
            _connString = value
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



    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property


    Private _Location As String
    Public Property Location() As String
        Get
            Return _Location
        End Get
        Set(ByVal value As String)
            _Location = value
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


    Private _TelephoneNo As Integer
    Public Property TelephoneNo() As Integer
        Get
            Return _TelephoneNo
        End Get
        Set(ByVal value As Integer)
            _TelephoneNo = value
        End Set
    End Property



    Public Sub New()

        ' connString = My.Settings.McKelviDBConnectionString
        SupplierNo = 0
        Name = ""
        Location = ""
        TelephoneNo = 0
        SN = 0



    End Sub
    Public Sub New(ByVal theSupplierNo, ByVal theName, ByVal theLocation, ByVal theTelephoneNo, ByVal theSN)

        'connString = My.Settings.McKelviDBConnectionString
        SupplierNo = theSupplierNo
        Name = theName
        Location = theLocation
        TelephoneNo = theTelephoneNo
        SN = theSN




    End Sub







End Class
