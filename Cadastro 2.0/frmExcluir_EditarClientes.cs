using Cadastro.BO.Negocio;
using Cadastro.BO.Modelo;
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

		int crescente, decrescente;
			

        public frmExcluir_EditarClientes()
        {
            InitializeComponent();
            cbxFiltos.SelectedIndex = 0;

        }

        

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
			List<Cliente> todosCli = ClienteNegocio.ExibirListaSemFiltro();
			carregaLista(todosCli);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
			if (txtDelete.Text.Equals("") || txtDelete.Text.Equals("0"))
			{
				MessageBox.Show("INSIRA UM VALOR VALIDO!");
			}
			else
			{

				ClienteNegocio.deletarCliente(int.Parse(txtDelete.Text));

			}

			List<Cliente> todosCli = ClienteNegocio.ExibirListaSemFiltro();
			carregaLista(todosCli);
		}


        private void frmExclusaoClientes_Load(object sender, EventArgs e)
        {

			List<Cliente> todosCli = ClienteNegocio.ExibirListaSemFiltro();
			carregaLista(todosCli);
		}

        private void btnEditar_Click(object sender, EventArgs e)
        {
			foreach (DataGridViewRow linhaSelecionada in dataGridView1.Rows)
			{

				if (linhaSelecionada.Cells[0].Value != null)
				{
					int cod_produto = Convert.ToInt32(linhaSelecionada.Cells[1].Value);

					retornarid(cod_produto);
					linhaSelecionada.Cells[0].Value = null;
					break;
				}
			}
		}
   
        public void retornarid(int id)
        {

			Cliente cliente = ClienteNegocio.RetornarClienteId(id);

			frmCadastroCliente cadCliente = new frmCadastroCliente();
            
            cadCliente.exibirCliente(cliente);
           
        }

        private void btnFiltar_Click(object sender, EventArgs e)
        {
            List<Cliente> listaFiltrada = ClienteNegocio.ExibirListaFiltradaporString(txtFiltar.Text,cbxFiltos.Text);
			carregaLista(listaFiltrada);
        }

        private void btncrescente_Click(object sender, EventArgs e)
        {
			crescente = 1;
		List<Cliente>listaCrescente=ClienteNegocio.ExibirListaDecresouCrescente(crescente);
			carregaLista(listaCrescente);
        }

        private void btndecrescente_Click(object sender, EventArgs e)
        {
			decrescente = 0;
			List<Cliente>listaDecrescente = ClienteNegocio.ExibirListaDecresouCrescente(decrescente);
			carregaLista(listaDecrescente);
        }

        


		public void carregaLista(List<Cliente>listaCliente)
		{
			


			var objcuston = (from c in listaCliente

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





	}
}
