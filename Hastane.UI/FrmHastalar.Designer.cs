namespace Hastane.UI
{
    partial class FrmHastalar
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
            this.gridControl_Hastalar = new DevExpress.XtraGrid.GridControl();
            this.gridView_Hastalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_Yeni = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Kayit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit_Acikla = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit_Adres = new DevExpress.XtraEditors.MemoEdit();
            this.maskedTextBox_Tel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_Tc = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_Kan = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DogTar = new System.Windows.Forms.DateTimePicker();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_Boy = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Kilo = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Email = new DevExpress.XtraEditors.TextEdit();
            this.comboBox_DogYer = new System.Windows.Forms.ComboBox();
            this.textEdit_Soyad = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Ad = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxEdit_Cinsiyet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit_MedHal = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Hastalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Hastalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Acikla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Adres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Boy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Kilo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Cinsiyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_MedHal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Hastalar
            // 
            this.gridControl_Hastalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Hastalar.Location = new System.Drawing.Point(2, 20);
            this.gridControl_Hastalar.MainView = this.gridView_Hastalar;
            this.gridControl_Hastalar.Name = "gridControl_Hastalar";
            this.gridControl_Hastalar.Size = new System.Drawing.Size(679, 490);
            this.gridControl_Hastalar.TabIndex = 0;
            this.gridControl_Hastalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Hastalar});
            // 
            // gridView_Hastalar
            // 
            this.gridView_Hastalar.GridControl = this.gridControl_Hastalar;
            this.gridView_Hastalar.Name = "gridView_Hastalar";
            this.gridView_Hastalar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Hastalar_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControl_Hastalar);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(683, 512);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Hasta Listesi";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.simpleButton_Yeni);
            this.groupControl2.Controls.Add(this.simpleButton_Kayit);
            this.groupControl2.Controls.Add(this.simpleButton_Sil);
            this.groupControl2.Controls.Add(this.memoEdit_Acikla);
            this.groupControl2.Controls.Add(this.simpleButton_Guncelle);
            this.groupControl2.Controls.Add(this.memoEdit_Adres);
            this.groupControl2.Controls.Add(this.maskedTextBox_Tel);
            this.groupControl2.Controls.Add(this.maskedTextBox_Tc);
            this.groupControl2.Controls.Add(this.comboBox_Kan);
            this.groupControl2.Controls.Add(this.dateTimePicker_DogTar);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.textEdit_Boy);
            this.groupControl2.Controls.Add(this.textEdit_Kilo);
            this.groupControl2.Controls.Add(this.textEdit_Email);
            this.groupControl2.Controls.Add(this.comboBox_DogYer);
            this.groupControl2.Controls.Add(this.textEdit_Soyad);
            this.groupControl2.Controls.Add(this.textEdit_Ad);
            this.groupControl2.Controls.Add(this.comboBoxEdit_Cinsiyet);
            this.groupControl2.Controls.Add(this.comboBoxEdit_MedHal);
            this.groupControl2.Location = new System.Drawing.Point(701, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(215, 440);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Hasta Bilgileri";
            // 
            // simpleButton_Yeni
            // 
            this.simpleButton_Yeni.Location = new System.Drawing.Point(5, 412);
            this.simpleButton_Yeni.Name = "simpleButton_Yeni";
            this.simpleButton_Yeni.Size = new System.Drawing.Size(64, 23);
            this.simpleButton_Yeni.TabIndex = 7;
            this.simpleButton_Yeni.Text = "Yeni";
            this.simpleButton_Yeni.Click += new System.EventHandler(this.simpleButton_Yeni_Click_1);
            // 
            // simpleButton_Kayit
            // 
            this.simpleButton_Kayit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.simpleButton_Kayit.Location = new System.Drawing.Point(5, 412);
            this.simpleButton_Kayit.Name = "simpleButton_Kayit";
            this.simpleButton_Kayit.Size = new System.Drawing.Size(64, 23);
            this.simpleButton_Kayit.TabIndex = 1;
            this.simpleButton_Kayit.Text = "Kayıt";
            this.simpleButton_Kayit.Click += new System.EventHandler(this.simpleButton_Kayit_Click);
            // 
            // simpleButton_Sil
            // 
            this.simpleButton_Sil.Location = new System.Drawing.Point(147, 412);
            this.simpleButton_Sil.Name = "simpleButton_Sil";
            this.simpleButton_Sil.Size = new System.Drawing.Size(64, 23);
            this.simpleButton_Sil.TabIndex = 1;
            this.simpleButton_Sil.Text = "Sil";
            this.simpleButton_Sil.Click += new System.EventHandler(this.simpleButton_Sil_Click);
            // 
            // memoEdit_Acikla
            // 
            this.memoEdit_Acikla.Location = new System.Drawing.Point(79, 357);
            this.memoEdit_Acikla.Name = "memoEdit_Acikla";
            this.memoEdit_Acikla.Size = new System.Drawing.Size(131, 42);
            this.memoEdit_Acikla.TabIndex = 6;
            // 
            // simpleButton_Guncelle
            // 
            this.simpleButton_Guncelle.Location = new System.Drawing.Point(76, 412);
            this.simpleButton_Guncelle.Name = "simpleButton_Guncelle";
            this.simpleButton_Guncelle.Size = new System.Drawing.Size(64, 23);
            this.simpleButton_Guncelle.TabIndex = 1;
            this.simpleButton_Guncelle.Text = "Güncelle";
            this.simpleButton_Guncelle.Click += new System.EventHandler(this.simpleButton_Guncelle_Click);
            // 
            // memoEdit_Adres
            // 
            this.memoEdit_Adres.Location = new System.Drawing.Point(79, 311);
            this.memoEdit_Adres.Name = "memoEdit_Adres";
            this.memoEdit_Adres.Size = new System.Drawing.Size(131, 40);
            this.memoEdit_Adres.TabIndex = 6;
            // 
            // maskedTextBox_Tel
            // 
            this.maskedTextBox_Tel.Location = new System.Drawing.Point(79, 100);
            this.maskedTextBox_Tel.Mask = "(999) 000-00 00";
            this.maskedTextBox_Tel.Name = "maskedTextBox_Tel";
            this.maskedTextBox_Tel.Size = new System.Drawing.Size(131, 21);
            this.maskedTextBox_Tel.TabIndex = 5;
            // 
            // maskedTextBox_Tc
            // 
            this.maskedTextBox_Tc.Location = new System.Drawing.Point(79, 30);
            this.maskedTextBox_Tc.Mask = "00000000000";
            this.maskedTextBox_Tc.Name = "maskedTextBox_Tc";
            this.maskedTextBox_Tc.Size = new System.Drawing.Size(131, 21);
            this.maskedTextBox_Tc.TabIndex = 5;
            this.maskedTextBox_Tc.ValidatingType = typeof(int);
            // 
            // comboBox_Kan
            // 
            this.comboBox_Kan.FormattingEnabled = true;
            this.comboBox_Kan.Location = new System.Drawing.Point(79, 241);
            this.comboBox_Kan.Name = "comboBox_Kan";
            this.comboBox_Kan.Size = new System.Drawing.Size(131, 21);
            this.comboBox_Kan.TabIndex = 1;
            // 
            // dateTimePicker_DogTar
            // 
            this.dateTimePicker_DogTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DogTar.Location = new System.Drawing.Point(79, 147);
            this.dateTimePicker_DogTar.Name = "dateTimePicker_DogTar";
            this.dateTimePicker_DogTar.Size = new System.Drawing.Size(131, 21);
            this.dateTimePicker_DogTar.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 199);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(61, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Medeni Hali :";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(48, 292);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(25, 13);
            this.labelControl14.TabIndex = 4;
            this.labelControl14.Text = "Boy :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 175);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Doğum Yeri :";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(25, 357);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(48, 13);
            this.labelControl13.TabIndex = 4;
            this.labelControl13.Text = "Açıklama :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(30, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Telefon :";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(50, 269);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(23, 13);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Kilo :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(4, 151);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Doğum Tarihi :";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(38, 311);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(35, 13);
            this.labelControl11.TabIndex = 4;
            this.labelControl11.Text = "Adres :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Soyad :";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(16, 245);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(57, 13);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Kan Grubu :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(28, 128);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Cinsiyet :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(42, 222);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(31, 13);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Email :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Ad :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tc :";
            // 
            // textEdit_Boy
            // 
            this.textEdit_Boy.EditValue = "0";
            this.textEdit_Boy.Location = new System.Drawing.Point(79, 288);
            this.textEdit_Boy.Name = "textEdit_Boy";
            this.textEdit_Boy.Size = new System.Drawing.Size(131, 20);
            this.textEdit_Boy.TabIndex = 2;
            // 
            // textEdit_Kilo
            // 
            this.textEdit_Kilo.EditValue = "0";
            this.textEdit_Kilo.Location = new System.Drawing.Point(79, 265);
            this.textEdit_Kilo.Name = "textEdit_Kilo";
            this.textEdit_Kilo.Size = new System.Drawing.Size(131, 20);
            this.textEdit_Kilo.TabIndex = 2;
            // 
            // textEdit_Email
            // 
            this.textEdit_Email.Location = new System.Drawing.Point(79, 218);
            this.textEdit_Email.Name = "textEdit_Email";
            this.textEdit_Email.Size = new System.Drawing.Size(131, 20);
            this.textEdit_Email.TabIndex = 2;
            // 
            // comboBox_DogYer
            // 
            this.comboBox_DogYer.FormattingEnabled = true;
            this.comboBox_DogYer.Location = new System.Drawing.Point(79, 171);
            this.comboBox_DogYer.Name = "comboBox_DogYer";
            this.comboBox_DogYer.Size = new System.Drawing.Size(131, 21);
            this.comboBox_DogYer.TabIndex = 1;
            // 
            // textEdit_Soyad
            // 
            this.textEdit_Soyad.Location = new System.Drawing.Point(79, 77);
            this.textEdit_Soyad.Name = "textEdit_Soyad";
            this.textEdit_Soyad.Size = new System.Drawing.Size(131, 20);
            this.textEdit_Soyad.TabIndex = 2;
            // 
            // textEdit_Ad
            // 
            this.textEdit_Ad.Location = new System.Drawing.Point(79, 54);
            this.textEdit_Ad.Name = "textEdit_Ad";
            this.textEdit_Ad.Size = new System.Drawing.Size(131, 20);
            this.textEdit_Ad.TabIndex = 2;
            // 
            // comboBoxEdit_Cinsiyet
            // 
            this.comboBoxEdit_Cinsiyet.Location = new System.Drawing.Point(79, 124);
            this.comboBoxEdit_Cinsiyet.Name = "comboBoxEdit_Cinsiyet";
            this.comboBoxEdit_Cinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_Cinsiyet.Properties.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBoxEdit_Cinsiyet.Size = new System.Drawing.Size(131, 20);
            this.comboBoxEdit_Cinsiyet.TabIndex = 0;
            // 
            // comboBoxEdit_MedHal
            // 
            this.comboBoxEdit_MedHal.Location = new System.Drawing.Point(79, 195);
            this.comboBoxEdit_MedHal.Name = "comboBoxEdit_MedHal";
            this.comboBoxEdit_MedHal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_MedHal.Properties.Items.AddRange(new object[] {
            "Bekar",
            "Evli",
            "Dul"});
            this.comboBoxEdit_MedHal.Size = new System.Drawing.Size(131, 20);
            this.comboBoxEdit_MedHal.TabIndex = 0;
            // 
            // FrmHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 536);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmHastalar";
            this.Text = "FrmHastalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Hastalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Hastalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Acikla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Adres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Boy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Kilo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Cinsiyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_MedHal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Hastalar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Hastalar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit memoEdit_Acikla;
        private DevExpress.XtraEditors.MemoEdit memoEdit_Adres;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Tel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Tc;
        private System.Windows.Forms.ComboBox comboBox_Kan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DogTar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_Boy;
        private DevExpress.XtraEditors.TextEdit textEdit_Kilo;
        private DevExpress.XtraEditors.TextEdit textEdit_Email;
        private System.Windows.Forms.ComboBox comboBox_DogYer;
        private DevExpress.XtraEditors.TextEdit textEdit_Soyad;
        private DevExpress.XtraEditors.TextEdit textEdit_Ad;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_Cinsiyet;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_MedHal;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Sil;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Guncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Kayit;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Yeni;
    }
}