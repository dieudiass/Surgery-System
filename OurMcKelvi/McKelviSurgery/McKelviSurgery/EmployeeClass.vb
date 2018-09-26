Imports System.Data.SqlClient




Public Class EmployeeClass

    Private _connString As String
    Public Property connString() As String
        Get
            Return _connString
        End Get
        Set(ByVal value As String)
            _connString = value
        End Set
    End Property


    Private _EmployeeID As Integer
    Public Property EmployeeID() As Integer
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Integer)
            _EmployeeID = value
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

    Private _attempt As String
    Public Property Attempt() As String
        Get
            Return _attempt
        End Get
        Set(ByVal value As String)
            _attempt = value
        End Set
    End Property

    Private _security As String
    Public Property Security() As String
        Get
            Return _security
        End Get
        Set(ByVal value As String)
            _security = value
        End Set
    End Property

    Private _answer As String
    Public Property Answer() As String
        Get
            Return _answer
        End Get
        Set(ByVal value As String)
            _answer = value
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

    Private _Email As String
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
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

    Private _Type As String
    Public Property Type() As String
        Get
            Return _Type
        End Get
        Set(ByVal value As String)
            _Type = value
        End Set
    End Property

    Private _Password As String
    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(ByVal value As String)
            _Password = value
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

    Public Sub New()
        connString = My.Settings.McKelviSurgDBConnectionStrin
        EmployeeID = 0
        Firstname = ""
        Surname = ""
        IDNumber = ""
        Gender = ""
        City = ""
        Province = ""
        Street = ""
        ZipCode = 0
        Email = ""
        PhoneNumber = ""
        Type = ""
        Password = ""
        DOB = ""
    End Sub
    Public Sub New(ByVal theFirstname As String, ByVal theSurname As String, ByVal theIDNumber As String, ByVal theGender As String, ByVal theCity As String, ByVal theProvince As String, ByVal theStreet As String, ByVal theZipCode As Integer, ByVal theEmail As String, ByVal thePhoneNumber As String, ByVal theType As String, ByVal thePassword As String, ByVal theDOB As String)
        connString = My.Settings.McKelviSurgDBConnectionStrin
        Firstname = theFirstname
        Surname = theSurname
        IDNumber = theIDNumber
        Gender = theGender
        City = theCity
        Province = theProvince
        Street = theStreet
        ZipCode = theZipCode
        Email = theEmail
        PhoneNumber = thePhoneNumber
        Type = theType
        Password = thePassword
        DOB = theDOB
    End Sub

    Public Sub AddEmployee(ByVal theFirstname As String, ByVal theSurname As String, ByVal theIDNumber As String, ByVal theGender As String, ByVal theCity As String, ByVal theProvince As String, ByVal theStreet As String, ByVal theZipCode As Integer, ByVal theEmail As String, ByVal thePhoneNumber As String, ByVal theType As String, ByVal thePassword As String, ByVal theDOB As String, ByVal theAnswer As String, ByVal theSecurity As String, ByVal theAttempt As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("INSERT INTO tblEmployee VALUES(@parFirstname,@parSurname,@parIDNumber,@parGender,@parCity,@parProvince,@parStreet,@parZipCode,@parEmail,@parPhoneNumber,@parType,@parPassword,@parDOB,@parAnswer,@parSecurity,@parAttempt)", myConn)

        myCommand.Parameters.Add("@parFirstname", SqlDbType.VarChar).Value = theFirstname
        myCommand.Parameters.Add("@parSurname", SqlDbType.VarChar).Value = theSurname
        myCommand.Parameters.Add("@parIDNumber", SqlDbType.VarChar).Value = theIDNumber
        myCommand.Parameters.Add("@parGender", SqlDbType.VarChar).Value = theGender
        myCommand.Parameters.Add("@parCity", SqlDbType.VarChar).Value = theCity
        myCommand.Parameters.Add("@parProvince", SqlDbType.VarChar).Value = theProvince
        myCommand.Parameters.Add("@parStreet", SqlDbType.VarChar).Value = theStreet
        myCommand.Parameters.Add("@parZipCode", SqlDbType.Int).Value = theZipCode
        myCommand.Parameters.Add("@parEmail", SqlDbType.VarChar).Value = theEmail
        myCommand.Parameters.Add("@parPhoneNumber", SqlDbType.VarChar).Value = thePhoneNumber
        myCommand.Parameters.Add("@parType", SqlDbType.VarChar).Value = theType
        myCommand.Parameters.Add("@parPassword", SqlDbType.VarChar).Value = thePassword
        myCommand.Parameters.Add("@parDOB", SqlDbType.Date).Value = theDOB
        myCommand.Parameters.Add("@parAnswer", SqlDbType.VarChar).Value = theAnswer
        myCommand.Parameters.Add("@parSecurity", SqlDbType.VarChar).Value = theSecurity
        myCommand.Parameters.Add("@parAttempt", SqlDbType.VarChar).Value = theAttempt

        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub

    Public Sub UpdateEmployee(ByVal theEmployeeID As Integer, ByVal theFirstname As String, ByVal theSurname As String, ByVal theIDNumber As String, ByVal theGender As String, ByVal theCity As String, ByVal theProvince As String, ByVal theStreet As String, ByVal theZipCode As Integer, ByVal theEmail As String, ByVal thePhoneNumber As String, ByVal theType As String, ByVal thePassword As String, ByVal theDOB As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("UPDATE tblEmployee SET Firstname = @parFirstname, Surname = @parSurname,Gender = @parGender,City = @parCity, Province = @parProvince,Street = @parStreet,ZipCode = @parZipCode,Email = @parEmail,PhoneNumber = @parPhoneNumber, Type = @parType,Password = @parPassword, DOB = @parDOB WHERE EmployeeID = @parEmployeeID", myConn)

        myCommand.Parameters.Add("@parEmployeeID", SqlDbType.Int).Value = theEmployeeID
        myCommand.Parameters.Add("@parFirstname", SqlDbType.VarChar).Value = theFirstname
        myCommand.Parameters.Add("@parSurname", SqlDbType.VarChar).Value = theSurname
        myCommand.Parameters.Add("@parIDNumber", SqlDbType.VarChar).Value = theIDNumber
        myCommand.Parameters.Add("@parGender", SqlDbType.VarChar).Value = theGender
        myCommand.Parameters.Add("@parCity", SqlDbType.VarChar).Value = theCity
        myCommand.Parameters.Add("@parProvince", SqlDbType.VarChar).Value = theProvince
        myCommand.Parameters.Add("@parStreet", SqlDbType.VarChar).Value = theStreet
        myCommand.Parameters.Add("@parZipCode", SqlDbType.Int).Value = theZipCode
        myCommand.Parameters.Add("@parEmail", SqlDbType.VarChar).Value = theEmail
        myCommand.Parameters.Add("@parPhoneNumber", SqlDbType.VarChar).Value = thePhoneNumber
        myCommand.Parameters.Add("@parType", SqlDbType.VarChar).Value = theType
        myCommand.Parameters.Add("@parPassword", SqlDbType.VarChar).Value = thePassword
        myCommand.Parameters.Add("@parDOB", SqlDbType.Date).Value = theDOB

        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub
    Public Sub DeleteEmployee(ByVal theEmployeeID As Integer)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("DELETE tblEmployee WHERE EmployeeID = @parEmployeeID", myConn)

        myCommand.Parameters.Add("@parEmployeeID", SqlDbType.Int).Value = theEmployeeID


        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub

    Public Sub ViewEmployee(ByVal theEmployeeID As Integer)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblEmployee WHERE EmployeeID = @parEmployeeID", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parEmployeeID", SqlDbType.Int).Value = theEmployeeID

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
        Email = oRow("Email")
        PhoneNumber = oRow("PhoneNumber")
        Type = oRow("Type")
        Password = oRow("Password")
        DOB = oRow("DOB")
        Answer = oRow("Answer")
        Security = oRow("Security")
        Attempt = oRow("Attempt")
    End Sub

    Public Sub selectAllEmployee()
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblEmployee", myConn)
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
        Email = oRow("Email")
        PhoneNumber = oRow("PhoneNumber")
        Type = oRow("Type")
        Password = oRow("Password")
        DOB = oRow("DOB")
        Answer = oRow("Answer")
        Security = oRow("Security")
        Attempt = oRow("Attempt")
    End Sub
    Public Sub ViewEmployeeByEmail(ByVal theEmail As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblEmployee WHERE Email= @parEmail", myConn)
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
            Email = oRow("Email")
            PhoneNumber = oRow("PhoneNumber")
            Type = oRow("Type")
            Password = oRow("Password")
            EmployeeID = oRow("EmployeeID")
            DOB = oRow("DOB")
            Answer = oRow("Answer")
            Security = oRow("Security")
            Attempt = oRow("Attempt")
        End If
    End Sub
    Public Sub ViewEmployeeByIDNumber(ByVal theID As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblEmployee WHERE IDNumber= @parIDNumber", myConn)
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
            Email = oRow("Email")
            PhoneNumber = oRow("PhoneNumber")
            Type = oRow("Type")
            Password = oRow("Password")
            EmployeeID = oRow("EmployeeID")
            DOB = oRow("DOB")
            Answer = oRow("Answer")
            Security = oRow("Security")
            Attempt = oRow("Attempt")
        End If
    End Sub
    Public Sub ViewEmployeeByEmployeeID(ByVal theEmpID As Integer)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("SELECT * FROM tblEmployee WHERE EmployeeID= @parIDNumber", myConn)
        Dim myAdapter As New SqlDataAdapter(myCommand)
        Dim myTable As New DataTable
        Dim oRow As DataRow

        myCommand.Parameters.Add("@parIDNumber", SqlDbType.Int).Value = theEmpID

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
            Email = oRow("Email")
            PhoneNumber = oRow("PhoneNumber")
            Type = oRow("Type")
            Password = oRow("Password")
            EmployeeID = oRow("EmployeeID")
            DOB = oRow("DOB")
            Answer = oRow("Answer")
            Security = oRow("Security")
            Attempt = oRow("Attempt")
        End If
    End Sub
    Public Sub UpdatePersonalEmployee(ByVal theEmployeeID As Integer, ByVal theFirstname As String, ByVal theSurname As String, ByVal theCity As String, ByVal theProvince As String, ByVal theStreet As String, ByVal theZipCode As Integer, ByVal thephoneNumber As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("UPDATE tblEmployee SET Firstname = @parFirstname, Surname = @parSurname,City = @parCity, Province = @parProvince,Street = @parStreet,ZipCode = @parZipCode, PhoneNumber = @parPhoneNumber WHERE EmployeeID = @parEmployeeID", myConn)

        myCommand.Parameters.Add("@parEmployeeID", SqlDbType.Int).Value = theEmployeeID
        myCommand.Parameters.Add("@parFirstname", SqlDbType.VarChar).Value = theFirstname
        myCommand.Parameters.Add("@parSurname", SqlDbType.VarChar).Value = theSurname
        myCommand.Parameters.Add("@parCity", SqlDbType.VarChar).Value = theCity
        myCommand.Parameters.Add("@parProvince", SqlDbType.VarChar).Value = theProvince
        myCommand.Parameters.Add("@parStreet", SqlDbType.VarChar).Value = theStreet
        myCommand.Parameters.Add("@parZipCode", SqlDbType.Int).Value = theZipCode
        myCommand.Parameters.Add("@parPhoneNumber", SqlDbType.VarChar).Value = thephoneNumber

        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub
    Public Sub UpdatePrivacyEmployee(ByVal theEmployeeID As Integer, ByVal thePassword As String, ByVal theDOB As String, ByVal theSecurity As String, ByVal theAnswer As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("UPDATE tblEmployee SET Answer = @parAnswer, Security = @parSecurity, Password = @parPassword, DOB = @parDOB WHERE EmployeeID = @parEmployeeID", myConn)

        myCommand.Parameters.Add("@parEmployeeID", SqlDbType.Int).Value = theEmployeeID
        myCommand.Parameters.Add("@parPassword", SqlDbType.VarChar).Value = thePassword
        myCommand.Parameters.Add("@parDOB", SqlDbType.Date).Value = theDOB
        myCommand.Parameters.Add("@parSecurity", SqlDbType.VarChar).Value = theSecurity
        myCommand.Parameters.Add("@parAnswer", SqlDbType.VarChar).Value = theAnswer

        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub
    Public Sub ResetPassword(ByVal theEmail As String, ByVal thePassword As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("UPDATE tblEmployee SET Password = @parPassword WHERE Email = @parEmail", myConn)

        myCommand.Parameters.Add("@parEmail", SqlDbType.VarChar).Value = theEmail
        myCommand.Parameters.Add("@parPassword", SqlDbType.VarChar).Value = thePassword


        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub
    Public Sub ResetAttempt(ByVal theEmail As String, ByVal theAttempt As String)
        Dim myConn As New SqlConnection(connString)
        Dim myCommand As New SqlCommand("UPDATE tblEmployee SET  Attempt = @parAttempt WHERE Email = @parEmail", myConn)

        myCommand.Parameters.Add("@parEmail", SqlDbType.VarChar).Value = theEmail
        myCommand.Parameters.Add("@parAttempt", SqlDbType.VarChar).Value = theAttempt


        myConn.Open()
        myCommand.ExecuteNonQuery()
        myConn.Close()

    End Sub
End Class
