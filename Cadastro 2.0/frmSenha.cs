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
using System.IO;

namespace Cadastro_2._0
{
	public partial class frmSenha : Form
	{
		
		Cliente autenticado;

		public frmSenha()
		{
			InitializeComponent();
		}

		private void btnProximo_Click(object sender, EventArgs e)
		{
			autenticaSenha();

		}

		public void recebeClienteAutenticado(Cliente clienteAutenticado)
		{

			autenticado = clienteAutenticado;
		}

		public void autenticaSenha()
		{
			if (!txtSenha.Text.Equals(""))
			{

				if (txtSenha.Text.Equals(autenticado.senha))
				{
					this.Hide();
					Objeto.recebeObjeto(autenticado);
					

				}
				else
				{
					MessageBox.Show("Senha incorreta!");
					txtSenha.Clear();

				}
			}
			else
			{
				MessageBox.Show("Senha incorreta!");
			}

		}

		private void frmSenha_Load(object sender, EventArgs e)
		{

			MemoryStream memory = new MemoryStream(autenticado.foto);
			pictureBoxSenha.Image = Image.FromStream(memory);
		}
	}
}
