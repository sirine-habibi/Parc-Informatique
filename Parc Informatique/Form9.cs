using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parc_Informatique
{
    public partial class Form9 : Form
    {
        bool sidebarExpand;
        public Form9()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
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
        private void ShowHelp()
        {
            string helpMessage = "Bienvenue dans l'application de gestion de parc informatique.\n" +
                                 "Pour obtenir de l'aide supplémentaire, veuillez contacter notre support technique.";

            // Afficher la boîte de dialogue d'aide
            MessageBox.Show(helpMessage, "Aide", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string aboutMessage = "Nom de l'application : Gestionnaire de parc informatique\n" +
                       "Version : 1.0\n" +
                       "Copyright © 2023 Médis\n" +
                       "Tous droits réservés.";

            MessageBox.Show(aboutMessage, "À propos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "";
                    return;
                }






                textBox1.ForeColor = Color.White;


            }
            catch { }
        }

        private bool IsValidNumeroInventaire(string input, out string errorMessage)
        {
            // Utilisation de l'expression régulière pour valider la syntaxe du numéro d'inventaire.
            string pattern = @"^N\d{2}\d{2}\d{3}[A-Z]{2}$";

            if (Regex.IsMatch(input, pattern))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Le numéro d'inventaire doit suivre le format N{mois}{2 derniers chiffres de l'année}{3 chiffres}{2 caractères}.";
                return false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "";
                    return;
                }

                textBox2.ForeColor = Color.White;

            }
            catch { }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text == "")
                {
                    textBox4.Text = "";
                    return;
                }

                textBox4.ForeColor = Color.White;

            }
            catch { }
        }
        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            string datePattern = @"^\d{4}-\d{1,2}-\d{1,2}$";


            if (!Regex.IsMatch(textBox4.Text, datePattern))
            {
                MessageBox.Show("Veuillez entrer une date au format année-mois-jour .", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                e.Cancel = true; // Annuler la validation
            }
            else if (!DateTime.TryParseExact(textBox4.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Veuillez entrer une date valide au format année-mois-jour.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                e.Cancel = true; // Annuler la validation
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text == "")
                {
                    textBox6.Text = "";
                    return;
                }

                textBox6.ForeColor = Color.White;

            }
            catch { }
        }
        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            string datePattern = @"^\d{4}-\d{1,2}-\d{1,2}$";


            if (!Regex.IsMatch(textBox6.Text, datePattern))
            {
                MessageBox.Show("Veuillez entrer une date au format année-mois-jour .", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
                e.Cancel = true; // Annuler la validation
            }
            else if (!DateTime.TryParseExact(textBox6.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Veuillez entrer une date valide au format année-mois-jour.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
                e.Cancel = true; // Annuler la validation
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox7.Text == "")
                {
                    textBox7.Text = "";
                    return;
                }
                if (textBox7.Text.Length > 10)
                {
                    textBox7.Text = textBox7.Text.Substring(0, 10); // Limitez la longueur à 10 caractères
                    textBox7.SelectionStart = textBox7.Text.Length; // Placez le curseur à la fin
                }

                textBox7.ForeColor = Color.White;

            }
            catch { }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string input = textBox3.Text.Replace("-", ""); // Supprimez les tirets
            StringBuilder formattedText = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0 && i % 5 == 0)
                {
                    formattedText.Append("-"); // Ajoutez un tiret après chaque groupe de 5 caractères
                }

                formattedText.Append(input[i]);

                if (i == 24)
                {
                    break; // Sortez de la boucle si la longueur atteint 25 caractères
                }
            }

            // Ajoutez des tirets supplémentaires si la longueur est inférieure à 25 caractères
            while (formattedText.Length < 25)
            {
                formattedText.Append("-");
            }


            textBox3.TextChanged -= textBox3_TextChanged; // Désactivez temporairement l'événement TextChanged
            textBox3.Text = formattedText.ToString();
            textBox3.SelectionStart = textBox3.Text.Length; // Placez le curseur à la fin
            textBox3.TextChanged += textBox3_TextChanged;
            try
            {
                if (textBox3.Text == "")
                {
                    textBox3.Text = "";
                    return;
                }

                textBox3.ForeColor = Color.White;

            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text) || textBox5.Text == "")
            {
                MessageBox.Show("Veuillez remplir ce champs.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox5.Focus();
                textBox5.SelectAll();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "")
            {
                MessageBox.Show("Veuillez remplir ces champs.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }
            string numeroInventaire = textBox1.Text.Trim();
            string errorMessage;
            if (!IsValidNumeroInventaire(numeroInventaire, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Vous pouvez également mettre en évidence le champ de texte ici, par exemple :
                textBox1.ForeColor = Color.Red;

                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "")
            {
                MessageBox.Show("Veuillez Remplir ces champs.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text) || textBox4.Text == "")
            {
                MessageBox.Show("Veuillez Remplir ces champs.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text) || textBox6.Text == "")
            {
                MessageBox.Show("Veuillez Remplir ces champs.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox6.Focus();
                textBox6.SelectAll();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "")
            {
                MessageBox.Show("Veuillez Remplir ces champs.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox3.Focus();
                textBox3.SelectAll();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox7.Text) || textBox7.Text == "")
            {
                MessageBox.Show("Veuillez Remplir ces champs.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox7.Focus();
                textBox7.SelectAll();
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || comboBox1.Text == "")
            {
                MessageBox.Show("Veuillez selectionner un choix.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                comboBox1.Focus();
                comboBox1.SelectAll();
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox2.Text) || comboBox2.Text == "")
            {
                MessageBox.Show("Veuillez selectionner un choix.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                comboBox2.Focus();
                comboBox2.SelectAll();
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox3.Text) || comboBox3.Text == "")
            {
                MessageBox.Show("Veuillez selectionner un choix.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                comboBox3.Focus();
                comboBox3.SelectAll();
                return;
            }
            string enteredPassword = Microsoft.VisualBasic.Interaction.InputBox("Veuillez entrer le mot de passe :", "Authentification", "");

            // Vérifiez si le mot de passe est correct
            if (enteredPassword != "12345678") // Remplacez "votreMotDePasse" par le mot de passe réel
            {
                MessageBox.Show("Mot de passe incorrect.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = "server=127.0.0.1;user=root;password=\"\";database=gestion_parc;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    string checkIfExistsQuery = "SELECT COUNT(*) FROM inventaire WHERE nom_utilisateur = @nomUtilisateur AND N_inventaire = @N_inventaire";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkIfExistsQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@nomUtilisateur", textBox5.Text);
                        checkCommand.Parameters.AddWithValue("@N_inventaire", textBox1.Text);


                        int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            // Les données existent déjà, afficher un message d'erreur
                            MessageBox.Show("Cet enregistrement existe déjà .", "Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string signup = "INSERT INTO inventaire (nom_utilisateur, N_inventaire, designation, date_achat, date_affectation, N_serie, serial_key, combo1, combo2, combo3) VALUES (@nomUtilisateur, @N_inventaire, @designation, @date_achat, @date_affectation, @N_serie, @serial_key, @combo1, @combo2, @combo3)";
                    using (MySqlCommand command = new MySqlCommand(signup, connection))
                    {
                        command.Parameters.AddWithValue("@nomUtilisateur", textBox5.Text);
                        command.Parameters.AddWithValue("@N_inventaire", textBox1.Text);
                        command.Parameters.AddWithValue("@designation", textBox2.Text);
                        command.Parameters.AddWithValue("@date_achat", textBox4.Text);
                        command.Parameters.AddWithValue("@date_affectation", textBox6.Text);
                        command.Parameters.AddWithValue("@N_serie", textBox7.Text);
                        command.Parameters.AddWithValue("@serial_key", textBox3.Text);
                        command.Parameters.AddWithValue("@combo1", comboBox1.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@combo2", comboBox2.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@combo3", comboBox3.SelectedItem.ToString());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Votre données a été enregistrée avec succès", "Enregistrement réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Créez une instance de Form3
            Form8 form8 = new Form8();

            // Récupérez les données à partir des contrôles de Form2
            string nomUtilisateur = textBox5.Text;
            string N_inventaire = textBox1.Text;
            string designation = textBox2.Text;
            string dateAchat = textBox4.Text;
            string dateAffectation = textBox6.Text;
            string N_serie = textBox7.Text;
            string serialKey = textBox3.Text;

            // Récupérez également les données des ComboBox de Form2
            string combo1 = comboBox1.Text;
            string combo2 = comboBox2.Text;
            string combo3 = comboBox3.Text;

            // Utilisez la méthode SetData de Form3 pour afficher toutes les données
            form8.SetData(nomUtilisateur, N_inventaire, designation, dateAchat, dateAffectation, N_serie, serialKey, combo1, combo2, combo3);

            // Affichez Form3
            form8.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flowLayoutPanel1.Width -= 10;
                if (flowLayoutPanel1.Width == flowLayoutPanel1.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer1.Stop();
                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;
                if (flowLayoutPanel1.Width == flowLayoutPanel1.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer1.Stop();
                }
            }
        }
    }
}



