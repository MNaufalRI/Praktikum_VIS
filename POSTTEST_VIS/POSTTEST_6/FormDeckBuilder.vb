Public Class FormDeckBuilder

    Private idDeckTerpilih As Integer = 0
    Private idPemainTerpilih As Integer = 0

    ' ── HELPERS ──────────────────────────────────

    Private Sub Kosong()
        txtIdDeck.Clear()
        txtNamaDeck.Clear()
        cmbPemain.SelectedIndex = -1
        cmbAnimalCard.SelectedIndex = -1
        cmbStrongCard.SelectedIndex = -1
        cmbMiracleCard.SelectedIndex = -1
        cmbStatusDeck.SelectedIndex = 0
        txtCatatan.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        lblAnimalInfo.Text = "Pilih Animal Card..."
        lblStrongInfo.Text = "Pilih Strong Card..."
        lblMiracleInfo.Text = "Pilih Miracle Card..."
        lblTotalPower.Text = "TOTAL POWER: —"
        prgPower.Value = 0
        idDeckTerpilih = 0
        idPemainTerpilih = 0
        txtNamaDeck.Focus()
    End Sub

    Private Sub TampilData()
        dgvDeck.DataSource = GetAllDeck()
        FormatGrid()
    End Sub

    Private Sub FormatGrid()
        If dgvDeck.Columns.Count = 0 Then Exit Sub
        dgvDeck.Columns("idDeck").HeaderText = "ID"
        dgvDeck.Columns("namaDeck").HeaderText = "Nama Deck"
        dgvDeck.Columns("namaPemain").HeaderText = "Pemain"
        dgvDeck.Columns("username").HeaderText = "Username"
        dgvDeck.Columns("namaAnimal").HeaderText = "Animal Card"
        dgvDeck.Columns("rarityAnimal").HeaderText = "Rarity"
        dgvDeck.Columns("namaStrong").HeaderText = "Strong Card"
        dgvDeck.Columns("nilaiP").HeaderText = "P"
        dgvDeck.Columns("nilaiG").HeaderText = "G"
        dgvDeck.Columns("nilaiT").HeaderText = "T"
        dgvDeck.Columns("namaMiracle").HeaderText = "Miracle Card"
        dgvDeck.Columns("jumlahMiracle").HeaderText = "Miracle"
        dgvDeck.Columns("totalPower").HeaderText = "TOTAL POWER"
        dgvDeck.Columns("statusDeck").HeaderText = "Status"
        dgvDeck.Columns("tanggalBuat").HeaderText = "Dibuat"
        dgvDeck.Columns("catatan").HeaderText = "Catatan"

        dgvDeck.Columns("idDeck").Width = 40
        dgvDeck.Columns("namaDeck").Width = 130
        dgvDeck.Columns("namaPemain").Width = 120
        dgvDeck.Columns("username").Width = 90
        dgvDeck.Columns("namaAnimal").Width = 120
        dgvDeck.Columns("rarityAnimal").Width = 60
        dgvDeck.Columns("namaStrong").Width = 110
        dgvDeck.Columns("nilaiP").Width = 30
        dgvDeck.Columns("nilaiG").Width = 30
        dgvDeck.Columns("nilaiT").Width = 30
        dgvDeck.Columns("namaMiracle").Width = 110
        dgvDeck.Columns("jumlahMiracle").Width = 55
        dgvDeck.Columns("totalPower").Width = 80
        dgvDeck.Columns("statusDeck").Width = 65
        dgvDeck.Columns("tanggalBuat").Width = 80
        dgvDeck.Columns("catatan").Width = 150
    End Sub

    ' Auto-update label info saat ComboBox berubah
    Private Sub UpdateInfoPanels()
        ' Animal Card info
        If cmbAnimalCard.SelectedValue IsNot Nothing Then
            Dim dtA As DataTable = GetAnimalByKode(cmbAnimalCard.SelectedValue.ToString())
            If dtA.Rows.Count > 0 Then
                lblAnimalInfo.Text = String.Format(
                    "STR: {0}  HP: {1}  |  P: {2}  G: {3}  T: {4}",
                    dtA.Rows(0)("strength"), dtA.Rows(0)("health"),
                    dtA.Rows(0)("skillP"), dtA.Rows(0)("skillG"), dtA.Rows(0)("skillT"))
                lblAnimalRarity.Text = "Rarity: " & dtA.Rows(0)("rarity").ToString()
            End If
        End If

        ' Strong Card info
        If cmbStrongCard.SelectedValue IsNot Nothing Then
            Dim dtS As DataTable = GetStrongByKode(cmbStrongCard.SelectedValue.ToString())
            If dtS.Rows.Count > 0 Then
                lblStrongInfo.Text = String.Format(
                    "P={0}  G={1}  T={2}  |  Aura: {3}",
                    dtS.Rows(0)("nilaiP"), dtS.Rows(0)("nilaiG"),
                    dtS.Rows(0)("nilaiT"),
                    If(IsDBNull(dtS.Rows(0)("auraEffect")), "—", dtS.Rows(0)("auraEffect")))
            End If
        End If

        ' Miracle Card info
        If cmbMiracleCard.SelectedValue IsNot Nothing Then
            Dim dtM As DataTable = GetMiracleByKode(cmbMiracleCard.SelectedValue.ToString())
            If dtM.Rows.Count > 0 Then
                lblMiracleInfo.Text = String.Format(
                    "Miracle: {0} pts  |  Efek: {1}",
                    dtM.Rows(0)("jumlahMiracle"), dtM.Rows(0)("efekMiracle"))
            End If
        End If

        ' Hitung Total Power real-time
        If cmbAnimalCard.SelectedValue IsNot Nothing AndAlso
           cmbStrongCard.SelectedValue IsNot Nothing AndAlso
           cmbMiracleCard.SelectedValue IsNot Nothing Then

            Dim power As Integer = HitungTotalPower(
                cmbAnimalCard.SelectedValue.ToString(),
                cmbStrongCard.SelectedValue.ToString(),
                cmbMiracleCard.SelectedValue.ToString())

            lblTotalPower.Text = "TOTAL POWER: " & power.ToString("N0")
            ' ProgressBar max = 3000 (kira-kira power maksimal)
            prgPower.Value = Math.Min(power, 3000)
        End If
    End Sub

    ' ── FORM LOAD ────────────────────────────────

    Private Sub FormDeckBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox Pemain
        Dim dtPemain As DataTable = GetAllPemain()
        cmbPemain.DataSource = dtPemain
        cmbPemain.DisplayMember = "labelPemain"
        cmbPemain.ValueMember = "idPemain"
        cmbPemain.SelectedIndex = -1

        ' Isi ComboBox Animal Card
        Dim dtAnimal As DataTable = GetAllAnimalCard()
        cmbAnimalCard.DataSource = dtAnimal
        cmbAnimalCard.DisplayMember = "namaAnimal"
        cmbAnimalCard.ValueMember = "kodeKartu"
        cmbAnimalCard.SelectedIndex = -1

        ' Isi ComboBox Strong Card
        Dim dtStrong As DataTable = GetAllStrongCard()
        cmbStrongCard.DataSource = dtStrong
        cmbStrongCard.DisplayMember = "namaKartu"
        cmbStrongCard.ValueMember = "kodeKartu"
        cmbStrongCard.SelectedIndex = -1

        ' Isi ComboBox Miracle Card
        Dim dtMiracle As DataTable = GetAllMiracleCard()
        cmbMiracleCard.DataSource = dtMiracle
        cmbMiracleCard.DisplayMember = "namaKartu"
        cmbMiracleCard.ValueMember = "kodeKartu"
        cmbMiracleCard.SelectedIndex = -1

        ' Isi ComboBox Status
        cmbStatusDeck.Items.AddRange({"Aktif", "Nonaktif"})
        cmbStatusDeck.SelectedIndex = 0

        ' Setup ProgressBar
        prgPower.Maximum = 3000
        prgPower.Minimum = 0

        TampilData()
        Kosong()
    End Sub

    ' ── COMBOBOX CHANGE EVENTS ───────────────────

    Private Sub cmbAnimalCard_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cmbAnimalCard.SelectedIndexChanged
        UpdateInfoPanels()
    End Sub

    Private Sub cmbStrongCard_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cmbStrongCard.SelectedIndexChanged
        UpdateInfoPanels()
    End Sub

    Private Sub cmbMiracleCard_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cmbMiracleCard.SelectedIndexChanged
        UpdateInfoPanels()
    End Sub

    ' ── CRUD ─────────────────────────────────────

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        ' Validasi
        Dim v1 = ValidasiTextBox(ErrorProvider1, txtNamaDeck, "Nama Deck wajib diisi")
        If cmbPemain.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbPemain, "Pilih Pemain")
            v1 = False
        End If
        If cmbAnimalCard.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbAnimalCard, "Pilih Animal Card")
            v1 = False
        End If
        If cmbStrongCard.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbStrongCard, "Pilih Strong Card")
            v1 = False
        End If
        If cmbMiracleCard.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbMiracleCard, "Pilih Miracle Card")
            v1 = False
        End If
        If Not v1 Then Exit Sub

        If SimpanDeck(
            txtNamaDeck.Text.Trim(),
            CInt(cmbPemain.SelectedValue),
            cmbAnimalCard.SelectedValue.ToString(),
            cmbStrongCard.SelectedValue.ToString(),
            cmbMiracleCard.SelectedValue.ToString(),
            txtCatatan.Text.Trim()) Then

            MessageBox.Show("Deck '" & txtNamaDeck.Text.Trim() & "' berhasil disimpan!",
                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idDeckTerpilih = 0 Then
            MessageBox.Show("Pilih Deck dari tabel terlebih dahulu!",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ErrorProvider1.Clear()
        If Not ValidasiTextBox(ErrorProvider1, txtNamaDeck, "Nama Deck wajib diisi") Then Exit Sub

        If MessageBox.Show("Ubah Deck '" & txtNamaDeck.Text.Trim() & "'?",
            "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        If UbahDeck(
            idDeckTerpilih,
            txtNamaDeck.Text.Trim(),
            CInt(cmbPemain.SelectedValue),
            cmbAnimalCard.SelectedValue.ToString(),
            cmbStrongCard.SelectedValue.ToString(),
            cmbMiracleCard.SelectedValue.ToString(),
            cmbStatusDeck.Text,
            txtCatatan.Text.Trim()) Then

            MessageBox.Show("Deck berhasil diubah!", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idDeckTerpilih = 0 Then
            MessageBox.Show("Pilih Deck dari tabel!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Hapus Deck '" & txtNamaDeck.Text & "'?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If HapusDeck(idDeckTerpilih, idPemainTerpilih) Then
                MessageBox.Show("Deck berhasil dihapus!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    ' ── KLIK GRID ────────────────────────────────

    Private Sub dgvDeck_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvDeck.CellClick
        If e.RowIndex >= 0 Then
            With dgvDeck.Rows(e.RowIndex)
                idDeckTerpilih = CInt(.Cells("idDeck").Value)
                txtIdDeck.Text = idDeckTerpilih.ToString()
                txtNamaDeck.Text = .Cells("namaDeck").Value.ToString()

                ' Pilih pemain di ComboBox
                Dim dtDeck As DataTable = GetDeckById(idDeckTerpilih)
                If dtDeck.Rows.Count > 0 Then
                    idPemainTerpilih = CInt(dtDeck.Rows(0)("idPemain"))
                    cmbPemain.SelectedValue = idPemainTerpilih
                    cmbAnimalCard.SelectedValue = dtDeck.Rows(0)("kodeAnimal").ToString()
                    cmbStrongCard.SelectedValue = dtDeck.Rows(0)("kodeStrong").ToString()
                    cmbMiracleCard.SelectedValue = dtDeck.Rows(0)("kodeMiracle").ToString()
                    cmbStatusDeck.Text = dtDeck.Rows(0)("statusDeck").ToString()
                    txtCatatan.Text = If(IsDBNull(dtDeck.Rows(0)("catatan")), "",
                        dtDeck.Rows(0)("catatan").ToString())
                End If
            End With
            UpdateInfoPanels()
        End If
    End Sub

    ' ── SEARCH ───────────────────────────────────

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvDeck.DataSource = SearchDeck(txtSearch.Text.Trim())
            FormatGrid()
        End If
    End Sub

End Class