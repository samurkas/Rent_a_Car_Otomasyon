using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Samur_Rent_a_Car
{
    public partial class kayıt_ol : Form
    {
        public kayıt_ol()
        {
            InitializeComponent();
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tc.Text) || 
                string.IsNullOrWhiteSpace(textBox2.Text) || 
                string.IsNullOrWhiteSpace(textBox3.Text) || 
                string.IsNullOrWhiteSpace(txt_kullaniciadi.Text) || 
                string.IsNullOrWhiteSpace(txt_parola.Text))
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurunuz (TC, Ad, Soyad, Kullanıcı Adı, Parola).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SQLiteConnection conn = VeriTabani.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO Kullaniciler (Tc_Kimlik, Ad, Soyad, Kullanici_Adi, Parola, Cinsiyet, Tel, Mail, Kayit_Tarihi) 
                               VALUES (@tc, @ad, @soyad, @kadi, @parola, @cinsiyet, @tel, @mail, @tarih)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tc", txt_tc.Text);
                    cmd.Parameters.AddWithValue("@ad", textBox2.Text);
                    cmd.Parameters.AddWithValue("@soyad", textBox3.Text);
                    cmd.Parameters.AddWithValue("@kadi", txt_kullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@parola", txt_parola.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", cmb_cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@tel", txt_telefon.Text);
                    cmd.Parameters.AddWithValue("@mail", textBox4.Text);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Kayıt başarıyla oluşturuldu.");
            this.Close();
        }

        private void txt_kullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
