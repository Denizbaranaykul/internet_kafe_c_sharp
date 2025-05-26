using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace internet_kafe
{
    public partial class yonetici : Form
    {
        public static int gunluk_ciro = 0;
        public static int aylık_ciro = 0;
        public yonetici()
        {
            InitializeComponent();


        }
        private void siparis()
        {
            giris.baglanti.Conn.Open();
            string query = "SELECT  masa_no, urun_adi, tarih FROM siparisler";
            MySqlDataAdapter da = new MySqlDataAdapter(query, giris.baglanti.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView3.DataSource = dt;
            giris.baglanti.Conn.Close();
        }
        private void btn_siparis_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm siparişler silinecek. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection conn = giris.baglanti.Conn;
                    conn.Open();

                    string query = "DELETE FROM siparisler";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int silinen = cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show($"{silinen} kayıt silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    siparis();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }

        private void yonetici_Load(object sender, EventArgs e)
        {
            ciro();
            siparis();
            giris.baglanti.Conn.Open();
            string query = "SELECT * FROM masalar";
            MySqlCommand cmd = new MySqlCommand(query, giris.baglanti.Conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int masaNo = dr.GetInt32("masa_no");
                int dolu = dr.GetInt32("dolu");

               
                PictureBox pb = this.Controls.Find("pictureBox" + masaNo, true).FirstOrDefault() as PictureBox;
                if (pb != null)
                {
                    pb.Tag = masaNo; 
                    if (dolu == 0)
                    {
                        pb.Image = Properties.Resources.yesil;
                    }
                    else
                    {
                        pb.Image = Properties.Resources.kırmızı;
                    }
                    pb.Click += Masa_Click;

                }

            }
            giris.baglanti.Conn.Close();
        }
        private void Masa_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            int masaNo = Convert.ToInt32(pb.Tag);



            giris.baglanti.Conn.Open();
            string query = "SELECT dolu FROM masalar WHERE masa_no = @no";
            MySqlCommand cmd = new MySqlCommand(query, giris.baglanti.Conn);
            cmd.Parameters.AddWithValue("@no", masaNo);
            int dolu = Convert.ToInt32(cmd.ExecuteScalar());

            if (dolu == 0)
            {
                giris.baglanti.Conn.Close();
                MessageBox.Show("Bu masa boş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string update = "UPDATE masalar SET dolu = 0 WHERE masa_no = @no";
                MySqlCommand updateCmd = new MySqlCommand(update, giris.baglanti.Conn);
                updateCmd.Parameters.AddWithValue("@no", masaNo);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Masa kapatıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pb.Image = Properties.Resources.yesil;
                giris.baglanti.Conn.Close();
                lbl_tutar.Text += kullanıcı.ucret + " TL";


            }
        }

        private void btn_mesaj_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text != "boş")
            {
                giris.baglanti.Conn.Open();
                string sql = "INSERT INTO mesajlar(masa_no,mesaj_metni,gonderen) VALUES(@no,@mesaj,@gonderen)";
                MySqlCommand cmd = new MySqlCommand(sql, giris.baglanti.Conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@no", Convert.ToInt32(comboBox1.Text));
                cmd.Parameters.AddWithValue("@mesaj", richTextBox2.Text);
                cmd.Parameters.AddWithValue("@gonderen", "admin");
                cmd.ExecuteNonQuery();
                MessageBox.Show("mesajınız başarı ile iletildi");
                giris.baglanti.Conn.Close();
                richTextBox2.Text = null;
            }
            else
            {
                MessageBox.Show("Mesaj kutusu boş olamaz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM yorumlar";

            giris.baglanti.Conn.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(sql, giris.baglanti.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;

            giris.baglanti.Conn.Close();
        }


        private void btn_yenile_mesaj_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id,masa_no,mesaj_metni,tarih FROM mesajlar WHERE gonderen='masa'";
            giris.baglanti.Conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sql, giris.baglanti.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            giris.baglanti.Conn.Close();
        }

        private void btn_odeme_Click(object sender, EventArgs e)
        {
            giris.baglanti.Conn.Open();
            string sql = "UPDATE ciro SET ciro_gunluk=@gunluk WHERE id= 1 ";
            MySqlCommand cmd = new MySqlCommand(sql, giris.baglanti.Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@gunluk", kullanıcı.ucret);
            cmd.ExecuteNonQuery();
            giris.baglanti.Conn.Close();
            gunluk_ciro += kullanıcı.ucret;
            ciro();
            lbl_tutar.Text = "masanın ödemesi gereken tutar : ";
        }

        private void ciro()
        {
            giris.baglanti.Conn.Open();
            string sql = "SELECT ciro_gunluk, ciro_aylık FROM ciro WHERE id = 1";
            MySqlCommand cmd = new MySqlCommand(sql, giris.baglanti.Conn);


            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                gunluk_ciro = reader.GetInt32("ciro_gunluk");
                aylık_ciro = reader.GetInt32("ciro_aylık");


                lbl_gunluk.Text = "Günlük Ciro: " + gunluk_ciro.ToString();
                lbl_aylık.Text = "Aylık Ciro: " + aylık_ciro.ToString();
            }
            reader.Close();
            giris.baglanti.Conn.Close();

        }

        private void btn_ciro_gunluk_Click(object sender, EventArgs e)
        {
            giris.baglanti.Conn.Open();
            string sql = "UPDATE ciro SET ciro_gunluk=@gunluk ,ciro_aylık=@aylık  WHERE id= 1 ";     
            MySqlCommand cmd = new MySqlCommand(sql, giris.baglanti.Conn);
            cmd.Parameters.Clear();
            aylık_ciro+= gunluk_ciro;
            gunluk_ciro = 0;
            cmd.Parameters.AddWithValue("@gunluk",gunluk_ciro);
            cmd.Parameters.AddWithValue("@aylık", aylık_ciro);
            cmd.ExecuteNonQuery();
            giris.baglanti.Conn.Close();
            ciro();
            
        }
    }
}
