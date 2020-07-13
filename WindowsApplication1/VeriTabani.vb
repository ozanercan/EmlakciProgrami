Imports System.Data.OleDb
Public Class VeriTabani


    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=vt.mdb;")
    Dim cmd As New OleDbCommand()
    Public da As New OleDbDataAdapter()
    Public dt As New DataTable()
    Public dt2 As New DataTable()
    Public dt3 As New DataTable()


    Function idkontrol(ByVal id As String, ByVal idturu As String) As Boolean 'Kayıt Bulursa True Döndürür
        Dim sonuc As Boolean = False
        Dim dr As OleDbDataReader
        conn.Open()
        If idturu = "Konut" Then
            cmd = New OleDbCommand("Select * From BosKonutlar where ID='" + id + "'", conn)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                sonuc = True
            Else
                cmd = New OleDbCommand("Select * From DoluKonutlar where ID='" + id + "'", conn)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    sonuc = True
                End If
            End If
        ElseIf idturu = "Arazi" Then

        End If

            cmd = New OleDbCommand("Select * From Personel where ID='" + id + "'", conn)
        dr = cmd.ExecuteReader()
            If dr.Read() Then
                sonuc = True
            Else
                cmd = New OleDbCommand("Select * From Musteri where ID='" + id + "'", conn)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    sonuc = True
                End If
            End If
            conn.Close()
            Return sonuc
    End Function
    Public Function idolustur(ByVal idturu As String) As String
        Dim random As New Random
        Dim olusturulanid As String
        Do
            olusturulanid = ""
            For index = 1 To 10
                olusturulanid += random.Next(1, 9).ToString()
            Next
        Loop While idkontrol(olusturulanid, idturu) = True
        Return olusturulanid.ToString()
    End Function

    Public Function GiriSYap(ByVal kullaniciadi As String, ByVal sifre As String) As Boolean
        Dim sonuc As Boolean = False
        conn.Open()
        cmd = New OleDbCommand("Select ID From Personel where KullaniciAdi='" + kullaniciadi + "' and Sifre='" + sifre + "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        If dr.Read() Then
            sonuc = True
        Else
            MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış!")
        End If
        conn.Close()
        Return sonuc
    End Function
    Public Function PersonelEkle(ByVal ID As String, ByVal TC As String, ByVal Ad As String, ByVal Soyad As String, ByVal CepTel As String, ByVal Il As String, ByVal Ilce As String, ByVal Adres As String, ByVal KullaniciAdi As String, ByVal Sifre As String) As Boolean
        Dim sonuc As Boolean = False
        conn.Open()
        cmd = New OleDbCommand("Insert into Personel(ID,TCNo,Ad,Soyad,CepTel,Il,Ilce,Adres,KullaniciAdi,Sifre,KayitTarihi) Values ('" + ID + "','" + TC + "','" + Ad + "','" + Soyad + "','" + CepTel + "','" + Il + "','" + Ilce + "','" + Adres + "','" + KullaniciAdi + "','" + Sifre + "',NOW())", conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        sonuc = True
        Return sonuc
    End Function
    Public Function MusteriEkle(ByVal ID As String, ByVal Tur As String, ByVal TcNo As String, ByVal Ad As String, ByVal Soyad As String, ByVal IsTel As String, ByVal EvTel As String, ByVal CepTel As String, ByVal Faks As String, ByVal Il As String, ByVal Ilce As String, ByVal Adres As String, ByVal EPosta As String, ByVal WebSite As String, ByVal Aciklama As String) As Boolean
        Dim sonuc As Boolean = False
        conn.Open()
        cmd = New OleDbCommand("Insert into Musteri(ID,Tur,TcNo,Ad,Soyad,IsTel,EvTel,CepTel,Faks,Il,Ilce,Adres,EPosta,WebSite,Aciklama,KayitTarihi) Values ('" + ID + "','" + Tur + "','" + TcNo + "','" + Ad + "','" + Soyad + "','" + IsTel + "','" + EvTel + "','" + CepTel + "','" + Faks + "','" + Il + "','" + Ilce + "','" + Adres + "','" + EPosta + "','" + WebSite + "','" + Aciklama + "',NOW())", conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        sonuc = True
        Return sonuc
    End Function

    Public Function GenelMusteriListele() As DataTable
        conn.Open()
        da = New OleDbDataAdapter("Select * From Musteri", conn)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function KonutEkle(ByVal id As String, ByVal saticiid As String, ByVal emlaktipi As String, ByVal durum As String, ByVal il As String, ByVal ilce As String, ByVal adres As String, ByVal metrekare As String, ByVal odasayisi As String, ByVal binayasi As String, ByVal bulundugukat As String, ByVal toplamkatsayisi As String, ByVal isitma As String, ByVal banyosayisi As String, ByVal balkon As String, ByVal esyadurumu As String, ByVal aidat As String, ByVal krediyeuygunmu As String, ByVal fiyat As String, ByVal parabirimi As String) As Boolean
        Dim sonuc As Boolean = False
        conn.Open()
        cmd = New OleDbCommand("insert into BosKonutlar(ID,SaticiID,EmlakTipi,Durum,Il,Ilce,Adres,MetreKare,OdaSayisi,BinaYasi,BulunduguKat,ToplamKatSayisi,Isitma,BanyoSayisi,Balkon,EsyaDurumu,Aidat,KrediyeUygunMu,Fiyat,ParaBirimi,KayitTarihi) Values ('" + id + "','" + saticiid + "','" + emlaktipi + "','" + durum + "','" + il + "','" + ilce + "','" + adres + "','" + metrekare + "','" + odasayisi + "','" + binayasi + "','" + bulundugukat + "','" + toplamkatsayisi + "','" + isitma + "','" + banyosayisi + "','" + balkon + "','" + esyadurumu + "','" + aidat + "','" + krediyeuygunmu + "','" + fiyat + "','" + parabirimi + "',NOW())", conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        sonuc = True
        Return sonuc
    End Function

    Public Function BekleyenKonutlariListele() As DataTable
        dt.Clear()
        conn.Open()
        da = New OleDbDataAdapter("Select * From BosKonutlar", conn)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function KonutListele(ByVal konutid As String) As DataTable
        dt2.Clear()
        conn.Open()
        da = New OleDbDataAdapter("Select * From BosKonutlar where ID='" + konutid + "'", conn)
        da.Fill(dt2)
        conn.Close()
        Return dt2
    End Function

    Public Function FiltreliKonutListele(ByVal Il As String, ByVal EmlakTipi As String, ByVal Durum As String, ByVal EsyaDurumu As String) As DataTable
        Dim sql As String = "Select * From BosKonutlar "
        If Il.Length >= 3 Then
            sql += "where Il='" + Il + "'"
        End If
        If EmlakTipi.Length >= 3 Then
            sql += "and EmlakTipi='" + EmlakTipi + "'"

        End If
        If Durum.Length >= 3 Then
            sql += "and Durum='" + Durum + "'"

        End If
        If EsyaDurumu.Length >= 3 Then
            sql += "and EsyaDurumu='" + EsyaDurumu + "'"

        End If
        dt.Clear()
        conn.Open()
        da = New OleDbDataAdapter(sql, conn)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function MusteriListele(ByVal islemtipi As String, ByVal veri As String) As DataTable
        dt.Clear()
        conn.Open()
        If islemtipi = "Ad" Then
            da = New OleDbDataAdapter("Select * From Musteri where Ad Like '" + veri + "%'", conn)
            da.Fill(dt)
        ElseIf islemtipi = "Tc" Then
            da = New OleDbDataAdapter("Select * From Musteri where TcNo Like '" + veri + "%'", conn)
            da.Fill(dt)
        ElseIf islemtipi = "ID" Then
            da = New OleDbDataAdapter("Select * From Musteri where ID = '" + veri + "'", conn)
            da.Fill(dt)
        Else
            da = New OleDbDataAdapter("Select * From Musteri", conn)
            da.Fill(dt)
        End If
        conn.Close()

        Return dt
    End Function
    Public Function MusteriListele2(ByVal islemtipi As String, ByVal veri As String) As DataTable
        dt3.Clear()
        conn.Open()
        If islemtipi = "Ad" Then
            da = New OleDbDataAdapter("Select * From Musteri where Ad Like '" + veri + "%'", conn)
            da.Fill(dt3)
        ElseIf islemtipi = "Tc" Then
            da = New OleDbDataAdapter("Select * From Musteri where TcNo Like '" + veri + "%'", conn)
            da.Fill(dt3)
        ElseIf islemtipi = "ID" Then
            da = New OleDbDataAdapter("Select * From Musteri where ID = '" + veri + "'", conn)
            da.Fill(dt3)
        Else
            da = New OleDbDataAdapter("Select * From Musteri", conn)
            da.Fill(dt3)
        End If
        conn.Close()

        Return dt3
    End Function
    Public Function MusteriSil(ByVal veri As String) As Boolean
        Dim sonuc As Boolean = False
        conn.Open()
        cmd = New OleDbCommand("Delete From Musteri where ID='" + veri + "'", conn)
        cmd.ExecuteNonQuery()
        sonuc = True
        conn.Close()
        Return sonuc
    End Function
    Public Function MusteriDuzenle(ByVal ID As String, ByVal Tur As String, ByVal TcNo As String, ByVal Ad As String, ByVal Soyad As String, ByVal IsTel As String, ByVal evtel As String, ByVal CepTel As String, ByVal Faks As String, ByVal Il As String, ByVal Ilce As String, ByVal Adres As String, ByVal EPosta As String, ByVal WebSite As String, ByVal Aciklama As String, ByVal KayitTarihi As String) As Boolean
        Dim sonuc As Boolean = False
        conn.Open()
        cmd = New OleDbCommand("Update Musteri set Tur='" + Tur + "', TcNo='" + TcNo + "',Ad='" + Ad + "',Soyad='" + Soyad + "',IsTel='" + IsTel + "',EvTel='" + evtel + "',CepTel='" + CepTel + "',Faks='" + Faks + "',Il='" + Il + "',Ilce='" + Ilce + "', Adres='" + Adres + "',EPosta='" + EPosta + "',WebSite='" + WebSite + "', Aciklama='" + Aciklama + "', KayitTarihi='" + KayitTarihi + "' where ID='" + ID + "'", conn)
        cmd.ExecuteNonQuery()
        sonuc = True
        conn.Close()
        Return sonuc
    End Function

    Public Function PersonelListele(ByVal islemtipi As String, ByVal veri As String) As DataTable
        dt.Clear()
        conn.Open()
        If islemtipi = "Ad" Then
            da = New OleDbDataAdapter("Select * From Personel where Ad Like '" + veri + "%'", conn)
            da.Fill(dt)
        ElseIf islemtipi = "Tc" Then
            da = New OleDbDataAdapter("Select * From Personel where TcNo Like '" + veri + "%'", conn)
            da.Fill(dt)
        Else
            da = New OleDbDataAdapter("Select * From Personel", conn)
            da.Fill(dt)
        End If
        conn.Close()

        Return dt
    End Function
    Public Function PersonelSil(ByVal veri As String) As Boolean
        Dim sonuc As Boolean = False
        conn.Open()
        cmd = New OleDbCommand("Delete From Personel where ID='" + veri + "'", conn)
        cmd.ExecuteNonQuery()
        sonuc = True
        conn.Close()
        Return sonuc
    End Function
    Public Function PersonelDuzenle(ByVal ID As String, ByVal TcNo As String, ByVal Ad As String, ByVal Soyad As String, ByVal CepTel As String, ByVal Il As String, ByVal Ilce As String, ByVal Adres As String, ByVal KullaniciAdi As String, ByVal Sifre As String, ByVal KayitTarihi As String) As Boolean
        Dim sonuc As Boolean = False
        conn.Open()
        cmd = New OleDbCommand("Update Personel set TcNo='" + TcNo + "', Ad='" + Ad + "',Soyad='" + Soyad + "',Il='" + Il + "',Ilce='" + Ilce + "',Adres='" + Adres + "',KullaniciAdi='" + KullaniciAdi + "',Sifre='" + Sifre + "',KayitTarihi='" + KayitTarihi + "' where ID='" + ID + "'", conn)
        cmd.ExecuteNonQuery()
        sonuc = True
        conn.Close()
        Return sonuc
    End Function
    Public Function KonutListele(ByVal islemtipi As String, ByVal veri As String) As DataTable
        dt.Clear()
        conn.Open()
        If islemtipi = "Konut ID" Then
            da = New OleDbDataAdapter("Select * From DoluKonutlar where ID Like '" + veri + "%'", conn)
            da.Fill(dt)
        ElseIf islemtipi = "Alıcı ID" Then
            da = New OleDbDataAdapter("Select * From DoluKonutlar where AliciID Like '" + veri + "%'", conn)
            da.Fill(dt)
        Else
            da = New OleDbDataAdapter("Select * From DoluKonutlar", conn)
            da.Fill(dt)
        End If
        conn.Close()
        Return dt
    End Function

    Public Function KonutSil(ByVal islemtipi As String, ByVal konutid As String) As Boolean
        Dim sonuc As Boolean = False
        conn.Open()
        If islemtipi = "Dolu" Then
            cmd = New OleDbCommand("Delete From DoluKonutlar where ID='" + konutid + "'", conn)
            cmd.ExecuteNonQuery()
        ElseIf islemtipi = "Boş" Then
            cmd = New OleDbCommand("Delete From BosKonutlar where ID='" + konutid + "'", conn)
            cmd.ExecuteNonQuery()
        End If
        conn.Close()
        sonuc = True
        Return sonuc
    End Function

    Public Function KonutDuzenle(ByVal islemtipi As String, ByVal id As String, ByVal saticiid As String, ByVal aliciid As String, ByVal emlaktipi As String, ByVal il As String, ByVal ilce As String, ByVal adres As String, ByVal metrekare As String, ByVal odasayisi As String, ByVal binayasi As String, ByVal bulundugukat As String, ByVal toplamkatsayisi As String, ByVal isitma As String, ByVal banyosayisi As String, ByVal balkon As String, ByVal esyadurumu As String, ByVal aidat As String, ByVal krediyeuygunmu As String, ByVal durum As String, ByVal fiyat As String, ByVal parabirimi As String, ByVal kayittarihi As String, ByVal gorsel As String) As Boolean

        Dim sonuc As Boolean = False

        conn.Open()
        If islemtipi = "Dolu" Then
            cmd = New OleDbCommand("Update DoluKonutlar set SaticiID='" + saticiid + "',AliciID='" + aliciid + "',EmlakTipi='" + emlaktipi + "',Il='" + il + "',Ilce='" + ilce + "',Adres='" + adres + "',MetreKare='" + metrekare + "',OdaSayisi='" + odasayisi + "',BinaYasi='" + binayasi + "',BulunduguKat='" + bulundugukat + "',ToplamKatSayisi='" + toplamkatsayisi + "',Isitma='" + isitma + "',BanyoSayisi='" + banyosayisi + "',Balkon='" + balkon + "',EsyaDurumu='" + esyadurumu + "',Aidat='" + aidat + "',KrediyeUygunMu='" + krediyeuygunmu + "',Durum='" + durum + "',Fiyat='" + fiyat + "',ParaBirimi='" + parabirimi + "',KayitTarihi='" + kayittarihi + "',Gorsel='" + gorsel + "' where ID='" + id + "'", conn)
        ElseIf islemtipi = "Boş" Then
            cmd = New OleDbCommand("Update BosKonutlar set SaticiID='" + saticiid + "',EmlakTipi='" + emlaktipi + "',Durum='" + durum + "',Il='" + il + "',Ilce='" + ilce + "',Adres='" + adres + "',MetreKare='" + metrekare + "',OdaSayisi='" + odasayisi + "',BinaYasi='" + binayasi + "',BulunduguKat='" + bulundugukat + "',ToplamKatSayisi='" + toplamkatsayisi + "',Isitma='" + isitma + "',BanyoSayisi='" + banyosayisi + "',Balkon='" + balkon + "',EsyaDurumu='" + esyadurumu + "',Aidat='" + aidat + "',KrediyeUygunMu='" + krediyeuygunmu + "',Fiyat='" + fiyat + "',ParaBirimi='" + parabirimi + "',KayitTarihi='" + kayittarihi + "',Gorsel='" + gorsel + "' where ID='" + id + "'", conn)

        End If
        cmd.ExecuteNonQuery()
        sonuc = True
        conn.Close()
        Return sonuc
    End Function
    Public Function EmlakIsleminiTamamla(ByVal KonutID As String, ByVal SaticiID As String, ByVal AliciID As String, ByVal Il As String, ByVal ilce As String, ByVal adres As String, ByVal EmlakTipi As String, ByVal MetreKare As String, ByVal OdaSayisi As String, ByVal BinaYasi As String, ByVal BulunduguKat As String, ByVal ToplamKatSayisi As String, ByVal Isitma As String, ByVal BanyoSayisi As String, ByVal Balkon As String, ByVal EsyaDurumu As String, ByVal Aidat As String, ByVal KrediyeUygunMu As String, ByVal Durum As String, ByVal Fiyat As String, ByVal ParaBirimi As String, ByVal gorsel As String) As Boolean

        Dim sonuc As Boolean = False
        conn.Open()
        cmd = New OleDbCommand("Insert into DoluKonutlar(ID,SaticiID,AliciID,EmlakTipi,Il,Ilce,Adres,MetreKare,OdaSayisi,BinaYasi,BulunduguKat,ToplamKatSayisi,Isitma,BanyoSayisi,Balkon,EsyaDurumu,Aidat,KrediyeUygunMu,Durum,Fiyat,ParaBirimi,KayitTarihi,Gorsel) Values('" + KonutID + "','" + SaticiID + "','" + AliciID + "','" + Il + "','" + ilce + "','" + adres + "', '" + EmlakTipi + "','" + MetreKare + "','" + OdaSayisi + "','" + BinaYasi + "','" + BulunduguKat + "','" + ToplamKatSayisi + "','" + Isitma + "','" + BanyoSayisi + "','" + Balkon + "','" + EsyaDurumu + "','" + Aidat + "','" + KrediyeUygunMu + "','" + Durum + "','" + Fiyat + "','" + ParaBirimi + "',NOW(),'" + gorsel + "')", conn)
        cmd.ExecuteNonQuery()
        conn.Close()

        conn.Open()
        cmd = New OleDbCommand("Delete From BosKonutlar where ID='" + KonutID + "'", conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        sonuc = True
        Return sonuc
    End Function
End Class
