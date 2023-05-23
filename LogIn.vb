Imports System.Data.SqlClient

Public Class LogIn
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connectionString As String = "Data Source=LAPTOP-LFAMR4GH; Initial Catalog=LabTask4;User Id=sa;Password=p@ssw0rd"
        Dim connection As New SqlConnection(connectionString)

        Dim sqlQuery As String = "SELECT * FROM login WHERE username=@username AND email=@email AND password=@password"

        Dim sqlcommand As New SqlCommand(sqlQuery, connection)
        sqlcommand.Parameters.AddWithValue("@username", txtUsername.Text)
        sqlcommand.Parameters.AddWithValue("@email", txtEmail.Text)
        sqlcommand.Parameters.AddWithValue("@password", txtPassword.Text)

        connection.Open()

        Dim reader As SqlDataReader = sqlcommand.ExecuteReader

        If reader.HasRows Then
            While reader.Read()
                Dim username As String = reader("username").ToString()
                Dim email As String = reader("email").ToString()
                Dim password As String = reader("password").ToString()
            End While
            Me.Hide()
            MsgBox("Welcome User!")
            Customer.Show()
            Home.Show()
        Else
            MsgBox("Invalid User.")
        End If
        connection.Close()
    End Sub
End Class
