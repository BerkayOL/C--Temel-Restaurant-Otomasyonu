using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Windows.Forms;
using System.Reflection.Metadata.Ecma335;
using System.Drawing.Text;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
namespace WinFormsApp8
{
    public partial class Form4 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SEK7GEB;Initial Catalog=Berkay Ay Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }
        //public void BilgiEkle()
        //{

        //    baglanti.Open();
        //    string kayit = "insert into sprs (ID,SiparisID,MasaID,Siparis_Zamani,Ürünler_Adetler,Toplam_Tutar) values (" + columnHeader13.Text + ",'" + columnHeader7.Text + "','" + columnHeader8.Text + "','" + columnHeader9.Text + "','" + columnHeader9.Text + "','" + columnHeader11.Text + "','" + columnHeader12.Text + "')";
        //    SqlCommand ekle = new SqlCommand(kayit, baglanti);
        //    ekle.CommandText = "SET IDENTITY_INSERT dbo.sprs ON";
        //    ekle.CommandText +=
        //    ekle.Parameters.AddWithValue("@ID", columnHeader13.Text);
        //    ekle.Parameters.AddWithValue("@SiparisID", columnHeader7.Text);
        //    ekle.Parameters.AddWithValue("@MasaID", columnHeader8.Text);
        //    ekle.Parameters.AddWithValue("@Siparis_Zamani", columnHeader9.Text);
        //    ekle.Parameters.AddWithValue("@Ürünler_Adetler", columnHeader11.Text);
        //    ekle.Parameters.AddWithValue("@Toplam_Tutar", columnHeader12.Text);
        //    ekle.ExecuteNonQuery();
        //    baglanti.Close();

        //}
        //private int _ID;
        //private int siparisID;
        //private int masaID;
        //private string siparis_Zamani;
        //private string ürünler_Adetler;
        //private int toplam_Tutar;


        //public int SiparisID { get => siparisID; set => siparisID = value; }
        //public int MasaID { get => masaID; set => masaID = value; }
        //public string Siparis_Zamani { get => siparis_Zamani; set => siparis_Zamani = value; }
        //public string Ürünler_Adetler { get => ürünler_Adetler; set => ürünler_Adetler = value; }
        //public int Toplam_Tutar { get => toplam_Tutar; set => toplam_Tutar = value; }
        //public int ID { get => _ID; set => _ID = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            //BilgiEkle();
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from sprs", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ID"].ToString());
                item.SubItems.Add(dr["SiparisID"].ToString());
                item.SubItems.Add(dr["MasaID"].ToString());
                item.SubItems.Add(dr["Siparis_Zamani"].ToString());
                item.SubItems.Add(dr["Ürünler_Adetler"].ToString());
                item.SubItems.Add(dr["Toplam_Tutar"].ToString());
                listView2.Items.Add(item);
            }
            baglanti.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listView2.FullRowSelect = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //int ID, SiparisID, MasaID,ÜrünAdet,ToplamTutar;
            //string SiparisZamani;
            //ID = Convert.ToInt32(textBox5.Text);
            //SiparisID = Convert.ToInt32(textBox2.Text);
            //MasaID= Convert.ToInt32(textBox3.Text);
            //SiparisZamani = Convert.ToString(dateTimePicker1.Text);
            //ÜrünAdet = Convert.ToInt32(textBox4.Text);
            //ToplamTutar = Convert.ToInt32(textBox6.Text);
            int sayac = listView2.Items.Count;
            listView2.Items.Add(textBox5.Text);
            listView2.Items[sayac].SubItems.Add(textBox2.Text);
            listView2.Items[sayac].SubItems.Add(textBox3.Text);
            listView2.Items[sayac].SubItems.Add(textBox1.Text);
            listView2.Items[sayac].SubItems.Add(textBox4.Text);
            listView2.Items[sayac].SubItems.Add(textBox6.Text);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from sprs where SiparisID=@SiparisID";
            //musterino parametresine bağlı olarak müşteri bilgilerini çeken sql kodu
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@SiparisID", textBox2.Text);
           
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();

            if (dr.Read())
            {
                string siparisıd = dr["SiparisID"].ToString() + " " + dr["MasaID"].ToString();
                dr.Close();
              
                DialogResult durum = MessageBox.Show(siparisıd + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                
                if (DialogResult.Yes == durum) 
                {
                    string silmeSorgusu = "DELETE from sprs where SiparisID=@SiparisID";
                    
                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@SiparisID", textBox2.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");
                    
                }
            }
            else
                MessageBox.Show("Müşteri Bulunamadı.");
            baglanti.Close();



            //DialogResult dialogResult = new DialogResult();
            //dialogResult = MessageBox.Show("Veriyi Silmek istediğinizden emin misiniz?", "Silme Uyarısı", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    listView2.SelectedItems[0].Remove();


            //}


            //    SqlCommand VeriSil = new SqlCommand("DELETE from sprs where SiparisID=@SiparisID", baglanti);
            //    VeriSil.Parameters.AddWithValue("@SiparisID", textBox2.Text);
            //    VeriSil.ExecuteNonQuery();
            //    baglanti.Close();
            //    MessageBox.Show("Veri silindi");
            //}
            //catch
            //{
            //    MessageBox.Show("Hata Oluştu.");
            //}


        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into [sprs](SiparisID,MasaID,Siparis_Zamani,Ürünler_Adetler,Toplam_Tutar) values (@SiparisID,@MasaID,@SiparisZamani,@ÜrünAdet,@ToplamTutar)";

                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@SiparisID", textBox2.Text);
                komut.Parameters.AddWithValue("@MasaID", textBox3.Text);
                komut.Parameters.AddWithValue("@SiparisZamani", textBox1.Text);
                komut.Parameters.AddWithValue("@ÜrünAdet", textBox4.Text);
                komut.Parameters.AddWithValue("@ToplamTutar", textBox6.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
