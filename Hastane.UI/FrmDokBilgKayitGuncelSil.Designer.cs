namespace Hastane.UI
{
    partial class FrmDokBilgKayitGuncelSil
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
            this.simpleButton_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox_aktif = new System.Windows.Forms.ComboBox();
            this.comboBox_Doktor = new System.Windows.Forms.ComboBox();
            this.simpleButton_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Guncel = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker_ciktar = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_girtar = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton_Kaydet
            // 
            this.simpleButton_Kaydet.Location = new System.Drawing.Point(91, 135);
            this.simpleButton_Kaydet.Name = "simpleButton_Kaydet";
            this.simpleButton_Kaydet.Size = new System.Drawing.Size(121, 23);
            this.simpleButton_Kaydet.TabIndex = 7;
            this.simpleButton_Kaydet.Text = "Kaydet";
            this.simpleButton_Kaydet.Click += new System.EventHandler(this.simpleButton_Kaydet_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBox_aktif);
            this.groupControl1.Controls.Add(this.comboBox_Doktor);
            this.groupControl1.Controls.Add(this.simpleButton_Sil);
            this.groupControl1.Controls.Add(this.simpleButton_Guncel);
            this.groupControl1.Controls.Add(this.simpleButton_Kaydet);
            this.groupControl1.Controls.Add(this.dateTimePicker_ciktar);
            this.groupControl1.Controls.Add(this.dateTimePicker_girtar);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(277, 207);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Doktor Bilgileri";
            // 
            // comboBox_aktif
            // 
            this.comboBox_aktif.FormattingEnabled = true;
            this.comboBox_aktif.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.comboBox_aktif.Location = new System.Drawing.Point(90, 108);
            this.comboBox_aktif.Name = "comboBox_aktif";
            this.comboBox_aktif.Size = new System.Drawing.Size(120, 21);
            this.comboBox_aktif.TabIndex = 3;
            // 
            // comboBox_Doktor
            // 
            this.comboBox_Doktor.FormattingEnabled = true;
            this.comboBox_Doktor.Location = new System.Drawing.Point(90, 23);
            this.comboBox_Doktor.Name = "comboBox_Doktor";
            this.comboBox_Doktor.Size = new System.Drawing.Size(120, 21);
            this.comboBox_Doktor.TabIndex = 0;
            // 
            // simpleButton_Sil
            // 
            this.simpleButton_Sil.Location = new System.Drawing.Point(90, 164);
            this.simpleButton_Sil.Name = "simpleButton_Sil";
            this.simpleButton_Sil.Size = new System.Drawing.Size(121, 23);
            this.simpleButton_Sil.TabIndex = 7;
            this.simpleButton_Sil.Text = "Sil";
            this.simpleButton_Sil.Click += new System.EventHandler(this.simpleButton_Sil_Click);
            // 
            // simpleButton_Guncel
            // 
            this.simpleButton_Guncel.Location = new System.Drawing.Point(90, 135);
            this.simpleButton_Guncel.Name = "simpleButton_Guncel";
            this.simpleButton_Guncel.Size = new System.Drawing.Size(121, 23);
            this.simpleButton_Guncel.TabIndex = 7;
            this.simpleButton_Guncel.Text = "Güncelle";
            this.simpleButton_Guncel.Click += new System.EventHandler(this.simpleButton_Guncel_Click);
            // 
            // dateTimePicker_ciktar
            // 
            this.dateTimePicker_ciktar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ciktar.Location = new System.Drawing.Point(89, 81);
            this.dateTimePicker_ciktar.Name = "dateTimePicker_ciktar";
            this.dateTimePicker_ciktar.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_ciktar.TabIndex = 2;
            // 
            // dateTimePicker_girtar
            // 
            this.dateTimePicker_girtar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_girtar.Location = new System.Drawing.Point(89, 53);
            this.dateTimePicker_girtar.Name = "dateTimePicker_girtar";
            this.dateTimePicker_girtar.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_girtar.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(45, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Aktifmi :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Çıkış Tarihi :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Giriş Tarihi :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Doktor :";
            // 
            // FrmDokBilgKayitGuncelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 207);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDokBilgKayitGuncelSil";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.ComboBox comboBox_aktif;
        public System.Windows.Forms.ComboBox comboBox_Doktor;
        public System.Windows.Forms.DateTimePicker dateTimePicker_ciktar;
        public System.Windows.Forms.DateTimePicker dateTimePicker_girtar;
        public DevExpress.XtraEditors.SimpleButton simpleButton_Kaydet;
        public DevExpress.XtraEditors.SimpleButton simpleButton_Sil;
        public DevExpress.XtraEditors.SimpleButton simpleButton_Guncel;
    }
}