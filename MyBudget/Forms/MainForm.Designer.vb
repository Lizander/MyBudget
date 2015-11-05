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
        Me.CreateProductButton = New System.Windows.Forms.Button()
        Me.ChooseProductButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CreateCategoryButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CreateProductButton
        '
        Me.CreateProductButton.BackColor = System.Drawing.Color.CadetBlue
        Me.CreateProductButton.Location = New System.Drawing.Point(129, 47)
        Me.CreateProductButton.Name = "CreateProductButton"
        Me.CreateProductButton.Size = New System.Drawing.Size(154, 85)
        Me.CreateProductButton.TabIndex = 0
        Me.CreateProductButton.Text = "Create Product"
        Me.CreateProductButton.UseVisualStyleBackColor = False
        '
        'ChooseProductButton
        '
        Me.ChooseProductButton.BackColor = System.Drawing.Color.PowderBlue
        Me.ChooseProductButton.Location = New System.Drawing.Point(129, 251)
        Me.ChooseProductButton.Name = "ChooseProductButton"
        Me.ChooseProductButton.Size = New System.Drawing.Size(154, 85)
        Me.ChooseProductButton.TabIndex = 1
        Me.ChooseProductButton.Text = "Choose Product"
        Me.ChooseProductButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Khaki
        Me.ExitButton.Location = New System.Drawing.Point(129, 357)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(154, 85)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'CreateCategoryButton
        '
        Me.CreateCategoryButton.BackColor = System.Drawing.Color.SkyBlue
        Me.CreateCategoryButton.Location = New System.Drawing.Point(129, 149)
        Me.CreateCategoryButton.Name = "CreateCategoryButton"
        Me.CreateCategoryButton.Size = New System.Drawing.Size(154, 85)
        Me.CreateCategoryButton.TabIndex = 3
        Me.CreateCategoryButton.Text = "Create Category"
        Me.CreateCategoryButton.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(423, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.CreateCategoryButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ChooseProductButton)
        Me.Controls.Add(Me.CreateProductButton)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CreateProductButton As System.Windows.Forms.Button
    Friend WithEvents ChooseProductButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents CreateCategoryButton As System.Windows.Forms.Button

End Class
