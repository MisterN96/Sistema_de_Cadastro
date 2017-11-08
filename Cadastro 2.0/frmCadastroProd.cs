using Cadastro.BO.Negocio;
using Cadastro.BO.Modelo;
using System;
using System.Windows.Forms;

namespace Cadastro_2._0
{
	public partial class frmCadastroProd : Form
    {
	
        bool status = false;
        string tipoProdu ;
		string statusProdu;
        int ide;
		DateTime fabricacao;
		DateTime validade;




		public frmCadastroProd()
        {
            InitializeComponent();
			
        }

        private void rdoPerecivel_CheckedChanged(object sender, EventArgs e)
        {
            tipoProdu = "Perecivel";
        }
        private void rdoNaoPerecivel_CheckedChanged(object sender, EventArgs e)
        {
			tipoProdu = "Não Perecivel";
        }
		private void rdNatural_CheckedChanged(object sender, EventArgs e)
		{
			statusProdu = "Natural";
		}

		private void rdIndus_CheckedChanged(object sender, EventArgs e)
		{
			statusProdu = "Industrializado";
		}

		

		private void btnSalvar_Click(object sender, EventArgs e)
        {
			validade = dtVali.Value;
			fabricacao = dtFabr.Value;
			if (fabricacao > validade )
			{
				MessageBox.Show("Data de FABRICAÇÃO não pode ser maior que data de VALIDADE!");
			}
			else
			{

				if (status == false)
				{
					adicionarNovoProduto();
					MessageBox.Show("Cadastro feito com sucesso!");
					frmPainelHome home = new frmPainelHome();
					limparCampos();
					home.carregarNomesdeProdutoComboBox();


				}
				else
				{
					SalvarDados( txtNomeProd.Text, validade, fabricacao, statusProdu, tipoProdu);
					MessageBox.Show("Edição feita com sucesso!");
					this.Close();
					
				}
			}

		}
		
		
		private void btnCancelar_Click(object sender, EventArgs e)
        {
			limparCampos();

			this.Close();
        }

		public void adicionarNovoProduto()
		{
			Produto produto = new Produto();

                produto.nomeprod = txtNomeProd.Text;
                produto.status_prod = statusProdu;
                produto.tipo_pro = tipoProdu;
                produto.data_fabri = fabricacao;
                produto.data_valid = validade;

               ProdutoNegocio.adicionarNovoProduto(produto);
           
        }
		public void exibirProduto(Produto produto)
		{

            ide = produto.Cod_PRO;
            txtNomeProd.Text = produto.nomeprod;
			dtVali.Value = produto.data_valid;
			dtFabr.Value = produto.data_fabri;
			tipoProdu = produto.tipo_pro;
			statusProdu = produto.status_prod;
			if (tipoProdu == "Não Perecivel")
			{
				rdoNaoPerecivel.Checked = true;
				
			}
			else
			{
				rdoPerecivel.Checked = true;
			}

			if (statusProdu == "Natural")
			{
				rdNatural.Checked = true;
			
			}
			else
			{

				rdIndus.Checked = true;
			}
			status = true;
            this.Show();
			

		}
        public void SalvarDados(string txtnome, DateTime validade, DateTime fabricacao, string status, string tipo)
        {
			Produto produtoEdi = new Produto();

            produtoEdi.nomeprod = txtnome;
            produtoEdi.data_valid = validade;
            produtoEdi.data_fabri = fabricacao;
            produtoEdi.tipo_pro = tipo;
            produtoEdi.status_prod = status;

            ProdutoNegocio.EditarProduto(produtoEdi);
            
        }
		public void limparCampos()
		{ 
			
			txtNomeProd.Clear();
			rdNatural.Checked = false;
			rdIndus.Checked = false;
			rdoNaoPerecivel.Checked = false;
			rdoPerecivel.Checked = false;
		}


	}
}
