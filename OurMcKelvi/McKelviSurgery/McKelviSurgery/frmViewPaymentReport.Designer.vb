<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewPaymentReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblAppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.tblPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblAppointmentTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter()
        Me.tblPaymentTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPaymentTableAdapter()
        Me.tblPatientTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter()
        Me.tblEmployeeTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblEmployeeTableAdapter()
        CType(Me.tblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblAppointmentBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.tblPaymentBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.tblPatientBindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.tblEmployeeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "McKelviSurgery.rptPayment.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(893, 539)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblAppointmentBindingSource
        '
        Me.tblAppointmentBindingSource.DataMember = "tblAppointment"
        Me.tblAppointmentBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblPaymentBindingSource
        '
        Me.tblPaymentBindingSource.DataMember = "tblPayment"
        Me.tblPaymentBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'tblPatientBindingSource
        '
        Me.tblPatientBindingSource.DataMember = "tblPatient"
        Me.tblPatientBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'tblEmployeeBindingSource
        '
        Me.tblEmployeeBindingSource.DataMember = "tblEmployee"
        Me.tblEmployeeBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'tblAppointmentTableAdapter
        '
        Me.tblAppointmentTableAdapter.ClearBeforeFill = True
        '
        'tblPaymentTableAdapter
        '
        Me.tblPaymentTableAdapter.ClearBeforeFill = True
        '
        'tblPatientTableAdapter
        '
        Me.tblPatientTableAdapter.ClearBeforeFill = True
        '
        'tblEmployeeTableAdapter
        '
        Me.tblEmployeeTableAdapter.ClearBeforeFill = True
        '
        'frmViewPaymentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 539)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmViewPaymentReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Payment  Report"
        CType(Me.tblAppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblAppointmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents tblPaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblAppointmentTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblAppointmentTableAdapter
    Friend WithEvents tblPaymentTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPaymentTableAdapter
    Friend WithEvents tblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents tblEmployeeTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblEmployeeTableAdapter
End Class
