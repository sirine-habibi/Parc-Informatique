using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Security.Cryptography;


namespace Parc_Informatique
{
    public partial class Form5 : Form
    {
        private string valeurTextBox2;

        public Form5(string valeur)
        {
            InitializeComponent();
            valeurTextBox2 = valeur;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            this.Hide();
            fm1.Show();
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
        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == Motdepasse.Text)
            {



                string connectionString = "server=127.0.0.1;user=root;password=\"\";database=gestion_parc;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string signup = "UPDATE informatique SET `mot de passe` = '" + Motdepasse.Text + "' WHERE gmail = '" + valeurTextBox2 + "'";
                        using (MySqlCommand command = new MySqlCommand(signup, connection))
                        {
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Le Mot De Passe Est Changer Avec Succées", "mot de passe réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Aucun utilisateur trouvé avec cet email.", "Échec de la mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Les conditions pour le mot de passe ne sont pas remplies.", "Erreur de mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (Motdepasse.Text.Length > 8)
            {
                Motdepasse.Text = Motdepasse.Text.Substring(0, 8); // Tronquer le texte à 8 caractères
            }

            Motdepasse.ForeColor = Color.White;
            Motdepasse.PasswordChar = '*';
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 8)
            {
                textBox1.Text = textBox1.Text.Substring(0, 8); // Tronquer le texte à 8 caractères
            }

            textBox1.ForeColor = Color.White;
            textBox1.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';
                Motdepasse.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
                Motdepasse.PasswordChar = '*';
            }
        }
     
       
    }
}
