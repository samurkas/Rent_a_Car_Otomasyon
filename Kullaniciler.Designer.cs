namespace Samur_Rent_a_Car
{
    partial class Kullaniciler
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
            this.lbl_tc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_yas = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_numara = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_acıklama = new System.Windows.Forms.Label();
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.lbl_parola = new System.Windows.Forms.Label();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.lbl_kayittarihi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.date_kayittarihi = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_yenikayıt = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_arama = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.ForeColor = System.Drawing.Color.White;
            this.lbl_tc.Location = new System.Drawing.Point(5, 30);
            this.lbl_tc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(98, 20);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "Tc Kimlik No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAdmin);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.lbl_yas);
            this.groupBox1.Controls.Add(this.lbl_ad);
            this.groupBox1.Controls.Add(this.lbl_soyad);
            this.groupBox1.Controls.Add(this.lbl_numara);
            this.groupBox1.Controls.Add(this.lbl_mail);
            this.groupBox1.Controls.Add(this.lbl_acıklama);
            this.groupBox1.Controls.Add(this.lbl_kullaniciadi);
            this.groupBox1.Controls.Add(this.lbl_parola);
            this.groupBox1.Controls.Add(this.lbl_cinsiyet);
            this.groupBox1.Controls.Add(this.lbl_kayittarihi);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.txt_kullaniciadi);
            this.groupBox1.Controls.Add(this.txt_parola);
            this.groupBox1.Controls.Add(this.cmb_cinsiyet);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.date_kayittarihi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(539, 369);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_yas
            // 
            this.lbl_yas.AutoSize = true;
            this.lbl_yas.ForeColor = System.Drawing.Color.White;
            this.lbl_yas.Location = new System.Drawing.Point(256, 28);
            this.lbl_yas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_yas.Name = "lbl_yas";
            this.lbl_yas.Size = new System.Drawing.Size(107, 20);
            this.lbl_yas.TabIndex = 0;
            this.lbl_yas.Text = "Doğum Tarihi:";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.ForeColor = System.Drawing.Color.White;
            this.lbl_ad.Location = new System.Drawing.Point(62, 63);
            this.lbl_ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(40, 20);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Adı :";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.ForeColor = System.Drawing.Color.White;
            this.lbl_soyad.Location = new System.Drawing.Point(45, 100);
            this.lbl_soyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(58, 20);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // lbl_numara
            // 
            this.lbl_numara.AutoSize = true;
            this.lbl_numara.ForeColor = System.Drawing.Color.White;
            this.lbl_numara.Location = new System.Drawing.Point(30, 246);
            this.lbl_numara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_numara.Name = "lbl_numara";
            this.lbl_numara.Size = new System.Drawing.Size(70, 20);
            this.lbl_numara.TabIndex = 0;
            this.lbl_numara.Text = "Telefon :";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.ForeColor = System.Drawing.Color.White;
            this.lbl_mail.Location = new System.Drawing.Point(18, 283);
            this.lbl_mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(87, 20);
            this.lbl_mail.TabIndex = 0;
            this.lbl_mail.Text = "Mail Adres:";
            // 
            // lbl_acıklama
            // 
            this.lbl_acıklama.AutoSize = true;
            this.lbl_acıklama.ForeColor = System.Drawing.Color.White;
            this.lbl_acıklama.Location = new System.Drawing.Point(256, 102);
            this.lbl_acıklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_acıklama.Name = "lbl_acıklama";
            this.lbl_acıklama.Size = new System.Drawing.Size(77, 20);
            this.lbl_acıklama.TabIndex = 0;
            this.lbl_acıklama.Text = "Açıklama:";
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.ForeColor = System.Drawing.Color.White;
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(8, 136);
            this.lbl_kullaniciadi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(97, 20);
            this.lbl_kullaniciadi.TabIndex = 0;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // lbl_parola
            // 
            this.lbl_parola.AutoSize = true;
            this.lbl_parola.ForeColor = System.Drawing.Color.White;
            this.lbl_parola.Location = new System.Drawing.Point(45, 173);
            this.lbl_parola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_parola.Name = "lbl_parola";
            this.lbl_parola.Size = new System.Drawing.Size(58, 20);
            this.lbl_parola.TabIndex = 0;
            this.lbl_parola.Text = "Parola:";
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.ForeColor = System.Drawing.Color.White;
            this.lbl_cinsiyet.Location = new System.Drawing.Point(30, 210);
            this.lbl_cinsiyet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(71, 20);
            this.lbl_cinsiyet.TabIndex = 0;
            this.lbl_cinsiyet.Text = "Cinsiyeti:";
            // 
            // lbl_kayittarihi
            // 
            this.lbl_kayittarihi.AutoSize = true;
            this.lbl_kayittarihi.ForeColor = System.Drawing.Color.White;
            this.lbl_kayittarihi.Location = new System.Drawing.Point(256, 63);
            this.lbl_kayittarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kayittarihi.Name = "lbl_kayittarihi";
            this.lbl_kayittarihi.Size = new System.Drawing.Size(89, 20);
            this.lbl_kayittarihi.TabIndex = 0;
            this.lbl_kayittarihi.Text = "Kayıt Tarihi:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 63);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 100);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 26);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 246);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 26);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(106, 283);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(142, 26);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(260, 126);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(215, 182);
            this.textBox6.TabIndex = 11;
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(106, 136);
            this.txt_kullaniciadi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(142, 26);
            this.txt_kullaniciadi.TabIndex = 4;
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(106, 173);
            this.txt_parola.Margin = new System.Windows.Forms.Padding(2);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(142, 26);
            this.txt_parola.TabIndex = 5;
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(106, 210);
            this.cmb_cinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(142, 28);
            this.cmb_cinsiyet.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 28);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // date_kayittarihi
            // 
            this.date_kayittarihi.Location = new System.Drawing.Point(362, 62);
            this.date_kayittarihi.Margin = new System.Windows.Forms.Padding(2);
            this.date_kayittarihi.Name = "date_kayittarihi";
            this.date_kayittarihi.Size = new System.Drawing.Size(142, 26);
            this.date_kayittarihi.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 420);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(719, 145);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_yenikayıt
            // 
            this.btn_yenikayıt.BackColor = System.Drawing.Color.Lime;
            this.btn_yenikayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yenikayıt.ForeColor = System.Drawing.Color.Transparent;
            this.btn_yenikayıt.Location = new System.Drawing.Point(576, 20);
            this.btn_yenikayıt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_yenikayıt.Name = "btn_yenikayıt";
            this.btn_yenikayıt.Size = new System.Drawing.Size(145, 54);
            this.btn_yenikayıt.TabIndex = 3;
            this.btn_yenikayıt.Text = "Yeni Kayıt ";
            this.btn_yenikayıt.UseVisualStyleBackColor = false;
            this.btn_yenikayıt.Click += new System.EventHandler(this.btn_yenikayıt_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Yellow;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.Black;
            this.btn_guncelle.Location = new System.Drawing.Point(576, 95);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(145, 54);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click_1);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sil.Location = new System.Drawing.Point(576, 168);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(145, 54);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click_1);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_temizle.ForeColor = System.Drawing.Color.Transparent;
            this.btn_temizle.Location = new System.Drawing.Point(576, 241);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(145, 54);
            this.btn_temizle.TabIndex = 3;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click_1);
            // 
            // btn_arama
            // 
            this.btn_arama.BackColor = System.Drawing.Color.Blue;
            this.btn_arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_arama.ForeColor = System.Drawing.Color.Transparent;
            this.btn_arama.Location = new System.Drawing.Point(576, 319);
            this.btn_arama.Margin = new System.Windows.Forms.Padding(2);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(145, 54);
            this.btn_arama.TabIndex = 3;
            this.btn_arama.Text = "Arama";
            this.btn_arama.UseVisualStyleBackColor = false;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click_1);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.Red;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.White;
            this.btnGeriDon.Location = new System.Drawing.Point(-3, 3);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(216, 30);
            this.btnGeriDon.TabIndex = 12;
            this.btnGeriDon.Text = "← Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdmin.ForeColor = System.Drawing.Color.Red;
            this.chkAdmin.Location = new System.Drawing.Point(404, 330);
            this.chkAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(118, 21);
            this.chkAdmin.TabIndex = 13;
            this.chkAdmin.Text = "Yönetici Yap";
            this.chkAdmin.UseVisualStyleBackColor = true;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.chkAdmin_CheckedChanged);
            // 
            // Kullaniciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(736, 612);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_yenikayıt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Kullaniciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullaniciler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

                    }

                    #endregion

        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_yas;
        private System.Windows.Forms.Label lbl_acıklama;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_numara;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_yenikayıt;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.Label lbl_parola;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.Label lbl_kayittarihi;
        private System.Windows.Forms.DateTimePicker date_kayittarihi;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.CheckBox chkAdmin;
    }
}