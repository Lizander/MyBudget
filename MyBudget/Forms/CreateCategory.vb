Public Class CreateCategory

    Dim answer As Windows.Forms.DialogResult

    Private Sub CategoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CategoriesSet)

    End Sub


    Private Sub CategoryBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CategoriesSet)

    End Sub

    Private Sub CreateCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CategoriesSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.CategoriesSet.Category)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If RequiredName.Visible = True Then
            MessageBox.Show("Please write a Name for the Category.", "Category Creation", MessageBoxButtons.OK)
            NameTextBox.Focus()
        ElseIf CategoryTableAdapter.DuplicateCategory(NameTextBox.Text) > 0 Then
            MessageBox.Show("A Category with that Name already exists.  Please use a different Name.", "Category Creation", MessageBoxButtons.OK)
        Else
            If CategoryTableAdapter.CreateCategory(NameTextBox.Text) > 0 Then
                answer = MessageBox.Show("Category created.  Do you want to create another one?", "Category Creation", MessageBoxButtons.YesNo)
                If answer = DialogResult.Yes Then
                    NameTextBox.Clear()
                ElseIf answer = DialogResult.No Then
                    MainForm.Show()
                    Me.Close()
                End If
            Else
                MessageBox.Show("We're sorry, there's been an error.  Please try again.", "ERROR", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        If NameTextBox.Text.Length > 0 Then
            RequiredName.Visible = False
        Else
            RequiredName.Visible = True
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Me.Close()
    End Sub
End Class