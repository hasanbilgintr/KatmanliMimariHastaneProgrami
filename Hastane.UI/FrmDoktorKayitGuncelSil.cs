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
using System.Data.SqlClient;
using System.Data.Entity;

namespace Hastane.UI
{
    public partial class FrmDoktorKayitGuncelSil : Form
    {
        public FrmDoktorKayitGuncelSil()
        {
            InitializeComponent();
        }

        illerManager il_man = new illerManager();
        KanGruplariManager kan_man = new KanGruplariManager();
        DoktorUnvanlarıManager dokUnv_man = new DoktorUnvanlarıManager();
        KliniklerManager kli_man = new KliniklerManager();
        DoktorlarManager dok_man = new DoktorlarManager();
        KullanicilarManager kul_man = new KullanicilarManager();

        public TextBox textboxresimadres = new TextBox();

        private void simpleButton_resimsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox_resim.ImageLocation = openFileDialog1.FileName;
            textboxresimadres.Text = openFileDialog1.FileName;
        }
        private void simpleButton_Kaydet_Click(object sender, EventArgs e)
        {
            string EkleSonuc = dok_man.Ekle(maskedTextBox_Tc.Text.Trim(), textEdit_DokAd.Text, textEdit_DokSoyad.Text, comboBoxEdit_DokCins.Text, maskedTextBox_DokTel.Text, textEdit_DokEmail.Text, comboBoxEdit_DokMedeni.SelectedText, dateTimePicker_DokDogTar.Value, (int)comboBox_DogYer.SelectedValue, (int)comboBox_KanGru.SelectedValue, (int)comboBox_UnvanAdi.SelectedValue, textEdit_DokAdres.Text, 1, (int)comboBox_Klinik.SelectedValue, textboxresimadres.Text);

            FrmDoktorlar frm_dok = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            frm_dok.gridControl_Doktorlar.DataSource = dok_man.Listele();
            MessageBox.Show(EkleSonuc.ToString());
            if (EkleSonuc == "Ekleme Başarılı")
            {
                Temizle();
            }
        }

        public int doktorid;

        FrmDoktorlar frm_dok;
        private void simpleButton_Guncelle_Click(object sender, EventArgs e)
        {
            frm_dok = new FrmDoktorlar();

            Doktorlar nesnetablo = new Doktorlar();
            nesnetablo.DoktorTC = maskedTextBox_Tc.Text.Trim();
            nesnetablo.DoktorAdi = textEdit_DokAd.Text;
            nesnetablo.DoktorSoyadi = textEdit_DokSoyad.Text;
            nesnetablo.DoktorCinsiyet = comboBoxEdit_DokCins.Text;
            nesnetablo.DoktorTelefon = maskedTextBox_DokTel.Text;
            nesnetablo.Email = textEdit_DokEmail.Text;
            nesnetablo.MedeniHali = comboBoxEdit_DokMedeni.Text;
            nesnetablo.DogumTarihi = dateTimePicker_DokDogTar.Value;
            nesnetablo.DogumYeriID = (int)comboBox_DogYer.SelectedValue;
            nesnetablo.KanGrubuID = (int)comboBox_KanGru.SelectedValue;
            nesnetablo.DoktorUnvanID = (int)comboBox_UnvanAdi.SelectedValue;
            nesnetablo.Adres = textEdit_DokAdres.Text;
            nesnetablo.KullaniciID = 1;
            nesnetablo.KlinikID = (int)comboBox_Klinik.SelectedValue;
            nesnetablo.Resim = textboxresimadres.Text;

            string GuncelleSonuc = dok_man.Guncelle(doktorid, nesnetablo);
            FrmDoktorlar frm_dok1 = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            frm_dok1.gridControl_Doktorlar.DataSource = dok_man.Listele();
            MessageBox.Show(GuncelleSonuc.ToString());
            Close();
        }

        private void simpleButton_Sil_Click(object sender, EventArgs e)
        {
            string SilSonuc = dok_man.Sil(doktorid);
            FrmDoktorlar frm_dok = (FrmDoktorlar)Application.OpenForms["FrmDoktorlar"];
            frm_dok.gridControl_Doktorlar.DataSource = dok_man.Listele();
            MessageBox.Show(SilSonuc.ToString());
            Close();
        }

        public void Temizle()
        {
            pictureBox_resim.ImageLocation = "";
            maskedTextBox_Tc.Text = null;
            textEdit_DokAd.Text = null;
            textEdit_DokSoyad.Text = null;
            comboBoxEdit_DokCins.Text = null;
            maskedTextBox_DokTel.Text = null;
            textEdit_DokEmail.Text = null;
            comboBoxEdit_DokMedeni.Text = null;
            dateTimePicker_DokDogTar.Value = DateTime.Parse("1.01.1753");
            comboBox_DogYer.Text = "Adana";
            comboBox_KanGru.Text = "A Rh+";
            comboBox_UnvanAdi.Text = "Prof";
            textEdit_DokAdres.Text = null;
            comboBox_Klinik.Text = "Psikiyatri";
        }


    }
}
