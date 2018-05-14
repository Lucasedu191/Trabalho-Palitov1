using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Palitov1
{
    public partial class FormPalito : Form
    {
        public FormPalito()
        {
            InitializeComponent();
        }
        private int computador = 0; // variável para calcular o valor da PA
        private int inicio = 0; // variável para valores do inicio escolhido pelo usuário de 20 a 30
        private int palitos = 0; // variável para receber a retirada de palitos de 1 a 3
        private int resto = 0; // resultado dos valores que vão diminuindo após a retirada de palitos
        
        private void Btnjogar_Click(object sender, EventArgs e)
        {
			Btnretirar.Visible = true; Maskbxpalitos.Visible = true;// campos que irão ficar habilitados após clicar em jogar
            Numqtdpalitos.Enabled = false; Lblquantospalitos.Visible = true; Btnjogar.Enabled = false;

            inicio =(int)Numqtdpalitos.Value; // deixando o numericbox como valor de inicio
            //valores que serão jogados pelo computador na jogada inicial dependo do valor inicia com 1 ou 2 ou 3
            if (inicio == 20 ||inicio == 21 || inicio ==24 || inicio ==25 || inicio ==28 || inicio ==29 ) 
                 palitos = 3; 
            else if (inicio == 22 || inicio == 26 || inicio == 30) 
              palitos = 1;
            else if (inicio == 23 || inicio == 27)
                palitos = 2;
            inicio = inicio- palitos; // faz o resultado da conta do inicio menos o valor retirado na primeira jogada
            RichTextBoxpalito.AppendText("Eu começo!! "+ Environment.NewLine);
            RichTextBoxpalito.AppendText("Retiro" + palitos.ToString() + " Palitos"+ Environment.NewLine);
            RichTextBoxpalito.AppendText("Restam " + (inicio.ToString()) + " palitos"+ Environment.NewLine);
            RichTextBoxpalito.AppendText("sua vez... "+ Environment.NewLine);
            Maskbxpalitos.Focus(); // deixa o cursor habilitado no masked
        }
        private void Btnretirar_Click(object sender, EventArgs e)
        {
            if (Maskbxpalitos.Text == "") // se o usuário não colocar valor algum aparece a mensagem de erro
            {
                MessageBox.Show("preechimento obrigatório da quantidade de palitos a remover", "Atenção");
                Maskbxpalitos.Focus();
                return;
            }
            palitos = Convert.ToInt16(Maskbxpalitos.Text); //converte msk para int do campo em que é colocado os numeros de palitos pelo usuario
            if (palitos == 0 || palitos >= 4)// faz a verificação se for 0 ou maior que 3, exibe msg de erro
            {
                MessageBox.Show("É permitido retirar de 1 a 3 palitos");
                Maskbxpalitos.Focus();
                return;
            }
            if (inicio == 2 & palitos == 3 | inicio == 1 & palitos == 3 | inicio == 1 & palitos == 2) // mensagem erro de quantidade for diferente do que precisa ser jogado
            {
                MessageBox.Show("Não é possível retirar essa quantidade de palitos!", "Palitos Insuficientes");
                Maskbxpalitos.Focus();
                return;
            }
     
            else
            {
                Maskbxpalitos.Clear(); // llimpa o campo para colocar o numero para a proxima jogada
                if (palitos == 2)
                {
                    if (inicio % 2 == 0) // div mod para se o numero for par ele retirar 3 ou dois se for impar
                        computador = 3;
                    else
                        computador = 2;
                }
                if (palitos == 3)// div mod para se o numero for par ele retirar 2 ou dois se for impar
                {
                    if (inicio % 2 == 0)
                        computador = 2;
                    else
                        computador = 1;
                }
                if (palitos == 1) // realiza o calc da Progressão 4 diminuindo o valor que o usuario colocou menos 4 o resultado é o valor do pc
                    computador = 4 - palitos;
                RichTextBoxpalito.AppendText("Você retirou  " + (palitos.ToString()) + " Palitos" + Environment.NewLine);
                
                inicio = inicio - palitos; // indica na tela quantos palitos restam para acabar o jogo
                if (inicio <= 0) // caso quando o computador ganha
                {
                    MessageBox.Show("você perdeu...", "kkkkkk Muito Fácil!!");
                    DialogResult SIM_NAO = MessageBox.Show("deseja jogar denovo", "Desafio", MessageBoxButtons.YesNo);
                    if (SIM_NAO == DialogResult.Yes)
                        Application.Restart(); // reinicia o jogo
                    else
                        Application.Exit(); // sai do jogo 
                }
                if (inicio == 1) //  caso quando o computador perde 
                {
                    MessageBox.Show("Eu Perdi!", "Impossível!!");
                    DialogResult SIM_NAO = MessageBox.Show("deseja jogar denovo", "Desafio", MessageBoxButtons.YesNo);
                    if (SIM_NAO == DialogResult.Yes)
                        Application.Restart();// reinicia o jogo
                    else
                        Application.Exit();// sai do jogo 
                    return;
                }
                // mensagens que aparecerão na tela,  utilizando as variaveis inicio, computador, resto
                RichTextBoxpalito.AppendText("Restam " + (inicio.ToString()) + " palitos" + Environment.NewLine);
                RichTextBoxpalito.AppendText("Eu retiro " + (computador.ToString()) + " Palitos" + Environment.NewLine);
                RichTextBoxpalito.AppendText("sua vez... " + Environment.NewLine);
                resto = inicio - computador;
                RichTextBoxpalito.AppendText("Restam " + (resto.ToString()) + " palitos" + Environment.NewLine);
                inicio = resto;
                Maskbxpalitos.Focus();
                RichTextBoxpalito.ScrollToCaret();
            }
        }
    }
}
