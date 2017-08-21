using Cadastro_2._0.Model;
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
    public partial class frmCadastroCliente : Form
    {
       



        int id_cliente = 0;
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
                editarCliente( txtBairro.Text, txtCep.Text, txtCpf.Text, txtEndereco.Text, txtNome.Text, txtNumero.Text, txtRg.Text, txtTelefone.Text, cbxCidade.Text, genero,id_cliente);

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

        // recebe um cliente marcado
        public void receberCliente(Cliente cliente)
        {
            // aqui tenho que enviar o obj recebido para alteração

            txtNome.Text = cliente.nome;
            txtBairro.Text = cliente.bairro;
            txtCep.Text = cliente.cep;
            txtCpf.Text = cliente.cpf;
            txtEndereco.Text = cliente.endereco;
            txtNumero.Text = cliente.numero;
            txtRg.Text = cliente.rg;
            txtTelefone.Text = cliente.telefone;
            genero = cliente.sexo;
            cbxCidade.Text = cliente.cidade;
            id_cliente = cliente.id;
            Estatus = false;
           
            this.ShowDialog();
            
        }

        public void adicionarCliente()
        {
          //TODO: setar o ID sem for com apenas um comando

         
       
            Cliente cliente = new Cliente();
          
            cliente.id = Static.Listas.Clientes.Count + 1 ;
            cliente.nome = txtNome.Text;
            cliente.cpf = txtCpf.Text;
            cliente.rg = txtRg.Text;
            cliente.sexo = genero;
            cliente.endereco = txtEndereco.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cep = txtCep.Text;
            cliente.cidade = cbxCidade.Text;
            cliente.numero = txtNumero.Text;
            cliente.telefone = txtTelefone.Text;
            Estatus = true;

            Static.Listas.InserirCliente(cliente);

            MessageBox.Show("Cadastrado com sucesso!");

            limparCampos();

        }
        
        private void editarCliente( string Bairro, string Cep, string Cpf, string Endereco, string Nome, string Numero, string Rg, string Telefone, string cidade, string genero, int id_cliente)
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
            clienteEditado.id = id_cliente;
            clienteEditado.telefone = Telefone;
            clienteEditado.cidade = cidade;
            clienteEditado.sexo = genero;
     
            Static.Listas.AlterarCliente(clienteEditado);
          
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limparCampos()
        {
            txtBairro.Clear(); txtCep.Clear(); txtCpf.Clear();
            txtEndereco.Clear(); txtNome.Clear(); txtNumero.Clear();
            txtRg.Clear(); txtTelefone.Clear(); genero = null;

        }

        
    }
}
