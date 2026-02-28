Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0
    Private Sub TentukanPredikat(ipk As Double)
        If ipk >= 2.0 And ipk <= 2.75 Then
            lblPredikat.Text = "Predikat : Cukup"
        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            lblPredikat.Text = "Predikat : Memuaskan"
        ElseIf ipk >= 3.01 Then
            lblPredikat.Text = "Predikat : Sangat Memuaskan"
        Else
            lblPredikat.Text = "Predikat : -"
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipInput As Double

        If Double.TryParse(txtIPSemester.Text, ipInput) Then
            If ipInput >= 0 And ipInput <= 4 Then

                totalIP += ipInput
                jumlahSemester += 1

                Dim ipk As Double = totalIP / jumlahSemester

                lblIPK.Text = "IPK Kumulatif : " & ipk.ToString("N2")
                lblSemester.Text = "Jumlah Semester : " & jumlahSemester.ToString

                TentukanPredikat(ipk)
                txtIPSemester.Clear()
                txtIPSemester.Focus()

            Else
                MessageBox.Show("Nilai IP harus di antara 0,00 sampai 4,00", "Input Salah")
            End If
        Else
            MessageBox.Show("Tolong masukkan angka yang valid!", "Peringatan")
        End If
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        lblIPK.Text = "IPK Kumulatif : 0,00"
        lblPredikat.Text = "Predikat : -"
        lblSemester.Text = "Jumlah Semester : -"
        txtIPSemester.Clear()
        txtIPSemester.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
