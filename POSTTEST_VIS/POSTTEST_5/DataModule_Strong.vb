Imports MySqlConnector

Module DataModule_Strong

    Public Function GetAllStrongCard() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeKartu, namaKartu, rarity, nilaiP, nilaiG, nilaiT, auraEffect, deskripsi " &
                "FROM tb_strong_card ORDER BY kodeKartu ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchStrongCard(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeKartu, namaKartu, rarity, nilaiP, nilaiG, nilaiT, auraEffect, deskripsi " &
                "FROM tb_strong_card WHERE kodeKartu LIKE @kw OR namaKartu LIKE @kw " &
                "OR rarity LIKE @kw OR auraEffect LIKE @kw ORDER BY kodeKartu ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetStrongByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(
                    "SELECT * FROM tb_strong_card WHERE kodeKartu=@kode", conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function KodeStrongSudahAda(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM tb_strong_card WHERE kodeKartu=@kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch
            Return True
        End Try
    End Function

    Public Function SimpanStrongCard(kode As String, nama As String,
                                      rarity As String, p As Integer,
                                      g As Integer, t As Integer,
                                      aura As String, desk As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tb_strong_card " &
                "(kodeKartu,namaKartu,rarity,nilaiP,nilaiG,nilaiT,auraEffect,deskripsi) " &
                "VALUES (@kode,@nama,@rarity,@p,@g,@t,@aura,@desk)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@rarity", rarity)
                    cmd.Parameters.AddWithValue("@p", p)
                    cmd.Parameters.AddWithValue("@g", g)
                    cmd.Parameters.AddWithValue("@t", t)
                    cmd.Parameters.AddWithValue("@aura", If(aura = "", DBNull.Value, aura))
                    cmd.Parameters.AddWithValue("@desk", desk)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahStrongCard(kode As String, nama As String,
                                    rarity As String, p As Integer,
                                    g As Integer, t As Integer,
                                    aura As String, desk As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tb_strong_card SET namaKartu=@nama, rarity=@rarity, " &
                "nilaiP=@p, nilaiG=@g, nilaiT=@t, auraEffect=@aura, deskripsi=@desk " &
                "WHERE kodeKartu=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@rarity", rarity)
                    cmd.Parameters.AddWithValue("@p", p)
                    cmd.Parameters.AddWithValue("@g", g)
                    cmd.Parameters.AddWithValue("@t", t)
                    cmd.Parameters.AddWithValue("@aura", If(aura = "", DBNull.Value, aura))
                    cmd.Parameters.AddWithValue("@desk", desk)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ubah: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusStrongCard(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "DELETE FROM tb_strong_card WHERE kodeKartu=@kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module