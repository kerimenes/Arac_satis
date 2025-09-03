using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace proje_araç_satış
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2U1S01O\\SQLEXPRESS;Initial Catalog=araç_satış;Integrated Security=True");
        SqlCommand komut = new SqlCommand();

        //Aksesuar Fiyatlarının hesaplanması için sayaçlar
        int sayac1;
        int sayac2;
        int sayac3;
        int sayac4;
        int sayac5;
        int sayac6;
        int sayac7;
        int sayac8;
        int sayac9;
        
        private void BindComboBox()
        {
           
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            //Veri Tabanından gelen verilerin tanınması için
            comboBox1.ValueMember = "ArabaMarka";
            comboBox3.ValueMember = "ArabaModel";
            comboBox2.ValueMember = "ArabaMotor";
            comboBox4.ValueMember = "ArabaRenk";

            pictureBox1.ImageLocation = "Renault.png";

            // TODO: Bu kod satırı 'araç_satışDataSet.Renk' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.renkTableAdapter.Fill(this.araç_satışDataSet.Renk);
            // TODO: Bu kod satırı 'araç_satışDataSet.Motor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.motorTableAdapter.Fill(this.araç_satışDataSet.Motor);
            // TODO: Bu kod satırı 'araç_satışDataSet.Model' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.modelTableAdapter.Fill(this.araç_satışDataSet.Model);
            // TODO: Bu kod satırı 'araç_satışDataSet.Marka' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.markaTableAdapter.Fill(this.araç_satışDataSet.Marka);

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            
            Form3 anasyf = new Form3();
            anasyf.Show();
            Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen markanın logosunun ekrana yazdırılması.
            if (comboBox1.SelectedIndex==0)
            {
                pictureBox1.ImageLocation = "Renault.png";
            }
            else if (comboBox1.SelectedIndex==1)
            {
                pictureBox1.ImageLocation = "volkswagen.png";
            }
            else if (comboBox1.SelectedIndex==2)
            {
                pictureBox1.ImageLocation = "Audi.png";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Uygulamadan çıkış onayı
            DialogResult result1 = MessageBox.Show("Uygulamayı kapatmaya eminmisin?",
            "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        { 
            richTextBox1.Clear();

            int ekran, deri, camTavan, ses, ısıtmalı; //iç aksesuar tanımlamaları
            int yardım, kamera, jant, ayna; //dış aksesuar tanımlamaları
            

            ekran=1500; deri = 1000; camTavan = 2000; ses = 1000; ısıtmalı = 2000; //iç aksesuar fiyatları
            yardım = 5000; kamera = 1000; jant = 2000; ayna = 500; //dış aksesuar fiyatları

            double içaksesuar = (ekran * sayac1) + (deri * sayac2) + (camTavan * sayac3) + (ses * sayac4) + (ısıtmalı * sayac5); //sayaçlar ile birlikte fiyatların hesaplanması
            double dışaksesuar = (yardım * sayac6) + (kamera * sayac7) + (jant * sayac8) + (ayna * sayac9);  //sayaçlar ile birlikte fiyatların hesaplanması

            // Seçilen aracın Özelliklerinin ve fiyatlarının ekrana yazdırılması
            richTextBox1.SelectedText = ("-------------------------------------------------" + Environment.NewLine);
            richTextBox1.SelectedText = ("\t" + "OtoGaleri" + Environment.NewLine);
            richTextBox1.SelectedText = ("-------------------------------------------------" + Environment.NewLine);
            richTextBox1.SelectedText = Environment.NewLine + "Marka: " + comboBox1.SelectedValue;
            richTextBox1.SelectedText = Environment.NewLine + "Model: " + comboBox3.SelectedValue;
            richTextBox1.SelectedText = Environment.NewLine + "Motor: " + comboBox2.SelectedValue;
            richTextBox1.SelectedText = Environment.NewLine + "Renk: " + comboBox4.SelectedValue;

            //Veri tabanından Başlangıç Fiyatının getirilmesi için gerekli satırlar.
            komut = new SqlCommand("SELECT * FROM Motor WHERE ArabaMotor ='" + comboBox2.Text + "'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {   
                // Veri Tabanında tanımlı olan Başlangıç Fiyatlarının seçilen comboBox'a göre getirilmesi.

                string BaşlangıçFiyat = dr["ArabaBaşlangıçFiyat"].ToString();
                richTextBox1.SelectedText = Environment.NewLine + "Ham Fiyat: " + BaşlangıçFiyat + "TL";
                
                int bf=Convert.ToInt32(BaşlangıçFiyat);
                string VergisizFiyat = (bf+içaksesuar+dışaksesuar).ToString();
                int VM = Convert.ToInt32(VergisizFiyat);
                double VergiM = (VM * 0.40);
                double SatışFiyatı = (VergiM + VM);
                richTextBox1.SelectedText = Environment.NewLine + "İç Aksesuar: " + içaksesuar.ToString() + "TL";
                richTextBox1.SelectedText = Environment.NewLine + "Dış Aksesuar: " + dışaksesuar.ToString() + "TL";
                richTextBox1.SelectedText = Environment.NewLine + "Vergisiz Fiyat: " + VergisizFiyat.ToString() + "TL";
                richTextBox1.SelectedText = Environment.NewLine + "Vergi Miktarı: " + VergiM.ToString() + "TL";
                richTextBox1.SelectedText = Environment.NewLine + "Satış Fiyatı: " + SatışFiyatı.ToString() + "TL";
            }
            baglanti.Close();
            
        }


        //İç aksesuar
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                sayac1++;
            }
            else
            {
                sayac1 = 0;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) 
            {
                sayac2++;
            }
            else
            { 
                sayac2 = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) 
            {
                sayac3++;
            }
            else
            {
                sayac3 = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                sayac4++;
            }
            else
            {
                sayac4 = 0;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                sayac5++;
            }
            else
            {
                sayac5 = 0;
            }
        }

        private void markaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        //Dış Aksesuar
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                sayac6++;
            }
            else
            {
                sayac6 = 0;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                sayac7++;
            }
            else
            {
                sayac7 = 0;
            }
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                sayac8++;
            }
            else
            {
                sayac8 = 0;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                sayac9++;
            }
            else
            {
                sayac9 = 0;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Araç Siparişiniz Başarıyla Tamamlandı!", "Araç Siparişi");

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";


            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(richTextBox1.Text);
            }
        }
    }
}