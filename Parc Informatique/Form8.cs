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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;

namespace Parc_Informatique
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
        public void SetData(string nomUtilisateur, string N_inventaire, string designation, string dateAchat, string dateAffectation, string N_serie, string serialKey, string combo1, string combo2, string combo3)
        {
            // Affichez les données dans les contrôles appropriés de Form3
            textBox1.Text = nomUtilisateur;
            textBox2.Text = N_inventaire;
            textBox3.Text = designation;
            textBox4.Text = dateAchat;
            textBox5.Text = dateAffectation;
            textBox6.Text = N_serie;
            textBox7.Text = serialKey;

            // Affichez les données des ComboBox
            textBox8.Text = combo1;
            textBox9.Text = combo2;
            textBox10.Text = combo3;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Collectez les données des labels ou des TextBox de Form3
            string nom = textBox1.Text;
            string numeroInventaire = textBox2.Text;
            string designation = textBox3.Text;
            string dateAchat = textBox4.Text;
            string dateAffectation = textBox5.Text;
            string N_serie = textBox6.Text;
            string serialKey = textBox7.Text;
            string combo1 = textBox8.Text;
            string combo2 = textBox9.Text;
            string combo3 = textBox10.Text;
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


       private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

