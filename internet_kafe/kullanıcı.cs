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
        public static int ucret = 50;
        public static int saatlik = 1;
        public static int SepetTutar = 0;
        public kullanıcı()
        {
            InitializeComponent();
            timer1.Interval = 10000;
            lbl_masa_no.Text += masalar.masa_no;
            ucret = ucret + (saatlik * masalar.dakika);
            lbl_ucret.Text += ucret + " TL";
            lbl_sure.Text += masalar.dakika + " Dk";
            timer1.Start();
            tagler();
        }
        private void tagler()
        {
            pictureBox_çay.Tag = "çay";
            pictureBox_nescafe.Tag = "nescafe";
            pictureBox_ıhlamur.Tag = "ıhlamur";

            pictureBox_çay.Click += Urun_Click;
            pictureBox_nescafe.Click += Urun_Click;
            pictureBox_ıhlamur.Click += Urun_Click;
        }
        private void btn_yorum_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != null)
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
            if (richTextBox2.Text != null)
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
            MySqlCommand cmd = new MySqlCommand(sql, giris.baglanti.Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@gonderen", "admin");
            cmd.Parameters.AddWithValue("@no", masalar.masa_no);
            cmd.ExecuteNonQuery();
            giris.baglanti.Conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_sure.Text = "masada geçirilen süre : ";
            lbl_sure.Text += masalar.dakika + " Dk";
            ucret = ucret + (saatlik * masalar.dakika);
            lbl_ucret.Text= "toplam ücret: ";
            lbl_ucret.Text += ucret + " TL";
        }


        Dictionary<string, int> urunFiyatlari = new Dictionary<string, int>()
        {
        { "çay", 20 },
        { "nescafe", 20 },
        { "ıhlamur", 20 }
        };

        private void Urun_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            string urunAdi = pb.Tag.ToString();

            if (urunFiyatlari.ContainsKey(urunAdi))
            {
                checkedListBox1.Items.Add($"{urunAdi} - {urunFiyatlari[urunAdi]} TL");
                SepetTutar += urunFiyatlari[urunAdi];
                lbl_sepet.Text = SepetTutar + " TL";
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
            {
                string secilen = checkedListBox1.CheckedItems[i].ToString();
                string[] parcalar = secilen.Split('-');
                string urunAdi = parcalar[0].Trim();
                int fiyat = int.Parse(parcalar[1].Replace("TL", "").Trim());

                checkedListBox1.Items.Remove(secilen);
                SepetTutar -= fiyat;
            }

            lbl_sepet.Text = SepetTutar + " TL";
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count == 0)
            {
                MessageBox.Show("Sepet boş!");
                return;
            }
            MySqlConnection conn = giris.baglanti.Conn;
            conn.Open();

            foreach (var item in checkedListBox1.Items)
            {
                    string[] parcalar = item.ToString().Split('-');
                    string urunAdi = parcalar[0].Trim();
                    int fiyat = int.Parse(parcalar[1].Replace("TL", "").Trim());

                    string query = "INSERT INTO siparisler (masa_no, urun_adi, fiyat, tarih) VALUES (@masa_no, @urun, @fiyat, @tarih)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@masa_no", masalar.masa_no);
                    cmd.Parameters.AddWithValue("@urun", urunAdi);
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now);

                    cmd.ExecuteNonQuery();
            }

            conn.Close();

            MessageBox.Show("Siparişiniz alındı.\nToplam Tutar: " + SepetTutar + " TL");
            checkedListBox1.Items.Clear();
            ucret += SepetTutar;
            lbl_ucret.Text = "toplam ücret: ";
            lbl_ucret.Text += ucret + " TL";
            SepetTutar = 0;
            lbl_sepet.Text = "0 TL";
        }
    }
}
