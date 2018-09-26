<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedication
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
        Dim MedicationIDLabel As System.Windows.Forms.Label
        Dim MedDescriptionLabel As System.Windows.Forms.Label
        Dim QuantityStockLabel As System.Windows.Forms.Label
        Dim MedPriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedication))
        Me.McKelviSurgDBDataSet = New McKelviSurgery.McKelviSurgDBDataSet()
        Me.TblMedicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMedicationTableAdapter = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblMedicationTableAdapter()
        Me.TableAdapterManager = New McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager()
        Me.TblMedicationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblMedicationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MedicationIDTextBox = New System.Windows.Forms.TextBox()
        Me.MedDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityStockTextBox = New System.Windows.Forms.TextBox()
        Me.MedPriceTextBox = New System.Windows.Forms.TextBox()
        MedicationIDLabel = New System.Windows.Forms.Label()
        MedDescriptionLabel = New System.Windows.Forms.Label()
        QuantityStockLabel = New System.Windows.Forms.Label()
        MedPriceLabel = New System.Windows.Forms.Label()
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMedicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMedicationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblMedicationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'MedicationIDLabel
        '
        MedicationIDLabel.AutoSize = True
        MedicationIDLabel.Location = New System.Drawing.Point(126, 80)
        MedicationIDLabel.Name = "MedicationIDLabel"
        MedicationIDLabel.Size = New System.Drawing.Size(76, 13)
        MedicationIDLabel.TabIndex = 1
        MedicationIDLabel.Text = "Medication ID:"
        '
        'MedDescriptionLabel
        '
        MedDescriptionLabel.AutoSize = True
        MedDescriptionLabel.Location = New System.Drawing.Point(126, 106)
        MedDescriptionLabel.Name = "MedDescriptionLabel"
        MedDescriptionLabel.Size = New System.Drawing.Size(87, 13)
        MedDescriptionLabel.TabIndex = 3
        MedDescriptionLabel.Text = "Med Description:"
        '
        'QuantityStockLabel
        '
        QuantityStockLabel.AutoSize = True
        QuantityStockLabel.Location = New System.Drawing.Point(126, 132)
        QuantityStockLabel.Name = "QuantityStockLabel"
        QuantityStockLabel.Size = New System.Drawing.Size(80, 13)
        QuantityStockLabel.TabIndex = 5
        QuantityStockLabel.Text = "Quantity Stock:"
        '
        'MedPriceLabel
        '
        MedPriceLabel.AutoSize = True
        MedPriceLabel.Location = New System.Drawing.Point(126, 158)
        MedPriceLabel.Name = "MedPriceLabel"
        MedPriceLabel.Size = New System.Drawing.Size(58, 13)
        MedPriceLabel.TabIndex = 7
        MedPriceLabel.Text = "Med Price:"
        '
        'McKelviSurgDBDataSet
        '
        Me.McKelviSurgDBDataSet.DataSetName = "McKelviSurgDBDataSet"
        Me.McKelviSurgDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMedicationBindingSource
        '
        Me.TblMedicationBindingSource.DataMember = "tblMedication"
        Me.TblMedicationBindingSource.DataSource = Me.McKelviSurgDBDataSet
        '
        'TblMedicationTableAdapter
        '
        Me.TblMedicationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblAppointmentTableAdapter = Nothing
        Me.TableAdapterManager.tblConsultationTableAdapter = Nothing
        Me.TableAdapterManager.tblDiseasTableAdapter = Nothing
        Me.TableAdapterManager.tblEmployeeTableAdapter = Nothing
        Me.TableAdapterManager.tblMedicationTableAdapter = Me.TblMedicationTableAdapter
        Me.TableAdapterManager.tblPatientTableAdapter = Nothing
        Me.TableAdapterManager.tblPaymentTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentLineTableAdapter = Nothing
        Me.TableAdapterManager.tblTreatmentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblMedicationBindingNavigator
        '
        Me.TblMedicationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblMedicationBindingNavigator.BindingSource = Me.TblMedicationBindingSource
        Me.TblMedicationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblMedicationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblMedicationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblMedicationBindingNavigatorSaveItem})
        Me.TblMedicationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblMedicationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblMedicationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblMedicationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblMedicationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblMedicationBindingNavigator.Name = "TblMedicationBindingNavigator"
        Me.TblMedicationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblMedicationBindingNavigator.Size = New System.Drawing.Size(572, 25)
        Me.TblMedicationBindingNavigator.TabIndex = 0
        Me.TblMedicationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblMedicationBindingNavigatorSaveItem
        '
        Me.TblMedicationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblMedicationBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblMedicationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblMedicationBindingNavigatorSaveItem.Name = "TblMedicationBindingNavigatorSaveItem"
        Me.TblMedicationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblMedicationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MedicationIDTextBox
        '
        Me.MedicationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMedicationBindingSource, "MedicationID", True))
        Me.MedicationIDTextBox.Location = New System.Drawing.Point(219, 77)
        Me.MedicationIDTextBox.Name = "MedicationIDTextBox"
        Me.MedicationIDTextBox.ReadOnly = True
        Me.MedicationIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MedicationIDTextBox.TabIndex = 2
        '
        'MedDescriptionTextBox
        '
        Me.MedDescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMedicationBindingSource, "MedDescription", True))
        Me.MedDescriptionTextBox.Location = New System.Drawing.Point(219, 103)
        Me.MedDescriptionTextBox.Name = "MedDescriptionTextBox"
        Me.MedDescriptionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MedDescriptionTextBox.TabIndex = 4
        '
        'QuantityStockTextBox
        '
        Me.QuantityStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMedicationBindingSource, "QuantityStock", True))
        Me.QuantityStockTextBox.Location = New System.Drawing.Point(219, 129)
        Me.QuantityStockTextBox.Name = "QuantityStockTextBox"
        Me.QuantityStockTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityStockTextBox.TabIndex = 6
        '
        'MedPriceTextBox
        '
        Me.MedPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMedicationBindingSource, "MedPrice", True))
        Me.MedPriceTextBox.Location = New System.Drawing.Point(219, 155)
        Me.MedPriceTextBox.Name = "MedPriceTextBox"
        Me.MedPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MedPriceTextBox.TabIndex = 8
        '
        'frmMedication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font

        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(572, 258)
        Me.Controls.Add(MedicationIDLabel)
        Me.Controls.Add(Me.MedicationIDTextBox)
        Me.Controls.Add(MedDescriptionLabel)
        Me.Controls.Add(Me.MedDescriptionTextBox)
        Me.Controls.Add(QuantityStockLabel)
        Me.Controls.Add(Me.QuantityStockTextBox)
        Me.Controls.Add(MedPriceLabel)
        Me.Controls.Add(Me.MedPriceTextBox)
        Me.Controls.Add(Me.TblMedicationBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMedication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medication Form"
        CType(Me.McKelviSurgDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMedicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMedicationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblMedicationBindingNavigator.ResumeLayout(False)
        Me.TblMedicationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents McKelviSurgDBDataSet As McKelviSurgery.McKelviSurgDBDataSet
    Friend WithEvents TblMedicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMedicationTableAdapter As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.tblMedicationTableAdapter
    Friend WithEvents TableAdapterManager As McKelviSurgery.McKelviSurgDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblMedicationBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblMedicationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MedicationIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedDescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityStockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedPriceTextBox As System.Windows.Forms.TextBox
End Class
