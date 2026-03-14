Public Class Form1

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim bukaFile As New OpenFileDialog()
        bukaFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"

        If bukaFile.ShowDialog() = DialogResult.OK Then
            pbProfile.Image = Image.FromFile(bukaFile.FileName)
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        Dim jk As String = ""
        If rbLaki.Checked Then
            jk = "Laki-laki"
        ElseIf rbPerempuan.Checked Then
            jk = "Perempuan"
        End If

        Dim daftarHobby As String = ""
        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then
                    daftarHobby += cb.Text & ", "
                End If
            End If
        Next

        If txtNama.Text.Trim() = "" Or
           txtUmur.Text.Trim() = "" Or
           txtTelepon.Text.Trim() = "" Or
           txtAlamat.Text.Trim() = "" Or
           jk = "" Or
           daftarHobby = "" Or
           pbProfile.Image Is Nothing Then

            MessageBox.Show("Inputan tidak boleh kosong", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        daftarHobby = daftarHobby.TrimEnd(","c, " "c)

        Dim formKartu As New FormHasil()

        formKartu.lblNamaHasil.Text = txtNama.Text
        formKartu.lblUmurHasil.Text = txtUmur.Text & " Tahun"
        formKartu.lblTelpHasil.Text = txtTelepon.Text
        formKartu.lblGenderHasil.Text = jk
        formKartu.lblHobbyHasil.Text = daftarHobby
        formKartu.lblTglLahirHasil.Text = dtpLahir.Value.ToString("dd MMMM yyyy")
        formKartu.lblAlamatHasil.Text = txtAlamat.Text
        formKartu.pbFotoHasil.Image = pbProfile.Image
        formKartu.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
