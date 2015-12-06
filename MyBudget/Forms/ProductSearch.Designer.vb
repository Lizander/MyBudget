<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductSearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductSearch))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchDataView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManageItems = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToBudgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyBudgetDataSet = New MyBudget.myBudgetDataSet()
        Me.MyBudgetDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New MyBudget.myBudgetDataSetTableAdapters.TableAdapterManager()
        Me.ProductTableAdapter = New MyBudget.myBudgetDataSetTableAdapters.ProductTableAdapter()
        Me.TypeBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesSet = New MyBudget.CategoriesSet()
        Me.CategoryTableAdapter = New MyBudget.CategoriesSetTableAdapters.CategoryTableAdapter()
        Me.Clear = New System.Windows.Forms.Button()
        CType(Me.SearchDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ManageItems.SuspendLayout()
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyBudgetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyBudgetDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(524, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(524, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Category:"
        '
        'SearchDataView
        '
        Me.SearchDataView.AllowUserToAddRows = False
        Me.SearchDataView.AllowUserToDeleteRows = False
        Me.SearchDataView.AllowUserToResizeColumns = False
        Me.SearchDataView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.SearchDataView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SearchDataView.AutoGenerateColumns = False
        Me.SearchDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.SearchDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SearchDataView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SearchDataView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.SearchDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SearchDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SearchDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.SearchDataView.ContextMenuStrip = Me.ManageItems
        Me.SearchDataView.DataSource = Me.ProductBindingSource1
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SearchDataView.DefaultCellStyle = DataGridViewCellStyle4
        Me.SearchDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SearchDataView.EnableHeadersVisualStyles = False
        Me.SearchDataView.Location = New System.Drawing.Point(12, 12)
        Me.SearchDataView.MultiSelect = False
        Me.SearchDataView.Name = "SearchDataView"
        Me.SearchDataView.ReadOnly = True
        Me.SearchDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SearchDataView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.SearchDataView.RowHeadersVisible = False
        Me.SearchDataView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDataView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SearchDataView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.SearchDataView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.SearchDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.SearchDataView.Size = New System.Drawing.Size(401, 237)
        Me.SearchDataView.TabIndex = 4
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 93
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 82
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDataGridViewTextBoxColumn.Width = 80
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryDataGridViewTextBoxColumn.Width = 120
        '
        'ManageItems
        '
        Me.ManageItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToBudgetToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ManageItems.Name = "ManageItems"
        Me.ManageItems.Size = New System.Drawing.Size(153, 92)
        '
        'AddToBudgetToolStripMenuItem
        '
        Me.AddToBudgetToolStripMenuItem.Name = "AddToBudgetToolStripMenuItem"
        Me.AddToBudgetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToBudgetToolStripMenuItem.Text = "Add to Budget"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ProductBindingSource1
        '
        Me.ProductBindingSource1.DataMember = "Product"
        Me.ProductBindingSource1.DataSource = Me.ProductBindingSource
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = Me.MyBudgetDataSet
        Me.ProductBindingSource.Position = 0
        '
        'MyBudgetDataSet
        '
        Me.MyBudgetDataSet.DataSetName = "myBudgetDataSet"
        Me.MyBudgetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MyBudgetDataSetBindingSource
        '
        Me.MyBudgetDataSetBindingSource.DataSource = Me.MyBudgetDataSet
        Me.MyBudgetDataSetBindingSource.Position = 0
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(1178, 307)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(144, 136)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = MyBudget.myBudgetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TypeBox
        '
        Me.TypeBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TypeBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TypeBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Items.AddRange(New Object() {"Service", "Product"})
        Me.TypeBox.Location = New System.Drawing.Point(657, 82)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(121, 38)
        Me.TypeBox.TabIndex = 6
        '
        'CategoryBox
        '
        Me.CategoryBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoryBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CategoryBox.DataSource = Me.CategoryBindingSource
        Me.CategoryBox.DisplayMember = "Name"
        Me.CategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CategoryBox.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CategoryBox.FormattingEnabled = True
        Me.CategoryBox.Location = New System.Drawing.Point(657, 139)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(121, 38)
        Me.CategoryBox.TabIndex = 7
        Me.CategoryBox.ValueMember = "Name"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.CategoriesSet
        '
        'CategoriesSet
        '
        Me.CategoriesSet.DataSetName = "CategoriesSet"
        Me.CategoriesSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'Clear
        '
        Me.Clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clear.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Clear.Image = CType(resources.GetObject("Clear.Image"), System.Drawing.Image)
        Me.Clear.Location = New System.Drawing.Point(641, 195)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(152, 132)
        Me.Clear.TabIndex = 8
        Me.Clear.UseVisualStyleBackColor = False
        '
        'ProductSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1354, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.CategoryBox)
        Me.Controls.Add(Me.TypeBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SearchDataView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProductSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SearchDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ManageItems.ResumeLayout(False)
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyBudgetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyBudgetDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SearchDataView As System.Windows.Forms.DataGridView
    Friend WithEvents MyBudgetDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MyBudgetDataSet As MyBudget.myBudgetDataSet
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As MyBudget.myBudgetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductTableAdapter As MyBudget.myBudgetDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TypeBox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoryBox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoriesSet As MyBudget.CategoriesSet
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As MyBudget.CategoriesSetTableAdapters.CategoryTableAdapter
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManageItems As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToBudgetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
