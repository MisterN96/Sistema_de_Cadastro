using System;
using Cadastro_2._0.Model;
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
    public partial class frmLogin : Form
    {
        frmExcluir_EditarClientes excluir = new frmExcluir_EditarClientes();
        static List<Cadastro> listacadastro = new List<Cadastro>();
        
        // static List<Cliente> listacliente = new List<Cliente>();
        //public static List<Cliente> listacliente { get; set; } // propriedade do tipo lista
        int ide = 0;
      
      



        bool validanome, validasenha;
        string login1="";
        string senha1="";
       
        public frmLogin()
        {
            InitializeComponent();

            Static.Listas.Iniciar();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmLoginCadastro logincadastro = new frmLoginCadastro();
            logincadastro.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            login1 = txtLogin.Text;
            senha1 = txtSenha.Text;
            comparar(login1,senha1);
            
            
        }
        public void salvarCadastro(string nome, string senha, string cpf)
        {
           
            Cadastro cadastropessoa = new Cadastro();

            cadastropessoa.nome = nome;
            cadastropessoa.senha = senha;
            cadastropessoa.cpf = cpf;

            listacadastro.Add(cadastropessoa);
        }
        public void comparar(string login1, string senha1)
        {

            foreach (Cadastro cad in listacadastro)
            { 
                if (cad.nome.Equals(login1))
                {
                    validanome = true;
                    if (cad.senha.Equals(senha1))
                    {

                        validasenha = true;
                        break;
                    }
                    else
                    {
                        validasenha = false;
                        
                    }


                }
                else
                {
                    validanome = false;
                    
                }
                
                
            }
            
            validarentrada(validanome, validasenha);

        }
        public void validarentrada(bool validanome , bool validasenha)
        {
            if (validanome == true & validasenha == true)
            {
                frmPainelHome usuario = new frmPainelHome();
                usuario.ShowDialog();
                txtLogin.Clear();
                txtSenha.Clear();
                
            }
            else
            {
                if(validanome == false & validasenha == false || validanome == true & validasenha == false || validanome == false & validasenha == true)
                {
                    MessageBox.Show("LOGIN OU SENHA INVALIDOS!");
                    txtLogin.Clear();
                    txtSenha.Clear();
                }
                
            }
        }
        public void salvarClientes(int id,string nome, string rg,string telefone, string cpf, string endereco, string numero, string bairro, string cep, string sexo, string cidade)
        {
            int contador = 2;

            Cliente cliente = new Cliente();
            ide = contador + 1;
            cliente.id = ide;
            cliente.nome = nome;
            cliente.rg = rg;
            cliente.telefone = telefone;
            cliente.cpf = cpf;
            cliente.endereco = endereco;
            cliente.numero = numero;
            cliente.bairro = bairro;
            cliente.cidade = cidade;
            cliente.cep = cep;
            cliente.sexo = sexo;


            Static.Listas.Clientes.Add(cliente);

           
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        
       
    }
    
       
  
   

       
    }

