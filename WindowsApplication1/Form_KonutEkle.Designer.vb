<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_KonutEkle
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_KonutEkle))
        Me.DataGridView_Musteri = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txt_KonutID = New System.Windows.Forms.TextBox()
        Me.txt_MusteriID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_BinaYasi = New System.Windows.Forms.TextBox()
        Me.cmb_EmlakTipi = New System.Windows.Forms.ComboBox()
        Me.cmb_Durum = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rtxt_Adres = New System.Windows.Forms.RichTextBox()
        Me.mtxt_MetreKare = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_OdaSayisi = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_BulunduguKat = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_ToplamKatSayisi = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_Isitma = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_BanyoSayisi = New System.Windows.Forms.TextBox()
        Me.cmb_Balkon = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmb_EsyaDurumu = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_Aidat = New System.Windows.Forms.TextBox()
        Me.cmb_KrediyeUygun = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.mtxt_Fiyat = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_ParaBirimi = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmb_Il = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_ilce = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView_Musteri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Musteri
        '
        Me.DataGridView_Musteri.AllowUserToAddRows = False
        Me.DataGridView_Musteri.AllowUserToDeleteRows = False
        Me.DataGridView_Musteri.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView_Musteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView_Musteri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView_Musteri.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Musteri.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_Musteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Musteri.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView_Musteri.Location = New System.Drawing.Point(12, 113)
        Me.DataGridView_Musteri.Name = "DataGridView_Musteri"
        Me.DataGridView_Musteri.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_Musteri.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_Musteri.RowHeadersVisible = False
        Me.DataGridView_Musteri.RowTemplate.Height = 24
        Me.DataGridView_Musteri.Size = New System.Drawing.Size(465, 591)
        Me.DataGridView_Musteri.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(177, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Müşteri Seçiniz"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Location = New System.Drawing.Point(524, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1, 591)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Label3"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(146, 725)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(198, 17)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Müşteri Eklemek İçin Tıklayınız"
        '
        'txt_KonutID
        '
        Me.txt_KonutID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_KonutID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_KonutID.Enabled = False
        Me.txt_KonutID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_KonutID.Location = New System.Drawing.Point(549, 122)
        Me.txt_KonutID.Name = "txt_KonutID"
        Me.txt_KonutID.ReadOnly = True
        Me.txt_KonutID.Size = New System.Drawing.Size(200, 30)
        Me.txt_KonutID.TabIndex = 13
        '
        'txt_MusteriID
        '
        Me.txt_MusteriID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_MusteriID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_MusteriID.Enabled = False
        Me.txt_MusteriID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_MusteriID.Location = New System.Drawing.Point(549, 201)
        Me.txt_MusteriID.Name = "txt_MusteriID"
        Me.txt_MusteriID.ReadOnly = True
        Me.txt_MusteriID.Size = New System.Drawing.Size(200, 30)
        Me.txt_MusteriID.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(593, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Konut ID"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(593, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Müşteri ID"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(593, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 25)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Emlak Tipi"
        '
        'txt_BinaYasi
        '
        Me.txt_BinaYasi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_BinaYasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_BinaYasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_BinaYasi.Location = New System.Drawing.Point(842, 298)
        Me.txt_BinaYasi.Name = "txt_BinaYasi"
        Me.txt_BinaYasi.Size = New System.Drawing.Size(188, 30)
        Me.txt_BinaYasi.TabIndex = 17
        '
        'cmb_EmlakTipi
        '
        Me.cmb_EmlakTipi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_EmlakTipi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_EmlakTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EmlakTipi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmb_EmlakTipi.FormattingEnabled = True
        Me.cmb_EmlakTipi.Items.AddRange(New Object() {"Daire", "İşyeri", "Arsa", "Bina"})
        Me.cmb_EmlakTipi.Location = New System.Drawing.Point(549, 298)
        Me.cmb_EmlakTipi.Name = "cmb_EmlakTipi"
        Me.cmb_EmlakTipi.Size = New System.Drawing.Size(200, 33)
        Me.cmb_EmlakTipi.TabIndex = 19
        '
        'cmb_Durum
        '
        Me.cmb_Durum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_Durum.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_Durum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Durum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmb_Durum.FormattingEnabled = True
        Me.cmb_Durum.Items.AddRange(New Object() {"Aylık Kiralık", "Satılık", "Günlük Kiralık"})
        Me.cmb_Durum.Location = New System.Drawing.Point(549, 398)
        Me.cmb_Durum.Name = "cmb_Durum"
        Me.cmb_Durum.Size = New System.Drawing.Size(200, 33)
        Me.cmb_Durum.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(611, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Durum"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(635, 454)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 25)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "İl"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(623, 533)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 25)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "İlçe"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(611, 610)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 25)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Adres"
        '
        'rtxt_Adres
        '
        Me.rtxt_Adres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtxt_Adres.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rtxt_Adres.Location = New System.Drawing.Point(549, 638)
        Me.rtxt_Adres.Name = "rtxt_Adres"
        Me.rtxt_Adres.Size = New System.Drawing.Size(200, 104)
        Me.rtxt_Adres.TabIndex = 27
        Me.rtxt_Adres.Text = ""
        '
        'mtxt_MetreKare
        '
        Me.mtxt_MetreKare.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxt_MetreKare.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mtxt_MetreKare.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.mtxt_MetreKare.Location = New System.Drawing.Point(842, 120)
        Me.mtxt_MetreKare.Mask = "000000000"
        Me.mtxt_MetreKare.Name = "mtxt_MetreKare"
        Me.mtxt_MetreKare.Size = New System.Drawing.Size(188, 32)
        Me.mtxt_MetreKare.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(902, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 25)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Metre ²"
        '
        'txt_OdaSayisi
        '
        Me.txt_OdaSayisi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_OdaSayisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_OdaSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_OdaSayisi.Location = New System.Drawing.Point(842, 201)
        Me.txt_OdaSayisi.Name = "txt_OdaSayisi"
        Me.txt_OdaSayisi.Size = New System.Drawing.Size(188, 30)
        Me.txt_OdaSayisi.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(884, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 25)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Oda Sayısı"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(884, 262)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 25)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Bina Yaşı"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(864, 359)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 25)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Bulunduğu Kat"
        '
        'txt_BulunduguKat
        '
        Me.txt_BulunduguKat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_BulunduguKat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_BulunduguKat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_BulunduguKat.Location = New System.Drawing.Point(842, 387)
        Me.txt_BulunduguKat.Name = "txt_BulunduguKat"
        Me.txt_BulunduguKat.Size = New System.Drawing.Size(188, 30)
        Me.txt_BulunduguKat.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(849, 455)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 25)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Toplam Kat Sayısı"
        '
        'txt_ToplamKatSayisi
        '
        Me.txt_ToplamKatSayisi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ToplamKatSayisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ToplamKatSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ToplamKatSayisi.Location = New System.Drawing.Point(842, 483)
        Me.txt_ToplamKatSayisi.Name = "txt_ToplamKatSayisi"
        Me.txt_ToplamKatSayisi.Size = New System.Drawing.Size(188, 30)
        Me.txt_ToplamKatSayisi.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(902, 537)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 25)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Isıtma"
        '
        'txt_Isitma
        '
        Me.txt_Isitma.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Isitma.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Isitma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_Isitma.Location = New System.Drawing.Point(842, 565)
        Me.txt_Isitma.Name = "txt_Isitma"
        Me.txt_Isitma.Size = New System.Drawing.Size(188, 30)
        Me.txt_Isitma.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(879, 622)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 25)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Banyo Sayısı"
        '
        'txt_BanyoSayisi
        '
        Me.txt_BanyoSayisi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_BanyoSayisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_BanyoSayisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_BanyoSayisi.Location = New System.Drawing.Point(842, 650)
        Me.txt_BanyoSayisi.Name = "txt_BanyoSayisi"
        Me.txt_BanyoSayisi.Size = New System.Drawing.Size(188, 30)
        Me.txt_BanyoSayisi.TabIndex = 39
        '
        'cmb_Balkon
        '
        Me.cmb_Balkon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_Balkon.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_Balkon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Balkon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmb_Balkon.FormattingEnabled = True
        Me.cmb_Balkon.Items.AddRange(New Object() {"Var", "Yok"})
        Me.cmb_Balkon.Location = New System.Drawing.Point(1076, 121)
        Me.cmb_Balkon.Name = "cmb_Balkon"
        Me.cmb_Balkon.Size = New System.Drawing.Size(200, 33)
        Me.cmb_Balkon.TabIndex = 42
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(1134, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 25)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Balkon"
        '
        'cmb_EsyaDurumu
        '
        Me.cmb_EsyaDurumu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_EsyaDurumu.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_EsyaDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EsyaDurumu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmb_EsyaDurumu.FormattingEnabled = True
        Me.cmb_EsyaDurumu.Items.AddRange(New Object() {"Eşyalı", "Eşyasız"})
        Me.cmb_EsyaDurumu.Location = New System.Drawing.Point(1076, 198)
        Me.cmb_EsyaDurumu.Name = "cmb_EsyaDurumu"
        Me.cmb_EsyaDurumu.Size = New System.Drawing.Size(200, 33)
        Me.cmb_EsyaDurumu.TabIndex = 44
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(1108, 170)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(130, 25)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Eşya Durumu"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(1134, 262)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 25)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Aidat"
        '
        'txt_Aidat
        '
        Me.txt_Aidat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Aidat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Aidat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_Aidat.Location = New System.Drawing.Point(1076, 298)
        Me.txt_Aidat.Name = "txt_Aidat"
        Me.txt_Aidat.Size = New System.Drawing.Size(200, 30)
        Me.txt_Aidat.TabIndex = 46
        '
        'cmb_KrediyeUygun
        '
        Me.cmb_KrediyeUygun.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_KrediyeUygun.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_KrediyeUygun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_KrediyeUygun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmb_KrediyeUygun.FormattingEnabled = True
        Me.cmb_KrediyeUygun.Items.AddRange(New Object() {"Evet", "Hayır"})
        Me.cmb_KrediyeUygun.Location = New System.Drawing.Point(1076, 387)
        Me.cmb_KrediyeUygun.Name = "cmb_KrediyeUygun"
        Me.cmb_KrediyeUygun.Size = New System.Drawing.Size(200, 33)
        Me.cmb_KrediyeUygun.TabIndex = 48
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(1097, 359)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(141, 25)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Krediye Uygun"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(1109, 453)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 25)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Fiyat"
        '
        'mtxt_Fiyat
        '
        Me.mtxt_Fiyat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxt_Fiyat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mtxt_Fiyat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.mtxt_Fiyat.Location = New System.Drawing.Point(1076, 481)
        Me.mtxt_Fiyat.Mask = "000000000"
        Me.mtxt_Fiyat.Name = "mtxt_Fiyat"
        Me.mtxt_Fiyat.Size = New System.Drawing.Size(122, 32)
        Me.mtxt_Fiyat.TabIndex = 49
        '
        'cmb_ParaBirimi
        '
        Me.cmb_ParaBirimi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_ParaBirimi.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_ParaBirimi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ParaBirimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmb_ParaBirimi.FormattingEnabled = True
        Me.cmb_ParaBirimi.Items.AddRange(New Object() {"Türk Lirası", "Amerikan Doları", "Euro"})
        Me.cmb_ParaBirimi.Location = New System.Drawing.Point(1204, 480)
        Me.cmb_ParaBirimi.Name = "cmb_ParaBirimi"
        Me.cmb_ParaBirimi.Size = New System.Drawing.Size(72, 33)
        Me.cmb_ParaBirimi.TabIndex = 51
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(1199, 452)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 25)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "P. Birimi"
        '
        'cmb_Il
        '
        Me.cmb_Il.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_Il.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_Il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Il.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmb_Il.FormattingEnabled = True
        Me.cmb_Il.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"})
        Me.cmb_Il.Location = New System.Drawing.Point(549, 482)
        Me.cmb_Il.Name = "cmb_Il"
        Me.cmb_Il.Size = New System.Drawing.Size(200, 33)
        Me.cmb_Il.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1076, 581)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 55)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Kayıt Et"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_ilce
        '
        Me.txt_ilce.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ilce.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ilce.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ilce.Location = New System.Drawing.Point(549, 561)
        Me.txt_ilce.Name = "txt_ilce"
        Me.txt_ilce.Size = New System.Drawing.Size(200, 30)
        Me.txt_ilce.TabIndex = 54
        '
        'Form_KonutEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.txt_ilce)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmb_ParaBirimi)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.mtxt_Fiyat)
        Me.Controls.Add(Me.cmb_KrediyeUygun)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txt_Aidat)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmb_EsyaDurumu)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cmb_Balkon)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_BanyoSayisi)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_Isitma)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_ToplamKatSayisi)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_BulunduguKat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_OdaSayisi)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.mtxt_MetreKare)
        Me.Controls.Add(Me.rtxt_Adres)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_Il)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_Durum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_EmlakTipi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_BinaYasi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_MusteriID)
        Me.Controls.Add(Me.txt_KonutID)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView_Musteri)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_KonutEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_KonutEkle"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView_Musteri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView_Musteri As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txt_KonutID As System.Windows.Forms.TextBox
    Friend WithEvents txt_MusteriID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_BinaYasi As System.Windows.Forms.TextBox
    Friend WithEvents cmb_EmlakTipi As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Durum As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rtxt_Adres As System.Windows.Forms.RichTextBox
    Friend WithEvents mtxt_MetreKare As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_OdaSayisi As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_BulunduguKat As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_ToplamKatSayisi As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_Isitma As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_BanyoSayisi As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Balkon As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmb_EsyaDurumu As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_Aidat As System.Windows.Forms.TextBox
    Friend WithEvents cmb_KrediyeUygun As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents mtxt_Fiyat As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_ParaBirimi As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmb_Il As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_ilce As System.Windows.Forms.TextBox
End Class
