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
        Me.createProductBtn = New System.Windows.Forms.Button()
        Me.chooseProductBtn = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'createProductBtn
        '
        Me.createProductBtn.BackColor = System.Drawing.Color.CadetBlue
        Me.createProductBtn.Location = New System.Drawing.Point(129, 47)
        Me.createProductBtn.Name = "createProductBtn"
        Me.createProductBtn.Size = New System.Drawing.Size(154, 85)
        Me.createProductBtn.TabIndex = 0
        Me.createProductBtn.Text = "Create Product"
        Me.createProductBtn.UseVisualStyleBackColor = False
        '
        'chooseProductBtn
        '
        Me.chooseProductBtn.BackColor = System.Drawing.Color.PowderBlue
        Me.chooseProductBtn.Location = New System.Drawing.Point(129, 176)
        Me.chooseProductBtn.Name = "chooseProductBtn"
        Me.chooseProductBtn.Size = New System.Drawing.Size(154, 85)
        Me.chooseProductBtn.TabIndex = 1
        Me.chooseProductBtn.Text = "Choose Product"
        Me.chooseProductBtn.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Khaki
        Me.ExitButton.Location = New System.Drawing.Point(129, 290)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(154, 85)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(423, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.chooseProductBtn)
        Me.Controls.Add(Me.createProductBtn)
        Me.Name = "MainForm"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents createProductBtn As System.Windows.Forms.Button
    Friend WithEvents chooseProductBtn As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button

End Class
