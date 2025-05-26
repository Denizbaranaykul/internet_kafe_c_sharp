using System.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MySql.Data.MySqlClient;

namespace internet_kafe
{
    public partial class giris : Form
    {
        public static int sifre = 12345;
        public giris()
        {
            InitializeComponent();
        }
      public static MySqlConnection baglantii = new MySqlConnection("Server=localhost;Database=internet_kafe;Uid=root;Pwd=12345");
        public static class baglanti
        {

            public static MySqlConnection Conn { get; set; }

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            if (lbl_sifre.Visible == false)
            {
                lbl_sifre.Visible = true;
                txt_sifre.Visible = true;
            }
            else if(Convert.ToInt32(txt_sifre.Text)==12345)
            {
                yonetici yonetici = new yonetici();
                yonetici.Show();
            }
            else
            {
                MessageBox.Show("þifre yanlýþ");
            }
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            masalar musteri = new masalar();
            musteri.Show();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            baglanti.Conn = baglantii;
        }
    }
}
