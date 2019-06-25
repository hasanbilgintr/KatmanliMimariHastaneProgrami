using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DLL;

namespace Hastane.BLL.Manager
{
    public class KullanicilarManager
    {
        Repository<Kullanicilar> rep_kul = new Repository<Kullanicilar>();

        public List<Kullanicilar> Listele()
        {
            return rep_kul.Listele();
        }

        public string KulAdi;
        public string Yetki;

        public Kullanicilar login(string kuladi, string sifre)
        {
            var giris = rep_kul.Bul(k => k.KullaniciAdi == kuladi && k.KullaniciSifre == sifre);
            if (giris != null)
            {
                KulAdi = giris.KullaniciAdi;
                Yetki = giris.Yetkiler.YetkiAdi;
            }
            return giris;
        }

        public string Ekle(string tc, string ad, string sifre, int yetki)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tc) && !string.IsNullOrWhiteSpace(ad) && !string.IsNullOrWhiteSpace(sifre))
                {
                    Kullanicilar tcayni = rep_kul.Bul(K => K.KullaniciTC == tc);
                    if (tcayni == null)
                    {
                        Kullanicilar adayni = rep_kul.Bul(K => K.KullaniciAdi == ad);
                        if (adayni == null)
                        {
                            int KulEkle = rep_kul.Ekle(new Kullanicilar() { KullaniciTC = tc, KullaniciAdi = ad, KullaniciSifre = sifre, YetkiID = yetki });
                            if (KulEkle > 0)
                            {
                                return "Kullanıcı Ekleme Başarılı";
                            }
                            return "Kullanıcı Ekleme Başarısız";
                        }
                        return "Lütfen Kullanıcı Adı Farklı Giriniz";
                    }
                    return "Böyle Bir TCli Kullanıcımız var";
                }
                return "TC,Kullanıcı Adı ve Şifresi Boş Bırakılmaz";
            }
            catch (Exception)
            {
                return "Hata Vardır Yetkiliye Bildirin";
            }
        }
    }
}
