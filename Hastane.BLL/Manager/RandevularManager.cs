using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.DLL;

namespace Hastane.BLL.Manager
{
    public class RandevularManager
    {
        Repository<Randevular> rep_ran = new Repository<Randevular>();
        Repository<vw_Randevular> rep_ranvw = new Repository<vw_Randevular>();

        public List<vw_Randevular> randevuListesi()
        {
            rep_ranvw = new Repository<vw_Randevular>();
            return rep_ranvw.Liste(k => (k.RandevuTarihi.Year == DateTime.Now.Year && k.RandevuTarihi.Month == DateTime.Now.Month && k.RandevuTarihi.Day >= DateTime.Now.Day) || (k.RandevuTarihi.Year == DateTime.Now.Year && k.RandevuTarihi.Month > DateTime.Now.Month) || (k.RandevuTarihi.Year > DateTime.Now.Year));
            //return rep_ranvw.Liste(k => k.RandevuTarihi >= DateTime.Now); //aynımış :D
        }

        public Randevular randevuaynimi(int doktorid, int klinikid, int hastaid, int yil, int ay, int gun)
        {
            return rep_ran.Bul(k => k.DoktorID == doktorid && k.KlinikID == klinikid && k.HastaID == hastaid && k.RandevuTarihi.Year == yil && k.RandevuTarihi.Month == ay && k.RandevuTarihi.Day == gun);
        }

        public Randevular saatdolumu(string saat, int yil, int ay, int gun, int doktorid, int klinikid)
        {
            return rep_ran.Bul(k => k.RandevuSaati == saat && k.RandevuTarihi.Year == yil && k.RandevuTarihi.Month == ay && k.RandevuTarihi.Day == gun && k.DoktorID == doktorid && k.KlinikID == klinikid);
        }

        public string Ekle(int hastaid, int klinikid, int doktorid, DateTime rantarihi, string ransaat, string aciklama, int kullaniciid)
        {

            if (hastaid != 0 && !string.IsNullOrWhiteSpace(klinikid.ToString()) && doktorid != 0 && !string.IsNullOrWhiteSpace(ransaat.ToString()))
            {
                int randevuekle = rep_ran.Ekle(new Randevular() { HastaID = hastaid, KlinikID = klinikid, DoktorID = doktorid, RandevuTarihi = rantarihi, RandevuSaati = ransaat, Aciklama = aciklama, KullaniciID = kullaniciid });
                if (randevuekle > 0)
                {
                    return "Randevu Kayıdı Başarılı";
                }
                return "Randevu Kayıdı Başarısız";
            }
            return "lütfen Hasta , Klinik , Doktor  ve Saat boş bırakmayınız";

        }

        public void checkboxaktif(CheckBox _0900, CheckBox _0930, CheckBox _1000, CheckBox _1030, CheckBox _1100, CheckBox _1130, CheckBox _1300, CheckBox _1330, CheckBox _1400, CheckBox _1430, CheckBox _1500, CheckBox _1530)
        {
            CheckBox[] aktif = { _0900, _0930, _1000, _1030, _1100, _1130, _1300, _1330, _1400, _1430, _1500, _1530 };

            for (int i = 0; i < aktif.Length; i++)
            {
                aktif[i].Enabled = true;
                aktif[i].BackColor = Color.Transparent;
                aktif[i].Checked = false;
            }
        }

        public void checkboxpasif(CheckBox _0900, CheckBox _0930, CheckBox _1000, CheckBox _1030, CheckBox _1100, CheckBox _1130, CheckBox _1300, CheckBox _1330, CheckBox _1400, CheckBox _1430, CheckBox _1500, CheckBox _1530)
        {
            CheckBox[] pasif = { _0900, _0930, _1000, _1030, _1100, _1130, _1300, _1330, _1400, _1430, _1500, _1530, };

            for (int i = 0; i < pasif.Length; i++)
            {
                pasif[i].Enabled = false;
                pasif[i].BackColor = Color.Red;
                pasif[i].Checked = false;
            }
        }

        public void checkboxpasifredsiz(CheckBox _0900, CheckBox _0930, CheckBox _1000, CheckBox _1030, CheckBox _1100, CheckBox _1130, CheckBox _1300, CheckBox _1330, CheckBox _1400, CheckBox _1430, CheckBox _1500, CheckBox _1530)
        {
            CheckBox[] pasif = { _0900, _0930, _1000, _1030, _1100, _1130, _1300, _1330, _1400, _1430, _1500, _1530, };

            for (int i = 0; i < pasif.Length; i++)
            {
                pasif[i].Enabled = false;
                pasif[i].BackColor = Color.Transparent;
                pasif[i].Checked = false;
            }
        }

        public string isaretli(CheckBox _0900, CheckBox _0930, CheckBox _1000, CheckBox _1030, CheckBox _1100, CheckBox _1130, CheckBox _1300, CheckBox _1330, CheckBox _1400, CheckBox _1430, CheckBox _1500, CheckBox _1530)
        {
            bool[] isaretli = { _0900.Checked, _0930.Checked, _1000.Checked, _1030.Checked, _1100.Checked, _1130.Checked, _1300.Checked, _1330.Checked, _1400.Checked, _1430.Checked, _1500.Checked, _1530.Checked, };
            string[] saat = { "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30" };
            for (int i = 0; i < saat.Length; i++)
            {
                if (isaretli[i] == true)
                {
                    return saat[i];
                }
            }
            return "işaretlenmedi";
        }

        public Randevular RandevuIDGetir(int RanID)
        {
            return rep_ran.Bul(k => k.RandevularID == RanID);
        }

        public void isaretle(string isaretlisaat, CheckBox _0900, CheckBox _0930, CheckBox _1000, CheckBox _1030, CheckBox _1100, CheckBox _1130, CheckBox _1300, CheckBox _1330, CheckBox _1400, CheckBox _1430, CheckBox _1500, CheckBox _1530)
        {
            CheckBox[] isaretli = { _0900, _0930, _1000, _1030, _1100, _1130, _1300, _1330, _1400, _1430, _1500, _1530 };
            string[] saat = { "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30" };
            for (int i = 0; i < saat.Length; i++)
            {
                if (isaretlisaat == saat[i])
                {
                    isaretli[i].Checked = true;
                }
            }
        }

        public string Guncelle(int RanID, Randevular tablo)
        {
            try
            {
                var RanGuncelle = rep_ran.Bul(K => K.RandevularID == RanID);
                DialogResult onayguncelle = MessageBox.Show("Güncelleme Yapmak İstediğinizden Emin misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onayguncelle == DialogResult.Yes)
                {
                    if (RanGuncelle != null)
                    {
                        RanGuncelle.HastaID = tablo.HastaID;
                        RanGuncelle.KlinikID = tablo.KlinikID;
                        RanGuncelle.DoktorID = tablo.DoktorID;
                        RanGuncelle.RandevuTarihi = tablo.RandevuTarihi;
                        RanGuncelle.RandevuSaati = tablo.RandevuSaati;
                        RanGuncelle.Aciklama = tablo.Aciklama;
                        RanGuncelle.KullaniciID = tablo.KullaniciID;
                    }
                    if (rep_ran.Guncelle(tablo) > 0)
                    {
                        return "Randevu Güncellemesi Başarılı";
                    }
                    return "Randevu Güncellemesi Başarısız";
                }
                return "İşlem İptal Edildi";
            }
            catch (Exception)
            {
                return "Hata var";
            }
        }

        public string Sil(int RanID)
        {
            try
            {
                var RanSil = rep_ran.Bul(K => K.RandevularID == RanID);
                DialogResult onaysil = MessageBox.Show("Silmek Yapmak İstediğinizden Emin misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onaysil == DialogResult.Yes)
                {
                    if (rep_ran.Sil(RanSil) > 0)
                    {
                        return "Randevu Silme Başarılı";
                    }
                    return "Randevu Silme Başarısız";
                }
                return "İşlem İptal Edildi";
            }
            catch (Exception)
            {
                return "Hata var";
            }
        }

    }
}
