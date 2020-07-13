<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KonutİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniKonutKaydıEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BekleyenKonutlarıGörToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoluKonutlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MüşteriİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniMüşteriEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MüşteriDüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonelİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniPersonelEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonelDüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KonutİşlemleriToolStripMenuItem, Me.MüşteriİşlemleriToolStripMenuItem, Me.PersonelİşlemleriToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 37)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KonutİşlemleriToolStripMenuItem
        '
        Me.KonutİşlemleriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniKonutKaydıEkleToolStripMenuItem, Me.BekleyenKonutlarıGörToolStripMenuItem, Me.DoluKonutlarToolStripMenuItem})
        Me.KonutİşlemleriToolStripMenuItem.Name = "KonutİşlemleriToolStripMenuItem"
        Me.KonutİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(120, 33)
        Me.KonutİşlemleriToolStripMenuItem.Text = "Konut İşlemleri"
        '
        'YeniKonutKaydıEkleToolStripMenuItem
        '
        Me.YeniKonutKaydıEkleToolStripMenuItem.Name = "YeniKonutKaydıEkleToolStripMenuItem"
        Me.YeniKonutKaydıEkleToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.YeniKonutKaydıEkleToolStripMenuItem.Text = "Yeni Konut Kaydı Ekle"
        '
        'BekleyenKonutlarıGörToolStripMenuItem
        '
        Me.BekleyenKonutlarıGörToolStripMenuItem.Name = "BekleyenKonutlarıGörToolStripMenuItem"
        Me.BekleyenKonutlarıGörToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.BekleyenKonutlarıGörToolStripMenuItem.Text = "Bekleyen Konutları Gör"
        '
        'DoluKonutlarToolStripMenuItem
        '
        Me.DoluKonutlarToolStripMenuItem.Name = "DoluKonutlarToolStripMenuItem"
        Me.DoluKonutlarToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.DoluKonutlarToolStripMenuItem.Text = "Dolu Konutlar"
        '
        'MüşteriİşlemleriToolStripMenuItem
        '
        Me.MüşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniMüşteriEkleToolStripMenuItem, Me.MüşteriDüzenleToolStripMenuItem})
        Me.MüşteriİşlemleriToolStripMenuItem.Name = "MüşteriİşlemleriToolStripMenuItem"
        Me.MüşteriİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(130, 33)
        Me.MüşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri"
        '
        'YeniMüşteriEkleToolStripMenuItem
        '
        Me.YeniMüşteriEkleToolStripMenuItem.Name = "YeniMüşteriEkleToolStripMenuItem"
        Me.YeniMüşteriEkleToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.YeniMüşteriEkleToolStripMenuItem.Text = "Yeni Müşteri Ekle"
        '
        'MüşteriDüzenleToolStripMenuItem
        '
        Me.MüşteriDüzenleToolStripMenuItem.Name = "MüşteriDüzenleToolStripMenuItem"
        Me.MüşteriDüzenleToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.MüşteriDüzenleToolStripMenuItem.Text = "Müşteri Düzenle/Sil"
        '
        'PersonelİşlemleriToolStripMenuItem
        '
        Me.PersonelİşlemleriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniPersonelEkleToolStripMenuItem, Me.PersonelDüzenleToolStripMenuItem})
        Me.PersonelİşlemleriToolStripMenuItem.Name = "PersonelİşlemleriToolStripMenuItem"
        Me.PersonelİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(136, 33)
        Me.PersonelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri"
        '
        'YeniPersonelEkleToolStripMenuItem
        '
        Me.YeniPersonelEkleToolStripMenuItem.Name = "YeniPersonelEkleToolStripMenuItem"
        Me.YeniPersonelEkleToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.YeniPersonelEkleToolStripMenuItem.Text = "Yeni Personel Ekle"
        '
        'PersonelDüzenleToolStripMenuItem
        '
        Me.PersonelDüzenleToolStripMenuItem.Name = "PersonelDüzenleToolStripMenuItem"
        Me.PersonelDüzenleToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.PersonelDüzenleToolStripMenuItem.Text = "Personel Düzenle/Sil"
        '
        'Form_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KonutİşlemleriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MüşteriİşlemleriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonelİşlemleriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YeniKonutKaydıEkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BekleyenKonutlarıGörToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YeniMüşteriEkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MüşteriDüzenleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YeniPersonelEkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonelDüzenleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoluKonutlarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
