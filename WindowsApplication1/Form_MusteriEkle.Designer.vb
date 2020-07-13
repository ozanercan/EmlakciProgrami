<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_MusteriEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_MusteriEkle))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_MusteriID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_MusteriTuru = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Ad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Soyad = New System.Windows.Forms.TextBox()
        Me.mtxt_IsTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mtxt_EvTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mtxt_CepTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mtxt_Faks = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtxt_TcNo = New System.Windows.Forms.MaskedTextBox()
        Me.rtxt_Adres = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_Il = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_EPosta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_WebSite = New System.Windows.Forms.TextBox()
        Me.rtxt_Aciklama = New System.Windows.Forms.RichTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_ilce = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(307, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ID"
        '
        'txt_MusteriID
        '
        Me.txt_MusteriID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_MusteriID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_MusteriID.Enabled = False
        Me.txt_MusteriID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_MusteriID.Location = New System.Drawing.Point(162, 48)
        Me.txt_MusteriID.Name = "txt_MusteriID"
        Me.txt_MusteriID.ReadOnly = True
        Me.txt_MusteriID.Size = New System.Drawing.Size(321, 30)
        Me.txt_MusteriID.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(267, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Müşteri Türü"
        '
        'cmb_MusteriTuru
        '
        Me.cmb_MusteriTuru.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_MusteriTuru.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_MusteriTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MusteriTuru.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmb_MusteriTuru.FormattingEnabled = True
        Me.cmb_MusteriTuru.Items.AddRange(New Object() {"Genel", "Alıcı", "Satıcı"})
        Me.cmb_MusteriTuru.Location = New System.Drawing.Point(162, 127)
        Me.cmb_MusteriTuru.Name = "cmb_MusteriTuru"
        Me.cmb_MusteriTuru.Size = New System.Drawing.Size(321, 33)
        Me.cmb_MusteriTuru.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(307, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Ad"
        '
        'txt_Ad
        '
        Me.txt_Ad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Ad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_Ad.Location = New System.Drawing.Point(162, 278)
        Me.txt_Ad.Name = "txt_Ad"
        Me.txt_Ad.Size = New System.Drawing.Size(321, 30)
        Me.txt_Ad.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(294, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Soyad"
        '
        'txt_Soyad
        '
        Me.txt_Soyad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Soyad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_Soyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_Soyad.Location = New System.Drawing.Point(162, 364)
        Me.txt_Soyad.Name = "txt_Soyad"
        Me.txt_Soyad.Size = New System.Drawing.Size(321, 30)
        Me.txt_Soyad.TabIndex = 22
        '
        'mtxt_IsTel
        '
        Me.mtxt_IsTel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxt_IsTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mtxt_IsTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxt_IsTel.Location = New System.Drawing.Point(162, 450)
        Me.mtxt_IsTel.Mask = "(999) 000-0000"
        Me.mtxt_IsTel.Name = "mtxt_IsTel"
        Me.mtxt_IsTel.Size = New System.Drawing.Size(321, 30)
        Me.mtxt_IsTel.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(275, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "İş Telefonu"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(267, 501)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 25)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Ev Telefonu"
        '
        'mtxt_EvTel
        '
        Me.mtxt_EvTel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxt_EvTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mtxt_EvTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxt_EvTel.Location = New System.Drawing.Point(162, 529)
        Me.mtxt_EvTel.Mask = "(999) 000-0000"
        Me.mtxt_EvTel.Name = "mtxt_EvTel"
        Me.mtxt_EvTel.Size = New System.Drawing.Size(321, 30)
        Me.mtxt_EvTel.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(267, 583)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 25)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Cep Telefonu"
        '
        'mtxt_CepTel
        '
        Me.mtxt_CepTel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxt_CepTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mtxt_CepTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxt_CepTel.Location = New System.Drawing.Point(162, 611)
        Me.mtxt_CepTel.Mask = "(999) 000-0000"
        Me.mtxt_CepTel.Name = "mtxt_CepTel"
        Me.mtxt_CepTel.Size = New System.Drawing.Size(321, 30)
        Me.mtxt_CepTel.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(294, 659)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 25)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Faks"
        '
        'mtxt_Faks
        '
        Me.mtxt_Faks.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxt_Faks.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mtxt_Faks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxt_Faks.Location = New System.Drawing.Point(162, 687)
        Me.mtxt_Faks.Mask = "(999) 000-0000"
        Me.mtxt_Faks.Name = "mtxt_Faks"
        Me.mtxt_Faks.Size = New System.Drawing.Size(321, 30)
        Me.mtxt_Faks.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(267, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "T.C. Numarası"
        '
        'mtxt_TcNo
        '
        Me.mtxt_TcNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxt_TcNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mtxt_TcNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxt_TcNo.Location = New System.Drawing.Point(162, 207)
        Me.mtxt_TcNo.Mask = "00000000000"
        Me.mtxt_TcNo.Name = "mtxt_TcNo"
        Me.mtxt_TcNo.Size = New System.Drawing.Size(321, 30)
        Me.mtxt_TcNo.TabIndex = 32
        '
        'rtxt_Adres
        '
        Me.rtxt_Adres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtxt_Adres.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rtxt_Adres.Location = New System.Drawing.Point(506, 204)
        Me.rtxt_Adres.Name = "rtxt_Adres"
        Me.rtxt_Adres.Size = New System.Drawing.Size(321, 104)
        Me.rtxt_Adres.TabIndex = 39
        Me.rtxt_Adres.Text = ""
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(628, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 25)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Adres"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(640, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 25)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "İlçe"
        '
        'cmb_Il
        '
        Me.cmb_Il.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_Il.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_Il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Il.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmb_Il.FormattingEnabled = True
        Me.cmb_Il.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"})
        Me.cmb_Il.Location = New System.Drawing.Point(506, 48)
        Me.cmb_Il.Name = "cmb_Il"
        Me.cmb_Il.Size = New System.Drawing.Size(321, 33)
        Me.cmb_Il.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(652, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 25)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "İl"
        '
        'txt_EPosta
        '
        Me.txt_EPosta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_EPosta.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_EPosta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_EPosta.Location = New System.Drawing.Point(506, 364)
        Me.txt_EPosta.Name = "txt_EPosta"
        Me.txt_EPosta.Size = New System.Drawing.Size(321, 30)
        Me.txt_EPosta.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(628, 336)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 25)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "E-Posta"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(617, 422)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 25)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Web Site"
        '
        'txt_WebSite
        '
        Me.txt_WebSite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_WebSite.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_WebSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_WebSite.Location = New System.Drawing.Point(506, 450)
        Me.txt_WebSite.Name = "txt_WebSite"
        Me.txt_WebSite.Size = New System.Drawing.Size(321, 30)
        Me.txt_WebSite.TabIndex = 42
        '
        'rtxt_Aciklama
        '
        Me.rtxt_Aciklama.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtxt_Aciklama.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rtxt_Aciklama.Location = New System.Drawing.Point(506, 529)
        Me.rtxt_Aciklama.Name = "rtxt_Aciklama"
        Me.rtxt_Aciklama.Size = New System.Drawing.Size(321, 104)
        Me.rtxt_Aciklama.TabIndex = 45
        Me.rtxt_Aciklama.Text = ""
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(602, 501)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 25)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Açıklama / Not"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(584, 676)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 55)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Kaydet"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_ilce
        '
        Me.txt_ilce.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ilce.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_ilce.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ilce.Location = New System.Drawing.Point(506, 130)
        Me.txt_ilce.Name = "txt_ilce"
        Me.txt_ilce.Size = New System.Drawing.Size(321, 30)
        Me.txt_ilce.TabIndex = 47
        '
        'Form_MusteriEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.txt_ilce)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rtxt_Aciklama)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_WebSite)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_EPosta)
        Me.Controls.Add(Me.rtxt_Adres)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmb_Il)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mtxt_TcNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mtxt_Faks)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mtxt_CepTel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mtxt_EvTel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mtxt_IsTel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Soyad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Ad)
        Me.Controls.Add(Me.cmb_MusteriTuru)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_MusteriID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_MusteriEkle"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müşteri Ekle"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_MusteriID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_MusteriTuru As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Ad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Soyad As System.Windows.Forms.TextBox
    Friend WithEvents mtxt_IsTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mtxt_EvTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mtxt_CepTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mtxt_Faks As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents mtxt_TcNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rtxt_Adres As System.Windows.Forms.RichTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_Il As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_EPosta As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_WebSite As System.Windows.Forms.TextBox
    Friend WithEvents rtxt_Aciklama As System.Windows.Forms.RichTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_ilce As System.Windows.Forms.TextBox
End Class
