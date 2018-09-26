<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeePrivacy
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
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.cmbSecurity = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpDOB
        '
        Me.dtpDOB.Location = New System.Drawing.Point(456, 106)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 20)
        Me.dtpDOB.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(364, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 19)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "DOB"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(200, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 19)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Employee ID"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(329, 258)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(200, 20)
        Me.txtEmployeeID.TabIndex = 64
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(456, 67)
        Me.txtType.Name = "txtType"
        Me.txtType.ReadOnly = True
        Me.txtType.Size = New System.Drawing.Size(116, 20)
        Me.txtType.TabIndex = 62
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(255, 315)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(137, 42)
        Me.btnSave.TabIndex = 61
        Me.btnSave.Text = "Save Information"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(364, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 19)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 19)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(122, 69)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 55
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(6, 110)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(69, 19)
        Me.Password.TabIndex = 57
        Me.Password.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(122, 110)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(200, 20)
        Me.txtPassword.TabIndex = 58
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(127, 141)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Answer"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(130, 201)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(200, 20)
        Me.txtAnswer.TabIndex = 69
        '
        'cmbSecurity
        '
        Me.cmbSecurity.FormattingEnabled = True
        Me.cmbSecurity.Items.AddRange(New Object() {"What is the name of your town?", "Who is your idol?", "What is your dream country?", "What is your favourite color?", "What is middle name of your mother"})
        Me.cmbSecurity.Location = New System.Drawing.Point(130, 157)
        Me.cmbSecurity.Name = "cmbSecurity"
        Me.cmbSecurity.Size = New System.Drawing.Size(200, 21)
        Me.cmbSecurity.TabIndex = 71
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 158)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 17)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Security question"
        '
        'frmEmployeePrivacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundtwo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(719, 415)
        Me.Controls.Add(Me.cmbSecurity)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.txtPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEmployeePrivacy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Privacy  Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents cmbSecurity As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
