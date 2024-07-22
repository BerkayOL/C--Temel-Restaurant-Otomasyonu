using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Menümüzde 'Adet Şeklinde Baklava' istiyorsunuz,başka bir isteğiniz varsa lütfen hayıra tuşlayın.(Evete tuşlarsanız Garson siparişinizi alacaktır.)", "Garson Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form4 form4 = new Form4();
                form4.ShowDialog();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Menümüzde 'Hamur Tatlısı' istiyorsunuz,başka bir isteğiniz varsa lütfen hayıra tuşlayın.(Evete tuşlarsanız Garson siparişinizi alacaktır.)", "Garson Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form4 form4 = new Form4();
                form4.ShowDialog();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Menümüzde 'Magnolya' istiyorsunuz,başka bir isteğiniz varsa lütfen hayıra tuşlayın.(Evete tuşlarsanız Garson siparişinizi alacaktır.)", "Garson Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form4 form4 = new Form4();
                form4.ShowDialog();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Menümüzde 'Tulumba Tatlısı' istiyorsunuz,başka bir isteğiniz varsa lütfen hayıra tuşlayın.(Evete tuşlarsanız Garson siparişinizi alacaktır.)", "Garson Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form4 form4 = new Form4();
                form4.ShowDialog();


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Menümüzde 'Tavuk Göğsü' istiyorsunuz,başka bir isteğiniz varsa lütfen hayıra tuşlayın.(Evete tuşlarsanız Garson siparişinizi alacaktır.)", "Garson Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form4 form4 = new Form4();
                form4.ShowDialog();


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Menümüzde 'Kıbrıs Tatlısı' istiyorsunuz,başka bir isteğiniz varsa lütfen hayıra tuşlayın.(Evete tuşlarsanız Garson siparişinizi alacaktır.)", "Garson Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form4 form4 = new Form4();
                form4.ShowDialog();


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }
    }
}
