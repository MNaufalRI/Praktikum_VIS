Public Class FormStrongCard

    Private Sub Kosong()
        txtKodeKartu.Clear() : txtNamaKartu.Clear()
        cmbRarity.SelectedIndex = -1
        txtNilaiP.Clear() : txtNilaiG.Clear() : txtNilaiT.Clear()
        txtAura.Clear() : txtDeskripsi.Clear()
        txtSearch.Clear() : ErrorProvider1.Clear()
        txtKodeKartu.Focus()
    End Sub

    Private Sub TampilData()
        dgvStrong.DataSource = GetAllStrongCard()
        FormatGrid()
    End Sub

    Private Sub FormatGrid()
        If dgvStrong.Columns.Count = 0 Then Exit Sub
        dgvStrong.Columns("kodeKartu").HeaderText = "Kode"
        dgvStrong.Columns("namaKartu").HeaderText = "Nama Kartu"
        dgvStrong.Columns("rarity").HeaderText = "Rarity"
        dgvStrong.Columns("nilaiP").HeaderText = "P (Power)"
        dgvStrong.Columns("nilaiG").HeaderText = "G (Guts)"
        dgvStrong.Columns("nilaiT").HeaderText = "T (Technique)"
        dgvStrong.Columns("auraEffect").HeaderText = "Aura Effect"
        dgvStrong.Columns("deskripsi").HeaderText = "Deskripsi"
    End Sub

    Private Sub FormStrongCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRarity.Items.AddRange({"Gold", "Silver", "Bronze"})
        TampilData() : Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        Dim v1 = ValidasiTextBox(ErrorProvider1, txtKodeKartu, "Kode wajib diisi")
        Dim v2 = ValidasiTextBox(ErrorProvider1, txtNamaKartu, "Nama wajib diisi")
        Dim v3 = ValidasiComboBox(ErrorProvider1, cmbRarity, "Pilih Rarity")
        Dim v4 = ValidasiNilai1to5(ErrorProvider1, txtNilaiP, "Power")
        Dim v5 = ValidasiNilai1to5(ErrorProvider1, txtNilaiG, "Guts")
        Dim v6 = ValidasiNilai1to5(ErrorProvider1, txtNilaiT, "Technique")
        If Not (v1 And v2 And v3 And v4 And v5 And v6) Then Exit Sub

        Dim kode As String = txtKodeKartu.Text.Trim().ToUpper()
        If KodeStrongSudahAda(kode) Then
            MessageBox.Show("Kode sudah ada!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        End If

        If SimpanStrongCard(kode, txtNamaKartu.Text.Trim(), cmbRarity.Text,
                            CInt(txtNilaiP.Text), CInt(txtNilaiG.Text), CInt(txtNilaiT.Text),
                            txtAura.Text.Trim(), txtDeskripsi.Text.Trim()) Then
            MessageBox.Show("Strong Card berhasil disimpan!", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData() : Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If txtKodeKartu.Text.Trim() = "" Then
            MessageBox.Show("Pilih kartu dari tabel!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        End If
        If MessageBox.Show("Ubah data ini?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
        If UbahStrongCard(txtKodeKartu.Text.Trim().ToUpper(),
                          txtNamaKartu.Text.Trim(), cmbRarity.Text,
                          CInt(txtNilaiP.Text), CInt(txtNilaiG.Text), CInt(txtNilaiT.Text),
                          txtAura.Text.Trim(), txtDeskripsi.Text.Trim()) Then
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
        If MessageBox.Show("Hapus Strong Card ini?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If HapusStrongCard(txtKodeKartu.Text.Trim().ToUpper()) Then
                MessageBox.Show("Data berhasil dihapus!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData() : Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong() : TampilData()
    End Sub

    Private Sub dgvStrong_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStrong.CellClick
        If e.RowIndex >= 0 Then
            With dgvStrong.Rows(e.RowIndex)
                txtKodeKartu.Text = .Cells("kodeKartu").Value.ToString()
                txtNamaKartu.Text = .Cells("namaKartu").Value.ToString()
                cmbRarity.Text = .Cells("rarity").Value.ToString()
                txtNilaiP.Text = .Cells("nilaiP").Value.ToString()
                txtNilaiG.Text = .Cells("nilaiG").Value.ToString()
                txtNilaiT.Text = .Cells("nilaiT").Value.ToString()
                txtAura.Text = If(IsDBNull(.Cells("auraEffect").Value), "",
                    .Cells("auraEffect").Value.ToString())
                txtDeskripsi.Text = If(IsDBNull(.Cells("deskripsi").Value), "",
                    .Cells("deskripsi").Value.ToString())
            End With
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then TampilData() _
        Else dgvStrong.DataSource = SearchStrongCard(txtSearch.Text.Trim()) : FormatGrid()
    End Sub

    Private Sub txtNilaiP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiP.KeyPress
        HanyaAngka(e)
    End Sub
    Private Sub txtNilaiG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiG.KeyPress
        HanyaAngka(e)
    End Sub
    Private Sub txtNilaiT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilaiT.KeyPress
        HanyaAngka(e)
    End Sub

End Class