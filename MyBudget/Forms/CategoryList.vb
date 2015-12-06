Public Class CategoryList

    Private Sub ExitButton_Click(sender As Object, e As EventArgs)
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub CategoryList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CategoriesSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.CategoriesSet.Category)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditCategory.OriginalName = ListView.CurrentRow.Cells(0).Value.ToString()
        EditCategory.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim CategoryName = ListView.CurrentRow.Cells(0).Value.ToString()
        Dim Answer = MessageBox.Show("Are you sure you want to delete the " + CategoryName + " category forever?", "Category Management", MessageBoxButtons.YesNo)
        If Answer = Windows.Forms.DialogResult.Yes Then
            If CategoryTableAdapter.DeleteCategory(CategoryName) > 0 Then
                ListView.DataSource = Nothing
                CategoryTableAdapter.Fill(CategoriesSet.Category)
                ListView.DataSource = CategoryBindingSource
                ListView.Refresh()
                MessageBox.Show("The Category has been deleted!", "Category Management")
            Else
                MessageBox.Show("There has been an error.  Please try again.", "ERROR")
            End If
        End If
    End Sub
End Class