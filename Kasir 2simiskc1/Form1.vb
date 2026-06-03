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
        cmbKoBar.Focus()
        cmbKoBar.Text = ""
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim total As Integer = transaksi.hitungTotal()
        Dim poin As Integer = total \ 100000 ' pembulatan ke bawah
        Dim potongan As Integer = poin * 2000
        Dim pajak As Integer = total * 11 \ 100 ' dibulatkan ke bawah
        Dim totalBayar As Integer = total - potongan + pajak

        ' Menampilkan hasil ke TextBox atau Label (asumsikan kamu punya TextBox ini di form)
        lblTotal.Text = "Total: Rp " & total.ToString("N0")
        txtPointBelanja.Text = poin.ToString()
        txtPotonganHarga.Text = potongan.ToString("N0")
        txtPajak.Text = pajak.ToString("N0")
        txtTotalBayar.Text = totalBayar.ToString("N0")


        'lblTotal.Text = "Total: Rp. " + transaksi.hitungTotal.ToString

        'txtStruk.Clear()
        'txtStruk.AppendText("=== STRUK BELANJA ===" & vbCrLf)
        'For Each i In transaksi.DaftarItem
        '    txtStruk.AppendText(i.Barang.Nama & " Rp." & i.Barang.Harga & " x" & i.Jumlah & " = Rp." & i.subTotal & vbCrLf)
        'Next
        'txtStruk.AppendText("=== ================== ===" & vbCrLf)
        'txtStruk.AppendText(lblTotal.Text)

    End Sub

    Private Sub cmbKoBar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKoBar.SelectedIndexChanged
        Select Case cmbKoBar.Text
            Case Is = "V001"
                txtNamaBarang.Text = "Vas Kecil"
                txtHarga.Text = 56000
            Case Is = "V002"
                txtNamaBarang.Text = "Vas Besar"
                txtHarga.Text = 150000
            Case Is = "P001"
                txtNamaBarang.Text = "Payung Lipat"
                txtHarga.Text = 25000
            Case Is = "P002"
                txtNamaBarang.Text = "Payung Besar"
                txtHarga.Text = 35000
            Case Is = "B001"
                txtNamaBarang.Text = "Bunga Hias Biasa"
                txtHarga.Text = 25000
            Case Is = "B002"
                txtNamaBarang.Text = "Bunga Hias Kombinasi"
                txtHarga.Text = 45000
            Case Is = "R001"
                txtNamaBarang.Text = "Rak Sepatu Kecil"
                txtHarga.Text = 100000
            Case Is = "R002"
                txtNamaBarang.Text = "Rak Sepatu Besar"
                txtHarga.Text = 300000
            Case Else
                txtNamaBarang.Clear()
                txtHarga.Clear()
        End Select

       
    End Sub

    Private Sub txtJlhUang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJlhUang.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim totalBayar As Integer = txtTotalBayar.Text
            Dim jumlahUang As Integer = 0

            ' Validasi input jumlah uang
            If Integer.TryParse(txtJlhUang.Text, jumlahUang) Then
                ' Ambil total bayar dari textbox
                Integer.TryParse(txtTotalBayar.Text, totalBayar)

                ' Hitung kembalian
                Dim kembali As Integer = jumlahUang - txtTotalBayar.Text

                ' Tampilkan hasil
                txtUanagKembali.Text = kembali.ToString("N0")
            Else
                MessageBox.Show("Masukkan jumlah uang yang valid",
"Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub txtJlhUang_TextChanged(sender As Object, e As EventArgs) Handles txtJlhUang.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtStruk.Clear()
        Dim total As Integer = transaksi.hitungTotal()
        txtStruk.AppendText("========= STRUK PEMBELIAN =========" & vbCrLf)

        For Each item As ItemTransaksi In transaksi.DaftarItem
            txtStruk.AppendText(item.Barang.Nama & " x" & item.Jumlah.ToString() & " = Rp " & item.subTotal.ToString() & vbCrLf)
        Next

        txtStruk.AppendText("------------------------------------" & vbCrLf)
        txtStruk.AppendText("Total: Rp " & total.ToString())
        txtStruk.AppendText("Poin Belanja    : " & txtPointBelanja.Text & vbCrLf)
        txtStruk.AppendText("Potongan Harga  : Rp " & txtPotonganHarga.Text & vbCrLf)
        txtStruk.AppendText("Pajak (11%)     : Rp " & txtPajak.Text & vbCrLf)
        txtStruk.AppendText("Total Bayar     : Rp " & txtTotalBayar.Text & vbCrLf)
        txtStruk.AppendText("Jumlah Uang     : Rp " & txtJlhUang.Text & vbCrLf)
        txtStruk.AppendText("Uang Kembali    : Rp " & txtUanagKembali.Text & vbCrLf)
        txtStruk.AppendText("====================================" & vbCrLf)
        txtStruk.AppendText("   Terima kasih atas kunjungannya!  " & vbCrLf)
        txtStruk.AppendText(lblPetugasKasir.Text)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPetugasKasir.Text = Login.TampilUser()

        'Menampilkan Hari pada Objek LblHari
        Dim hari As String
        Select Case Weekday(Today)
            Case 1 : hari = "Minggu"
            Case 2 : hari = "Senin"
            Case 3 : hari = "Selasa"
            Case 4 : hari = "Rabu"
            Case 5 : hari = "Kamis"
            Case 6 : hari = "Jumat"
            Case 7 : hari = "Sabtu"
        End Select
        lblHari.Text = hari

        'Menampilkan Tanggal pada objek LblTgl
        lbltgl.Text = Format(Today, "dd-MM-yyyy")

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbljam.Text = Format(Now(), "HH:mm:ss")
    End Sub
End Class
