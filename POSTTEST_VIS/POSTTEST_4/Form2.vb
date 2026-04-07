Imports System.Drawing.Imaging
Imports System.IO

Public Class Form2
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            ErrorProvider1.SetError(txtNama, "Inputan Nama hanya boleh huruf!")
        Else
            ErrorProvider1.SetError(txtNama, "")
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            ErrorProvider1.SetError(txtID, "Inputan ID hanya boleh angka!")
        Else
            ErrorProvider1.SetError(txtID, "")
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OFD1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OFD1.ShowDialog() = DialogResult.OK Then
            pbFotoProfil.ImageLocation = OFD1.FileName
            pbFotoProfil.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If txtNama.Text = "" Or txtID.Text = "" Or txtEmail.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not mtxtTelp.MaskCompleted Then
            MessageBox.Show("Nomor telepon harus sesuai format!", "Error")
            Return
        End If

        If pbFotoProfil.Image Is Nothing Then
            MessageBox.Show("Silakan pilih foto terlebih dahulu!", "Error")
            Return
        End If

        Dim pilihanTerpilih As String = ""
        Dim isChecked As Boolean = False


        Dim gbs() As GroupBox = {gbHobi, gbAktivitas}
        For Each gb In gbs
            For Each ctrl As Control In gb.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim chk = DirectCast(ctrl, CheckBox)
                    If chk.Checked Then
                        isChecked = True
                        pilihanTerpilih &= chk.Text & ", "
                    End If
                End If
            Next
        Next

        If Not isChecked Then
            MessageBox.Show("Pilih minimal satu hobi atau aktivitas!", "Error")
            Return
        End If

        pilihanTerpilih = pilihanTerpilih.TrimEnd(New Char() {","c, " "c})

        Try
            Dim folderData As String = Path.Combine(Application.StartupPath, "DataAnggota")

            If Not Directory.Exists(folderData) Then
                Directory.CreateDirectory(folderData)
            End If

            Dim fileDataBaru As String = Path.Combine(folderData, txtID.Text & ".txt")
            Dim pathFoto As String = Path.Combine(folderData, txtID.Text & ".png")
            Using bmp As New Bitmap(pbFotoProfil.Image)
                bmp.Save(pathFoto, Imaging.ImageFormat.Png)
            End Using

            Dim barisData As String = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}",
                            txtID.Text, txtNama.Text, cbDivisi.Text,
                            mtxtTelp.Text, txtEmail.Text, pilihanTerpilih, pathFoto)

            File.WriteAllText(fileDataBaru, barisData)

            Dim konfirmasi As DialogResult = MessageBox.Show("Data berhasil disimpan! Cetak kartu sekarang?", "Sukses", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If konfirmasi = DialogResult.Yes Then
                Dim frmHasil As New FormKartu()

                frmHasil.lblNama.Text = txtNama.Text
                frmHasil.lblID.Text = txtID.Text
                frmHasil.lblKomunitas.Text = cbDivisi.Text
                frmHasil.lblKontak.Text = mtxtTelp.Text
                frmHasil.lblHobby.Text = pilihanTerpilih
                frmHasil.pbFotoHasil.Image = Image.FromFile(pathFoto)

                frmHasil.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SFD1.Filter = "Text Files (*.txt)|*.txt"

        If SFD1.ShowDialog() = DialogResult.OK Then
            Try
                Dim hobiTerpilih As String = ""
                For Each ctrl As Control In gbHobi.Controls
                    If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then hobiTerpilih &= ctrl.Text & ";"
                Next
                For Each ctrl As Control In gbAktivitas.Controls
                    If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then hobiTerpilih &= ctrl.Text & ";"
                Next

                Dim peranTerpilih As String = ""
                If rbPeran1.Checked Then peranTerpilih = rbPeran1.Text
                If rbPeran2.Checked Then peranTerpilih = rbPeran2.Text
                If rbPeran3.Checked Then peranTerpilih = rbPeran3.Text

                Dim stringFoto As String = ""
                If pbFotoProfil.Image IsNot Nothing Then
                    Using ms As New System.IO.MemoryStream()
                        pbFotoProfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        stringFoto = Convert.ToBase64String(ms.ToArray())
                    End Using
                End If

                Dim dataSimpan As New List(Of String)
                dataSimpan.Add(txtNama.Text)
                dataSimpan.Add(txtID.Text)
                dataSimpan.Add(dtpLahir.Value.ToString("yyyy-MM-dd"))
                dataSimpan.Add(If(rbPria.Checked, "Pria", "Wanita"))
                dataSimpan.Add(cbDivisi.Text)
                dataSimpan.Add(mtxtTelp.Text)
                dataSimpan.Add(txtEmail.Text)
                dataSimpan.Add(txtAlamat.Text.Replace(vbCrLf, " "))
                dataSimpan.Add(hobiTerpilih.TrimEnd(";"c))
                dataSimpan.Add(peranTerpilih)
                dataSimpan.Add(stringFoto)

                System.IO.File.WriteAllLines(SFD1.FileName, dataSimpan.ToArray())
                MessageBox.Show("Data dan Foto berhasil disimpan!", "Sukses")
            Catch ex As Exception
                MessageBox.Show("Gagal simpan: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim res As DialogResult = MessageBox.Show("Yakin ingin keluar?", "Keluar", MessageBoxButtons.YesNo)
        If res = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        Dim cariFile As New OpenFileDialog()
        cariFile.Filter = "Data Anggota (*.txt)|*.txt"
        cariFile.InitialDirectory = Path.Combine(Application.StartupPath, "DataAnggota")

        If cariFile.ShowDialog() = DialogResult.OK Then
            Try
                Dim isiFile As String = File.ReadAllText(cariFile.FileName)
                Dim kolom As String() = isiFile.Split("|"c)

                If kolom.Length >= 7 Then
                    FormKartu.lblID.Text = kolom(0)
                    FormKartu.lblNama.Text = kolom(1)
                    FormKartu.lblKomunitas.Text = kolom(2)
                    FormKartu.lblKontak.Text = kolom(3)
                    FormKartu.lblHobby.Text = kolom(5)

                    Dim pathFoto As String = kolom(6)
                    If File.Exists(pathFoto) Then
                        Dim bytes = File.ReadAllBytes(pathFoto)
                        FormKartu.pbFotoHasil.Image = Image.FromStream(New MemoryStream(bytes))
                    End If

                    FormKartu.Show()
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal memuat data: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        If OFD1.ShowDialog() = DialogResult.OK Then
            Try
                Dim baris() As String = System.IO.File.ReadAllLines(OFD1.FileName)

                If baris.Length >= 11 Then
                    txtNama.Text = baris(0)
                    txtID.Text = baris(1)
                    dtpLahir.Value = Convert.ToDateTime(baris(2))

                    If baris(3) = "Pria" Then rbPria.Checked = True Else rbWanita.Checked = True

                    cbDivisi.Text = baris(4)
                    mtxtTelp.Text = baris(5)
                    txtEmail.Text = baris(6)
                    txtAlamat.Text = baris(7)

                    Dim hobi As String = baris(8)
                    For Each ctrl As Control In gbHobi.Controls
                        If TypeOf ctrl Is CheckBox Then DirectCast(ctrl, CheckBox).Checked = hobi.Contains(ctrl.Text)
                    Next

                    Dim peran As String = baris(9)
                    If rbPeran1.Text = peran Then rbPeran1.Checked = True
                    If rbPeran2.Text = peran Then rbPeran2.Checked = True
                    If rbPeran3.Text = peran Then rbPeran3.Checked = True

                    Dim stringFoto As String = baris(10)
                    If Not String.IsNullOrEmpty(stringFoto) Then
                        Dim imageBytes() As Byte = Convert.FromBase64String(stringFoto)
                        Using ms As New System.IO.MemoryStream(imageBytes)
                            pbFotoProfil.Image = Image.FromStream(ms)
                        End Using
                    End If

                    MessageBox.Show("Semua data termasuk foto berhasil dimuat!")
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal buka: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TambahDivisiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        Dim divisiBaru As String = InputBox("Masukkan Nama Divisi Baru:", "Input Divisi")

        If Not String.IsNullOrWhiteSpace(divisiBaru) Then
            If cbDivisi.Items.Contains(divisiBaru) Then
                MessageBox.Show("Divisi ini sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Try
                Dim pathDivisi As String = Path.Combine(Application.StartupPath, "divisi.txt")

                Using sw As StreamWriter = File.AppendText(pathDivisi)
                    sw.WriteLine(divisiBaru)
                End Using

                cbDivisi.Items.Add(divisiBaru)
                cbDivisi.SelectedItem = divisiBaru

                MessageBox.Show("Divisi '" & divisiBaru & "' berhasil ditambahkan!", "Sukses")

            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan divisi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pathDivisi As String = Path.Combine(Application.StartupPath, "divisi.txt")

        If File.Exists(pathDivisi) Then
            Dim daftarDivisi As String() = File.ReadAllLines(pathDivisi)

            For Each d In daftarDivisi
                If Not String.IsNullOrWhiteSpace(d) Then
                    cbDivisi.Items.Add(d)
                End If
            Next
        End If
    End Sub

End Class