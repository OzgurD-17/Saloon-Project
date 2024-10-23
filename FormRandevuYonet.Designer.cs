namespace C_ProjeDeneme1
{
    partial class FormRandevuYonet
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
            components = new System.ComponentModel.Container();
            randevuBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            Calisan = new DataGridViewTextBoxColumn();
            tarihDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            musteriAdiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            musteriSoyadiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            musteriTelefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            musteriEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ToplamUcret = new DataGridViewTextBoxColumn();
            HizmetlerString = new DataGridViewTextBoxColumn();
            panelMenu = new Panel();
            btnRandevuSil = new Button();
            bMenuKucult = new Button();
            lMenu = new Label();
            bRandevu = new Button();
            bMenuBuyult = new Button();
            ((System.ComponentModel.ISupportInitialize)randevuBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // randevuBindingSource
            // 
            randevuBindingSource.DataSource = typeof(Randevu);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 64, 0);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Calisan, tarihDataGridViewTextBoxColumn, saatDataGridViewTextBoxColumn, musteriAdiDataGridViewTextBoxColumn, musteriSoyadiDataGridViewTextBoxColumn, musteriTelefonDataGridViewTextBoxColumn, musteriEmailDataGridViewTextBoxColumn, ToplamUcret, HizmetlerString });
            dataGridView1.DataSource = randevuBindingSource;
            dataGridView1.Location = new Point(208, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1559, 599);
            dataGridView1.TabIndex = 2;
            // 
            // Calisan
            // 
            Calisan.DataPropertyName = "Calisan";
            Calisan.FillWeight = 1000F;
            Calisan.HeaderText = "Calisan";
            Calisan.MinimumWidth = 6;
            Calisan.Name = "Calisan";
            Calisan.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // saatDataGridViewTextBoxColumn
            // 
            saatDataGridViewTextBoxColumn.DataPropertyName = "Saat";
            saatDataGridViewTextBoxColumn.HeaderText = "Saat";
            saatDataGridViewTextBoxColumn.MinimumWidth = 6;
            saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            saatDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriAdiDataGridViewTextBoxColumn
            // 
            musteriAdiDataGridViewTextBoxColumn.DataPropertyName = "MusteriAdi";
            musteriAdiDataGridViewTextBoxColumn.HeaderText = "MusteriAdi";
            musteriAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            musteriAdiDataGridViewTextBoxColumn.Name = "musteriAdiDataGridViewTextBoxColumn";
            musteriAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriSoyadiDataGridViewTextBoxColumn
            // 
            musteriSoyadiDataGridViewTextBoxColumn.DataPropertyName = "MusteriSoyadi";
            musteriSoyadiDataGridViewTextBoxColumn.HeaderText = "MusteriSoyadi";
            musteriSoyadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            musteriSoyadiDataGridViewTextBoxColumn.Name = "musteriSoyadiDataGridViewTextBoxColumn";
            musteriSoyadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriTelefonDataGridViewTextBoxColumn
            // 
            musteriTelefonDataGridViewTextBoxColumn.DataPropertyName = "MusteriTelefon";
            musteriTelefonDataGridViewTextBoxColumn.HeaderText = "MusteriTelefon";
            musteriTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            musteriTelefonDataGridViewTextBoxColumn.Name = "musteriTelefonDataGridViewTextBoxColumn";
            musteriTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriEmailDataGridViewTextBoxColumn
            // 
            musteriEmailDataGridViewTextBoxColumn.DataPropertyName = "MusteriEmail";
            musteriEmailDataGridViewTextBoxColumn.HeaderText = "MusteriEmail";
            musteriEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            musteriEmailDataGridViewTextBoxColumn.Name = "musteriEmailDataGridViewTextBoxColumn";
            musteriEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // ToplamUcret
            // 
            ToplamUcret.DataPropertyName = "ToplamUcret";
            ToplamUcret.HeaderText = "ToplamUcret";
            ToplamUcret.MinimumWidth = 6;
            ToplamUcret.Name = "ToplamUcret";
            ToplamUcret.Width = 125;
            // 
            // HizmetlerString
            // 
            HizmetlerString.DataPropertyName = "HizmetlerString";
            HizmetlerString.DividerWidth = 1;
            HizmetlerString.HeaderText = "Hizmetler";
            HizmetlerString.MinimumWidth = 26;
            HizmetlerString.Name = "HizmetlerString";
            HizmetlerString.ReadOnly = true;
            HizmetlerString.Width = 500;
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.Left;
            panelMenu.BackColor = SystemColors.ActiveCaption;
            panelMenu.Controls.Add(btnRandevuSil);
            panelMenu.Controls.Add(bMenuKucult);
            panelMenu.Controls.Add(lMenu);
            panelMenu.Controls.Add(bRandevu);
            panelMenu.Location = new Point(2, 15);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 599);
            panelMenu.TabIndex = 15;
            // 
            // btnRandevuSil
            // 
            btnRandevuSil.BackColor = Color.Red;
            btnRandevuSil.Location = new Point(19, 261);
            btnRandevuSil.Name = "btnRandevuSil";
            btnRandevuSil.Size = new Size(160, 65);
            btnRandevuSil.TabIndex = 2;
            btnRandevuSil.Text = "Randevu Sil";
            btnRandevuSil.UseVisualStyleBackColor = false;
            btnRandevuSil.Click += btnRandevuSil_Click;
            // 
            // bMenuKucult
            // 
            bMenuKucult.BackColor = Color.FromArgb(128, 255, 255);
            bMenuKucult.Location = new Point(130, 3);
            bMenuKucult.Name = "bMenuKucult";
            bMenuKucult.Size = new Size(69, 38);
            bMenuKucult.TabIndex = 1;
            bMenuKucult.Text = "Küçült";
            bMenuKucult.UseVisualStyleBackColor = false;
            bMenuKucult.Click += bMenuKucult_Click;
            // 
            // lMenu
            // 
            lMenu.AutoSize = true;
            lMenu.Location = new Point(19, 76);
            lMenu.MinimumSize = new Size(160, 70);
            lMenu.Name = "lMenu";
            lMenu.Size = new Size(160, 70);
            lMenu.TabIndex = 0;
            lMenu.Text = "MENÜ";
            lMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bRandevu
            // 
            bRandevu.BackColor = Color.FromArgb(255, 255, 128);
            bRandevu.Location = new Point(19, 375);
            bRandevu.Name = "bRandevu";
            bRandevu.Size = new Size(160, 65);
            bRandevu.TabIndex = 0;
            bRandevu.Text = "Randevu Al";
            bRandevu.UseVisualStyleBackColor = false;
            bRandevu.Click += bRandevu_Click;
            // 
            // bMenuBuyult
            // 
            bMenuBuyult.Anchor = AnchorStyles.Left;
            bMenuBuyult.BackColor = Color.FromArgb(128, 255, 255);
            bMenuBuyult.Location = new Point(5, 15);
            bMenuBuyult.Name = "bMenuBuyult";
            bMenuBuyult.Size = new Size(64, 38);
            bMenuBuyult.TabIndex = 16;
            bMenuBuyult.Text = "Büyült";
            bMenuBuyult.UseVisualStyleBackColor = false;
            bMenuBuyult.Click += bMenuBuyult_Click;
            // 
            // FormRandevuYonet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1779, 626);
            Controls.Add(bMenuBuyult);
            Controls.Add(panelMenu);
            Controls.Add(dataGridView1);
            Name = "FormRandevuYonet";
            Text = "Randevu Yönet";
            FormClosing += FormRandevuYonet_FormClosing;
            ((System.ComponentModel.ISupportInitialize)randevuBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource randevuBindingSource;
        private DataGridView dataGridView1;
        private Panel panelMenu;
        private Button bMenuKucult;
        private Label lMenu;
        private Button bRandevu;
        private Button bMenuBuyult;
        private Button btnRandevuSil;
        private DataGridViewTextBoxColumn Calisan;
        private DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn musteriAdiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn musteriSoyadiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn musteriTelefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn musteriEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ToplamUcret;
        private DataGridViewTextBoxColumn HizmetlerString;
    }
}