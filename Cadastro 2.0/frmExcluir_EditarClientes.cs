using Cadastro_2._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; //Biblioteca System LINQ
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_2._0
{
    public partial class frmExcluir_EditarClientes : Form
    {
        
        int result = 0, contador = 0;


        public frmExcluir_EditarClientes()
        {
            InitializeComponent();
            cbxFiltos.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
            
            carregaLista();
          
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {


            if (txtDelete.Text.Equals("") || txtDelete.Text.Equals("0"))
            {
                MessageBox.Show("INSIRA UM VALOR VALIDO!");
            }
            else
            {
                foreach (Cliente cliente in Static.Listas.Clientes)
                {
                    if (cliente.id == int.Parse(txtDelete.Text))
                    {
                        Static.Listas.Clientes.Remove(cliente);
                        txtDelete.Clear();
                        break;
                    }

                }
            }


            carregaLista();
        }
        public void carregaLista()
        {

            var objcuston = (
                                  from c in
                                  Static.Listas.Clientes
                                  
                                select new
                                {

                                    ID = c.id,
                                    NOME = c.nome,
                                    SEXO = c.sexo,
                                    CPF = c.cpf,
                                    TELEFONE = c.telefone,
                                    RG = c.rg,
                                    CIDADE = c.cidade,
                                    BAIRRO = c.bairro,
                                    ENDEREÇO = c.endereco,
                                    NÚMERO = c.numero,
                                    CEP = c.cep

                                }

                             ).ToList();

           
            dataGridView1.DataSource = objcuston; 


        }

        private void frmExclusaoClientes_Load(object sender, EventArgs e)
        {
           
            carregaLista(); // metodo para carregar lista automaticamente quando abrir janela
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // envia o id do Chekbox marcado para o metodo editar lista
            while (result == 0)
            {
                foreach (DataGridViewRow selecionar in dataGridView1.Rows)
            {
                
                    if (selecionar.Cells[0].Value != null)
                    {
                        contador = selecionar.Index + 1;
                        editarLista(contador);
                        selecionar.Cells[0].Value = null;
                    }
                } 
            result = 1;
             }
            result = 0;           
        }
   
        public void editarLista(int id)
        {
            
      Cliente cliente = Static.Listas.RetornarClientePorID(id);

            frmCadastroCliente cadCliente = new frmCadastroCliente();
            
            cadCliente.receberCliente(cliente);
           
        }

        private void btnFiltar_Click(object sender, EventArgs e)
        {
             filtrarDados(txtFiltar.Text,cbxFiltos.Text);
            
        }

        private void btncrescente_Click(object sender, EventArgs e)
        {
           crescente();
            
        }

        private void btndecrescente_Click(object sender, EventArgs e)
        {
            decrescente();
        }

         
        // Organiza de A/Z todos os clientes
        public void crescente()
        {
            List<Cliente> retonoListaCliente = Static.Listas.crescente();

            var retorno = (from c in retonoListaCliente
                           select new
                           {
                               ID = c.id,
                               NOME = c.nome,
                               SEXO = c.sexo,
                               CPF = c.cpf,
                               TELEFONE = c.telefone,
                               RG = c.rg,
                               CIDADE = c.cidade,
                               BAIRRO = c.bairro,
                               ENDEREÇO = c.endereco,
                               NÚMERO = c.numero,
                               CEP = c.cep

                           }).ToList();

            dataGridView1.DataSource = retorno;
          
        }

        // Organiza de maneira decrescente os clientes
        public void decrescente()
        {


            List<Cliente> cliente_decrescente = Static.Listas.decrescente();
                
                
                  var retono =  (from c in cliente_decrescente
                                     select new
                                     {
                                         ID = c.id,
                                         NOME = c.nome,
                                         SEXO = c.sexo,
                                         CPF = c.cpf,
                                         TELEFONE = c.telefone,
                                         RG = c.rg,
                                         CIDADE = c.cidade,
                                         BAIRRO = c.bairro,
                                         ENDEREÇO = c.endereco,
                                         NÚMERO = c.numero,
                                         CEP = c.cep

                                     }).ToList();

            dataGridView1.DataSource = retono;
        }

        private void btnDeletChek_Click(object sender, EventArgs e)
        {

            while (result == 0)
            {
                foreach (DataGridViewRow selecionar in dataGridView1.Rows)
                {

                    if (selecionar.Cells[0].Value != null)
                    {

                        contador = selecionar.Index + 1;

                        deletarLista(contador);
                        selecionar.Cells[0].Value = null;

                    }

                }

                result = 1;

            }
            result = 0;

        }
        public void deletarLista(int id)
        {
            Static.Listas.deletar(id);
            carregaLista();
        }




        // filtra cliente diacordo com o que foi digirado na txtBox
        public void filtrarDados(string resultado, string check)
        {

            try
            {
                List<Cliente> filtrado =  Static.Listas.filtrar(resultado,check);

                var  cliente = (from c in filtrado
                                   select new
                                   {
                                       ID = c.id,
                                       NOME = c.nome,
                                       SEXO = c.sexo,
                                       CPF = c.cpf,
                                       TELEFONE = c.telefone,
                                       RG = c.rg,
                                       CIDADE = c.cidade,
                                       BAIRRO = c.bairro,
                                       ENDEREÇO = c.endereco,
                                       NÚMERO = c.numero,
                                       CEP = c.cep

                                   }).ToList();

                dataGridView1.DataSource = cliente;
            }
            catch (ArgumentNullException)
            {

                
            }
            catch (Exception)
            {

            }

        }

    }
}
