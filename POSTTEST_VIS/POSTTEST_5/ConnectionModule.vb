Imports MySqlConnector

Module ConnectionModule

    Public ReadOnly ConnectionString As String =
        "Server=localhost;Port=3306;Database=db_animal_kaiser;User ID=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

    Public Function TestConnection() As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module