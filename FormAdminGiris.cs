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
    public partial class FormAdminGiris : Form
    {
        private Form1 form1;
        public FormAdminGiris(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void bGiris_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "asd" && textBox2.Text == "asd")
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                form1.Show();
                form1.isAdminLoggedIn = true;
                form1.AdminGirisKontrol();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void FormAdminGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            form1.Show();
        }
    }
}
