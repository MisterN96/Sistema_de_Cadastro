using Cadastro.BO.Modelo;
using Cadastro.BO.Negocio;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Cadastro_2._0
{
	public partial class frmCadastroCliente : Form
    {
		#region Globais
		/// <summary>
		/// variaveis globais
		/// </summary>
		MemoryStream memory;
		byte[] foto;
		string nomeFoto;
		int valida = 1;
		Bitmap bmp;
		Cliente clienteEditado;
		int ideCliente = 0;
		bool Estatus = true;
		string genero;
		#endregion

		public frmCadastroCliente()
        {
            InitializeComponent();
            
        }
		#region RadioButom
		/// <summary>
		/// Define valor dos radio butons
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdoMasc_CheckedChanged(object sender, EventArgs e)
		{
			genero = "Masculino";
		}
		private void rdoFem_CheckedChanged(object sender, EventArgs e)
		{
			genero = "Feminino";
		}
		#endregion



		/// <summary>
		/// Evento do botao com ação de definir se ira editar conteudo ou salver um novo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(Estatus == false)
            {
				foto = memory.ToArray();
				editarCliente( txtBairro.Text, txtCep.Text, txtCpf.Text, txtEndereco.Text, txtNome.Text, txtNumero.Text,
								txtRg.Text, txtTelefone.Text, cbxCidade.Text, genero,txtLogin.Text,txtSenha.Text,foto);
            }
            else
            {
				adicionarCliente();
            }
        }


        
       /// <summary>
	   /// Recebe Obj cliente e exibe na janela
	   /// </summary>
	   /// <param name="cliente"></param>
        public void exibirCliente(Cliente cliente)
        {
            // aqui tenho que enviar o obj recebido para alteração

            txtNome.Text = cliente.nome;
            txtBairro.Text = cliente.bairro;
            txtCep.Text = cliente.cep.ToString();
            txtCpf.Text = cliente.cpf.ToString();
            txtEndereco.Text = cliente.endereco;
            txtNumero.Text = cliente.numero.ToString();
            txtRg.Text = cliente.rg.ToString();
            txtTelefone.Text = cliente.telefone.ToString();
            genero = cliente.sexo;
            cbxCidade.Text = cliente.cidade;
			memory = new MemoryStream(cliente.foto);
			ptbPerfil.Image = Image.FromStream(memory);
			txtSenha.Text = cliente.senha;
			txtLogin.Text = cliente.login;
			ideCliente = cliente.id;

			if (genero == "Masculino")
			{
				rdoMasc.Checked = true;
			}
			else
			{
				rdoFem.Checked = true;
			}
			valida = 0;
            Estatus = false;
        }

		/// <summary>
		/// adiciona um Cliente novo e envia para camada DAL
		/// </summary>
        public void adicionarCliente()
        {
         
            Cliente cliente = new Cliente();
          
            cliente.nome = txtNome.Text;
            cliente.cpf =txtCpf.Text;
            cliente.rg = txtRg.Text;
            cliente.sexo = genero;
            cliente.endereco = txtEndereco.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cep = txtCep.Text;
            cliente.cidade = cbxCidade.Text;
            cliente.numero = txtNumero.Text;
            cliente.telefone = txtTelefone.Text;
			cliente.login = txtLogin.Text;
			cliente.senha = txtSenha.Text;
			salvarFoto();
			cliente.foto = foto;
            Estatus = true;

			ClienteNegocio.adicionarNovoCliente(cliente);

            MessageBox.Show("Cadastrado com sucesso!");
			valida = 1;
			limparCampos();
		}

        /// <summary>
		/// Metodo eutilizado para editar cliente carregado na tela
		/// </summary>
		/// <param name="Bairro"></param>
		/// <param name="Cep"></param>
		/// <param name="Cpf"></param>
		/// <param name="Endereco"></param>
		/// <param name="Nome"></param>
		/// <param name="Numero"></param>
		/// <param name="Rg"></param>
		/// <param name="Telefone"></param>
		/// <param name="cidade"></param>
		/// <param name="genero"></param>
		/// <param name="login"></param>
		/// <param name="senha"></param>
		/// <param name="foto"></param>
        private void editarCliente( string Bairro, string Cep, string Cpf, string Endereco, string Nome, string Numero, string Rg, string Telefone, string cidade, string genero, string login, string senha, byte[] foto)
        {

			clienteEditado = new Cliente();
			
			clienteEditado.bairro = Bairro;
            clienteEditado.cep = Cep;
            clienteEditado.cidade = cidade;
            clienteEditado.cpf = Cpf;
            clienteEditado.endereco = Endereco;
            clienteEditado.nome = Nome;
            clienteEditado.numero = Numero;
            clienteEditado.rg = Rg;
            clienteEditado.telefone = Telefone;
            clienteEditado.cidade = cidade;
            clienteEditado.sexo = genero;
			clienteEditado.login = login;
			clienteEditado.senha = senha;
			clienteEditado.foto = foto;
			clienteEditado.id = ideCliente;
			ClienteNegocio.EditarCliente(clienteEditado);
			
			MessageBox.Show("Edição feita com sucesso!");
			Estatus = true;
			valida = 0;
			

		}
		
		/// <summary>
		/// Evento do botao sair decide se vota para login ou para home logada
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSair_Click(object sender, EventArgs e)
        {
			if (valida ==  1 && clienteEditado == null)
			{
				this.Hide();
			}
			
			if (clienteEditado != null && valida == 0 && Estatus == true)
			{
				limparCampos();
				this.Hide();
				Objeto.recebeObjeto(clienteEditado);
			}
			else
			{
				if(clienteEditado == null && valida == 0)
				{
					this.Hide();
					Objeto.iniciaSemAlteracao();
				}
			}
		}

		/// <summary>
		/// Metodo utilzado para otimizar o serviço de limpeza de campos
		/// </summary>
        public void limparCampos()
        {
            txtBairro.Clear(); txtCep.Clear(); txtCpf.Clear();
            txtEndereco.Clear(); txtNome.Clear(); txtNumero.Clear();
            txtRg.Clear(); txtTelefone.Clear(); txtLogin.Clear(); txtSenha.Clear(); rdoFem.Checked = false;
			rdoMasc.Checked = false;
        }

		/// <summary>
		/// Metodo salva foto quando foi alterada ou quando nao foi alterada
		/// </summary>
		public void salvarFoto()
		{
			if (bmp == null)
			{
					bmp = new Bitmap(ptbPerfil.Image);
					ptbPerfil.Image = bmp;
					memory = new MemoryStream();
					bmp.Save(memory, ImageFormat.Bmp);
					foto = memory.ToArray();
			}
		}

		/// <summary>
		/// Metodo para vezer buscas de imagem e selecionar para inserir na picturebox correspondente.
		/// </summary>
		public void alterarImgem()
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				nomeFoto = openFileDialog1.FileName;
				bmp = new Bitmap(nomeFoto);
				ptbPerfil.Image = bmp;
				memory = new MemoryStream();
				bmp.Save(memory, ImageFormat.Bmp);
				foto = memory.ToArray();
			}
		}

		/// <summary>
		/// boão que tem a ação de alterar imagem.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnTrocarimg_Click(object sender, EventArgs e)
		{
			alterarImgem();

		}

		
	}
}
