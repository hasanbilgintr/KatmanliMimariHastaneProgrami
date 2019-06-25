using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hastane.DLL;
using Hastane.BLL;

namespace Hastane.BLL.Manager
{
    public class KanGruplariManager
    {
        Repository<vw_KanGruplari> rep_kan = new Repository<vw_KanGruplari>();

        public List<vw_KanGruplari> Listele()
        {
            return rep_kan.Listele();
        }
    }
}
