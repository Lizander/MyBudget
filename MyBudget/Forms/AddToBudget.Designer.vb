<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddToBudget
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
        Me.DateBox = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QuantityBox = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.PriceBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TransactionCreation = New MyBudget.TransactionCreation()
        Me.TransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactionTableAdapter = New MyBudget.TransactionCreationTableAdapters.TransactionTableAdapter()
        Me.TableAdapterManager = New MyBudget.TransactionCreationTableAdapters.TableAdapterManager()
        Me.BudgetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BudgetTableAdapter = New MyBudget.TransactionCreationTableAdapters.BudgetTableAdapter()
        CType(Me.QuantityBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionCreation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BudgetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateBox
        '
        Me.DateBox.Location = New System.Drawing.Point(101, 99)
        Me.DateBox.Name = "DateBox"
        Me.DateBox.Size = New System.Drawing.Size(200, 20)
        Me.DateBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity:"
        '
        'QuantityBox
        '
        Me.QuantityBox.Location = New System.Drawing.Point(101, 143)
        Me.QuantityBox.Name = "QuantityBox"
        Me.QuantityBox.Size = New System.Drawing.Size(69, 20)
        Me.QuantityBox.TabIndex = 3
        Me.QuantityBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Price:"
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(101, 33)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.ReadOnly = True
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 6
        '
        'PriceBox
        '
        Me.PriceBox.Location = New System.Drawing.Point(101, 64)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.ReadOnly = True
        Me.PriceBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceBox.TabIndex = 7
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(22, 245)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(224, 245)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 9
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'TransactionCreation
        '
        Me.TransactionCreation.DataSetName = "TransactionCreation"
        Me.TransactionCreation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransactionBindingSource
        '
        Me.TransactionBindingSource.DataMember = "Transaction"
        Me.TransactionBindingSource.DataSource = Me.TransactionCreation
        '
        'TransactionTableAdapter
        '
        Me.TransactionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BudgetTableAdapter = Nothing
        Me.TableAdapterManager.TransactionTableAdapter = Me.TransactionTableAdapter
        Me.TableAdapterManager.UpdateOrder = MyBudget.TransactionCreationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BudgetBindingSource
        '
        Me.BudgetBindingSource.DataMember = "Budget"
        Me.BudgetBindingSource.DataSource = Me.TransactionCreation
        '
        'BudgetTableAdapter
        '
        Me.BudgetTableAdapter.ClearBeforeFill = True
        '
        'AddToBudget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 309)
        Me.ControlBox = False
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.PriceBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.QuantityBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateBox)
        Me.Name = "AddToBudget"
        Me.Text = "Add To Budget"
        CType(Me.QuantityBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionCreation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BudgetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateBox As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents QuantityBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceBox As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents TransactionCreation As MyBudget.TransactionCreation
    Friend WithEvents TransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransactionTableAdapter As MyBudget.TransactionCreationTableAdapters.TransactionTableAdapter
    Friend WithEvents TableAdapterManager As MyBudget.TransactionCreationTableAdapters.TableAdapterManager
    Friend WithEvents BudgetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BudgetTableAdapter As MyBudget.TransactionCreationTableAdapters.BudgetTableAdapter
End Class
