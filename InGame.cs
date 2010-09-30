using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class InGame : Form
    {
        string jogador = "0";
        string jogador1, jogador2, jogador3;
        public InGame(string jogador1)
        {
            InitializeComponent();
            this.jogador1 = jogador1;
        }
        public InGame(string jogador1, string jogador2)
        {
            InitializeComponent();
            this.jogador1 = jogador1;
            this.jogador2 = jogador2;
            this.jogador3 = jogador3;
        }

        public void StatusDoJogo()
        {
            if (Btn11.Text == Btn12.Text && Btn12.Text == Btn13.Text && Btn11.Text != "")
                Vencedor(Btn11.Text);
            if (Btn21.Text == Btn22.Text && Btn21.Text == Btn23.Text && Btn21.Text != "")
                Vencedor(Btn21.Text);
            if (Btn31.Text == Btn32.Text && Btn32.Text == Btn33.Text && Btn31.Text != "")
                Vencedor(Btn31.Text);
            if (Btn11.Text == Btn21.Text && Btn21.Text == Btn31.Text && Btn11.Text != "")
                Vencedor(Btn11.Text);
            if (Btn12.Text == Btn22.Text && Btn22.Text == Btn32.Text && Btn12.Text != "")
                Vencedor(Btn12.Text);
            if (Btn13.Text == Btn23.Text && Btn23.Text == Btn33.Text && Btn13.Text != "")
                Vencedor(Btn13.Text);
            if (Btn11.Text == Btn22.Text && Btn22.Text == Btn33.Text && Btn11.Text != "")
                Vencedor(Btn11.Text);
            if (Btn13.Text == Btn22.Text && Btn22.Text == Btn31.Text && Btn13.Text != "")
                Vencedor(Btn13.Text);
            if (Btn11.Text != "" && Btn12.Text != "" && Btn13.Text != "" && Btn21.Text != "" && Btn22.Text != "" && Btn23.Text != "" && Btn31.Text != "" && Btn32.Text != "" && Btn33.Text != "")
            {
                MessageBox.Show("Empate!");
                this.Close();
            }
        }

        private void Vencedor(string p)
        {
            if (p == "X")
                MessageBox.Show(jogador1 + " Venceu!");
            else
                MessageBox.Show(jogador2 + " Venceu!");
            this.Close();
        }

        private string JogadorDaVez()
        {
            if (jogador == "X")
                jogador = "0";
            else
                jogador = "X";
            return jogador;
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            if (Btn11.Text == "")
                Btn11.Text = JogadorDaVez();
            StatusDoJogo();
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            if (Btn12.Text == "")
                Btn12.Text = JogadorDaVez();
            StatusDoJogo();
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            if (Btn13.Text == "")
                Btn13.Text = JogadorDaVez();
            StatusDoJogo();
        }

        private void Btn21_Click(object sender, EventArgs e)
        {
            if (Btn21.Text == "")
                Btn21.Text = JogadorDaVez();
            StatusDoJogo();
        }

        private void Btn22_Click(object sender, EventArgs e)
        {
            if (Btn22.Text == "")
                Btn22.Text = JogadorDaVez();
            StatusDoJogo();
        }

        private void Btn23_Click(object sender, EventArgs e)
        {
            if (Btn23.Text == "")
                Btn23.Text = JogadorDaVez();
            StatusDoJogo();
        }

        private void Btn31_Click(object sender, EventArgs e)
        {
            if (Btn31.Text == "")
                Btn31.Text = JogadorDaVez();
            StatusDoJogo();
        }

        private void Btn32_Click(object sender, EventArgs e)
        {
            if (Btn32.Text == "")
                Btn32.Text = JogadorDaVez();
            StatusDoJogo();
        }

        private void Btn33_Click(object sender, EventArgs e)
        {
            if (Btn33.Text == "")
                Btn33.Text = JogadorDaVez();
            StatusDoJogo();
        }
    }
}