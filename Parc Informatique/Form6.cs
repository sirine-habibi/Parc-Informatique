using MySql.Data.MySqlClient;
using MySql.Data.Types;
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

namespace Parc_Informatique
{
    public partial class Form6 : Form
    {
        bool sidebarExpand;
        public Form6()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;user=root;password=\"\";database=gestion_parc;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string checkIfExistsQuery = "SELECT nom_utilisateur, N_inventaire, designation, DATE_FORMAT(date_achat, '%Y-%m-%d') AS date_achat, DATE_FORMAT(date_affectation, '%Y-%m-%d') AS date_affectation, N_serie, serial_key,combo1,combo2,combo3 FROM inventaire";
            MySqlCommand checkCommand = new MySqlCommand(checkIfExistsQuery, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(checkCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public static DataGridViewRow selectedrow;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                string nomUtilisateur = selectedRow.Cells["nom_utilisateur"].Value.ToString();
                string N_inventaire = selectedRow.Cells["N_inventaire"].Value.ToString();
                string designation = selectedRow.Cells["designation"].Value.ToString();
                string dateAchat = selectedRow.Cells["date_achat"].Value.ToString();
                string dateAffectation = selectedRow.Cells["date_affectation"].Value.ToString();
                string N_serie = selectedRow.Cells["N_serie"].Value.ToString();
                string serialKey = selectedRow.Cells["serial_key"].Value.ToString();
                string combo1 = selectedRow.Cells["combo1"].Value.ToString();
                string combo2 = selectedRow.Cells["combo2"].Value.ToString();
                string combo3 = selectedRow.Cells["combo3"].Value.ToString();

                // Créez une instance de Form2
                Form2 form2 = Form2.getform2;

                // Appelez la méthode SetComboBoxValues de Form2 avec les valeurs extraites
                form2.SetComboBoxValues(nomUtilisateur, N_inventaire, designation, dateAchat, dateAffectation, N_serie, serialKey, combo1, combo2, combo3);
                this.Hide();
                // Affichez Form2
                form2.ShowDialog();


            }
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

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            string connectionString = "server=127.0.0.1;user=root;password=\"\";database=gestion_parc;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                string searchText = tb_search.Text.Trim(); // Obtenir le texte saisi dans le TextBox et supprimer les espaces inutiles

                // Construire une requête SQL pour rechercher des enregistrements correspondants dans votre base de données
                string searchQuery = "SELECT nom_utilisateur, N_inventaire, designation, " +
                                     "DATE_FORMAT(date_achat, '%Y-%m-%d') AS date_achat, " +
                                     "DATE_FORMAT(date_affectation, '%Y-%m-%d') AS date_affectation, " +
                                     "N_serie, serial_key, combo1, combo2, combo3 " + // Ajouter des virgules pour séparer les colonnes
                                     "FROM inventaire " +
                                     "WHERE nom_utilisateur LIKE @searchText " +
                                     "OR N_inventaire = @searchTextNum " + // Utilisation de = pour des valeurs numériques
                                     "OR designation LIKE @searchText " +
                                     "OR N_serie LIKE @searchText " +
                                     "OR serial_key LIKE @searchText " +
                                     "OR combo1 LIKE @searchText " +
                                     "OR combo2 LIKE @searchText " +
                                     "OR combo3 LIKE @searchText";

                MySqlCommand searchCommand = new MySqlCommand(searchQuery, connection);
                searchCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); // Utilisation de paramètres de requête
                searchCommand.Parameters.AddWithValue("@searchTextNum", searchText); // Pour les valeurs numériques, utilisez simplement le texte

                MySqlDataAdapter da = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Afficher les résultats de la recherche dans le DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
    }
}
