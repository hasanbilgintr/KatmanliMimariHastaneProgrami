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

namespace Hastane.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public string KullaniciYetkisi;
        public string KullaniciAdi;

        FrmDoktorlar frm_doktor;

        private void barButtonItem_Doktorlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_doktor == null || frm_doktor.IsDisposed)
            {
                frm_doktor = new FrmDoktorlar();
                frm_doktor.MdiParent = this;
                frm_doktor.Show();
            }
        }

        FrmRandevular frm_ran;
        private void barButtonItem_Randevular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_ran == null || frm_ran.IsDisposed)
            {
                frm_ran = new FrmRandevular();
                frm_ran.MdiParent = this;
                frm_ran.Show();
            }
        }

        FrmHastalar frm_hasta;
        private void barButtonItem_Hastalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_hasta == null || frm_hasta.IsDisposed)
            {
                frm_hasta = new FrmHastalar();
                frm_hasta.MdiParent = this;
                frm_hasta.Show();
            }
        }

        FrmPersoneller frm_pers;
        private void barButtonItem_Personeller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_pers == null || frm_pers.IsDisposed)
            {
                frm_pers = new FrmPersoneller();
                frm_pers.MdiParent = this;
                frm_pers.Show();
            }
        }

        FrmKlinikler frm_kli;
        private void barButtonItem_Klinikler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_kli == null || frm_kli.IsDisposed)
            {
                frm_kli = new FrmKlinikler();
                frm_kli.MdiParent = this;
                frm_kli.Show();
            }
        }

        FrmMuhasebe frm_muh;
        private void barButtonItem_Muhasebe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_muh == null || frm_muh.IsDisposed)
            {
                frm_muh = new FrmMuhasebe();
                frm_muh.MdiParent = this;
                frm_muh.Show();
            }
        }

        FrmYoneticiler frm_yonet;
        private void barButtonItem_Yoneticiler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_yonet == null || frm_yonet.IsDisposed)
            {
                frm_yonet = new FrmYoneticiler();
                frm_yonet.MdiParent = this;
                frm_yonet.Show();
            }
        }

        public void YetkiyeGoreMenu()
        {
            if (KullaniciYetkisi == "Personel")
            {
                barButtonItem_Doktorlar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Klinikler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Personeller.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Muhasebe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Yoneticiler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (KullaniciYetkisi == "Kayıt Giriş")
            {
                barButtonItem_Doktorlar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Klinikler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Personeller.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Muhasebe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Yoneticiler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Randevular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }

            if (KullaniciYetkisi == "Hasta") //veri tabanında ekleydi saçma kaldı biraz
            {
                barButtonItem_Doktorlar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Klinikler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Personeller.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Muhasebe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Yoneticiler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Randevular.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Hastalar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (KullaniciYetkisi == "Doktor")
            {
                barButtonItem_Klinikler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Muhasebe.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Yoneticiler.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_Doktorlar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        public void FrmMenu_Load(object sender, EventArgs e)
        {
            label_KullaniciAdi.Text = KullaniciAdi;
            label1.Parent = ribbonControl1; //arka plan rengi olmasın diye labellerin
            label_KullaniciAdi.Parent = ribbonControl1;
            YetkiyeGoreMenu();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kapat = MessageBox.Show("Programı Kapamak İster misiniz?", "Kapama Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kapat == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else { e.Cancel = true; }
        }
    }
}
