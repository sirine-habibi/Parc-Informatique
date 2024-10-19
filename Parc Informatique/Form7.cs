using MySqlX.XDevAPI.Relational;
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
    public partial class Form7 : Form
    {
        private Size normalSize;
        public Form7()
        {
            InitializeComponent();
            normalSize = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
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
        
        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.RoyalBlue;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
