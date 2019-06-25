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
    public class DoktorBilgileriManager
    {
        Repository<vw2_DoktorBilgileri> rep_dokbilgvw = new Repository<vw2_DoktorBilgileri>();
        Repository<DoktorBilgileri> rep_dokbilg = new Repository<DoktorBilgileri>();

        public List<vw2_DoktorBilgileri> Listele()
        {
            return rep_dokbilgvw.Listele();
        }

        public string Ekle(int doktorid, DateTime girtah, DateTime ciktar, bool aktifmi, int kulid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(doktorid.ToString()) && !string.IsNullOrWhiteSpace(girtah.ToString()) && !string.IsNullOrWhiteSpace(ciktar.ToString()))
                {
                    int ekle = rep_dokbilg.Ekle(new DoktorBilgileri()
                    { DoktorID = doktorid, GirisTarihi = girtah, CikisTarihi = ciktar, AktifMi = aktifmi, KullaniciID = kulid });

                    if (ekle > 0)
                    {
                        return "Ekleme Başarılı";
                    }
                    return "Ekleme Başarısız";
                }
                return "Lütfen doktor,giris tarihi ve çıkış tarihi giriniz";
            }
            catch (Exception)
            {
                return "Hata Vardır Yetkiliye Bildirin";
            }
        }

        public string Guncelle(int Dokbilgid, DoktorBilgileri tablo)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tablo.DoktorID.ToString()) && !string.IsNullOrWhiteSpace(tablo.GirisTarihi.ToString()))
                {
                    DoktorBilgileri Guncelle = rep_dokbilg.Bul(k => k.DoktorBilgileriID == Dokbilgid);
                    DialogResult onayguncelle = MessageBox.Show("Güncellemek istediğiniziden Emin misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onayguncelle == DialogResult.Yes)
                    {
                        if (Guncelle != null)
                        {
                            Guncelle.DoktorID = tablo.DoktorID;
                            Guncelle.GirisTarihi = tablo.GirisTarihi;
                            Guncelle.CikisTarihi = tablo.CikisTarihi;
                            Guncelle.AktifMi = tablo.AktifMi;
                        }
                        if (rep_dokbilg.Guncelle(tablo) > 0)
                        {
                            return "Guncelleme Başarılı";
                        }
                        return "Guncelleme Başarısız";
                    }
                    return "İşlem İptal Edildi";
                }
                return "Lütfen doktor,giris tarihi ve çıkış tarihi giriniz";
            }
            catch (Exception)
            {
                return "Hata Vardır Yetkiliye Bildirin";
            }

        }

        public string Sil(int Dokbilgid)
        {
            try
            {
                DoktorBilgileri doktorsil = rep_dokbilg.Bul(k => k.DoktorBilgileriID == Dokbilgid);

                DialogResult silmesaj = MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (silmesaj == DialogResult.Yes)
                {
                    if (rep_dokbilg.Sil(doktorsil) > 0)
                    {
                        return "Silme Başarılı";
                    }
                    return "Silme Başarısız";
                }
                return "İşlem İptal Edildi";
            }
            catch (Exception)
            {
                return "Hata Vardır Yetkiliye Bildirin";
            }

        }


        public string aktifmiE(string a)
        {
            if (a == "Evet")
            {
                return "True";
            }
            return "False";
        }

        public string aktifmiT(string a)
        {
            if (a == "True")
            {
                return "Evet";
            }
            return "Hayır";
        }


        public DoktorBilgileri DokBilgGetir(int doktorid)
        {
            rep_dokbilg = new Repository<DoktorBilgileri>();
            return rep_dokbilg.Bul(k => k.DoktorBilgileriID == doktorid);
        }

        public List<vw2_DoktorBilgileri> DoktorGirisCikis(DateTime girtar, DateTime ciktar)
        {
            return rep_dokbilgvw.Liste(k => k.GirisTarihi >= girtar && k.CikisTarihi <= ciktar);
        }
    }
}
