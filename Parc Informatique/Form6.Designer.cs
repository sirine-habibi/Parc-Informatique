namespace Parc_Informatique
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel22 = new Panel();
            tb_search = new TextBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel20 = new Panel();
            pictureBox3 = new PictureBox();
            label16 = new Label();
            panel24 = new Panel();
            button7 = new Button();
            button8 = new Button();
            button11 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel24.SuspendLayout();
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
            panel1.Size = new Size(1297, 40);
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
            button3.Location = new Point(1180, 0);
            button3.Name = "button3";
            button3.Size = new Size(39, 40);
            button3.TabIndex = 3;
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
            button2.Location = new Point(1219, 0);
            button2.Name = "button2";
            button2.Size = new Size(35, 40);
            button2.TabIndex = 2;
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
            button1.Size = new Size(43, 40);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(30, 30, 30);
            dataGridView1.Location = new Point(331, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(937, 203);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // panel22
            // 
            panel22.BackColor = Color.White;
            panel22.ForeColor = Color.White;
            panel22.Location = new Point(317, 101);
            panel22.Name = "panel22";
            panel22.Size = new Size(322, 1);
            panel22.TabIndex = 5;
            // 
            // tb_search
            // 
            tb_search.BackColor = Color.FromArgb(30, 30, 30);
            tb_search.BorderStyle = BorderStyle.None;
            tb_search.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tb_search.ForeColor = Color.White;
            tb_search.Location = new Point(316, 72);
            tb_search.Name = "tb_search";
            tb_search.PlaceholderText = "Recherche";
            tb_search.Size = new Size(322, 27);
            tb_search.TabIndex = 4;
            tb_search.KeyPress += tb_search_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1149, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel20);
            flowLayoutPanel1.Controls.Add(panel24);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button11);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.MaximumSize = new Size(224, 532);
            flowLayoutPanel1.MinimumSize = new Size(92, 532);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(224, 532);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // panel20
            // 
            panel20.Controls.Add(pictureBox3);
            panel20.Controls.Add(label16);
            panel20.Location = new Point(3, 3);
            panel20.Name = "panel20";
            panel20.Size = new Size(224, 98);
            panel20.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(114, 32);
            label16.Name = "label16";
            label16.Size = new Size(54, 21);
            label16.TabIndex = 23;
            label16.Text = "Menu";
            // 
            // panel24
            // 
            panel24.Controls.Add(button7);
            panel24.Location = new Point(3, 107);
            panel24.Name = "panel24";
            panel24.Size = new Size(221, 43);
            panel24.TabIndex = 1;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Black;
            button7.Image = Properties.Resources.unnamed__4_;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 0);
            button7.Name = "button7";
            button7.Padding = new Padding(30, 0, 0, 0);
            button7.Size = new Size(221, 44);
            button7.TabIndex = 23;
            button7.Text = "               Home ";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Black;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(3, 156);
            button8.Name = "button8";
            button8.Padding = new Padding(30, 0, 0, 0);
            button8.Size = new Size(221, 44);
            button8.TabIndex = 25;
            button8.Text = "                Help";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button11
            // 
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = Color.Black;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(3, 206);
            button11.Name = "button11";
            button11.Padding = new Padding(30, 0, 0, 0);
            button11.Size = new Size(221, 44);
            button11.TabIndex = 26;
            button11.Text = "               About";
            button11.TextAlign = ContentAlignment.MiddleLeft;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(287, 519);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 27;
            button4.Text = "Retour";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1297, 575);
            Controls.Add(button4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel22);
            Controls.Add(tb_search);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel24.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel22;
        private TextBox tb_search;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel20;
        private PictureBox pictureBox3;
        private Label label16;
        private Panel panel24;
        private Button button7;
        private Button button8;
        private Button button11;
        private System.Windows.Forms.Timer timer1;
        private Button button4;
    }
}