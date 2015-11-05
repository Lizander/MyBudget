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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchDataView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(488, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(464, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Categoria:"
        '
        'SearchDataView
        '
        Me.SearchDataView.AllowUserToAddRows = False
        Me.SearchDataView.AllowUserToDeleteRows = False
        Me.SearchDataView.AllowUserToResizeColumns = False
        Me.SearchDataView.AllowUserToResizeRows = False
        Me.SearchDataView.AutoGenerateColumns = False
        Me.SearchDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.SearchDataView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.SearchDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.SearchDataView.DataSource = Me.ProductBindingSource1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SearchDataView.DefaultCellStyle = DataGridViewCellStyle1
        Me.SearchDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SearchDataView.EnableHeadersVisualStyles = False
        Me.SearchDataView.Location = New System.Drawing.Point(12, 12)
        Me.SearchDataView.MultiSelect = False
        Me.SearchDataView.Name = "SearchDataView"
        Me.SearchDataView.ReadOnly = True
        Me.SearchDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SearchDataView.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SearchDataView.RowHeadersVisible = False
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
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.ExitButton.BackColor = System.Drawing.Color.LightYellow
        Me.ExitButton.Location = New System.Drawing.Point(12, 336)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(401, 45)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Back"
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
        Me.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Items.AddRange(New Object() {"Service", "Product"})
        Me.TypeBox.Location = New System.Drawing.Point(525, 66)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(121, 21)
        Me.TypeBox.TabIndex = 6
        '
        'CategoryBox
        '
        Me.CategoryBox.DataSource = Me.CategoryBindingSource
        Me.CategoryBox.DisplayMember = "Name"
        Me.CategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryBox.FormattingEnabled = True
        Me.CategoryBox.Location = New System.Drawing.Point(525, 123)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(121, 21)
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
        Me.Clear.BackColor = System.Drawing.Color.Gainsboro
        Me.Clear.Location = New System.Drawing.Point(12, 273)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(401, 45)
        Me.Clear.TabIndex = 8
        Me.Clear.Text = "Clear Search"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'ProductSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.CategoryBox)
        Me.Controls.Add(Me.TypeBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SearchDataView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProductSearch"
        Me.Text = "Search"
        CType(Me.SearchDataView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clear As System.Windows.Forms.Button
End Class
