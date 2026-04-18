Imports MySqlConnector

Module DataModule_Pemain

    Public Function GetAllPemainFull() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(
                    "SELECT idPemain, namaPemain, username, totalDeck, " &
                    "totalMenang, totalKalah, tanggalDaftar FROM tb_pemain " &
                    "ORDER BY idPemain ASC", conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPemain(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(
                    "SELECT idPemain, namaPemain, username, totalDeck, " &
                    "totalMenang, totalKalah, tanggalDaftar FROM tb_pemain " &
                    "WHERE namaPemain LIKE @kw OR username LIKE @kw " &
                    "ORDER BY idPemain ASC", conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function GetPemainById(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(
                    "SELECT * FROM tb_pemain WHERE idPemain=@id", conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function UsernameSudahAda(username As String,
                                      Optional excludeId As Integer = 0) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim q As String = "SELECT COUNT(*) FROM tb_pemain WHERE username=@un"
                If excludeId > 0 Then q &= " AND idPemain <> @id"
                Using cmd As New MySqlCommand(q, conn)
                    cmd.Parameters.AddWithValue("@un", username)
                    If excludeId > 0 Then cmd.Parameters.AddWithValue("@id", excludeId)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch
            Return True
        End Try
    End Function

    Public Function SimpanPemain(nama As String, username As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "INSERT INTO tb_pemain (namaPemain, username) VALUES (@nama, @un)", conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@un", username)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPemain(id As Integer, nama As String,
                                username As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "UPDATE tb_pemain SET namaPemain=@nama, username=@un WHERE idPemain=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@un", username)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ubah: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPemain(id As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                ' Cek dulu apakah pemain masih punya deck
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM tb_deck WHERE idPemain=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                        MessageBox.Show("Pemain masih memiliki Deck aktif! Hapus deck-nya dulu.",
                            "Tidak Bisa Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                End Using
                Using cmd As New MySqlCommand(
                    "DELETE FROM tb_pemain WHERE idPemain=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module