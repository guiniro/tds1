using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Jogador1()
        {
            Lbl1.Visible = true;
            Txt1.Visible = true;
            BtnStart.Enabled = true;
        }
        private void Jogador2()
        {
            Jogador1();
            Lbl2.Visible = true;
            Txt2.Visible = true;
        }

        private void MnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuLocal1_Click(object sender, EventArgs e)
        {
            Jogador1();
        }

        private void MnuLocal2_Click(object sender, EventArgs e)
        {
            Jogador2();
        }

        private void MnuSobre_Click(object sender, EventArgs e)
        {
            //Sobre sobre = new Sobre();
            //sobre.MdiParent = this;
            //sobre.Show();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (Txt1.Text == "")
                MessageBox.Show("Informe o nome do jogador 1!");
            else
                if (Txt2.Visible && Txt2.Text == "")
                    MessageBox.Show("Informe o nome do jogador 2!");
                else
                    if (Txt2.Visible)
                        AbrirTelaInGame(2);
                    else
                        AbrirTelaInGame(1);
        }

        private void AbrirTelaInGame(int j)
        {
            InGame jogo;
            if (j == 1)
                jogo = new InGame(Txt1.Text);
            else
                jogo = new InGame(Txt1.Text, Txt2.Text);
            jogo.Show();
        }
    }
}