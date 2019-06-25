using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL;
using Hastane.DLL;

namespace Hastane.BLL.Manager
{
    public class KliniklerManager
    {
        Repository<vw_klinikler> rep_klivw = new Repository<vw_klinikler>();
        Repository<Klinikler> rep_kli = new Repository<Klinikler>();

        public List<vw_klinikler> Listele()
        {
            return rep_klivw.Listele();
        }

        public Klinikler KlinikGetir(int kliid)
        {
            return rep_kli.Bul(k => k.KliniklerID == kliid);
        }
    }
}
