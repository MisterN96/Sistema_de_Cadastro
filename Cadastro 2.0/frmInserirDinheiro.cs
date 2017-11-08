using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro.BO.Negocio;
using Cadastro.BO.Modelo;

namespace Cadastro_2._0
{
	public partial class frmInserirDinheiro : Form
	{
		float dinheiro;
		int idCliente;
		string senhadoCli;
		
		public frmInserirDinheiro()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (senhadoCli.Equals(senhaValida.Text))
			{
				dinheiro += float.Parse(dinheiroInserir.Text);
				inserirMoney();
			}
			else
			{
				MessageBox.Show("Senha invalida!");
			}
			

		}
		public void recebeDados(int id, float money, string senha)
		{
			dinheiro = money;
			idCliente = id;
			senhadoCli = senha;
		}

		public void inserirMoney()
		{   
			Cliente Cliente = ClienteNegocio.RetornarClienteId(idCliente);
			ClienteNegocio.inserirDinheiro(idCliente, dinheiro);
			Objeto.repassaResultado(dinheiro);
			this.Close();
		}
	}
}
