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

namespace internet_kafe
{
    public partial class kullanıcı : Form
    {
        public kullanıcı()
        {
            InitializeComponent();
        }

        private void btn_yorum_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text!=null)
            {
                int secilenDeger = 1;

                if (radioButton1.Checked) secilenDeger = 1;
                else if (radioButton2.Checked) secilenDeger = 2;
                else if (radioButton3.Checked) secilenDeger = 3;
                else if (radioButton4.Checked) secilenDeger = 4;
                else if (radioButton5.Checked) secilenDeger = 5;
                string sql = "INSERT INTO yorumlar(yorum,masa_no,yildiz) VALUES(@yorum,@no,@yildiz)";
                giris.baglanti.Conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, giris.baglanti.Conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@yorum", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@no", masalar.masa_no);
                cmd.Parameters.AddWithValue("yildiz", secilenDeger);
                cmd.ExecuteNonQuery();
                MessageBox.Show("yorumunuz başarı ile gönderildi.");
                giris.baglanti.Conn.Close();
                richTextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Yorum kutusu boş olamaz");
            }

        }

        private void btn_mesaj_Click(object sender, EventArgs e)
        {
            if(richTextBox2.Text !=null)
            {
                giris.baglanti.Conn.Open();
                string sql = "INSERT INTO mesajlar(masa_no,mesaj_metni) VALUES(@no,@mesaj)";
                MySqlCommand cmd = new MySqlCommand(sql, giris.baglanti.Conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@no", masalar.masa_no);
                cmd.Parameters.AddWithValue("@mesaj", richTextBox2.Text);
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

        private void btn_yenile_mesaj_Click(object sender, EventArgs e)
        {
            giris.baglanti.Conn.Open();
            string sql = "SELECT mesaj_metni,tarih FROM mesajlar WHERE gonderen=@gonderen AND masa_no=@no";
            MySqlCommand cmd = new MySqlCommand(sql,giris.baglanti.Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@gonderen","admin");
            cmd.Parameters.AddWithValue("@no",masalar.masa_no);
            cmd.ExecuteNonQuery();
            giris.baglanti.Conn.Close();
        }
    }
}
