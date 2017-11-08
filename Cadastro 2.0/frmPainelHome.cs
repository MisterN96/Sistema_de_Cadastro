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
using System.IO;

namespace Cadastro_2._0
{
    

    public partial class frmPainelHome : Form
    {
		static Cliente cliente;
		public float money;
		public frmPainelHome()
        {
            InitializeComponent();
			
		}
		/// <summary>
		/// Recebe OBj atuando como metodo intermediador para carregar um objto static
		/// </summary>
		/// <param name="clienteAutenticado"></param>
		public void recebeObj(Cliente clienteAutenticado)
		{
			cliente = clienteAutenticado;
		}
		/// <summary>
		/// todo responsavel por carregar labels e componentes da tela com Objeto static
		/// </summary>
		public void carregaTela()
		{
			
			nomeCliente.Text = cliente.nome;
			MemoryStream memory = new MemoryStream(cliente.foto);
			pictureBoxhome.Image = Image.FromStream(memory);

		}
		
		/// <summary>
		/// Exibe um combobox de produtos cadastrados
		/// </summary>
		public void carregaCombobox()
		{
			List<Produto> listaProduto = PedidoNegocio.enviarListadeNomesProduto();
			foreach (var produto in listaProduto)
			{
				cbxProdutos.Items.Add(produto.nomeprod);
				cbxProdutos.ValueMember = Convert.ToString(produto.Cod_PRO);
			}
		}

		public void GridViewComPedidosNaoFinalizados()
		{
			List<Carrinho> carrinhoLista = PedidoNegocio.pedidosNaoFinalizados(cliente.id);

			var list = (from carrinho in carrinhoLista
						select new {

							Nome_Produto = carrinho.nomeProduto_carrinho,
							Quantidade = carrinho.quantidadeProduto_carrinho,
							Valor = carrinho.valorProduto_carrinho,
							Data_do_Pedido = carrinho.dataDeCompra}).ToList();
			dataGridView3.DataSource = list;
		}

		private void frmPainelHome_Load(object sender, EventArgs e)
		{
			atualizaDinheiro();
			GridViewComPedidosNaoFinalizados();
			carregaCombobox();
			carregaTela();
		}
		/// <summary>
		/// metodo responsavel por mostar a hora em tempo real
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			lbHora.Text = DateTime.Now.ToString("HH:mm");
			lbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
		}

		/// <summary>
		/// evento do botao editar
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnEditar_Click(object sender, EventArgs e)
		{
			butonEditar();
		}

		/// <summary>
		/// Metodo responsavel pela chamada da função editar do botao
		/// </summary>
		public void butonEditar()
		{
			this.Hide();
			frmCadastroCliente clienteEditar = new frmCadastroCliente();
			
			Objeto.chamaEditar(cliente);
		}

		private void button1_Click(object sender, EventArgs e)
		{
				if(MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				logoof();
			}
		}
		public void logoof()
		{
			for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
			{
				if (Application.OpenForms[intIndex] != this)
					Application.OpenForms[intIndex].Close();
			}
		}

		private void btnFazerPedido_Click(object sender, EventArgs e)
		{
			Pedido pedido = new Pedido();
			Produto_Pedido pro_ped = new Produto_Pedido();
			pedido.cod_cli = cliente.id;
			pedido.data_pedido = Convert.ToDateTime(lbData.Text);
			pedido = PedidoNegocio.salvarPedido(pedido);
			pro_ped.ped_id = pedido.cod_ped;
			pro_ped.prod_id = Convert.ToInt32(cbxProdutos.ValueMember);
			pro_ped.quantidade = Convert.ToInt32(txbQuantidade.Value);
			PedidoNegocio.salvarProduto_Pedido(pro_ped);
			GridViewComPedidosNaoFinalizados();
		}
		public void inserirDinheiro()
		{
			Objeto.buscaDinheiro(cliente.id, float.Parse(lbDimdim.Text));
			atualizaDinheiro();
		}
		public void recebeValor(float valor)
		{
			money = valor;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			inserirDinheiro();
		}
		public void atualizaDinheiro()
		{
			Cliente clienteSosalario = ClienteNegocio.RetornarClienteId(cliente.id);
			lbDimdim.Text = clienteSosalario.carteira.ToString();
		}
	}

	
		
	
}

