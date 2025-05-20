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
    public partial class masalar : Form
    {
        public static int sure = 0;
        public static int dakika = 0;
        public static int masa_no;
        public masalar()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            sure++;

            if (sure == 60)
            {
                dakika++;
                sure = 0;
            }
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

            if (dolu == 1)
            {
                giris.baglanti.Conn.Close();
                MessageBox.Show("Bu masa dolu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Masa açma işlemleri burada yapılır
                // Örneğin, veritabanında dolu yap:
                string update = "UPDATE masalar SET dolu = 1 WHERE masa_no = @no";
                MySqlCommand updateCmd = new MySqlCommand(update, giris.baglanti.Conn);
                updateCmd.Parameters.AddWithValue("@no", masaNo);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Masa açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Resmi güncelle:
                pb.Image = Properties.Resources.kırmızı; 
                giris.baglanti.Conn.Close();
                masa_no = masa_no;
                this.Close();
                kullanıcı kullanıcı = new kullanıcı();
                kullanıcı.Show();
            }
        }



        private void masalar_Load(object sender, EventArgs e)
        {
            giris.baglanti.Conn.Open();
            string query = "SELECT * FROM masalar";
            MySqlCommand cmd = new MySqlCommand(query, giris.baglanti.Conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int masaNo = dr.GetInt32("masa_no");
                int dolu = dr.GetInt32("dolu");

                // PictureBox kontrolünü bul
                PictureBox pb = this.Controls.Find("pictureBox" + masaNo, true).FirstOrDefault() as PictureBox;
                if (pb != null)
                {
                    pb.Tag = masaNo; // Hangi masa olduğunu sakla
                    if(dolu==0)
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
    }
}
