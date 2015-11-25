Public Class AddToBudget
    Private Sub AddToBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TransactionCreation.Budget' table. You can move, or remove it, as needed.
        Me.BudgetTableAdapter.Fill(Me.TransactionCreation.Budget)
        'TODO: This line of code loads data into the 'TransactionCreation.Transaction' table. You can move, or remove it, as needed.
        Me.TransactionTableAdapter.Fill(Me.TransactionCreation.Transaction)

    End Sub

    Private Sub AddToBudget_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub TransactionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TransactionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TransactionCreation)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If BudgetTableAdapter.SearchDate(DateBox.Value.ToShortDateString) = 0 Then
            BudgetTableAdapter.CreateBudget(DateBox.Value.ToShortDateString, 0.0, 0.0)
        End If
        If TransactionTableAdapter.CreateTransaction(NameBox.Text, QuantityBox.Value, Double.Parse(PriceBox.Text.Trim("$")), DateBox.Value.ToShortDateString) > 0 Then
            Dim Total = BudgetTableAdapter.GetTotal(DateBox.Value.ToShortDateString).Value
            Total += (Double.Parse(PriceBox.Text.Trim("$")) * QuantityBox.Value)
            Dim Tax = Total * 0.115
            If BudgetTableAdapter.UpdateBudget(Total, Tax, DateBox.Value.ToShortDateString, DateBox.Value.ToShortDateString) > 0 Then
                MessageBox.Show("Item added to Budget!", "Budget Creation", MessageBoxButtons.OK)
                Me.Close()
            Else
                MessageBox.Show("We're sorry, there's been an error.  Please try again.", "ERROR", MessageBoxButtons.OK)
            End If
        End If
    End Sub
End Class