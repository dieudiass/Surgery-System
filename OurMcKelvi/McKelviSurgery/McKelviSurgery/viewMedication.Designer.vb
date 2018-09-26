<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewMedication
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
        Me.tblMedicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.tblTreatmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblConsultationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblMedicationTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblMedicationTableAdapter()
        Me.tblTreatmentTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblTreatmentTableAdapter()
        Me.tblConsultationTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblConsultationTableAdapter()
        Me.tblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblPatientTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter()
        CType(Me.tblMedicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblTreatmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblConsultationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblMedicationBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.tblTreatmentBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.tblConsultationBindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.tblPatientBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "McKelviSurgery.rptMedication.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(871, 556)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblMedicationBindingSource
        '
        Me.tblMedicationBindingSource.DataMember = "tblMedication"
        Me.tblMedicationBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.EnforceConstraints = False
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblTreatmentBindingSource
        '
        Me.tblTreatmentBindingSource.DataMember = "tblTreatment"
        Me.tblTreatmentBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'tblConsultationBindingSource
        '
        Me.tblConsultationBindingSource.DataMember = "tblConsultation"
        Me.tblConsultationBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'tblMedicationTableAdapter
        '
        Me.tblMedicationTableAdapter.ClearBeforeFill = True
        '
        'tblTreatmentTableAdapter
        '
        Me.tblTreatmentTableAdapter.ClearBeforeFill = True
        '
        'tblConsultationTableAdapter
        '
        Me.tblConsultationTableAdapter.ClearBeforeFill = True
        '
        'tblPatientBindingSource
        '
        Me.tblPatientBindingSource.DataMember = "tblPatient"
        Me.tblPatientBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'tblPatientTableAdapter
        '
        Me.tblPatientTableAdapter.ClearBeforeFill = True
        '
        'viewMedication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 556)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "viewMedication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Medication "
        CType(Me.tblMedicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblTreatmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblConsultationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblMedicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents tblTreatmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblConsultationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblMedicationTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblMedicationTableAdapter
    Friend WithEvents tblTreatmentTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblTreatmentTableAdapter
    Friend WithEvents tblConsultationTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblConsultationTableAdapter
    Friend WithEvents tblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tblPatientTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblPatientTableAdapter
End Class
