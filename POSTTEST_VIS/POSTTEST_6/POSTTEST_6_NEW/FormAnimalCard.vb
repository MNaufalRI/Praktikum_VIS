Public Class FormAnimalCard

    Private Sub Kosong()
        txtKodeKartu.Clear()
        txtNamaAnimal.Clear()
        cmbRarity.SelectedIndex = -1
        txtStrength.Clear()
        txtHealth.Clear()
        txtSkillP.Clear()
        txtSkillG.Clear()
        txtSkillT.Clear()
        txtDeskripsi.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodeKartu.Focus()
    End Sub

    Private Sub TampilData()
        dgvAnimal.DataSource = GetAllAnimalCard()
        FormatGrid()
    End Sub

    Private Sub FormatGrid()
        If dgvAnimal.Columns.Count = 0 Then Exit Sub
        dgvAnimal.Columns("kodeKartu").HeaderText = "Kode"
        dgvAnimal.Columns("namaAnimal").HeaderText = "Nama Animal"
        dgvAnimal.Columns("rarity").HeaderText = "Rarity"
        dgvAnimal.Columns("strength").HeaderText = "Strength"
        dgvAnimal.Columns("health").HeaderText = "Health"
        dgvAnimal.Columns("skillP").HeaderText = "Skill P (Power)"
        dgvAnimal.Columns("skillG").HeaderText = "Skill G (Guts)"
        dgvAnimal.Columns("skillT").HeaderText = "Skill T (Technique)"
        dgvAnimal.Columns("deskripsi").HeaderText = "Deskripsi"

        dgvAnimal.Columns("kodeKartu").Width = 60
        dgvAnimal.Columns("namaAnimal").Width = 140
        dgvAnimal.Columns("rarity").Width = 65
        dgvAnimal.Columns("strength").Width = 70
        dgvAnimal.Columns("health").Width = 60
        dgvAnimal.Columns("skillP").Width = 120
        dgvAnimal.Columns("skillG").Width = 120
        dgvAnimal.Columns("skillT").Width = 120
        dgvAnimal.Columns("deskripsi").Width = 200
    End Sub

    Private Sub FormAnimalCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRarity.Items.AddRange({"Gold", "Silver", "Bronze"})
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        Dim v1 = ValidasiTextBox(ErrorProvider1, txtKodeKartu, "Kode wajib diisi")
        Dim v2 = ValidasiTextBox(ErrorProvider1, txtNamaAnimal, "Nama wajib diisi")
        Dim v3 = ValidasiComboBox(ErrorProvider1, cmbRarity, "Pilih Rarity")
        Dim v4 = ValidasiStat(ErrorProvider1, txtStrength, "Strength")
        Dim v5 = ValidasiStat(ErrorProvider1, txtHealth, "Health")
        Dim v6 = ValidasiTextBox(ErrorProvider1, txtSkillP, "Skill P wajib diisi")
        Dim v7 = ValidasiTextBox(ErrorProvider1, txtSkillG, "Skill G wajib diisi")
        Dim v8 = ValidasiTextBox(ErrorProvider1, txtSkillT, "Skill T wajib diisi")
        If Not (v1 And v2 And v3 And v4 And v5 And v6 And v7 And v8) Then Exit Sub

        Dim kode As String = txtKodeKartu.Text.Trim().ToUpper()
        If KodeAnimalSudahAda(kode) Then
            MessageBox.Show("Kode '" & kode & "' sudah ada!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SimpanAnimalCard(kode, txtNamaAnimal.Text.Trim(), cmbRarity.Text,
                            CInt(txtStrength.Text), CInt(txtHealth.Text),
                            txtSkillP.Text.Trim(), txtSkillG.Text.Trim(),
                            txtSkillT.Text.Trim(), txtDeskripsi.Text.Trim()) Then
            MessageBox.Show("Animal Card berhasil disimpan!", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData() : Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        Dim v1 = ValidasiTextBox(ErrorProvider1, txtKodeKartu, "Kode wajib diisi")
        Dim v2 = ValidasiTextBox(ErrorProvider1, txtNamaAnimal, "Nama wajib diisi")
        Dim v3 = ValidasiComboBox(ErrorProvider1, cmbRarity, "Pilih Rarity")
        Dim v4 = ValidasiStat(ErrorProvider1, txtStrength, "Strength")
        Dim v5 = ValidasiStat(ErrorProvider1, txtHealth, "Health")
        If Not (v1 And v2 And v3 And v4 And v5) Then Exit Sub

        If MessageBox.Show("Ubah data kartu ini?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        If UbahAnimalCard(txtKodeKartu.Text.Trim().ToUpper(),
                          txtNamaAnimal.Text.Trim(), cmbRarity.Text,
                          CInt(txtStrength.Text), CInt(txtHealth.Text),
                          txtSkillP.Text.Trim(), txtSkillG.Text.Trim(),
                          txtSkillT.Text.Trim(), txtDeskripsi.Text.Trim()) Then
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

        If MessageBox.Show("Hapus Animal Card '" & txtNamaAnimal.Text & "'?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If HapusAnimalCard(txtKodeKartu.Text.Trim().ToUpper()) Then
                MessageBox.Show("Data berhasil dihapus!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData() : Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong() : TampilData()
    End Sub

    Private Sub dgvAnimal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnimal.CellClick
        If e.RowIndex >= 0 Then
            With dgvAnimal.Rows(e.RowIndex)
                txtKodeKartu.Text = .Cells("kodeKartu").Value.ToString()
                txtNamaAnimal.Text = .Cells("namaAnimal").Value.ToString()
                cmbRarity.Text = .Cells("rarity").Value.ToString()
                txtStrength.Text = .Cells("strength").Value.ToString()
                txtHealth.Text = .Cells("health").Value.ToString()
                txtSkillP.Text = .Cells("skillP").Value.ToString()
                txtSkillG.Text = .Cells("skillG").Value.ToString()
                txtSkillT.Text = .Cells("skillT").Value.ToString()
                txtDeskripsi.Text = If(IsDBNull(.Cells("deskripsi").Value), "",
                    .Cells("deskripsi").Value.ToString())
            End With
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvAnimal.DataSource = SearchAnimalCard(txtSearch.Text.Trim())
            FormatGrid()
        End If
    End Sub

    Private Sub txtKodeKartu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeKartu.KeyPress
        HanyaAlphanumeric(e)
        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = GetAnimalByKode(txtKodeKartu.Text.Trim().ToUpper())
            If dt.Rows.Count > 0 Then
                txtNamaAnimal.Text = dt.Rows(0)("namaAnimal").ToString()
                cmbRarity.Text = dt.Rows(0)("rarity").ToString()
                txtStrength.Text = dt.Rows(0)("strength").ToString()
                txtHealth.Text = dt.Rows(0)("health").ToString()
                txtSkillP.Text = dt.Rows(0)("skillP").ToString()
                txtSkillG.Text = dt.Rows(0)("skillG").ToString()
                txtSkillT.Text = dt.Rows(0)("skillT").ToString()
            End If
            txtNamaAnimal.Focus()
        End If
    End Sub

End Class