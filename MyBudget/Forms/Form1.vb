Public Class MainForm

    Private Sub chooseProductBtn_Click(sender As Object, e As EventArgs) Handles chooseProductBtn.Click
        ProductSearch.Show()
        Me.Hide()
    End Sub

    Private Sub createProductBtn_Click(sender As Object, e As EventArgs) Handles createProductBtn.Click
        CreateProduct.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
