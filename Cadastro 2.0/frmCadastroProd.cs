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
    public partial class frmCadastroProd : Form
    {
       

        string nome;
        
        public frmCadastroProd()
        {
            InitializeComponent();
        }

        private void rdoPerecivel_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdoNaoPerecivel_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        

        private void txtNomeProd_TextChanged(object sender, EventArgs e)
        {
            nome = txtNomeProd.Text;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
			Environmen
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		public void enviarProduto()
		{

		}
     
    }
}
