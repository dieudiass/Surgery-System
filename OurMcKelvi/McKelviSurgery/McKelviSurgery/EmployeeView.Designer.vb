<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeView
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
        Me.grpSearchPatient = New System.Windows.Forms.GroupBox()
        Me.lblSearchError = New System.Windows.Forms.Label()
        Me.rdoByPassportNo = New System.Windows.Forms.RadioButton()
        Me.rdoByIDNumber = New System.Windows.Forms.RadioButton()
        Me.rdoByEmailAddress = New System.Windows.Forms.RadioButton()
        Me.txtSearchPatient = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpSearchPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSearchPatient
        '
        Me.grpSearchPatient.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpSearchPatient.Controls.Add(Me.lblSearchError)
        Me.grpSearchPatient.Controls.Add(Me.rdoByPassportNo)
        Me.grpSearchPatient.Controls.Add(Me.rdoByIDNumber)
        Me.grpSearchPatient.Controls.Add(Me.rdoByEmailAddress)
        Me.grpSearchPatient.Controls.Add(Me.txtSearchPatient)
        Me.grpSearchPatient.Controls.Add(Me.btnFind)
        Me.grpSearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchPatient.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpSearchPatient.Location = New System.Drawing.Point(16, 24)
        Me.grpSearchPatient.Name = "grpSearchPatient"
        Me.grpSearchPatient.Size = New System.Drawing.Size(635, 126)
        Me.grpSearchPatient.TabIndex = 4
        Me.grpSearchPatient.TabStop = False
        Me.grpSearchPatient.Text = "Search Employee"
        '
        'lblSearchError
        '
        Me.lblSearchError.AutoSize = True
        Me.lblSearchError.ForeColor = System.Drawing.Color.Red
        Me.lblSearchError.Location = New System.Drawing.Point(62, 95)
        Me.lblSearchError.Name = "lblSearchError"
        Me.lblSearchError.Size = New System.Drawing.Size(0, 15)
        Me.lblSearchError.TabIndex = 5
        '
        'rdoByPassportNo
        '
        Me.rdoByPassportNo.AutoSize = True
        Me.rdoByPassportNo.Location = New System.Drawing.Point(426, 18)
        Me.rdoByPassportNo.Name = "rdoByPassportNo"
        Me.rdoByPassportNo.Size = New System.Drawing.Size(170, 19)
        Me.rdoByPassportNo.TabIndex = 4
        Me.rdoByPassportNo.Text = "Search by Passport No"
        Me.rdoByPassportNo.UseVisualStyleBackColor = True
        '
        'rdoByIDNumber
        '
        Me.rdoByIDNumber.AutoSize = True
        Me.rdoByIDNumber.Location = New System.Drawing.Point(235, 18)
        Me.rdoByIDNumber.Name = "rdoByIDNumber"
        Me.rdoByIDNumber.Size = New System.Drawing.Size(161, 19)
        Me.rdoByIDNumber.TabIndex = 3
        Me.rdoByIDNumber.Text = "Search by ID Number"
        Me.rdoByIDNumber.UseVisualStyleBackColor = True
        '
        'rdoByEmailAddress
        '
        Me.rdoByEmailAddress.AutoSize = True
        Me.rdoByEmailAddress.Checked = True
        Me.rdoByEmailAddress.Location = New System.Drawing.Point(22, 18)
        Me.rdoByEmailAddress.Name = "rdoByEmailAddress"
        Me.rdoByEmailAddress.Size = New System.Drawing.Size(184, 19)
        Me.rdoByEmailAddress.TabIndex = 2
        Me.rdoByEmailAddress.TabStop = True
        Me.rdoByEmailAddress.Text = "Search by Email address"
        Me.rdoByEmailAddress.UseVisualStyleBackColor = True
        '
        'txtSearchPatient
        '
        Me.txtSearchPatient.Location = New System.Drawing.Point(63, 71)
        Me.txtSearchPatient.Name = "txtSearchPatient"
        Me.txtSearchPatient.Size = New System.Drawing.Size(284, 21)
        Me.txtSearchPatient.TabIndex = 0
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(405, 66)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(102, 30)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "Search"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnCancel.Location = New System.Drawing.Point(273, 176)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 36)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'EmployeeView
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.McKelviSurgery.My.Resources.Resources.backgroundtwo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(662, 231)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.grpSearchPatient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee View"
        Me.grpSearchPatient.ResumeLayout(False)
        Me.grpSearchPatient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSearchPatient As System.Windows.Forms.GroupBox
    Friend WithEvents lblSearchError As System.Windows.Forms.Label
    Friend WithEvents rdoByPassportNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoByIDNumber As System.Windows.Forms.RadioButton
    Friend WithEvents rdoByEmailAddress As System.Windows.Forms.RadioButton
    Friend WithEvents txtSearchPatient As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
