Public Class frmPatient
    Public objPatient As New PatientClass
    Public objAppoint As New frmAppointment
    Public objNewPatient As New frmPatientAdd
    Private objAppointView As New viewPatientAppointment
    Private objDoctorChoose As New frmChooseDoctor
    Private Sub frmPatient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        MainForm.AppearButtons()
        MainFormDoctor.AppearButtons()
        MainFormManager.AppearButtons()


    End Sub

    Public Sub appointment()
        'objAppointment.MdiParent = MainForm
        'objAppointment.Show()
        'Me.Hide()
    End Sub
    Public Sub clear()
        txtFirstname.Clear()
        txtSurname.Clear()
        txtIDNumber.Clear()
        cmbGender.Text = ""
        txtCity.Clear()
        cmbProvince.Text = ""
        txtStreet.Clear()
        txtZipCode.Clear()
        cmbMaritalStatus.Text = ""
        txtPhoneNumber.Clear()
        dptDOB.Value = Today
        txtSearchPatient.Clear()
        txtPatientID.Clear()
        txtIDNumber.Focus()
    End Sub


    Private Sub frmPatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainForm.hideButtons()
        MainFormDoctor.hideButtons()
        MainFormManager.hideButtons()

        btnFind.Enabled = False
        btnNextStep.Enabled = False
        txtSearchPatient.Focus()
    End Sub

    Private Sub txtSearchPatient_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchPatient.KeyPress
        If rdoByIDNumber.Checked Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        ElseIf rdoByPhoneNumber.Checked Then
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

   

    Private Sub txtSearchPatient_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchPatient.TextChanged
        If rdoByIDNumber.Checked Then
            txtSearchPatient.MaxLength = 13
            If txtSearchPatient.TextLength < 13 Then
                lblSearchError.Text = "Please a valid South African ID with 13 digits"
                btnFind.Enabled = False
                btnNextStep.Enabled = False
            ElseIf txtSearchPatient.Text = "" Then
                lblSearchError.Text = "Please provide a South African ID"
                btnFind.Enabled = False
                btnNextStep.Enabled = False
            Else
                lblSearchError.Text = ""
                btnFind.Enabled = True
            End If
        ElseIf rdoByPassportNo.Checked Then
            txtSearchPatient.MaxLength = 20
            If txtSearchPatient.Text = "" Then
                lblSearchError.Text = "Please provide a passport number"
                btnFind.Enabled = False
                btnNextStep.Enabled = False
            Else
                lblSearchError.Text = ""
                btnFind.Enabled = True
            End If

        ElseIf rdoByPhoneNumber.Checked Then
            txtSearchPatient.MaxLength = 10
            If txtSearchPatient.Text = "" Then
                lblSearchError.Text = "Please provide a phone number"
                btnFind.Enabled = False
                btnNextStep.Enabled = False
            ElseIf txtSearchPatient.TextLength < 10 Then
                lblSearchError.Text = "Please provide a valid phone number with 10 digits"
                btnFind.Enabled = False
                btnNextStep.Enabled = False
            ElseIf txtSearchPatient.Text.Substring(0, 1) <> 0 Then
                lblSearchError.Text = "Please provide a valid phone number that start with 0"
                btnFind.Enabled = False
                btnNextStep.Enabled = False
            Else
                lblSearchError.Text = ""
                btnFind.Enabled = True
            End If

        End If
    End Sub

   
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If rdoByIDNumber.Checked Then
            objPatient.ViewPatientByIDNumber(txtSearchPatient.Text)
            If (txtSearchPatient.Text.ToUpper = objPatient.IDNumber) Then
                txtPatientID.Text = objPatient.PatientID
                txtIDNumber.Text = objPatient.IDNumber
                txtFirstname.Text = objPatient.Firstname
                txtSurname.Text = objPatient.Surname
                txtCity.Text = objPatient.City
                txtPhoneNumber.Text = objPatient.PhoneNumber
                txtStreet.Text = objPatient.Street
                txtZipCode.Text = objPatient.ZipCode
                cmbGender.Text = objPatient.Gender
                cmbProvince.Text = objPatient.Province
                cmbMaritalStatus.Text = objPatient.MaritalStatus
                dptDOB.Value = objPatient.DOB
                btnNextStep.Enabled = True
                grpSearchPatient.Enabled = False
            Else
                If MessageBox.Show("Patient is not registered, Do you want to register the patient", "Patient Dr Batubenga Surgery", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    objNewPatient.MdiParent = MainForm
                    objNewPatient.Show()
                    objNewPatient.txtIDNumber.Text = txtSearchPatient.Text
                    objNewPatient.rdoNational.Checked = True
                    Me.Hide()
                Else
                    txtSearchPatient.Focus()
                End If
            End If
        ElseIf rdoByPassportNo.Checked Then
            objPatient.ViewPatientByIDNumber(txtSearchPatient.Text)
            If (txtSearchPatient.Text.ToUpper = objPatient.IDNumber) Then
                txtPatientID.Text = objPatient.PatientID
                txtIDNumber.Text = objPatient.IDNumber
                txtFirstname.Text = objPatient.Firstname
                txtSurname.Text = objPatient.Surname
                txtCity.Text = objPatient.City
                txtPhoneNumber.Text = objPatient.PhoneNumber
                txtStreet.Text = objPatient.Street
                txtZipCode.Text = objPatient.ZipCode
                cmbGender.Text = objPatient.Gender
                cmbProvince.Text = objPatient.Province
                cmbMaritalStatus.Text = objPatient.MaritalStatus
                dptDOB.Value = objPatient.DOB
                btnNextStep.Enabled = True
                grpSearchPatient.Enabled = False
            Else
                If MessageBox.Show("Patient is not registered, Do you want to register the patient", "Patient Dr Batubenga Surgery", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    objNewPatient.MdiParent = MainForm
                    objNewPatient.Show()
                    objNewPatient.txtIDNumber.Text = txtSearchPatient.Text
                    objNewPatient.rdoInternational.Checked = True
                    Me.Hide()
                Else
                    txtSearchPatient.Focus()
                End If
            End If
        
        ElseIf rdoByPhoneNumber.Checked Then
            objPatient.ViewPatientByPhoneNumber(txtSearchPatient.Text)
            If (txtSearchPatient.Text.ToUpper = objPatient.PhoneNumber) Then
                txtPatientID.Text = objPatient.PatientID
                txtIDNumber.Text = objPatient.IDNumber
                txtFirstname.Text = objPatient.Firstname
                txtSurname.Text = objPatient.Surname
                txtCity.Text = objPatient.City
                txtPhoneNumber.Text = objPatient.PhoneNumber
                txtStreet.Text = objPatient.Street
                txtZipCode.Text = objPatient.ZipCode
                cmbGender.Text = objPatient.Gender
                cmbProvince.Text = objPatient.Province
                cmbMaritalStatus.Text = objPatient.MaritalStatus
                dptDOB.Value = objPatient.DOB
                btnNextStep.Enabled = True
                grpSearchPatient.Enabled = False
            Else
                If MessageBox.Show("Patient is not registered, Do you want to register the patient", "Patient Dr Batubenga Surgery", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    objNewPatient.MdiParent = MainForm
                    objNewPatient.Show()
                    objNewPatient.txtPhoneNumber.Text = txtSearchPatient.Text
                    Me.Hide()
                Else
                    txtSearchPatient.Focus()
                End If
            End If
        End If


    End Sub

    Private Sub rdoByPhoneNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoByPhoneNumber.CheckedChanged
        lblSearchError.Text = ""
        txtSearchPatient.Clear()
        txtSearchPatient.Focus()
    End Sub

    Private Sub rdoByIDNumber_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoByIDNumber.CheckedChanged
        lblSearchError.Text = ""
        txtSearchPatient.Clear()
        txtSearchPatient.Focus()
    End Sub

    Private Sub rdoByPassportNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoByPassportNo.CheckedChanged
        lblSearchError.Text = ""
        txtSearchPatient.Clear()
        txtSearchPatient.Focus()
    End Sub

    
    Private Sub btnNextStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextStep.Click
        If Me.TblAppointmentTableAdapter1.FillByAwaitingAppointment(Me.McKelviSurgDBDataSet.tblAppointment, txtPatientID.Text) = 1 Then
            If MessageBox.Show("Patient already has an appointment,Do you want to view his/her appointment?", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MainForm.hideButtons()
                objAppointView.txtPhoneNumber.Text = txtPhoneNumber.Text
                objAppointView.TblPatientTableAdapter.FillByPhoneNumber(Me.McKelviSurgDBDataSet.tblPatient, txtPhoneNumber.Text)
                objAppointView.TblAppointmentTableAdapter.Fill(Me.McKelviSurgDBDataSet.tblAppointment)
                Me.Hide()
                objAppointView.Show()
            End If
            grpSearchPatient.Enabled = True
            txtSearchPatient.SelectAll()
            txtSearchPatient.Focus()
        Else
            If MessageBox.Show("Patient does not have an appointment, Do you want to make an appointment?", "Dr Batubenga", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MainForm.hideButtons()
                objDoctorChoose.MdiParent = MainForm
                objDoctorChoose.patientName = txtFirstname.Text & " " & txtSurname.Text
                objDoctorChoose.patientID = txtPatientID.Text
                objDoctorChoose.Show()
                Me.Hide()
            End If
            grpSearchPatient.Enabled = True
            txtSearchPatient.SelectAll()
            txtSearchPatient.Focus()
        End If

        
    End Sub

    


    Private Function TblPatientTableAdapter() As Object
        Throw New NotImplementedException
    End Function

    
End Class