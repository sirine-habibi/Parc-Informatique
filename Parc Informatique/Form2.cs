using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Parc_Informatique;



namespace Parc_Informatique
{
    public partial class Form2 : Form
    {
        public static Form2 frm;
        bool sidebarExpand;
        private Form1 form1;
        public static Form2 getform2
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form2();
                }
                return frm;
            }
        }
        public string MotDePasse { get; set; }

        public Form2()
        {
            InitializeComponent();
            textBox4.Validating += textBox4_Validating;
            textBox6.Validating += textBox6_Validating;

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



        private void textBox7_TextChanged_1(object sender, EventArgs e)
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




        private void button2_Click(object sender, EventArgs e)
        {
            // Affichez une boîte de dialogue pour saisir le mot de passe
            string enteredPassword = Microsoft.VisualBasic.Interaction.InputBox("Veuillez entrer le mot de passe :", "Authentification", "");

            // Vérifiez si le mot de passe est correct
            if (enteredPassword != "12345678") // Remplacez "votreMotDePasse" par le mot de passe réel
            {
                MessageBox.Show("Mot de passe incorrect.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Ouvrez la connexion à la base de données
            string connectionString = "server=127.0.0.1;user=root;password=\"\";database=gestion_parc;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Créez une requête SQL pour supprimer l'enregistrement en fonction des critères spécifiés
                    string deleteQuery = "DELETE FROM inventaire WHERE nom_utilisateur = @nomUtilisateur AND N_inventaire = @N_inventaire";
                    using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@nomUtilisateur", textBox5.Text);
                        deleteCommand.Parameters.AddWithValue("@N_inventaire", textBox1.Text);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            textBox5.Text = "";
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";
                            comboBox1.SelectedIndex = -1;
                            comboBox2.SelectedIndex = -1;
                            comboBox3.SelectedIndex = -1;

                            MessageBox.Show("Enregistrement supprimé avec succès.", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aucun enregistrement trouvé avec les critères spécifiés.", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Cette méthode doit être définie dans la classe ou le contexte où vous gérez l'authentification de l'utilisateur
        private string GetLoggedInUserId()
        {
            string userId = "id";
            return userId;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Affichez une boîte de dialogue pour saisir le mot de passe
            string enteredPassword = Microsoft.VisualBasic.Interaction.InputBox("Veuillez entrer le mot de passe :", "Authentification", "");

            // Vérifiez si le mot de passe est correct
            if (enteredPassword != "12345678") // Remplacez "votreMotDePasse" par le mot de passe réel
            {
                MessageBox.Show("Mot de passe incorrect.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifiez si les champs requis sont renseignés
            if (string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Veuillez remplir les champs pour effectuer la modification.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Ouvrez la connexion à la base de données
            string connectionString = "server=127.0.0.1;user=root;password=\"\";database=gestion_parc;";
            // Ouvrez la connexion à la base de données

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Créez une requête SQL pour mettre à jour l'enregistrement en fonction des critères spécifiés
                    string updateQuery = "UPDATE inventaire SET designation = @designation, date_achat = @date_achat, date_affectation = @date_affectation, N_serie = @N_serie, serial_key = @serial_key WHERE nom_utilisateur = @nomUtilisateur AND N_inventaire = @N_inventaire";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@nomUtilisateur", textBox5.Text);
                        updateCommand.Parameters.AddWithValue("@N_inventaire", textBox1.Text);
                        updateCommand.Parameters.AddWithValue("@designation", textBox2.Text);
                        updateCommand.Parameters.AddWithValue("@date_achat", textBox4.Text);
                        updateCommand.Parameters.AddWithValue("@date_affectation", textBox6.Text);
                        updateCommand.Parameters.AddWithValue("@N_serie", textBox7.Text);
                        updateCommand.Parameters.AddWithValue("@serial_key", textBox3.Text);
                        updateCommand.Parameters.AddWithValue("@combo1", comboBox1.SelectedItem.ToString());
                        updateCommand.Parameters.AddWithValue("@combo2", comboBox2.SelectedItem.ToString());
                        updateCommand.Parameters.AddWithValue("@combo3", comboBox3.SelectedItem.ToString());


                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Enregistrement modifié avec succès.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aucun enregistrement trouvé avec les critères spécifiés.", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form6.selectedrow != null)
            {
                if (Form6.selectedrow.Cells[0].Value != null)
                    textBox5.Text = Form6.selectedrow.Cells[0].Value.ToString();

                if (Form6.selectedrow.Cells[1].Value != null)
                    textBox1.Text = Form6.selectedrow.Cells[1].Value.ToString();

                if (Form6.selectedrow.Cells[2].Value != null)
                    textBox2.Text = Form6.selectedrow.Cells[2].Value.ToString();

                if (Form6.selectedrow.Cells[3].Value != null)
                    textBox4.Text = Form6.selectedrow.Cells[3].Value.ToString();

                if (Form6.selectedrow.Cells[4].Value != null)
                    textBox6.Text = Form6.selectedrow.Cells[4].Value.ToString();

                if (Form6.selectedrow.Cells[5].Value != null)
                    textBox7.Text = Form6.selectedrow.Cells[5].Value.ToString();

                if (Form6.selectedrow.Cells[6].Value != null)
                    textBox3.Text = Form6.selectedrow.Cells[6].Value.ToString();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void button7_Click_1(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class PdfFooter : PdfPageEventHelper
        {
            // Événement déclenché lorsqu'une page est finalisée
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                base.OnEndPage(writer, document);

                // Créez un pied de page avec le numéro de page
                string footerText = writer.PageNumber.ToString();

                iTextSharp.text.Font font = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                // Créez un élément Phrase pour le pied de page
                Phrase footerPhrase = new Phrase(footerText, font);

                // Alignez le pied de page au centre
                ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_CENTER, footerPhrase, document.Right - 60, document.Bottom + 20, 0);
            }
        }
        public void SetComboBoxValues(string nomUtilisateur, string N_inventaire, string designation, string dateAchat, string dateAffectation, string N_serie, string serialKey, string combo1, string combo2, string combo3)
        {
            // Utilisez les valeurs pour définir les ComboBox et d'autres contrôles dans Form2
            comboBox1.Text = combo1;
            comboBox2.Text = combo2;
            comboBox3.Text = combo3;
            // Assurez-vous que comboBox1, comboBox2, comboBox3, et les autres contrôles sont correctement nommés dans Form2.
            // Répétez cette étape pour les autres contrôles que vous souhaitez initialiser.
            textBox5.Text = nomUtilisateur;
            textBox1.Text = N_inventaire;
            textBox2.Text = designation;
            textBox4.Text = dateAchat;
            textBox6.Text = dateAffectation;
            textBox7.Text = N_serie;
            textBox3.Text = serialKey;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Collectez les données des labels ou des TextBox de Form3
            string nom = textBox5.Text;
            string numeroInventaire = textBox1.Text;
            string designation = textBox2.Text;
            string dateAchat = textBox4.Text;
            string dateAffectation = textBox6.Text;
            string N_serie = textBox7.Text;
            string serialKey = textBox3.Text;
            string combo1 = comboBox1.Text;
            string combo2 = comboBox2.Text;
            string combo3 = comboBox3.Text;
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string uniqueFileName = $"Form8_{timestamp}.pdf";

            // Créez un document PDF
            string nomFichier = "Form8_" + timestamp + ".pdf";
            string filePath = Path.Combine("C:\\Users\\AH-INFO\\Downloads", nomFichier);

            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            PdfFooter footerEvent = new PdfFooter();
            writer.PageEvent = footerEvent;
            doc.Open();
            // Chemin vers votre logo
            string logoPath = "C:\\Users\\AH-INFO\\Downloads\\sirine.png";

            // Chargez l'image depuis le chemin
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);

            // Ajustez la taille du logo selon vos besoins
            logo.ScaleToFit(100f, 100f);

            // Créez un paragraphe pour l'image
            Paragraph imageParagraph = new Paragraph();
            imageParagraph.Alignment = Element.ALIGN_LEFT; // Alignez l'image à gauche

            // Créez une cellule pour contenir l'image
            PdfPCell imageCell = new PdfPCell();
            imageCell.Border = PdfPCell.NO_BORDER; // Supprimez la bordure de la cellule
            imageCell.AddElement(logo); // Ajoutez le logo à la cellule

            // Ajoutez la cellule à la table
            PdfPTable imageTable = new PdfPTable(1);
            imageTable.WidthPercentage = 100; // Largeur de la table à 100% de la page
            imageTable.AddCell(imageCell);

            // Ajoutez la table au paragraphe
            imageParagraph.Add(imageTable);

            // Ajoutez le paragraphe contenant l'image au document
            doc.Add(imageParagraph);


            Paragraph centerText = new Paragraph();
            centerText.Alignment = Element.ALIGN_CENTER;

            // Créez une police personnalisée avec une taille de police plus grande
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, 23, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
            // Créez une table pour organiser les données
            PdfPTable table = new PdfPTable(1); // Une colonne


            // Créez un style pour centrer le contenu de la table
            PdfPCell cell = new PdfPCell();
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.VerticalAlignment = Element.ALIGN_MIDDLE;
            cell.Border = PdfPCell.NO_BORDER;
            // Créez un paragraphe pour chaque donnée
            Paragraph nomParagraph = new Paragraph("Nom D'utilisateur : " + nom, font);
            Paragraph numeroParagraph = new Paragraph("Numéro D'inventaire : " + numeroInventaire, font);
            Paragraph designationParagraph = new Paragraph("Désignation : " + designation, font);
            Paragraph dateAchatParagraph = new Paragraph("Date d'achat : " + dateAchat, font);
            Paragraph dateAffectationParagraph = new Paragraph("Date d'affectation : " + dateAffectation, font);
            Paragraph N_serieParagraph = new Paragraph("N_Série_OU_Service taq : " + N_serie, font);
            Paragraph combo1Paragraph = new Paragraph("OS : " + combo1, font);
            Paragraph serialKeyParagraph = new Paragraph("SERIAL_KEY : " + serialKey, font);
            Paragraph combo2Paragraph = new Paragraph("Département : " + combo2, font);
            Paragraph combo3Paragraph = new Paragraph("Matière : " + combo3, font);

            // Ajoutez les paragraphes aux cellules de la table
            cell.AddElement(nomParagraph);
            cell.AddElement(numeroParagraph);
            cell.AddElement(designationParagraph);
            cell.AddElement(dateAchatParagraph);
            cell.AddElement(dateAffectationParagraph);
            cell.AddElement(N_serieParagraph);
            cell.AddElement(combo1Paragraph);
            cell.AddElement(serialKeyParagraph);
            cell.AddElement(combo2Paragraph);
            cell.AddElement(combo3Paragraph);

            // Ajoutez la cellule à la table
            table.AddCell(cell);

            // Ajoutez la table au document PDF
            doc.Add(table);

            doc.Close();

            // Affichez un message ou effectuez d'autres actions après la création du PDF
            MessageBox.Show("Téléchargement Avec Succées.", "Téléchargement PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}







