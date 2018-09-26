Imports System.Data.SqlClient



Public Class PatientClass


    Private _connString As String
    Public Property connString() As String
        Get
            Return _connString
        End Get
        Set(ByVal value As String)
            _connString = value
        End Set
    End Property


    Private _PatientID As Integer
    Public Property PatientID() As Integer
        Get
            Return _PatientID
        End Get
        Set(ByVal value As Integer)
            _PatientID = value
        End Set
    End Property

    Private _Firstname As String
    Public Property Firstname() As String
        Get
            Return _Firstname
        End Get
        Set(ByVal value As String)
            _Firstname = value
        End Set
    End Property

    Private _Surname As String
    Public Property Surname() As String
        Get
            Return _Surname
        End Get
        Set(ByVal value As String)
            _Surname = value
        End Set
    End Property

    Private _IDNumber As String
    Public Property IDNumber() As String
        Get
            Return _IDNumber
        End Get
        Set(ByVal value As String)
            _IDNumber = value
        End Set
    End Property

    Private _Gender As String
    Public Property Gender() As String
        Get
            Return _Gender
        End Get
        Set(ByVal value As String)
            _Gender = value
        End Set
    End Property

    Private _City As String
    Public Property City() As String
        Get
            Return _City
        End Get
        Set(ByVal value As String)
            _City = value
        End Set
    End Property

    Private _Province As String
    Public Property Province() As String
        Get
            Return _Province
        End Get
        Set(ByVal value As String)
            _Province = value
        End Set
    End Property
    Private _DOB As String
    Public Property DOB() As String
        Get
            Return _DOB
        End Get
        Set(ByVal value As String)
            _DOB = value
        End Set
    End Property


    Private _Street As String
    Public Property Street() As String
        Get
            Return _Street
        End Get
        Set(ByVal value As String)
            _Street = value
        End Set
    End Property

    Private _ZipCode As String
    Public Property ZipCode() As String
        Get
            Return _ZipCode
        End Get
        Set(ByVal value As String)
            _ZipCode = value
        End Set
    End Property

    Private _MaritalStatus As String
    Public Property MaritalStatus() As String
        Get
            Return _MaritalStatus
        End Get
        Set(ByVal value As String)
            _MaritalStatus = value
        End Set
    End Property

    Private _PhoneNumber As String
    Public Property PhoneNumber() As String
        Get
            Return _PhoneNumber
        End Get
        Set(ByVal value As String)
            _PhoneNumber = value
        End Set
    End Property


    Private _MedicalAidNumber As String
    Public Property MedicalAidNumber() As String
        Get
            Return _MedicalAidNumber
        End Get
        Set(ByVal value As String)
            _MedicalAidNumber = value
        End Set
    End Property


    Private _MedicalAidName As String
    Public Property MedicalAidName() As String
        Get
            Return _MedicalAidName
        End Get
        Set(ByVal value As String)
            _MedicalAidName = value
        End Set
    End Property

    Private _medicalAidOptions As String
    Public Property MedicalAidOptions() As String
        Get
            Return _medicalAidOptions
        End Get
        Set(ByVal value As String)
            _medicalAidOptions = value
        End Set
    End Property


    Private _medicalAidDepend As String
    Public Property MedicalAidDepend() As String
        Get
            Return _medicalAidDepend
        End Get
        Set(ByVal value As String)
            _medicalAidDepend = value
        End Set
    End Property


    Public Sub New()
        connString = My.Settings.McKelviSurgDBConnectionStrin
        PatientID = 0
        Firstname = ""
        Surname = ""
        IDNumber = ""
        Gender = ""
        City = ""
        Province = ""
        Street = ""
        ZipCode = 0
        MaritalStatus = ""
        PhoneNumber = ""
        MedicalAidName = ""
        MedicalAidNumber = ""

    End Sub
    Public Sub New(ByVal theFirstname As String, ByVal theSurname As String, ByVal theIDNumber As String, ByVal theGender As String, ByVal theDOB As String, ByVal theCity As String, ByVal theProvince As String, ByVal theStreet As String, ByVal theZipCode As Integer, ByVal theMaritalStatus As String, ByVal thePhoneNumber As String, ByVal theType As String, ByVal thePassword As String, ByVal theMedicalAidNumber As String, ByVal theMedicalAidName As String)
        connString = My.Settings.McKelviSurgDBConnectionStrin
        Firstname = theFirstname
        Surname = theSurname
        IDNumber = theIDNumber
        Gender = theGender
        City = theCity
        Province = theProvince
        Street = theStreet
        ZipCode = theZipCode
        MaritalStatus = theMaritalStatus
        PhoneNumber = thePhoneNumber
        DOB = theDOB
        MedicalAidName = theMedicalAidName
        MedicalAidNumber = theMedicalAidNumber

    End Sub

    Public Sub AddPatient(ByVal theFirstname As String, ByVal theSurname As String, ByVal theIDNumber As String, ByVal theGender As String, ByVal theCity As String, ByVal theDOB As String, ByVal theProvince As String, ByVal theStreet As String, ByVal theZipCode As Integer, ByVal theMaritalStatus As String, ByVal thePhoneNumber As String, ByVal theMedicalAidNumber As String, ByVal theMedicalAidName As String, ByVal theMedicalAidOptions As String, ByVal theMedicalDepend As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("INSERT INTO tblPatient VALUES(@parFirstname,@parSurname,@parGender,@parIDNumber,@parDOB,@parCity,@parProvince,@parStreet,@parZipCode,@parPhoneNumber,@parMaritalStatus,@parMedicalAidNo,@parMedicalAidName,@parMedicalAidDepend,@parMedicalAidOptions)", myConn)

        myCommand.Parameters.Add("@parFirstname", SqlDbType.VarChar).Value = theFirstname
        myCommand.Parameters.Add("@parSurname", SqlDbType.VarChar).Value = theSurname
        myCommand.Parameters.Add("@parIDNumber", SqlDbType.VarChar).Value = theIDNumber
        myCommand.Parameters.Add("@parGender", SqlDbType.VarChar).Value = theGender
        myCommand.Parameters.Add("@parCity", SqlDbType.VarChar).Value = theCity
        myCommand.Parameters.Add("@parProvince", SqlDbType.VarChar).Value = theProvince
        myCommand.Parameters.Add("@parStreet", SqlDbType.VarChar).Value = theStreet
        myCommand.Parameters.Add("@parZipCode", SqlDbType.VarChar).Value = theZipCode
        myCommand.Parameters.Add("@parMaritalStatus", SqlDbType.VarChar).Value = theMaritalStatus
        myCommand.Parameters.Add("@parPhoneNumber", SqlDbType.VarChar).Value = thePhoneNumber
        myCommand.Parameters.Add("@parDOB", SqlDbType.Date).Value = theDOB
        myCommand.Parameters.Add("@parMedicalAidNo", SqlDbType.VarChar).Value = theMedicalAidNumber
        myCommand.Parameters.Add("@parMedicalAidName", SqlDbType.VarChar).Value = theMedicalAidName
        myCommand.Parameters.Add("@parMedicalAidOptions", SqlDbType.VarChar).Value = theMedicalAidOptions
        myCommand.Parameters.Add("@parMedicalAidDepend", SqlDbType.VarChar).Value = theMedicalDepend


        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub

    Public Sub UpdatePatient(ByVal thePatientID As Integer, ByVal theFirstname As String, ByVal theSurname As String, ByVal theIDNumber As String, ByVal theGender As String, ByVal theCity As String, ByVal theDOB As String, ByVal theProvince As String, ByVal theStreet As String, ByVal theZipCode As Integer, ByVal theMaritalStatus As String, ByVal thePhoneNumber As String, ByVal theMedicalAidNumber As String, ByVal theMedicalAidName As String, ByVal theMedicalAidOptions As String, ByVal theMedicalDepend As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("UPDATE tblPatient SET Firstname = @parFirstname, Surname = @parSurname,Gender = @parGender, DOB = @parDOB,City = @parCity, Province = @parProvince,Street = @parStreet,ZipCode = @parZipCode,MaritalStatus = @parMaritalStatus,PhoneNumber = @parPhoneNo, MedicalAidNumber= @parMedicalAidNo, MedicalAidName=@parMedicalAidName,MedicalAidDepend=@parMedicalAidDepend,MedicalAidOptions=@parMedicalAidOptions WHERE PatientID = @parPatientID", myConn)

        myCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = thePatientID
        myCommand.Parameters.Add("@parFirstname", SqlDbType.VarChar).Value = theFirstname
        myCommand.Parameters.Add("@parSurname", SqlDbType.VarChar).Value = theSurname
        myCommand.Parameters.Add("@parIDNumber", SqlDbType.VarChar).Value = theIDNumber
        myCommand.Parameters.Add("@parGender", SqlDbType.VarChar).Value = theGender
        myCommand.Parameters.Add("@parCity", SqlDbType.VarChar).Value = theCity
        myCommand.Parameters.Add("@parProvince", SqlDbType.VarChar).Value = theProvince
        myCommand.Parameters.Add("@parStreet", SqlDbType.VarChar).Value = theStreet
        myCommand.Parameters.Add("@parZipCode", SqlDbType.Int).Value = theZipCode
        myCommand.Parameters.Add("@parMaritalStatus", SqlDbType.VarChar).Value = theMaritalStatus
        myCommand.Parameters.Add("@parPhoneNumber", SqlDbType.VarChar).Value = thePhoneNumber
        myCommand.Parameters.Add("@parDOB", SqlDbType.Date).Value = theDOB
        myCommand.Parameters.Add("@parMedicalAidNo", SqlDbType.VarChar).Value = theMedicalAidNumber
        myCommand.Parameters.Add("@parMedicalAidName", SqlDbType.VarChar).Value = theMedicalAidName
        myCommand.Parameters.Add("@parMedicalAidOptions", SqlDbType.VarChar).Value = theMedicalAidOptions
        myCommand.Parameters.Add("@parMedicalAidDepend", SqlDbType.VarChar).Value = theMedicalDepend



        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub
    Public Sub DeletePatient(ByVal thePatientID As Integer)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("DELETE tblPatient WHERE PatientID = @parPatientID", myConn)

        myCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = thePatientID


        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub

    Public Sub ViewPatient(ByVal thePatientID As Integer)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblPatient WHERE PatientID = @parPatientID", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parPatientID", SqlDbType.Int).Value = thePatientID

        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()

        oRow = myTable.Rows(0)

        Firstname = oRow("Firstname")
        Surname = oRow("Surname")
        IDNumber = oRow("IDNumber")
        Gender = oRow("Gender")
        City = oRow("City")
        Province = oRow("Province")
        Street = oRow("Street")
        ZipCode = oRow("ZipCode")
        MaritalStatus = oRow("MaritalStatus")
        PhoneNumber = oRow("PhoneNumber")
        DOB = oRow("DOB")
        MedicalAidNumber = oRow("MedicalAidNo")
        MedicalAidName = oRow("MedicalAidName")
        MedicalAidDepend = oRow("MedicalAidDepend")
        MedicalAidOptions = oRow("MedicalAidOptions")
    End Sub

    Public Sub selectAllPatient()
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblPatient", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()

        oRow = myTable.Rows(0)

        Firstname = oRow("Firstname")
        Surname = oRow("Surname")
        IDNumber = oRow("IDNumber")
        Gender = oRow("Gender")
        City = oRow("City")
        Province = oRow("Province")
        Street = oRow("Street")
        ZipCode = oRow("ZipCode")
        MaritalStatus = oRow("MaritalStatus")
        PhoneNumber = oRow("PhoneNumber")
        DOB = oRow("DOB")
        MedicalAidNumber = oRow("MedicalAidNo")
        MedicalAidName = oRow("MedicalAidName")
        MedicalAidDepend = oRow("MedicalAidDepend")
        MedicalAidOptions = oRow("MedicalAidOptions")

    End Sub
    Public Sub ViewPatientByEmail(ByVal theEmail As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblPatient WHERE Email= @parEmail", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parEmail", SqlDbType.VarChar).Value = theEmail

        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()


        If myTable.Rows.Count <> 0 Then

            oRow = myTable.Rows(0)
            Firstname = oRow("Firstname")
            Surname = oRow("Surname")
            IDNumber = oRow("IDNumber")
            Gender = oRow("Gender")
            City = oRow("City")
            Province = oRow("Province")
            Street = oRow("Street")
            ZipCode = oRow("ZipCode")
            MaritalStatus = oRow("MaritalStatus")
            PhoneNumber = oRow("PhoneNumber")
            DOB = oRow("DOB")
            MedicalAidNumber = oRow("MedicalAidNo")
            MedicalAidName = oRow("MedicalAidName")
            MedicalAidDepend = oRow("MedicalAidDepend")
            MedicalAidOptions = oRow("MedicalAidOptions")

        End If
    End Sub
    Public Sub ViewPatientByIDNumber(ByVal theID As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblPatient WHERE IDNumber= @parIDNumber", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parIDNumber", SqlDbType.VarChar).Value = theID

        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()


        If myTable.Rows.Count <> 0 Then

            oRow = myTable.Rows(0)
            Firstname = oRow("Firstname")
            Surname = oRow("Surname")
            IDNumber = oRow("IDNumber")
            Gender = oRow("Gender")
            City = oRow("City")
            Province = oRow("Province")
            Street = oRow("Street")
            ZipCode = oRow("ZipCode")
            MaritalStatus = oRow("MaritalStatus")
            PhoneNumber = oRow("PhoneNumber")
            DOB = oRow("DOB")
            PatientID = oRow("PatientID")
            MedicalAidNumber = oRow("MedicalAidNo")
            MedicalAidName = oRow("MedicalAidName")
            MedicalAidDepend = oRow("MedicalAidDepend")
            MedicalAidOptions = oRow("MedicalAidOptions")
        End If
    End Sub
    Public Sub ViewPatientByPhoneNumber(ByVal thePhoneNumber As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblPatient WHERE PhoneNumber= @parPhoneNumber", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parPhoneNumber", SqlDbType.VarChar).Value = thePhoneNumber

        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()


        If myTable.Rows.Count <> 0 Then

            oRow = myTable.Rows(0)
            Firstname = oRow("Firstname")
            Surname = oRow("Surname")
            IDNumber = oRow("IDNumber")
            Gender = oRow("Gender")
            City = oRow("City")
            Province = oRow("Province")
            Street = oRow("Street")
            ZipCode = oRow("ZipCode")
            MaritalStatus = oRow("MaritalStatus")
            PhoneNumber = oRow("PhoneNumber")
            DOB = oRow("DOB")
            PatientID = oRow("PatientID")
            MedicalAidNumber = oRow("MedicalAidNo")
            MedicalAidName = oRow("MedicalAidName")
            MedicalAidDepend = oRow("MedicalAidDepend")
            MedicalAidOptions = oRow("MedicalAidOptions")
        End If
    End Sub
    Public Sub ViewPatientByPatientID(ByVal thePatientID As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblPatient WHERE PatientID= @parIDNumber", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parIDNumber", SqlDbType.Int).Value = thePatientID

        myConn.Open()
        myAdapter.Fill(myTable)
        myConn.Close()


        If myTable.Rows.Count <> 0 Then

            oRow = myTable.Rows(0)
            Firstname = oRow("Firstname")
            Surname = oRow("Surname")
            IDNumber = oRow("IDNumber")
            Gender = oRow("Gender")
            City = oRow("City")
            Province = oRow("Province")
            Street = oRow("Street")
            ZipCode = oRow("ZipCode")
            MaritalStatus = oRow("MaritalStatus")
            PhoneNumber = oRow("PhoneNumber")
            DOB = oRow("DOB")
            PatientID = oRow("PatientID")
            MedicalAidNumber = oRow("MedicalAidNo")
            MedicalAidName = oRow("MedicalAidName")
            MedicalAidDepend = oRow("MedicalAidDepend")
            MedicalAidOptions = oRow("MedicalAidOptions")
        End If
    End Sub


End Class
