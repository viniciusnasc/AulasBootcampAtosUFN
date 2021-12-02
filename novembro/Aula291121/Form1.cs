using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula291121
{
    public partial class Form1 : Form
    {
        bool vezX = false;
        int Count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            vezX = true;

            lblVez.Text = "X";

            BotoesEnable();
            btnX.Enabled = false;
            btnO.Enabled = false;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            vezX = false;

            lblVez.Text = "O";

            BotoesEnable();
            btnX.Enabled = false;
            btnO.Enabled = false;
        }

        private void btnReinicia_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;

            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";

            lblVez.Text = " - ";
            lblVencedor.Text = " - ";

            btnX.Enabled = true;
            btnO.Enabled = true;

            Count = 0;
        }

        private void BotoesEnable()
        {
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
        }

        private void BotoesEnableF()
        {
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Count++;
            Button btn = (Button)sender;
            btn.Text = lblVez.Text;
            btn.Enabled = false;

            if (vezX)
                lblVez.Text = "O";

            else
                lblVez.Text = "X";

            vezX = !vezX;

            if(!VerificaVencedor())
            {
                if(Count >=9)
                {
                    btn.Text = lblVez.Text;
                    lblVez.Text = "-";
                    btn.Enabled = false;
                    MessageBox.Show("Empate");
                }
            }
        }

        private bool VerificaVencedor()
        {
            if(button3.Text == button4.Text && button4.Text == button5.Text && button5.Text != "")
            {
                lblVencedor.Text = button3.Text;
                MessageBox.Show(button3.Text + " é o vencedor!");
                BotoesEnableF();
                return true;
            }
            else if(button3.Text == button6.Text && button6.Text == button9.Text && button9.Text !="")
            {
                lblVencedor.Text = button3.Text;
                MessageBox.Show(button3.Text + " é o vencedor!");
                BotoesEnableF();
                return true;
            }
            else if (button3.Text == button7.Text && button7.Text == button11.Text && button11.Text != "")
            {
                lblVencedor.Text = button3.Text;
                MessageBox.Show(button3.Text + " é o vencedor!");
                BotoesEnableF();
                return true;
            }
            else if (button4.Text == button7.Text && button7.Text == button10.Text && button10.Text != "")
            {
                lblVencedor.Text = button4.Text;
                MessageBox.Show(button4.Text + " é o vencedor!");
                BotoesEnableF();
                return true;
            }
            else if (button5.Text == button7.Text && button7.Text == button9.Text && button9.Text != "")
            {
                lblVencedor.Text = button5.Text;
                MessageBox.Show(button5.Text + " é o vencedor!");
                BotoesEnableF();
                return true;
            }
            else if (button5.Text == button8.Text && button8.Text == button11.Text && button11.Text != "")
            {
                lblVencedor.Text = button5.Text;
                MessageBox.Show(button5.Text + " é o vencedor!");
                BotoesEnableF();
                return true;
            }
            else if (button6.Text == button7.Text && button6.Text == button8.Text && button7.Text != "")
            {
                lblVencedor.Text = button6.Text;
                MessageBox.Show(button6.Text + " é o vencedor!");
                BotoesEnableF();
                return true;
            }
            else if (button9.Text == button10.Text && button11.Text == button9.Text && button9.Text != "")
            {
                lblVencedor.Text = button9.Text;
                MessageBox.Show(button9.Text + " é o vencedor!");
                BotoesEnableF();
                return true;
            }
            return false;
        }
    }
}
