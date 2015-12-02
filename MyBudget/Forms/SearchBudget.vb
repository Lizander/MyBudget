Public Class SearchBudget

    Private Sub SearchBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BudgetTransaction.Transaction' table. You can move, or remove it, as needed.
        Me.TransactionTableAdapter.Fill(Me.BudgetTransaction.Transaction)
        'TODO: This line of code loads data into the 'BudgetTransaction.Budget' table. You can move, or remove it, as needed.
        Me.BudgetTableAdapter.Fill(Me.BudgetTransaction.Budget)

    End Sub

    Private Sub DateView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DateView.CellContentClick
        ItemsView.DataSource = Nothing
        TransactionTableAdapter.ShowItems(BudgetTransaction.Transaction, DateView.Rows(e.RowIndex).Cells(0).Value.ToString())
        ItemsView.DataSource = TransactionBindingSource
        ItemsView.Refresh()
        ItemsView.ClearSelection()
        TotalLabel.Text = FormatCurrency(TotalLabel.Text)
        TaxLabel.Text = FormatCurrency(TaxLabel.Text)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub SearchBudget_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TotalLabel.Text = FormatCurrency(TotalLabel.Text)
        TaxLabel.Text = FormatCurrency(TaxLabel.Text)
    End Sub
End Class