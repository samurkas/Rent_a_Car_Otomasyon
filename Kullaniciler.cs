using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Samur_Rent_a_Car
{
    public partial class Kullaniciler : Form
    {
        int selectedId = 0;

        public Kullaniciler()
        {
            InitializeComponent();
            VeriTabani.EnsureTableExists();
            dataGridView1.CellClick += DataGridView1_CellClick;
            Listele();
        }

        private void Kullaniciler_Load(object sender, EventArgs e)
        {
            if (!UserSession.IsAdmin)
            {
                chkAdmin.Enabled = false;
            }
        }

        private void Listele()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = VeriTabani.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Kullaniciler";
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }
            }
            dataGridView1.DataSource = dt.Copy();
        }

        private void btn_yenikayıt_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = VeriTabani.GetConnection())
            {
                conn.Open();
                string sql = "INSERT INTO Kullaniciler (Tc_Kimlik, Ad, Soyad, Kullanici_Adi, Parola, Cinsiyet, Tel, Mail, Dogum_Tarihi, Kayit_Tarihi, Aciklama, Admin) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@p3", textBox3.Text);
                    cmd.Parameters.AddWithValue("@p4", txt_kullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@p5", txt_parola.Text);
                    cmd.Parameters.AddWithValue("@p6", cmb_cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@p7", textBox4.Text);
                    cmd.Parameters.AddWithValue("@p8", textBox5.Text);
                    cmd.Parameters.AddWithValue("@p9", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p10", date_kayittarihi.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p11", textBox6.Text);
                    cmd.Parameters.AddWithValue("@p12", chkAdmin.Checked ? 1 : 0);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Kayıt Eklendi");
            Listele();
            Temizle();
        }

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kaydı seçin.");
                return;
            }

            using (SQLiteConnection conn = VeriTabani.GetConnection())
            {
                conn.Open();
                string sql = "UPDATE Kullaniciler SET Tc_Kimlik=@p1, Ad=@p2, Soyad=@p3, Kullanici_Adi=@p4, Parola=@p5, Cinsiyet=@p6, Tel=@p7, Mail=@p8, Dogum_Tarihi=@p9, Kayit_Tarihi=@p10, Aciklama=@p11, Admin=@p12 WHERE Id=@id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@p2", textBox2.Text);
                    cmd.Parameters.AddWithValue("@p3", textBox3.Text);
                    cmd.Parameters.AddWithValue("@p4", txt_kullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@p5", txt_parola.Text);
                    cmd.Parameters.AddWithValue("@p6", cmb_cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@p7", textBox4.Text);
                    cmd.Parameters.AddWithValue("@p8", textBox5.Text);
                    cmd.Parameters.AddWithValue("@p9", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p10", date_kayittarihi.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p11", textBox6.Text);
                    cmd.Parameters.AddWithValue("@p12", chkAdmin.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Kayıt Güncellendi");
            Listele();
            Temizle();
        }

        private void btn_sil_Click_1(object sender, EventArgs e)
        {
            int idToDelete = 0;
            
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["Id"].Value != null)
            {
                idToDelete = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            }
            else if (selectedId > 0)
            {
                idToDelete = selectedId;
            }
            
            if (idToDelete == 0)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçin.");
                return;
            }

            if (MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.DataSource = null;
                    
                using (SQLiteConnection conn = VeriTabani.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM Kullaniciler WHERE Id=@id";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idToDelete);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Kayıt Silindi");
                Listele();
                Temizle();
            }
        }

        private void btn_temizle_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            txt_kullaniciadi.Clear();
            txt_parola.Clear();
            cmb_cinsiyet.SelectedIndex = -1;
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dateTimePicker1.Value = DateTime.Now;
            date_kayittarihi.Value = DateTime.Now;
            chkAdmin.Checked = false;
            selectedId = 0;
        }

        private void btn_arama_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = VeriTabani.GetConnection())
            {
                conn.Open();
                string searchSql = "SELECT * FROM Kullaniciler WHERE 1=1";
                if(!string.IsNullOrEmpty(textBox1.Text)) searchSql += " AND Tc_Kimlik LIKE '%" + textBox1.Text + "%'";
                if(!string.IsNullOrEmpty(textBox2.Text)) searchSql += " AND Ad LIKE '%" + textBox2.Text + "%'";
                    
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(searchSql, conn))
                {
                    da.Fill(dt);
                }
            }
            dataGridView1.DataSource = dt.Copy();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    
                if (row.Cells["Id"].Value == null || row.Cells["Id"].Value == DBNull.Value)
                {
                    return;
                }
                    
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                    
                textBox1.Text = row.Cells["Tc_Kimlik"].Value != null ? row.Cells["Tc_Kimlik"].Value.ToString() : "";
                textBox2.Text = row.Cells["Ad"].Value != null ? row.Cells["Ad"].Value.ToString() : "";
                textBox3.Text = row.Cells["Soyad"].Value != null ? row.Cells["Soyad"].Value.ToString() : "";
                txt_kullaniciadi.Text = row.Cells["Kullanici_Adi"].Value != null ? row.Cells["Kullanici_Adi"].Value.ToString() : "";
                txt_parola.Text = row.Cells["Parola"].Value != null ? row.Cells["Parola"].Value.ToString() : "";
                cmb_cinsiyet.Text = row.Cells["Cinsiyet"].Value != null ? row.Cells["Cinsiyet"].Value.ToString() : "";
                textBox4.Text = row.Cells["Tel"].Value != null ? row.Cells["Tel"].Value.ToString() : "";
                textBox5.Text = row.Cells["Mail"].Value != null ? row.Cells["Mail"].Value.ToString() : "";
                    
                DateTime dtBirth, dtReg;
                if(row.Cells["Dogum_Tarihi"].Value != null && 
                    DateTime.TryParse(row.Cells["Dogum_Tarihi"].Value.ToString(), out dtBirth))
                    dateTimePicker1.Value = dtBirth;
                if(row.Cells["Kayit_Tarihi"].Value != null && 
                    DateTime.TryParse(row.Cells["Kayit_Tarihi"].Value.ToString(), out dtReg))
                    date_kayittarihi.Value = dtReg;

                textBox6.Text = row.Cells["Aciklama"].Value != null ? row.Cells["Aciklama"].Value.ToString() : "";
                    
                if (row.Cells["Admin"].Value != null && row.Cells["Admin"].Value != DBNull.Value)
                {
                    chkAdmin.Checked = Convert.ToInt32(row.Cells["Admin"].Value) == 1;
                }
                else
                {
                    chkAdmin.Checked = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}