Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connectionString As String = "Data Source=WMATHURA-WS01\SQLEXPRESS;Initial Catalog=Student;Integrated Security=true"
        Dim queryString As String = "INSERT INTO Registration (FName, Lname) values (@fn,@ln)"
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim command As New SqlCommand(queryString, connection)
                command.Parameters.AddWithValue("@fn", TextBox1.Text)
                command.Parameters.AddWithValue("@ln", TextBox2.Text)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Exception : " + ex.ToString)
        End Try

        GridView1.DataBind()

    End Sub
End Class




