
namespace Form_Kontroller01
{
    partial class Form1
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.textHarf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBHarf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cmbSehirler = new System.Windows.Forms.ComboBox();
            this.btnMesaj = new System.Windows.Forms.Button();
            this.rbEvet = new System.Windows.Forms.RadioButton();
            this.rbHayir = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sadece Sayı Girişi";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(33, 41);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(122, 20);
            this.txtSayi.TabIndex = 1;
            this.txtSayi.TextChanged += new System.EventHandler(this.txtSayi_TextChanged);
            this.txtSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi_KeyPress);
            // 
            // textHarf
            // 
            this.textHarf.Location = new System.Drawing.Point(246, 41);
            this.textHarf.Name = "textHarf";
            this.textHarf.Size = new System.Drawing.Size(122, 20);
            this.textHarf.TabIndex = 4;
            this.textHarf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHarf_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sadece Harf Girişi";
            // 
            // textBHarf
            // 
            this.textBHarf.Location = new System.Drawing.Point(436, 41);
            this.textBHarf.Name = "textBHarf";
            this.textBHarf.Size = new System.Drawing.Size(122, 20);
            this.textBHarf.TabIndex = 6;
            this.textBHarf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBHarf_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(433, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sadece Büyük Harf Girişi";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(33, 100);
            this.maskedTextBox1.Mask = "*****     ";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // cmbSehirler
            // 
            this.cmbSehirler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSehirler.FormattingEnabled = true;
            this.cmbSehirler.Items.AddRange(new object[] {
            "İstanbul",
            "Adana",
            "İzmir",
            "Ankara",
            "Trabzon"});
            this.cmbSehirler.Location = new System.Drawing.Point(436, 100);
            this.cmbSehirler.Name = "cmbSehirler";
            this.cmbSehirler.Size = new System.Drawing.Size(121, 21);
            this.cmbSehirler.TabIndex = 8;
            this.cmbSehirler.SelectedIndexChanged += new System.EventHandler(this.cmbSehirler_SelectedIndexChanged);
            // 
            // btnMesaj
            // 
            this.btnMesaj.Location = new System.Drawing.Point(436, 150);
            this.btnMesaj.Name = "btnMesaj";
            this.btnMesaj.Size = new System.Drawing.Size(132, 28);
            this.btnMesaj.TabIndex = 9;
            this.btnMesaj.Text = "Mesaj";
            this.btnMesaj.UseVisualStyleBackColor = true;
            this.btnMesaj.Click += new System.EventHandler(this.btnMesaj_Click);
            // 
            // rbEvet
            // 
            this.rbEvet.AutoSize = true;
            this.rbEvet.Location = new System.Drawing.Point(473, 221);
            this.rbEvet.Name = "rbEvet";
            this.rbEvet.Size = new System.Drawing.Size(47, 17);
            this.rbEvet.TabIndex = 11;
            this.rbEvet.TabStop = true;
            this.rbEvet.Text = "Evet";
            this.rbEvet.UseVisualStyleBackColor = true;
            this.rbEvet.CheckedChanged += new System.EventHandler(this.rbEvet_CheckedChanged);
            // 
            // rbHayir
            // 
            this.rbHayir.AutoSize = true;
            this.rbHayir.Location = new System.Drawing.Point(473, 262);
            this.rbHayir.Name = "rbHayir";
            this.rbHayir.Size = new System.Drawing.Size(49, 17);
            this.rbHayir.TabIndex = 12;
            this.rbHayir.TabStop = true;
            this.rbHayir.Text = "Hayır";
            this.rbHayir.UseVisualStyleBackColor = true;
            this.rbHayir.CheckedChanged += new System.EventHandler(this.rbHayir_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(449, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bugün Keyfin Yerinde mi?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbErkek);
            this.groupBox1.Controls.Add(this.rdbKadin);
            this.groupBox1.Location = new System.Drawing.Point(188, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 122);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(18, 81);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 1;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Location = new System.Drawing.Point(18, 40);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(52, 17);
            this.rdbKadin.TabIndex = 0;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(225, 262);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(132, 28);
            this.btnTamam.TabIndex = 15;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(12, 308);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(132, 28);
            this.btnForm2.TabIndex = 17;
            this.btnForm2.Text = "Form2\'ye geç";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Ahmet",
            "Mehmet",
            "Selin",
            "Canan",
            "Seda",
            "Filiz"});
            this.listBox1.Location = new System.Drawing.Point(33, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnForm2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbHayir);
            this.Controls.Add(this.rbEvet);
            this.Controls.Add(this.btnMesaj);
            this.Controls.Add(this.cmbSehirler);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBHarf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textHarf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.TextBox textHarf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBHarf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox cmbSehirler;
        private System.Windows.Forms.Button btnMesaj;
        private System.Windows.Forms.RadioButton rbEvet;
        private System.Windows.Forms.RadioButton rbHayir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

