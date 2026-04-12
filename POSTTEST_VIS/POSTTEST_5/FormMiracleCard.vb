Public Class FormMiracleCard

    Private Sub Kosong()
        txtKodeKartu.Clear() : txtNamaKartu.Clear()
        cmbRarity.SelectedIndex = -1
        txtJumlahMiracle.Clear() : txtEfekMiracle.Clear()
        txtDeskripsi.Clear() : txtSearch.Clear()
        ErrorProvider1.Clear() : txtKodeKartu.Focus()
    End Sub

    Private Sub TampilData()
        dgvMiracle.DataSource = GetAllMiracleCard()
        FormatGrid()
    End Sub

    Private Sub FormatGrid()
        If dgvMiracle.Columns.Count = 0 Then Exit Sub
        dgvMiracle.Columns("kodeKartu").HeaderText = "Kode"
        dgvMiracle.Columns("namaKartu").HeaderText = "Nama Kartu"
        dgvMiracle.Columns("rarity").HeaderText = "Rarity"
        dgvMiracle.Columns("jumlahMiracle").HeaderText = "Miracle Pts"
        dgvMiracle.Columns("efekMiracle").HeaderText = "Efek"
        dgvMiracle.Columns("deskripsi").HeaderText = "Deskripsi"
    End Sub

    Private Sub FormMiracleCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRarity.Items.AddRange({"Gold", "Silver", "Bronze"})
        TampilData() : Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        Dim v1 = ValidasiTextBox(ErrorProvider1, txtKodeKartu, "Kode wajib diisi")
        Dim v2 = ValidasiTextBox(ErrorProvider1, txtNamaKartu, "Nama wajib diisi")
        Dim v3 = ValidasiComboBox(ErrorProvider1, cmbRarity, "Pilih Rarity")
        Dim v4 = ValidasiMiracle(ErrorProvider1, txtJumlahMiracle)
        Dim v5 = ValidasiTextBox(ErrorProvider1, txtEfekMiracle, "Efek wajib diisi")
        If Not (v1 And v2 And v3 And v4 And v5) Then Exit Sub

        Dim kode As String = txtKodeKartu.Text.Trim().ToUpper()
        If KodeMiracleSudahAda(kode) Then
            MessageBox.Show("Kode sudah ada!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        End If

        If SimpanMiracleCard(kode, txtNamaKartu.Text.Trim(), cmbRarity.Text,
                             CInt(txtJumlahMiracle.Text), txtEfekMiracle.Text.Trim(),
                             txtDeskripsi.Text.Trim()) Then
            MessageBox.Show("Miracle Card berhasil disimpan!", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData() : Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtKodeKartu.Text.Trim() = "" Then
            MessageBox.Show("Pilih kartu dari tabel!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        End If
        If MessageBox.Show("Ubah Miracle Card ini?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
        If UbahMiracleCard(txtKodeKartu.Text.Trim().ToUpper(),
                           txtNamaKartu.Text.Trim(), cmbRarity.Text,
                           CInt(txtJumlahMiracle.Text), txtEfekMiracle.Text.Trim(),
                           txtDeskripsi.Text.Trim()) Then
            MessageBox.Show("Data berhasil diubah!", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData() : Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeKartu.Text.Trim() = "" Then
            MessageBox.Show("Pilih kartu dari tabel!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        End If
        If MessageBox.Show("Hapus Miracle Card ini?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If HapusMiracleCard(txtKodeKartu.Text.Trim().ToUpper()) Then
                MessageBox.Show("Data berhasil dihapus!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData() : Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong() : TampilData()
    End Sub

    Private Sub dgvMiracle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMiracle.CellClick
        If e.RowIndex >= 0 Then
            With dgvMiracle.Rows(e.RowIndex)
                txtKodeKartu.Text = .Cells("kodeKartu").Value.ToString()
                txtNamaKartu.Text = .Cells("namaKartu").Value.ToString()
                cmbRarity.Text = .Cells("rarity").Value.ToString()
                txtJumlahMiracle.Text = .Cells("jumlahMiracle").Value.ToString()
                txtEfekMiracle.Text = .Cells("efekMiracle").Value.ToString()
                txtDeskripsi.Text = If(IsDBNull(.Cells("deskripsi").Value), "",
                    .Cells("deskripsi").Value.ToString())
            End With
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then TampilData() _
        Else dgvMiracle.DataSource = SearchMiracleCard(txtSearch.Text.Trim()) : FormatGrid()
    End Sub

    Private Sub txtJumlahMiracle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahMiracle.KeyPress
        HanyaAngka(e)
    End Sub

End Class