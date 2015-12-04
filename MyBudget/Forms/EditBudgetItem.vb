Public Class EditBudgetItem
    Public ItemDate As String
    Public ItemQuantity As Integer
    Private Sub EditBudgetItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BudgetTransaction.Budget' table. You can move, or remove it, as needed.
        Me.BudgetTableAdapter.Fill(Me.BudgetTransaction.Budget)
        'TODO: This line of code loads data into the 'BudgetTransaction.Transaction' table. You can move, or remove it, as needed.
        Me.TransactionTableAdapter.Fill(Me.BudgetTransaction.Transaction)

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If TransactionTableAdapter.UpdateItem(QuantityBox.Value, NameBox.Text, ItemDate) > 0 Then
            If BudgetTableAdapter.UpdateBudget(ItemDate, ItemDate) > 0 Then
                MessageBox.Show("Budget updated!", "Budget Management")
                SearchBudget.ItemsView.DataSource = Nothing
                SearchBudget.TransactionTableAdapter.ShowItems(SearchBudget.BudgetTransaction.Transaction, ItemDate)
                SearchBudget.ItemsView.DataSource = SearchBudget.TransactionBindingSource
                SearchBudget.ItemsView.Refresh()
                SearchBudget.ItemsView.ClearSelection()
                SearchBudget.DateView.DataSource = Nothing
                SearchBudget.BudgetTableAdapter.Fill(SearchBudget.BudgetTransaction.Budget)
                SearchBudget.DateView.DataSource = SearchBudget.BudgetBindingSource
                SearchBudget.DateView.Refresh()
                SearchBudget.BudgetBindingSource.ResetBindings(False)
                SearchBudget.TotalLabel.Text = FormatCurrency(SearchBudget.TotalLabel.Text)
                SearchBudget.TaxLabel.Text = FormatCurrency(SearchBudget.TaxLabel.Text)
                Me.Close()
            Else
                MessageBox.Show("There has been an error.  Please try again.", "ERROR")
            End If
        End If
    End Sub

    Private Sub EditBudgetItem_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If PriceBox.Text.Length > 0 Then
            PriceBox.Text = FormatCurrency(PriceBox.Text)
        End If
    End Sub
End Class