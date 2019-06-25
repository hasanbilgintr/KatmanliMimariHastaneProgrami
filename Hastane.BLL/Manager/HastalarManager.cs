using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DLL;
using Hastane.BLL.Manager;
using System.Windows.Forms;

namespace Hastane.BLL.Manager
{
    public class HastalarManager
    {
        Repository<Hastalar> rep_has = new Repository<Hastalar>();
        Repository<vw_Hastalar> rep_hasvw = new Repository<vw_Hastalar>();

        public List<vw_Hastalar> Listele()
        {
            rep_hasvw = new Repository<vw_Hastalar>();
            return rep_hasvw.Listele();
        }

        public string Yeni(string tc, string ad, string soyad, string tel, string cinsiyet, DateTime dtarihi, int dyeriid, string medenihali, string email, int kanid, decimal kilo, decimal boy, string adres, string aciklama, int kulid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tc) && !string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(soyad))
                {
                    Hastalar AyniHasta = rep_has.Bul(k => k.HastaTC == tc);
                    if (AyniHasta == null)
                    {
                        int DoktorEkle = rep_has.Ekle(new Hastalar() { HastaTC = tc, HastaAdi = ad, HastaSoyadi = soyad, Telefon = tel, Cinsiyet = cinsiyet, DogumTarihi = dtarihi, DogumYeriID = dyeriid, MedeniHali = medenihali, Email = email, KanGrubuID = int.Parse(kanid.ToString()), HastaKilo = kilo, HastaBoy = boy, Adres = adres, Acıklama = aciklama, KullaniciID = kulid });
                        if (DoktorEkle > 0)
                        {
                            return "Hasta Ekleme Başarılı";
                        }
                        return "Hasta Ekleme Başarısız";
                    }
                    return "Girilen TCli Hastamız vardır";
                }
                return "Lütfen Tc, Ad ve Soyad Bilgilerini Giriniz.";
            }
            catch (Exception)
            {
                return "hata var ";
            }
        }

        public string Guncelle(int hastaid, Hastalar tablo)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tablo.HastaTC) && !string.IsNullOrWhiteSpace(tablo.HastaAdi) && !string.IsNullOrWhiteSpace(tablo.HastaSoyadi))
                {
                    if (hastaid != 0) //bunlara gerek kalmıcak enable olcağı için 
                    {
                        DialogResult GuncelleOnay = MessageBox.Show("Güncellemek İstediğinizden Emin Misiniz?", "Guncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (GuncelleOnay == DialogResult.Yes)
                        {
                            Hastalar Guncelle = rep_has.Bul(K => K.HastalarID == hastaid);
                            if (Guncelle != null)
                            {
                                Guncelle.HastaTC = tablo.HastaTC;
                                Guncelle.HastaAdi = tablo.HastaAdi;
                                Guncelle.HastaSoyadi = tablo.HastaSoyadi;
                                Guncelle.Telefon = tablo.Telefon;
                                Guncelle.Cinsiyet = tablo.Cinsiyet;
                                Guncelle.DogumTarihi = tablo.DogumTarihi;
                                Guncelle.DogumYeriID = tablo.DogumYeriID;
                                Guncelle.MedeniHali = tablo.MedeniHali;
                                Guncelle.Email = tablo.Email;
                                Guncelle.KanGrubuID = tablo.KanGrubuID;
                                Guncelle.HastaKilo = tablo.HastaKilo;
                                Guncelle.HastaBoy = tablo.HastaBoy;
                                Guncelle.Adres = tablo.Adres;
                                Guncelle.Acıklama = tablo.Acıklama;
                                Guncelle.KullaniciID = tablo.KullaniciID;
                            }
                            if (rep_has.Guncelle(Guncelle) > 0)
                            {
                                return "Hasta Güncelleme Başarılı";
                            }
                            return "Hasta Güncelleme Başarısız";
                        }
                        return "Güncelleme İşlemi İptal Edildi";
                    }
                    return "Listeden Seçim Yapınız";
                }
                return "Lütfen Tc,Ad ve Soyad Boş Bırakmayınız";
            }
            catch (Exception)
            {
                return "Hata var";
            }
        }

        public string Sil(int hastaid)
        {
            try
            {
                if (hastaid != 0) //buda aynı şekilde gerek kalmıcak 
                {
                    DialogResult OnaySil = MessageBox.Show("Silmek İstediğiniziden Emin Misinizi?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (OnaySil == DialogResult.Yes)
                    {
                        var HastaSil = rep_has.Bul(k => k.HastalarID == hastaid);
                        if (rep_has.Sil(HastaSil) > 0)
                        {
                            return "Hasta Silme Başarılı";
                        }
                        return "Hasta Silme Başarısız";
                    }
                    return "İşlem İptal Edildi";
                }
                return "Listeden Seçim Yapınız";
            }
            catch (Exception)
            {
                return "Hata var";
            }
        }

        public Hastalar HastaTCGetir(string hastatc)
        {
            return rep_has.Bul(k => k.HastaTC == hastatc);
        }

        public Hastalar HastaGetir(int hastaid)
        {
            return rep_has.Bul(k => k.HastalarID == hastaid);
        }
    }
}
