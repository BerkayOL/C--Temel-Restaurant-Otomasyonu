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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-SEK7GEB;Initial Catalog=Berkay Ay Restaurant;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici;
            string sifre;
            kullanici = comboBox1.Text;
            sifre = comboBox2.Text;
            if (sifre == "Özlem Hoca" && kullanici == "Özlem GÜZELYAZICI")
            {
                this.Hide();
                Form2 giris = new Form2();
                giris.Show();


            }
            else
            {
                MessageBox.Show("Þifreniz veya Kullanýcý Adýnýz Yanlýþ!");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            SqlCommand cmd = new SqlCommand("select * from [ADMÝN GÝRÝSÝ BÝLGÝLERÝ]", baglan);
            SqlDataReader dr;
            baglan.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["kullanici_adi"]);
                comboBox2.Items.Add(dr["sifre"]);
            }
            baglan.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }
    }

}


