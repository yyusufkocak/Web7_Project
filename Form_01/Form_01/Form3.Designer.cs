
namespace Form_01
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayiGir = new System.Windows.Forms.TextBox();
            this.lblRandomSayi = new System.Windows.Forms.Label();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblTahminAciklama = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(267, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSayiGir
            // 
            this.txtSayiGir.Location = new System.Drawing.Point(270, 79);
            this.txtSayiGir.Name = "txtSayiGir";
            this.txtSayiGir.Size = new System.Drawing.Size(115, 20);
            this.txtSayiGir.TabIndex = 1;
            // 
            // lblRandomSayi
            // 
            this.lblRandomSayi.Location = new System.Drawing.Point(77, 51);
            this.lblRandomSayi.Name = "lblRandomSayi";
            this.lblRandomSayi.Size = new System.Drawing.Size(116, 13);
            this.lblRandomSayi.TabIndex = 2;
            this.lblRandomSayi.Text = "Random Sayımız";
            this.lblRandomSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(270, 105);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(96, 33);
            this.btnTahminEt.TabIndex = 3;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(80, 75);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(113, 37);
            this.btnBaslat.TabIndex = 4;
            this.btnBaslat.Text = "Start";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblTahminAciklama
            // 
            this.lblTahminAciklama.AutoSize = true;
            this.lblTahminAciklama.Location = new System.Drawing.Point(412, 82);
            this.lblTahminAciklama.Name = "lblTahminAciklama";
            this.lblTahminAciklama.Size = new System.Drawing.Size(88, 13);
            this.lblTahminAciklama.TabIndex = 5;
            this.lblTahminAciklama.Text = "Tahmin Açıklama";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(536, 27);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(32, 13);
            this.lblPuan.TabIndex = 6;
            this.lblPuan.Text = "Puan";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblTahminAciklama);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.lblRandomSayi);
            this.Controls.Add(this.txtSayiGir);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayiGir;
        private System.Windows.Forms.Label lblRandomSayi;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblTahminAciklama;
        private System.Windows.Forms.Label lblPuan;
    }
}