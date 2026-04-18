Imports MySqlConnector

Module DataModule_Miracle

    Public Function GetAllMiracleCard() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeKartu, namaKartu, rarity, jumlahMiracle, efekMiracle, deskripsi " &
                "FROM tb_miracle_card ORDER BY kodeKartu ASC"
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

    Public Function SearchMiracleCard(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeKartu, namaKartu, rarity, jumlahMiracle, efekMiracle, deskripsi " &
                "FROM tb_miracle_card WHERE kodeKartu LIKE @kw OR namaKartu LIKE @kw " &
                "OR rarity LIKE @kw OR efekMiracle LIKE @kw ORDER BY kodeKartu ASC"
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

    Public Function GetMiracleByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(
                    "SELECT * FROM tb_miracle_card WHERE kodeKartu=@kode", conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function KodeMiracleSudahAda(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM tb_miracle_card WHERE kodeKartu=@kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch
            Return True
        End Try
    End Function

    Public Function SimpanMiracleCard(kode As String, nama As String,
                                       rarity As String, jumlah As Integer,
                                       efek As String, desk As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tb_miracle_card " &
                "(kodeKartu,namaKartu,rarity,jumlahMiracle,efekMiracle,deskripsi) " &
                "VALUES (@kode,@nama,@rarity,@jumlah,@efek,@desk)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@rarity", rarity)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@efek", efek)
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

    Public Function UbahMiracleCard(kode As String, nama As String,
                                     rarity As String, jumlah As Integer,
                                     efek As String, desk As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tb_miracle_card SET namaKartu=@nama, rarity=@rarity, " &
                "jumlahMiracle=@jumlah, efekMiracle=@efek, deskripsi=@desk " &
                "WHERE kodeKartu=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@rarity", rarity)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@efek", efek)
                    cmd.Parameters.AddWithValue("@desk", desk)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ubah: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusMiracleCard(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "DELETE FROM tb_miracle_card WHERE kodeKartu=@kode", conn)
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