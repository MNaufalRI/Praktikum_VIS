Module Module1
    Public Structure Buku
        Public Judul As String
        Public Genre As String
    End Structure

    Public DaftarBuku() As Buku = {}
    Public Function CariIndexBuku(ByVal judulCari As String) As Integer
        For i As Integer = 0 To DaftarBuku.Length - 1
            If DaftarBuku(i).Judul.Equals(judulCari, StringComparison.OrdinalIgnoreCase) Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module