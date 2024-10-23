/****************************************************************************
**					      SAKARYA �N�VERS�TES�
**				 B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				      B�LG�SAYAR M�HEND�SL��� B�L�M�
**				     NESNEYE DAYALI PROGRAMLAMA DERS�
**					     2023-2024 BAHAR D�NEM�
**
**
**
**		  �DEV NUMARASI.........:  Proje              Tarih..: 19.05.2024
**		  ��RENC� ADI...........:  �zg�r Demir
**		  ��RENC� NUMARASI......:  B221210017
**        DERS�N ALINDI�I GRUP..:  C
**
**
**
*****************************************************************************/
using System.ComponentModel;
using System.Windows.Forms;

namespace C_ProjeDeneme1
{
    public partial class Form1 : Form
    {
        public Dictionary<string, BindingList<Randevu>> calisanRandevular = new Dictionary<string, BindingList<Randevu>>();

        public bool isAdminLoggedIn = false;

        int tutar = 0;
        public Form1()
        {
            InitializeComponent();

            calisanRandevular.Add("Merve �eng�l", new BindingList<Randevu>());
            calisanRandevular.Add("Esma Korkmaz", new BindingList<Randevu>());
            calisanRandevular.Add("Asiye Keskin", new BindingList<Randevu>());
            calisanRandevular.Add("Aynur Tekin", new BindingList<Randevu>());
            calisanRandevular.Add("Kadriye G�ne�", new BindingList<Randevu>());

            nameBox.MaxLength = 15;
            surnameBox.MaxLength = 15;
            maskedEmailBox.MaxLength = 30;

            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(30);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";


            timePicker.DrawMode = DrawMode.OwnerDrawFixed; // al�nm�� saatleri farkl� g�stermek i�in �izim
            timePicker.DrawItem += new DrawItemEventHandler(timePicker_DrawItem);


            lMenu.Font = new Font("Arial", 18, FontStyle.Bold);
            lMenu.ForeColor = Color.Black;
            lMenu.TextAlign = ContentAlignment.MiddleCenter;


            ltutar.Text = "Toplam fiyat: " + tutar.ToString() + "TL";

            // �al��anlar� ComboBox'a ekle
            comboBoxCalisanlar.Items.Add("Merve �eng�l");
            comboBoxCalisanlar.Items.Add("Esma Korkmaz");
            comboBoxCalisanlar.Items.Add("Asiye Keskin");
            comboBoxCalisanlar.Items.Add("Aynur Tekin");
            comboBoxCalisanlar.Items.Add("Kadriye G�ne�");
            comboBoxCalisanlar.SelectedIndex = -1; // �lk �al��an� varsay�lan olarak se�


            this.Invalidate();
        }

        private FormRandevuYonet formRandevuYonet;
        //public BindingList<Randevu> randevular = new BindingList<Randevu>();

        private void bRandevuOnay_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || maskedPhoneBox.Text == "" || maskedEmailBox.Text == "" || dateTimePicker1.Value.ToShortDateString() == null || timePicker.SelectedItem == null || comboBoxCalisanlar.SelectedItem == null || tutar == 0)
            {
                MessageBox.Show("L�tfen t�m alanlar� doldurunuz, veya se�mediyseniz hizmet(ler), randevu tarihi, saati ve hizmeti verecek �al��an� se�iniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (labelErrorMessage1.Visible || labelErrorMessage2.Visible)
            {
                MessageBox.Show("L�tfen ge�erli bir telefon numaras� ve e-posta adresi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Randevunuz al�nm��t�r. Randevu Bilgileri:\n Randevu tutar�: " + tutar + "TL. Randevu tarihi: " + dateTimePicker1.Value.ToShortDateString(), "Randevu Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                string secilenSaat = timePicker.SelectedItem != null ? timePicker.SelectedItem.ToString() : "";
                DateTime secilenTarih = dateTimePicker1.Value.Date;
                string musteriAdi = nameBox.Text;
                string musteriSoyadi = surnameBox.Text;
                string musteriTelefon = maskedPhoneBox.Text;
                string musteriEmail = maskedEmailBox.Text;
                string secilenCalisan = comboBoxCalisanlar.SelectedItem.ToString();
                List<string> secilenHizmetler = new List<string>();
                
                
                if (checkBox1.Checked)
                {
                    secilenHizmetler.Add("Sa� Kesim");
                }
                if (checkBox2.Checked)
                {
                    secilenHizmetler.Add("Sa� Y�kama");
                }
                if (checkBox3.Checked)
                {
                    secilenHizmetler.Add("Sa� Boyama");
                }
                if (checkBox4.Checked)
                {
                    secilenHizmetler.Add("Ka� D�zeltme");
                }
                if (checkBox5.Checked)
                {
                    secilenHizmetler.Add("Manik�r");
                }
                if (checkBox6.Checked)
                {
                    secilenHizmetler.Add("Pedi�r");
                }
                if (checkBox7.Checked)
                {
                    secilenHizmetler.Add("Pasta ve Cila");
                }
                

                RandevuEkle(secilenCalisan, secilenTarih, secilenSaat, musteriAdi, musteriSoyadi, musteriTelefon, musteriEmail, secilenHizmetler, tutar);

                int secilenSaatIndex = timePicker.SelectedIndex;
                //alinanSaatler.Add(secilenSaat);
                timePicker.Items[secilenSaatIndex] = timePicker.Items[secilenSaatIndex] + " - Dolu";


                MessageBox.Show("Randevunuz onaylanm��t�r. Randevu tarihiniz: " + dateTimePicker1.Value.ToShortDateString() + "\nL�tfen randevu saatinizden 10-15 dakika �nce i� yerimizde olunuz.\nGe� gelmeniz durumunda �cret iadesi yap�lmaz", "Randevu Alma Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                dateTimePicker1.Value = DateTime.Now;
                timePicker.SelectedIndex = -1;
                nameBox.Clear();
                surnameBox.Clear();
                maskedPhoneBox.Clear();
                maskedEmailBox.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
            }
            else
            {
                MessageBox.Show("Randevu alma i�lemi iptal edilmi�tir.", "Randevu �ptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #region CheckBoxes
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(checkBox1, 200);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(checkBox2, 100);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(checkBox3, 900);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(checkBox4, 50);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(checkBox5, 200);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(checkBox6, 300);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            TutarGuncelle(checkBox7, 1500);
        }
        #endregion

        private void TutarGuncelle(CheckBox checkBox, int amount)
        {
            if (checkBox.Checked)
            {
                tutar += amount;
            }
            else
            {
                tutar -= amount;
            }
            ltutar.Text = "Toplam fiyat: " + tutar.ToString() + "TL";
        }

        public void AdminGirisKontrol()
        {
            if (isAdminLoggedIn)
            {
                bRYonet.Enabled = true;
                bAdminCikis.Visible = true;
            }
            else
            {
                bRYonet.Enabled = false;
                bAdminCikis.Visible = false;
            }
        }

        #region textBox Kontrolleri
        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // E�er girilen karakter bir harf de�ilse ve kontrol karakteri de�ilse, giri�i engelle
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void surnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // E�er girilen karakter bir harf de�ilse ve kontrol karakteri de�ilse, giri�i engelle
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedEmailBox_Validating(object sender, EventArgs e)
        {
            string email = maskedEmailBox.Text;

            // E-posta adresi do�rulamas� i�in basit bir y�ntem
            if (!EmailKontrol(email))
            {
                labelErrorMessage2.Visible = true;
                labelErrorMessage2.Text = "Ge�erli bir e-posta adresi girin.";
                labelErrorMessage2.ForeColor = Color.Red;
                labelErrorMessage2.Font = new Font(labelErrorMessage2.Font, FontStyle.Bold);
                //MessageBox.Show("Ge�erli bir e-posta adresi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //maskedEmailBox.Clear(); // Hatal� giri�i temizle
            }
            else
            {
                labelErrorMessage2.Visible = false; // Hata olmad���nda Label'� gizle
                //labelErrorMessage2.Text = ""; // Uyar� mesaj�n� temizle
            }
        }
        private bool EmailKontrol(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void maskedPhoneBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string phone = maskedPhoneBox.Text;
            if (!PhoneKontrol(phone))
            {
                labelErrorMessage1.Visible = true;
                labelErrorMessage1.Text = "Ge�erli bir telefon numaras� girin.";
                labelErrorMessage1.ForeColor = Color.Red;
                labelErrorMessage1.Font = new Font(labelErrorMessage1.Font, FontStyle.Bold);
                //MessageBox.Show("Ge�erli bir telefon numaras� girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //maskedPhoneBox.Clear(); // Hatal� giri�i temizle
            }
            else
            {
                labelErrorMessage1.Visible = false; // Hata olmad���nda Label'� gizle
                //labelErrorMessage1.Text = ""; // Uyar� mesaj�n� temizle
            }
        }

        private bool PhoneKontrol(string phone)
        {
            if (phone.Length != 14)
            {
                return false;
            }
            return true;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Today.AddHours(9); // Ba�lang�� saati
            while (time <= DateTime.Today.AddHours(18)) // Biti� saati
            {
                timePicker.Items.Add(time.ToString("HH:mm")); // Saati ComboBox'a ekle
                time = time.AddMinutes(30); // Saati 30 dakika art�r
            }
            timePicker.SelectedIndex = 0;
            dateTimePicker1_ValueChanged(dateTimePicker1, EventArgs.Empty);


            string dosyaYolu = @"E:\Visual Studio source-repos\C#ProjeDeneme1\C#ProjeDeneme1\randevular.txt";
            string[] randevuBilgileri = File.ReadAllLines(dosyaYolu);



            foreach (string randevuBilgisi in randevuBilgileri)
            {
                // Her bir sat�r� parse ederek Randevu nesnesine d�n��t�r
                string[] bilgiler = randevuBilgisi.Split(';');
                string calisan = bilgiler[0];
                DateTime tarih = DateTime.Parse(bilgiler[1]);
                string saat = bilgiler[2];
                string musteriAdi = bilgiler[3];
                string musteriSoyadi = bilgiler[4];
                string musteriTelefon = bilgiler[5];
                string musteriEmail = bilgiler[6];
                List<string> hizmetler = bilgiler[7].Split(',').ToList();
                int toplamUcret = int.Parse(bilgiler[8]);

                Randevu randevu = new Randevu(calisan, tarih, saat, musteriAdi, musteriSoyadi, musteriTelefon, musteriEmail, hizmetler, toplamUcret)
                {
                    Calisan = calisan,
                    Tarih = tarih,
                    Saat = saat,
                    MusteriAdi = musteriAdi,
                    MusteriSoyadi = musteriSoyadi,
                    MusteriTelefon = musteriTelefon,
                    MusteriEmail = musteriEmail,
                    Hizmetler = hizmetler,
                    ToplamUcret = toplamUcret
                };

                // Randevuyu ilgili �al��an�n listesine ekle
                if (!calisanRandevular.ContainsKey(calisan))
                {
                    calisanRandevular[calisan] = new BindingList<Randevu>();
                }
                calisanRandevular[calisan].Add(randevu);
            }

        }

        private void timePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timePicker.SelectedItem != null && timePicker.SelectedItem.ToString().Contains("Dolu"))
            {
                //MessageBox.Show("Bu saat dolu. L�tfen ba�ka bir saat se�in.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timePicker.SelectedIndex = -1; // Se�imi kald�r
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime secilenTarih = dateTimePicker1.Value.Date;
            string secilenCalisan = comboBoxCalisanlar.SelectedItem != null ? comboBoxCalisanlar.SelectedItem.ToString() : "";

            // Saatleri yeniden y�kle
            timePicker.Items.Clear();
            DateTime time = DateTime.Today.AddHours(9); // Ba�lang�� saati
            TimeSpan delay = TimeSpan.FromMinutes(15); // Gecikme s�resi
            while (time <= DateTime.Today.AddHours(18)) // Biti� saati
            {
                string saat = time.ToString("HH:mm");
                if ((secilenTarih == DateTime.Today && time.TimeOfDay < DateTime.Now.TimeOfDay + delay) || RandevuVarMi(secilenCalisan, secilenTarih, saat))
                {
                    // Bu saat dolu
                    saat += " - Dolu";
                }
                timePicker.Items.Add(saat); // Saati ComboBox'a ekle
                time = time.AddMinutes(30); // Saati 30 dakika art�r
            }
            timePicker.SelectedIndex = 0;
        }

        private void timePicker_DrawItem(object sender, DrawItemEventArgs e) // ComboBox'ta �izim yap
        {
            /// Bu tasar�mla metin gri olur ve italik yaz�l�r
            /// 

            //if (e.Index < 0) return; // Hi�bir ��e se�ili de�ilse ��k

            //// Se�ili ��enin metnini al
            //string text = ((ComboBox)sender).Items[e.Index].ToString();

            //// Metin "Dolu" i�eriyorsa, ��eyi gri ve italik yaz
            //if (text.Contains("Dolu"))
            //{
            //    e.Graphics.DrawString(text, new Font(e.Font, FontStyle.Italic), Brushes.Gray, e.Bounds);
            //}
            //else
            //{
            //    e.DrawBackground();
            //    e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds);
            //    e.DrawFocusRectangle();
            //}

            if (e.Index < 0) return; // Hi�bir ��e se�ili de�ilse ��k

            if (sender is ComboBox comboBox && e.Index >= 0)
            {
                object item = comboBox.Items[e.Index];
                if (item != null)
                {
                    // Se�ili ��enin metnini al
                    string text = item.ToString();

                    // Metin "Dolu" i�eriyorsa, ��enin arka plan�n� k�rm�z� yap
                    if (text.Contains("Dolu"))
                    {
                        e.Graphics.FillRectangle(Brushes.MediumVioletRed, e.Bounds);
                        e.Graphics.DrawString(text, e.Font, Brushes.White, e.Bounds);
                    }
                    else
                    {
                        e.DrawBackground();
                        e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds);
                        e.DrawFocusRectangle();
                    }

                }
            }
        }

        private void bCalisanlar_Click(object sender, EventArgs e)
        {
            FormCalisanlar formCalisanlar = new FormCalisanlar(this);
            this.Hide();
            formCalisanlar.Show();

        }
        #region Menu K���lt B�y�lt
        private bool menuKucukMu = false;
        private void bMenuKucult_Click(object sender, EventArgs e)
        {
            if (menuKucukMu)
            {
                // Men�y� geni�let
                bMenuBuyult.Visible = false;
                panelMenu.Width = 200;
                menuKucukMu = false;
            }
            else
            {
                // Men�y� k���lt
                panelMenu.Width = 0;
                menuKucukMu = true;
                bMenuBuyult.Visible = true;
            }
        }

        private void bMenuBuyult_Click(object sender, EventArgs e)
        {
            if (menuKucukMu)
            {
                // Men�y� geni�let
                bMenuBuyult.Visible = false;
                panelMenu.Width = 200;
                menuKucukMu = false;
            }
            else
            {
                // Men�y� k���lt
                panelMenu.Width = 0;
                menuKucukMu = true;
                bMenuBuyult.Visible = true;
            }
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form formCalisanlar = Application.OpenForms["formCalisanlar"];
            if (formCalisanlar != null)
            {
                formCalisanlar.Dispose();
            }
            e.Cancel = false;
        }

        private void bAdmin_Click(object sender, EventArgs e)
        {
            FormAdminGiris formAdminGiris = new FormAdminGiris(this);
            this.Hide();
            formAdminGiris.Show();
        }

        private void bAdminCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("��k�� yapmak istedi�inize emin misiniz?", "��k��", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                bAdminCikis.Visible = false;
                isAdminLoggedIn = false;
                bRYonet.Enabled = false;
                MessageBox.Show("Admin ��k��� ba�ar�yla ger�ekle�tirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bRYonet_Click(object sender, EventArgs e)
        {
            //formRandevuYonet = new FormRandevuYonet(this, randevular);
            formRandevuYonet = new FormRandevuYonet(this, calisanRandevular);
            this.Hide();
            formRandevuYonet.Show();
        }


        private Dictionary<DateTime, List<string>> alinanRandevular = new Dictionary<DateTime, List<string>>();

        public void RandevuEkle(string calisan, DateTime tarih, string saat, string musteriAdi, string musteriSoyadi, string musteriTelefon, string musteriEmail, List<string> hizmetler, int toplamUcret)
        {
            if (!alinanRandevular.ContainsKey(tarih))
            {
                alinanRandevular[tarih] = new List<string>();
            }
            alinanRandevular[tarih].Add(saat);

            Randevu randevu = new Randevu(calisan, tarih, saat, musteriAdi, musteriSoyadi, musteriTelefon, musteriEmail, hizmetler, toplamUcret);
            //randevular.Add(randevu);
            calisanRandevular[calisan].Add(randevu);

            // Randevu bilgilerini bir metin dosyas�na kaydet
            string dosyaYolu = @"E:\Visual Studio source-repos\C#ProjeDeneme1\C#ProjeDeneme1\randevular.txt";
            string randevuBilgisi = $"{calisan};{tarih.ToShortDateString()};{saat};{musteriAdi};{musteriSoyadi};{musteriTelefon};{musteriEmail};{string.Join(",", hizmetler)};{toplamUcret}";
            File.AppendAllText(dosyaYolu, randevuBilgisi + Environment.NewLine);

        }

        public bool RandevuVarMi(string calisan, DateTime tarih, string saat)
        {
            if (string.IsNullOrEmpty(calisan) || !calisanRandevular.ContainsKey(calisan))
            {
                return false;
            }
            return calisanRandevular[calisan].Any(r => r.Tarih == tarih && r.Saat == saat);
        }

        private void comboBoxCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenCalisan = comboBoxCalisanlar.SelectedItem.ToString();
            DateTime secilenTarih = dateTimePicker1.Value.Date;

            TimePickerGuncelle(secilenCalisan, secilenTarih);
            dateTimePicker1_ValueChanged(dateTimePicker1, EventArgs.Empty);
        }

        private void TimePickerGuncelle(string calisan, DateTime tarih)
        {
            // T�m saatleri temizle
            timePicker.Items.Clear();

            // T�m saatleri ekle
            DateTime time = DateTime.Today.AddHours(9); // Ba�lang�� saati
            while (time <= DateTime.Today.AddHours(18)) // Biti� saati
            {
                timePicker.Items.Add(time.ToString("HH:mm")); // Saati ComboBox'a ekle
                time = time.AddMinutes(30); // Saati 30 dakika art�r
            }

            // Belirli bir tarihteki t�m randevular� al
            var randevular = calisanRandevular[calisan].Where(r => r.Tarih.Date == tarih.Date).ToList();

            // Her bir randevu i�in
            foreach (var randevu in randevular)
            {
                // Randevunun saati timePicker'da varsa
                if (timePicker.Items.Contains(randevu.Saat))
                {
                    // Saati "Dolu" olarak i�aretle
                    int index = timePicker.Items.IndexOf(randevu.Saat);
                    timePicker.Items[index] = randevu.Saat + " - Dolu";
                }
            }
        }
    }
}

public class Randevu
{
    public DateTime Tarih { get; set; }
    public string Saat { get; set; }
    public string MusteriAdi { get; set; }
    public string MusteriSoyadi { get; set; }
    public string MusteriTelefon { get; set; }
    public string MusteriEmail { get; set; }
    public string Calisan { get; set; }
    public List<string> Hizmetler { get; set; }
    public int ToplamUcret { get; set; }

    public string HizmetlerString
    {
        get { return string.Join(", ", Hizmetler); }
    }


    public Randevu(string calisan, DateTime tarih, string saat, string musteriAdi, string musteriSoyadi, string musteriTelefon, string musteriEmail, List<string> hizmetler, int toplamUcret)
    {
        Tarih = tarih;
        Saat = saat;
        MusteriAdi = musteriAdi;
        MusteriSoyadi = musteriSoyadi;
        MusteriTelefon = musteriTelefon;
        MusteriEmail = musteriEmail;
        Calisan = calisan;
        Hizmetler = hizmetler;
        ToplamUcret = toplamUcret;
    }
}