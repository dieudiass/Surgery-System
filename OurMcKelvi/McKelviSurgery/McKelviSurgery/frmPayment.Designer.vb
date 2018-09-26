<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AmountDueLabel As System.Windows.Forms.Label
        Dim PaymentTypeLabel As System.Windows.Forms.Label
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim AppIDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chckPatientCash = New System.Windows.Forms.CheckBox()
        Me.lblMedicalAid = New System.Windows.Forms.Label()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.TblPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.AmountDueTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentTypeTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.AppIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblPaymentTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPaymentTableAdapter()
        Me.TableAdapterManager = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager()
        Me.TblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPatientTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter()
        AmountDueLabel = New System.Windows.Forms.Label()
        PaymentTypeLabel = New System.Windows.Forms.Label()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        AppIDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.grpPayment.SuspendLayout()
        CType(Me.TblPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AmountDueLabel
        '
        AmountDueLabel.AutoSize = True
        AmountDueLabel.Location = New System.Drawing.Point(150, 51)
        AmountDueLabel.Name = "AmountDueLabel"
        AmountDueLabel.Size = New System.Drawing.Size(69, 13)
        AmountDueLabel.TabIndex = 4
        AmountDueLabel.Text = "Amount Due:"
        '
        'PaymentTypeLabel
        '
        PaymentTypeLabel.AutoSize = True
        PaymentTypeLabel.Location = New System.Drawing.Point(150, 76)
        PaymentTypeLabel.Name = "PaymentTypeLabel"
        PaymentTypeLabel.Size = New System.Drawing.Size(78, 13)
        PaymentTypeLabel.TabIndex = 8
        PaymentTypeLabel.Text = "Payment Type:"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(150, 153)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(70, 13)
        EmployeeIDLabel.TabIndex = 10
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.Location = New System.Drawing.Point(150, 179)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(93, 13)
        PatientIDLabel.TabIndex = 12
        PatientIDLabel.Text = "Employee Name : "
        '
        'AppIDLabel
        '
        AppIDLabel.AutoSize = True
        AppIDLabel.Location = New System.Drawing.Point(150, 205)
        AppIDLabel.Name = "AppIDLabel"
        AppIDLabel.Size = New System.Drawing.Size(92, 13)
        AppIDLabel.TabIndex = 14
        AppIDLabel.Text = "Apppointment  ID:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(151, 232)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(77, 13)
        Label1.TabIndex = 16
        Label1.Text = "Patient Name :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(150, 259)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(57, 13)
        Label3.TabIndex = 18
        Label3.Text = "Patient ID:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(150, 22)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(65, 13)
        Label4.TabIndex = 21
        Label4.Text = "Payment ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 26)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Payment information"
        '
        'grpPayment
        '
        Me.grpPayment.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpPayment.Controls.Add(Me.btnClose)
        Me.grpPayment.Controls.Add(Me.chckPatientCash)
        Me.grpPayment.Controls.Add(Me.lblMedicalAid)
        Me.grpPayment.Controls.Add(Label4)
        Me.grpPayment.Controls.Add(Me.txtPaymentID)
        Me.grpPayment.Controls.Add(Me.btnProceed)
        Me.grpPayment.Controls.Add(Label3)
        Me.grpPayment.Controls.Add(Me.txtEmployeeName)
        Me.grpPayment.Controls.Add(Label1)
        Me.grpPayment.Controls.Add(Me.txtPatientName)
        Me.grpPayment.Controls.Add(AmountDueLabel)
        Me.grpPayment.Controls.Add(Me.AmountDueTextBox)
        Me.grpPayment.Controls.Add(PaymentTypeLabel)
        Me.grpPayment.Controls.Add(Me.PaymentTypeTextBox)
        Me.grpPayment.Controls.Add(EmployeeIDLabel)
        Me.grpPayment.Controls.Add(Me.EmployeeIDTextBox)
        Me.grpPayment.Controls.Add(PatientIDLabel)
        Me.grpPayment.Controls.Add(Me.PatientIDTextBox)
        Me.grpPayment.Controls.Add(AppIDLabel)
        Me.grpPayment.Controls.Add(Me.AppIDTextBox)
        Me.grpPayment.Location = New System.Drawing.Point(50, 66)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(714, 409)
        Me.grpPayment.TabIndex = 15
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment Process"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(396, 314)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 43)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chckPatientCash
        '
        Me.chckPatientCash.AutoSize = True
        Me.chckPatientCash.Location = New System.Drawing.Point(481, 23)
        Me.chckPatientCash.Name = "chckPatientCash"
        Me.chckPatientCash.Size = New System.Drawing.Size(204, 17)
        Me.chckPatientCash.TabIndex = 24
        Me.chckPatientCash.Text = "Patient would like to pay with cash ?  "
        Me.chckPatientCash.UseVisualStyleBackColor = True
        '
        'lblMedicalAid
        '
        Me.lblMedicalAid.AutoSize = True
        Me.lblMedicalAid.ForeColor = System.Drawing.Color.Red
        Me.lblMedicalAid.Location = New System.Drawing.Point(269, 101)
        Me.lblMedicalAid.Name = "lblMedicalAid"
        Me.lblMedicalAid.Size = New System.Drawing.Size(0, 13)
        Me.lblMedicalAid.TabIndex = 23
        '
        'txtPaymentID
        '
        Me.txtPaymentID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPaymentBindingSource, "PaymentID", True))
        Me.txtPaymentID.Enabled = False
        Me.txtPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentID.Location = New System.Drawing.Point(249, 19)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.Size = New System.Drawing.Size(200, 21)
        Me.txtPaymentID.TabIndex = 22
        Me.txtPaymentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TblPaymentBindingSource
        '
        Me.TblPaymentBindingSource.DataMember = "tblPayment"
        Me.TblPaymentBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(249, 314)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(99, 43)
        Me.btnProceed.TabIndex = 20
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Enabled = False
        Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.ForeColor = System.Drawing.Color.Red
        Me.txtEmployeeName.Location = New System.Drawing.Point(249, 175)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(200, 21)
        Me.txtEmployeeName.TabIndex = 19
        Me.txtEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPatientName
        '
        Me.txtPatientName.Enabled = False
        Me.txtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.ForeColor = System.Drawing.Color.Red
        Me.txtPatientName.Location = New System.Drawing.Point(249, 227)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(200, 21)
        Me.txtPatientName.TabIndex = 17
        Me.txtPatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmountDueTextBox
        '
        Me.AmountDueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPaymentBindingSource, "AmountDue", True))
        Me.AmountDueTextBox.Enabled = False
        Me.AmountDueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountDueTextBox.ForeColor = System.Drawing.Color.Red
        Me.AmountDueTextBox.Location = New System.Drawing.Point(249, 46)
        Me.AmountDueTextBox.Name = "AmountDueTextBox"
        Me.AmountDueTextBox.Size = New System.Drawing.Size(200, 21)
        Me.AmountDueTextBox.TabIndex = 5
        Me.AmountDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PaymentTypeTextBox
        '
        Me.PaymentTypeTextBox.Enabled = False
        Me.PaymentTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentTypeTextBox.Location = New System.Drawing.Point(249, 73)
        Me.PaymentTypeTextBox.Name = "PaymentTypeTextBox"
        Me.PaymentTypeTextBox.Size = New System.Drawing.Size(200, 21)
        Me.PaymentTypeTextBox.TabIndex = 9
        Me.PaymentTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.Enabled = False
        Me.EmployeeIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(249, 148)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(200, 21)
        Me.EmployeeIDTextBox.TabIndex = 11
        Me.EmployeeIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPaymentBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Enabled = False
        Me.PatientIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientIDTextBox.ForeColor = System.Drawing.Color.Red
        Me.PatientIDTextBox.Location = New System.Drawing.Point(249, 254)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(200, 21)
        Me.PatientIDTextBox.TabIndex = 13
        Me.PatientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AppIDTextBox
        '
        Me.AppIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPaymentBindingSource, "AppID", True))
        Me.AppIDTextBox.Enabled = False
        Me.AppIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppIDTextBox.ForeColor = System.Drawing.Color.Red
        Me.AppIDTextBox.Location = New System.Drawing.Point(249, 200)
        Me.AppIDTextBox.Name = "AppIDTextBox"
        Me.AppIDTextBox.Size = New System.Drawing.Size(200, 21)
        Me.AppIDTextBox.TabIndex = 15
        Me.AppIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TblPaymentTableAdapter
        '
        Me.TblPaymentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAppointmentTableAdapter = Nothing
        Me.TableAdapterManager.tblConsultationTableAdapter = Nothing
        Me.TableAdapterManager.tblDiseasTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblMedicationTableAdapter = Nothing
        Me.TableAdapterManager.tblPatientTableAdapter = Nothing
        Me.TableAdapterManager.tblPaymentTableAdapter = Me.TblPaymentTableAdapter
        Me.TableAdapterManager.tblTreatmentLineTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPatientBindingSource
        '
        Me.TblPatientBindingSource.DataMember = "tblPatient"
        Me.TblPatientBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'TblPatientTableAdapter
        '
        Me.TblPatientTableAdapter.ClearBeforeFill = True
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundone
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(794, 623)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Form"
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        CType(Me.TblPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpPayment As System.Windows.Forms.GroupBox
    Friend WithEvents TblPaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPaymentTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPaymentTableAdapter
    Friend WithEvents TableAdapterManager As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AmountDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AppIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents btnProceed As System.Windows.Forms.Button
    Friend WithEvents txtPaymentID As System.Windows.Forms.TextBox
    Friend WithEvents lblMedicalAid As System.Windows.Forms.Label
    Friend WithEvents chckPatientCash As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
End Class
