namespace WinFormsApp8
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button5 = new Button();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(635, 405);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stok Ekranı Bilgileri";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.GridLines = true;
            listView1.Location = new Point(6, 26);
            listView1.Name = "listView1";
            listView1.Size = new Size(613, 354);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ÜrünID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ürünİsmi";
            columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "MevcutMiktar";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "MinimumStokMiktari";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "TedarikciBilgileri";
            columnHeader5.Width = 130;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.png_transparent_computer_icons_undo_arrow_button_circular_angle_text_monochrome_thumbnail;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(12, 483);
            button1.Name = "button1";
            button1.Size = new Size(94, 84);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(265, 423);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "verileri çek.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(824, 287);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 3;
            button3.Text = "verileri ekle.";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(716, 296);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "verileri sil.";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(716, 52);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "Ürün NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(708, 109);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Ürün İsmi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(671, 154);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 8;
            label4.Text = "Mevcut Miktar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(686, 206);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 9;
            label5.Text = "Stok Miktarı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(659, 246);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 10;
            label6.Text = "Tedarikçi Bilgisi:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(793, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(793, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(793, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(793, 151);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(793, 199);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(793, 243);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 16;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(764, 331);
            button5.Name = "button5";
            button5.Size = new Size(107, 65);
            button5.TabIndex = 17;
            button5.Text = "veriyi veritabanına kaydet.";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(422, 518);
            label7.Name = "label7";
            label7.Size = new Size(516, 17);
            label7.TabIndex = 39;
            label7.Text = "Eğer bir veriyi SQL tarafından silmek istiyorsanız lütfen ilk verileri çeke tıklayıp ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(419, 535);
            label9.Name = "label9";
            label9.Size = new Size(519, 17);
            label9.TabIndex = 40;
            label9.Text = "tabloyu görün sonrasında tablodan hangisini silmek istiyorsanız sadece ve sadece";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(419, 552);
            label10.Name = "label10";
            label10.Size = new Size(485, 17);
            label10.TabIndex = 41;
            label10.Text = "''Ürün NO'' kısmına onun ''ÜrünID''sini yazın ve veri sil. butonuna tıklayın.";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lovepik_large_data_technology_line_background_image_400124958;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(936, 570);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form7";
            Text = "STOK EKRANI FORMU";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button1;
        private Button button2;
        private ColumnHeader columnHeader6;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button5;
        private Label label7;
        private Label label9;
        private Label label10;
    }
}