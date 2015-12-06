Public Class EditCategory
    Public OriginalName As String
    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        If NameTextBox.Text.Length > 0 Then
            RequiredName.Visible = False
        Else
            RequiredName.Visible = True
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If RequiredName.Visible = True Then
            MessageBox.Show("Please write a Name for the Category.", "Category Creation", MessageBoxButtons.OK)
            NameTextBox.Focus()
        ElseIf (OriginalName <> NameTextBox.Text) And (CategoryTableAdapter.DuplicateCategory(NameTextBox.Text) > 0) Then
            MessageBox.Show("A Category with that Name already exists.  Please use a different Name.", "Category Creation", MessageBoxButtons.OK)
        ElseIf CategoryTableAdapter.UpdateCategory(NameTextBox.Text, OriginalName) > 0 Then
            MessageBox.Show("The category has been updated!", "Category Management")
            CategoryList.ListView.DataSource = Nothing
            CategoryList.CategoryTableAdapter.Fill(CategoryList.CategoriesSet.Category)
            CategoryList.ListView.DataSource = CategoryList.CategoryBindingSource
            CategoryList.ListView.Refresh()
            Me.Close()
        Else
            MessageBox.Show("We're sorry, there's been an error.  Please try again.", "ERROR", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub CategoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CategoriesSet)

    End Sub

    Private Sub EditCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CategoriesSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.CategoriesSet.Category)

    End Sub

    Private Sub EditCategory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        NameTextBox.Text = OriginalName
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class