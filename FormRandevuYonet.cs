/****************************************************************************
**					      SAKARYA ÜNİVERSİTESİ
**				 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2023-2024 BAHAR DÖNEMİ
**
**
**
**		  ÖDEV NUMARASI.........:  Proje              Tarih..: 19.05.2024
**		  ÖĞRENCİ ADI...........:  Özgür Demir
**		  ÖĞRENCİ NUMARASI......:  B221210017
**        DERSİN ALINDIĞI GRUP..:  C
**
**
**
*****************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_ProjeDeneme1
{
    public partial class FormRandevuYonet : Form
    {
        private Form1 form1;
        public Dictionary<string, BindingList<Randevu>> calisanRandevular = new Dictionary<string, BindingList<Randevu>>();

        public FormRandevuYonet(Form1 _form1, Dictionary<string, BindingList<Randevu>> _calisanRandevular)
        {
            InitializeComponent();

            this.calisanRandevular = _calisanRandevular;
            this.form1 = _form1;

            // Tüm çalışanların tüm randevularını tek bir liste halinde birleştir
            var tumRandevular = calisanRandevular.SelectMany(pair => pair.Value).ToList();

            dataGridView1.DataSource = tumRandevular;


            lMenu.Font = new Font("Arial", 18, FontStyle.Bold);
            lMenu.ForeColor = Color.Black;
            lMenu.TextAlign = ContentAlignment.MiddleCenter;
            Invalidate();
        }

        private void FormRandevuYonet_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            Invalidate();
            
        }

        private void FormRandevuYonet_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            form1.Show();
        }

        private bool menuKucukMu = false;
        private void bMenuBuyult_Click(object sender, EventArgs e)
        {
            if (menuKucukMu)
            {
                // Menüyü genişlet
                bMenuBuyult.Visible = false;
                panelMenu.Width = 200;
                menuKucukMu = false;
            }
            else
            {
                // Menüyü küçült
                panelMenu.Width = 0;
                menuKucukMu = true;
                bMenuBuyult.Visible = true;
            }
        }

        private void bMenuKucult_Click(object sender, EventArgs e)
        {
            if (menuKucukMu)
            {
                // Menüyü genişlet
                bMenuBuyult.Visible = false;
                panelMenu.Width = 200;
                menuKucukMu = false;
            }
            else
            {
                // Menüyü küçült
                panelMenu.Width = 0;
                menuKucukMu = true;
                bMenuBuyult.Visible = true;
            }
        }

        private void bRandevu_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            // DataGridView'den seçili satırı al
            var selectedRow = dataGridView1.CurrentRow;

            if (selectedRow != null)
            {
                // Seçili satırdaki randevuyu al
                Randevu selectedRandevu = (Randevu)selectedRow.DataBoundItem;

                // Kullanıcıya onay mesajı göster
                var result = MessageBox.Show("Seçili randevuyu silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Randevuyu ilgili çalışanın listesinden kaldır
                    calisanRandevular[selectedRandevu.Calisan].Remove(selectedRandevu);

                    // Dosyayı güncelle
                    List<string> tumRandevular = calisanRandevular.SelectMany(pair => pair.Value.Select(randevu => $"{randevu.Calisan};{randevu.Tarih};{randevu.Saat};{randevu.MusteriAdi};{randevu.MusteriSoyadi};{randevu.MusteriTelefon};{randevu.MusteriEmail};{string.Join(",", randevu.Hizmetler)};{randevu.ToplamUcret}")).ToList();
                    File.WriteAllLines(@"E:\Visual Studio source-repos\C#ProjeDeneme1\C#ProjeDeneme1\randevular.txt", tumRandevular);

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = calisanRandevular.SelectMany(pair => pair.Value).ToList();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir randevu seçin.");
            }
        }
    }

}
