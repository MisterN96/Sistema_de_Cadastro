using System;
using Cadastro.BO.Negocio;
using Cadastro.BO.Modelo;
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
    

    public partial class frmPainelHome : Form
    {
        frmExcluirProdutos excluirProd = new frmExcluirProdutos();
        frmCadastroProd cadastroprod = new frmCadastroProd();
        frmLogin cad = new frmLogin();
       
        frmCadastroCliente cadastrocliente = new frmCadastroCliente();
        frmExcluir_EditarClientes exclusaoclientes = new frmExcluir_EditarClientes();

        public frmPainelHome()
        {
            InitializeComponent();
			exibirProdutos();

		}
		#region Botoes

		private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrocliente.ShowDialog();
        }

        private void eXCLUIRCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exclusaoclientes.ShowDialog();
      
        }

        private void cADASTRARPRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroprod.ShowDialog();
        }
        
        private void eXCLUIRPRODUTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excluirProd.ShowDialog();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		#endregion

		public void exibirProdutos()
		{

			List<Produto> listaProduto = ProdutoNegocio.ExibirListaSemFiltro();

			var listaProdutoEditado = (from produto in listaProduto
							 select new
							 {
								 Nome = produto.nomeprod,
								 Validade = produto.data_valid,
								 Status_do_Produto = produto.status_prod,
								 Tipo_do_Produto = produto.tipo_pro

							 }).ToList();

			dataGrid3.DataSource = listaProdutoEditado;

		}
	
		public  void carregarNomesComboBox()
		{
			List<Cliente> listadeNomes = PedidoNegocio.enviarListadeNomesCliente();

			foreach (Cliente clientes in listadeNomes)
			{
				cmbListadeNomes.Items.Add(clientes.nome);
			}
		}
		public  void carregarNomesdeProdutoComboBox()
		{
			List<Produto> listaProdutos = PedidoNegocio.enviarListaNomeProduto();

			foreach (Produto produto in listaProdutos)
			{
				cmbNomeProduto.Items.Add(produto.nomeprod);
			}
		}

		private void frmPainelHome_Load(object sender, EventArgs e)
		{
			carregarNomesComboBox();
			carregarNomesdeProdutoComboBox();
		}

		
	}
}

