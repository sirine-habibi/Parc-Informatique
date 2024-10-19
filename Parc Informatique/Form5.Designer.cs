namespace Parc_Informatique
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel22 = new Panel();
            Motdepasse = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 43);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1174, 0);
            button3.Name = "button3";
            button3.Size = new Size(41, 43);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1215, 0);
            button2.Name = "button2";
            button2.Size = new Size(39, 43);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1254, 0);
            button1.Name = "button1";
            button1.Size = new Size(43, 43);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(491, 93);
            label1.Name = "label1";
            label1.Size = new Size(365, 25);
            label1.TabIndex = 2;
            label1.Text = "Réinitialiser Le Mot De Passe Via E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(272, 232);
            label2.Name = "label2";
            label2.Size = new Size(198, 21);
            label2.TabIndex = 10;
            label2.Text = "Nouvaux Mot De Passe  :";
            // 
            // panel22
            // 
            panel22.BackColor = Color.White;
            panel22.Location = new Point(487, 252);
            panel22.Name = "panel22";
            panel22.Size = new Size(444, 1);
            panel22.TabIndex = 9;
            // 
            // Motdepasse
            // 
            Motdepasse.BackColor = Color.FromArgb(30, 30, 30);
            Motdepasse.BorderStyle = BorderStyle.None;
            Motdepasse.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Motdepasse.ForeColor = Color.Gray;
            Motdepasse.Location = new Point(487, 219);
            Motdepasse.Name = "Motdepasse";
            Motdepasse.Size = new Size(444, 27);
            Motdepasse.TabIndex = 8;
            Motdepasse.TextChanged += textBox5_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(248, 324);
            label3.Name = "label3";
            label3.Size = new Size(222, 21);
            label3.TabIndex = 13;
            label3.Text = "Confirmer Le Mot De Passe :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(487, 344);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 1);
            panel2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(487, 311);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(444, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.FlatAppearance.BorderColor = Color.RoyalBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(540, 466);
            button4.Name = "button4";
            button4.Size = new Size(120, 44);
            button4.TabIndex = 14;
            button4.Text = "Retour";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.RoyalBlue;
            button5.FlatAppearance.BorderColor = Color.RoyalBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(739, 466);
            button5.Name = "button5";
            button5.Size = new Size(117, 44);
            button5.TabIndex = 15;
            button5.Text = "Enregistrer";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(821, 367);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(158, 19);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Afficher le mot de passe";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1297, 574);
            Controls.Add(checkBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(panel22);
            Controls.Add(Motdepasse);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel22;
        private TextBox Motdepasse;
        private Label label3;
        private Panel panel2;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private CheckBox checkBox1;
    }
}