using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula301121
{
    public partial class Form1 : Form
    {
        private bool _criado = false;
        public Form1()
        {
            InitializeComponent();

            Button btn = new();
            btn.Text = "Clique";
            btn.Width = 200;
            btn.Click += Btn_Click;

            button1.Click += Button1_Click;

            panel1.Controls.Add(btn);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Metodo dinamico de um botao estatico");
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("evento clique de um componente dinamico");
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!_criado)
            {
                Button btnNovo = new();
                panel2.Controls.Add(btnNovo);
                btnNovo.Location = new Point(int.Parse(textX.Text), int.Parse(textY.Text));
                btnNovo.Text = textNome.Text;
                _criado = true;
            }
            else
            {
               // panel2.Controls.Remove(btnNovo)
            }
        }

        private void TextCompleted(object sender, EventArgs e)
        {
            if (textNome.Text != "" && textX.Text != "" && textY.Text != "")
                btnCriar.Enabled = true;
        }
    }
}
