using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Samur_Rent_a_Car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = global::Samur_Rent_a_Car.Properties.Resources.LOGO;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Visible = true;
            pictureBox1.BringToFront();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string parola = textBox2.Text;

            if (string.IsNullOrWhiteSpace(kadi) || string.IsNullOrWhiteSpace(parola))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve parola giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = VeriTabani.GetConnection())
            {
                conn.Open();
                string sql = "SELECT Id, Kullanici_Adi, Admin FROM Kullaniciler WHERE Kullanici_Adi=@p1 AND Parola=@p2";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", kadi);
                    cmd.Parameters.AddWithValue("@p2", parola);
                        
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserSession.UserId = Convert.ToInt32(reader["Id"]);
                            UserSession.KullaniciAdi = reader["Kullanici_Adi"].ToString();
                            UserSession.IsAdmin = reader["Admin"] != DBNull.Value && Convert.ToInt32(reader["Admin"]) == 1;
                                
                            AnaForm anaForm = new AnaForm();
                            this.Hide();
                            anaForm.ShowDialog();
                            this.Show(); 
                                
                            UserSession.Clear();
                            textBox1.Clear();
                            textBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya parola hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayıt_ol kayitOlFormu = new kayıt_ol();
            kayitOlFormu.ShowDialog();
        }
    }
}
