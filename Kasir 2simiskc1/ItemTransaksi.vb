Public Class ItemTransaksi
    Public Property Barang As Barang
    Public Property Jumlah As Integer

    Public ReadOnly Property subTotal As Integer
        Get
            Return Barang.Harga * Jumlah
        End Get
    End Property

    Public Sub New(b As Barang, j As Integer)
        Barang = b
        Jumlah = j
    End Sub
End Class
