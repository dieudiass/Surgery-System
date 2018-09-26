<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientView
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
        Me.rdoByPhoneNumber = New System.Windows.Forms.RadioButton()
        Me.txtSearchPatient = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpSearchPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSearchPatient
        '
        Me.grpSearchPatient.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpSearchPatient.Controls.Add(Me.lblSearchError)
        Me.grpSearchPatient.Controls.Add(Me.rdoByPassportNo)
        Me.grpSearchPatient.Controls.Add(Me.rdoByIDNumber)
        Me.grpSearchPatient.Controls.Add(Me.rdoByPhoneNumber)
        Me.grpSearchPatient.Controls.Add(Me.txtSearchPatient)
        Me.grpSearchPatient.Controls.Add(Me.btnFind)
        Me.grpSearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchPatient.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.grpSearchPatient.Location = New System.Drawing.Point(22, 58)
        Me.grpSearchPatient.Name = "grpSearchPatient"
        Me.grpSearchPatient.Size = New System.Drawing.Size(621, 124)
        Me.grpSearchPatient.TabIndex = 4
        Me.grpSearchPatient.TabStop = False
        Me.grpSearchPatient.Text = "Search Patient"
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
        'rdoByPhoneNumber
        '
        Me.rdoByPhoneNumber.AutoSize = True
        Me.rdoByPhoneNumber.Checked = True
        Me.rdoByPhoneNumber.Location = New System.Drawing.Point(22, 18)
        Me.rdoByPhoneNumber.Name = "rdoByPhoneNumber"
        Me.rdoByPhoneNumber.Size = New System.Drawing.Size(188, 19)
        Me.rdoByPhoneNumber.TabIndex = 2
        Me.rdoByPhoneNumber.TabStop = True
        Me.rdoByPhoneNumber.Text = "Search by Phone Number"
        Me.rdoByPhoneNumber.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(253, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search Patient"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnClose.Location = New System.Drawing.Point(246, 205)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(123, 33)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PatientView
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 264)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpSearchPatient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PatientView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PatientView"
        Me.grpSearchPatient.ResumeLayout(False)
        Me.grpSearchPatient.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSearchPatient As System.Windows.Forms.GroupBox
    Friend WithEvents lblSearchError As System.Windows.Forms.Label
    Friend WithEvents rdoByPassportNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoByIDNumber As System.Windows.Forms.RadioButton
    Friend WithEvents rdoByPhoneNumber As System.Windows.Forms.RadioButton
    Friend WithEvents txtSearchPatient As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
