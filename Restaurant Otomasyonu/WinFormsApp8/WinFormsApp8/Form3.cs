using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp8
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SEK7GEB;Initial Catalog=Berkay Ay Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public Form3()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başlatılmıştır.");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from [MASA BİLGİLERİ]", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ID"].ToString());
                item.SubItems.Add(dr["MasaID"].ToString());
                item.SubItems.Add(dr["Kapasite"].ToString());
                item.SubItems.Add(dr["Durum"].ToString());
                item.SubItems.Add(dr["Rezervasyon_Durumu"].ToString());
                listView1.Items.Add(item);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.BackColor = Color.Turquoise;
            //MessageBox.Show("Bu masa şuanlık doludur.");
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show("Bu masa boş mu?", "Boş ise Evet Rezerve ise Hayır,Dolu ise lütfen İptale tıklayın", MessageBoxButtons.YesNoCancel);
            if(sorgu == DialogResult.Yes)
            {
                button1.ForeColor = Color.Chocolate;
            }
            if (sorgu == DialogResult.No) {
            
                button1.ForeColor = Color.Red;
            }
            else if (sorgu == DialogResult.Cancel) {
                button1.ForeColor = Color.Turquoise;
            }


            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bu masa 'REZERVE EDİLMEMİŞ' şekilde boştur.", "Masa 2");
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show("Bu masa boş mu?", "Boş ise Evet Rezerve ise Hayır,Dolu ise lütfen İptale tıklayın", MessageBoxButtons.YesNoCancel);
            if (sorgu == DialogResult.Yes)
            {
                button1.ForeColor = Color.Chocolate;
            }
            if (sorgu == DialogResult.No)
            {

                button1.ForeColor = Color.Red;
            }
            else if (sorgu == DialogResult.Cancel)
            {
                button1.ForeColor = Color.Turquoise;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bu masa 14:00'a kadar rezervedir");
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show("Bu masa boş mu?", "Boş ise Evet Rezerve ise Hayır,Dolu ise lütfen İptale tıklayın", MessageBoxButtons.YesNoCancel);
            if (sorgu == DialogResult.Yes)
            {
                button1.ForeColor = Color.Chocolate;
            }
            if (sorgu == DialogResult.No)
            {

                button1.ForeColor = Color.Red;
            }
            else if (sorgu == DialogResult.Cancel)
            {
                button1.ForeColor = Color.Turquoise;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bu masa yedek rezervededir fakat boştur.");
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show("Bu masa boş mu?", "Boş ise Evet Rezerve ise Hayır,Dolu ise lütfen İptale tıklayın", MessageBoxButtons.YesNoCancel);
            if (sorgu == DialogResult.Yes)
            {
                button1.ForeColor = Color.Chocolate;
            }
            if (sorgu == DialogResult.No)
            {

                button1.ForeColor = Color.Red;
            }
            else if (sorgu == DialogResult.Cancel)
            {
                button1.ForeColor = Color.Turquoise;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bu masa 'REZERVE EDİLMEMİŞ' şekilde boştur.");
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show("Bu masa boş mu?", "Boş ise Evet Rezerve ise Hayır,Dolu ise lütfen İptale tıklayın", MessageBoxButtons.YesNoCancel);
            if (sorgu == DialogResult.Yes)
            {
                button1.ForeColor = Color.Chocolate;
            }
            if (sorgu == DialogResult.No)
            {

                button1.ForeColor = Color.Red;
            }
            else if (sorgu == DialogResult.Cancel)
            {
                button1.ForeColor = Color.Turquoise;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bu masa 16:30'a kadar rezervedir.");
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show("Bu masa boş mu?", "Boş ise Evet Rezerve ise Hayır,Dolu ise lütfen İptale tıklayın", MessageBoxButtons.YesNoCancel);
            if (sorgu == DialogResult.Yes)
            {
                button1.ForeColor = Color.Chocolate;
            }
            if (sorgu == DialogResult.No)
            {

                button1.ForeColor = Color.Red;
            }
            else if (sorgu == DialogResult.Cancel)
            {
                button1.ForeColor = Color.Turquoise;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bu masa şuanlık doludur.");
            DialogResult sorgu = new DialogResult();
            sorgu = MessageBox.Show("Bu masa boş mu?", "Boş ise Evet Rezerve ise Hayır,Dolu ise lütfen İptale tıklayın", MessageBoxButtons.YesNoCancel);
            if (sorgu == DialogResult.Yes)
            {
                button1.ForeColor = Color.Chocolate;
            }
            if (sorgu == DialogResult.No)
            {

                button1.ForeColor = Color.Red;
            }
            else if (sorgu == DialogResult.Cancel)
            {
                button1.ForeColor = Color.Turquoise;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int sayac = listView1.Items.Count;
            listView1.Items.Add(textBox1.Text);
            listView1.Items[sayac].SubItems.Add(textBox2.Text);
            listView1.Items[sayac].SubItems.Add(textBox3.Text);
            listView1.Items[sayac].SubItems.Add(textBox4.Text);
            listView1.Items[sayac].SubItems.Add(textBox5.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = new DialogResult();
            //dialogResult = MessageBox.Show("Veriyi Silmek istediğinizden emin misiniz?", "Silme Uyarısı", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    listView1.SelectedItems[0].Remove();


            //}
            baglanti.Open();
            string secmeSorgusu = "SELECT * from [MASA BİLGİLERİ] where MasaID=@MasaID";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@MasaID", textBox2.Text);

            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();

            if (dr.Read())
            {
                string masaıd = dr["MasaID"].ToString() + " " + dr["Kapasite"].ToString();
                dr.Close();

                DialogResult durum = MessageBox.Show(masaıd + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from [MASA BİLGİLERİ] where MasaID=@MasaID";

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@MasaID", textBox2.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");

                }
            }
            else
                MessageBox.Show("Müşteri Bulunamadı.");
            baglanti.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into [MASA BİLGİLERİ](MasaID,Kapasite,Durum,Rezervasyon_Durumu) values (@MasaID,@Kapasite,@Durum,@Rezervasyon_Durumu)";

                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@MasaID", textBox2.Text);
                komut.Parameters.AddWithValue("@Kapasite", textBox3.Text);
                komut.Parameters.AddWithValue("@Durum", textBox4.Text);
                komut.Parameters.AddWithValue("@Rezervasyon_Durumu", textBox5.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }
    }

}
