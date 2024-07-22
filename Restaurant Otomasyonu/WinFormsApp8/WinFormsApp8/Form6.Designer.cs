namespace WinFormsApp8
{
    partial class Form6
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
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button5 = new Button();
            textBox2 = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Z RAPORU";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader1, columnHeader2, columnHeader3 });
            listView1.GridLines = true;
            listView1.Location = new Point(11, 26);
            listView1.Name = "listView1";
            listView1.Size = new Size(438, 239);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "RaporTarihi";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ToplamSatis";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "İslemSayisi";
            columnHeader3.Width = 100;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.png_transparent_computer_icons_undo_arrow_button_circular_angle_text_monochrome_thumbnail;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(2, 374);
            button1.Name = "button1";
            button1.Size = new Size(81, 73);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 306);
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
            button3.Location = new Point(561, 178);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "veriyi sil.";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(675, 178);
            button4.Name = "button4";
            button4.Size = new Size(113, 29);
            button4.TabIndex = 4;
            button4.Text = "veriyi ekle.";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(524, 148);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 5;
            label1.Text = "İşlem Sayısı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(514, 98);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 6;
            label2.Text = "Toplam Satış:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(514, 55);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 7;
            label3.Text = "Rapor Tarihi:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(630, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(627, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(627, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(612, 213);
            button5.Name = "button5";
            button5.Size = new Size(100, 66);
            button5.TabIndex = 14;
            button5.Text = "veriyi veritabanına ekle.";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(627, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(289, 396);
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
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(286, 413);
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
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(273, 430);
            label10.Name = "label10";
            label10.Size = new Size(532, 17);
            label10.TabIndex = 41;
            label10.Text = "''Rapor Tarihi kısmına onun ''Rapor_Tarihi''sini yazın ve veri sil. butonuna tıklayın.";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lovepik_large_data_technology_line_background_image_400124958;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(803, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form6";
            Text = "Z RAPORU FORMU";
            Load += Form6_Load;
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
        private Button button1;
        private Button button2;
        private ColumnHeader columnHeader4;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button5;
        private TextBox textBox2;
        private Label label7;
        private Label label9;
        private Label label10;
    }
}