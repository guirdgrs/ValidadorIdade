using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //Var para armazenar o nome completo da pessoa
            string nome = txbNome.Text;
            string sobrenome = txbSobrenome.Text;

            //Var para armazenar o ano de nascimento e calcular a idade
            int anoNascimento = int.Parse(txbAno.Text);
            int idade = (DateTime.Now.Year - anoNascimento);

            if (idade >= 18) //Condição - maior de idade
            {
                MessageBox.Show("Bem vindo! " + nome + " " + sobrenome + 
                    " Você tem " + idade + " anos então está permitido a entrada!");
                pibStatus.Image = Properties.Resources.AcessoPermitido; //Imagem de acesso permitido

                lblStatus.Text = "Status: Acesso Liberado";
                lblStatus.ForeColor = Color.Green;
            }
            else //Menor de idade
            {
                MessageBox.Show("Acesso Negado! " + nome + " " + sobrenome +
                    " Você tem " + idade + " anos, infelizmente você não poderá entrar");

                pibStatus.Image = Properties.Resources.Denied; //Imagem de acesso negado
                lblStatus.Text = "Status: Acesso Negado";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Botão limpar
            txbAno.Clear();
            txbNome.Clear();
            txbSobrenome.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Botão sair
            Application.Exit();
        }
    }
}
