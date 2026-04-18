Public Class FormPemain

    Private idPemainTerpilih As Integer = 0

    Private Sub Kosong()
        txtIdPemain.Clear()
        txtNama.Clear()
        txtUsername.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        lblStatDeck.Text = "Total Deck: —"
        dgvDeckMilik.DataSource = Nothing
        idPemainTerpilih = 0
        txtNama.Focus()
    End Sub

    Private Sub TampilData()
        dgvPemain.DataSource = GetAllPemainFull()
        FormatGridPemain()
    End Sub

    Private Sub FormatGridPemain()
        If dgvPemain.Columns.Count = 0 Then Exit Sub
        dgvPemain.Columns("idPemain").HeaderText = "ID"
        dgvPemain.Columns("namaPemain").HeaderText = "Nama Pemain"
        dgvPemain.Columns("username").HeaderText = "Username"
        dgvPemain.Columns("totalDeck").HeaderText = "Deck"
        dgvPemain.Columns("totalMenang").HeaderText = "Menang"
        dgvPemain.Columns("totalKalah").HeaderText = "Kalah"
        dgvPemain.Columns("tanggalDaftar").HeaderText = "Daftar"
        dgvPemain.Columns("idPemain").Width = 40
        dgvPemain.Columns("namaPemain").Width = 140
        dgvPemain.Columns("username").Width = 100
        dgvPemain.Columns("totalDeck").Width = 50
        dgvPemain.Columns("totalMenang").Width = 60
        dgvPemain.Columns("totalKalah").Width = 60
        dgvPemain.Columns("tanggalDaftar").Width = 90
    End Sub

    Private Sub FormPemain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        Dim v1 = ValidasiTextBox(ErrorProvider1, txtNama, "Nama wajib diisi")
        Dim v2 = ValidasiTextBox(ErrorProvider1, txtUsername, "Username wajib diisi")
        If Not (v1 And v2) Then Exit Sub

        If UsernameSudahAda(txtUsername.Text.Trim()) Then
            ErrorProvider1.SetError(txtUsername, "Username sudah digunakan!")
            Exit Sub
        End If

        If SimpanPemain(txtNama.Text.Trim(), txtUsername.Text.Trim()) Then
            MessageBox.Show("Pemain berhasil didaftarkan!", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData() : Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idPemainTerpilih = 0 Then
            MessageBox.Show("Pilih pemain dari tabel!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        End If
        ErrorProvider1.Clear()
        Dim v1 = ValidasiTextBox(ErrorProvider1, txtNama, "Nama wajib diisi")
        Dim v2 = ValidasiTextBox(ErrorProvider1, txtUsername, "Username wajib diisi")
        If Not (v1 And v2) Then Exit Sub

        If UsernameSudahAda(txtUsername.Text.Trim(), idPemainTerpilih) Then
            ErrorProvider1.SetError(txtUsername, "Username sudah digunakan!")
            Exit Sub
        End If

        If MessageBox.Show("Ubah data pemain ini?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        If UbahPemain(idPemainTerpilih, txtNama.Text.Trim(), txtUsername.Text.Trim()) Then
            MessageBox.Show("Data pemain berhasil diubah!", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData() : Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idPemainTerpilih = 0 Then
            MessageBox.Show("Pilih pemain dari tabel!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        End If
        If MessageBox.Show("Hapus pemain '" & txtNama.Text & "'?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If HapusPemain(idPemainTerpilih) Then
                MessageBox.Show("Pemain berhasil dihapus!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData() : Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong() : TampilData()
    End Sub

    Private Sub dgvPemain_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvPemain.CellClick
        If e.RowIndex >= 0 Then
            With dgvPemain.Rows(e.RowIndex)
                idPemainTerpilih = CInt(.Cells("idPemain").Value)
                txtIdPemain.Text = idPemainTerpilih.ToString()
                txtNama.Text = .Cells("namaPemain").Value.ToString()
                txtUsername.Text = .Cells("username").Value.ToString()
                lblStatDeck.Text = "Total Deck: " & .Cells("totalDeck").Value.ToString()
            End With
            ' Tampilkan deck milik pemain ini di grid bawah
            dgvDeckMilik.DataSource = GetDeckByPemain(idPemainTerpilih)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then TampilData() _
        Else dgvPemain.DataSource = SearchPemain(txtSearch.Text.Trim()) : FormatGridPemain()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar = "_"c _
           OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class