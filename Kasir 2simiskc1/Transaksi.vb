Public Class Transaksi
    Public Property DaftarItem As New List(Of ItemTransaksi)

    Public Sub TambahItem(i As ItemTransaksi)
        DaftarItem.Add(i)
    End Sub

    Public Function hitungTotal() As Integer
        Dim total As Integer
        For Each item In DaftarItem
            total += item.subTotal
        Next
        Return total
    End Function

End Class