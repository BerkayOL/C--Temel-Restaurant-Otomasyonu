using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp8
{
    public partial class Form5 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-SEK7GEB;Initial Catalog=Berkay Ay Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public Form5()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem İptal Edildi.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + "TL" + "Kartla Ödemeniz Gerçekleşmiştir,Yine Bekleriz.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + "TL" + "Adisyon nakit kullanılarak ödenmiştir.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from [SatisBilgileri]", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["ID"].ToString());
                item.SubItems.Add(dr["OdemeID"].ToString());
                item.SubItems.Add(dr["MasaID"].ToString());
                item.SubItems.Add(dr["Odeme_Turu"].ToString());
                item.SubItems.Add(dr["Toplam_Tutar"].ToString());
                listView1.Items.Add(item);
            }
            baglan.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {


        }

        private void button19_Click(object sender, EventArgs e)
        {
            int sayac = listView1.Items.Count;
            listView1.Items.Add(textBox3.Text);
            listView1.Items[sayac].SubItems.Add(textBox4.Text);
            listView1.Items[sayac].SubItems.Add(textBox5.Text);
            listView1.Items[sayac].SubItems.Add(textBox6.Text);
            listView1.Items[sayac].SubItems.Add(textBox7.Text);


        }

        private void button18_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = new DialogResult();
            //dialogResult = MessageBox.Show("Veriyi Silmek istediğinizden emin misiniz?", "Silme Uyarısı", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    listView1.SelectedItems[0].Remove();


            //}
            baglan.Open();
            string secmeSorgusu = "SELECT * from [SatisBilgileri] where OdemeID=@OdemeID";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglan);
            secmeKomutu.Parameters.AddWithValue("@OdemeID", textBox4.Text);

            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();

            if (dr.Read())
            {
                string odemeıd = dr["OdemeID"].ToString() + " " + dr["MasaID"].ToString();
                dr.Close();

                DialogResult durum = MessageBox.Show(odemeıd + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from [SatisBilgileri] where OdemeID=@OdemeID";

                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglan);
                    silKomutu.Parameters.AddWithValue("@OdemeID", textBox4.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");

                }
            }
            else
                MessageBox.Show("Müşteri Bulunamadı.");
            baglan.Close();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                string kayit = "insert into [SatisBilgileri](OdemeID,MasaID,Odeme_Turu,Toplam_Tutar) values (@OdemeID,@MasaID,@Odeme_Turu,@Toplam_Tutar)";

                SqlCommand komut = new SqlCommand(kayit, baglan);

                komut.Parameters.AddWithValue("@OdemeID", textBox4.Text);
                komut.Parameters.AddWithValue("@MasaID", textBox5.Text);
                komut.Parameters.AddWithValue("@Odeme_Turu", textBox6.Text);
                komut.Parameters.AddWithValue("@Toplam_Tutar", textBox7.Text);

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


