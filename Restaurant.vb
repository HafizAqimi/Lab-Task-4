Imports System.Data.SqlClient

Public Class Restaurant
    Private Sub BTNHome_Click(sender As Object, e As EventArgs) Handles BTNHome.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub BTNAbout_Click(sender As Object, e As EventArgs) Handles BTNAbout.Click
        About.Show()
    End Sub

    Private Sub BTNRestaurants_Click(sender As Object, e As EventArgs) Handles BTNRestaurants.Click
        Me.Show()
    End Sub

    Private Sub BTNCustomer_Click(sender As Object, e As EventArgs) Handles BTNCustomer.Click
        Customer.Show()
    End Sub

    Private Sub BTNReservation_Click(sender As Object, e As EventArgs) Handles BTNReservation.Click
        Dim connectionString As String = "Data Source=LAPTOP-LFAMR4GH; Initial Catalog=LabTask4;User Id=sa;Password=p@ssw0rd"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim sqlQuery As String = "SELECT * FROM restaurants WHERE name=@name"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)
        sqlCommand.Parameters.AddWithValue("@name", txtSearch.Text)

        Dim sqlDataReader As SqlDataReader = sqlCommand.ExecuteReader()
        'If sqlDataReader.HasRows Then
        While sqlDataReader.Read()
            txtRestName.Text = sqlDataReader("name").ToString()
            txtRestLocation.Text = sqlDataReader("location").ToString()
        End While
        'Else
        '    MsgBox("0 Result Found :(")
        'End If
        connection.Close()
    End Sub

    Private Sub BTNSearch_Click(sender As Object, e As EventArgs) Handles BTNSearch.Click
        Dim connectionString As String = "Data Source=LAPTOP-LFAMR4GH; Initial Catalog=LabTask4;User Id=sa;Password=p@ssw0rd"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim sqlQuery As String = "SELECT * FROM restaurants WHERE name=@name"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)
        sqlCommand.Parameters.AddWithValue("@name", txtSearch.Text)

        Dim sqlDataReader As SqlDataReader = sqlCommand.ExecuteReader()
        'If sqlDataReader.HasRows Then
        While sqlDataReader.Read()
            txtRestaurantName.Text = sqlDataReader("name").ToString()
            txtLocation.Text = sqlDataReader("location").ToString()
            txtCuisine.Text = sqlDataReader("cuisine").ToString()
            txtRating.Text = sqlDataReader("rating").ToString()
            txtPopularDish.Text = sqlDataReader("popularDish").ToString()
        End While
        'Else
        '    MsgBox("0 Result Found :(")
        'End If
        connection.Close()
    End Sub

    Private Sub BTNCancel_Click(sender As Object, e As EventArgs) Handles BTNCancel.Click
        Dim connectionString As String = "Data Source=LAPTOP-LFAMR4GH; Initial Catalog=LabTask4;User Id=sa;Password=p@ssw0rd"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim sqlQuery As String = "DELETE FROM restaurants WHERE name=@name"
        Dim sqlCommand As New SqlCommand(sqlQuery, connection)
        sqlCommand.Parameters.AddWithValue("@name", txtSearch.Text)

        Dim rowsAffected As Integer = sqlCommand.ExecuteNonQuery
        If rowsAffected > 0 Then
            MsgBox("Reservation Has Been Cancelled.")
        Else
            MsgBox("Cannot Be Removed.")
        End If
    End Sub

    Private Sub BTNConfirm_Click(sender As Object, e As EventArgs) Handles BTNConfirm.Click
        Dim connectionString As String = "Data Source=LAPTOP-LFAMR4GH; Initial Catalog=LabTask4;User Id=sa;Password=p@ssw0rd"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim sqlQuery As String = "INSERT INTO customers(CustomerID,FirstName,LastName,ReservationDate,RestaurantName,RestaurantLocation) 
VALUES(@CustomerID,@FirstName,@LastName,@ReservationDate,@RestaurantName,@RestaurantLocation)"

        Dim sqlCommand As New SqlCommand(sqlQuery, connection)

        sqlCommand.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text)
        sqlCommand.Parameters.AddWithValue("@FirstName", txtFName.Text)
        sqlCommand.Parameters.AddWithValue("@LastName", txtLName.Text)

        sqlCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@ReservationDate", .SqlDbType = SqlDbType.Date, .Value = txtReseDate.Text})
        'sqlCommand.Parameters.AddWithValue("@ReservationDate", txtReseDate.Text)

        sqlCommand.Parameters.AddWithValue("@RestaurantName", txtRestName.Text)
        sqlCommand.Parameters.AddWithValue("@RestaurantLocation", txtRestLocation.Text)

        sqlCommand.ExecuteNonQuery()
        MsgBox("The Reservation Has Been Confirmed.")
        connection.Close()


    End Sub
End Class