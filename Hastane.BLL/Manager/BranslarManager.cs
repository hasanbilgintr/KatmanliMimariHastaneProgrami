using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.BLL.Manager;
using Hastane.DLL;

namespace Hastane.BLL.Manager
{
    public class BranslarManager
    {
        Repository<vw_Branslar> rep_bravw = new Repository<vw_Branslar>();
        Repository<Branslar> rep_bra = new Repository<Branslar>();

        public List<vw_Branslar> Listele()
        {
            return rep_bravw.Listele();
        }

        public Branslar BransGetir(int bransid)
        {
            rep_bra = new Repository<Branslar>();
            return rep_bra.Bul(k => k.BranslarID == bransid);
        }

        public string Ekle(string brans, int kulid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(brans))
                {
                    Branslar aynibrans = rep_bra.Bul(k => k.BransAdi == brans);
                    if (aynibrans == null)
                    {
                        int ekle = rep_bra.Ekle(new Branslar() { BransAdi = brans, KullaniciID = kulid });
                        if (ekle > 0)
                        {
                            return "Ekleme Başarılı";
                        }
                        return "Ekleme Başarısız";
                    }
                    return "Aynı Brans Adında Kayıt vardır";
                }
                return "Lütfen Branş Adını Giriniz";
            }
            catch (Exception)
            {
                return "Hata Var Yetkiliye Bildirin";
            }

        }
        public string guncelle(int bransid, Branslar tablo)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tablo.BransAdi))
                {
                    Branslar aynibrans = rep_bra.Bul(k => k.BransAdi == tablo.BransAdi);
                    if (aynibrans == null)
                    {
                        Branslar bransGuncelle = rep_bra.Bul(k => k.BranslarID == bransid);

                        DialogResult onayguncelle = MessageBox.Show("Guncellemek istediğinizden Emin misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (onayguncelle == DialogResult.Yes)
                        {
                            if (bransGuncelle != null)
                            {
                                bransGuncelle.BransAdi = tablo.BransAdi;
                                bransGuncelle.KullaniciID = tablo.KullaniciID;
                            }
                            if (rep_bra.Guncelle(tablo) > 0)
                            {
                                return "Güncelleme Başarılı";
                            }
                            return "Güncelleme Başarısız";
                        }
                        return "İşlem İptal Edildi";
                    }
                    return "Aynı Bras Adında Kayıt var";
                }
                return "Branş Adını Doldurunuz";
            }
            catch (Exception)
            {
                return "Hata var";
            }

        }
        public string Sil(int bransid)
        {
            try
            {
                Branslar BransSil = rep_bra.Bul(k => k.BranslarID == bransid);

                DialogResult onaysil = MessageBox.Show("Silmek İstediğinizden Emin Misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onaysil == DialogResult.Yes)
                {
                    if (rep_bra.Sil(BransSil) > 0)
                    {
                        return "Silme Başarılı";
                    }
                    return "Silme Başarısız";
                }
                return "İşlem İptal Edildi";
            }
            catch (Exception)
            {
                return "Hata var";
            }
        }

        public List<vw_Branslar> BransAdiAra(string BransAdi)
        {
            return rep_bravw.Liste(k => k.BransAdi.Contains(BransAdi));
        }
    }
}
