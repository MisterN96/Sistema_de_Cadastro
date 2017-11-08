using Cadastro.BO.Modelo;
using Cadastro.BO.Negocio;

namespace Cadastro_2._0
{

	public class Objeto
	{
		#region Globais
		/// <summary>
		/// variavais globais
		/// </summary>
		static Cliente clienteSalvo;
		static float dinheiro;
		#endregion


		/// <summary>
		/// Metodo responsavel por enviar objeto validado para pagina home
		/// </summary>
		/// <param name="clienteAutenticado"></param>
		public static void recebeObjeto(Cliente clienteAutenticado)
		{
			clienteSalvo = clienteAutenticado;
			frmCadastroCliente clienteEditar = new frmCadastroCliente();
			frmPainelHome home = new frmPainelHome();
			home.recebeObj(clienteSalvo);
			clienteEditar.Close();
			home.ShowDialog();
		}

		/// <summary>
		/// Metodo e ativado quando sai da tela de edição e nada é editado 
		/// </summary>
		public static void iniciaSemAlteracao()
		{
			frmPainelHome home = new frmPainelHome();
			home.recebeObj(clienteSalvo);
			home.ShowDialog();
		}

		/// <summary>
		/// instancisa janela e carraga dados para ediçao
		/// </summary>
		/// <param name="cliente"></param>
		public static void chamaEditar(Cliente cliente)
		{
			frmCadastroCliente clienteEditar = new frmCadastroCliente();
			clienteEditar.exibirCliente(cliente);
			clienteEditar.ShowDialog();
			clienteEditar.Close();
		}

		public static void buscaDinheiro(int idClientelogado, float money)
		{

			frmInserirDinheiro inserir = new frmInserirDinheiro();
			inserir.recebeDados(idClientelogado, money, clienteSalvo.senha);
			inserir.ShowDialog();
		}

		public static void repassaResultado(float valor)
		{
			dinheiro = valor;
			frmPainelHome home = new frmPainelHome();
			home.recebeValor(dinheiro);
		}
	}
}
