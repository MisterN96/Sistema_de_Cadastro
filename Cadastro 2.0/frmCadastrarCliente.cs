using Cadastro.BO.Modelo;
using Cadastro.BO.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cadastro_2._0
{
	public partial class frmCadastroCliente : Form
    {
       



        bool Estatus = true;
        string genero;

        public frmCadastroCliente()
        {
            InitializeComponent();
            
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(Estatus == false)
            {
                editarCliente( txtBairro.Text, txtCep.Text, txtCpf.Text, txtEndereco.Text, txtNome.Text, txtNumero.Text, txtRg.Text, txtTelefone.Text, cbxCidade.Text, genero);

                MessageBox.Show("Edição feita com sucesso!");

                //criar um metodo para limpar tela
                limparCampos();
                Estatus = true;
                this.Close();
                
            }
            else
            {

                adicionarCliente();
               
            }
        }

        

        private void rdoMasc_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Masculino";
        }
        private void rdoFem_CheckedChanged(object sender, EventArgs e)
        {
            genero = "Feminino";
        }

       
        public void exibirCliente(Cliente cliente)
        {
            // aqui tenho que enviar o obj recebido para alteração

            txtNome.Text = cliente.nome;
            txtBairro.Text = cliente.bairro;
            txtCep.Text = cliente.cep.ToString();
            txtCpf.Text = cliente.cpf.ToString();
            txtEndereco.Text = cliente.endereco;
            txtNumero.Text = cliente.numero.ToString();
            txtRg.Text = cliente.rg.ToString();
            txtTelefone.Text = cliente.telefone.ToString();
            genero = cliente.sexo;
            cbxCidade.Text = cliente.cidade;
			if (genero == "Masculino")
			{
				rdoMasc.Checked = true;
			}
			else
			{
				rdoFem.Checked = true;
			}
           
            Estatus = false;
           
            this.ShowDialog();
            
        }

        public void adicionarCliente()
        {
         
            Cliente cliente = new Cliente();
          
            cliente.nome = txtNome.Text;
            cliente.cpf =txtCpf.Text;
            cliente.rg = txtRg.Text;
            cliente.sexo = genero;
            cliente.endereco = txtEndereco.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cep = txtCep.Text;
            cliente.cidade = cbxCidade.Text;
            cliente.numero = txtNumero.Text;
            cliente.telefone = txtTelefone.Text;
            Estatus = true;

			ClienteNegocio.adicionarNovoCliente(cliente);

            MessageBox.Show("Cadastrado com sucesso!");
			frmPainelHome home = new frmPainelHome();
            limparCampos();
			home.carregarNomesComboBox();

		}
        
        private void editarCliente( string Bairro, string Cep, string Cpf, string Endereco, string Nome, string Numero, string Rg, string Telefone, string cidade, string genero)
        {
            Cliente clienteEditado = new Cliente();

            clienteEditado.bairro = Bairro;
            clienteEditado.cep = Cep;
            clienteEditado.cidade = cidade;
            clienteEditado.cpf = Cpf;
            clienteEditado.endereco = Endereco;
            clienteEditado.nome = Nome;
            clienteEditado.numero = Numero;
            clienteEditado.rg = Rg;
            clienteEditado.telefone = Telefone;
            clienteEditado.cidade = cidade;
            clienteEditado.sexo = genero;

			ClienteNegocio.EditarCliente(clienteEditado);
          
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limparCampos()
        {
            txtBairro.Clear(); txtCep.Clear(); txtCpf.Clear();
            txtEndereco.Clear(); txtNome.Clear(); txtNumero.Clear();
            txtRg.Clear(); txtTelefone.Clear(); rdoFem.Checked = false;
			rdoMasc.Checked = false;

        }

        
    }
}
