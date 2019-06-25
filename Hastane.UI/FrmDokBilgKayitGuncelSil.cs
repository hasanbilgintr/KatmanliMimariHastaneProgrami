using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.DLL;
using Hastane.BLL.Manager;
using Hastane.BLL;


namespace Hastane.UI
{
    public partial class FrmDokBilgKayitGuncelSil : Form
    {
        public FrmDokBilgKayitGuncelSil()
        {
            InitializeComponent();
        }

        DoktorlarManager dok_man = new DoktorlarManager();
        DoktorBilgileriManager dokbilg_man = new DoktorBilgileriManager();

        private void simpleButton_Kaydet_Click(object sender, EventArgs e)
        {
            string EkleSonuc = dokbilg_man.Ekle((int)comboBox_Doktor.SelectedValue, dateTimePicker_girtar.Value, dateTimePicker_ciktar.Value, Convert.ToBoolean(dokbilg_man.aktifmiE(comboBox_aktif.Text)), 1);

            FrmDoktorlar frm_dok = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            frm_dok.gridControl_DokBilg.DataSource = dokbilg_man.Listele();
            MessageBox.Show(EkleSonuc.ToString());
            Temizle();
        }

        private void simpleButton_Guncel_Click(object sender, EventArgs e)
        {
            DoktorBilgileri nesnetablo = new DoktorBilgileri();
            nesnetablo.DoktorID = (int)comboBox_Doktor.SelectedValue;
            nesnetablo.GirisTarihi = dateTimePicker_girtar.Value;
            nesnetablo.CikisTarihi = dateTimePicker_ciktar.Value;
            nesnetablo.AktifMi = Convert.ToBoolean(dokbilg_man.aktifmiE(comboBox_aktif.Text));

            FrmDoktorlar frm_dok = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            string GuncelleSonuc = dokbilg_man.Guncelle(frm_dok.Dok_BilgID,nesnetablo);
            frm_dok.gridControl_DokBilg.DataSource = dokbilg_man.Listele();
            MessageBox.Show(GuncelleSonuc.ToString());
            Close();
        }

        private void simpleButton_Sil_Click(object sender, EventArgs e)
        {
            FrmDoktorlar frm_dok = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            string SilSonuc = dokbilg_man.Sil(frm_dok.Dok_BilgID);
            frm_dok.gridControl_DokBilg.DataSource = dokbilg_man.Listele();
            MessageBox.Show(SilSonuc.ToString());
            Close();
        }

        public void Temizle()
        {
            comboBox_Doktor.Text = "Malik";
            dateTimePicker_girtar.Value = DateTime.Now;
            dateTimePicker_ciktar.Value = DateTime.Now;
            comboBox_aktif.Text = null;
        }
    }
}
