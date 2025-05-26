namespace internet_kafe
{
    partial class giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_musteri = new Button();
            btn_admin = new Button();
            txt_sifre = new MaskedTextBox();
            lbl_sifre = new Label();
            SuspendLayout();
            // 
            // btn_musteri
            // 
            btn_musteri.Location = new Point(50, 60);
            btn_musteri.Name = "btn_musteri";
            btn_musteri.Size = new Size(162, 68);
            btn_musteri.TabIndex = 0;
            btn_musteri.Text = "müşteri girişi";
            btn_musteri.UseVisualStyleBackColor = true;
            btn_musteri.Click += btn_musteri_Click;
            // 
            // btn_admin
            // 
            btn_admin.Location = new Point(50, 151);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(162, 68);
            btn_admin.TabIndex = 1;
            btn_admin.Text = "yönetici girişi";
            btn_admin.UseVisualStyleBackColor = true;
            btn_admin.Click += btn_admin_Click;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(50, 288);
            txt_sifre.Mask = "00000";
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(162, 27);
            txt_sifre.TabIndex = 2;
            txt_sifre.ValidatingType = typeof(int);
            txt_sifre.Visible = false;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.Location = new Point(50, 252);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(135, 20);
            lbl_sifre.TabIndex = 3;
            lbl_sifre.Text = "lütfen şifreyi giriniz";
            lbl_sifre.Visible = false;
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 450);
            Controls.Add(lbl_sifre);
            Controls.Add(txt_sifre);
            Controls.Add(btn_admin);
            Controls.Add(btn_musteri);
            Name = "giris";
            Text = "giriş ekranı";
            Load += giris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_musteri;
        private Button btn_admin;
        private MaskedTextBox txt_sifre;
        private Label lbl_sifre;
    }
}
