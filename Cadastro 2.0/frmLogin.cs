using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.BO.Negocio;
using Cadastro.BO.Modelo;
using System.Windows.Forms;

namespace Cadastro_2._0
{
	public partial class frmLogin : Form
	{
		Cliente clienteautenticado;
		public frmLogin()
		{
			InitializeComponent();
			
		}

		public void validarLogin()
		{
			if (!txtLogin.Text.Equals(""))
			{
				clienteautenticado = ClienteNegocio.validarLogin(txtLogin.Text);
				
					if (txtLogin.Text.Equals(clienteautenticado.login))
					{
						frmSenha autenticaSenha = new frmSenha();
						autenticaSenha.recebeClienteAutenticado(clienteautenticado);
						autenticaSenha.Show();
						this.Hide();
				}
				else
				{
					MessageBox.Show("Login invalido!");
				}
			}
		}

		private void btnProximo_Click(object sender, EventArgs e)
		{
			validarLogin();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			frmCadastroCliente cadastroCliente = new frmCadastroCliente();
			cadastroCliente.Show();
		
			
			
		}
	}
}
