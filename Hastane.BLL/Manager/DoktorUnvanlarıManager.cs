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
    public class DoktorUnvanlarıManager
    {
        Repository<vw_DoktorUnvanlari> rep_dokunvvw = new Repository<vw_DoktorUnvanlari>();
        Repository<DoktorUnvanlari> rep_dokun = new Repository<DoktorUnvanlari>();

        public List<vw_DoktorUnvanlari> Listele()
        {
            return rep_dokunvvw.Listele();
        }

        public string Ekle(string Unvan, int bransid, string dipno, int kulid)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Unvan))
                {
                    int ekle = rep_dokun.Ekle(new DoktorUnvanlari() { UnvanAdi = Unvan, BransID = bransid, DiplomaNumarasi = dipno, KullaniciID = kulid });
                    if (ekle > 0)
                    {
                        return "Ekleme Başarılı";
                    }
                    return "Ekleme Başarısız";
                }
                return "Unvan Adı Boş Bırakılamaz";
            }
            catch (Exception)
            {
                return "Hata var Kontrol Ediniz";
            }
        }
        public string Guncelle(int dokunid, DoktorUnvanlari tablo)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tablo.UnvanAdi))
                {
                    DoktorUnvanlari guncelle = rep_dokun.Bul(k => k.DoktorUnvanlariID == dokunid);

                    DialogResult onayguncel = MessageBox.Show("Güncellemek istediğinizden Emin misiniz?", "Güncelleme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (onayguncel == DialogResult.Yes)
                    {
                        if (guncelle != null)
                        {
                            guncelle.UnvanAdi = tablo.UnvanAdi;
                            guncelle.BransID = tablo.BransID;
                            guncelle.DiplomaNumarasi = tablo.DiplomaNumarasi;
                            guncelle.KullaniciID = tablo.KullaniciID;
                        }
                        if (rep_dokun.Guncelle(tablo) > 0)
                        {
                            return "Guncelleme Başarılı";
                        }
                        return "Guncelleme Başarısız";
                    }
                    return "İşlem İptal Edildi";
                }
                return "Lütfen Unvan Adı Giriniz";
            }
            catch (Exception)
            {
                return "hata var yetkiliye bildirin";
            }

        }

        public string Sil(int dokunid)
        {
            try
            {
                DoktorUnvanlari dokunSil = rep_dokun.Bul(k => k.DoktorUnvanlariID == dokunid);

                DialogResult onaysil = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Silme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onaysil == DialogResult.Yes)
                {
                    if (rep_dokun.Sil(dokunSil) != 0)
                    {
                        return "Silme Başarılı";
                    }
                    return "Silme Başarısız";
                }
                return "İşlem İptal Edildi";
            }
            catch (Exception)
            {
                return "Hata var Lütfen Yetkiliye Bildiriniz";
            }
        }

        public DoktorUnvanlari DoktorUnvGetir(int dokunid)
        {
            rep_dokun = new Repository<DoktorUnvanlari>();
            return rep_dokun.Bul(k => k.DoktorUnvanlariID == dokunid);
        }

        public List<vw_DoktorUnvanlari> DoktorUnvaniAra(string unvanadi)
        {
            return rep_dokunvvw.Liste(K => K.UnvanAdi.Contains(unvanadi));
        }
    }
}
