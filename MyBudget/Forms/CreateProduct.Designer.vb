<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateProduct
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim TypeLabel1 As System.Windows.Forms.Label
        Dim CategoryLabel1 As System.Windows.Forms.Label
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.ProductCreation = New MyBudget.ProductCreation()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New MyBudget.ProductCreationTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New MyBudget.ProductCreationTableAdapters.TableAdapterManager()
        Me.CategoryTableAdapter = New MyBudget.ProductCreationTableAdapters.CategoryTableAdapter()
        Me.CategoriesSet = New MyBudget.CategoriesSet()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.PriceBox = New System.Windows.Forms.TextBox()
        Me.RequiredName = New System.Windows.Forms.Label()
        Me.RequiredPrice = New System.Windows.Forms.Label()
        Me.TypeBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductCreation1 = New MyBudget.ProductCreation()
        NameLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        TypeLabel1 = New System.Windows.Forms.Label()
        CategoryLabel1 = New System.Windows.Forms.Label()
        CType(Me.ProductCreation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductCreation1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.ForeColor = System.Drawing.Color.DarkGreen
        NameLabel.Location = New System.Drawing.Point(94, 59)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 11
        NameLabel.Text = "Name:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.ForeColor = System.Drawing.Color.DarkGreen
        PriceLabel.Location = New System.Drawing.Point(94, 96)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 13
        PriceLabel.Text = "Price:"
        '
        'TypeLabel1
        '
        TypeLabel1.AutoSize = True
        TypeLabel1.ForeColor = System.Drawing.Color.DarkGreen
        TypeLabel1.Location = New System.Drawing.Point(91, 140)
        TypeLabel1.Name = "TypeLabel1"
        TypeLabel1.Size = New System.Drawing.Size(34, 13)
        TypeLabel1.TabIndex = 24
        TypeLabel1.Text = "Type:"
        '
        'CategoryLabel1
        '
        CategoryLabel1.AutoSize = True
        CategoryLabel1.ForeColor = System.Drawing.Color.DarkGreen
        CategoryLabel1.Location = New System.Drawing.Point(91, 182)
        CategoryLabel1.Name = "CategoryLabel1"
        CategoryLabel1.Size = New System.Drawing.Size(52, 13)
        CategoryLabel1.TabIndex = 25
        CategoryLabel1.Text = "Category:"
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.Teal
        Me.saveBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.saveBtn.Location = New System.Drawing.Point(81, 220)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 53)
        Me.saveBtn.TabIndex = 10
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Brown
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cancelBtn.Location = New System.Drawing.Point(197, 220)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 53)
        Me.cancelBtn.TabIndex = 11
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'ProductCreation
        '
        Me.ProductCreation.DataSetName = "ProductCreation"
        Me.ProductCreation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.ProductCreation
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTableAdapter = Me.CategoryTableAdapter
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = MyBudget.ProductCreationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'CategoriesSet
        '
        Me.CategoriesSet.DataSetName = "CategoriesSet"
        Me.CategoriesSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NameBox
        '
        Me.NameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NameBox.Location = New System.Drawing.Point(158, 59)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 26
        '
        'PriceBox
        '
        Me.PriceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PriceBox.Location = New System.Drawing.Point(158, 96)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceBox.TabIndex = 27
        '
        'RequiredName
        '
        Me.RequiredName.AutoSize = True
        Me.RequiredName.ForeColor = System.Drawing.Color.DarkRed
        Me.RequiredName.Location = New System.Drawing.Point(77, 62)
        Me.RequiredName.Name = "RequiredName"
        Me.RequiredName.Size = New System.Drawing.Size(11, 13)
        Me.RequiredName.TabIndex = 31
        Me.RequiredName.Text = "*"
        '
        'RequiredPrice
        '
        Me.RequiredPrice.AutoSize = True
        Me.RequiredPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.RequiredPrice.Location = New System.Drawing.Point(77, 99)
        Me.RequiredPrice.Name = "RequiredPrice"
        Me.RequiredPrice.Size = New System.Drawing.Size(11, 13)
        Me.RequiredPrice.TabIndex = 36
        Me.RequiredPrice.Text = "*"
        '
        'TypeBox
        '
        Me.TypeBox.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TypeBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Items.AddRange(New Object() {"Product", "Service"})
        Me.TypeBox.Location = New System.Drawing.Point(158, 141)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(100, 21)
        Me.TypeBox.Sorted = True
        Me.TypeBox.TabIndex = 40
        '
        'CategoryBox
        '
        Me.CategoryBox.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.CategoryBox.DataSource = Me.CategoryBindingSource1
        Me.CategoryBox.DisplayMember = "Name"
        Me.CategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryBox.FormattingEnabled = True
        Me.CategoryBox.Location = New System.Drawing.Point(158, 179)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(100, 21)
        Me.CategoryBox.TabIndex = 41
        Me.CategoryBox.ValueMember = "Name"
        '
        'CategoryBindingSource1
        '
        Me.CategoryBindingSource1.DataMember = "Category"
        Me.CategoryBindingSource1.DataSource = Me.ProductCreation
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.ProductCreation1
        '
        'ProductCreation1
        '
        Me.ProductCreation1.DataSetName = "ProductCreation"
        Me.ProductCreation1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CreateProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(396, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.CategoryBox)
        Me.Controls.Add(Me.TypeBox)
        Me.Controls.Add(Me.RequiredPrice)
        Me.Controls.Add(Me.RequiredName)
        Me.Controls.Add(Me.PriceBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(CategoryLabel1)
        Me.Controls.Add(TypeLabel1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Name = "CreateProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Product"
        CType(Me.ProductCreation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductCreation1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents ProductCreation As MyBudget.ProductCreation
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As MyBudget.ProductCreationTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As MyBudget.ProductCreationTableAdapters.TableAdapterManager
    Friend WithEvents CategoryTableAdapter As MyBudget.ProductCreationTableAdapters.CategoryTableAdapter
    Friend WithEvents CategoriesSet As MyBudget.CategoriesSet
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceBox As System.Windows.Forms.TextBox
    Friend WithEvents RequiredName As System.Windows.Forms.Label
    Friend WithEvents RequiredPrice As System.Windows.Forms.Label
    Friend WithEvents TypeBox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoryBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductCreation1 As MyBudget.ProductCreation
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryBindingSource1 As System.Windows.Forms.BindingSource
End Class
