using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using Parc_Informatique;
using System.Security.Cryptography;
using System.Text;

namespace Parc_Informatique
{
    public partial class Form1 : Form
    {
        int pw;
        bool hided;
        bool sidebarExpand;


        public string PasswordText
        {
            get { return textBox2.Text; }
        }
        private Size normalSize;
        public Form1()
        {
            InitializeComponent();
            normalSize = this.Size;
            pw = panel5.Width;
            hided = false;
        }
        public static class PasswordStorage
        {
            public static string Password { get; set; }
        }

        void IncreaseOpacity(object sender, EventArgs e)
        {
            if (this.Opacity <= 1)
            {
                this.Opacity += 0.01;
            }
            if (this.Opacity == 1)
                timer.Stop();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Entrer Votre Nom";
                    return;
                }
                string input = textBox1.Text.Trim(); // Supprimer les espaces avant et après la chaîne
                string errorMessage;

                if (!IsValidString(input, out errorMessage))
                {
                    textBox1.ForeColor = Color.Red;
                    panel5.Visible = true;

                    // Afficher le message d'erreur dans une MessageBox
                    MessageBox.Show(errorMessage, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                textBox1.ForeColor = Color.White;
                panel5.Visible = false;

            }
            catch { }

        }
        private bool IsValidString(string input, out string errorMessage)
        {
            if (input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "La chaîne doit contenir uniquement des lettres et des espaces.";
                return false;
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "")
                {

                    return;
                }
                if (textBox2.Text.Length > 8)
                {
                    textBox2.Text = textBox2.Text.Substring(0, 8); // Tronquer le texte à 8 caractères
                }
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
                panel7.Visible = false;

            }
            catch { }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.RoyalBlue;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Entrer Votre Nom")
            {
                panel5.Visible = true;
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "Entrer Mot De Passe")
            {
                panel7.Visible = true;
                textBox2.Focus();
                return;
            }



            string connectionString = "server=127.0.0.1;user=root;password=\"\";database=gestion_parc;";




            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string enteredUsername = textBox1.Text;
                    string enteredPassword = textBox2.Text;

                    // Recherche de l'utilisateur dans la base de données en utilisant le nom d'utilisateur
                    string selectUserQuery = "SELECT `mot de passe` FROM informatique WHERE nom_utilisateur = @username";

                    using (MySqlCommand selectUserCommand = new MySqlCommand(selectUserQuery, connection))
                    {
                        selectUserCommand.Parameters.AddWithValue("@username", enteredUsername);
                        string storedPassword = selectUserCommand.ExecuteScalar() as string;

                        if (storedPassword != null && VerifyPassword(enteredPassword, storedPassword))
                        {
                            // Mot de passe correct, connectez l'utilisateur.
                            Form7 form7 = new Form7();
                            form7.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = "Entrer Votre Nom";
                            textBox2.Text = "Entrer Mot De Passe";
                            textBox1.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        private bool VerifyPassword(string enteredPassword, string storedPassword)
        {
            string hashedEnteredPassword = HashPassword(enteredPassword);
            return string.Equals(hashedEnteredPassword, storedPassword, StringComparison.OrdinalIgnoreCase);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(30, 30, 30);
            button3.ForeColor = Color.RoyalBlue;
        }
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text) || textBox5.Text == "")
            {
                MessageBox.Show("Veuillez entrer votre nom.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlUsername.Visible = true;
                textBox5.Focus();
                textBox5.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "")
            {
                MessageBox.Show("Veuillez entrer votre email.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlUsername.Visible = true;
                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }

            string email = textBox3.Text;
            if (!email.Contains("gmail.com"))
            {
                MessageBox.Show("L'adresse email doit être de type Gmail (gmail.com).", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlUsername.Visible = true;
                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text) || textBox4.Text == "")
            {
                MessageBox.Show("Veuillez entrer un mot de passe.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlPassword.Visible = true;
                textBox4.Focus();
                textBox4.SelectAll();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox6.Text) || textBox6.Text == "")
            {
                MessageBox.Show("Veuillez confirmer le mot de passe.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlCPassword.Visible = true;
                textBox6.Focus();
                textBox6.SelectAll();
                return;
            }

            if (textBox4.Text != textBox6.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnlPassword.Visible = true;
                pnlCPassword.Visible = true;
                textBox4.Focus();
                textBox4.SelectAll();
                return;
            }
            string connectionString = "server=127.0.0.1;user=root;password=\"\";database=gestion_parc;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string nomUtilisateur = textBox5.Text;
                    string gmail = textBox3.Text;
                    string password = textBox4.Text;

                    // Vérifier si l'utilisateur existe déjà
                    string checkIfExistsQuery = "SELECT COUNT(*) FROM informatique WHERE nom_utilisateur = @nomUtilisateur AND gmail = @email";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkIfExistsQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                        checkCommand.Parameters.AddWithValue("@email", gmail);

                        int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            // Les données existent déjà, afficher un message d'erreur
                            MessageBox.Show("Cet utilisateur existe déjà dans la base de données.", "Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Hacher le mot de passe avant de l'insérer dans la base de données
                    string hashedPassword = HashPassword(password);

                    // Insérer l'utilisateur dans la base de données
                    string signup = "INSERT INTO informatique (nom_utilisateur, `mot de passe`, gmail) VALUES (@nomUtilisateur, @hashedPassword, @email)";
                    using (MySqlCommand command = new MySqlCommand(signup, connection))
                    {
                        command.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                        command.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                        command.Parameters.AddWithValue("@email", email);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Votre compte a été créé avec succès", "Enregistrement réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Si toutes les conditions sont remplies, le code continue ici




            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlUsername.Visible = pnlPassword.Visible = pnlCPassword.Visible = false;
        }



        private void pnlLogin_Paint_1(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == "")
                {
                    textBox5.Text = "";
                    return;
                }
                string input = textBox5.Text.Trim(); // Supprimer les espaces avant et après la chaîne
                string errorMessage;

                if (!IsValidString(input, out errorMessage))
                {
                    textBox5.ForeColor = Color.Red;
                    panel5.Visible = true;

                    // Afficher le message d'erreur dans une MessageBox
                    MessageBox.Show(errorMessage, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                textBox5.ForeColor = Color.White;
                panel5.Visible = false;

            }
            catch { }
        }




        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text == "")
                {

                    return;
                }
                if (textBox4.Text.Length > 8)
                {
                    textBox4.Text = textBox4.Text.Substring(0, 8); // Tronquer le texte à 8 caractères
                }
                textBox4.ForeColor = Color.White;
                textBox4.PasswordChar = '*';
                panel7.Visible = false;

            }
            catch { }


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text == "")
                {

                    return;
                }
                if (textBox6.Text.Length > 8)
                {
                    textBox6.Text = textBox6.Text.Substring(0, 8); // Tronquer le texte à 8 caractères
                }
                textBox6.ForeColor = Color.White;
                textBox6.PasswordChar = '*';
                panel7.Visible = false;

            }
            catch { }

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.RoyalBlue;
            button3.ForeColor = Color.Black;
        }



        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = true;
            pnlLogin.Dock = DockStyle.Fill;
            pnlsignup.Visible = false;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = false;
            pnlsignup.Visible = true;

            pnlsignup.Dock = DockStyle.Fill;


        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }



        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                // Passe à l'état maximisé
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Passe à l'état normal
                WindowState = FormWindowState.Normal;

                // Réglez la taille des éléments de l'interface proportionnellement
                float ratioWidth = (float)this.Size.Width / normalSize.Width;
                float ratioHeight = (float)this.Size.Height / normalSize.Height;

                RedimensionnerElementsDeLInterface(ratioWidth, ratioHeight);
            }
        }
        private void RedimensionnerElementsDeLInterface(float ratioWidth, float ratioHeight)
        {
            // Redimensionnez ici tous les éléments d'interface utilisateur en fonction des ratios fournis
            // Par exemple, vous pouvez redimensionner les contrôles, les étiquettes, les boutons, etc.
            // Exemple :
            // monControl.Width = (int)(monControl.Width * ratioWidth);
            // monControl.Height = (int)(monControl.Height * ratioHeight);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar = '\0';
                textBox6.PasswordChar = '\0';
            }
            else
            {
                textBox4.PasswordChar = '*';
                textBox6.PasswordChar = '*';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox5.Focus();
            textBox5.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox6.Text = string.Empty;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }
        private void ShowHelp()
        {
            string helpMessage = "Bienvenue dans l'application de gestion de parc informatique.\n" +
                                 "Pour obtenir de l'aide supplémentaire, veuillez contacter notre support technique.";

            // Afficher la boîte de dialogue d'aide
            MessageBox.Show(helpMessage, "Aide", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string aboutMessage = "Nom de l'application : Gestionnaire de parc informatique\n" +
                         "Version : 1.0\n" +
                         "Copyright © 2023 Médis\n" +
                         "Tous droits réservés.";

            MessageBox.Show(aboutMessage, "À propos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flowLayoutPanel1.Width -= 10;
                if (flowLayoutPanel1.Width == flowLayoutPanel1.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer2.Stop();
                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;
                if (flowLayoutPanel1.Width == flowLayoutPanel1.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer2.Stop();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string aboutMessage = "Nom de l'application : Gestionnaire de parc informatique\n" +
                         "Version : 1.0\n" +
                         "Copyright © 2023 Médis\n" +
                         "Tous droits réservés.";

            MessageBox.Show(aboutMessage, "À propos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlsignup_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

