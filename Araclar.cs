using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Samur_Rent_a_Car
{
    public partial class Araclar : Form
    {
        public Araclar()
        {
            InitializeComponent();
            this.Load += Araclar_Load;
        }

        private void Araclar_Load(object sender, EventArgs e)
        {
            VeriTabani.EnsureTableExists();
            Listele();
            
            cmb_arac_cesidi.SelectedIndexChanged += cmb_arac_cesidi_SelectedIndexChanged;
            btn_kadet.Click += btn_kadet_Click;
            btn_guncelle.Click += btn_guncelle_Click;
            btn_iptal.Click += btn_iptal_Click;
            btn_yeni_kayit.Click += btn_yeni_kayit_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Listele()
        {
            DataTable dt = new DataTable();
            using (var conn = VeriTabani.GetConnection())
            {
                conn.Open();
                using (var da = new SQLiteDataAdapter("SELECT * FROM Kiralama", conn))
                {
                    da.Fill(dt);
                }
            }
            dataGridView1.DataSource = dt.Copy();
        }

        private string GetResimPath(string imageName)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = Directory.GetParent(baseDir).Parent.FullName;
            string path = Path.Combine(projectDir, "RESİMLER", imageName);
            
            if (File.Exists(path))
            {
                return path;
            }
            return null;
        }

        private void cmb_arac_cesidi_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void UpdateImage()
        {
            string imageName = null;
            
            string secilenArac = cmb_arac_cesidi.Text.ToLower();
            
            if (secilenArac.Contains("otomobil"))
            {
                imageName = "otomobil.png";
            }
            else if (secilenArac.Contains("motosiklet"))
            {
                imageName = "motosiklet.jpg";
            }
            else if (secilenArac.Contains("bisiklet"))
            {
                imageName = "bisiklet.jpg";
            }
            else if (secilenArac.Contains("kamyon"))
            {
                imageName = "kamyon.jpg";
            }

            if (!string.IsNullOrEmpty(imageName))
            {
                string fullPath = GetResimPath(imageName);
                if (fullPath != null)
                {
                    pictureBox8.ImageLocation = fullPath;
                    pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox8.ImageLocation = null;
                    pictureBox8.Image = Properties.Resources.LOGO1;
                }
            }
            else
            {
                pictureBox8.ImageLocation = null;
                pictureBox8.Image = Properties.Resources.LOGO;
            }
        }

        private void btn_kadet_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Kiralama (Tc_Kimlik, Ad, Soyad, Kullanici_Adi, Plaka, Arac_Cesidi, Tel, Ucret, Alis_Tarihi, Teslim_Tarihi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)";
            ExecuteQuery(sql);
            Listele();
            Temizle();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["Id"].Value == null) return;
            string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

            string sql = "UPDATE Kiralama SET Tc_Kimlik=@p1, Ad=@p2, Soyad=@p3, Kullanici_Adi=@p4, Plaka=@p5, Arac_Cesidi=@p6, Tel=@p7, Ucret=@p8, Alis_Tarihi=@p9, Teslim_Tarihi=@p10 WHERE Id=" + id;
            ExecuteQuery(sql);
            Listele();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["Id"].Value == null) return;
            string id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

            if (MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.DataSource = null;
                    
                using (var conn = VeriTabani.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM Kiralama WHERE Id=@id";
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                Listele();
                Temizle();
                MessageBox.Show("Kayıt Silindi");
            }
        }

        private void btn_yeni_kayit_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txt_kullaniciadi.Text = "";
            txt_parola.Text = "";
            cmb_arac_cesidi.SelectedIndex = -1;
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            date_kayittarihi.Value = DateTime.Now;
        }

        private void ExecuteQuery(string sql)
        {
            using (var conn = VeriTabani.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@p3", textBox3.Text);
                    cmd.Parameters.AddWithValue("@p4", txt_kullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@p5", txt_parola.Text);
                    cmd.Parameters.AddWithValue("@p6", cmb_arac_cesidi.Text);
                    cmd.Parameters.AddWithValue("@p7", textBox4.Text);
                    cmd.Parameters.AddWithValue("@p8", textBox5.Text);
                    cmd.Parameters.AddWithValue("@p9", dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm"));
                    cmd.Parameters.AddWithValue("@p10", date_kayittarihi.Value.ToString("yyyy-MM-dd HH:mm"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Tc_Kimlik"].Value.ToString();
                textBox2.Text = row.Cells["Ad"].Value.ToString();
                textBox3.Text = row.Cells["Soyad"].Value.ToString();
                txt_kullaniciadi.Text = row.Cells["Kullanici_Adi"].Value.ToString();
                txt_parola.Text = row.Cells["Plaka"].Value.ToString();
                cmb_arac_cesidi.Text = row.Cells["Arac_Cesidi"].Value.ToString();
                textBox4.Text = row.Cells["Tel"].Value.ToString();
                textBox5.Text = row.Cells["Ucret"].Value.ToString();
                
                if(DateTime.TryParse(row.Cells["Alis_Tarihi"].Value.ToString(), out DateTime alis))
                    dateTimePicker1.Value = alis;
                
                if (DateTime.TryParse(row.Cells["Teslim_Tarihi"].Value.ToString(), out DateTime teslim))
                    date_kayittarihi.Value = teslim;
                
                UpdateImage();
            }
        }
        
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
