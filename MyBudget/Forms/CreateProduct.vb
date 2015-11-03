Public Class CreateProduct

    Dim DecimalPresent As Boolean
    Dim answer As Int16

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim InitialCount As Int16
        InitialCount = Me.ProductTableAdapter.GetData.Count
        If RequiredName.Visible = True Then
            MessageBox.Show("Please write a name for the product.", "Product Creation", MessageBoxButtons.OK)
            NameBox.Focus()
        ElseIf RequiredPrice.Visible = True Then
            MessageBox.Show("Please write a price for the product.", "Product Creation", MessageBoxButtons.OK)
            PriceBox.Focus()
        ElseIf Me.ProductTableAdapter.DuplicateProduct(NameBox.Text) = 1 Then
            MessageBox.Show("A product with that name already exists.  Please use a different name.", "Product Creation", MessageBoxButtons.OK)
        Else
            Me.ProductTableAdapter.CreateProduct(NameBox.Text, Decimal.Parse(PriceBox.Text), TypeBox.Text, CategoryBox.SelectedItem.ToString)
            If Me.ProductTableAdapter.GetData.Count > InitialCount Then
                answer = MessageBox.Show("Product created.  Do you want to create another one?", "Product Creation", MessageBoxButtons.YesNo)
                If answer = DialogResult.Yes Then
                    NameBox.Clear()
                    PriceBox.Clear()
                    CategoryBox.SelectedItem = 0
                    TypeBox.SelectedItem = 0
                ElseIf answer = DialogResult.No Then
                    MainForm.Show()
                    Me.Close()
                End If
            Else
                MessageBox.Show("We're sorry, there's been an error.  Please try again.", "ERROR", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub CreateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductCreation1.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.ProductCreation1.Category)
        'TODO: This line of code loads data into the 'ProductCreation.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.ProductCreation.Category)
        'TODO: This line of code loads data into the 'ProductCreation.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.ProductCreation.Product)

    End Sub

    Private Sub CreateProduct_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TypeBox.SelectedItem = "Product"
        DecimalPresent = False
        CategoryBox.SelectedItem = 0
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        If NameBox.Text.Length > 0 Then
            RequiredName.Visible = False
        Else
            RequiredName.Visible = True
        End If
    End Sub

    Private Sub PriceBox_TextChanged(sender As Object, e As EventArgs) Handles PriceBox.TextChanged
        If PriceBox.Text.Length > 0 Then
            RequiredPrice.Visible = False
        Else
            RequiredPrice.Visible = True
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

    Private Sub QuantityBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar.ToString) Or e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Delete) Then
            If e.KeyChar.ToString = "." Then
                e.KeyChar = ""
            End If
        Else
            e.KeyChar = ""
        End If
    End Sub
End Class