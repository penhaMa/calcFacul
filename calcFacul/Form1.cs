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
            double p1, traba ,n1, n2, valor, valor1,num1,num2,num3;
            p1 = 0;
            traba = 0;
            n1 = 0;
            n2 = 0;
            num1 = 0;
            num2 = 0;
            num3 = 0;
            
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    n1 = Convert.ToSingle(((TextBox)controle).Text);
                    p1 += n1;

                    n2 = Convert.ToSingle(((TextBox)controle).Text);
                    traba += n2;
                }
                num1 = 32 / 100;
                num2 = 20 / 100;
                num3 = 48 / 100;
                valor = 6 - (p1 * num1) - (traba * num2);
                valor1 = valor / num3;
                this.Controls["label3"].Text = valor1.ToString();
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

                this.Controls["label3"].Text = "Você Precisa Tirar....";
            }
        }
    }
}
