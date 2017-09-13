using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_2._0
{
    public partial class frmLoginCadastro : Form
    {


        //string nome = "";
        //string senha = "";
        //string cpefinho = "";
        //bool validacpf,validanome,validasenha;

        public frmLoginCadastro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        //private void btnSalvarCad_Click(object sender, EventArgs e)
        //{

        //    frmLogin frmcadastro = new frmLogin();

        //    if (txtNome.Text == "")
        //    {
        //        validanome = false;
        //        MessageBox.Show("Favor preencher o campo LOGIN!");
        //    }
        //    else
        //    {
        //        validanome = true;
        //        nome = txtNome.Text;
        //    }
        //    if (txtSenha.Text == "")
        //    {
        //        validasenha = false;
        //        MessageBox.Show("Favor inserir SENHA");

        //    }else
        //    {
        //        if (txtSenha.Text.Length <= 5)
        //        {
        //            validasenha = false;
        //            MessageBox.Show("Favor inserir SENHA com mais  de 5 digitos!");
        //        }
        //        else
        //        {
        //            validasenha = true;
        //            senha = txtSenha.Text;
        //        }
        //    }
                        
        //    bool result = validarcpf(txtCpf.Text);
        //    if (result == true)
        //    {
        //        validacpf = true;
        //        lblValida.Text = "Valido";
        //        cpefinho = txtCpf.Text;
            
        //    }
        //    else
        //    {
        //        validacpf = false;
        //        lblValida.Text = "Inválido";
        //        txtCpf.Clear();
        //        if (lblValida.Text.Equals("Inválido") || lblValida.Text.Equals(""))
        //        {
        //            validacpf = true;
        //            MessageBox.Show("Favor inserir um CPF valido!");
        //        }
        //    }
        //    if (validacpf == true && validanome == true && validasenha == true)
        //    {
        //        frmcadastro.salvarCadastro(nome, senha, cpefinho);
        //        MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!");
        //        this.Close();
        //    }
          
        //}
        


        public bool validarcpf(string cpf)
        {
            cpf = cpf.Replace(",","").Replace("-","").Replace(" ","");
            string cpf1 = cpf;
            int soma = 0,result,contador=2;
            int[] dig1 = new int[9] { 10 ,9 ,8 , 7, 6 , 5, 4, 3, 2 };
            int[] dig2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            if(cpf.Length != 11)
            {
                return false;
            }
            if (cpf.Equals("11111111111") || cpf.Equals("22222222222") || cpf.Equals("33333333333") ||
                cpf.Equals("44444444444") || cpf.Equals("55555555555") || cpf.Equals("66666666666") ||
                cpf.Equals("77777777777") || cpf.Equals("88888888888") || cpf.Equals("99999999999") ||
                cpf.Equals("00000000000"))
            {
                return false;
            }
            cpf = cpf.Substring(0, 9);

            for (int i = 0; i < cpf.Length; i++)
            {
                dig1[i] = int.Parse(cpf[i].ToString());
            }
            for(int i = cpf.Length - 1; i >= 0; i--)
            {
                soma = soma + dig1[i] * contador;
                contador = contador + 1;
            }
            result = soma % 11;
            if (result < 2)
            {
                result = 0;
                cpf = cpf + result.ToString();
            }
            else
            {
                result = 11 - result;
                cpf = cpf + result.ToString();
            }

            soma = 0;
            result = 0;
            contador = 2;
            for (int i = 0; i < cpf.Length; i++)
            {
                dig2[i] = int.Parse(cpf[i].ToString());
            }
            for (int i = cpf.Length - 1; i >= 0; i--)
            {
                soma = soma + dig2[i] * contador;
                contador = contador + 1;
            }
            result = soma % 11;
            if (result < 2)
            {
                result = 0;
                cpf = cpf + result.ToString();

            }
            else
            {
                result = 11 - result;
                cpf = cpf + result.ToString();
            }
            if(cpf.Equals(cpf1))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        
    }
}
