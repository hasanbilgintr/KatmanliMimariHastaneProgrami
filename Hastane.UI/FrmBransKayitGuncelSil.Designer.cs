namespace Hastane.UI
{
    partial class FrmBransKayitGuncelSil
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
            this.textEdit_Brans = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Brans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEdit_Brans
            // 
            this.textEdit_Brans.Location = new System.Drawing.Point(103, 24);
            this.textEdit_Brans.Name = "textEdit_Brans";
            this.textEdit_Brans.Size = new System.Drawing.Size(112, 20);
            this.textEdit_Brans.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton_Guncelle);
            this.groupControl1.Controls.Add(this.simpleButton_Sil);
            this.groupControl1.Controls.Add(this.simpleButton_kaydet);
            this.groupControl1.Controls.Add(this.textEdit_Brans);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(272, 84);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Doktor Branş Bilgileri";
            // 
            // simpleButton_Guncelle
            // 
            this.simpleButton_Guncelle.Location = new System.Drawing.Point(100, 49);
            this.simpleButton_Guncelle.Name = "simpleButton_Guncelle";
            this.simpleButton_Guncelle.Size = new System.Drawing.Size(55, 23);
            this.simpleButton_Guncelle.TabIndex = 3;
            this.simpleButton_Guncelle.Text = "Güncelle";
            this.simpleButton_Guncelle.Click += new System.EventHandler(this.simpleButton_Guncelle_Click);
            // 
            // simpleButton_Sil
            // 
            this.simpleButton_Sil.Location = new System.Drawing.Point(160, 49);
            this.simpleButton_Sil.Name = "simpleButton_Sil";
            this.simpleButton_Sil.Size = new System.Drawing.Size(55, 23);
            this.simpleButton_Sil.TabIndex = 3;
            this.simpleButton_Sil.Text = "Sil";
            this.simpleButton_Sil.Click += new System.EventHandler(this.simpleButton_Sil_Click);
            // 
            // simpleButton_kaydet
            // 
            this.simpleButton_kaydet.Location = new System.Drawing.Point(160, 49);
            this.simpleButton_kaydet.Name = "simpleButton_kaydet";
            this.simpleButton_kaydet.Size = new System.Drawing.Size(55, 23);
            this.simpleButton_kaydet.TabIndex = 5;
            this.simpleButton_kaydet.Text = "Kaydet";
            this.simpleButton_kaydet.Click += new System.EventHandler(this.simpleButton_kaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Branş Adı :";
            // 
            // FrmBransKayitGuncelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 84);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmBransKayitGuncelSil";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Brans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit textEdit_Brans;
        public DevExpress.XtraEditors.SimpleButton simpleButton_kaydet;
        public DevExpress.XtraEditors.SimpleButton simpleButton_Guncelle;
        public DevExpress.XtraEditors.SimpleButton simpleButton_Sil;
    }
}