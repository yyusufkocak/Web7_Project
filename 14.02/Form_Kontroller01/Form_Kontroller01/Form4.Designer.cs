
namespace Form_Kontroller01
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.lblSayi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lstKazananlar = new System.Windows.Forms.ListBox();
            this.rdbCift = new System.Windows.Forms.RadioButton();
            this.rdbTek = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblSayi
            // 
            this.lblSayi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSayi.Location = new System.Drawing.Point(34, 29);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(249, 159);
            this.lblSayi.TabIndex = 0;
            this.lblSayi.Text = "10";
            this.lblSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSayi.Click += new System.EventHandler(this.lblSayi_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(39, 211);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "Sonuç";
            // 
            // lstKazananlar
            // 
            this.lstKazananlar.FormattingEnabled = true;
            this.lstKazananlar.Location = new System.Drawing.Point(321, 29);
            this.lstKazananlar.Name = "lstKazananlar";
            this.lstKazananlar.Size = new System.Drawing.Size(101, 160);
            this.lstKazananlar.TabIndex = 2;
            // 
            // rdbCift
            // 
            this.rdbCift.AutoSize = true;
            this.rdbCift.Location = new System.Drawing.Point(326, 214);
            this.rdbCift.Name = "rdbCift";
            this.rdbCift.Size = new System.Drawing.Size(40, 17);
            this.rdbCift.TabIndex = 3;
            this.rdbCift.TabStop = true;
            this.rdbCift.Text = "Çift";
            this.rdbCift.UseVisualStyleBackColor = true;
            this.rdbCift.CheckedChanged += new System.EventHandler(this.rdbCift_CheckedChanged);
            // 
            // rdbTek
            // 
            this.rdbTek.AutoSize = true;
            this.rdbTek.Location = new System.Drawing.Point(326, 248);
            this.rdbTek.Name = "rdbTek";
            this.rdbTek.Size = new System.Drawing.Size(44, 17);
            this.rdbTek.TabIndex = 4;
            this.rdbTek.TabStop = true;
            this.rdbTek.Text = "Tek";
            this.rdbTek.UseVisualStyleBackColor = true;
            this.rdbTek.CheckedChanged += new System.EventHandler(this.rdbTek_CheckedChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 315);
            this.Controls.Add(this.rdbTek);
            this.Controls.Add(this.rdbCift);
            this.Controls.Add(this.lstKazananlar);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSayi);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ListBox lstKazananlar;
        private System.Windows.Forms.RadioButton rdbCift;
        private System.Windows.Forms.RadioButton rdbTek;
    }
}