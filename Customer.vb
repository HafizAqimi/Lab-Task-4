Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LabTask4Customer1.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter2.Fill(Me.LabTask4Customer1.customers)
    End Sub
End Class