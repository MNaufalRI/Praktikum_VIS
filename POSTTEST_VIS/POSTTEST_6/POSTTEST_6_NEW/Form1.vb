Public Class Form1

    Private isDatabaseReady As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Animal Kaiser - Sistem Manajemen Kartu"
        Me.StartPosition = FormStartPosition.CenterScreen

        CheckDatabaseConnection()

        LoadFormSafely(New FormAnimalCard(), TabPage1)
        LoadFormSafely(New FormStrongCard(), TabPage2)
        LoadFormSafely(New FormMiracleCard(), TabPage3)
        LoadFormSafely(New FormDeckBuilder(), TabPage4)
        LoadFormSafely(New FormPemain(), TabPage5)
    End Sub

    Private Sub CheckDatabaseConnection()
        Try
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

    Private Sub LoadFormSafely(ByVal frm As Form, ByVal tp As TabPage)
        Try

            If tp Is Nothing Then
                Console.WriteLine("Error: TabPage tidak ditemukan di Designer.")
                Return
            End If

            frm.TopLevel = False
            frm.FormBorderStyle = FormBorderStyle.None
            frm.Dock = DockStyle.Fill

            tp.Controls.Clear()
            tp.Controls.Add(frm)
            frm.Show()

            Console.WriteLine("Log: Berhasil memuat " & frm.Name)

        Catch ex As Exception
            Dim errorLabel As New Label()
            errorLabel.Text = "Gagal memuat form: " & ex.Message
            errorLabel.ForeColor = Color.Red
            errorLabel.Dock = DockStyle.Fill
            tp.Controls.Add(errorLabel)

            Console.WriteLine("Crash Log [" & frm.Name & "]: " & ex.Message)
        End Try
    End Sub

    Private Function TestConnection() As Boolean
        Return True
    End Function

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class