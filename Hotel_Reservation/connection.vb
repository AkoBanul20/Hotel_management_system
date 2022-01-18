Imports System.Data.SqlClient
Module connection
    Public cm As SqlCommand
    Public dr As SqlDataReader

    Public Function connect() As SqlConnection
        connect = New SqlConnection
        connect.ConnectionString = "Data Source=DESKTOP-QIRU3G9\SQLEXPRESS;Initial Catalog=hotel_management_db;Integrated Security=True"
        connect.Open()
        Return connect
    End Function

End Module
