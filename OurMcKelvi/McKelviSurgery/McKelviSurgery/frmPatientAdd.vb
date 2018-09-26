Public Class frmPatientAdd
    Private nameError As Boolean = True
    Private surnameError As Boolean = True
    Private streetNameError As Boolean = True
    Private cityError As Boolean = True
    Private provinceError As Boolean = True
    Private postalCodeError As Boolean = True
    Private phoneNumberError As Boolean = True
    Private GenderError As Boolean = True
    Private maritalStatus As Boolean = True
    Private IDerror As Boolean = True
    Public objAppoint As New frmAppointment
    Public objPatient As New PatientClass
    Private Sub frmPatientAdd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()

    End Sub

    Private Sub frmPatientAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()

        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()


        cmbProvince.SelectedIndex = 0
        btnAppointment.Enabled = False
        btnSave.Enabled = False
        txtIDNumber.Focus()
        grpMedicalAid.Enabled = False

    End Sub

    Private Sub rdoNational_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNational.CheckedChanged
        txtIDNumber.Focus()
        dptDOB.Enabled = False
        btnSave.Enabled = False
        btnAppointment.Enabled = False
        cmbGender.Enabled = False
        'clear()
    End Sub

    Private Sub rdoInternational_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoInternational.CheckedChanged
        txtIDNumber.Focus()
        btnAppointment.Enabled = False
        dptDOB.Enabled = True
        cmbGender.Enabled = True
    End Sub
    Public Sub clear()
        txtFirstname.Clear()
        txtSurname.Clear()
        txtIDNumber.Clear()
        cmbGender.Text = ""
        ' txtCity.Clear()
        cmbProvince.Text = ""
        txtStreet.Clear()
        txtZipCode.Clear()
        cmbMaritalStatus.Text = ""
        txtPhoneNumber.Clear()
        dptDOB.Value = Today
        txtPatientID.Clear()
        txtIDNumber.Focus()
    End Sub
    Public Function validateForm() As Boolean
        Dim validateSave As Boolean = False
        If nameError = False And surnameError = False And IDerror = False And maritalStatus = False And streetNameError = False And GenderError = False And phoneNumberError = False Then
            validateSave = True
        End If
        Return validateSave
    End Function

    Private Sub txtIDNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDNumber.KeyPress
        If rdoNational.Checked Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtIDNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIDNumber.TextChanged
        Dim month As String = "Jan"
        Dim day As String
        Dim year As String

        If rdoNational.Checked Then
            'dptDOB.Enabled = False
            lblIDerror.Text = ""
            txtIDNumber.MaxLength = 13
            If txtIDNumber.TextLength < 13 Then
                lblIDerror.Text = "Please a valid South African ID with 13 digits"
                btnSave.Enabled = False
                btnAppointment.Enabled = False
                IDerror = True
            ElseIf txtIDNumber.Text = "" Then
                lblIDerror.Text = "Please provide a South African ID"
                btnSave.Enabled = False
                btnAppointment.Enabled = False
                IDerror = True
            Else
                objPatient.ViewPatientByIDNumber(txtIDNumber.Text)
                If txtIDNumber.Text = objPatient.IDNumber Then
                    lblIDerror.Text = "ID Number already been used"
                    btnSave.Enabled = False
                    btnAppointment.Enabled = False
                    IDerror = True
                Else
                    year = txtIDNumber.Text.Substring(0, 2)
                    day = txtIDNumber.Text.Substring(4, 2)
                    If day < 1 Or day > 31 Then
                        lblIDerror.Text = "Please provide a valid a ID Number with a correct day"
                        btnSave.Enabled = False
                        IDerror = True
                        Return
                    End If
                    If txtIDNumber.Text.Substring(2, 2) = "01" Then
                        month = "Jan"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "02" Then
                        month = "Feb"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "03" Then
                        month = "Mar"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "04" Then
                        month = "Apr"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "05" Then
                        month = "May"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "06" Then
                        month = "Jun"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "07" Then
                        month = "Jul"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "08" Then
                        month = "Aug"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "09" Then
                        month = "Sep"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "10" Then
                        month = "Oct"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "11" Then
                        month = "Nov"
                    ElseIf txtIDNumber.Text.Substring(2, 2) = "12" Then
                        month = "Dec"
                    Else
                        lblIDerror.Text = "Please provide a valid a ID Number with a correct month"
                        btnSave.Enabled = False
                        IDerror = True
                        Return
                    End If

                    If txtIDNumber.Text.Substring(2, 2) = "02" Then
                        If day > 28 Then
                            lblIDerror.Text = "Please provide a valid a ID Number with a correct day"
                            btnSave.Enabled = False
                            IDerror = True
                            Return
                        End If
                    End If

                    If Date.Today < CDate(day & "-" & month & "-" & year) Then
                        lblIDerror.Text = "Please provide a valid a ID Number with a correct year"
                        btnSave.Enabled = False
                        IDerror = True
                        Return
                    End If
                    If CDate(day & "-" & month & "-" & year) > Date.Today Then
                        lblIDerror.Text = "Please enter an ID Number that is correct. ID should not be greater than the current date"
                        btnSave.Enabled = False
                        IDerror = True
                        Return
                    End If
                    dptDOB.Value = CDate(day & "-" & month & "-" & year)
                    lblIDerror.Text = ""
                    If txtIDNumber.Text.Substring(6, 4) >= 0 And txtIDNumber.Text.Substring(6, 4) <= 4999 Then
                        cmbGender.SelectedIndex = 1
                    ElseIf txtIDNumber.Text.Substring(6, 4) >= 5000 And txtIDNumber.Text.Substring(6, 4) <= 9999 Then
                        cmbGender.SelectedIndex = 0
                    End If
                    IDerror = False
                    If validateForm() = True Then
                        btnSave.Enabled = True
                    End If
                    End If

            End If
        ElseIf rdoInternational.Checked Then
            lblIDerror.Text = ""
            txtIDNumber.MaxLength = 20
            If txtIDNumber.Text = "" Then
                lblIDerror.Text = "Please provide a passport number"
                btnSave.Enabled = False
                btnAppointment.Enabled = False
            Else
                objPatient.ViewPatientByIDNumber(txtIDNumber.Text)
                If txtIDNumber.Text = objPatient.IDNumber Then
                    lblIDerror.Text = "Passport number already been used"
                    btnSave.Enabled = False
                    btnAppointment.Enabled = False
                    IDerror = True
                Else
                    lblIDerror.Text = ""
                    IDerror = False
                    If validateForm() = True Then
                        btnSave.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtFirstname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstname.KeyPress
        If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFirstname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstname.TextChanged

        If (txtFirstname.Text = "") Then
            lblFirstnameError.Text = "Please provide a firstname"
            btnSave.Enabled = False
            nameError = True
        ElseIf txtFirstname.TextLength < 4 Then
            lblFirstnameError.Text = "The Firstname should have at least 4 characters"
            btnSave.Enabled = False
            nameError = True
        Else
            lblFirstnameError.Text = ""
            nameError = False
            If validateForm() = True Then
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtSurname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSurname.KeyPress
        If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False And e.KeyChar = "" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSurname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSurname.TextChanged
        If (txtSurname.Text = "") Then
            lblSurnameError.Text = "Please provide a firstname"
            btnSave.Enabled = False
            surnameError = True
        ElseIf txtSurname.TextLength < 4 Then
            lblSurnameError.Text = "The surname should have at least 4 characters"
            btnSave.Enabled = False
            surnameError = True
        Else
            lblSurnameError.Text = ""
            surnameError = False
            If validateForm() = True Then
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmbGender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGender.SelectedIndexChanged
        If (cmbGender.Text = "") Then
            lblGenderError.Text = "Please choose a gender"
            btnSave.Enabled = False
        Else
            lblGenderError.Text = ""
            GenderError = False
            If validateForm() = True Then
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub cmbMaritalStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMaritalStatus.SelectedIndexChanged
        If (cmbMaritalStatus.Text = "") Then
            lblMaritalStatusError.Text = "Please choose marital status"
            btnSave.Enabled = False
        Else
            lblMaritalStatusError.Text = ""
            maritalStatus = False
            If validateForm() = True Then
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbProvince_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProvince.SelectedIndexChanged
        cmbCity.Text = ""
            If cmbProvince.Text.ToUpper = "GAUTENG" Then
                cmbCity.Items.Clear()
                cmbCity.Items.Add("Benoni")
                cmbCity.Items.Add("Boksburg")
                cmbCity.Items.Add("Brakpan")
                cmbCity.Items.Add("Carletonville")
                cmbCity.Items.Add("Germiston")
                cmbCity.Items.Add("Johannesburg")
                cmbCity.Items.Add("Krugersdorp")
                cmbCity.Items.Add("Pretoria")
                cmbCity.Items.Add("Randburg")
                cmbCity.Items.Add("Randfontein")
                cmbCity.Items.Add("Roodepoort")
                cmbCity.Items.Add("Soweto")
                cmbCity.Items.Add("Springs")
                cmbCity.Items.Add("Vanderbijlpark")
                cmbCity.Items.Add("Vereeniging")
            ElseIf cmbProvince.Text.ToUpper = "KWAZULU-NATAL" Then
                cmbCity.Items.Clear()
                cmbCity.Items.Add("Durban")
                cmbCity.Items.Add("Empangeni")
                cmbCity.Items.Add("Ladysmith")
                cmbCity.Items.Add("Newcastle")
                cmbCity.Items.Add("Pietermaritzburg")
                cmbCity.Items.Add("Pinetown")
                cmbCity.Items.Add("Ulundi")
                cmbCity.Items.Add("Umlazi")

            ElseIf cmbProvince.Text.ToUpper = "LIMPOPO" Then
                cmbCity.Items.Clear()
                cmbCity.Items.Add("Giyani")
                cmbCity.Items.Add("Lebowakgomo")
                cmbCity.Items.Add("Musina")
                cmbCity.Items.Add("Phalaborwa")
                cmbCity.Items.Add("Polokwane")
                cmbCity.Items.Add("Seshego")
                cmbCity.Items.Add("Sibasa")
                cmbCity.Items.Add("Thabazimbi")

            ElseIf cmbProvince.Text.ToUpper = "MPUMALANGA" Then
                cmbCity.Items.Clear()
                cmbCity.Items.Add("Emalahleni")
                cmbCity.Items.Add("Nelspruit")
                cmbCity.Items.Add("Secunda")

            ElseIf cmbProvince.Text.ToUpper = "EASTERN CAPE" Then
                cmbCity.Items.Clear()
                cmbCity.Items.Add("Alice")
                cmbCity.Items.Add("Butterworth")
                cmbCity.Items.Add("East London")
                cmbCity.Items.Add("Graaff-Reinet")
                cmbCity.Items.Add("Grahamstown")
                cmbCity.Items.Add("King William’s Town")
                cmbCity.Items.Add("Mthatha")
                cmbCity.Items.Add("Port Elizabeth")
                cmbCity.Items.Add("Queenstown")
                cmbCity.Items.Add("Uitenhage")
                cmbCity.Items.Add("Zwelitsha")

            ElseIf cmbProvince.Text.ToUpper = "FREE STATE" Then
                cmbCity.Items.Clear()
                cmbCity.Items.Add("Bethlehem")
                cmbCity.Items.Add("Bloemfontein")
                cmbCity.Items.Add("Jagersfontein")
                cmbCity.Items.Add("Kroonstad")
                cmbCity.Items.Add("Odendaalsrus")
                cmbCity.Items.Add("Parys")

            ElseIf cmbProvince.Text.ToUpper = "NORTH WEST" Then
                cmbCity.Items.Clear()
                cmbCity.Items.Add("Klerksdorp")
                cmbCity.Items.Add("Mahikeng")
                cmbCity.Items.Add("Mmabatho")
                cmbCity.Items.Add("Potchefstroom")
                cmbCity.Items.Add("Rustenburg")

            ElseIf cmbProvince.Text.ToUpper = "WESTERN CAPE" Then
                cmbCity.Items.Clear()
                cmbCity.Items.Add("Bellville")
                cmbCity.Items.Add("Cape Town")
                cmbCity.Items.Add("Constantia")
                cmbCity.Items.Add("George")
                cmbCity.Items.Add("Hopefield")
                cmbCity.Items.Add("Oudtshoorn")
                cmbCity.Items.Add("Paarl")
                cmbCity.Items.Add("Simon’s Town")
                cmbCity.Items.Add("Stellenbosch")
                cmbCity.Items.Add("Swellendam")
                cmbCity.Items.Add("Worcester")


            ElseIf cmbProvince.Text = "NORTHERN CAPE" Then
                cmbCity.Items.Clear()
                cmbCity.Items.Add("Kimberley")
                cmbCity.Items.Add("Kuruman")
                cmbCity.Items.Add("Port Nolloth")
                cmbCity.Items.Add("West")
                cmbCity.Items.Add("Phuthaditjhaba")
                cmbCity.Items.Add("Sasolburg")
                cmbCity.Items.Add("Virginia")
                cmbCity.Items.Add("Welkom")


        End If

        cmbCity.SelectedIndex = 0
            lblProvinceError.Text = ""
            provinceError = False
            If validateForm() = True Then
                btnSave.Enabled = True
            End If

    End Sub

   

    Private Sub txtStreet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStreet.TextChanged
        If (txtStreet.Text = "") Then
            lblStreetError.Text = "Please provide a city"
            btnSave.Enabled = False
            streetNameError = True
        ElseIf txtStreet.TextLength < 3 Then
            lblStreetError.Text = "The city should have at least 3 characters"
            btnSave.Enabled = False
            streetNameError = True
        Else
            lblStreetError.Text = ""
            streetNameError = False
            If validateForm() = True Then
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtZipCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtZipCode.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtZipCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZipCode.TextChanged
        If (txtZipCode.Text = "") Then
            lblPostalCodeError.Text = "Please provide a postal code"
            btnSave.Enabled = False
            postalCodeError = True
        Else
            lblPostalCodeError.Text = ""
            postalCodeError = False
            If validateForm() = True Then
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtPhoneNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPhoneNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhoneNumber.TextChanged
        If (txtPhoneNumber.Text = "") Then
            lblPhoneNumberError.Text = "Please provide a phone number"
            btnSave.Enabled = False
            phoneNumberError = True
        ElseIf txtPhoneNumber.TextLength < 10 Then
            lblPhoneNumberError.Text = "Please provide a valid phone number with 10 digits"
            btnSave.Enabled = False
            phoneNumberError = True
        ElseIf txtPhoneNumber.Text.Substring(0, 1) <> 0 Then
            lblPhoneNumberError.Text = "Please provide a valid phone number that start with 0"
            btnSave.Enabled = False
            btnAppointment.Enabled = False

        Else
            objPatient.ViewPatientByPhoneNumber(txtPhoneNumber.Text)
            If txtPhoneNumber.Text = objPatient.PhoneNumber Then
                lblPhoneNumberError.Text = "The phone number is already used"
                btnSave.Enabled = False
                phoneNumberError = True
            Else
                lblPhoneNumberError.Text = ""
                phoneNumberError = False
                If validateForm() = True Then
                    btnSave.Enabled = True
                End If
            End If

        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        objPatient.AddPatient(txtFirstname.Text.ToUpper, txtSurname.Text.ToUpper, txtIDNumber.Text.ToUpper, cmbGender.Text.ToUpper, cmbCity.Text.ToUpper, dptDOB.Value, cmbProvince.Text.ToUpper, txtStreet.Text.ToUpper, txtZipCode.Text, cmbMaritalStatus.Text, txtPhoneNumber.Text, txtMedicalAidNo.Text, cmbMedicalNames.Text, txxMedicalAidOptions.Text, txtMedicalAidDepend.Text)

        MessageBox.Show(txtFirstname.Text & " " & txtSurname.Text & " was successfully registered", "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)


        btnSave.Enabled = False
        objPatient.ViewPatientByIDNumber(txtIDNumber.Text)
        MessageBox.Show("Patient number is " & objPatient.PatientID, "Dr Batubenga", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtPatientID.Text = objPatient.PatientID
        txtFirstname.ReadOnly = True
        txtSurname.ReadOnly = True
        cmbGender.Enabled = False
        txtIDNumber.ReadOnly = True
        dptDOB.Enabled = False
        ' txtCity.ReadOnly = True
        cmbProvince.Enabled = True
        txtStreet.ReadOnly = True
        txtZipCode.ReadOnly = True
        cmbMaritalStatus.Enabled = True
        btnAppointment.Enabled = True
        grpID.Enabled = False
        txtPhoneNumber.ReadOnly = True
        cmbGender.Enabled = False
        cmbMaritalStatus.Enabled = False
        grpMedicalAid.Enabled = False
        chkMedicalAid.Enabled = False
    End Sub

    Private Sub btnAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppointment.Click

        objAppoint.txtPatientName.Text = txtFirstname.Text & " " & txtSurname.Text
        objAppoint.PatientIDTextBox.Text = txtPatientID.Text
        objAppoint.Show()
        Me.Hide()
    End Sub

    
    Private Sub cmbCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCity.SelectedIndexChanged
        txtZipCode.Clear()
        If cmbCity.Text = "Johannesburg" Then
            txtZipCode.Text = 2192
        ElseIf cmbCity.Text = "Emalahleni" Then
            txtZipCode.Text = 1049

        ElseIf cmbCity.Text = "Nelspruit" Then
            txtZipCode.Text = 1220

        ElseIf cmbCity.Text = "Secunda" Then
            txtZipCode.Text = 2301

        ElseIf cmbCity.Text = "Klerksdorp" Then
            txtZipCode.Text = 2571

        ElseIf cmbCity.Text = "Mahikeng" Then
            txtZipCode.Text = 2745

        ElseIf cmbCity.Text = "Mmabatho" Then
            txtZipCode.Text = 2735

        ElseIf cmbCity.Text = "Potchefstroom" Then
            txtZipCode.Text = 2531

        ElseIf cmbCity.Text = "Rustenburg" Then
            txtZipCode.Text = 299

        ElseIf cmbCity.Text = "Bethlehem" Then
            txtZipCode.Text = 9702

        ElseIf cmbCity.Text = "Bloemfontein" Then
            txtZipCode.Text = 9301
        ElseIf cmbCity.Text = "Jagersfontein" Then
            txtZipCode.Text = 9974

        ElseIf cmbCity.Text = "Kroonstad" Then
            txtZipCode.Text = 9499
        ElseIf cmbCity.Text = "Benoni" Then
            txtZipCode.Text = 1501
        ElseIf cmbCity.Text = "Boksburg" Then
            txtZipCode.Text = 1459
        ElseIf cmbCity.Text = "Brakpan" Then
            txtZipCode.Text = 1541
        ElseIf cmbCity.Text = "Carletonville" Then
            txtZipCode.Text = 2499
        ElseIf cmbCity.Text = "Germiston" Then
            txtZipCode.Text = 1401
        ElseIf cmbCity.Text = "Alberton" Then
            txtZipCode.Text = 1449
        ElseIf cmbCity.Text = "Krugersdorp" Then
            txtZipCode.Text = 1739
        ElseIf cmbCity.Text = "Pretoria" Then
            txtZipCode.Text = 181
        ElseIf cmbCity.Text = "Randburg" Then
            txtZipCode.Text = 2158
        ElseIf cmbCity.Text = "Randfontein" Then
            txtZipCode.Text = 7798
        ElseIf cmbCity.Text = "Roodepoort" Then
            txtZipCode.Text = 1724
        ElseIf cmbCity.Text = "Soweto" Then
            txtZipCode.Text = 4309
        ElseIf cmbCity.Text = "Springs" Then
            txtZipCode.Text = 1914
        ElseIf cmbCity.Text = "Vanderbijlpark" Then
            txtZipCode.Text = 1911
        ElseIf cmbCity.Text = "Vereeniging" Then
            txtZipCode.Text = 1929
        ElseIf cmbCity.Text = "Durban" Then
            txtZipCode.Text = 4091
        ElseIf cmbCity.Text = "Empangeni Then" Then
            txtZipCode.Text = 3880
        ElseIf cmbCity.Text = "Ladysmith" Then
            txtZipCode.Text = 2300
        ElseIf cmbCity.Text = "Newcastle" Then
            txtZipCode.Text = 2940
        ElseIf cmbCity.Text = "Pietermaritzburg" Then
            txtZipCode.Text = 2390
        ElseIf cmbCity.Text = "Pinetown" Then
            txtZipCode.Text = 3610
        ElseIf cmbCity.Text = "Ulundi" Then
            txtZipCode.Text = 3838
        ElseIf cmbCity.Text = "Umlazi" Then
            txtZipCode.Text = 4031
        ElseIf cmbCity.Text = "Kimberley" Then
            txtZipCode.Text = 8301
        ElseIf cmbCity.Text = "Kuruman" Then
            txtZipCode.Text = 8462
        ElseIf cmbCity.Text = "Port Nolloth" Then
            txtZipCode.Text = 2110
        ElseIf cmbCity.Text = "West" Then
        ElseIf cmbCity.Text = "Phuthaditjhaba" Then
            txtZipCode.Text = 9868
        ElseIf cmbCity.Text = "Sasolburg" Then
            txtZipCode.Text = 1947
        ElseIf cmbCity.Text = "Virginia" Then
            txtZipCode.Text = 9423
        ElseIf cmbCity.Text = "Bellville" Then
            txtZipCode.Text = 7530
        ElseIf cmbCity.Text = "Cape Town" Then
            txtZipCode.Text = 8001
        ElseIf cmbCity.Text = "Constantia" Then
            txtZipCode.Text = 7806
        ElseIf cmbCity.Text = "George" Then
            txtZipCode.Text = 6544
        ElseIf cmbCity.Text = "Hopefield" Then
            txtZipCode.Text = 7355
        ElseIf cmbCity.Text = "Oudtshoorn" Then
            txtZipCode.Text = 6625
        ElseIf cmbCity.Text = "Paarl" Then
            txtZipCode.Text = 7646
        ElseIf cmbCity.Text = "Simon’s Town" Then
            txtZipCode.Text = 1212
        ElseIf cmbCity.Text = "Stellenbosch" Then
            txtZipCode.Text = 7600
        ElseIf cmbCity.Text = "Swellendam" Then
            txtZipCode.Text = 6740
        ElseIf cmbCity.Text = "Worcester" Then
            txtZipCode.Text = 6845
        ElseIf cmbCity.Text = "Odendaalsrus" Then
            txtZipCode.Text = 2300
        ElseIf cmbCity.Text = "Parys" Then
            txtZipCode.Text = 9585
        ElseIf cmbCity.Text = "Alice" Then
            txtZipCode.Text = 2090
        ElseIf cmbCity.Text = "Butterworth" Then
            txtZipCode.Text = 4960
        ElseIf cmbCity.Text = "East London" Then
            txtZipCode.Text = 5209
        ElseIf cmbCity.Text = "Graaff-Reinet" Then
            txtZipCode.Text = 6281
        ElseIf cmbCity.Text = "Grahamstown" Then
            txtZipCode.Text = 6139
        ElseIf cmbCity.Text = "King William’s Town" Then
            txtZipCode.Text = 5601
        ElseIf cmbCity.Text = "Mthatha" Then
            txtZipCode.Text = 5100
        ElseIf cmbCity.Text = "Port Elizabeth" Then
            txtZipCode.Text = 6100
        ElseIf cmbCity.Text = "Queenstown" Then
            txtZipCode.Text = 5319
        ElseIf cmbCity.Text = "Uitenhage" Then
            txtZipCode.Text = 6229
        ElseIf cmbCity.Text = "Zwelitsha" Then
            txtZipCode.Text = 6105
        ElseIf cmbCity.Text = "Welkom" Then
            txtZipCode.Text = 9459
        ElseIf cmbCity.Text = "Giyani" Then
            txtZipCode.Text = 985
        ElseIf cmbCity.Text = "Lebowakgomo" Then
            txtZipCode.Text = 737
        ElseIf cmbCity.Text = "Musina" Then
            txtZipCode.Text = 900
        ElseIf cmbCity.Text = "Phalaborwa" Then
            txtZipCode.Text = 1390
        ElseIf cmbCity.Text = "Polokwane" Then
            txtZipCode.Text = 799
        ElseIf cmbCity.Text = "Seshego" Then
            txtZipCode.Text = 751
        ElseIf cmbCity.Text = "Sibasa" Then
            txtZipCode.Text = 955
        ElseIf cmbCity.Text = "Thabazimbi" Then
            txtZipCode.Text = 362


        End If


    End Sub


    Private Sub chkMedicalAid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMedicalAid.CheckedChanged
        If chkMedicalAid.Checked Then
            grpMedicalAid.Enabled = True
            txtMedicalAidNo.Focus()
        Else
            grpMedicalAid.Enabled = False
        End If
    End Sub
End Class