Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBuku.ColumnCount = 2
        dgvBuku.Columns(0).Name = "Judul Buku"
        dgvBuku.Columns(1).Name = "Genre"
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.AllowUserToAddRows = False
        dgvBuku.ReadOnly = True
    End Sub

    Private Sub RefreshGrid(ByVal data() As Buku)
        dgvBuku.Rows.Clear()
        For Each item In data
            dgvBuku.Rows.Add(item.Judul, item.Genre)
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJudulTambah.Text <> "" And txtGenre.Text <> "" Then
            ReDim Preserve DaftarBuku(DaftarBuku.Length)

            DaftarBuku(DaftarBuku.Length - 1).Judul = txtJudulTambah.Text
            DaftarBuku(DaftarBuku.Length - 1).Genre = txtGenre.Text
            RefreshGrid(DaftarBuku)
            txtJudulTambah.Clear()
            txtGenre.Clear()
        Else
            MsgBox("Mohon isi semua data!")
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim index As Integer = CariIndexBuku(txtJudulHapus.Text)

        If index <> -1 Then
            Dim listBuku As List(Of Buku) = DaftarBuku.ToList()
            listBuku.RemoveAt(index)
            DaftarBuku = listBuku.ToArray()

            RefreshGrid(DaftarBuku)
            MsgBox("Buku berhasil dihapus!")
            txtJudulHapus.Clear()
        Else
            MsgBox("Buku tidak ditemukan!")
        End If
    End Sub

End Class
