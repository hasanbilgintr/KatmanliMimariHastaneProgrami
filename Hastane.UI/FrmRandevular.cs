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
    public partial class FrmRandevular : Form
    {
        public FrmRandevular()
        {
            InitializeComponent();
        }

        KliniklerManager kli_man = new KliniklerManager();
        DoktorlarManager dok_man = new DoktorlarManager();
        HastalarManager has_man = new HastalarManager();
        RandevularManager ran_man = new RandevularManager();
        illerManager il_man = new illerManager();

        private void FrmRandevular_Load(object sender, EventArgs e)
        {
            comboBox_Klinik.DataSource = kli_man.Listele();
            comboBox_Klinik.DisplayMember = "KlinikAdi";
            comboBox_Klinik.ValueMember = "KliniklerID";

            dateTimePicker_RanTar.MinDate = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            //dateTimePicker_RanTar.MaxDate = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month , DateTime.Now.Day + 14);

            gridControl_Randevu.DataSource = ran_man.randevuListesi();
        }

        int hastaid;

        private void simpleButton_getir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(maskedTextBox_hastatc.Text.Trim()))
            {
                var hasta = has_man.HastaTCGetir(maskedTextBox_hastatc.Text.Trim());
                if (hasta != null)
                {
                    simpleButton_getir.Enabled = false;
                    dateTimePicker_RanTar.Enabled = true;
                    comboBox_Klinik.Enabled = true;
                    comboBox_Doktor.Enabled = true;
                    richTextBox_aciklama.Enabled = true;
                    maskedTextBox_hastatc.Enabled = false;
                    simpleButton_Sorgula.Enabled = true;
                    simpleButton_focSorgula.Visible = false;
                    textEdit_ad.Text = hasta.HastaAdi;
                    textEdit_soyad.Text = hasta.HastaSoyadi;
                    textEdit_dogyer.Text = hasta.iller.ilAdi;
                    hastaid = hasta.HastalarID;
                }
                else
                {
                    textEdit_ad.Text = null;
                    textEdit_soyad.Text = null;
                    textEdit_dogyer.Text = null;
                    MessageBox.Show("Böyle Bir Hasta Yoktur");
                }
            }
            else
            {
                textEdit_ad.Text = null;
                textEdit_soyad.Text = null;
                textEdit_dogyer.Text = null;
                MessageBox.Show("Lütfen Tc Girin");
            }

        }



        private void simpleButton_Sorgula_Click(object sender, EventArgs e)
        {
            simpleButton_RanAl.Enabled = true;
            ran_man.checkboxaktif(checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);

            if (hastaid != 0)
            {
                if (comboBox_Doktor.Text != "Doktor Yok")
                {
                    var doktorid = dok_man.DoktorGetir((int)comboBox_Doktor.SelectedValue);

                    if (doktorid != null)
                    {
                        var randevuvarmi = ran_man.randevuaynimi((int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue, hastaid, dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day);

                        if (randevuvarmi == null)
                        {
                            var _0900 = ran_man.saatdolumu("09:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _0930 = ran_man.saatdolumu("09:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _1000 = ran_man.saatdolumu("10:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _1030 = ran_man.saatdolumu("10:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _1100 = ran_man.saatdolumu("11:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _1130 = ran_man.saatdolumu("11:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _1300 = ran_man.saatdolumu("13:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _1330 = ran_man.saatdolumu("13:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _1400 = ran_man.saatdolumu("14:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _1430 = ran_man.saatdolumu("14:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _1500 = ran_man.saatdolumu("15:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                            var _1530 = ran_man.saatdolumu("15:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)
                                comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);


                            object[] dolusaat = { _0900, _0930, _1000, _1030, _1100, _1130, _1300, _1330, _1400, _1430, _1500, _1530 };

                            CheckBox[] saatler = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530, };

                            for (int i = 0; i < dolusaat.Length; i++)
                            {
                                if (dolusaat[i] != null)
                                {
                                    saatler[i].Enabled = false;
                                    saatler[i].BackColor = Color.Red;
                                }
                            }
                        }
                        else
                        {
                            ran_man.checkboxpasif(checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);
                            simpleButton_RanAl.Enabled = false;
                            MessageBox.Show("Lütfen Başka Bir gün yada Başka Bir Doktordan Randevu Alınız");
                        }
                    }
                }
                else
                {
                    ran_man.checkboxpasif(checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);

                    MessageBox.Show("Lütfen Doktoru Olan Klinik Seçiniz");
                }
            }
            else { MessageBox.Show("Lütfen Hastanın Tc sini girip onaylayınız"); }
        }

        private void comboBox_Klinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var klinikdoktoru = dok_man.klinikIDdoktorGetir(comboBox_Klinik.SelectedIndex + 1);
                if (klinikdoktoru.Count() > 0)
                {
                    comboBox_Doktor.DataSource = dok_man.klinikIDdoktorGetir(comboBox_Klinik.SelectedIndex + 1); //he ikiside combobox seçimi aynı 
                    comboBox_Doktor.DisplayMember = "DoktorAdi";
                    comboBox_Doktor.ValueMember = "DoktorlarID";
                }
                else
                {
                    comboBox_Doktor.DataSource = dok_man.klinikIDdoktorGetir(comboBox_Klinik.SelectedIndex + 1); //he ikiside combobox seçimi aynı 
                    comboBox_Doktor.DisplayMember = "DoktorAdi";
                    comboBox_Doktor.ValueMember = "DoktorlarID";
                    comboBox_Doktor.Text = "Doktor Yok";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata var Yetkiliye Bildirin");
            }
        }

        private void simpleButton_RanAl_Click(object sender, EventArgs e)
        {

            string isaret = ran_man.isaretli(checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);
            if (isaret == "işaretlenmedi")
            {
                MessageBox.Show("Lütfen Saat İşaretleyiniz");
            }
            else
            {
                simpleButton_yeni.Enabled = true;
                simpleButton_yeni.Enabled = true;
                simpleButton_Sorgula.Enabled = false;
                simpleButton_RanAl.Enabled = false;
                dateTimePicker_RanTar.Enabled = false;
                comboBox_Klinik.Enabled = false;
                comboBox_Doktor.Enabled = false;
                richTextBox_aciklama.Enabled = false;
                string RanEkle = ran_man.Ekle(hastaid, (int)comboBox_Klinik.SelectedValue, (int)comboBox_Doktor.SelectedValue, dateTimePicker_RanTar.Value, isaret, richTextBox_aciklama.Text, 1);
                gridControl_Randevu.DataSource = ran_man.randevuListesi();
                MessageBox.Show(RanEkle.ToString());
                ran_man.checkboxpasifredsiz(checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);
            }

        }

        private void checkBox_0900_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_0900.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }
        }

        private void checkBox_0930_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_0930.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }

        }

        private void checkBox_1000_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1000.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_0930, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }
        }

        private void checkBox_1030_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1030.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }
        }

        private void checkBox_1100_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1100.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }

        }

        private void checkBox_1130_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1130.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }
        }

        private void checkBox_1300_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1300.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }

        }

        private void checkBox_1330_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1330.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }
        }

        private void checkBox_1400_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1400.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1430, checkBox_1500, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }

        }

        private void checkBox_1430_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1430.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1500, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }

        }

        private void checkBox_1500_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1500.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1530 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }

        }

        private void checkBox_1530_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_1530.Checked == true)
            {
                CheckBox[] coksecim = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500 };

                for (int i = 0; i < coksecim.Length; i++)
                {
                    coksecim[i].Checked = false;
                }
            }
        }

        private void simpleButton_yeni_Click(object sender, EventArgs e)
        {
            maskedTextBox_hastatc.Enabled = true;
            maskedTextBox_hastatc.Text = "";
            textEdit_ad.Text = "";
            textEdit_soyad.Text = "";
            textEdit_dogyer.Text = "";
            simpleButton_getir.Enabled = true;
            dateTimePicker_RanTar.Enabled = false;
            dateTimePicker_RanTar.Value = DateTime.Now;
            comboBox_Klinik.Enabled = false;
            comboBox_Doktor.Enabled = false;
            richTextBox_aciklama.Enabled = false;
            richTextBox_aciklama.Text = "";
            simpleButton_focSorgula.Visible = false;
            simpleButton_Sorgula.Visible = true;
            ran_man.checkboxpasifredsiz(checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);
            simpleButton_Guncelle.Enabled = false;
            simpleButton_Sil.Enabled = false;
        }

        int randevuID;
        int hastaidfocus;

        private void gridView_Randevu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            simpleButton_getir.Enabled = false;
            maskedTextBox_hastatc.Enabled = false;
            dateTimePicker_RanTar.Enabled = true;
            comboBox_Klinik.Enabled = true;
            comboBox_Doktor.Enabled = true;
            richTextBox_aciklama.Enabled = true;
            simpleButton_yeni.Enabled = true;

            simpleButton_Sorgula.Enabled = false;
            simpleButton_Sorgula.Visible = false;
            simpleButton_focSorgula.Enabled = true;
            simpleButton_focSorgula.Visible = true;

            ran_man.checkboxpasifredsiz(checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);
            simpleButton_Guncelle.Enabled = true;
            simpleButton_Sil.Enabled = true;


            randevuID = (int)gridView_Randevu.GetFocusedRowCellValue("RandevularID");
            hastaidfocus = ran_man.RandevuIDGetir(randevuID).HastaID;
            maskedTextBox_hastatc.Text = has_man.HastaGetir(hastaidfocus).HastaTC;
            textEdit_ad.Text = has_man.HastaGetir(hastaidfocus).HastaAdi;
            textEdit_soyad.Text = has_man.HastaGetir(hastaidfocus).HastaSoyadi;
            int dogyerid = (int)has_man.HastaGetir(hastaidfocus).DogumYeriID;
            //yada il adı için gridcontroldan hastaid çekip hastalarmanagerden hastabul tanımpalayıp hastaid göndercez oda dogyerid vercek sonra ilmanagerede dogyerid göderrince il adı gelicektir tablolar birribire bağlı olmadığı için uzun işlem sürdü
            textEdit_dogyer.Text = il_man.ilBul(dogyerid).ilAdi;
            dateTimePicker_RanTar.Value = ran_man.RandevuIDGetir(randevuID).RandevuTarihi;
            int klinikid = ran_man.RandevuIDGetir(randevuID).KlinikID;
            comboBox_Klinik.Text = kli_man.KlinikGetir(klinikid).KlinikAdi;
            int doktorid = ran_man.RandevuIDGetir(randevuID).DoktorID;
            comboBox_Doktor.Text = dok_man.DoktorGetir(doktorid).DoktorAdi;
            richTextBox_aciklama.Text = ran_man.RandevuIDGetir(randevuID).Aciklama;
            string isaretli = ran_man.RandevuIDGetir(randevuID).RandevuSaati;
            ran_man.isaretle(isaretli, checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);
        }

        private void simpleButton_Guncelle_Click(object sender, EventArgs e)
        {
            Randevular tablo = new Randevular();
            tablo.HastaID = hastaidfocus;
            tablo.KlinikID = (int)comboBox_Klinik.SelectedValue;
            tablo.DoktorID = (int)comboBox_Doktor.SelectedValue;
            tablo.RandevuTarihi = dateTimePicker_RanTar.Value;
            tablo.RandevuSaati = ran_man.isaretli(checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);
            tablo.Aciklama = richTextBox_aciklama.Text;
            tablo.KullaniciID = 1;
            if (tablo.RandevuSaati == "işaretlenmedi")
            {
                MessageBox.Show("Lütfen Saat İşaretleyiniz");
            }
            else
            {
                string GuncelleSonuc = ran_man.Guncelle(randevuID, tablo);
                FrmRandevular frm_ran = (FrmRandevular)Application.OpenForms["FrmRandevular"];
                frm_ran.gridControl_Randevu.DataSource = ran_man.randevuListesi();
                MessageBox.Show(GuncelleSonuc.ToString());
            }
        }

        private void simpleButton_focSorgula_Click(object sender, EventArgs e)
        {
            simpleButton_focSorgula.Enabled = true;

            ran_man.checkboxaktif(checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);

            if (comboBox_Doktor.Text != "Doktor Yok")
            {
                var _0900 = ran_man.saatdolumu("09:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _0930 = ran_man.saatdolumu("09:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _1000 = ran_man.saatdolumu("10:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _1030 = ran_man.saatdolumu("10:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _1100 = ran_man.saatdolumu("11:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _1130 = ran_man.saatdolumu("11:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _1300 = ran_man.saatdolumu("13:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _1330 = ran_man.saatdolumu("13:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _1400 = ran_man.saatdolumu("14:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _1430 = ran_man.saatdolumu("14:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _1500 = ran_man.saatdolumu("15:00", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);
                var _1530 = ran_man.saatdolumu("15:30", dateTimePicker_RanTar.Value.Year, dateTimePicker_RanTar.Value.Month, dateTimePicker_RanTar.Value.Day, (int)
                    comboBox_Doktor.SelectedValue, (int)comboBox_Klinik.SelectedValue);

                object[] dolusaat = { _0900, _0930, _1000, _1030, _1100, _1130, _1300, _1330, _1400, _1430, _1500, _1530 };

                CheckBox[] saatler = { checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530, };

                for (int i = 0; i < dolusaat.Length; i++)
                {
                    if (dolusaat[i] != null)
                    {
                        saatler[i].Enabled = false;
                        saatler[i].BackColor = Color.Red;
                        saatler[i].Checked = false;
                    }
                }
            }
            else
            {
                ran_man.checkboxpasif(checkBox_0900, checkBox_0930, checkBox_1000, checkBox_1030, checkBox_1100, checkBox_1130, checkBox_1300, checkBox_1330, checkBox_1400, checkBox_1430, checkBox_1500, checkBox_1530);

                MessageBox.Show("Lütfen Doktoru Olan Klinik Seçiniz");
            }
        }

        private void simpleButton_Sil_Click(object sender, EventArgs e)
        {
            string SilSonuc = ran_man.Sil(randevuID);
            FrmRandevular frm_ran = (FrmRandevular)Application.OpenForms["FrmRandevular"];
            frm_ran.gridControl_Randevu.DataSource = ran_man.randevuListesi();
            MessageBox.Show(SilSonuc.ToString());
        }

    }
    
}
