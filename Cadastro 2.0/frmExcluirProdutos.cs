using Cadastro.BO.Modelo;
using Cadastro.BO.Negocio;
using Cadastro.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cadastro_2._0
{
	public partial class frmExcluirProdutos : Form
    {
		int crescente,decresente;

		public frmExcluirProdutos()
        {
            InitializeComponent();
			cbxFiltros.SelectedIndex = 0;
		}

		#region BOTAO CRESCENTE E DECRESENTE

		private void btnDecrescente_Click(object sender, EventArgs e)
		{
			decresente = 0;
			exibirListaFiltroCrescenteDecresente(decresente);
		}
		
		private void btnCrescente_Click(object sender, EventArgs e)
		{
			crescente = 1;
			exibirListaFiltroCrescenteDecresente(crescente);
		}
		#endregion

		#region BOTAO ATUALIZAR

		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			List<Produto>listadeProdutos = ProdutoNegocio.ExibirListaSemFiltro();
			preencherGridViewComProduto(listadeProdutos);
		}
		#endregion

		#region BOTAO EDITAR
		
		private void btnEditar_Click(object sender, EventArgs e)
		{

			foreach (DataGridViewRow linhaSelecionada in dataGridView3.Rows)
			{

				if (linhaSelecionada.Cells[0].Value != null)
				{
					int cod_produto = Convert.ToInt32(linhaSelecionada.Cells[1].Value);

					retonarProdutoId(cod_produto);
					linhaSelecionada.Cells[0].Value = null;
					break;
				}
			}
		}
		#endregion

		#region BOTAO FILTRAR
		private void btnFiltar_Click(object sender, EventArgs e)
		{
			string filtro = cbxFiltros.Text;
			filtrar(txtPalavra.Text, filtro);
		}

		#endregion

		private void frmExcluirProdutos_Load(object sender, EventArgs e)
		{
			List<Produto> listasemFiltro =ProdutoNegocio.ExibirListaSemFiltro();
			preencherGridViewComProduto(listasemFiltro);

		}

	/// <summary>
	/// Método utilizado para poder deletar apartir de um id
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            if (txtExcluirProd.Text.Equals("") || txtExcluirProd.Text.Equals("0"))
            {
                MessageBox.Show("INSIRA UM VALOR VALIDO!");
            }
            else
            {
				ProdutoNegocio.deletarProduto(int.Parse(txtExcluirProd.Text));
            }

			List<Produto> listasemFiltro = ProdutoNegocio.ExibirListaSemFiltro();
			preencherGridViewComProduto(listasemFiltro);
		}
		
		/// <summary>
		/// Método é utilizado ´para retornar um produto atravez de um ID
		/// </summary>
		/// <param name="id"></param>
		public void retonarProdutoId(int id)
		{
			Produto produtoOriginal = ProdutoNegocio.RetornarProdutoId(id);

			frmCadastroProd cadProd = new frmCadastroProd();

			cadProd.exibirProduto(produtoOriginal);
		}

		/// <summary>
		/// Método utilizado para poder manipular os atributos da tabela
		/// </summary>
		public void exibirListaFiltroCrescenteDecresente(int valor)
		{
			List<Produto> listadeProduto = ProdutoNegocio.ExibirListaDecresouCrescente(valor);
			preencherGridViewComProduto(listadeProduto);
			
		}

		
		public void filtrar(string palavrapasse, string filtro)
		{
			List<Produto> listaFiltrada =ProdutoNegocio.ExibirListaFiltradaporString(palavrapasse, filtro);

			preencherGridViewComProduto(listaFiltrada);

		}

		/// <summary>
		/// Método é utilizado para exibir e preencher datagrid do  produto
		/// </summary>
		/// <param name="listadeProduto"></param>
		public void preencherGridViewComProduto(List<Produto> listadeProduto)
		{
			var exibPro = (from c in listadeProduto
						   select new
						   {
							   ID = c.Cod_PRO,
							   NOME = c.nomeprod,
							   TIPO = c.tipo_pro,
							   STATUS = c.status_prod,
							   FABRICAÇÃO = c.data_fabri,
							   VALIDADE = c.data_valid
						   }).ToList();

			dataGridView3.DataSource = exibPro;
		}

	}
}
