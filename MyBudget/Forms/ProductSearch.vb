Public Class ProductSearch

    Private Sub ProductSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CategoriesSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.CategoriesSet.Category)
        'TODO: This line of code loads data into the 'MyBudgetDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.MyBudgetDataSet.Product)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub TypeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeBox.SelectedIndexChanged
        If CategoryBox.SelectedItem Is Nothing Then
            If TypeBox.SelectedItem IsNot Nothing Then
                Me.SearchDataView.DataSource = Nothing
                Me.ProductTableAdapter.FilterTypeFill(MyBudgetDataSet.Product, TypeBox.SelectedItem)
                Me.SearchDataView.DataSource = Me.ProductBindingSource1
                Me.SearchDataView.Refresh()
            End If
        End If
    End Sub

    Private Sub ProductSearch_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CategoryBox.SelectedValue = ""
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        CategoryBox.SelectedItem = Nothing
        TypeBox.SelectedItem = Nothing
        Me.SearchDataView.DataSource = Nothing
        Me.ProductTableAdapter.Fill(MyBudgetDataSet.Product)
        Me.SearchDataView.DataSource = Me.ProductBindingSource1
        Me.SearchDataView.Refresh()
    End Sub
End Class