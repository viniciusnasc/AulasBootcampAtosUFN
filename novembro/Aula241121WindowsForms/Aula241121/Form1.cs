using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula241121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(txbIdade.Text);

            if (idade >= 18)
                LabelIdadeSim.Font = new Font(this.Font, FontStyle.Bold);

            else
                LabelIdadeNao.Font = new Font(this.Font, FontStyle.Bold);

            MessageBox.Show("Seu nome é " + txbNome.Text);
        }

        private void Somar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(Numero1.Text);
            int num2 = int.Parse(Numero2.Text);
            int resultado = num1+num2;

            LblResultado.Text = $"A soma de {Numero1.Text} + {Numero2.Text} = {resultado}";

            if (resultado % 2 == 0)
                groupParImpar.BackColor = Color.Blue;

            else
                groupParImpar.BackColor = Color.Red;

            MessageBox.Show($"A soma de {Numero1.Text} + {Numero2.Text} = { int.Parse(Numero1.Text) + int.Parse(Numero2.Text)}");

        }

        private void BtnEsquerda_Click(object sender, EventArgs e)
        {
            BtnCentral.Left -= 10;
        }

        private void BtnDireita_Click(object sender, EventArgs e)
        {
            BtnCentral.Left += 10;
        }
    }
}
