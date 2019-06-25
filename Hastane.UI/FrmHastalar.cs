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

namespace Hastane.UI
{
    public partial class FrmHastalar : Form
    {
        public FrmHastalar()
        {
            InitializeComponent();
        }

        HastalarManager has_man = new HastalarManager();
        illerManager il_man = new illerManager();
        KanGruplariManager kan_man = new KanGruplariManager();

        private void FrmHastalar_Load(object sender, EventArgs e)
        {
            gridControl_Hastalar.DataSource = has_man.Listele();

            comboBox_DogYer.DataSource = il_man.Listele();
            comboBox_DogYer.DisplayMember = "ilAdi";
            comboBox_DogYer.ValueMember = "illerID";

            comboBox_Kan.DataSource = kan_man.Listele();
            comboBox_Kan.DisplayMember = "KanGrubuAdi";
            comboBox_Kan.ValueMember = "KanGruplariID";
        }


        private void simpleButton_Kayit_Click(object sender, EventArgs e)
        {
            string YeniSonuc = has_man.Yeni(maskedTextBox_Tc.Text.Trim(), textEdit_Ad.Text, textEdit_Soyad.Text, maskedTextBox_Tel.Text, comboBoxEdit_Cinsiyet.Text, dateTimePicker_DogTar.Value, (int)comboBox_DogYer.SelectedValue, comboBoxEdit_MedHal.Text, textEdit_Email.Text, (int)comboBox_Kan.SelectedValue, Convert.ToDecimal(textEdit_Kilo.Text), Convert.ToDecimal(textEdit_Boy.Text), memoEdit_Adres.Text, memoEdit_Acikla.Text, 1);
            gridControl_Hastalar.DataSource = has_man.Listele();
            MessageBox.Show(YeniSonuc.ToString());
            Temizle();
        }


        private void simpleButton_Guncelle_Click(object sender, EventArgs e)
        {
            Hastalar tablo = new Hastalar();
            tablo.HastaTC = maskedTextBox_Tc.Text.Trim();
            tablo.HastaAdi = textEdit_Ad.Text;
            tablo.HastaSoyadi = textEdit_Soyad.Text;
            tablo.Telefon = maskedTextBox_Tel.Text;
            tablo.Cinsiyet = comboBoxEdit_Cinsiyet.Text;
            tablo.DogumTarihi = dateTimePicker_DogTar.Value;
            tablo.DogumYeriID = (int)comboBox_DogYer.SelectedValue;
            tablo.MedeniHali = comboBoxEdit_MedHal.Text;
            tablo.Email = textEdit_Email.Text;
            tablo.KanGrubuID = (int)comboBox_Kan.SelectedValue;
            try
            {
                tablo.HastaKilo = Convert.ToDecimal(textEdit_Kilo.Text);
            }
            catch (Exception)
            {
                tablo.HastaKilo = 0;
            }
            try
            {
                tablo.HastaBoy = Convert.ToDecimal(textEdit_Boy.Text);
            }
            catch (Exception)
            {
                tablo.HastaBoy = 0;
            }
            tablo.Adres = memoEdit_Adres.Text;
            tablo.Acıklama = memoEdit_Acikla.Text;

            FrmHastalar frm_has = (FrmHastalar)Application.OpenForms["FrmHastalar"];
            string GuncelleSonuc = has_man.Guncelle(Hastaid, tablo);
            frm_has.gridControl_Hastalar.DataSource = has_man.Listele();
            MessageBox.Show(GuncelleSonuc.ToString());
            if (GuncelleSonuc == "Hasta Güncelleme Başarılı")
            {
                simpleButton_Guncelle.Enabled = true;
                simpleButton_Sil.Enabled = true;
            }
        }

        int Hastaid;

        private void gridView_Hastalar_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            simpleButton_Yeni.Visible = true;
            simpleButton_Guncelle.Enabled = true;
            simpleButton_Sil.Enabled = true;

            Hastaid = (int)gridView_Hastalar.GetFocusedRowCellValue("HastalarID");
            maskedTextBox_Tc.Text = has_man.HastaGetir(Hastaid).HastaTC;
            textEdit_Ad.Text = has_man.HastaGetir(Hastaid).HastaAdi;
            textEdit_Soyad.Text = has_man.HastaGetir(Hastaid).HastaSoyadi;
            maskedTextBox_Tel.Text = has_man.HastaGetir(Hastaid).Telefon;
            comboBoxEdit_Cinsiyet.Text = has_man.HastaGetir(Hastaid).Cinsiyet;
            try
            {
                dateTimePicker_DogTar.Value = has_man.HastaGetir(Hastaid).DogumTarihi.Value;
            }
            catch (Exception)
            {
                dateTimePicker_DogTar.Value = DateTime.Parse("01-01-1990");
            }
            comboBox_DogYer.Text = has_man.HastaGetir(Hastaid).iller.ilAdi;
            comboBoxEdit_MedHal.Text = has_man.HastaGetir(Hastaid).MedeniHali;
            textEdit_Email.Text = has_man.HastaGetir(Hastaid).Email;
            comboBox_Kan.Text = has_man.HastaGetir(Hastaid).KanGruplari.KanGrubuAdi;
            textEdit_Kilo.Text = has_man.HastaGetir(Hastaid).HastaKilo.ToString();
            textEdit_Boy.Text = has_man.HastaGetir(Hastaid).HastaBoy.ToString();
            memoEdit_Adres.Text = has_man.HastaGetir(Hastaid).Adres;
            memoEdit_Acikla.Text = has_man.HastaGetir(Hastaid).Acıklama;
        }

        private void simpleButton_Sil_Click(object sender, EventArgs e)
        {
            string SilSonuc = has_man.Sil(Hastaid);
            gridControl_Hastalar.DataSource = has_man.Listele();
            MessageBox.Show(SilSonuc.ToString());
        }

        private void simpleButton_Yeni_Click_1(object sender, EventArgs e)
        {
            simpleButton_Yeni.Visible = false;
            simpleButton_Guncelle.Enabled = false;
            simpleButton_Sil.Enabled = false;

            maskedTextBox_Tc.Text = null;
            textEdit_Ad.Text = null;
            textEdit_Soyad.Text = null;
            maskedTextBox_Tel.Text = null;
            comboBoxEdit_Cinsiyet.Text = null;
            dateTimePicker_DogTar.Value = DateTime.Parse("1.01.1753");
            comboBox_DogYer.Text = "Adana";
            comboBoxEdit_MedHal.Text = null;
            textEdit_Email.Text = null;
            comboBox_Kan.Text = "A Rh+";
            textEdit_Kilo.Text = "0";
            textEdit_Boy.Text = "0";
            memoEdit_Adres.Text = null;
            memoEdit_Acikla.Text = null;
        }

        public void Temizle()
        {
            maskedTextBox_Tc.Text = null;
            textEdit_Ad.Text = null;
            textEdit_Soyad.Text = null;
            maskedTextBox_Tel.Text = null;
            comboBoxEdit_Cinsiyet.Text = null;
            dateTimePicker_DogTar.Value = DateTime.Parse("1.01.1753");
            comboBox_DogYer.Text = "Adana";
            comboBoxEdit_MedHal.Text = null;
            textEdit_Email.Text = null;
            comboBox_Kan.Text = "A Rh+";
            textEdit_Kilo.Text = "0";
            textEdit_Boy.Text = "0";
            memoEdit_Adres.Text = null;
            memoEdit_Acikla.Text = null;
        }
      
    }
}
