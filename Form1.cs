/****************************************************************************
**					      SAKARYA ÜNÝVERSÝTESÝ
**				 BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				      BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					     2023-2024 BAHAR DÖNEMÝ
**
**
**
**		  ÖDEV NUMARASI.........:  Proje              Tarih..: 19.05.2024
**		  ÖÐRENCÝ ADI...........:  Özgür Demir
**		  ÖÐRENCÝ NUMARASI......:  B221210017
**        DERSÝN ALINDIÐI GRUP..:  C
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

            calisanRandevular.Add("Merve Þengül", new BindingList<Randevu>());
            calisanRandevular.Add("Esma Korkmaz", new BindingList<Randevu>());
            calisanRandevular.Add("Asiye Keskin", new BindingList<Randevu>());
            calisanRandevular.Add("Aynur Tekin", new BindingList<Randevu>());
            calisanRandevular.Add("Kadriye Güneþ", new BindingList<Randevu>());

            nameBox.MaxLength = 15;
            surnameBox.MaxLength = 15;
            maskedEmailBox.MaxLength = 30;

            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(30);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";


            timePicker.DrawMode = DrawMode.OwnerDrawFixed; // alýnmýþ saatleri farklý göstermek için çizim
            timePicker.DrawItem += new DrawItemEventHandler(timePicker_DrawItem);


            lMenu.Font = new Font("Arial", 18, FontStyle.Bold);
            lMenu.ForeColor = Color.Black;
            lMenu.TextAlign = ContentAlignment.MiddleCenter;


            ltutar.Text = "Toplam fiyat: " + tutar.ToString() + "TL";

            // Çalýþanlarý ComboBox'a ekle
            comboBoxCalisanlar.Items.Add("Merve Þengül");
            comboBoxCalisanlar.Items.Add("Esma Korkmaz");
            comboBoxCalisanlar.Items.Add("Asiye Keskin");
            comboBoxCalisanlar.Items.Add("Aynur Tekin");
            comboBoxCalisanlar.Items.Add("Kadriye Güneþ");
            comboBoxCalisanlar.SelectedIndex = -1; // Ýlk çalýþaný varsayýlan olarak seç


            this.Invalidate();
        }

        private FormRandevuYonet formRandevuYonet;
        //public BindingList<Randevu> randevular = new BindingList<Randevu>();

        private void bRandevuOnay_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || maskedPhoneBox.Text == "" || maskedEmailBox.Text == "" || dateTimePicker1.Value.ToShortDateString() == null || timePicker.SelectedItem == null || comboBoxCalisanlar.SelectedItem == null || tutar == 0)
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurunuz, veya seçmediyseniz hizmet(ler), randevu tarihi, saati ve hizmeti verecek çalýþaný seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (labelErrorMessage1.Visible || labelErrorMessage2.Visible)
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarasý ve e-posta adresi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Randevunuz alýnmýþtýr. Randevu Bilgileri:\n Randevu tutarý: " + tutar + "TL. Randevu tarihi: " + dateTimePicker1.Value.ToShortDateString(), "Randevu Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                    secilenHizmetler.Add("Saç Kesim");
                }
                if (checkBox2.Checked)
                {
                    secilenHizmetler.Add("Saç Yýkama");
                }
                if (checkBox3.Checked)
                {
                    secilenHizmetler.Add("Saç Boyama");
                }
                if (checkBox4.Checked)
                {
                    secilenHizmetler.Add("Kaþ Düzeltme");
                }
                if (checkBox5.Checked)
                {
                    secilenHizmetler.Add("Manikür");
                }
                if (checkBox6.Checked)
                {
                    secilenHizmetler.Add("Pediür");
                }
                if (checkBox7.Checked)
                {
                    secilenHizmetler.Add("Pasta ve Cila");
                }
                

                RandevuEkle(secilenCalisan, secilenTarih, secilenSaat, musteriAdi, musteriSoyadi, musteriTelefon, musteriEmail, secilenHizmetler, tutar);

                int secilenSaatIndex = timePicker.SelectedIndex;
                //alinanSaatler.Add(secilenSaat);
                timePicker.Items[secilenSaatIndex] = timePicker.Items[secilenSaatIndex] + " - Dolu";


                MessageBox.Show("Randevunuz onaylanmýþtýr. Randevu tarihiniz: " + dateTimePicker1.Value.ToShortDateString() + "\nLütfen randevu saatinizden 10-15 dakika önce iþ yerimizde olunuz.\nGeç gelmeniz durumunda ücret iadesi yapýlmaz", "Randevu Alma Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Randevu alma iþlemi iptal edilmiþtir.", "Randevu Ýptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Eðer girilen karakter bir harf deðilse ve kontrol karakteri deðilse, giriþi engelle
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void surnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eðer girilen karakter bir harf deðilse ve kontrol karakteri deðilse, giriþi engelle
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedEmailBox_Validating(object sender, EventArgs e)
        {
            string email = maskedEmailBox.Text;

            // E-posta adresi doðrulamasý için basit bir yöntem
            if (!EmailKontrol(email))
            {
                labelErrorMessage2.Visible = true;
                labelErrorMessage2.Text = "Geçerli bir e-posta adresi girin.";
                labelErrorMessage2.ForeColor = Color.Red;
                labelErrorMessage2.Font = new Font(labelErrorMessage2.Font, FontStyle.Bold);
                //MessageBox.Show("Geçerli bir e-posta adresi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //maskedEmailBox.Clear(); // Hatalý giriþi temizle
            }
            else
            {
                labelErrorMessage2.Visible = false; // Hata olmadýðýnda Label'ý gizle
                //labelErrorMessage2.Text = ""; // Uyarý mesajýný temizle
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
                labelErrorMessage1.Text = "Geçerli bir telefon numarasý girin.";
                labelErrorMessage1.ForeColor = Color.Red;
                labelErrorMessage1.Font = new Font(labelErrorMessage1.Font, FontStyle.Bold);
                //MessageBox.Show("Geçerli bir telefon numarasý girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //maskedPhoneBox.Clear(); // Hatalý giriþi temizle
            }
            else
            {
                labelErrorMessage1.Visible = false; // Hata olmadýðýnda Label'ý gizle
                //labelErrorMessage1.Text = ""; // Uyarý mesajýný temizle
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
            DateTime time = DateTime.Today.AddHours(9); // Baþlangýç saati
            while (time <= DateTime.Today.AddHours(18)) // Bitiþ saati
            {
                timePicker.Items.Add(time.ToString("HH:mm")); // Saati ComboBox'a ekle
                time = time.AddMinutes(30); // Saati 30 dakika artýr
            }
            timePicker.SelectedIndex = 0;
            dateTimePicker1_ValueChanged(dateTimePicker1, EventArgs.Empty);


            string dosyaYolu = @"E:\Visual Studio source-repos\C#ProjeDeneme1\C#ProjeDeneme1\randevular.txt";
            string[] randevuBilgileri = File.ReadAllLines(dosyaYolu);



            foreach (string randevuBilgisi in randevuBilgileri)
            {
                // Her bir satýrý parse ederek Randevu nesnesine dönüþtür
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

                // Randevuyu ilgili çalýþanýn listesine ekle
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
                //MessageBox.Show("Bu saat dolu. Lütfen baþka bir saat seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timePicker.SelectedIndex = -1; // Seçimi kaldýr
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime secilenTarih = dateTimePicker1.Value.Date;
            string secilenCalisan = comboBoxCalisanlar.SelectedItem != null ? comboBoxCalisanlar.SelectedItem.ToString() : "";

            // Saatleri yeniden yükle
            timePicker.Items.Clear();
            DateTime time = DateTime.Today.AddHours(9); // Baþlangýç saati
            TimeSpan delay = TimeSpan.FromMinutes(15); // Gecikme süresi
            while (time <= DateTime.Today.AddHours(18)) // Bitiþ saati
            {
                string saat = time.ToString("HH:mm");
                if ((secilenTarih == DateTime.Today && time.TimeOfDay < DateTime.Now.TimeOfDay + delay) || RandevuVarMi(secilenCalisan, secilenTarih, saat))
                {
                    // Bu saat dolu
                    saat += " - Dolu";
                }
                timePicker.Items.Add(saat); // Saati ComboBox'a ekle
                time = time.AddMinutes(30); // Saati 30 dakika artýr
            }
            timePicker.SelectedIndex = 0;
        }

        private void timePicker_DrawItem(object sender, DrawItemEventArgs e) // ComboBox'ta çizim yap
        {
            /// Bu tasarýmla metin gri olur ve italik yazýlýr
            /// 

            //if (e.Index < 0) return; // Hiçbir öðe seçili deðilse çýk

            //// Seçili öðenin metnini al
            //string text = ((ComboBox)sender).Items[e.Index].ToString();

            //// Metin "Dolu" içeriyorsa, öðeyi gri ve italik yaz
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

            if (e.Index < 0) return; // Hiçbir öðe seçili deðilse çýk

            if (sender is ComboBox comboBox && e.Index >= 0)
            {
                object item = comboBox.Items[e.Index];
                if (item != null)
                {
                    // Seçili öðenin metnini al
                    string text = item.ToString();

                    // Metin "Dolu" içeriyorsa, öðenin arka planýný kýrmýzý yap
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
        #region Menu Küçült Büyült
        private bool menuKucukMu = false;
        private void bMenuKucult_Click(object sender, EventArgs e)
        {
            if (menuKucukMu)
            {
                // Menüyü geniþlet
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
                // Menüyü geniþlet
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
            DialogResult sonuc = MessageBox.Show("Çýkýþ yapmak istediðinize emin misiniz?", "Çýkýþ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                bAdminCikis.Visible = false;
                isAdminLoggedIn = false;
                bRYonet.Enabled = false;
                MessageBox.Show("Admin çýkýþý baþarýyla gerçekleþtirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // Randevu bilgilerini bir metin dosyasýna kaydet
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
            // Tüm saatleri temizle
            timePicker.Items.Clear();

            // Tüm saatleri ekle
            DateTime time = DateTime.Today.AddHours(9); // Baþlangýç saati
            while (time <= DateTime.Today.AddHours(18)) // Bitiþ saati
            {
                timePicker.Items.Add(time.ToString("HH:mm")); // Saati ComboBox'a ekle
                time = time.AddMinutes(30); // Saati 30 dakika artýr
            }

            // Belirli bir tarihteki tüm randevularý al
            var randevular = calisanRandevular[calisan].Where(r => r.Tarih.Date == tarih.Date).ToList();

            // Her bir randevu için
            foreach (var randevu in randevular)
            {
                // Randevunun saati timePicker'da varsa
                if (timePicker.Items.Contains(randevu.Saat))
                {
                    // Saati "Dolu" olarak iþaretle
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