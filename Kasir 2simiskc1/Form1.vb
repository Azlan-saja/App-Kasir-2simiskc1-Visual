Public Class Form1
    Dim transaksi As New Transaksi()
 
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim nama As String = txtNamaBarang.Text
        Dim harga As Integer = Integer.Parse(txtHarga.Text)
        Dim jumlah As Integer = Integer.Parse(txtJumlah.Text)

        Dim barang As New Barang(nama, harga)
        Dim item As New ItemTransaksi(barang, jumlah)
        transaksi.TambahItem(item)

        Dim row As New ListViewItem(nama)
        row.SubItems.Add("Rp." & harga)
        row.SubItems.Add(jumlah)
        row.SubItems.Add("Rp." & item.subTotal)
        lvTransaksi.Items.Add(row)

        txtNamaBarang.Clear()
        txtHarga.Clear()
        txtJumlah.Clear()
        txtNamaBarang.Focus()
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        lblTotal.Text = "Total: Rp. " + transaksi.hitungTotal.ToString

        txtStruk.Clear()
        txtStruk.AppendText("=== STRUK BELANJA ===" & vbCrLf)
        For Each i In transaksi.DaftarItem
            txtStruk.AppendText(i.Barang.Nama & " Rp." & i.Barang.Harga & " x" & i.Jumlah & " = Rp." & i.subTotal & vbCrLf)
        Next
        txtStruk.AppendText("=== ================== ===" & vbCrLf)
        txtStruk.AppendText(lblTotal.Text)

    End Sub
End Class
