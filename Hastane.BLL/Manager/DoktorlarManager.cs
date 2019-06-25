using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.DLL;

namespace Hastane.BLL.Manager
{
    public class DoktorlarManager
    {
        Repository<vw_Doktorlar> rep_dokvw = new Repository<vw_Doktorlar>();
        Repository<Doktorlar> rep_dok = new Repository<Doktorlar>();

        public List<vw_Doktorlar> Listele()
        {
            return rep_dokvw.Listele();

        }


        public string Ekle(string tc, string ad, string soyad, string cinsiyet, string tel, string email, string medenihali, DateTime dtarih, int dyeriid, int kanid, int dokunvanid, string adres, int kulid, int klinid, string resim)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tc) && !string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(soyad))
                {
                    Doktorlar doktorayni = rep_dok.Bul(k => k.DoktorTC == tc);
                    if (doktorayni == null)
                    {
                        int ekle = rep_dok.Ekle(new Doktorlar()
                        { DoktorTC = tc, DoktorAdi = ad, DoktorSoyadi = soyad, DoktorCinsiyet = cinsiyet, DoktorTelefon = tel, Email = email, MedeniHali = medenihali, DogumTarihi = dtarih, DogumYeriID = dyeriid, KanGrubuID = kanid, DoktorUnvanID = dokunvanid, Adres = adres, KullaniciID = kulid, KlinikID = klinid, Resim = resim });

                        if (ekle > 0)
                        {
                            return "Ekleme Başarılı";
                        }
                        return "Ekleme Başarısız"; 
                    }
                    return "Doktor Adı Aynı kayıt var";
                }
                return "Lütfen Tc ,Ad ve soyad giriniz";
            }
            catch (Exception)
            {
                return "Hata Vardır Yetkiliye Bildirin";
            }
        }

        public Doktorlar DoktorGetir(int doktorid)
        {
            rep_dok = new Repository<Doktorlar>();
            return rep_dok.Bul(k => k.DoktorlarID == doktorid);
        }

        public string Guncelle(int Doktorid, Doktorlar tablo)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tablo.DoktorTC))
                {
                    Doktorlar Guncelle = rep_dok.Bul(k => k.DoktorlarID == Doktorid);
                    DialogResult onayguncelle = MessageBox.Show("Güncellemek istediğiniziden Emin misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onayguncelle == DialogResult.Yes)
                    {
                        if (Guncelle != null)
                        {
                            Guncelle.DoktorTC = tablo.DoktorTC;
                            Guncelle.DoktorAdi = tablo.DoktorAdi;
                            Guncelle.DoktorSoyadi = tablo.DoktorSoyadi;
                            Guncelle.DoktorCinsiyet = tablo.DoktorCinsiyet;
                            Guncelle.DoktorTelefon = tablo.DoktorTelefon;
                            Guncelle.Email = tablo.Email;
                            Guncelle.MedeniHali = tablo.MedeniHali;
                            Guncelle.DogumTarihi = tablo.DogumTarihi;
                            Guncelle.DogumYeriID = tablo.DogumYeriID;
                            Guncelle.KanGrubuID = tablo.KanGrubuID;
                            Guncelle.DoktorUnvanID = tablo.DoktorUnvanID;
                            Guncelle.Adres = tablo.Adres;
                            Guncelle.KullaniciID = tablo.KullaniciID;
                            Guncelle.KlinikID = tablo.KlinikID;
                            Guncelle.Resim = tablo.Resim;
                        }
                        if (rep_dok.Guncelle(tablo) > 0)
                        {
                            return "Guncelleme Başarılı";
                        }
                        return "Guncelleme Başarısız";
                    }
                    return "İşlem İptal Edildi";
                }
                return "Lütfen doktorTc giriniz";
            }
            catch (Exception)
            {
                return "Hata Vardır Yetkiliye Bildirin";
            }
        }

        public string Sil(int doktorid)
        {
            try
            {
                DialogResult onaysil = MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (onaysil == DialogResult.Yes)
                {
                    Doktorlar doktorsil = rep_dok.Bul(K => K.DoktorlarID == doktorid);
                    if (rep_dok.Sil(doktorsil) > 0)
                    {
                        return "Silme Başarılı";
                    }
                    return "Silme Başarısız";
                }
                return "İşlem İptal edildi";
            }
            catch (Exception)
            {
                return "Hata var ";
            }
        }

        public List<Doktorlar> klinikIDdoktorGetir(int klinikid)
        {
            return rep_dok.Liste(k => k.KlinikID == klinikid);
        }

        public List<vw_Doktorlar> OgrenciAra(string tc)
        {
            return rep_dokvw.Liste(K => K.DoktorTC.Contains(tc));
        }
    }
}
