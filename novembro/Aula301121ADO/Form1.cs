using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula301121ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco banco = new();

            string sql = "select * from programadores";

            DataTable dt = new();

            dt = banco.ExecutarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Programadores prog = new();

            prog.Nome = txtNome.Text;
            prog.Linguagem = txtLinguagem.Text;
            prog.Banco = txtLinguagem.Text;

            bool retorno = prog.GravarProgramador();

            if (retorno)
                MessageBox.Show("Gravado com sucesso!");

            else
                MessageBox.Show("Erro ao gravar");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Programadores prog = new();
            prog = prog.ConsultaProgramador(int.Parse(textBox1.Text));
            MessageBox.Show(prog.Nome);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Programadores prog = new();
            prog = prog.ConsultaProgramador(int.Parse(uId.Text));

            prog.Banco = uBank.Text == "" ? prog.Banco : uBank.Text;
            prog.Nome = uName.Text == "" ? prog.Nome : uName.Text;
            prog.Linguagem = uLing.Text == "" ? prog.Linguagem : uLing.Text;

            bool retorno = prog.AtualizarProgramador();

            if(retorno)
                MessageBox.Show("Atualizado com sucesso!");

            else
                MessageBox.Show("Erro ao atualizar");
        }

        private void uId_TextChanged(object sender, EventArgs e)
        {

            if (uId.Text != "")
            {
                Programadores prog = new();
                prog = prog.ConsultaProgramador(int.Parse(uId.Text));

                if (prog == null)
                    MessageBox.Show("Id não existe!");

                else
                    btnAtualizar.Enabled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Programadores prog = new();
            prog = prog.ConsultaProgramador(int.Parse(delId.Text));

            bool result = prog.ExcluirProgramador();

            if (result)
                MessageBox.Show("Programador deletado!");

            else
                MessageBox.Show("Erro ao excluir");
        }
    }
}
