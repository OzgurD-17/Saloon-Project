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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_ProjeDeneme1
{
    public partial class FormCalisanlar : Form
    {
        public FormCalisanlar()
        {
            InitializeComponent();

            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label2.Font = new Font("Arial", 12, FontStyle.Bold);
            label3.Font = new Font("Arial", 12, FontStyle.Bold);
            label4.Font = new Font("Arial", 12, FontStyle.Bold);
            label5.Font = new Font("Arial", 12, FontStyle.Bold);
        }
        private Form1 form1;
        public FormCalisanlar(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void BRandevu_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private bool menuKucukMu = false;
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

        private void FormCalisanlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            form1.Show();
        }

        private void bRandevu_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void FormCalisanlar_Load(object sender, EventArgs e)
        {
            lMenu.Font = new Font("Arial", 18, FontStyle.Bold);
            lMenu.ForeColor = Color.Black;
            lMenu.TextAlign = ContentAlignment.MiddleCenter;
            Invalidate();
        }
    }
}
