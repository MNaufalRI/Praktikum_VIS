Imports MySqlConnector

Module DataModule_Deck

    Public Function GetAllDeck() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT d.idDeck, d.namaDeck, " &
                "p.namaPemain, p.username, " &
                "a.namaAnimal, a.rarity AS rarityAnimal, " &
                "s.namaKartu AS namaStrong, s.nilaiP, s.nilaiG, s.nilaiT, " &
                "m.namaKartu AS namaMiracle, m.jumlahMiracle, " &
                "d.totalPower, d.statusDeck, d.tanggalBuat, d.catatan " &
                "FROM tb_deck d " &
                "INNER JOIN tb_pemain      p ON d.idPemain   = p.idPemain " &
                "INNER JOIN tb_animal_card a ON d.kodeAnimal = a.kodeKartu " &
                "INNER JOIN tb_strong_card s ON d.kodeStrong = s.kodeKartu " &
                "INNER JOIN tb_miracle_card m ON d.kodeMiracle= m.kodeKartu " &
                "ORDER BY d.idDeck ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchDeck(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT d.idDeck, d.namaDeck, " &
                "p.namaPemain, p.username, " &
                "a.namaAnimal, a.rarity AS rarityAnimal, " &
                "s.namaKartu AS namaStrong, s.nilaiP, s.nilaiG, s.nilaiT, " &
                "m.namaKartu AS namaMiracle, m.jumlahMiracle, " &
                "d.totalPower, d.statusDeck, d.tanggalBuat " &
                "FROM tb_deck d " &
                "INNER JOIN tb_pemain      p ON d.idPemain   = p.idPemain " &
                "INNER JOIN tb_animal_card a ON d.kodeAnimal = a.kodeKartu " &
                "INNER JOIN tb_strong_card s ON d.kodeStrong = s.kodeKartu " &
                "INNER JOIN tb_miracle_card m ON d.kodeMiracle= m.kodeKartu " &
                "WHERE d.namaDeck     LIKE @kw " &
                "OR p.namaPemain      LIKE @kw " &
                "OR a.namaAnimal      LIKE @kw " &
                "OR s.namaKartu       LIKE @kw " &
                "OR m.namaKartu       LIKE @kw " &
                "OR d.statusDeck      LIKE @kw " &
                "ORDER BY d.idDeck ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetDeckById(idDeck As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT d.*, p.namaPemain, p.username " &
                "FROM tb_deck d " &
                "INNER JOIN tb_pemain p ON d.idPemain = p.idPemain " &
                "WHERE d.idDeck = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", idDeck)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function GetDeckByPemain(idPemain As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT d.idDeck, d.namaDeck, " &
                "a.namaAnimal, s.namaKartu AS namaStrong, " &
                "m.namaKartu AS namaMiracle, " &
                "d.totalPower, d.statusDeck " &
                "FROM tb_deck d " &
                "INNER JOIN tb_animal_card  a ON d.kodeAnimal  = a.kodeKartu " &
                "INNER JOIN tb_strong_card  s ON d.kodeStrong  = s.kodeKartu " &
                "INNER JOIN tb_miracle_card m ON d.kodeMiracle = m.kodeKartu " &
                "WHERE d.idPemain = @id ORDER BY d.idDeck ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", idPemain)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function HitungTotalPower(kodeAnimal As String,
                                      kodeStrong As String,
                                      kodeMiracle As String) As Integer
        Try
            Dim query As String =
                "SELECT a.strength, s.nilaiP, s.nilaiG, s.nilaiT, m.jumlahMiracle " &
                "FROM tb_animal_card a, tb_strong_card s, tb_miracle_card m " &
                "WHERE a.kodeKartu = @ka AND s.kodeKartu = @ks AND m.kodeKartu = @km"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ka", kodeAnimal)
                    cmd.Parameters.AddWithValue("@ks", kodeStrong)
                    cmd.Parameters.AddWithValue("@km", kodeMiracle)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim str As Integer = reader.GetInt32("strength")
                            Dim p As Integer = reader.GetInt32("nilaiP")
                            Dim g As Integer = reader.GetInt32("nilaiG")
                            Dim t As Integer = reader.GetInt32("nilaiT")
                            Dim mir As Integer = reader.GetInt32("jumlahMiracle")
                            Return str + (p + g + t) * 100 + mir * 150
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return 0
    End Function

    Public Function SimpanDeck(namaDeck As String, idPemain As Integer,
                                kodeAnimal As String, kodeStrong As String,
                                kodeMiracle As String, catatan As String) As Boolean
        Try
            ' Hitung total power otomatis
            Dim power As Integer = HitungTotalPower(kodeAnimal, kodeStrong, kodeMiracle)

            Dim query As String =
                "INSERT INTO tb_deck " &
                "(namaDeck, idPemain, kodeAnimal, kodeStrong, kodeMiracle, totalPower, catatan) " &
                "VALUES (@nama, @idP, @ka, @ks, @km, @power, @cat)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", namaDeck)
                    cmd.Parameters.AddWithValue("@idP", idPemain)
                    cmd.Parameters.AddWithValue("@ka", kodeAnimal)
                    cmd.Parameters.AddWithValue("@ks", kodeStrong)
                    cmd.Parameters.AddWithValue("@km", kodeMiracle)
                    cmd.Parameters.AddWithValue("@power", power)
                    cmd.Parameters.AddWithValue("@cat", catatan)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Update jumlah deck pemain
            UpdateTotalDeckPemain(idPemain)
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan deck: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahDeck(idDeck As Integer, namaDeck As String,
                              idPemain As Integer, kodeAnimal As String,
                              kodeStrong As String, kodeMiracle As String,
                              statusDeck As String, catatan As String) As Boolean
        Try
            Dim power As Integer = HitungTotalPower(kodeAnimal, kodeStrong, kodeMiracle)

            Dim query As String =
                "UPDATE tb_deck SET namaDeck=@nama, idPemain=@idP, " &
                "kodeAnimal=@ka, kodeStrong=@ks, kodeMiracle=@km, " &
                "totalPower=@power, statusDeck=@status, catatan=@cat " &
                "WHERE idDeck=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idDeck)
                    cmd.Parameters.AddWithValue("@nama", namaDeck)
                    cmd.Parameters.AddWithValue("@idP", idPemain)
                    cmd.Parameters.AddWithValue("@ka", kodeAnimal)
                    cmd.Parameters.AddWithValue("@ks", kodeStrong)
                    cmd.Parameters.AddWithValue("@km", kodeMiracle)
                    cmd.Parameters.AddWithValue("@power", power)
                    cmd.Parameters.AddWithValue("@status", statusDeck)
                    cmd.Parameters.AddWithValue("@cat", catatan)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ubah: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusDeck(idDeck As Integer, idPemain As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "DELETE FROM tb_deck WHERE idDeck=@id", conn)
                    cmd.Parameters.AddWithValue("@id", idDeck)
                    Dim result As Boolean = cmd.ExecuteNonQuery() > 0
                    If result Then UpdateTotalDeckPemain(idPemain)
                    Return result
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub UpdateTotalDeckPemain(idPemain As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "UPDATE tb_pemain SET totalDeck = " &
                    "(SELECT COUNT(*) FROM tb_deck WHERE idPemain = @id) " &
                    "WHERE idPemain = @id", conn)
                    cmd.Parameters.AddWithValue("@id", idPemain)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Function GetAllPemain() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(
                    "SELECT idPemain, CONCAT(namaPemain,' (@',username,')') AS labelPemain " &
                    "FROM tb_pemain ORDER BY namaPemain", conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

End Module