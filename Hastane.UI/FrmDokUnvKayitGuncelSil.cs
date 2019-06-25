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
    public partial class FrmDokUnvKayitGuncelSil : Form
    {
        public FrmDokUnvKayitGuncelSil()
        {
            InitializeComponent();
        }

        BranslarManager bra_man = new BranslarManager();
        DoktorUnvanlarıManager dokun_man = new DoktorUnvanlarıManager();

        private void simpleButton_kaydet_Click(object sender, EventArgs e)
        {
            string ekleSonuc = dokun_man.Ekle(textEdit_DokUnvan.Text, (int)comboBox_Bransadi.SelectedValue, maskedTextBox_dipno.Text, 1);
            FrmDoktorlar frm_dok = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            frm_dok.gridControl_DokUnv.DataSource = dokun_man.Listele();
            MessageBox.Show(ekleSonuc.ToString());
            TemizleOdakla();
        }

        public int Dokunid;

        private void simpleButton_Guncelle_Click(object sender, EventArgs e)
        {
            DoktorUnvanlari tablo = new DoktorUnvanlari();
            tablo.UnvanAdi = textEdit_DokUnvan.Text;
            tablo.BransID = (int)comboBox_Bransadi.SelectedValue;
            tablo.DiplomaNumarasi = maskedTextBox_dipno.Text;
            tablo.KullaniciID = 1;
            string GuncelleSonuc = dokun_man.Guncelle(Dokunid, tablo);
            FrmDoktorlar frm_dokun = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            frm_dokun.gridControl_DokUnv.DataSource = dokun_man.Listele();
            MessageBox.Show(GuncelleSonuc.ToString());
            Close();
        }

        private void simpleButton_Sil_Click(object sender, EventArgs e)
        {
            string SilSonuc = dokun_man.Sil(Dokunid);
            FrmDoktorlar frm_dokun = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            frm_dokun.gridControl_DokUnv.DataSource = dokun_man.Listele();
            MessageBox.Show(SilSonuc.ToString());
            Close();
        }

        public void TemizleOdakla()
        {
            textEdit_DokUnvan.Text = null;
            comboBox_Bransadi.Text = "Dahiliye";
            maskedTextBox_dipno.Text = null;
        }
    }
}
