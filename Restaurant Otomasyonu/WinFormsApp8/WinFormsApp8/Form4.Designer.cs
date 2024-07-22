namespace WinFormsApp8
{
    partial class Form4
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox1 = new GroupBox();
            listView2 = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Activation = ItemActivation.OneClick;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listView1.GridLines = true;
            listView1.Location = new Point(22, 21);
            listView1.Name = "listView1";
            listView1.Size = new Size(629, 359);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "SiparisID";
            columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "MasaID";
            columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "SiparisZamani";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ürün";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ÜrünAdet";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ToplamTutar";
            columnHeader6.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Siparişler";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader7, columnHeader8, columnHeader9, columnHeader11, columnHeader12 });
            listView2.GridLines = true;
            listView2.Location = new Point(6, 17);
            listView2.Name = "listView2";
            listView2.Size = new Size(504, 295);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "ID";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "SiparisID";
            columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "MasaID";
            columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "SiparisZamani";
            columnHeader9.Width = 110;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "ÜrünAdet";
            columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "ToplamTutar";
            columnHeader12.Width = 110;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.png_transparent_computer_icons_undo_arrow_button_circular_angle_text_monochrome_thumbnail;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(754, 422);
            button1.Name = "button1";
            button1.Size = new Size(79, 71);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 327);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "verileri çek.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(754, 266);
            button3.Name = "button3";
            button3.Size = new Size(130, 58);
            button3.TabIndex = 3;
            button3.Text = "veriyi Tablo Tarafına Ekle.";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(669, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(669, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(669, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(784, 29);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(0, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(669, 222);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(576, 32);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 11;
            label2.Text = "Sipariş NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(589, 80);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 12;
            label3.Text = "Masa NO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(545, 132);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 13;
            label4.Text = "Sipariş Zamanı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(576, 178);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 14;
            label5.Text = "Ürün Adeti:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(553, 225);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 15;
            label6.Text = "Toplam Tutar:";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(690, 330);
            button4.Name = "button4";
            button4.Size = new Size(94, 57);
            button4.TabIndex = 17;
            button4.Text = "veri sil.";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(589, 268);
            button5.Name = "button5";
            button5.Size = new Size(132, 57);
            button5.TabIndex = 18;
            button5.Text = "veriyi veri tabanına kaydet.";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(669, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(586, 523);
            label7.Name = "label7";
            label7.Size = new Size(327, 17);
            label7.TabIndex = 20;
            label7.Text = "Sipariş Zamanında SQL tarafına kayıt eklemek için.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(624, 540);
            label8.Name = "label8";
            label8.Size = new Size(289, 17);
            label8.TabIndex = 21;
            label8.Text = "1905-06-20 00:00:00.000 şeklinde olmalıdır.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(-1, 506);
            label1.Name = "label1";
            label1.Size = new Size(516, 17);
            label1.TabIndex = 22;
            label1.Text = "Eğer bir veriyi SQL tarafından silmek istiyorsanız lütfen ilk verileri çeke tıklayıp ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(-1, 523);
            label9.Name = "label9";
            label9.Size = new Size(519, 17);
            label9.TabIndex = 23;
            label9.Text = "tabloyu görün sonrasında tablodan hangisini silmek istiyorsanız sadece ve sadece";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(-1, 540);
            label10.Name = "label10";
            label10.Size = new Size(497, 17);
            label10.TabIndex = 24;
            label10.Text = "''Siparis NO kısmına onun ''SiparisID''sini yazın ve veri sil. butonuna tıklayın.";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lovepik_large_data_technology_line_background_image_400124958;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(918, 564);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Siparişler Formu";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox1;
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Button button1;
        private Button button2;
        private ColumnHeader columnHeader13;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private Label label7;
        private Label label8;
        private Label label1;
        private Label label9;
        private Label label10;
    }
}