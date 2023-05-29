namespace midnightCafe
{
    partial class registration
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(337, 402);
            button1.Name = "button1";
            button1.Size = new Size(130, 36);
            button1.TabIndex = 34;
            button1.Text = "Sign UP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(374, 293);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 33;
            label3.Text = "Gender";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(367, 214);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 32;
            label2.Text = "Birthday";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(276, 333);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Male";
            textBox9.Size = new Size(98, 23);
            textBox9.TabIndex = 31;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(425, 333);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Female";
            textBox8.Size = new Size(98, 23);
            textBox8.TabIndex = 30;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(492, 247);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Year";
            textBox7.Size = new Size(98, 23);
            textBox7.TabIndex = 29;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(354, 247);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Date";
            textBox6.Size = new Size(98, 23);
            textBox6.TabIndex = 28;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(210, 247);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Month";
            textBox5.Size = new Size(98, 23);
            textBox5.TabIndex = 27;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(210, 167);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Password";
            textBox4.Size = new Size(380, 23);
            textBox4.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(415, 69);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "LastName";
            textBox3.Size = new Size(175, 23);
            textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 120);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Email or Username";
            textBox2.Size = new Size(380, 23);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 69);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "FirstName";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(278, 13);
            label1.Name = "label1";
            label1.Size = new Size(229, 24);
            label1.TabIndex = 22;
            label1.Text = "Register new account";
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "registration";
            Text = "registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}