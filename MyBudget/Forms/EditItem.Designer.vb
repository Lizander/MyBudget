<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditItem
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
        Dim CategoryLabel1 As System.Windows.Forms.Label
        Dim TypeLabel1 As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditItem))
        Me.CategoryBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyBudgetDataSet = New MyBudget.myBudgetDataSet()
        Me.TypeBox = New System.Windows.Forms.ComboBox()
        Me.RequiredPrice = New System.Windows.Forms.Label()
        Me.RequiredName = New System.Windows.Forms.Label()
        Me.PriceBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New MyBudget.myBudgetDataSetTableAdapters.ProductTableAdapter()
        Me.CategoryTableAdapter = New MyBudget.myBudgetDataSetTableAdapters.CategoryTableAdapter()
        CategoryLabel1 = New System.Windows.Forms.Label()
        TypeLabel1 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyBudgetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryLabel1
        '
        CategoryLabel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CategoryLabel1.AutoSize = True
        CategoryLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CategoryLabel1.Location = New System.Drawing.Point(59, 189)
        CategoryLabel1.Name = "CategoryLabel1"
        CategoryLabel1.Size = New System.Drawing.Size(76, 21)
        CategoryLabel1.TabIndex = 47
        CategoryLabel1.Text = "Category:"
        '
        'TypeLabel1
        '
        TypeLabel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TypeLabel1.AutoSize = True
        TypeLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TypeLabel1.Location = New System.Drawing.Point(76, 126)
        TypeLabel1.Name = "TypeLabel1"
        TypeLabel1.Size = New System.Drawing.Size(45, 21)
        TypeLabel1.TabIndex = 46
        TypeLabel1.Text = "Type:"
        '
        'NameLabel
        '
        NameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        NameLabel.Location = New System.Drawing.Point(90, 30)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(55, 21)
        NameLabel.TabIndex = 43
        NameLabel.Text = "Name:"
        '
        'PriceLabel
        '
        PriceLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        PriceLabel.Location = New System.Drawing.Point(90, 75)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(47, 21)
        PriceLabel.TabIndex = 45
        PriceLabel.Text = "Price:"
        '
        'CategoryBox
        '
        Me.CategoryBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoryBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CategoryBox.DataSource = Me.CategoryBindingSource
        Me.CategoryBox.DisplayMember = "Name"
        Me.CategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CategoryBox.FormattingEnabled = True
        Me.CategoryBox.Location = New System.Drawing.Point(178, 186)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(148, 29)
        Me.CategoryBox.TabIndex = 53
        Me.CategoryBox.ValueMember = "Name"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.MyBudgetDataSet
        '
        'MyBudgetDataSet
        '
        Me.MyBudgetDataSet.DataSetName = "myBudgetDataSet"
        Me.MyBudgetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TypeBox
        '
        Me.TypeBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TypeBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TypeBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TypeBox.FormattingEnabled = True
        Me.TypeBox.Items.AddRange(New Object() {"Product", "Service"})
        Me.TypeBox.Location = New System.Drawing.Point(178, 126)
        Me.TypeBox.Name = "TypeBox"
        Me.TypeBox.Size = New System.Drawing.Size(148, 29)
        Me.TypeBox.Sorted = True
        Me.TypeBox.TabIndex = 52
        '
        'RequiredPrice
        '
        Me.RequiredPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RequiredPrice.AutoSize = True
        Me.RequiredPrice.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequiredPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.RequiredPrice.Location = New System.Drawing.Point(59, 78)
        Me.RequiredPrice.Name = "RequiredPrice"
        Me.RequiredPrice.Size = New System.Drawing.Size(25, 32)
        Me.RequiredPrice.TabIndex = 51
        Me.RequiredPrice.Text = "*"
        '
        'RequiredName
        '
        Me.RequiredName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RequiredName.AutoSize = True
        Me.RequiredName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequiredName.ForeColor = System.Drawing.Color.DarkRed
        Me.RequiredName.Location = New System.Drawing.Point(59, 30)
        Me.RequiredName.Name = "RequiredName"
        Me.RequiredName.Size = New System.Drawing.Size(25, 32)
        Me.RequiredName.TabIndex = 50
        Me.RequiredName.Text = "*"
        '
        'PriceBox
        '
        Me.PriceBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PriceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PriceBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceBox.Location = New System.Drawing.Point(178, 75)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(148, 29)
        Me.PriceBox.TabIndex = 49
        '
        'NameBox
        '
        Me.NameBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NameBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.Location = New System.Drawing.Point(178, 30)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(148, 29)
        Me.NameBox.TabIndex = 48
        '
        'cancelBtn
        '
        Me.cancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cancelBtn.Image = CType(resources.GetObject("cancelBtn.Image"), System.Drawing.Image)
        Me.cancelBtn.Location = New System.Drawing.Point(272, 233)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(147, 146)
        Me.cancelBtn.TabIndex = 44
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'saveBtn
        '
        Me.saveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.saveBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.saveBtn.Image = CType(resources.GetObject("saveBtn.Image"), System.Drawing.Image)
        Me.saveBtn.Location = New System.Drawing.Point(12, 233)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(147, 146)
        Me.saveBtn.TabIndex = 42
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.MyBudgetDataSet
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'EditItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(486, 391)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Item"
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyBudgetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CategoryBox As System.Windows.Forms.ComboBox
    Friend WithEvents TypeBox As System.Windows.Forms.ComboBox
    Friend WithEvents RequiredPrice As System.Windows.Forms.Label
    Friend WithEvents RequiredName As System.Windows.Forms.Label
    Friend WithEvents PriceBox As System.Windows.Forms.TextBox
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents MyBudgetDataSet As MyBudget.myBudgetDataSet
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As MyBudget.myBudgetDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As MyBudget.myBudgetDataSetTableAdapters.CategoryTableAdapter
End Class
