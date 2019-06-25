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
    public partial class FrmYeniKullanici : Form
    {
        public FrmYeniKullanici()
        {
            InitializeComponent();
        }

        KullanicilarManager kul_man = new KullanicilarManager();

        private void textEdit_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void simpleButton_Kaydet_Click(object sender, EventArgs e)
        {
            string EkleSonuc = kul_man.Ekle(textEdit_tc.Text, textEdit_kul.Text, textEdit_sifre.Text, 1);
            MessageBox.Show(EkleSonuc.ToString());
            if (EkleSonuc=="Kullanıcı Ekleme Başarılı")
            {
                MessageBox.Show("Lütfen Giriş Yapınız");
                this.Close();
            }
        }
    }
}
