Imports System.Data.SqlClient

Public Class OrderLineClass

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


    Private _SN As Integer
    Public Property SN() As Integer
        Get
            Return _SN
        End Get
        Set(ByVal value As Integer)
            _SN = value
        End Set
    End Property


    Private _QtyOrdered As Integer
    Public Property QtyOrdered() As Integer
        Get
            Return _QtyOrdered
        End Get
        Set(ByVal value As Integer)
            _QtyOrdered = value
        End Set
    End Property

    Public Sub New()

        ConnString = My.Settings.McKelviSurgDBConnectionStrin
        PoNo = 0
        SN = 0
        QtyOrdered = 0

    End Sub

    Public Sub New(ByVal ThePoNo As Integer, ByVal TheSN As Integer, ByVal TheQtyOrdered As Integer)

        ConnString = My.Settings.McKelviSurgDBConnectionStrin
        PoNo = ThePoNo
        SN = TheSN
        QtyOrdered = TheQtyOrdered

    End Sub

End Class
