Public Class Form1

    ' Variabel untuk menyimpan status koneksi
    Private isDatabaseReady As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Pengaturan Tampilan Awal
        Me.Text = "Animal Kaiser - Sistem Manajemen Kartu"
        Me.StartPosition = FormStartPosition.CenterScreen

        ' 2. Cek Koneksi Database dengan Safe Method
        CheckDatabaseConnection()

        ' 3. Muat semua form anak dengan sistem proteksi (Try-Catch per form)
        ' Jadi jika satu form error, form lain tidak ikut crash
        LoadFormSafely(New FormAnimalCard(), TabPage1)
        LoadFormSafely(New FormStrongCard(), TabPage2)
        LoadFormSafely(New FormMiracleCard(), TabPage3)
        LoadFormSafely(New FormDeckBuilder(), TabPage4)
        LoadFormSafely(New FormPemain(), TabPage5)
    End Sub

    Private Sub CheckDatabaseConnection()
        Try
            ' Panggil fungsi TestConnection dari Module Anda
            ' Saya asumsikan Anda punya fungsi ini di Module
            If TestConnection() Then
                isDatabaseReady = True
            Else
                MessageBox.Show("Aplikasi berjalan dalam mode Offline (Database tidak terdeteksi).",
                                "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi error fatal saat cek database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Memasukkan form ke tab dengan pengamanan agar tidak crash seluruh aplikasi
    ''' </summary>
    Private Sub LoadFormSafely(ByVal frm As Form, ByVal tp As TabPage)
        Try
            ' Cek apakah TabPage ada di designer
            If tp Is Nothing Then
                Console.WriteLine("Error: TabPage tidak ditemukan di Designer.")
                Return
            End If

            ' Pengaturan Form agar masuk ke dalam Tab
            frm.TopLevel = False
            frm.FormBorderStyle = FormBorderStyle.None
            frm.Dock = DockStyle.Fill

            ' Bersihkan TabPage dan masukkan Form
            tp.Controls.Clear()
            tp.Controls.Add(frm)
            frm.Show()

            Console.WriteLine("Log: Berhasil memuat " & frm.Name)

        Catch ex As Exception
            ' Jika satu form gagal, beri info tapi jangan tutup aplikasinya
            Dim errorLabel As New Label()
            errorLabel.Text = "Gagal memuat form: " & ex.Message
            errorLabel.ForeColor = Color.Red
            errorLabel.Dock = DockStyle.Fill
            tp.Controls.Add(errorLabel)

            Console.WriteLine("Crash Log [" & frm.Name & "]: " & ex.Message)
        End Try
    End Sub

    ' Fungsi dummy jika belum ada di Module
    Private Function TestConnection() As Boolean
        ' Ganti dengan logika koneksi asli Anda
        Return True
    End Function

End Class