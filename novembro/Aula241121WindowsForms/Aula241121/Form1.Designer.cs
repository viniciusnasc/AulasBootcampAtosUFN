
namespace Aula241121
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.confirmar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.Somar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelIdadeNao = new System.Windows.Forms.Label();
            this.LabelIdadeSim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.groupParImpar = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnDireita = new System.Windows.Forms.Button();
            this.BtnEsquerda = new System.Windows.Forms.Button();
            this.BtnCentral = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmar
            // 
            this.confirmar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmar.Location = new System.Drawing.Point(16, 115);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(159, 23);
            this.confirmar.TabIndex = 0;
            this.confirmar.Text = "confirmar";
            this.confirmar.UseVisualStyleBackColor = false;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(16, 50);
            this.txbNome.Multiline = true;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(159, 19);
            this.txbNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o seu nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primeiro numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Segundo numero";
            // 
            // Numero1
            // 
            this.Numero1.Location = new System.Drawing.Point(48, 47);
            this.Numero1.Multiline = true;
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(99, 19);
            this.Numero1.TabIndex = 5;
            // 
            // Numero2
            // 
            this.Numero2.Location = new System.Drawing.Point(48, 87);
            this.Numero2.Multiline = true;
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(99, 19);
            this.Numero2.TabIndex = 6;
            // 
            // Somar
            // 
            this.Somar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Somar.Location = new System.Drawing.Point(48, 125);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(101, 23);
            this.Somar.TabIndex = 7;
            this.Somar.Text = "Realizar soma";
            this.Somar.UseVisualStyleBackColor = false;
            this.Somar.Click += new System.EventHandler(this.Somar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelIdadeNao);
            this.groupBox1.Controls.Add(this.LabelIdadeSim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbIdade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Controls.Add(this.confirmar);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome";
            // 
            // LabelIdadeNao
            // 
            this.LabelIdadeNao.AutoEllipsis = true;
            this.LabelIdadeNao.AutoSize = true;
            this.LabelIdadeNao.Location = new System.Drawing.Point(86, 156);
            this.LabelIdadeNao.Name = "LabelIdadeNao";
            this.LabelIdadeNao.Size = new System.Drawing.Size(29, 15);
            this.LabelIdadeNao.TabIndex = 7;
            this.LabelIdadeNao.Text = "Nao";
            // 
            // LabelIdadeSim
            // 
            this.LabelIdadeSim.AutoEllipsis = true;
            this.LabelIdadeSim.AutoSize = true;
            this.LabelIdadeSim.Location = new System.Drawing.Point(58, 156);
            this.LabelIdadeSim.Name = "LabelIdadeSim";
            this.LabelIdadeSim.Size = new System.Drawing.Size(27, 15);
            this.LabelIdadeSim.TabIndex = 6;
            this.LabelIdadeSim.Text = "Sim";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Voce é maior de idade?";
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(16, 90);
            this.txbIdade.Multiline = true;
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(159, 19);
            this.txbIdade.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Insira a sua idade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblResultado);
            this.groupBox2.Controls.Add(this.Numero2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Somar);
            this.groupBox2.Controls.Add(this.Numero1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 180);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soma";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(48, 109);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(111, 15);
            this.LblResultado.TabIndex = 8;
            this.LblResultado.Text = "A soma resulta em: ";
            // 
            // groupParImpar
            // 
            this.groupParImpar.Location = new System.Drawing.Point(218, 198);
            this.groupParImpar.Name = "groupParImpar";
            this.groupParImpar.Size = new System.Drawing.Size(200, 47);
            this.groupParImpar.TabIndex = 10;
            this.groupParImpar.TabStop = false;
            this.groupParImpar.Text = "ParAzul-ImparVermelho";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnDireita);
            this.groupBox3.Controls.Add(this.BtnEsquerda);
            this.groupBox3.Controls.Add(this.BtnCentral);
            this.groupBox3.Location = new System.Drawing.Point(424, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 227);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Centralizar";
            // 
            // BtnDireita
            // 
            this.BtnDireita.Location = new System.Drawing.Point(202, 106);
            this.BtnDireita.Name = "BtnDireita";
            this.BtnDireita.Size = new System.Drawing.Size(75, 23);
            this.BtnDireita.TabIndex = 2;
            this.BtnDireita.Text = "Direita";
            this.BtnDireita.UseVisualStyleBackColor = true;
            this.BtnDireita.Click += new System.EventHandler(this.BtnDireita_Click);
            // 
            // BtnEsquerda
            // 
            this.BtnEsquerda.Location = new System.Drawing.Point(76, 106);
            this.BtnEsquerda.Name = "BtnEsquerda";
            this.BtnEsquerda.Size = new System.Drawing.Size(75, 23);
            this.BtnEsquerda.TabIndex = 1;
            this.BtnEsquerda.Text = "Esquerda";
            this.BtnEsquerda.UseVisualStyleBackColor = true;
            this.BtnEsquerda.Click += new System.EventHandler(this.BtnEsquerda_Click);
            // 
            // BtnCentral
            // 
            this.BtnCentral.Location = new System.Drawing.Point(145, 41);
            this.BtnCentral.Name = "BtnCentral";
            this.BtnCentral.Size = new System.Drawing.Size(75, 23);
            this.BtnCentral.TabIndex = 0;
            this.BtnCentral.Text = "Central";
            this.BtnCentral.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 374);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupParImpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Numero1;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.Button Somar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.GroupBox groupParImpar;
        private System.Windows.Forms.Label LabelIdadeNao;
        private System.Windows.Forms.Label LabelIdadeSim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnDireita;
        private System.Windows.Forms.Button BtnEsquerda;
        private System.Windows.Forms.Button BtnCentral;
    }
}

