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
    

    public partial class frmPainelHome : Form
    {
        frmExcluirProdutos excluirProd = new frmExcluirProdutos();
        frmCadastroProd cadastroprod = new frmCadastroProd();
        frmLogin cad = new frmLogin();
        frmListaCliente listacliente = new frmListaCliente();
        frmCadastroCliente cadastrocliente = new frmCadastroCliente();
        frmExcluir_EditarClientes exclusaoclientes = new frmExcluir_EditarClientes();

        public frmPainelHome()
        {
            InitializeComponent();
          
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrocliente.ShowDialog();
        }

        private void eXCLUIRCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exclusaoclientes.ShowDialog();
          

        }

        private void lISTADECADASTRADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listacliente.ShowDialog();
        }

        private void cADASTRARPRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroprod.ShowDialog();
        }

        private void eXCLUIRPRODUTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excluirProd.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var objProd = (from cliente in Static.Listas.Clientes
                           select new
                           {

                               NOME = cliente.nome,
                               CPF = cliente.cpf,
                               TELEFONE = cliente.telefone


                           }).ToList();
            dataGrid3.DataSource = objProd;
        }

        

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
