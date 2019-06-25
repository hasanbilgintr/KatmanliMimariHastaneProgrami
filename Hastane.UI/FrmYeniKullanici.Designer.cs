namespace Hastane.UI
{
    partial class FrmYeniKullanici
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
            this.textEdit_kul = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_sifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_tc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_kul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_tc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit_kul
            // 
            this.textEdit_kul.Location = new System.Drawing.Point(112, 53);
            this.textEdit_kul.Name = "textEdit_kul";
            this.textEdit_kul.Size = new System.Drawing.Size(100, 20);
            this.textEdit_kul.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(49, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Kullanıcı Adı :";
            // 
            // textEdit_sifre
            // 
            this.textEdit_sifre.Location = new System.Drawing.Point(112, 85);
            this.textEdit_sifre.Name = "textEdit_sifre";
            this.textEdit_sifre.Size = new System.Drawing.Size(100, 20);
            this.textEdit_sifre.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kullanıcı Şifresi :";
            // 
            // textEdit_tc
            // 
            this.textEdit_tc.Location = new System.Drawing.Point(112, 21);
            this.textEdit_tc.Name = "textEdit_tc";
            this.textEdit_tc.Size = new System.Drawing.Size(100, 20);
            this.textEdit_tc.TabIndex = 0;
            this.textEdit_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit_tc_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(53, 25);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Kullanıcı Tc :";
            // 
            // simpleButton_Kaydet
            // 
            this.simpleButton_Kaydet.Location = new System.Drawing.Point(89, 124);
            this.simpleButton_Kaydet.Name = "simpleButton_Kaydet";
            this.simpleButton_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_Kaydet.TabIndex = 3;
            this.simpleButton_Kaydet.Text = "Kaydet";
            this.simpleButton_Kaydet.Click += new System.EventHandler(this.simpleButton_Kaydet_Click);
            // 
            // FrmYeniKullanici
            // 
            this.AcceptButton = this.simpleButton_Kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(248, 149);
            this.Controls.Add(this.simpleButton_Kaydet);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit_sifre);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit_tc);
            this.Controls.Add(this.textEdit_kul);
            this.Name = "FrmYeniKullanici";
            this.Text = "Yeni Kullanıcı";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_kul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_tc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit_kul;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_sifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_tc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Kaydet;
    }
}