using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13253013_HW03
{
    public partial class Form1 : Form
    {
        Ogrenci ogr;
        public ArrayList liste = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) ///aynı dersi bir daha seçmiyor.
        {
            string ders1 = ders1Giris.SelectedIndex.ToString();
            string ders2 = ders2Giris.SelectedIndex.ToString();
            string ders3 = ders3Giris.SelectedIndex.ToString();
            if (ders1 == ders2 || ders1 == ders3)
            {
                ders1Giris.SelectedIndex = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.DarkBlue;
            ders1Giris.Items.Add("");
            ders1Giris.Items.Add("Fizik");
            ders1Giris.Items.Add("Ayrık");
            ders1Giris.Items.Add("Matematik");
            ders1Giris.Items.Add("İngilizce");
            ders1Giris.Items.Add("Resim");
            ders2Giris.Items.Add("");
            ders2Giris.Items.Add("Fizik");
            ders2Giris.Items.Add("Ayrık");
            ders2Giris.Items.Add("Matematik");
            ders2Giris.Items.Add("İngilizce");
            ders2Giris.Items.Add("Resim");
            ders3Giris.Items.Add("");
            ders3Giris.Items.Add("Fizik");
            ders3Giris.Items.Add("Ayrık");
            ders3Giris.Items.Add("Matematik");
            ders3Giris.Items.Add("İngilizce");
            ders3Giris.Items.Add("Resim");

            this.FormBorderStyle = FormBorderStyle.FixedSingle;  ///form sabit kalıyo

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (numaraGiris.Text == "" || (isimGiris.Text) == "" || (bolumGiris.Text) == "" || ders1Giris.Text == "" || ders2Giris.Text == "" || ders3Giris.Text == "" || (ders1Giris.SelectedItem) == "" || (ders2Giris.SelectedItem) == "" || (ders3Giris.SelectedItem) == "" || (sınavsonucu1Giris.Text) == "" || (sınavsonucu2Giris.Text) == "" || (sınavsonucu3Giris.Text) == "")
                {
                    MessageBox.Show("Boş Alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    ogr = new Ogrenci(isimGiris.Text, int.Parse(numaraGiris.Text), bolumGiris.Text, ders1Giris.Text, int.Parse(sınavsonucu1Giris.Text), ders2Giris.Text, int.Parse(sınavsonucu2Giris.Text), ders3Giris.Text, int.Parse(sınavsonucu3Giris.Text));
                    liste.Add(ogr); ///arraylliste ekledim.....
                    MessageBox.Show("Ögrenci Bilgileri Sisteme Eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    groupBox1.Visible = true;
                   

                }

            }
            catch (Exception)
            {
                groupBox1.Visible = false;
                MessageBox.Show("EKleme İşlemi Başarısız.Girilen Bilgileri Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_Click(object sender, EventArgs e)
        {


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DersAdıArama_TextChanged(object sender, EventArgs e)
        {
            if (dersAdıArama.Text == "")
            {
                dersegorelistbox.Items.Clear();
            }
        }

        private void DersAdıArama_Click(object sender, EventArgs e)
        {
            dersAdıArama.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BolümAdıArama_Click(object sender, EventArgs e)
        {
            BolümAdıArama.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }
        private void sınavsonucu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void isimGiris_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dersAra_Click(object sender, EventArgs e)
        {
            dersegorelistbox.Visible = true;

            if (altmısdanKucukbuton.Checked == true)
            {
                altımsdanKucuk();
            }
            if (dersAramaButonu.Checked == true)
            {

                derseKayıtlıOgrencıOrtalama();
            }

            if (dersAdıArama.Text == "")
            {

                MessageBox.Show("Lütfen Bir Ders Adı Giriniz:", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void numaraAra_Click(object sender, EventArgs e)
        {
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void isimAra_Click(object sender, EventArgs e)
        {
        }

        private void temizleButon_Click(object sender, EventArgs e)  ///textboxları temizleme
        {
            numaraGiris.Text = "";
            isimGiris.Text = "";
            bolumGiris.Text = "";
            ders1Giris.Text = "";
            ders2Giris.Text = "";
            ders3Giris.Text = "";
            sınavsonucu1Giris.Text = "";
            sınavsonucu2Giris.Text = "";
            sınavsonucu3Giris.Text = "";
        }

        public void bolumeKayitliOgrenci()  ///bölüme kayıtlı ögrenciler
        {
            int sayac = 0;
            float toplam = 0;

            for (int i = 0; i < liste.Count; i++)
            {
                if (BolümAdıArama.Text == ((Ogrenci)liste[i]).bölüm)
                {
                    sayac++;
                    toplam += (((Ogrenci)liste[i]).Not1 + ((Ogrenci)liste[i]).Not2 + ((Ogrenci)liste[i]).Not3);
                }

            }
            bolumlistbox.Items.Add("Bölüme Kayıtlı Öğrenci Sayısı:" + " " + sayac + " Bölüm Ortalaması:" + " " + toplam / sayac);

        }

        private void bolumArama_Click(object sender, EventArgs e)
        {
            bolumlistbox.Visible = true;
            bolumeKayitliOgrenci();
        }

        public void altımsdanKucuk()  ///altmıştan küçük notlar
        {
            for (int i = 0; i < liste.Count; i++)
            {
                if (dersAdıArama.Text == ((Ogrenci)liste[i]).ders1)
                {
                    if (((Ogrenci)liste[i]).Not1 < 60)
                    {
                        dersegorelistbox.Items.Add("NO:" + " " + ((Ogrenci)liste[i]).Numara + "  " + "İsim :" + " " + ((Ogrenci)liste[i]).isim + " " + "Notu:" + " " + ((Ogrenci)liste[i]).Not1);
                    }
                }
                if (dersAdıArama.Text == ((Ogrenci)liste[i]).ders2)
                {
                    if (((Ogrenci)liste[i]).Not2 < 60)
                    {
                        dersegorelistbox.Items.Add("NO:" + " " + ((Ogrenci)liste[i]).Numara + "  " + "İsim :" + " " + ((Ogrenci)liste[i]).isim + " " + "Notu:" + " " + ((Ogrenci)liste[i]).Not2);
                    }
                }
                if (dersAdıArama.Text == ((Ogrenci)liste[i]).ders3)
                {
                    if (((Ogrenci)liste[i]).Not3 < 60)
                    {
                        dersegorelistbox.Items.Add("NO:" + " " + ((Ogrenci)liste[i]).Numara + "  " + "İsim :" + " " + ((Ogrenci)liste[i]).isim + " " + "Notu:" + " " + ((Ogrenci)liste[i]).Not3);
                    }
                }

            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void altmısdanKucuk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numarayagorearama_TextChanged(object sender, EventArgs e)
        {

        }

        private void ismegöre_TextChanged(object sender, EventArgs e)
        {

        }

        private void enYuksek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BolümAdıArama_TextChanged(object sender, EventArgs e)
        {
            if (BolümAdıArama.Text == "")
            {
                bolumlistbox.Items.Clear();
            }
        }

        private void ders2Giris_SelectedIndexChanged(object sender, EventArgs e) //ikinci kez aynı dersi seçmiyor
        {
            string ders1 = ders1Giris.SelectedIndex.ToString();
            string ders2 = ders2Giris.SelectedIndex.ToString();
            string ders3 = ders3Giris.SelectedIndex.ToString();
            if (ders2 == ders1 || ders2 == ders3)
            {
                ders2Giris.SelectedIndex = 0;
            }


        }

        private void ders3Giris_SelectedIndexChanged(object sender, EventArgs e) //ikinci kez aynı dersi seçmiyor..
        {
            string ders1 = ders1Giris.SelectedIndex.ToString();
            string ders2 = ders2Giris.SelectedIndex.ToString();
            string ders3 = ders3Giris.SelectedIndex.ToString();
            if (ders3 == ders1 || ders3 == ders2)
            {
                ders3Giris.SelectedIndex = 0;
            }
        }

        public void derseKayıtlıOgrencıOrtalama()  ///derse kayıtlı ögrenci sayısını ve ortalamasını buluyor
        {
            int sayac = 0;
            double toplam = 0;

            for (int i = 0; i < liste.Count; i++)
            {
                if (dersAdıArama.Text == ((Ogrenci)liste[i]).ders1 || dersAdıArama.Text == ((Ogrenci)liste[i]).ders2 || dersAdıArama.Text == ((Ogrenci)liste[i]).ders3)
                {
                    sayac++;
                }

            }
            dersegorelistbox.Items.Add("Derse Kayıtlı Öğrenci Sayısı:" + "" + sayac);
            for (int i = 0; i < liste.Count; i++)
            {
                if (dersAdıArama.Text == ((Ogrenci)liste[i]).ders1)
                {
                    toplam += ((Ogrenci)liste[i]).Not1;
                }
                else if (dersAdıArama.Text == ((Ogrenci)liste[i]).ders2)
                {
                    toplam += ((Ogrenci)liste[i]).Not2;
                }
                else if (dersAdıArama.Text == ((Ogrenci)liste[i]).ders3)
                {
                    toplam += ((Ogrenci)liste[i]).Not3;
                }
            }
            dersegorelistbox.Items.Add("Dersin Sınav Sonuc Ortalaması:" + " " + toplam / sayac);
        }

        public void isimNumarayaArama() //isim ve numaraya göre arama işlemi yapıyor...
        {
            int sayac = 0;
            float toplam = 0;

            for (int i = 0; i < liste.Count; i++)
            {
                if (textBoxisimArama.Text == ((Ogrenci)liste[i]).isim && int.Parse(textboxnumara.Text) == ((Ogrenci)liste[i]).Numara)
                {
                    listBox1.Items.Add(((Ogrenci)liste[i]).ders1 + "   " + ((Ogrenci)liste[i]).Not1);
                    toplam += ((Ogrenci)liste[i]).Not1;
                    sayac++;

                    listBox1.Items.Add(((Ogrenci)liste[i]).ders2 + "   " + ((Ogrenci)liste[i]).Not2);
                    toplam += ((Ogrenci)liste[i]).Not2;
                    sayac++;

                    listBox1.Items.Add(((Ogrenci)liste[i]).ders3 + "   " + ((Ogrenci)liste[i]).Not3);
                    toplam += ((Ogrenci)liste[i]).Not3;
                    sayac++;
                }

                if (textBoxisimArama.Text != ((Ogrenci)ogr).isim || int.Parse(textboxnumara.Text) != ((Ogrenci)ogr).Numara)
                    if (DialogResult.OK == MessageBox.Show("Aranılan İsim Ve Numaraya Ait Öğrenci Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error))
                    {


                    }
            }
            listBox1.Items.Add("Ögrencinin Aldığı Ders Sayısı:" + "  " + sayac);
            listBox1.Items.Add("Öğrencinin Ortalaması:" + "  " + toplam / sayac);

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            isimNumarayaArama();
            listBox1.Visible = true;
        }

        private void labelİsim_Click(object sender, EventArgs e)
        {

        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            textboxnumara.Text = "";
            textBoxisimArama.Text = "";
        }

        public void enMaxSinavSonucu() //fizik için en yüksek notu bulan method
        {
            int maxNot = 0;
            int sayac = 0;
            if (radioButtonfizik.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1 == "Fizik")
                    {
                        if (((Ogrenci)liste[i]).Not1 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not1;

                        }
                    }
                    if (((Ogrenci)liste[i]).ders2 == "Fizik")
                    {
                        if (((Ogrenci)liste[i]).Not2 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not2;

                        }
                    }
                    if (((Ogrenci)liste[i]).ders3 == "Fizik")
                    {
                        if (((Ogrenci)liste[i]).Not3 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not3;

                        }
                    }
                }

                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1 == "Fizik" && maxNot == ((Ogrenci)liste[i]).Not1)
                    {
                        sayac++;
                    }
                    if (((Ogrenci)liste[i]).ders2 == "Fizik" && maxNot == ((Ogrenci)liste[i]).Not2)
                    {
                        sayac++;
                    }
                    if (((Ogrenci)liste[i]).ders3 == "Fizik" && maxNot == ((Ogrenci)liste[i]).Not3)
                    {
                        sayac++;
                    }
                }
                for (int i = 0; i < sayac; i++)
                {
                    listBoxMax.Items.Add(maxNot);
                }

            }
        }

        public void genelOrtalama()
        {
            int sayac = 0;
            int ort = 0;
            int[] diziOrt = new int[liste.Count];
            int[] no = new int[liste.Count];
            int toplam = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                sayac = 0;
                toplam = 0;
                if (((Ogrenci)liste[i]).ders1 != ((Ogrenci)liste[i]).ders2 && ((Ogrenci)liste[i]).ders1 != ((Ogrenci)liste[i]).ders3 && ((Ogrenci)liste[i]).ders2 != ((Ogrenci)liste[i]).ders3)
                {
                    sayac = sayac + 3;

                }
                toplam += ((Ogrenci)liste[i]).Not1 + ((Ogrenci)liste[i]).Not2 + ((Ogrenci)liste[i]).Not3;
                ort = toplam / sayac;
                diziOrt[i] = ort;

            }
            //diziyi sırala
            int min;
            for (int i = 0; i < diziOrt.Length; i++)
            {
                for (int j = i + 1; j < diziOrt.Length; j++)
                {
                    if (diziOrt[j] < diziOrt[i])
                    {
                        min = diziOrt[i];
                        diziOrt[i] = diziOrt[j];

                        diziOrt[j] = min;
                    }
                }

            }

            for (int i = 0; i < liste.Count; i++)
            {
                for (int j = 0; j < liste.Count; j++)
                {
                    if (diziOrt[i] == (((Ogrenci)liste[j]).Not1 + ((Ogrenci)liste[j]).Not2 + ((Ogrenci)liste[j]).Not3) / sayac)
                    {
                        listBox2.Items.Add("Numara:" + " " + ((Ogrenci)liste[j]).Numara + " " + " İsim:" + " " + ((Ogrenci)liste[j]).isim + " " + " Genel Ortalama:" + " " + diziOrt[i]);
                    }
                }
            }
        }

        public void maxAyrık() ///max ayrık notu 
        {
            int maxNot = 0;
            int sayac = 0;
            if (radioButtonayrık.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1 == "Ayrık")
                    {
                        if (((Ogrenci)liste[i]).Not1 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not1;

                        }
                    }
                    if (((Ogrenci)liste[i]).ders2 == "Ayrık")
                    {
                        if (((Ogrenci)liste[i]).Not2 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not2;

                        }
                    }
                    if (((Ogrenci)liste[i]).ders3 == "Ayrık")
                    {
                        if (((Ogrenci)liste[i]).Not3 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not3;

                        }
                    }
                }

                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1 == "Ayrık" && maxNot == ((Ogrenci)liste[i]).Not1)
                    {
                        sayac++;
                    }
                    if (((Ogrenci)liste[i]).ders2 == "Ayrık" && maxNot == ((Ogrenci)liste[i]).Not2)
                    {
                        sayac++;
                    }
                    if (((Ogrenci)liste[i]).ders3 == "Ayrık" && maxNot == ((Ogrenci)liste[i]).Not3)
                    {
                        sayac++;
                    }
                }
                for (int i = 0; i < sayac; i++)
                {
                    listBoxMax.Items.Add(maxNot);
                }

            }


        }

        public void maxMatematik() ///max matematik notu
        {
            int maxNot = 0;
            int sayac = 0;
            if (radioButtonmatematik.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1 == "Matematik")
                    {
                        if (((Ogrenci)liste[i]).Not1 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not1;

                        }
                    }
                    if (((Ogrenci)liste[i]).ders2 == "Matematik")
                    {
                        if (((Ogrenci)liste[i]).Not2 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not2;

                        }
                    }
                    if (((Ogrenci)liste[i]).ders3 == "Matematik")
                    {
                        if (((Ogrenci)liste[i]).Not3 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not3;

                        }
                    }
                }
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1 == "Matematik" && maxNot == ((Ogrenci)liste[i]).Not1)
                    {
                        sayac++;
                    }
                    if (((Ogrenci)liste[i]).ders2 == "Matematik" && maxNot == ((Ogrenci)liste[i]).Not2)
                    {
                        sayac++;
                    }
                    if (((Ogrenci)liste[i]).ders3 == "Matematik" && maxNot == ((Ogrenci)liste[i]).Not3)
                    {
                        sayac++;
                    }
                }

                for (int i = 0; i < sayac; i++)
                {
                    listBoxMax.Items.Add(maxNot);
                }
            }

        }

        public void maxIngilizce()  //max ingilizce
        {
            int maxNot = 0;
            int sayac = 0;
            if (radioButtoningilizce.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1 == "İngilizce")
                    {
                        if (((Ogrenci)liste[i]).Not1 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not1;
                        }
                    }
                    if (((Ogrenci)liste[i]).ders2 == "İngilizce")
                    {
                        if (((Ogrenci)liste[i]).Not2 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not2;

                        }
                    }
                    if (((Ogrenci)liste[i]).ders3 == "İngilizce")
                    {
                        if (((Ogrenci)liste[i]).Not3 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not3;

                        }
                    }
                }

                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1 == "İngilizce" && maxNot == ((Ogrenci)liste[i]).Not1)
                    {
                        sayac++;
                    }

                    if (((Ogrenci)liste[i]).ders2 == "İngilizce" && maxNot == ((Ogrenci)liste[i]).Not2)
                    {
                        sayac++;
                    }
                    if (((Ogrenci)liste[i]).ders3 == "İngilizce" && maxNot == ((Ogrenci)liste[i]).Not3)
                    {
                        sayac++;
                    }
                }
                for (int i = 0; i < sayac; i++)
                {
                    listBoxMax.Items.Add(maxNot);
                }

            }
        }
        public void maxResim() //max resim notu
        {
            int maxNot = 0;
            int sayac = 0;
            if (radioButtonresim.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1 == "Resim")
                    {
                        if (((Ogrenci)liste[i]).Not1 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not1;

                        }
                    }
                    if (((Ogrenci)liste[i]).ders2 == "Resim")
                    {
                        if (((Ogrenci)liste[i]).Not2 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not2;

                        }
                    }
                    if (((Ogrenci)liste[i]).ders3 == "Resim")
                    {
                        if (((Ogrenci)liste[i]).Not3 > maxNot)
                        {
                            maxNot = ((Ogrenci)liste[i]).Not3;

                        }
                    }
                }
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1 == "Resim" && maxNot == ((Ogrenci)liste[i]).Not1)
                    {
                        sayac++;
                    }
                    if (((Ogrenci)liste[i]).ders2 == "Resim" && maxNot == ((Ogrenci)liste[i]).Not2)
                    {
                        sayac++;
                    }
                    if (((Ogrenci)liste[i]).ders3 == "Resim" && maxNot == ((Ogrenci)liste[i]).Not3)
                    {
                        sayac++;
                    }
                }
                for (int i = 0; i < sayac; i++)
                {
                    listBoxMax.Items.Add(maxNot);
                }
            }
        }
        private void radioButtonfizik_CheckedChanged(object sender, EventArgs e)
        {
            //listBoxMax.Visible = true;
            // enMaxSinavSonucu();

        }

        private void radioButtonayrık_CheckedChanged(object sender, EventArgs e)
        {
            // listBoxMax.Visible = true;
            // maxAyrık();

        }

        private void radioButtonmatematik_CheckedChanged(object sender, EventArgs e)
        {
            //listBoxMax.Visible = true;
            //maxMatematik();


        }

        private void radioButtoningilizce_CheckedChanged(object sender, EventArgs e)
        {
            //listBoxMax.Visible = true;
            //maxIngilizce();


        }

        private void radioButtonresim_CheckedChanged(object sender, EventArgs e)
        {
            //listBoxMax.Visible = true;
            //maxResim();

        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //   
        //}

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void bolumGiris_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox2.Visible = true;
            genelOrtalama();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            listBoxMax.Visible = true;
            if (radioButtonfizik.Checked == true)
            {
                enMaxSinavSonucu();
            }

            if (radioButtonayrık.Checked == true)
            {
                maxAyrık();
            }
            if (radioButtonmatematik.Checked == true)
            {
                maxMatematik();
            }
            if (radioButtoningilizce.Checked == true)
            {
                maxIngilizce();
            }
            if (radioButtonresim.Checked == true)
            {
                maxResim();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxMax.Items.Clear();

        }

        private void dersegorelistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
