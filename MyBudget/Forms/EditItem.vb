Public Class EditItem
    Public OriginalName As String
    Public OriginalPrice As Double
    Public OriginalType As String
    Public OriginalCategory As String
    Public DecimalPresent As Boolean
    Private Sub EditItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyBudgetDataSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.MyBudgetDataSet.Category)
        'TODO: This line of code loads data into the 'MyBudgetDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.MyBudgetDataSet.Product)

    End Sub

    Private Sub EditItem_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        DecimalPresent = False
        CategoryBox.SelectedIndex = CategoryBox.FindStringExact(OriginalCategory)
        NameBox.Text = OriginalName
        PriceBox.Text = FormatCurrency(OriginalPrice)
        TypeBox.SelectedIndex = TypeBox.FindStringExact(OriginalType)
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If RequiredName.Visible = True Then
            MessageBox.Show("Please write a Name for the Product.", "Product Creation", MessageBoxButtons.OK)
            NameBox.Focus()
        ElseIf RequiredPrice.Visible = True Then
            MessageBox.Show("Please write a Price for the Product.", "Product Creation", MessageBoxButtons.OK)
            PriceBox.Focus()
        ElseIf (OriginalName <> NameBox.Text) And (ProductTableAdapter.DuplicateProduct(NameBox.Text) > 0) Then
            MessageBox.Show("A Product with that Name already exists.  Please use a different Name.", "Product Creation", MessageBoxButtons.OK)
        Else
            If ProductTableAdapter.UpdateProduct(NameBox.Text, Decimal.Parse(PriceBox.Text.Trim("$")), TypeBox.Text, CategoryBox.SelectedValue.ToString(),
                                                 OriginalName, OriginalPrice, OriginalType, OriginalCategory) > 0 Then
                MessageBox.Show("Product updated!", "Product Management")
                ProductSearch.SearchDataView.DataSource = Nothing
                ProductSearch.ProductTableAdapter.Fill(ProductSearch.MyBudgetDataSet.Product)
                ProductSearch.SearchDataView.DataSource = ProductSearch.ProductBindingSource1
                ProductSearch.SearchDataView.Refresh()
                Me.Close()
            Else
                MessageBox.Show("We're sorry, there's been an error.  Please try again.", "ERROR", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        If NameBox.Text.Length > 0 Then
            RequiredName.Visible = False
        Else
            RequiredName.Visible = True
        End If
    End Sub

    Private Sub PriceBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PriceBox.KeyPress
        If DecimalPresent = True And e.KeyChar.ToString = "." Then
            If PriceBox.Text.Contains(".") Then
                e.KeyChar = ""
            End If
        End If
        If IsNumeric(e.KeyChar.ToString) Or e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Delete) Or e.KeyChar = Convert.ToChar(Keys.Decimal) Then
            If e.KeyChar.ToString = "." Then
                DecimalPresent = True
            End If
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub PriceBox_TextChanged(sender As Object, e As EventArgs) Handles PriceBox.TextChanged
        If PriceBox.Text.Length > 0 Then
            RequiredPrice.Visible = False
        Else
            RequiredPrice.Visible = True
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
End Class