namespace Hastane.UI
{
    partial class FrmRandevular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevular));
            this.gridControl_Randevu = new DevExpress.XtraGrid.GridControl();
            this.gridView_Randevu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_getir = new DevExpress.XtraEditors.SimpleButton();
            this.maskedTextBox_hastatc = new System.Windows.Forms.MaskedTextBox();
            this.textEdit_dogyer = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_soyad = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_ad = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.checkBox_1530 = new System.Windows.Forms.CheckBox();
            this.checkBox_1130 = new System.Windows.Forms.CheckBox();
            this.checkBox_1500 = new System.Windows.Forms.CheckBox();
            this.checkBox_1100 = new System.Windows.Forms.CheckBox();
            this.checkBox_1430 = new System.Windows.Forms.CheckBox();
            this.checkBox_1030 = new System.Windows.Forms.CheckBox();
            this.checkBox_1400 = new System.Windows.Forms.CheckBox();
            this.checkBox_1000 = new System.Windows.Forms.CheckBox();
            this.checkBox_1330 = new System.Windows.Forms.CheckBox();
            this.checkBox_0930 = new System.Windows.Forms.CheckBox();
            this.checkBox_1300 = new System.Windows.Forms.CheckBox();
            this.checkBox_0900 = new System.Windows.Forms.CheckBox();
            this.simpleButton_RanAl = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Sorgula = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox_aciklama = new System.Windows.Forms.RichTextBox();
            this.comboBox_Doktor = new System.Windows.Forms.ComboBox();
            this.comboBox_Klinik = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_RanTar = new System.Windows.Forms.DateTimePicker();
            this.simpleButton_yeni = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_focSorgula = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Randevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Randevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_dogyer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_Randevu
            // 
            this.gridControl_Randevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Randevu.Location = new System.Drawing.Point(2, 20);
            this.gridControl_Randevu.MainView = this.gridView_Randevu;
            this.gridControl_Randevu.Name = "gridControl_Randevu";
            this.gridControl_Randevu.Size = new System.Drawing.Size(590, 387);
            this.gridControl_Randevu.TabIndex = 0;
            this.gridControl_Randevu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Randevu});
            // 
            // gridView_Randevu
            // 
            this.gridView_Randevu.GridControl = this.gridControl_Randevu;
            this.gridView_Randevu.Name = "gridView_Randevu";
            this.gridView_Randevu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Randevu_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControl_Randevu);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(594, 409);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Randevu Listesi";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.simpleButton_getir);
            this.groupControl2.Controls.Add(this.maskedTextBox_hastatc);
            this.groupControl2.Controls.Add(this.textEdit_dogyer);
            this.groupControl2.Controls.Add(this.textEdit_soyad);
            this.groupControl2.Controls.Add(this.textEdit_ad);
            this.groupControl2.Location = new System.Drawing.Point(612, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(176, 117);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Hasta Bilgileri";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 97);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Dogum Yeri";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Soyad";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(52, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(13, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ad";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "TC";
            // 
            // simpleButton_getir
            // 
            this.simpleButton_getir.Enabled = false;
            this.simpleButton_getir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_getir.ImageOptions.Image")));
            this.simpleButton_getir.Location = new System.Drawing.Point(113, 23);
            this.simpleButton_getir.Name = "simpleButton_getir";
            this.simpleButton_getir.Size = new System.Drawing.Size(58, 23);
            this.simpleButton_getir.TabIndex = 2;
            this.simpleButton_getir.Text = "Getir";
            this.simpleButton_getir.Click += new System.EventHandler(this.simpleButton_getir_Click);
            // 
            // maskedTextBox_hastatc
            // 
            this.maskedTextBox_hastatc.Enabled = false;
            this.maskedTextBox_hastatc.Location = new System.Drawing.Point(29, 23);
            this.maskedTextBox_hastatc.Mask = "00000000000";
            this.maskedTextBox_hastatc.Name = "maskedTextBox_hastatc";
            this.maskedTextBox_hastatc.Size = new System.Drawing.Size(78, 21);
            this.maskedTextBox_hastatc.TabIndex = 1;
            this.maskedTextBox_hastatc.ValidatingType = typeof(int);
            // 
            // textEdit_dogyer
            // 
            this.textEdit_dogyer.Enabled = false;
            this.textEdit_dogyer.Location = new System.Drawing.Point(69, 94);
            this.textEdit_dogyer.Name = "textEdit_dogyer";
            this.textEdit_dogyer.Size = new System.Drawing.Size(100, 20);
            this.textEdit_dogyer.TabIndex = 0;
            // 
            // textEdit_soyad
            // 
            this.textEdit_soyad.Enabled = false;
            this.textEdit_soyad.Location = new System.Drawing.Point(69, 73);
            this.textEdit_soyad.Name = "textEdit_soyad";
            this.textEdit_soyad.Size = new System.Drawing.Size(100, 20);
            this.textEdit_soyad.TabIndex = 0;
            // 
            // textEdit_ad
            // 
            this.textEdit_ad.Enabled = false;
            this.textEdit_ad.Location = new System.Drawing.Point(69, 52);
            this.textEdit_ad.Name = "textEdit_ad";
            this.textEdit_ad.Size = new System.Drawing.Size(100, 20);
            this.textEdit_ad.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.checkBox_1530);
            this.groupControl3.Controls.Add(this.checkBox_1130);
            this.groupControl3.Controls.Add(this.checkBox_1500);
            this.groupControl3.Controls.Add(this.checkBox_1100);
            this.groupControl3.Controls.Add(this.checkBox_1430);
            this.groupControl3.Controls.Add(this.checkBox_1030);
            this.groupControl3.Controls.Add(this.checkBox_1400);
            this.groupControl3.Controls.Add(this.checkBox_1000);
            this.groupControl3.Controls.Add(this.checkBox_1330);
            this.groupControl3.Controls.Add(this.checkBox_0930);
            this.groupControl3.Controls.Add(this.checkBox_1300);
            this.groupControl3.Controls.Add(this.checkBox_0900);
            this.groupControl3.Controls.Add(this.simpleButton_RanAl);
            this.groupControl3.Controls.Add(this.simpleButton_focSorgula);
            this.groupControl3.Controls.Add(this.simpleButton_Sorgula);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.richTextBox_aciklama);
            this.groupControl3.Controls.Add(this.comboBox_Doktor);
            this.groupControl3.Controls.Add(this.comboBox_Klinik);
            this.groupControl3.Controls.Add(this.dateTimePicker_RanTar);
            this.groupControl3.Location = new System.Drawing.Point(612, 135);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(176, 273);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Randevu Bilgileri";
            // 
            // checkBox_1530
            // 
            this.checkBox_1530.AutoSize = true;
            this.checkBox_1530.Enabled = false;
            this.checkBox_1530.Location = new System.Drawing.Point(119, 217);
            this.checkBox_1530.Name = "checkBox_1530";
            this.checkBox_1530.Size = new System.Drawing.Size(54, 17);
            this.checkBox_1530.TabIndex = 5;
            this.checkBox_1530.Text = "15:30";
            this.checkBox_1530.UseVisualStyleBackColor = true;
            this.checkBox_1530.CheckedChanged += new System.EventHandler(this.checkBox_1530_CheckedChanged);
            // 
            // checkBox_1130
            // 
            this.checkBox_1130.AutoSize = true;
            this.checkBox_1130.Enabled = false;
            this.checkBox_1130.Location = new System.Drawing.Point(119, 181);
            this.checkBox_1130.Name = "checkBox_1130";
            this.checkBox_1130.Size = new System.Drawing.Size(54, 17);
            this.checkBox_1130.TabIndex = 5;
            this.checkBox_1130.Text = "11:30";
            this.checkBox_1130.UseVisualStyleBackColor = true;
            this.checkBox_1130.CheckedChanged += new System.EventHandler(this.checkBox_1130_CheckedChanged);
            // 
            // checkBox_1500
            // 
            this.checkBox_1500.AutoSize = true;
            this.checkBox_1500.Enabled = false;
            this.checkBox_1500.Location = new System.Drawing.Point(66, 217);
            this.checkBox_1500.Name = "checkBox_1500";
            this.checkBox_1500.Size = new System.Drawing.Size(54, 17);
            this.checkBox_1500.TabIndex = 5;
            this.checkBox_1500.Text = "15:00";
            this.checkBox_1500.UseVisualStyleBackColor = true;
            this.checkBox_1500.CheckedChanged += new System.EventHandler(this.checkBox_1500_CheckedChanged);
            // 
            // checkBox_1100
            // 
            this.checkBox_1100.AutoSize = true;
            this.checkBox_1100.Enabled = false;
            this.checkBox_1100.Location = new System.Drawing.Point(66, 181);
            this.checkBox_1100.Name = "checkBox_1100";
            this.checkBox_1100.Size = new System.Drawing.Size(54, 17);
            this.checkBox_1100.TabIndex = 5;
            this.checkBox_1100.Text = "11:00";
            this.checkBox_1100.UseVisualStyleBackColor = true;
            this.checkBox_1100.CheckedChanged += new System.EventHandler(this.checkBox_1100_CheckedChanged);
            // 
            // checkBox_1430
            // 
            this.checkBox_1430.AutoSize = true;
            this.checkBox_1430.Enabled = false;
            this.checkBox_1430.Location = new System.Drawing.Point(6, 217);
            this.checkBox_1430.Name = "checkBox_1430";
            this.checkBox_1430.Size = new System.Drawing.Size(54, 17);
            this.checkBox_1430.TabIndex = 5;
            this.checkBox_1430.Text = "14:30";
            this.checkBox_1430.UseVisualStyleBackColor = true;
            this.checkBox_1430.CheckedChanged += new System.EventHandler(this.checkBox_1430_CheckedChanged);
            // 
            // checkBox_1030
            // 
            this.checkBox_1030.AutoSize = true;
            this.checkBox_1030.Enabled = false;
            this.checkBox_1030.Location = new System.Drawing.Point(6, 181);
            this.checkBox_1030.Name = "checkBox_1030";
            this.checkBox_1030.Size = new System.Drawing.Size(54, 17);
            this.checkBox_1030.TabIndex = 5;
            this.checkBox_1030.Text = "10:30";
            this.checkBox_1030.UseVisualStyleBackColor = true;
            this.checkBox_1030.CheckedChanged += new System.EventHandler(this.checkBox_1030_CheckedChanged);
            // 
            // checkBox_1400
            // 
            this.checkBox_1400.AutoSize = true;
            this.checkBox_1400.Enabled = false;
            this.checkBox_1400.Location = new System.Drawing.Point(119, 199);
            this.checkBox_1400.Name = "checkBox_1400";
            this.checkBox_1400.Size = new System.Drawing.Size(54, 17);
            this.checkBox_1400.TabIndex = 5;
            this.checkBox_1400.Text = "14:00";
            this.checkBox_1400.UseVisualStyleBackColor = true;
            this.checkBox_1400.CheckedChanged += new System.EventHandler(this.checkBox_1400_CheckedChanged);
            // 
            // checkBox_1000
            // 
            this.checkBox_1000.AutoSize = true;
            this.checkBox_1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox_1000.Enabled = false;
            this.checkBox_1000.Location = new System.Drawing.Point(119, 163);
            this.checkBox_1000.Name = "checkBox_1000";
            this.checkBox_1000.Size = new System.Drawing.Size(54, 17);
            this.checkBox_1000.TabIndex = 5;
            this.checkBox_1000.Text = "10:00";
            this.checkBox_1000.UseVisualStyleBackColor = true;
            this.checkBox_1000.CheckedChanged += new System.EventHandler(this.checkBox_1000_CheckedChanged);
            // 
            // checkBox_1330
            // 
            this.checkBox_1330.AutoSize = true;
            this.checkBox_1330.Enabled = false;
            this.checkBox_1330.Location = new System.Drawing.Point(66, 199);
            this.checkBox_1330.Name = "checkBox_1330";
            this.checkBox_1330.Size = new System.Drawing.Size(54, 17);
            this.checkBox_1330.TabIndex = 5;
            this.checkBox_1330.Text = "13:30";
            this.checkBox_1330.UseVisualStyleBackColor = true;
            this.checkBox_1330.CheckedChanged += new System.EventHandler(this.checkBox_1330_CheckedChanged);
            // 
            // checkBox_0930
            // 
            this.checkBox_0930.AutoSize = true;
            this.checkBox_0930.Enabled = false;
            this.checkBox_0930.Location = new System.Drawing.Point(66, 163);
            this.checkBox_0930.Name = "checkBox_0930";
            this.checkBox_0930.Size = new System.Drawing.Size(54, 17);
            this.checkBox_0930.TabIndex = 5;
            this.checkBox_0930.Text = "09:30";
            this.checkBox_0930.UseVisualStyleBackColor = true;
            this.checkBox_0930.CheckedChanged += new System.EventHandler(this.checkBox_0930_CheckedChanged);
            // 
            // checkBox_1300
            // 
            this.checkBox_1300.AutoSize = true;
            this.checkBox_1300.Enabled = false;
            this.checkBox_1300.Location = new System.Drawing.Point(6, 199);
            this.checkBox_1300.Name = "checkBox_1300";
            this.checkBox_1300.Size = new System.Drawing.Size(54, 17);
            this.checkBox_1300.TabIndex = 5;
            this.checkBox_1300.Text = "13:00";
            this.checkBox_1300.UseVisualStyleBackColor = true;
            this.checkBox_1300.CheckedChanged += new System.EventHandler(this.checkBox_1300_CheckedChanged);
            // 
            // checkBox_0900
            // 
            this.checkBox_0900.AutoSize = true;
            this.checkBox_0900.Enabled = false;
            this.checkBox_0900.Location = new System.Drawing.Point(6, 163);
            this.checkBox_0900.Name = "checkBox_0900";
            this.checkBox_0900.Size = new System.Drawing.Size(54, 17);
            this.checkBox_0900.TabIndex = 5;
            this.checkBox_0900.Text = "09:00";
            this.checkBox_0900.UseVisualStyleBackColor = true;
            this.checkBox_0900.CheckedChanged += new System.EventHandler(this.checkBox_0900_CheckedChanged_1);
            // 
            // simpleButton_RanAl
            // 
            this.simpleButton_RanAl.Appearance.Font = new System.Drawing.Font("Jokerman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_RanAl.Appearance.Options.UseFont = true;
            this.simpleButton_RanAl.Enabled = false;
            this.simpleButton_RanAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_RanAl.ImageOptions.Image")));
            this.simpleButton_RanAl.Location = new System.Drawing.Point(10, 240);
            this.simpleButton_RanAl.Name = "simpleButton_RanAl";
            this.simpleButton_RanAl.Size = new System.Drawing.Size(159, 23);
            this.simpleButton_RanAl.TabIndex = 4;
            this.simpleButton_RanAl.Text = "Randevu Al";
            this.simpleButton_RanAl.Click += new System.EventHandler(this.simpleButton_RanAl_Click);
            // 
            // simpleButton_Sorgula
            // 
            this.simpleButton_Sorgula.Appearance.Font = new System.Drawing.Font("Jokerman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_Sorgula.Appearance.Options.UseFont = true;
            this.simpleButton_Sorgula.Enabled = false;
            this.simpleButton_Sorgula.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_Sorgula.ImageOptions.Image")));
            this.simpleButton_Sorgula.Location = new System.Drawing.Point(10, 134);
            this.simpleButton_Sorgula.Name = "simpleButton_Sorgula";
            this.simpleButton_Sorgula.Size = new System.Drawing.Size(159, 23);
            this.simpleButton_Sorgula.TabIndex = 4;
            this.simpleButton_Sorgula.Text = "Randevu Sorgula";
            this.simpleButton_Sorgula.Click += new System.EventHandler(this.simpleButton_Sorgula_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 91);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 13);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Açiklama";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(26, 69);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 13);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "Doktor";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(35, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Klinik";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 25);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Ran. Tarihi";
            // 
            // richTextBox_aciklama
            // 
            this.richTextBox_aciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_aciklama.Enabled = false;
            this.richTextBox_aciklama.Location = new System.Drawing.Point(66, 88);
            this.richTextBox_aciklama.Name = "richTextBox_aciklama";
            this.richTextBox_aciklama.Size = new System.Drawing.Size(107, 40);
            this.richTextBox_aciklama.TabIndex = 3;
            this.richTextBox_aciklama.Text = "";
            // 
            // comboBox_Doktor
            // 
            this.comboBox_Doktor.Enabled = false;
            this.comboBox_Doktor.FormattingEnabled = true;
            this.comboBox_Doktor.Location = new System.Drawing.Point(66, 66);
            this.comboBox_Doktor.Name = "comboBox_Doktor";
            this.comboBox_Doktor.Size = new System.Drawing.Size(107, 21);
            this.comboBox_Doktor.TabIndex = 2;
            // 
            // comboBox_Klinik
            // 
            this.comboBox_Klinik.Enabled = false;
            this.comboBox_Klinik.FormattingEnabled = true;
            this.comboBox_Klinik.Location = new System.Drawing.Point(66, 44);
            this.comboBox_Klinik.Name = "comboBox_Klinik";
            this.comboBox_Klinik.Size = new System.Drawing.Size(107, 21);
            this.comboBox_Klinik.TabIndex = 1;
            this.comboBox_Klinik.SelectedIndexChanged += new System.EventHandler(this.comboBox_Klinik_SelectedIndexChanged);
            // 
            // dateTimePicker_RanTar
            // 
            this.dateTimePicker_RanTar.Enabled = false;
            this.dateTimePicker_RanTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_RanTar.Location = new System.Drawing.Point(66, 22);
            this.dateTimePicker_RanTar.Name = "dateTimePicker_RanTar";
            this.dateTimePicker_RanTar.Size = new System.Drawing.Size(107, 21);
            this.dateTimePicker_RanTar.TabIndex = 0;
            // 
            // simpleButton_yeni
            // 
            this.simpleButton_yeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton_yeni.Location = new System.Drawing.Point(618, 410);
            this.simpleButton_yeni.Name = "simpleButton_yeni";
            this.simpleButton_yeni.Size = new System.Drawing.Size(52, 23);
            this.simpleButton_yeni.TabIndex = 3;
            this.simpleButton_yeni.Text = "Yeni";
            this.simpleButton_yeni.Click += new System.EventHandler(this.simpleButton_yeni_Click);
            // 
            // simpleButton_Guncelle
            // 
            this.simpleButton_Guncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton_Guncelle.Enabled = false;
            this.simpleButton_Guncelle.Location = new System.Drawing.Point(677, 410);
            this.simpleButton_Guncelle.Name = "simpleButton_Guncelle";
            this.simpleButton_Guncelle.Size = new System.Drawing.Size(52, 23);
            this.simpleButton_Guncelle.TabIndex = 3;
            this.simpleButton_Guncelle.Text = "Guncelle";
            this.simpleButton_Guncelle.Click += new System.EventHandler(this.simpleButton_Guncelle_Click);
            // 
            // simpleButton_Sil
            // 
            this.simpleButton_Sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton_Sil.Enabled = false;
            this.simpleButton_Sil.Location = new System.Drawing.Point(733, 410);
            this.simpleButton_Sil.Name = "simpleButton_Sil";
            this.simpleButton_Sil.Size = new System.Drawing.Size(52, 23);
            this.simpleButton_Sil.TabIndex = 3;
            this.simpleButton_Sil.Text = "Sil";
            this.simpleButton_Sil.Click += new System.EventHandler(this.simpleButton_Sil_Click);
            // 
            // simpleButton_focSorgula
            // 
            this.simpleButton_focSorgula.Appearance.Font = new System.Drawing.Font("Jokerman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_focSorgula.Appearance.Options.UseFont = true;
            this.simpleButton_focSorgula.Enabled = false;
            this.simpleButton_focSorgula.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton_focSorgula.Location = new System.Drawing.Point(10, 134);
            this.simpleButton_focSorgula.Name = "simpleButton_focSorgula";
            this.simpleButton_focSorgula.Size = new System.Drawing.Size(159, 23);
            this.simpleButton_focSorgula.TabIndex = 4;
            this.simpleButton_focSorgula.Text = "Randevu Sorgula";
            this.simpleButton_focSorgula.Click += new System.EventHandler(this.simpleButton_focSorgula_Click);
            // 
            // FrmRandevular
            // 
            this.AcceptButton = this.simpleButton_getir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.simpleButton_Sil);
            this.Controls.Add(this.simpleButton_Guncelle);
            this.Controls.Add(this.simpleButton_yeni);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmRandevular";
            this.Text = "FrmRandevular";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRandevular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Randevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Randevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_dogyer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Randevu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Randevu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_getir;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_hastatc;
        private DevExpress.XtraEditors.TextEdit textEdit_ad;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_dogyer;
        private DevExpress.XtraEditors.TextEdit textEdit_soyad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RichTextBox richTextBox_aciklama;
        private System.Windows.Forms.ComboBox comboBox_Doktor;
        private System.Windows.Forms.ComboBox comboBox_Klinik;
        private System.Windows.Forms.DateTimePicker dateTimePicker_RanTar;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Sorgula;
        private System.Windows.Forms.CheckBox checkBox_1530;
        private System.Windows.Forms.CheckBox checkBox_1130;
        private System.Windows.Forms.CheckBox checkBox_1500;
        private System.Windows.Forms.CheckBox checkBox_1100;
        private System.Windows.Forms.CheckBox checkBox_1430;
        private System.Windows.Forms.CheckBox checkBox_1030;
        private System.Windows.Forms.CheckBox checkBox_1400;
        private System.Windows.Forms.CheckBox checkBox_1000;
        private System.Windows.Forms.CheckBox checkBox_1330;
        private System.Windows.Forms.CheckBox checkBox_0930;
        private System.Windows.Forms.CheckBox checkBox_1300;
        private System.Windows.Forms.CheckBox checkBox_0900;
        private DevExpress.XtraEditors.SimpleButton simpleButton_RanAl;
        private DevExpress.XtraEditors.SimpleButton simpleButton_yeni;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Guncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Sil;
        private DevExpress.XtraEditors.SimpleButton simpleButton_focSorgula;
    }
}