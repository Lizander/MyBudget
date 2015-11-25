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
        If TypeBox.SelectedItem IsNot Nothing Then
            If CategoryBox.SelectedItem Is Nothing Then
                SearchDataView.DataSource = Nothing
                ProductTableAdapter.FilterTypeFill(MyBudgetDataSet.Product, TypeBox.SelectedItem)
                SearchDataView.DataSource = Me.ProductBindingSource1
                SearchDataView.Refresh()
                SearchDataView.ClearSelection()
            ElseIf CategoryBox.SelectedItem IsNot Nothing Then
                SearchDataView.DataSource = Nothing
                ProductTableAdapter.FilterBothFill(MyBudgetDataSet.Product, CategoryBox.SelectedValue, TypeBox.SelectedItem)
                SearchDataView.DataSource = Me.ProductBindingSource1
                SearchDataView.Refresh()
                SearchDataView.ClearSelection()
            End If
        End If
    End Sub

    Private Sub ProductSearch_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CategoryBox.SelectedValue = ""
        SearchDataView.ClearSelection()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        CategoryBox.SelectedItem = Nothing
        TypeBox.SelectedItem = Nothing
        SearchDataView.DataSource = Nothing
        ProductTableAdapter.Fill(MyBudgetDataSet.Product)
        SearchDataView.DataSource = Me.ProductBindingSource1
        SearchDataView.Refresh()
        SearchDataView.ClearSelection()
    End Sub

    Private Sub CategoryBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryBox.SelectedIndexChanged
        If CategoryBox.SelectedItem IsNot Nothing Then
            If TypeBox.SelectedItem Is Nothing Then
                SearchDataView.DataSource = Nothing
                ProductTableAdapter.FilterCategoryFill(MyBudgetDataSet.Product, CategoryBox.SelectedValue)
                SearchDataView.DataSource = Me.ProductBindingSource1
                SearchDataView.Refresh()
                SearchDataView.ClearSelection()
            ElseIf TypeBox.SelectedItem IsNot Nothing Then
                SearchDataView.DataSource = Nothing
                ProductTableAdapter.FilterBothFill(MyBudgetDataSet.Product, CategoryBox.SelectedValue, TypeBox.SelectedItem)
                SearchDataView.DataSource = Me.ProductBindingSource1
                SearchDataView.Refresh()
                SearchDataView.ClearSelection()
            End If
        End If
    End Sub

    Private Sub SearchDataView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles SearchDataView.CellDoubleClick
        AddToBudget.NameBox.Text = SearchDataView.Rows(e.RowIndex).Cells(0).Value.ToString()
        AddToBudget.PriceBox.Text = FormatCurrency(SearchDataView.Rows(e.RowIndex).Cells(1).Value.ToString())
        AddToBudget.Show()
    End Sub
End Class