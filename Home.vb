Imports System.Data.SqlClient

Public Class Home
    Private Sub BTNCart_Click(sender As Object, e As EventArgs) Handles BTNCart.Click
        Dim connectionString As String = "Data Source=LAPTOP-LFAMR4GH; Initial Catalog=LabTask4;User Id=sa;Password=p@ssw0rd"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim sqlQuery As String = "INSERT INTO meal(name,price,quantity,totalPrice,VAT) VALUES(@name,@price,@quantity,@totalPrice,@VAT)"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)

        sqlCommand.Parameters.AddWithValue("@name", txtProductName.Text)
        sqlCommand.Parameters.AddWithValue("@price", txtProductPrice.Text)
        sqlCommand.Parameters.AddWithValue("@quantity", txtQuantity.Text)
        sqlCommand.Parameters.AddWithValue("@totalPrice", txtTotalPrice.Text)
        sqlCommand.Parameters.AddWithValue("@VAT", txtVAT.Text)


        sqlCommand.ExecuteNonQuery()
        MsgBox("The Product Has Already Added to Cart.")
        connection.Close()
    End Sub

    Function kiraVAT(ByVal x As String)
        Dim taxVAT As Decimal = 12 / 100 * x
        Return taxVAT
    End Function

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        txtTotalPrice.Text = Val(txtProductPrice.Text) * Val(txtQuantity.Text)
        txtVAT.Text = kiraVAT(Val(txtTotalPrice.Text))
    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        Dim connectionString As String = "Data Source=LAPTOP-LFAMR4GH; Initial Catalog=LabTask4;User Id=sa;Password=p@ssw0rd"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim sqlQuery As String = "SELECT * FROM meal WHERE name=@name"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)
        sqlCommand.Parameters.AddWithValue("@name", txtSearch.Text)

        Dim sqlDataReader As SqlDataReader = sqlCommand.ExecuteReader()
        'If sqlDataReader.HasRows Then
        While sqlDataReader.Read()
            txtProductName.Text = sqlDataReader("name").ToString()
            txtProductPrice.Text = sqlDataReader("price").ToString()
            txtQuantity.Text = sqlDataReader("quantity").ToString()
            txtTotalPrice.Text = sqlDataReader("totalPrice").ToString()
            txtVAT.Text = sqlDataReader("VAT").ToString()
        End While
        'Else
        '    MsgBox("0 Result Found :(")
        'End If
        connection.Close()
    End Sub

    Private Sub BTNRemove_Click(sender As Object, e As EventArgs) Handles BTNRemove.Click
        Dim connectionString As String = "Data Source=LAPTOP-LFAMR4GH; Initial Catalog=LabTask4;User Id=sa;Password=p@ssw0rd"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim sqlQuery As String = "DELETE FROM meal WHERE name=@name"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)
        sqlCommand.Parameters.AddWithValue("@name", txtSearch.Text)

        Dim rowsAffected As Integer = sqlCommand.ExecuteNonQuery
        If rowsAffected > 0 Then
            MsgBox("The Meal Has Been Removed From The Cart.")
        Else
            MsgBox("Cannot Be Removed.")
        End If

    End Sub

    Private Sub BTNAbout_Click(sender As Object, e As EventArgs) Handles BTNAbout.Click
        About.Show()
    End Sub

    Private Sub BTNHome_Click(sender As Object, e As EventArgs) Handles BTNHome.Click
        Me.Show()
    End Sub

    Private Sub BTNCustomer_Click(sender As Object, e As EventArgs) Handles BTNCustomer.Click
        Customer.Show()
    End Sub

    Private Sub BTNRestaurants_Click(sender As Object, e As EventArgs) Handles BTNRestaurants.Click
        Restaurant.Show()
        Me.Close()
    End Sub
End Class