﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchBudget
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchBudget))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DateView = New System.Windows.Forms.DataGridView()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BudgetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BudgetTransaction = New MyBudget.BudgetTransaction()
        Me.TransactionStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BudgetTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BudgetTableAdapter = New MyBudget.BudgetTransactionTableAdapters.BudgetTableAdapter()
        Me.TransactionTableAdapter = New MyBudget.BudgetTransactionTableAdapters.TransactionTableAdapter()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ItemsView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BudgetStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DateView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BudgetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BudgetTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TransactionStrip.SuspendLayout()
        CType(Me.TransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BudgetTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BudgetStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateView
        '
        Me.DateView.AllowUserToAddRows = False
        Me.DateView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DateView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DateView.AutoGenerateColumns = False
        Me.DateView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DateView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DateView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DateView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DateView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DateView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DateView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn})
        Me.DateView.ContextMenuStrip = Me.BudgetStrip
        Me.DateView.DataSource = Me.BudgetBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DateView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DateView.EnableHeadersVisualStyles = False
        Me.DateView.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DateView.Location = New System.Drawing.Point(46, 12)
        Me.DateView.Name = "DateView"
        Me.DateView.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DateView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DateView.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DateView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DateView.Size = New System.Drawing.Size(144, 150)
        Me.DateView.TabIndex = 0
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateDataGridViewTextBoxColumn.Width = 66
        '
        'BudgetBindingSource
        '
        Me.BudgetBindingSource.DataMember = "Budget"
        Me.BudgetBindingSource.DataSource = Me.BudgetTransaction
        '
        'BudgetTransaction
        '
        Me.BudgetTransaction.DataSetName = "BudgetTransaction"
        Me.BudgetTransaction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionStrip
        '
        Me.TransactionStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.TransactionStrip.Name = "ContextMenuStrip1"
        Me.TransactionStrip.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'TransactionBindingSource
        '
        Me.TransactionBindingSource.DataMember = "Transaction"
        Me.TransactionBindingSource.DataSource = Me.BudgetTransactionBindingSource
        '
        'BudgetTransactionBindingSource
        '
        Me.BudgetTransactionBindingSource.DataSource = Me.BudgetTransaction
        Me.BudgetTransactionBindingSource.Position = 0
        '
        'BudgetTableAdapter
        '
        Me.BudgetTableAdapter.ClearBeforeFill = True
        '
        'TransactionTableAdapter
        '
        Me.TransactionTableAdapter.ClearBeforeFill = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(1060, 307)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(144, 136)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'TotalLabel
        '
        Me.TotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BudgetBindingSource, "Total", True))
        Me.TotalLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TotalLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TotalLabel.Location = New System.Drawing.Point(635, 184)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(56, 21)
        Me.TotalLabel.TabIndex = 7
        Me.TotalLabel.Text = "Label1"
        '
        'TaxLabel
        '
        Me.TaxLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaxLabel.AutoSize = True
        Me.TaxLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BudgetBindingSource, "Tax", True))
        Me.TaxLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TaxLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TaxLabel.Location = New System.Drawing.Point(635, 233)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(56, 21)
        Me.TaxLabel.TabIndex = 8
        Me.TaxLabel.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(559, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tax:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(559, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Total:"
        '
        'ItemsView
        '
        Me.ItemsView.AllowUserToAddRows = False
        Me.ItemsView.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.ItemsView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.ItemsView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemsView.AutoGenerateColumns = False
        Me.ItemsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ItemsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ItemsView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ItemsView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemsView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemsView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemsView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.ItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.Price})
        Me.ItemsView.ContextMenuStrip = Me.TransactionStrip
        Me.ItemsView.DataSource = Me.TransactionBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemsView.DefaultCellStyle = DataGridViewCellStyle9
        Me.ItemsView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ItemsView.EnableHeadersVisualStyles = False
        Me.ItemsView.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ItemsView.Location = New System.Drawing.Point(563, 12)
        Me.ItemsView.Name = "ItemsView"
        Me.ItemsView.ReadOnly = True
        Me.ItemsView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemsView.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.ItemsView.RowHeadersVisible = False
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        Me.ItemsView.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.ItemsView.Size = New System.Drawing.Size(304, 169)
        Me.ItemsView.TabIndex = 1
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 75
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 93
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.Price.DefaultCellStyle = DataGridViewCellStyle8
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 67
        '
        'TransactionBindingSource1
        '
        Me.TransactionBindingSource1.DataMember = "Transaction"
        Me.TransactionBindingSource1.DataSource = Me.BudgetTransactionBindingSource
        '
        'BudgetStrip
        '
        Me.BudgetStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1})
        Me.BudgetStrip.Name = "BudgetStrip"
        Me.BudgetStrip.Size = New System.Drawing.Size(153, 48)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'SearchBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1216, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TaxLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ItemsView)
        Me.Controls.Add(Me.DateView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchBudget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Budget"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DateView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BudgetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BudgetTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TransactionStrip.ResumeLayout(False)
        CType(Me.TransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BudgetTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BudgetStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateView As System.Windows.Forms.DataGridView
    Friend WithEvents BudgetTransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BudgetTransaction As MyBudget.BudgetTransaction
    Friend WithEvents BudgetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BudgetTableAdapter As MyBudget.BudgetTransactionTableAdapters.BudgetTableAdapter
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionTableAdapter As MyBudget.BudgetTransactionTableAdapters.TransactionTableAdapter
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents TaxLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TransactionStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemsView As System.Windows.Forms.DataGridView
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BudgetStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
