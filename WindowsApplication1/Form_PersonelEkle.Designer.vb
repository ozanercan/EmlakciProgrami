<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_PersonelEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_PersonelEkle))
        Me.txt_PersonelID = New System.Windows.Forms.TextBox()
        Me.mtxt_TcNo = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Ad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Soyad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtxt_CepTel = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_Il = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rtxt_Adres = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_KullaniciAdi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Sifre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_ilce = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_PersonelID
        '
        Me.txt_PersonelID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_PersonelID.Enabled = False
        Me.txt_PersonelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_PersonelID.Location = New System.Drawing.Point(667, 49)
        Me.txt_PersonelID.Name = "txt_PersonelID"
        Me.txt_PersonelID.ReadOnly = True
        Me.txt_PersonelID.Size = New System.Drawing.Size(247, 30)
        Me.txt_PersonelID.TabIndex = 0
        '
        'mtxt_TcNo
        '
        Me.mtxt_TcNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxt_TcNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxt_TcNo.Location = New System.Drawing.Point(162, 45)
        Me.mtxt_TcNo.Mask = "00000000000"
        Me.mtxt_TcNo.Name = "mtxt_TcNo"
        Me.mtxt_TcNo.Size = New System.Drawing.Size(247, 30)
        Me.mtxt_TcNo.TabIndex = 1
        '
        'txt_Ad
        '
        Me.txt_Ad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_Ad.Location = New System.Drawing.Point(162, 120)
        Me.txt_Ad.Name = "txt_Ad"
        Me.txt_Ad.Size = New System.Drawing.Size(247, 30)
        Me.txt_Ad.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(776, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(223, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "T.C. Numarası"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(264, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ad"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(254, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Soyad"
        '
        'txt_Soyad
        '
        Me.txt_Soyad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Soyad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_Soyad.Location = New System.Drawing.Point(162, 203)
        Me.txt_Soyad.Name = "txt_Soyad"
        Me.txt_Soyad.Size = New System.Drawing.Size(247, 30)
        Me.txt_Soyad.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(223, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cep Telefonu"
        '
        'mtxt_CepTel
        '
        Me.mtxt_CepTel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxt_CepTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxt_CepTel.Location = New System.Drawing.Point(162, 285)
        Me.mtxt_CepTel.Mask = "(999) 000-0000"
        Me.mtxt_CepTel.Name = "mtxt_CepTel"
        Me.mtxt_CepTel.Size = New System.Drawing.Size(247, 30)
        Me.mtxt_CepTel.TabIndex = 8
        '
        'cmb_Il
        '
        Me.cmb_Il.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_Il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Il.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cmb_Il.FormattingEnabled = True
        Me.cmb_Il.Items.AddRange(New Object() {"Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "K.maraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"})
        Me.cmb_Il.Location = New System.Drawing.Point(162, 359)
        Me.cmb_Il.Name = "cmb_Il"
        Me.cmb_Il.Size = New System.Drawing.Size(247, 33)
        Me.cmb_Il.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(264, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "İl"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(254, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "İlçe"
        '
        'rtxt_Adres
        '
        Me.rtxt_Adres.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtxt_Adres.Location = New System.Drawing.Point(165, 515)
        Me.rtxt_Adres.Name = "rtxt_Adres"
        Me.rtxt_Adres.Size = New System.Drawing.Size(244, 150)
        Me.rtxt_Adres.TabIndex = 14
        Me.rtxt_Adres.Text = ""
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(254, 487)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Adres"
        '
        'txt_KullaniciAdi
        '
        Me.txt_KullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_KullaniciAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_KullaniciAdi.Location = New System.Drawing.Point(667, 207)
        Me.txt_KullaniciAdi.Name = "txt_KullaniciAdi"
        Me.txt_KullaniciAdi.Size = New System.Drawing.Size(254, 30)
        Me.txt_KullaniciAdi.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(731, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Kullanıcı Adı"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(766, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 25)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Şifre"
        '
        'txt_Sifre
        '
        Me.txt_Sifre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Sifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_Sifre.Location = New System.Drawing.Point(667, 285)
        Me.txt_Sifre.Name = "txt_Sifre"
        Me.txt_Sifre.Size = New System.Drawing.Size(254, 30)
        Me.txt_Sifre.TabIndex = 18
        Me.txt_Sifre.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(667, 515)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(254, 55)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_ilce
        '
        Me.txt_ilce.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ilce.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ilce.Location = New System.Drawing.Point(155, 433)
        Me.txt_ilce.Name = "txt_ilce"
        Me.txt_ilce.Size = New System.Drawing.Size(254, 30)
        Me.txt_ilce.TabIndex = 21
        '
        'Form_PersonelEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.txt_ilce)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_Sifre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_KullaniciAdi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rtxt_Adres)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_Il)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mtxt_CepTel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Soyad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Ad)
        Me.Controls.Add(Me.mtxt_TcNo)
        Me.Controls.Add(Me.txt_PersonelID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_PersonelEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_PersonelEkle"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_PersonelID As System.Windows.Forms.TextBox
    Friend WithEvents mtxt_TcNo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Ad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Soyad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mtxt_CepTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_Il As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rtxt_Adres As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_KullaniciAdi As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Sifre As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_ilce As System.Windows.Forms.TextBox
End Class
