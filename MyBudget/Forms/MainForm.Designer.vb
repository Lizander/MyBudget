<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CreateProductButton = New System.Windows.Forms.Button()
        Me.ChooseProductButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CreateCategoryButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateProductButton
        '
        Me.CreateProductButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CreateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateProductButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CreateProductButton.Image = CType(resources.GetObject("CreateProductButton.Image"), System.Drawing.Image)
        Me.CreateProductButton.Location = New System.Drawing.Point(169, 60)
        Me.CreateProductButton.Name = "CreateProductButton"
        Me.CreateProductButton.Size = New System.Drawing.Size(154, 156)
        Me.CreateProductButton.TabIndex = 0
        Me.CreateProductButton.UseVisualStyleBackColor = False
        '
        'ChooseProductButton
        '
        Me.ChooseProductButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChooseProductButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ChooseProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChooseProductButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ChooseProductButton.Image = CType(resources.GetObject("ChooseProductButton.Image"), System.Drawing.Image)
        Me.ChooseProductButton.Location = New System.Drawing.Point(439, 71)
        Me.ChooseProductButton.Name = "ChooseProductButton"
        Me.ChooseProductButton.Size = New System.Drawing.Size(154, 135)
        Me.ChooseProductButton.TabIndex = 1
        Me.ChooseProductButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(1214, 492)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(136, 125)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'CreateCategoryButton
        '
        Me.CreateCategoryButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CreateCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateCategoryButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CreateCategoryButton.Image = CType(resources.GetObject("CreateCategoryButton.Image"), System.Drawing.Image)
        Me.CreateCategoryButton.Location = New System.Drawing.Point(169, 360)
        Me.CreateCategoryButton.Name = "CreateCategoryButton"
        Me.CreateCategoryButton.Size = New System.Drawing.Size(154, 143)
        Me.CreateCategoryButton.TabIndex = 3
        Me.CreateCategoryButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(171, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "New Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(163, 506)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "New Category"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(480, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Search"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(480, 508)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Budget"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(439, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 135)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1362, 629)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CreateCategoryButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ChooseProductButton)
        Me.Controls.Add(Me.CreateProductButton)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CreateProductButton As System.Windows.Forms.Button
    Friend WithEvents ChooseProductButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents CreateCategoryButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
