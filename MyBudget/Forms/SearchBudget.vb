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
        If TotalLabel.Text.Length > 1 Then
            TotalLabel.Text = FormatCurrency(TotalLabel.Text)
            TaxLabel.Text = FormatCurrency(TaxLabel.Text)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim answer = MessageBox.Show("Are you sure you want to delete " + ItemsView.CurrentRow.Cells(0).Value.ToString() + " from the budget?",
                                     "Budget Management", MessageBoxButtons.YesNo)
        If answer = Windows.Forms.DialogResult.Yes Then
            If TransactionTableAdapter.DeleteFromTransaction(ItemsView.CurrentRow.Cells(0).Value.ToString(), DateView.CurrentRow.Cells(0).Value.ToString()) > 0 Then
                Dim Total = BudgetTableAdapter.GetTotalAfterDelete(DateView.CurrentRow.Cells(0).Value).Value
                Total -= ItemsView.CurrentRow.Cells(1).Value * ItemsView.CurrentRow.Cells(2).Value
                Dim Tax = Total * 0.115
                BudgetTableAdapter.UpdateAfterDelete(Total, Tax, DateView.CurrentRow.Cells(0).Value, DateView.CurrentRow.Cells(0).Value)
                DateView.DataSource = Nothing
                BudgetTableAdapter.Fill(BudgetTransaction.Budget)
                DateView.DataSource = BudgetBindingSource
                DateView.Refresh()
                ItemsView.DataSource = Nothing
                TransactionTableAdapter.ShowItems(BudgetTransaction.Transaction, DateView.CurrentRow.Cells(0).Value.ToString())
                ItemsView.DataSource = TransactionBindingSource
                ItemsView.Refresh()
                ItemsView.ClearSelection()
                TotalLabel.Text = FormatCurrency(TotalLabel.Text)
                TaxLabel.Text = FormatCurrency(TaxLabel.Text)
                MessageBox.Show("The item has been removed.")
            Else
                MessageBox.Show("We're sorry there has been an error.  Please try again.")
            End If
        End If
    End Sub
End Class