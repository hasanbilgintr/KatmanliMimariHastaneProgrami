using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane.BLL;
using Hastane.BLL.Manager;

using Hastane.DLL;


namespace Hastane.UI
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        KullanicilarManager kul_man = new KullanicilarManager();

        int hak = 0;

        private void simpleButton_Giris_Click(object sender, EventArgs e)
        {
            var sonuc = kul_man.login(textEdit_Kul_Adi.Text, textEdit_Kul_Sifre.Text);

            if (sonuc != null)
            {
                FrmMenu frm_menu = new FrmMenu();
                frm_menu.KullaniciAdi = kul_man.KulAdi;
                frm_menu.KullaniciYetkisi = kul_man.Yetki;
                Hide();
                frm_menu.Show();
            }
            else
            {
                labelControl_bilgi.ForeColor = Color.Red;
                labelControl_bilgi.Text = hak+1+" Denemede Giriş Hatalı Tekrar Deneyiniz";
                textEdit_Kul_Adi.Text = ""; textEdit_Kul_Sifre.Text = null;
                hak++;
                if (hak == 3)
                {
                    textEdit_Kul_Adi.Text = ""; textEdit_Kul_Sifre.Text = null;
                    labelControl_bilgi.Text = null;
                    MessageBox.Show("Hatalı Giriş Siste Tarafından Atılcaksınız");
                    Application.Exit();
                }
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            FrmYeniKullanici frm_yeni = new FrmYeniKullanici();
            frm_yeni.ShowDialog();
        }
    }
}
