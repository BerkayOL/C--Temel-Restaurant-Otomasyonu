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
    public partial class Form8 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-SEK7GEB;Initial Catalog=Berkay Ay Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public Form8()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form9 = new Form9();
            form9.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 form12 = new Form12();
            form12.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from [MenüBİlgileri]", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ID"].ToString());
                item.SubItems.Add(dr["ÜrünID"].ToString());
                item.SubItems.Add(dr["İsim"].ToString());
                item.SubItems.Add(dr["Fiyat"].ToString());
                item.SubItems.Add(dr["Kategori"].ToString());
                item.SubItems.Add(dr["Aciklama"].ToString());
                listView1.Items.Add(item);
            }
            baglan.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayac = listView1.Items.Count;
            listView1.Items.Add(textBox1.Text);
            listView1.Items[sayac].SubItems.Add(textBox2.Text);
            listView1.Items[sayac].SubItems.Add(textBox3.Text);
            listView1.Items[sayac].SubItems.Add(textBox4.Text);
            listView1.Items[sayac].SubItems.Add(textBox5.Text);
            listView1.Items[sayac].SubItems.Add(textBox6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = new DialogResult();
            //dialogResult = MessageBox.Show("Veriyi Silmek istediğinizden emin misiniz?", "Silme Uyarısı", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    listView1.SelectedItems[0].Remove();


            //}
            baglan.Open();
            string secmeSorgusu = "SELECT * from [MenüBİlgileri] where ÜrünID=@ÜrünID";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglan);
            secmeKomutu.Parameters.AddWithValue("@ÜrünID", textBox2.Text);

            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();

            if (dr.Read())
            {
                string ürünıd = dr["ÜrünID"].ToString() + " " + dr["İsim"].ToString();
                dr.Close();

                DialogResult durum = MessageBox.Show(ürünıd + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from [MenüBİlgileri] where ÜrünID=@ÜrünID";

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglan);
                    silKomutu.Parameters.AddWithValue("@ÜrünID", textBox2.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");

                }
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                string kayit = "insert into [MenüBİlgileri](ÜrünID,İsim,Fiyat,Kategori,Aciklama) values (@ÜrünID,@İsim,@Fiyat,@Kategori,@Aciklama)";

                SqlCommand komut = new SqlCommand(kayit, baglan);

                komut.Parameters.AddWithValue("@ÜrünID", textBox2.Text);
                komut.Parameters.AddWithValue("@İsim", textBox3.Text);
                komut.Parameters.AddWithValue("@Fiyat", textBox4.Text);
                komut.Parameters.AddWithValue("@Kategori", textBox5.Text);
                komut.Parameters.AddWithValue("@Aciklama", textBox6.Text);

                komut.ExecuteNonQuery();

                baglan.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
    }
}
