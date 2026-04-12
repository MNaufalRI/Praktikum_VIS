Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) _
           OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Public Sub HanyaAlphanumeric(e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan) : Return False
        Else
            ep.SetError(txt, "") : Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cmb As ComboBox, pesan As String) As Boolean
        If cmb.SelectedIndex = -1 Then
            ep.SetError(cmb, pesan) : Return False
        Else
            ep.SetError(cmb, "") : Return True
        End If
    End Function

    Public Function ValidasiNilai1to5(ep As ErrorProvider, txt As TextBox, field As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, field & " tidak boleh kosong") : Return False
        End If
        Dim v As Integer
        If Not Integer.TryParse(txt.Text, v) OrElse v < 1 OrElse v > 5 Then
            ep.SetError(txt, field & " harus angka 1-5") : Return False
        End If
        ep.SetError(txt, "") : Return True
    End Function

    Public Function ValidasiStat(ep As ErrorProvider, txt As TextBox, field As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, field & " tidak boleh kosong") : Return False
        End If
        Dim v As Integer
        If Not Integer.TryParse(txt.Text, v) OrElse v < 0 OrElse v > 9999 Then
            ep.SetError(txt, field & " harus angka 0-9999") : Return False
        End If
        ep.SetError(txt, "") : Return True
    End Function

    Public Function ValidasiMiracle(ep As ErrorProvider, txt As TextBox) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, "Jumlah miracle tidak boleh kosong") : Return False
        End If
        Dim v As Integer
        If Not Integer.TryParse(txt.Text, v) OrElse v < 1 OrElse v > 9999 Then
            ep.SetError(txt, "Miracle harus angka 1-9") : Return False
        End If
        ep.SetError(txt, "") : Return True
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

End Module