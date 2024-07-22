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
    public partial class Form6 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SEK7GEB;Initial Catalog=Berkay Ay Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from [Z RAPORU BİLGİLERİ]", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ID"].ToString());
                item.SubItems.Add(dr["Rapor_Tarihi"].ToString());
                item.SubItems.Add(dr["Toplam_Satis"].ToString());
                item.SubItems.Add(dr["İslem_Sayisi"].ToString());
                listView1.Items.Add(item);
            }
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            int sayac = listView1.Items.Count;
            listView1.Items.Add(textBox1.Text);
            listView1.Items[sayac].SubItems.Add(textBox2.Text);
            listView1.Items[sayac].SubItems.Add(textBox3.Text);
            listView1.Items[sayac].SubItems.Add(textBox4.Text);
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }

            else MessageBox.Show("Kayıt Tamamlandı.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = new DialogResult();
            //dialogResult = MessageBox.Show("Veriyi Silmek istediğinizden emin misiniz?", "Silme Uyarısı", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    listView1.SelectedItems[0].Remove();


            //}
            baglanti.Open();
            string secmeSorgusu = "SELECT * from [Z RAPORU BİLGİLERİ] where Rapor_Tarihi=@RaporTarihi";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@RaporTarihi", textBox2.Text);

            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();

            if (dr.Read())
            {
                string raporıd = dr["Rapor_Tarihi"].ToString() + " " + dr["Toplam_Satis"].ToString();
                dr.Close();

                DialogResult durum = MessageBox.Show(raporıd + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from [Z RAPORU BİLGİLERİ] where Rapor_Tarihi=@RaporTarihi";

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@RaporTarihi", textBox2.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand VeriKaydet = new SqlCommand("insert into [Z RAPORU BİLGİLERİ] (Rapor_Tarihi,Toplam_Satis,İslem_Sayisi) values(@RaporTarihi,@ToplamSatis,@İslemSayisi)", baglanti);
                //VeriKaydet.CommandText = "SET IDENTITY_INSERT [Z RAPORU BİLGİLERİ] ON";
                //VeriKaydet.CommandText +=
                //VeriKaydet.Parameters.AddWithValue("@ID", textBox1.Text);
                VeriKaydet.Parameters.AddWithValue("@RaporTarihi", textBox2.Text);
                VeriKaydet.Parameters.AddWithValue("@ToplamSatis", textBox3.Text);
                VeriKaydet.Parameters.AddWithValue("@İslemSayisi", textBox4.Text);
                VeriKaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Veri Eklendi");
            }
            catch
            {
                MessageBox.Show("Kayıt Eklendi.");
            }

        }
    }
}
