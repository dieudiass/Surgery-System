Imports System.Data.SqlClient

Public Class TreatmentClass

    Private _ConnString As String
    Public Property ConnString() As String
        Get
            Return _ConnString
        End Get
        Set(ByVal value As String)
            _ConnString = value
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


    Private _TreatmentDate As String
    Public Property TreatmentDate() As String
        Get
            Return _TreatmentDate
        End Get
        Set(ByVal value As String)
            _TreatmentDate = value
        End Set
    End Property


    Private _TreatmentTime As String
    Public Property TreatmentTime() As String
        Get
            Return _TreatmentTime
        End Get
        Set(ByVal value As String)
            _TreatmentTime = value
        End Set
    End Property


    Private _Diagnosis As String
    Public Property Diagnosis() As String
        Get
            Return _Diagnosis
        End Get
        Set(ByVal value As String)
            _Diagnosis = value
        End Set
    End Property


    Private _ConsultationNo As String
    Public Property ConsultationNo() As String
        Get
            Return _ConsultationNo
        End Get
        Set(ByVal value As String)
            _ConsultationNo = value
        End Set
    End Property

    Public Sub New()


        TreatmentCode = ""
        TreatmentDate = Nothing
        TreatmentTime = Nothing
        Diagnosis = ""
        ConsultationNo = 0

    End Sub





End Class
