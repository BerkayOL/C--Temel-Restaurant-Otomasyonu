namespace WinFormsApp8
{
    partial class Form8
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
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
            button9 = new Button();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.png_transparent_chef_cooking_computer_icons_kitchen_recipe_cooking_microphone_logo_cook;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.IndianRed;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(219, 26);
            button1.Name = "button1";
            button1.Size = new Size(169, 121);
            button1.TabIndex = 0;
            button1.Text = "ANA YEMEK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.png_transparent_fizzy_drinks_non_alcoholic_drink_computer_icons_soft_drink_food_rectangle_drinking_straw;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.IndianRed;
            button2.Location = new Point(26, 147);
            button2.Name = "button2";
            button2.Size = new Size(164, 115);
            button2.TabIndex = 1;
            button2.Text = "İÇECEK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.png_clipart_miso_soup_computer_icons_food_indian_cuisine_soup_pot_soup_food;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.IndianRed;
            button3.Location = new Point(26, 26);
            button3.Name = "button3";
            button3.Size = new Size(164, 115);
            button3.TabIndex = 2;
            button3.Text = "ÇORBA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources._83947224_tatlı_kek_tatlı_simgesi_vektör_resim_grafik_tasarım;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.IndianRed;
            button4.Location = new Point(219, 153);
            button4.Name = "button4";
            button4.Size = new Size(169, 109);
            button4.TabIndex = 3;
            button4.Text = "TATLI";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.png_transparent_computer_icons_undo_arrow_button_circular_angle_text_monochrome_thumbnail;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(149, 286);
            button5.Name = "button5";
            button5.Size = new Size(114, 86);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(485, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 498);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "YEMEK TÜRLERİ";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(363, 275);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ÜrünID";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "İsim";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fiyat";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Kategori";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Aciklama";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(12, 293);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 7;
            button6.Text = "verileri çek.";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button7.Location = new Point(241, 484);
            button7.Name = "button7";
            button7.Size = new Size(154, 29);
            button7.TabIndex = 8;
            button7.Text = "verileri sil.";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button8.Location = new Point(241, 437);
            button8.Name = "button8";
            button8.Size = new Size(154, 30);
            button8.TabIndex = 9;
            button8.Text = "verileri tabloya ekle.";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(24, 345);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 11;
            label2.Text = "Ürün NO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(16, 389);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 12;
            label3.Text = "Ürün İsmi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(51, 427);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 13;
            label4.Text = "Fiyat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(24, 472);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 14;
            label5.Text = "Kategori:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(20, 513);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 15;
            label6.Text = "Açıklama:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 368);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 27);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 342);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 386);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(101, 424);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(101, 469);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(101, 510);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 21;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLight;
            button9.Font = new Font("Segoe UI Black", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button9.Location = new Point(241, 354);
            button9.Name = "button9";
            button9.Size = new Size(154, 65);
            button9.TabIndex = 0;
            button9.Text = "verileri veritabanına kaydet.";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Black", 6F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(478, 3);
            label7.Name = "label7";
            label7.Size = new Size(399, 12);
            label7.TabIndex = 40;
            label7.Text = "Eğer bir veriyi SQL tarafından silmek istiyorsanız lütfen ilk verileri çeke tıklayıp ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Black", 6F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(478, 15);
            label9.Name = "label9";
            label9.Size = new Size(406, 12);
            label9.TabIndex = 41;
            label9.Text = "tabloyu görün sonrasında tablodan hangisini silmek istiyorsanız sadece ve sadece";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Black", 6F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(478, 27);
            label10.Name = "label10";
            label10.Size = new Size(369, 12);
            label10.TabIndex = 42;
            label10.Text = "''Ürün NO'' kısmına onun ''ÜrünID''sini yazın ve veri sil. butonuna tıklayın.";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.lovepik_large_data_technology_line_background_image_400124958;
            ClientSize = new Size(881, 566);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(button9);
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
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "Form8";
            Text = "YEMEK MENÜSÜ FORMU";
            Load += Form8_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button6;
        private Button button7;
        private Button button8;
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
        private Button button9;
        private Label label7;
        private Label label9;
        private Label label10;
    }
}