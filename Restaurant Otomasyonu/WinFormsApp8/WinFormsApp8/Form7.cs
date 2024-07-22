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

    public partial class Form7 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-SEK7GEB;Initial Catalog=Berkay Ay Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from [Stok Ekranı Bilgileri]", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ID"].ToString());
                item.SubItems.Add(dr["ÜrünID"].ToString());
                item.SubItems.Add(dr["Ürün_İsmi"].ToString());
                item.SubItems.Add(dr["Mevcut_Miktar"].ToString());
                item.SubItems.Add(dr["Minimum_Stok_Miktari"].ToString());
                item.SubItems.Add(dr["Tedarikci_Bilgileri"].ToString());
                listView1.Items.Add(item);
            }
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayac = listView1.Items.Count;
            listView1.Items.Add(textBox1.Text);
            listView1.Items[sayac].SubItems.Add(textBox2.Text);
            listView1.Items[sayac].SubItems.Add(textBox3.Text);
            listView1.Items[sayac].SubItems.Add(textBox4.Text);
            listView1.Items[sayac].SubItems.Add(textBox5.Text);
            listView1.Items[sayac].SubItems.Add(textBox6.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = new DialogResult();
            //dialogResult = MessageBox.Show("Veriyi Silmek istediğinizden emin misiniz?", "Silme Uyarısı", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    listView1.SelectedItems[0].Remove();


            //}
            baglan.Open();
            string secmeSorgusu = "SELECT * from [Stok Ekranı Bilgileri] where ÜrünID=@ÜrünID";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglan);
            secmeKomutu.Parameters.AddWithValue("@ÜrünID", textBox2.Text);

            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();

            if (dr.Read())
            {
                string ürünıd = dr["ÜrünID"].ToString() + " " + dr["Ürün_İsmi"].ToString();
                dr.Close();

                DialogResult durum = MessageBox.Show(ürünıd + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from [Stok Ekranı Bilgileri] where ÜrünID=@ÜrünID";

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglan);
                    silKomutu.Parameters.AddWithValue("@ÜrünID", textBox2.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");

                }
            }
            else
                MessageBox.Show("Müşteri Bulunamadı.");
            baglan.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                SqlCommand VeriKaydet = new SqlCommand("insert into [Stok Ekranı Bilgileri] (ÜrünID,Ürün_İsmi,Mevcut_Miktar,Minimum_Stok_Miktari,Tedarikci_Bilgileri) values(@ÜrünID,@Ürünİsmi,@MevcutMiktar,@MinimumStokMiktari,@TedarikciBilgileri)", baglan);
                //VeriKaydet.CommandText = "SET IDENTITY_INSERT [Z RAPORU BİLGİLERİ] ON";
                //VeriKaydet.CommandText +=
                //VeriKaydet.Parameters.AddWithValue("@ID", textBox1.Text);
                VeriKaydet.Parameters.AddWithValue("@ÜrünID", textBox2.Text);
                VeriKaydet.Parameters.AddWithValue("@Ürünİsmi", textBox3.Text);
                VeriKaydet.Parameters.AddWithValue("@MevcutMiktar", textBox4.Text);
                VeriKaydet.Parameters.AddWithValue("@MinimumStokMiktari", textBox5.Text);
                VeriKaydet.Parameters.AddWithValue("@TedarikciBilgileri", textBox6.Text);
                VeriKaydet.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Veri Eklendi");
            }
            catch
            {
                MessageBox.Show("Kayıt Eklendi.");
            }

        }
    }
}
