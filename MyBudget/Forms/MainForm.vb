Public Class MainForm

    Private Sub chooseProductBtn_Click(sender As Object, e As EventArgs) Handles ChooseProductButton.Click
        ProductSearch.Show()
        Me.Hide()
    End Sub

    Private Sub createProductBtn_Click(sender As Object, e As EventArgs) Handles CreateProductButton.Click
        CreateProduct.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub CreateCategoryButton_Click(sender As Object, e As EventArgs) Handles CreateCategoryButton.Click
        CreateCategory.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchBudget.Show()
        Me.Hide()
    End Sub

    Private Sub CategoriesButton_Click(sender As Object, e As EventArgs) Handles CategoriesButton.Click
        CategoryList.Show()
    End Sub
End Class
