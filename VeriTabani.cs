using System;
using System.Data.SQLite;
using System.IO;

namespace Samur_Rent_a_Car
{
    public static class UserSession
    {
        public static string KullaniciAdi { get; set; }
        public static bool IsAdmin { get; set; }
        public static int UserId { get; set; }
        
        public static void Clear()
        {
            KullaniciAdi = null;
            IsAdmin = false;
            UserId = 0;
        }
    }

    public class VeriTabani
    {
        private static string dbFileName = "SamurRentACar.db";
        private static string connectionString = $"Data Source={dbFileName};Version=3;Journal Mode=WAL;Busy Timeout=5000;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void EnsureTableExists()
        {
            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
            }

            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS Kullaniciler (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Tc_Kimlik TEXT,
                        Ad TEXT,
                        Soyad TEXT,
                        Kullanici_Adi TEXT,
                        Parola TEXT,
                        Cinsiyet TEXT,
                        Tel TEXT,
                        Mail TEXT,
                        Dogum_Tarihi TEXT,
                        Kayit_Tarihi TEXT,
                        Aciklama TEXT,
                        Admin INTEGER DEFAULT 0
                    )";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                bool adminExists = false;
                using (var cmd = new SQLiteCommand("PRAGMA table_info(Kullaniciler)", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["name"].ToString() == "Admin")
                            {
                                adminExists = true;
                                break;
                            }
                        }
                    }
                }

                if (!adminExists)
                {
                    using (var cmd = new SQLiteCommand("ALTER TABLE Kullaniciler ADD COLUMN Admin INTEGER DEFAULT 0", conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                string sqlKiralama = @"
                    CREATE TABLE IF NOT EXISTS Kiralama (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Tc_Kimlik TEXT,
                        Ad TEXT,
                        Soyad TEXT,
                        Kullanici_Adi TEXT,
                        Plaka TEXT,
                        Arac_Cesidi TEXT,
                        Tel TEXT,
                        Ucret TEXT,
                        Alis_Tarihi TEXT,
                        Teslim_Tarihi TEXT
                    )";
                using (var cmd = new SQLiteCommand(sqlKiralama, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                
                CreateDefaultAdmin(conn);
            }
        }
        
        private static void CreateDefaultAdmin(SQLiteConnection conn)
        {
            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Kullaniciler WHERE Admin = 1", conn))
            {
                long adminCount = (long)cmd.ExecuteScalar();
                    
                if (adminCount == 0)
                {
                    string insertSql = @"INSERT INTO Kullaniciler 
                        (Tc_Kimlik, Ad, Soyad, Kullanici_Adi, Parola, Cinsiyet, Tel, Mail, Dogum_Tarihi, Kayit_Tarihi, Aciklama, Admin) 
                        VALUES (@tc, @ad, @soyad, @kadi, @parola, @cinsiyet, @tel, @mail, @dogum, @kayit, @aciklama, @admin)";
                        
                    using (var insertCmd = new SQLiteCommand(insertSql, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@tc", "12218838160");
                        insertCmd.Parameters.AddWithValue("@ad", "İsmail");
                        insertCmd.Parameters.AddWithValue("@soyad", "SAMURKAS");
                        insertCmd.Parameters.AddWithValue("@kadi", "admin");
                        insertCmd.Parameters.AddWithValue("@parola", "123");
                        insertCmd.Parameters.AddWithValue("@cinsiyet", "Erkek");
                        insertCmd.Parameters.AddWithValue("@tel", "5555555555");
                        insertCmd.Parameters.AddWithValue("@mail", "ismail@samurrentacar.com");
                        insertCmd.Parameters.AddWithValue("@dogum", "2001-10-19");
                        insertCmd.Parameters.AddWithValue("@kayit", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        insertCmd.Parameters.AddWithValue("@aciklama", "Yönetici Hesabı");
                        insertCmd.Parameters.AddWithValue("@admin", 1);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
