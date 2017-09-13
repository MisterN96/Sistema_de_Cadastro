using System;
using Cadastro.BO.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Cadastro.BO.Negocio
{
	public class PedidoNegocio
	{
		public static List<Cliente> enviarListadeNomesCliente()
		{
			List<Cliente> listadeClientes = new List<Cliente>();
			SqlDataReader dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT Nome_Cliente FROM TBL_CLIENTE", null);
			while (dr.Read())
			{

				Cliente cliente = new Cliente();
				cliente.nome = Convert.ToString(dr["Nome_Cliente"]);
				listadeClientes.Add(cliente);
			}

			return listadeClientes;
		}

		public static List<Produto> enviarListaNomeProduto()
		{
			List<Produto> listadeProdutos = new List<Produto>();

			SqlDataReader dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT Nome_Produto FROM TBL_PRODUTO", null);
			while (dr.Read())
			{
				Produto produto = new Produto();
				produto.nomeprod = Convert.ToString(dr["Nome_Produto"]);
				listadeProdutos.Add(produto);

			}
			return listadeProdutos;
		}
		
	}
}
