namespace Hastane.UI
{
    partial class FrmDokUnvKayitGuncelSil
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
            this.textEdit_DokUnvan = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox_Bransadi = new System.Windows.Forms.ComboBox();
            this.simpleButton_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.maskedTextBox_dipno = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DokUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEdit_DokUnvan
            // 
            this.textEdit_DokUnvan.Location = new System.Drawing.Point(124, 24);
            this.textEdit_DokUnvan.Name = "textEdit_DokUnvan";
            this.textEdit_DokUnvan.Size = new System.Drawing.Size(112, 20);
            this.textEdit_DokUnvan.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton_Sil);
            this.groupControl1.Controls.Add(this.simpleButton_Guncelle);
            this.groupControl1.Controls.Add(this.comboBox_Bransadi);
            this.groupControl1.Controls.Add(this.simpleButton_kaydet);
            this.groupControl1.Controls.Add(this.textEdit_DokUnvan);
            this.groupControl1.Controls.Add(this.maskedTextBox_dipno);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(277, 139);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Doktor Unvanları Bilgileri";
            // 
            // simpleButton_Sil
            // 
            this.simpleButton_Sil.Location = new System.Drawing.Point(176, 108);
            this.simpleButton_Sil.Name = "simpleButton_Sil";
            this.simpleButton_Sil.Size = new System.Drawing.Size(60, 23);
            this.simpleButton_Sil.TabIndex = 5;
            this.simpleButton_Sil.Text = "Sil";
            this.simpleButton_Sil.Click += new System.EventHandler(this.simpleButton_Sil_Click);
            // 
            // simpleButton_Guncelle
            // 
            this.simpleButton_Guncelle.Location = new System.Drawing.Point(110, 108);
            this.simpleButton_Guncelle.Name = "simpleButton_Guncelle";
            this.simpleButton_Guncelle.Size = new System.Drawing.Size(60, 23);
            this.simpleButton_Guncelle.TabIndex = 4;
            this.simpleButton_Guncelle.Text = "Guncelle";
            this.simpleButton_Guncelle.Click += new System.EventHandler(this.simpleButton_Guncelle_Click);
            // 
            // comboBox_Bransadi
            // 
            this.comboBox_Bransadi.FormattingEnabled = true;
            this.comboBox_Bransadi.Location = new System.Drawing.Point(125, 53);
            this.comboBox_Bransadi.Name = "comboBox_Bransadi";
            this.comboBox_Bransadi.Size = new System.Drawing.Size(111, 21);
            this.comboBox_Bransadi.TabIndex = 1;
            // 
            // simpleButton_kaydet
            // 
            this.simpleButton_kaydet.Location = new System.Drawing.Point(176, 108);
            this.simpleButton_kaydet.Name = "simpleButton_kaydet";
            this.simpleButton_kaydet.Size = new System.Drawing.Size(60, 23);
            this.simpleButton_kaydet.TabIndex = 2;
            this.simpleButton_kaydet.Text = "Kaydet";
            this.simpleButton_kaydet.Click += new System.EventHandler(this.simpleButton_kaydet_Click);
            // 
            // maskedTextBox_dipno
            // 
            this.maskedTextBox_dipno.Location = new System.Drawing.Point(124, 81);
            this.maskedTextBox_dipno.Mask = "0000000000";
            this.maskedTextBox_dipno.Name = "maskedTextBox_dipno";
            this.maskedTextBox_dipno.Size = new System.Drawing.Size(112, 21);
            this.maskedTextBox_dipno.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Dip. Numarası :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(82, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Branş :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(60, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Unvan Adı :";
            // 
            // FrmDokUnvKayitGuncelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 139);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDokUnvKayitGuncelSil";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DokUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit textEdit_DokUnvan;
        public System.Windows.Forms.MaskedTextBox maskedTextBox_dipno;
        public System.Windows.Forms.ComboBox comboBox_Bransadi;
        public DevExpress.XtraEditors.SimpleButton simpleButton_Sil;
        public DevExpress.XtraEditors.SimpleButton simpleButton_Guncelle;
        public DevExpress.XtraEditors.SimpleButton simpleButton_kaydet;
    }
}