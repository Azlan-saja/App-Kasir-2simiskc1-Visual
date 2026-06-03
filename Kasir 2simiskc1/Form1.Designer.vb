<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtStruk = New System.Windows.Forms.TextBox()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvTransaksi = New System.Windows.Forms.ListView()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbKoBar = New System.Windows.Forms.ComboBox()
        Me.txtPointBelanja = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPotonganHarga = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPajak = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtJlhUang = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtUanagKembali = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblPetugasKasir = New System.Windows.Forms.Label()
        Me.lblHari = New System.Windows.Forms.Label()
        Me.lbltgl = New System.Windows.Forms.Label()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(367, 22)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Belanja Happy, RUmah Menjadi Indah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(289, 22)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Support Contact : 08217474322"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 658)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1251, 95)
        Me.Panel2.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calisto MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 34)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Happy Home"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(376, 601)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(106, 22)
        Me.lblTotal.TabIndex = 22
        Me.lblTotal.Text = "Total Rp.0"
        '
        'txtStruk
        '
        Me.txtStruk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtStruk.Location = New System.Drawing.Point(739, 470)
        Me.txtStruk.Multiline = True
        Me.txtStruk.Name = "txtStruk"
        Me.txtStruk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStruk.Size = New System.Drawing.Size(500, 182)
        Me.txtStruk.TabIndex = 21
        Me.txtStruk.Text = "=== STRUK BELANJA ==="
        Me.txtStruk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sub Total"
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah"
        Me.ColumnHeader3.Width = 94
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Harga"
        Me.ColumnHeader2.Width = 146
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nama Barang"
        Me.ColumnHeader1.Width = 182
        '
        'lvTransaksi
        '
        Me.lvTransaksi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvTransaksi.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lvTransaksi.GridLines = True
        Me.lvTransaksi.Location = New System.Drawing.Point(33, 399)
        Me.lvTransaksi.Name = "lvTransaksi"
        Me.lvTransaksi.Size = New System.Drawing.Size(614, 199)
        Me.lvTransaksi.TabIndex = 20
        Me.lvTransaksi.UseCompatibleStateImageBehavior = False
        Me.lvTransaksi.View = System.Windows.Forms.View.Details
        '
        'txtJumlah
        '
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtJumlah.Location = New System.Drawing.Point(172, 303)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(85, 30)
        Me.txtJumlah.TabIndex = 15
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtHarga.Location = New System.Drawing.Point(172, 267)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(185, 30)
        Me.txtHarga.TabIndex = 16
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNamaBarang.Location = New System.Drawing.Point(172, 231)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(436, 30)
        Me.txtNamaBarang.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 22)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(362, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jl. Cinta Kasih N0. 54 Medan Maimun"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Happy Home"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program Kasir"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1251, 123)
        Me.Panel1.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 22)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Kode Barang"
        '
        'cmbKoBar
        '
        Me.cmbKoBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbKoBar.FormattingEnabled = True
        Me.cmbKoBar.Items.AddRange(New Object() {"V001", "V002", "P001", "P002", "B001", "B002", "R001", "R002"})
        Me.cmbKoBar.Location = New System.Drawing.Point(172, 191)
        Me.cmbKoBar.Name = "cmbKoBar"
        Me.cmbKoBar.Size = New System.Drawing.Size(173, 33)
        Me.cmbKoBar.TabIndex = 25
        '
        'txtPointBelanja
        '
        Me.txtPointBelanja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPointBelanja.Location = New System.Drawing.Point(907, 196)
        Me.txtPointBelanja.Name = "txtPointBelanja"
        Me.txtPointBelanja.Size = New System.Drawing.Size(314, 30)
        Me.txtPointBelanja.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(735, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 22)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Point Belanja"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(735, 232)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 22)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Potongan Harga"
        '
        'txtPotonganHarga
        '
        Me.txtPotonganHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPotonganHarga.Location = New System.Drawing.Point(907, 232)
        Me.txtPotonganHarga.Name = "txtPotonganHarga"
        Me.txtPotonganHarga.Size = New System.Drawing.Size(314, 30)
        Me.txtPotonganHarga.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(738, 267)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 22)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Pajak"
        '
        'txtPajak
        '
        Me.txtPajak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPajak.Location = New System.Drawing.Point(907, 268)
        Me.txtPajak.Name = "txtPajak"
        Me.txtPajak.Size = New System.Drawing.Size(314, 30)
        Me.txtPajak.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(735, 304)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 22)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Total Bayar"
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalBayar.Location = New System.Drawing.Point(907, 304)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(314, 30)
        Me.txtTotalBayar.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(735, 340)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 22)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Jumlah Uang"
        '
        'txtJlhUang
        '
        Me.txtJlhUang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtJlhUang.Location = New System.Drawing.Point(907, 340)
        Me.txtJlhUang.Name = "txtJlhUang"
        Me.txtJlhUang.Size = New System.Drawing.Size(314, 30)
        Me.txtJlhUang.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(735, 376)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(167, 22)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Uang Kembalian"
        '
        'txtUanagKembali
        '
        Me.txtUanagKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtUanagKembali.Location = New System.Drawing.Point(907, 376)
        Me.txtUanagKembali.Name = "txtUanagKembali"
        Me.txtUanagKembali.Size = New System.Drawing.Size(314, 30)
        Me.txtUanagKembali.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(739, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 39)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Cetak Struk Belanja"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnHitung.Image = CType(resources.GetObject("btnHitung.Image"), System.Drawing.Image)
        Me.btnHitung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHitung.Location = New System.Drawing.Point(33, 601)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(177, 39)
        Me.btnHitung.TabIndex = 18
        Me.btnHitung.Text = "Hitung Total"
        Me.btnHitung.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(33, 346)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(144, 41)
        Me.btnTambah.TabIndex = 19
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Kasir_2simiskc1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(62, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblPetugasKasir)
        Me.Panel3.Location = New System.Drawing.Point(33, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(575, 49)
        Me.Panel3.TabIndex = 29
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lbljam)
        Me.Panel4.Controls.Add(Me.lbltgl)
        Me.Panel4.Controls.Add(Me.lblHari)
        Me.Panel4.Location = New System.Drawing.Point(739, 136)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(482, 49)
        Me.Panel4.TabIndex = 29
        '
        'lblPetugasKasir
        '
        Me.lblPetugasKasir.AutoSize = True
        Me.lblPetugasKasir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPetugasKasir.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetugasKasir.Location = New System.Drawing.Point(15, 13)
        Me.lblPetugasKasir.Name = "lblPetugasKasir"
        Me.lblPetugasKasir.Size = New System.Drawing.Size(89, 24)
        Me.lblPetugasKasir.TabIndex = 24
        Me.lblPetugasKasir.Text = "Petugas:"
        '
        'lblHari
        '
        Me.lblHari.AutoSize = True
        Me.lblHari.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHari.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHari.Location = New System.Drawing.Point(12, 13)
        Me.lblHari.Name = "lblHari"
        Me.lblHari.Size = New System.Drawing.Size(61, 24)
        Me.lblHari.TabIndex = 24
        Me.lblHari.Text = "Hari:"
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltgl.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltgl.Location = New System.Drawing.Point(184, 13)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(48, 24)
        Me.lbltgl.TabIndex = 24
        Me.lbltgl.Text = "Tgl:"
        '
        'lbljam
        '
        Me.lbljam.AutoSize = True
        Me.lbljam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbljam.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljam.Location = New System.Drawing.Point(350, 13)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(57, 24)
        Me.lbljam.TabIndex = 24
        Me.lbljam.Text = "Jam:"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 753)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtUanagKembali)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtJlhUang)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotalBayar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPajak)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPotonganHarga)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPointBelanja)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbKoBar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtStruk)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.lvTransaksi)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Kasir V.9.9"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtStruk As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvTransaksi As System.Windows.Forms.ListView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbKoBar As System.Windows.Forms.ComboBox
    Friend WithEvents txtPointBelanja As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPotonganHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPajak As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtJlhUang As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtUanagKembali As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblPetugasKasir As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbljam As System.Windows.Forms.Label
    Friend WithEvents lbltgl As System.Windows.Forms.Label
    Friend WithEvents lblHari As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
