using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using Parc_Informatique.Properties;
using System.Net.Mail;
using System.Net;

namespace Parc_Informatique
{
    public partial class Form3 : Form
    {
        string randomcode;
        public static string to;
        public Form3()
        {
            InitializeComponent();
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
            button4.BackColor = Color.RoyalBlue;
            button4.ForeColor = Color.White;
            if (randomcode == (textBox1.Text).ToString())
            {
                string valeurTextBox2 = textBox2.Text;
                Form5 rp = new Form5(valeurTextBox2);
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Code Incorrect");
            }

        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(30, 30, 30);
            button4.ForeColor = Color.RoyalBlue;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string emailToCheck = textBox2.Text.Trim();
            bool emailExists = CheckIfEmailExists(emailToCheck);
            if (emailExists)
            {
                string from, pass, messagebody;
                Random rand = new Random();
                randomcode = rand.Next(999999).ToString();
                MailMessage message = new MailMessage();
                to = (textBox2.Text).ToString();
                from = "habibi02sirine@gmail.com";
                pass = "psneirghzojjemjw";
                messagebody = $"Votre Code Est {randomcode}";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "code de réinitialisation du mot de passe";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code Envoyer Avec Succées");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // L'e-mail n'existe pas dans la base de données, affichez un message d'erreur
                MessageBox.Show("L'e-mail n'existe pas dans la base de données. Veuillez vérifier l'e-mail saisi.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckIfEmailExists(string emailToCheck)
        {
            string connectionString = "server=127.0.0.1;user=root;password=\"\";database=gestion_parc;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string checkEmailQuery = "SELECT COUNT(*) FROM informatique WHERE gmail = @email";
                MySqlCommand checkEmailCommand = new MySqlCommand(checkEmailQuery, connection);
                checkEmailCommand.Parameters.AddWithValue("@email", emailToCheck);

                int emailCount = Convert.ToInt32(checkEmailCommand.ExecuteScalar());

                return emailCount > 0; // Retourne true si l'e-mail existe, sinon false
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
        }
    }
}
