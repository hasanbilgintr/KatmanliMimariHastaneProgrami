using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DLL;


namespace Hastane.BLL.Manager
{
    public class illerManager
    {
        Repository<iller> rep_il = new Repository<iller>();

        public List<iller> Listele()
        {
            return rep_il.Listele();
        }

        public iller ilBul(int dogyerid)
        {
            return rep_il.Bul(k=>k.illerID==dogyerid);
        }
    }
}
