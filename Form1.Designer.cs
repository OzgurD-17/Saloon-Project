namespace C_ProjeDeneme1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            bRandevuOnay = new Button();
            nameBox = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            timePicker = new ComboBox();
            pBilgiler = new Panel();
            label8 = new Label();
            maskedPhoneBox = new MaskedTextBox();
            comboBoxCalisanlar = new ComboBox();
            labelErrorMessage1 = new Label();
            labelErrorMessage2 = new Label();
            label4 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            surnameBox = new TextBox();
            label6 = new Label();
            maskedEmailBox = new MaskedTextBox();
            pHizmetler = new Panel();
            ltutar = new Label();
            checkBox7 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            treeView1 = new TreeView();
            panelMenu = new Panel();
            bMenuKucult = new Button();
            lMenu = new Label();
            bAdmin = new Button();
            bRYonet = new Button();
            bRandevu = new Button();
            bCalisanlar = new Button();
            bMenuBuyult = new Button();
            bAdminCikis = new Button();
            panel1.SuspendLayout();
            pBilgiler.SuspendLayout();
            pHizmetler.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 18);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 103);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Telefon:";
            // 
            // bRandevuOnay
            // 
            bRandevuOnay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bRandevuOnay.BackColor = Color.FromArgb(255, 255, 128);
            bRandevuOnay.Location = new Point(657, 539);
            bRandevuOnay.Name = "bRandevuOnay";
            bRandevuOnay.Size = new Size(177, 73);
            bRandevuOnay.TabIndex = 13;
            bRandevuOnay.Text = "Randevuyu Onayla";
            bRandevuOnay.UseVisualStyleBackColor = false;
            bRandevuOnay.Click += bRandevuOnay_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(81, 15);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(137, 27);
            nameBox.TabIndex = 1;
            nameBox.KeyPress += nameBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 19);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 0;
            label3.Text = "Hizmetler";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(timePicker);
            panel1.Controls.Add(pBilgiler);
            panel1.Controls.Add(pHizmetler);
            panel1.Controls.Add(treeView1);
            panel1.Controls.Add(bRandevuOnay);
            panel1.Location = new Point(211, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 629);
            panel1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 250);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 24;
            label5.Text = "Randevu Saati Seçin";
            // 
            // timePicker
            // 
            timePicker.FormattingEnabled = true;
            timePicker.Location = new Point(353, 282);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(151, 28);
            timePicker.TabIndex = 23;
            timePicker.SelectedIndexChanged += timePicker_SelectedIndexChanged;
            // 
            // pBilgiler
            // 
            pBilgiler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pBilgiler.Controls.Add(label8);
            pBilgiler.Controls.Add(maskedPhoneBox);
            pBilgiler.Controls.Add(comboBoxCalisanlar);
            pBilgiler.Controls.Add(label1);
            pBilgiler.Controls.Add(label2);
            pBilgiler.Controls.Add(labelErrorMessage1);
            pBilgiler.Controls.Add(nameBox);
            pBilgiler.Controls.Add(labelErrorMessage2);
            pBilgiler.Controls.Add(label4);
            pBilgiler.Controls.Add(label7);
            pBilgiler.Controls.Add(dateTimePicker1);
            pBilgiler.Controls.Add(surnameBox);
            pBilgiler.Controls.Add(label6);
            pBilgiler.Controls.Add(maskedEmailBox);
            pBilgiler.Location = new Point(54, 19);
            pBilgiler.Name = "pBilgiler";
            pBilgiler.Size = new Size(805, 292);
            pBilgiler.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(299, 22);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 27;
            label8.Text = "Çalışanlarımız";
            // 
            // maskedPhoneBox
            // 
            maskedPhoneBox.Location = new Point(81, 103);
            maskedPhoneBox.Mask = "(999) 000-0000";
            maskedPhoneBox.Name = "maskedPhoneBox";
            maskedPhoneBox.Size = new Size(137, 27);
            maskedPhoneBox.TabIndex = 3;
            maskedPhoneBox.Validating += maskedPhoneBox_Validating;
            // 
            // comboBoxCalisanlar
            // 
            comboBoxCalisanlar.FormattingEnabled = true;
            comboBoxCalisanlar.Location = new Point(299, 53);
            comboBoxCalisanlar.Name = "comboBoxCalisanlar";
            comboBoxCalisanlar.Size = new Size(151, 28);
            comboBoxCalisanlar.TabIndex = 26;
            comboBoxCalisanlar.SelectedIndexChanged += comboBoxCalisanlar_SelectedIndexChanged;
            // 
            // labelErrorMessage1
            // 
            labelErrorMessage1.AutoSize = true;
            labelErrorMessage1.Location = new Point(13, 133);
            labelErrorMessage1.Name = "labelErrorMessage1";
            labelErrorMessage1.Size = new Size(140, 20);
            labelErrorMessage1.TabIndex = 0;
            labelErrorMessage1.Text = "labelErrorMessage1";
            labelErrorMessage1.Visible = false;
            // 
            // labelErrorMessage2
            // 
            labelErrorMessage2.AutoSize = true;
            labelErrorMessage2.Location = new Point(15, 192);
            labelErrorMessage2.Name = "labelErrorMessage2";
            labelErrorMessage2.Size = new Size(140, 20);
            labelErrorMessage2.TabIndex = 0;
            labelErrorMessage2.Text = "labelErrorMessage2";
            labelErrorMessage2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 22);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 0;
            label4.Text = "Randevu Tarihi Seçin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 61);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 0;
            label7.Text = "Soyad:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(513, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(81, 58);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(137, 27);
            surnameBox.TabIndex = 2;
            surnameBox.KeyPress += surnameBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 165);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 22;
            label6.Text = "E-mail:";
            // 
            // maskedEmailBox
            // 
            maskedEmailBox.Location = new Point(81, 162);
            maskedEmailBox.Name = "maskedEmailBox";
            maskedEmailBox.Size = new Size(137, 27);
            maskedEmailBox.TabIndex = 4;
            maskedEmailBox.Validating += maskedEmailBox_Validating;
            // 
            // pHizmetler
            // 
            pHizmetler.Controls.Add(label3);
            pHizmetler.Controls.Add(ltutar);
            pHizmetler.Controls.Add(checkBox7);
            pHizmetler.Controls.Add(checkBox1);
            pHizmetler.Controls.Add(checkBox6);
            pHizmetler.Controls.Add(checkBox2);
            pHizmetler.Controls.Add(checkBox5);
            pHizmetler.Controls.Add(checkBox3);
            pHizmetler.Controls.Add(checkBox4);
            pHizmetler.Location = new Point(54, 317);
            pHizmetler.Name = "pHizmetler";
            pHizmetler.Size = new Size(265, 309);
            pHizmetler.TabIndex = 21;
            // 
            // ltutar
            // 
            ltutar.AutoSize = true;
            ltutar.Location = new Point(15, 278);
            ltutar.Name = "ltutar";
            ltutar.Size = new Size(44, 20);
            ltutar.TabIndex = 0;
            ltutar.Text = "ltutar";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(15, 234);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(174, 24);
            checkBox7.TabIndex = 11;
            checkBox7.Text = "Pasta ve Cila - 1500TL";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 54);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(151, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Saç Kesim - 200TL";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(15, 203);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(132, 24);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "Pedikür - 300TL";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 84);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(159, 24);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Saç Yıkama - 100TL";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(15, 173);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(137, 24);
            checkBox5.TabIndex = 9;
            checkBox5.Text = "Manikür - 200TL";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(15, 113);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(165, 24);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Saç Boyama - 900TL";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(15, 143);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(167, 24);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Kaş Düzeltme - 50TL";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(3, 261);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(8, 8);
            treeView1.TabIndex = 16;
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(bMenuKucult);
            panelMenu.Controls.Add(lMenu);
            panelMenu.Controls.Add(bAdmin);
            panelMenu.Controls.Add(bRYonet);
            panelMenu.Controls.Add(bRandevu);
            panelMenu.Controls.Add(bCalisanlar);
            panelMenu.Location = new Point(5, 5);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 629);
            panelMenu.TabIndex = 0;
            // 
            // bMenuKucult
            // 
            bMenuKucult.Anchor = AnchorStyles.Left;
            bMenuKucult.BackColor = Color.FromArgb(128, 255, 255);
            bMenuKucult.Location = new Point(134, 6);
            bMenuKucult.Name = "bMenuKucult";
            bMenuKucult.Size = new Size(66, 41);
            bMenuKucult.TabIndex = 1;
            bMenuKucult.Text = "Küçült";
            bMenuKucult.UseVisualStyleBackColor = false;
            bMenuKucult.Click += bMenuKucult_Click;
            // 
            // lMenu
            // 
            lMenu.Anchor = AnchorStyles.Left;
            lMenu.AutoSize = true;
            lMenu.Location = new Point(12, 55);
            lMenu.MinimumSize = new Size(160, 70);
            lMenu.Name = "lMenu";
            lMenu.Size = new Size(160, 70);
            lMenu.TabIndex = 0;
            lMenu.Text = "MENÜ";
            lMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bAdmin
            // 
            bAdmin.Anchor = AnchorStyles.Left;
            bAdmin.BackColor = Color.FromArgb(255, 255, 128);
            bAdmin.Location = new Point(12, 442);
            bAdmin.Name = "bAdmin";
            bAdmin.Size = new Size(160, 65);
            bAdmin.TabIndex = 0;
            bAdmin.Text = "Admin Girişi";
            bAdmin.UseVisualStyleBackColor = false;
            bAdmin.Click += bAdmin_Click;
            // 
            // bRYonet
            // 
            bRYonet.Anchor = AnchorStyles.Left;
            bRYonet.BackColor = Color.FromArgb(192, 255, 192);
            bRYonet.Enabled = false;
            bRYonet.Location = new Point(12, 538);
            bRYonet.Name = "bRYonet";
            bRYonet.Size = new Size(160, 65);
            bRYonet.TabIndex = 0;
            bRYonet.Text = "Randevuları Yönet (Admin)";
            bRYonet.UseVisualStyleBackColor = false;
            bRYonet.Click += bRYonet_Click;
            // 
            // bRandevu
            // 
            bRandevu.Anchor = AnchorStyles.Left;
            bRandevu.BackColor = Color.FromArgb(255, 255, 128);
            bRandevu.Location = new Point(12, 158);
            bRandevu.Name = "bRandevu";
            bRandevu.Size = new Size(160, 65);
            bRandevu.TabIndex = 0;
            bRandevu.Text = "Randevu Al";
            bRandevu.UseVisualStyleBackColor = false;
            // 
            // bCalisanlar
            // 
            bCalisanlar.Anchor = AnchorStyles.Left;
            bCalisanlar.BackColor = Color.FromArgb(255, 255, 128);
            bCalisanlar.Location = new Point(12, 253);
            bCalisanlar.Name = "bCalisanlar";
            bCalisanlar.Size = new Size(160, 65);
            bCalisanlar.TabIndex = 0;
            bCalisanlar.Text = "Calışanlarımız";
            bCalisanlar.UseVisualStyleBackColor = false;
            bCalisanlar.Click += bCalisanlar_Click;
            // 
            // bMenuBuyult
            // 
            bMenuBuyult.Anchor = AnchorStyles.Left;
            bMenuBuyult.BackColor = Color.FromArgb(128, 255, 255);
            bMenuBuyult.Location = new Point(8, 11);
            bMenuBuyult.Name = "bMenuBuyult";
            bMenuBuyult.Size = new Size(64, 38);
            bMenuBuyult.TabIndex = 2;
            bMenuBuyult.Text = "Büyült";
            bMenuBuyult.UseVisualStyleBackColor = false;
            bMenuBuyult.Visible = false;
            bMenuBuyult.Click += bMenuBuyult_Click;
            // 
            // bAdminCikis
            // 
            bAdminCikis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bAdminCikis.BackColor = Color.Red;
            bAdminCikis.Location = new Point(962, 10);
            bAdminCikis.Name = "bAdminCikis";
            bAdminCikis.Size = new Size(125, 48);
            bAdminCikis.TabIndex = 12;
            bAdminCikis.Text = "Çıkış Yap";
            bAdminCikis.UseVisualStyleBackColor = false;
            bAdminCikis.Visible = false;
            bAdminCikis.Click += bAdminCikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1095, 639);
            Controls.Add(bAdminCikis);
            Controls.Add(bMenuBuyult);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selin Kuaför Randevu Sistemi";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pBilgiler.ResumeLayout(false);
            pBilgiler.PerformLayout();
            pHizmetler.ResumeLayout(false);
            pHizmetler.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bRandevuOnay;
        private TextBox nameBox;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Label ltutar;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TreeView treeView1;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private DateTimePicker dateTimePicker1;
        private Panel pHizmetler;
        private MaskedTextBox maskedPhoneBox;
        private MaskedTextBox maskedEmailBox;
        private Label label6;
        private Label label7;
        private TextBox surnameBox;
        private Label labelErrorMessage2;
        private Label labelErrorMessage1;
        private ComboBox timePicker;
        private Label label5;
        private Panel pBilgiler;
        private Panel panelMenu;
        private Button bAdmin;
        private Button bRYonet;
        private Button bRandevu;
        private Button bCalisanlar;
        private Label lMenu;
        private Button bMenuKucult;
        private Button bMenuBuyult;
        private Button bAdminCikis;
        private Label label8;
        private ComboBox comboBoxCalisanlar;
    }
}
