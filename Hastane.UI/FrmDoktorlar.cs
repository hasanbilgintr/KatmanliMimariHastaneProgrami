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
using Hastane.BLL;
using Hastane.DLL;

namespace Hastane.UI
{
    public partial class FrmDoktorlar : Form
    {
        public FrmDoktorlar()
        {
            InitializeComponent();
        }

        DoktorlarManager Dok_Man = new DoktorlarManager();
        DoktorBilgileriManager DokBilg_Man = new DoktorBilgileriManager();
        DoktorUnvanlarıManager DokUnv_Man = new DoktorUnvanlarıManager();
        BranslarManager Bra_Man = new BranslarManager();
        illerManager il_man = new illerManager();
        KullanicilarManager kul_man = new KullanicilarManager();
        KanGruplariManager kan_man = new KanGruplariManager();
        KliniklerManager kli_man = new KliniklerManager();
        FrmDoktorKayitGuncelSil frmdok_yeni = new FrmDoktorKayitGuncelSil();

        private void FrmDoktorlar_Load(object sender, EventArgs e)
        {
            gridControl_Doktorlar.DataSource = Dok_Man.Listele();
            gridControl_DokBilg.DataSource = DokBilg_Man.Listele();
            gridControl_DokUnv.DataSource = DokUnv_Man.Listele();
            gridControl_Branslar.DataSource = Bra_Man.Listele();
        }

        private void simpleButton_Dok_Yeni_Click(object sender, EventArgs e)
        {
            frmdok_yeni = new FrmDoktorKayitGuncelSil();
            frmdok_yeni.simpleButton_Kaydet.Visible = true;
            frmdok_yeni.simpleButton_Guncelle.Visible = false;
            frmdok_yeni.simpleButton_Sil.Visible = false;


            frmdok_yeni.comboBox_DogYer.DataSource = il_man.Listele();
            frmdok_yeni.comboBox_DogYer.DisplayMember = "ilAdi";
            frmdok_yeni.comboBox_DogYer.ValueMember = "illerID";


            frmdok_yeni.comboBox_KanGru.DataSource = kan_man.Listele();
            frmdok_yeni.comboBox_KanGru.DisplayMember = "KanGrubuAdi";
            frmdok_yeni.comboBox_KanGru.ValueMember = "KanGruplariID";

            frmdok_yeni.comboBox_UnvanAdi.DataSource = DokUnv_Man.Listele();
            frmdok_yeni.comboBox_UnvanAdi.DisplayMember = "UnvanAdi";
            frmdok_yeni.comboBox_UnvanAdi.ValueMember = "DoktorUnvanlariID";

            frmdok_yeni.comboBox_Klinik.DataSource = kli_man.Listele();
            frmdok_yeni.comboBox_Klinik.DisplayMember = "KlinikAdi";
            frmdok_yeni.comboBox_Klinik.ValueMember = "KliniklerID";

            frmdok_yeni.ShowDialog();
        }

        private void simpleButton_DokBilg_Yeni_Click(object sender, EventArgs e)
        {
            FrmDokBilgKayitGuncelSil frmdokbilg_yeni = new FrmDokBilgKayitGuncelSil();
            frmdokbilg_yeni.simpleButton_Guncel.Visible = false;
            frmdokbilg_yeni.simpleButton_Sil.Visible = false;

            frmdokbilg_yeni.comboBox_Doktor.DataSource = Dok_Man.Listele();
            frmdokbilg_yeni.comboBox_Doktor.DisplayMember = "DoktorAdi";
            frmdokbilg_yeni.comboBox_Doktor.ValueMember = "DoktorlarID";
            frmdokbilg_yeni.ShowDialog();
        }

        private void simpleButton_DokUnv_Yeni_Click(object sender, EventArgs e)
        {
            FrmDokUnvKayitGuncelSil frmdokunv_yeni = new FrmDokUnvKayitGuncelSil();
            frmdokunv_yeni.simpleButton_kaydet.Visible = true;
            frmdokunv_yeni.simpleButton_Guncelle.Visible = false;
            frmdokunv_yeni.simpleButton_Sil.Visible = false;

            frmdokunv_yeni.comboBox_Bransadi.DataSource = Bra_Man.Listele();
            frmdokunv_yeni.comboBox_Bransadi.DisplayMember = "BransAdi";
            frmdokunv_yeni.comboBox_Bransadi.ValueMember = "BranslarID";

            frmdokunv_yeni.ShowDialog();
        }

        private void simpleButton_Brans_Yeni_Click(object sender, EventArgs e)
        {
            FrmBransKayitGuncelSil frmbra_yeni = new FrmBransKayitGuncelSil();

            frmbra_yeni.simpleButton_kaydet.Visible = true;
            frmbra_yeni.simpleButton_Guncelle.Visible = false;
            frmbra_yeni.simpleButton_Sil.Visible = false;
            frmbra_yeni.ShowDialog();
        }

        public int Dok_BilgID;

        private void gridControl_DokBilg_DoubleClick(object sender, EventArgs e)
        {
            FrmDokBilgKayitGuncelSil frm_dokbilg = new FrmDokBilgKayitGuncelSil();
            frm_dokbilg.Text = "Güncelleme / Silme";
            frm_dokbilg.simpleButton_Kaydet.Visible = false;

            frm_dokbilg.comboBox_Doktor.DataSource = Dok_Man.Listele();
            frm_dokbilg.comboBox_Doktor.DisplayMember = "DoktorAdi";
            frm_dokbilg.comboBox_Doktor.ValueMember = "DoktorlarID";

            Dok_BilgID = (int)gridView_DokBilg.GetFocusedRowCellValue("DoktorBilgileriID");
            try
            {
                frm_dokbilg.comboBox_Doktor.Text = DokBilg_Man.DokBilgGetir(Dok_BilgID).Doktorlar.DoktorAdi;
            }
            catch (Exception)
            {
                frm_dokbilg.comboBox_Doktor.Text = "";
            }
            try
            {
                frm_dokbilg.dateTimePicker_girtar.Value = DokBilg_Man.DokBilgGetir(Dok_BilgID).GirisTarihi;
            }
            catch (Exception)
            {
                frm_dokbilg.dateTimePicker_girtar.Value = DateTime.Parse("01-01-1800");

            }
            try
            {
                frm_dokbilg.dateTimePicker_ciktar.Value = DokBilg_Man.DokBilgGetir(Dok_BilgID).CikisTarihi.Value;
            }
            catch (Exception)
            {
                frm_dokbilg.dateTimePicker_ciktar.Value = DateTime.Parse("01-01-1800");

            }

            string b = DokBilg_Man.DokBilgGetir(Dok_BilgID).AktifMi.ToString();
            frm_dokbilg.comboBox_aktif.Text = DokBilg_Man.aktifmiT(b);

            frm_dokbilg.ShowDialog();
        }

        public int DoktorID;

        FrmDoktorKayitGuncelSil frm_dokyeni;
        private void gridControl_Doktorlar_DoubleClick(object sender, EventArgs e)
        {
            frm_dokyeni = new FrmDoktorKayitGuncelSil();
            frm_dokyeni.Text = "Güncelleme / Silme";

            frm_dokyeni.simpleButton_Sil.Visible = true;
            frm_dokyeni.simpleButton_Guncelle.Visible = true;
            frm_dokyeni.simpleButton_Kaydet.Visible = false;

            frm_dokyeni.comboBox_DogYer.DataSource = il_man.Listele();
            frm_dokyeni.comboBox_DogYer.DisplayMember = "ilAdi";
            frm_dokyeni.comboBox_DogYer.ValueMember = "illerID";

            frm_dokyeni.comboBox_KanGru.DataSource = kan_man.Listele();
            frm_dokyeni.comboBox_KanGru.DisplayMember = "KanGrubuAdi";
            frm_dokyeni.comboBox_KanGru.ValueMember = "KanGruplariID";

            frm_dokyeni.comboBox_UnvanAdi.DataSource = DokUnv_Man.Listele();
            frm_dokyeni.comboBox_UnvanAdi.DisplayMember = "UnvanAdi";
            frm_dokyeni.comboBox_UnvanAdi.ValueMember = "DoktorUnvanlariID";

            frm_dokyeni.comboBox_Klinik.DataSource = kli_man.Listele();
            frm_dokyeni.comboBox_Klinik.DisplayMember = "KlinikAdi";
            frm_dokyeni.comboBox_Klinik.ValueMember = "KliniklerID";

            Dok_Man = new DoktorlarManager();

            DoktorID = (int)gridView_Doktorlar.GetFocusedRowCellValue("DoktorlarID");
            frm_dokyeni.doktorid = DoktorID;

            try
            {
                frm_dokyeni.maskedTextBox_Tc.Text = Dok_Man.DoktorGetir(DoktorID).DoktorTC;
            }
            catch (Exception)
            {
                frm_dokyeni.maskedTextBox_Tc.Text = "";
            }
            try
            {
                frm_dokyeni.textEdit_DokAd.Text = Dok_Man.DoktorGetir(DoktorID).DoktorAdi;
            }
            catch (Exception)
            {
                frm_dokyeni.textEdit_DokAd.Text = "";
            }
            try
            {
                frm_dokyeni.textEdit_DokSoyad.Text = Dok_Man.DoktorGetir(DoktorID).DoktorSoyadi;
            }
            catch (Exception)
            {
                frm_dokyeni.textEdit_DokSoyad.Text = "";
            }
            try
            {
                frm_dokyeni.comboBoxEdit_DokCins.Text = Dok_Man.DoktorGetir(DoktorID).DoktorCinsiyet;
            }
            catch (Exception)
            {

                frm_dokyeni.comboBoxEdit_DokCins.Text = "";
            }
            try
            {
                frm_dokyeni.maskedTextBox_DokTel.Text = Dok_Man.DoktorGetir(DoktorID).DoktorTelefon;
            }
            catch (Exception)
            {
                frm_dokyeni.maskedTextBox_DokTel.Text = "";
            }
            try
            {
                frm_dokyeni.textEdit_DokEmail.Text = Dok_Man.DoktorGetir(DoktorID).Email;
            }
            catch (Exception)
            {
                frm_dokyeni.textEdit_DokEmail.Text = "";
            }
            try
            {
                frm_dokyeni.comboBoxEdit_DokMedeni.Text = Dok_Man.DoktorGetir(DoktorID).MedeniHali;
            }
            catch (Exception)
            {
                frm_dokyeni.comboBoxEdit_DokMedeni.Text = "";
            }
            try
            {
                frm_dokyeni.dateTimePicker_DokDogTar.Value = Dok_Man.DoktorGetir(DoktorID).DogumTarihi.Value;
            }
            catch (Exception)
            {
                frm_dokyeni.dateTimePicker_DokDogTar.Value = DateTime.Parse("01-01-1800");
            }
            try
            {
                frm_dokyeni.comboBox_DogYer.Text = Dok_Man.DoktorGetir(DoktorID).iller.ilAdi;
            }
            catch (Exception)
            {
                frm_dokyeni.comboBox_DogYer.Text = "";
                MessageBox.Show("Lütfen Dogum yeri giriniz"); 
            }
            try
            {
                frm_dokyeni.comboBox_KanGru.Text = Dok_Man.DoktorGetir(DoktorID).KanGruplari.KanGrubuAdi;
            }
            catch (Exception)
            {
                frm_dokyeni.comboBox_KanGru.Text = "";
                MessageBox.Show("Lütfen Kan Grubu Giriniz");
            }
            try
            {
                frm_dokyeni.comboBox_UnvanAdi.Text = Dok_Man.DoktorGetir(DoktorID).DoktorUnvanlari.UnvanAdi;
            }
            catch (Exception)
            {
                frm_dokyeni.comboBox_UnvanAdi.Text = "";
                MessageBox.Show("Lütfen Unvan Adını Giriniz");
            }
            try
            {
                frm_dokyeni.textEdit_DokAdres.Text = Dok_Man.DoktorGetir(DoktorID).Adres;
            }
            catch (Exception)
            {
                frm_dokyeni.textEdit_DokAdres.Text = "";
            }
            try
            {
                frm_dokyeni.comboBox_Klinik.Text = Dok_Man.DoktorGetir(DoktorID).Klinikler.KlinikAdi;
            }
            catch (Exception)
            {
                frm_dokyeni.comboBox_Klinik.Text = "";
                MessageBox.Show("Lütfen Klinik Giriniz");
            }
            if (string.IsNullOrWhiteSpace(Dok_Man.DoktorGetir(DoktorID).Resim))
            {
                frm_dokyeni.simpleButton_resimsec.Text = "Resim Seç";
                frm_dokyeni.pictureBox_resim.ImageLocation = @"D:\USB\Çalışma Sayfaları\Windows Form Çalışma Sayfası\190529_ KatmanlıMimari_HastahaneDB\Hastane.UI\Resources\resim-yok.jpg ";
            }
            else
            {
                frm_dokyeni.simpleButton_resimsec.Text = "Resim Güncelle";
                frm_dokyeni.textboxresimadres.Text = Dok_Man.DoktorGetir(DoktorID).Resim;
                frm_dokyeni.pictureBox_resim.ImageLocation = Dok_Man.DoktorGetir(DoktorID).Resim;
            }
            frm_dokyeni.ShowDialog();
        }

        public int DokUnID;
        FrmDokUnvKayitGuncelSil frm_dokun;
        private void gridControl_DokUnv_DoubleClick(object sender, EventArgs e)
        {
            frm_dokun = new FrmDokUnvKayitGuncelSil();
            frm_dokun.Text = "Güncelleme / Silme";

            frm_dokun.simpleButton_kaydet.Visible = false;
            frm_dokun.simpleButton_Guncelle.Visible = true;
            frm_dokun.simpleButton_Sil.Visible = true;

            frm_dokun.comboBox_Bransadi.DataSource = Bra_Man.Listele();
            frm_dokun.comboBox_Bransadi.DisplayMember = "BransAdi";
            frm_dokun.comboBox_Bransadi.ValueMember = "BranslarID";

            DokUnID = (int)gridView_DokUnv.GetFocusedRowCellValue("DoktorUnvanlariID");
            frm_dokun.Dokunid = DokUnID;
            try
            {
                frm_dokun.textEdit_DokUnvan.Text = DokUnv_Man.DoktorUnvGetir(DokUnID).UnvanAdi;
            }
            catch (Exception)
            {
                frm_dokun.textEdit_DokUnvan.Text = "";
                MessageBox.Show("Lütfen Doktor Ünvanı Giriniz");
            }
            try
            {
                frm_dokun.comboBox_Bransadi.Text = DokUnv_Man.DoktorUnvGetir(DokUnID).Branslar.BransAdi;
            }
            catch (Exception)
            {
                frm_dokun.comboBox_Bransadi.Text = "";
                MessageBox.Show("Lütfen Branş Giriniz");
            }
            try
            {
                frm_dokun.maskedTextBox_dipno.Text = DokUnv_Man.DoktorUnvGetir(DokUnID).DiplomaNumarasi;
            }
            catch (Exception)
            {
                frm_dokun.maskedTextBox_dipno.Text = "";
            }

            frm_dokun.ShowDialog();
        }

        FrmBransKayitGuncelSil frm_bran;
        public int BransID;

        private void gridControl_Branslar_DoubleClick(object sender, EventArgs e)
        {
            frm_bran = new FrmBransKayitGuncelSil();
            frm_bran.Text = "Güncelleme / Silme";


            frm_bran.simpleButton_kaydet.Visible = false;
            frm_bran.simpleButton_Guncelle.Visible = true;
            frm_bran.simpleButton_Sil.Visible = true;

            BransID = (int)gridView_Branslar.GetFocusedRowCellValue("BranslarID");
            frm_bran.bransid = BransID;
            frm_bran.textEdit_Brans.Text = Bra_Man.BransGetir(BransID).BransAdi;
            frm_bran.ShowDialog();
        }

        private void textEdit_TcAra_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_Doktorlar.DataSource = Dok_Man.OgrenciAra(textEdit_TcAra.Text);
        }

        private void textEdit_UnvanAdıAra_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_DokUnv.DataSource = DokUnv_Man.DoktorUnvaniAra(textEdit_UnvanAdıAra.Text);
        }

        private void textEdit_BransAdiAra_EditValueChanged(object sender, EventArgs e)
        {
            gridControl_Branslar.DataSource = Bra_Man.BransAdiAra(textEdit_BransAdiAra.Text);
        }

        private void dateTimePicker_GirTar_ValueChanged(object sender, EventArgs e)
        {
            gridControl_DokBilg.DataSource = DokBilg_Man.DoktorGirisCikis(dateTimePicker_GirTar.Value, dateTimePicker_CikTar.Value);
        }

        private void dateTimePicker_CikTar_ValueChanged(object sender, EventArgs e)
        {
            gridControl_DokBilg.DataSource = DokBilg_Man.DoktorGirisCikis(dateTimePicker_GirTar.Value, dateTimePicker_CikTar.Value);
        }

        private void simpleButton_TarihSifirla_Click(object sender, EventArgs e)
        {
            dateTimePicker_GirTar.Value = DateTime.Parse("1.01.1753");
            dateTimePicker_CikTar.Value = DateTime.Parse("31.12.2100");
        }

    }
}
