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

    Private Sub SearchDataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SearchDataView.CellContentClick

    End Sub

    Private Sub AddToBudgetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToBudgetToolStripMenuItem.Click
        AddToBudget.NameBox.Text = SearchDataView.CurrentRow.Cells(0).Value.ToString()
        AddToBudget.PriceBox.Text = FormatCurrency(SearchDataView.CurrentRow.Cells(1).Value.ToString())
        AddToBudget.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        EditItem.OriginalName = SearchDataView.CurrentRow.Cells(0).Value.ToString()
        EditItem.OriginalPrice = FormatCurrency(SearchDataView.CurrentRow.Cells(1).Value.ToString())
        EditItem.OriginalType = SearchDataView.CurrentRow.Cells(2).Value()
        EditItem.OriginalCategory = SearchDataView.CurrentRow.Cells(3).Value()
        EditItem.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim ProductName = SearchDataView.CurrentRow.Cells(0).Value.ToString()
        Dim ProductPrice = SearchDataView.CurrentRow.Cells(1).Value
        Dim ProductType = SearchDataView.CurrentRow.Cells(2).Value.ToString()
        Dim ProductCategory = SearchDataView.CurrentRow.Cells(3).Value.ToString()
        Dim answer = MessageBox.Show("Are you sure you want to delete " + SearchDataView.CurrentRow.Cells(0).Value.ToString() + " forever?", "Product Management",
                                     MessageBoxButtons.YesNo)
        If answer = Windows.Forms.DialogResult.Yes Then
            If ProductTableAdapter.DeleteProduct(ProductName, ProductPrice, ProductType, ProductCategory) > 0 Then
                SearchDataView.DataSource = Nothing
                ProductTableAdapter.Fill(MyBudgetDataSet.Product)
                SearchDataView.DataSource = ProductBindingSource1
                SearchDataView.Refresh()
                MessageBox.Show("The product has been deleted!", "Product Management")
            Else
                MessageBox.Show("There has been an error please try again.")
            End If
        End If
    End Sub
End Class