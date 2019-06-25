using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.BLL.Manager;
using Hastane.DLL;

namespace Hastane.UI
{
    public partial class FrmBransKayitGuncelSil : Form
    {
        public FrmBransKayitGuncelSil()
        {
            InitializeComponent();
        }

        BranslarManager bra_man = new BranslarManager();

        private void simpleButton_kaydet_Click(object sender, EventArgs e)
        {
            string EkleSonuc = bra_man.Ekle(textEdit_Brans.Text,1);
            FrmDoktorlar frm_dok = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];

            frm_dok.gridControl_Branslar.DataSource = bra_man.Listele();
            MessageBox.Show(EkleSonuc.ToString());
            textEdit_Brans.Text = null;
        }

        public int bransid;
        FrmDoktorlar frm_brans = new FrmDoktorlar();

        private void simpleButton_Guncelle_Click(object sender, EventArgs e)
        {
            Branslar tablo = new Branslar();
            tablo.BransAdi = textEdit_Brans.Text;
            tablo.KullaniciID = 1;
            string guncelleSonuc = bra_man.guncelle(bransid, tablo);
            frm_brans = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            frm_brans.gridControl_Branslar.DataSource = bra_man.Listele();
            MessageBox.Show(guncelleSonuc.ToString());
            Close();
        }

        private void simpleButton_Sil_Click(object sender, EventArgs e)
        {
            string SilSonuc = bra_man.Sil(bransid);
            frm_brans = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            frm_brans.gridControl_Branslar.DataSource = bra_man.Listele();
            MessageBox.Show(SilSonuc.ToString());
            Close();
        }
    }
}
