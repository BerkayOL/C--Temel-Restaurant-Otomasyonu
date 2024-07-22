namespace WinFormsApp8
{
    partial class Form2
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
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.png_clipart_computer_icons_collegest_order_icon_cdr_angle;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(359, 99);
            button1.Name = "button1";
            button1.Size = new Size(132, 129);
            button1.TabIndex = 0;
            button1.Text = "SİPARİŞLER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.BackgroundImage = Properties.Resources.png_transparent_table_matbord_computer_icons_furniture_dining_room_restaurant_table_furniture_text_logo;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(150, 92);
            button2.Name = "button2";
            button2.Size = new Size(203, 123);
            button2.TabIndex = 1;
            button2.Text = "MASA";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources._5164023;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(199, 221);
            button3.Name = "button3";
            button3.Size = new Size(154, 121);
            button3.TabIndex = 2;
            button3.Text = "STOK EKRANI";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.download;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(359, 234);
            button4.Name = "button4";
            button4.Size = new Size(109, 108);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.png_transparent_sales_computer_icons_purchasing_e_commerce_selling_miscellaneous_angle_text;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(474, 240);
            button5.Name = "button5";
            button5.Size = new Size(122, 83);
            button5.TabIndex = 4;
            button5.Text = "SATIŞ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.png_transparent_dining_menu_cafe_menu_restaurant_icon_restaurant_menu_template_white_food_thumbnail;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(497, 111);
            button6.Name = "button6";
            button6.Size = new Size(102, 123);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.png_transparent_computer_icons_undo_arrow_button_circular_angle_text_monochrome_thumbnail;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(718, 360);
            button7.Name = "button7";
            button7.Size = new Size(70, 66);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(390, 429);
            label1.Name = "label1";
            label1.Size = new Size(414, 23);
            label1.TabIndex = 7;
            label1.Text = "ADMİN GİRİŞİNE GERİ DÖNMEK İÇİN TIKLAYIN.";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.menu_01;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlLight;
            Name = "Form2";
            Text = "MENÜ FORMU";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
    }
}