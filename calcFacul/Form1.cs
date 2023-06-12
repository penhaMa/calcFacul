using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calcFacul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double media, p1, trabalho;
            p1 = 0;
            media = 0;
            trabalho = 0;

            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    media = (6 - p1 * 0.32 - trabalho * 0.2) / 0.48;
                }
                this.Controls["resultado"].Text = media.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }

                this.Controls["resultado"].Text = "Você Precisa Tirar....";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
