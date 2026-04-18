Imports MySqlConnector

Module DataModule_Animal

    Public Function GetAllAnimalCard() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeKartu, namaAnimal, rarity, strength, health, " &
                "skillP, skillG, skillT, deskripsi " &
                "FROM tb_animal_card ORDER BY kodeKartu ASC"
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

    Public Function SearchAnimalCard(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeKartu, namaAnimal, rarity, strength, health, " &
                "skillP, skillG, skillT, deskripsi FROM tb_animal_card " &
                "WHERE kodeKartu LIKE @kw OR namaAnimal LIKE @kw " &
                "OR rarity LIKE @kw OR skillP LIKE @kw " &
                "OR skillG LIKE @kw OR skillT LIKE @kw " &
                "ORDER BY kodeKartu ASC"
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

    Public Function GetAnimalByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT * FROM tb_animal_card WHERE kodeKartu = @kode"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeAnimalSudahAda(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM tb_animal_card WHERE kodeKartu = @kode", conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanAnimalCard(kode As String, nama As String,
                                      rarity As String, strength As Integer,
                                      health As Integer, skillP As String,
                                      skillG As String, skillT As String,
                                      deskripsi As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tb_animal_card " &
                "(kodeKartu, namaAnimal, rarity, strength, health, skillP, skillG, skillT, deskripsi) " &
                "VALUES (@kode, @nama, @rarity, @strength, @health, @skillP, @skillG, @skillT, @desk)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@rarity", rarity)
                    cmd.Parameters.AddWithValue("@strength", strength)
                    cmd.Parameters.AddWithValue("@health", health)
                    cmd.Parameters.AddWithValue("@skillP", skillP)
                    cmd.Parameters.AddWithValue("@skillG", skillG)
                    cmd.Parameters.AddWithValue("@skillT", skillT)
                    cmd.Parameters.AddWithValue("@desk", deskripsi)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahAnimalCard(kode As String, nama As String,
                                    rarity As String, strength As Integer,
                                    health As Integer, skillP As String,
                                    skillG As String, skillT As String,
                                    deskripsi As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tb_animal_card SET namaAnimal=@nama, rarity=@rarity, " &
                "strength=@strength, health=@health, skillP=@skillP, " &
                "skillG=@skillG, skillT=@skillT, deskripsi=@desk " &
                "WHERE kodeKartu=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@rarity", rarity)
                    cmd.Parameters.AddWithValue("@strength", strength)
                    cmd.Parameters.AddWithValue("@health", health)
                    cmd.Parameters.AddWithValue("@skillP", skillP)
                    cmd.Parameters.AddWithValue("@skillG", skillG)
                    cmd.Parameters.AddWithValue("@skillT", skillT)
                    cmd.Parameters.AddWithValue("@desk", deskripsi)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ubah: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusAnimalCard(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "DELETE FROM tb_animal_card WHERE kodeKartu = @kode", conn)
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