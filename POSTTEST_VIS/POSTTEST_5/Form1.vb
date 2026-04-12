' Form utama menggunakan TabControl dengan 3 tab:
' Tab 1: Animal Cards
' Tab 2: Strong Cards
' Tab 3: Miracle Cards

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Animal Kaiser - Sistem Manajemen Kartu"
        Me.Size = New Size(1200, 750)

        ' 1. Masukkan Form Animal Card ke TabPage1
        LoadFormInTab(New FormAnimalCard(), TabPage1)

        ' 2. Masukkan Form Strong Card ke TabPage2
        LoadFormInTab(New FormStrongCard(), TabPage2)

        ' 3. Masukkan Form Miracle Card ke TabPage3
        LoadFormInTab(New FormMiracleCard(), TabPage3)

        ' Cek koneksi database saat startup
        If Not TestConnection() Then
            MessageBox.Show("Tidak dapat terhubung ke database. Periksa XAMPP!",
                "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LoadFormInTab(frm As Form, tp As TabPage)
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill

        tp.Controls.Add(frm) ' Menambahkan form ke dalam TabPage
        frm.Show()           ' Menampilkan form
    End Sub

End Class