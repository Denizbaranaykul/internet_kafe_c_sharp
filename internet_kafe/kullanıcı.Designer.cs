namespace internet_kafe
{
    partial class kullanıcı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            btn_yorum = new Button();
            panel1 = new Panel();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            btn_mesaj = new Button();
            richTextBox2 = new RichTextBox();
            tabPage2 = new TabPage();
            btn_yenile_mesaj = new Button();
            dataGridView1 = new DataGridView();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.7F);
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 30;
            label1.Text = "Masa No : ";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(89, 67);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(237, 282);
            richTextBox1.TabIndex = 31;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.7F);
            label2.Location = new Point(339, 31);
            label2.Name = "label2";
            label2.Size = new Size(343, 32);
            label2.TabIndex = 32;
            label2.Text = "masada geçirilen süre : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.7F);
            label3.Location = new Point(89, 14);
            label3.Name = "label3";
            label3.Size = new Size(211, 32);
            label3.TabIndex = 33;
            label3.Text = "yorum bölümü";
            // 
            // btn_yorum
            // 
            btn_yorum.Location = new Point(133, 417);
            btn_yorum.Name = "btn_yorum";
            btn_yorum.Size = new Size(167, 49);
            btn_yorum.TabIndex = 34;
            btn_yorum.Text = "yorumu gönder";
            btn_yorum.UseVisualStyleBackColor = true;
            btn_yorum.Click += btn_yorum_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_yorum);
            panel1.Controls.Add(richTextBox1);
            panel1.Location = new Point(1379, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 514);
            panel1.TabIndex = 35;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(314, 379);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(95, 24);
            radioButton5.TabIndex = 39;
            radioButton5.TabStop = true;
            radioButton5.Text = "☆☆☆☆☆";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(226, 379);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(82, 24);
            radioButton4.TabIndex = 38;
            radioButton4.TabStop = true;
            radioButton4.Text = "☆☆☆☆";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(151, 379);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(69, 24);
            radioButton3.TabIndex = 37;
            radioButton3.TabStop = true;
            radioButton3.Text = "☆☆☆";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(89, 379);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 24);
            radioButton2.TabIndex = 36;
            radioButton2.TabStop = true;
            radioButton2.Text = "☆☆";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(25, 379);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(43, 24);
            radioButton1.TabIndex = 35;
            radioButton1.TabStop = true;
            radioButton1.Text = "☆";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Location = new Point(995, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 514);
            panel2.TabIndex = 36;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(372, 508);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btn_mesaj);
            tabPage1.Controls.Add(richTextBox2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(364, 475);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "msg gönder";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 15.7F);
            label4.Location = new Point(30, 27);
            label4.Name = "label4";
            label4.Size = new Size(247, 32);
            label4.TabIndex = 37;
            label4.Text = "mesajınızı yazınız";
            // 
            // btn_mesaj
            // 
            btn_mesaj.Location = new Point(105, 385);
            btn_mesaj.Name = "btn_mesaj";
            btn_mesaj.Size = new Size(167, 49);
            btn_mesaj.TabIndex = 35;
            btn_mesaj.Text = "mesaj gönder";
            btn_mesaj.UseVisualStyleBackColor = true;
            btn_mesaj.Click += btn_mesaj_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(30, 68);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(302, 303);
            richTextBox2.TabIndex = 32;
            richTextBox2.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_yenile_mesaj);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(364, 475);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "gelen msg";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_yenile_mesaj
            // 
            btn_yenile_mesaj.Location = new Point(99, 385);
            btn_yenile_mesaj.Name = "btn_yenile_mesaj";
            btn_yenile_mesaj.Size = new Size(167, 49);
            btn_yenile_mesaj.TabIndex = 35;
            btn_yenile_mesaj.Text = "gelen kutusunu yenile";
            btn_yenile_mesaj.UseVisualStyleBackColor = true;
            btn_yenile_mesaj.Click += btn_yenile_mesaj_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(352, 329);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Location = new Point(25, 98);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(905, 440);
            tabControl2.TabIndex = 37;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(897, 407);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "sıcak içecekler";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(897, 407);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "soğuk içecekler";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(897, 407);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "atıştırmaklık";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(897, 407);
            tabPage6.TabIndex = 3;
            tabPage6.Text = "yemekler";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // kullanıcı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1812, 557);
            Controls.Add(tabControl2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "kullanıcı";
            Text = "kullanıcı";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Label label3;
        private Button btn_yorum;
        private Panel panel1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btn_mesaj;
        private RichTextBox richTextBox2;
        private TabPage tabPage2;
        private Button btn_yenile_mesaj;
        private DataGridView dataGridView1;
        private Label label4;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
    }
}