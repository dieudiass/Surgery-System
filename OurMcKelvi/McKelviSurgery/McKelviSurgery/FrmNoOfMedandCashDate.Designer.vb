<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNoOfMedandCashDate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.btnViewReport = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GrpStatus = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GrpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "To:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(80, 46)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(200, 20)
        Me.dtpFrom.TabIndex = 10
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(80, 98)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(200, 20)
        Me.dtpTo.TabIndex = 11
        '
        'btnViewReport
        '
        Me.btnViewReport.Location = New System.Drawing.Point(69, 151)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(127, 23)
        Me.btnViewReport.TabIndex = 12
        Me.btnViewReport.Text = "View Report"
        Me.btnViewReport.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(289, 151)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(127, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(62, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Cash"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GrpStatus
        '
        Me.GrpStatus.Controls.Add(Me.CheckBox2)
        Me.GrpStatus.Controls.Add(Me.CheckBox1)
        Me.GrpStatus.Location = New System.Drawing.Point(321, 18)
        Me.GrpStatus.Name = "GrpStatus"
        Me.GrpStatus.Size = New System.Drawing.Size(200, 100)
        Me.GrpStatus.TabIndex = 15
        Me.GrpStatus.TabStop = False
        Me.GrpStatus.Text = "Status"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(62, 60)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 15
        Me.CheckBox2.Text = "Medical Aid"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'FrmNoOfMedandCashDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(555, 207)
        Me.Controls.Add(Me.GrpStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnViewReport)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNoOfMedandCashDate"
        Me.Text = "FrmNoOfMedandCashDate"
        Me.GrpStatus.ResumeLayout(False)
        Me.GrpStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnViewReport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GrpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
