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
    public partial class frmListaCliente : Form
    {
        public frmListaCliente()
        {
            InitializeComponent();
            
           
        }

        public void exibirLista()
        {

            var objcuston1 = (
                                 from c in
                                 Static.Listas.Clientes
                                 select new {

                                     NOME = c.nome,
                                     CPF = c.cpf,
                                     TELEFONE = c.telefone

                                 }
                                 
                                 ).ToList();


            dataGridView2.DataSource = objcuston1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmListaCliente_Load(object sender, EventArgs e)
        {
            exibirLista();

        }
    }
}
