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
			SqlDataReader dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT Codigo_Cliente, Nome_Cliente FROM TBL_CLIENTE", null);
			while (dr.Read())
			{

				Cliente cliente = new Cliente();
				cliente.nome = Convert.ToString(dr["Nome_Cliente"]);
				cliente.id = Convert.ToInt32(dr["Codigo_Cliente"]);
				listadeClientes.Add(cliente);
			}

			return listadeClientes;
		}

		public static List<Produto> enviarListadeNomesProduto()
		{
			List<Produto> listadeProdutos = new List<Produto>();
			SqlDataReader dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT * FROM TBL_PRODUTO", null);
			while (dr.Read())
			{

				Produto produto = new Produto();
				produto.nomeprod = Convert.ToString(dr["Nome_Produto"]);
				produto.Cod_PRO = Convert.ToInt32(dr["Cod_PRO"]);
				produto.data_valid = Convert.ToDateTime(dr["Validade"]);
				produto.data_fabri = Convert.ToDateTime(dr["Fabricacao"]);
				produto.tipo_pro = Convert.ToString(dr["Tipo_PRO"]);
				produto.status_prod = Convert.ToString(dr["Status_PRO"]);
				produto.Valor_Produto = Convert.ToDecimal(dr["Valor_PRODUTO"]);
				listadeProdutos.Add(produto);
			}

			return listadeProdutos;
		}


		public static Pedido salvarPedido(Pedido pedido)
		{
			List<SqlParameter> listaParametros = new List<SqlParameter>();
			listaParametros.Add(new SqlParameter { ParameterName = "@id_pedido", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output });
			listaParametros.Add(new SqlParameter { ParameterName = "@Status_Pedido", SqlDbType = System.Data.SqlDbType.Bit, Value = 0 });
			listaParametros.Add(new SqlParameter { ParameterName = "@id_cliente", SqlDbType = System.Data.SqlDbType.Int, Value = pedido.cod_cli });
			listaParametros.Add(new SqlParameter { ParameterName = "@dataPedido", SqlDbType = System.Data.SqlDbType.DateTime, Value = pedido.data_pedido });

			
			 DataAccessLayer.ExecuteNonQuery(System.Data.CommandType.Text, "INSERT INTO TBL_PEDIDO(Cod_CLI, Data_Ped,Status_Pedido)" +
				"VALUES (@id_cliente, @dataPedido,@Status_Pedido) SET @id_pedido = SCOPE_IDENTITY()", listaParametros);

			var idpedido = 0;
			idpedido = Convert.ToInt32(listaParametros[0].Value);
			pedido.cod_ped = idpedido;
			return pedido; 
		}



		public static Produto_Pedido salvarProduto_Pedido(Produto_Pedido pedidoProduto)
		{

			List<SqlParameter> listaParametros = new List<SqlParameter>();
			listaParametros.Add(new SqlParameter { ParameterName = "@id_pedidoRetorno", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output });
			listaParametros.Add(new SqlParameter { ParameterName = "@id_produto", SqlDbType = System.Data.SqlDbType.Int, Value = pedidoProduto.prod_id });
			listaParametros.Add(new SqlParameter { ParameterName = "@id_pedido", SqlDbType = System.Data.SqlDbType.Int, Value = pedidoProduto.ped_id });
			listaParametros.Add(new SqlParameter { ParameterName = "@quantidade", SqlDbType = System.Data.SqlDbType.Int, Value = pedidoProduto.quantidade });


			DataAccessLayer.ExecuteNonQuery(System.Data.CommandType.Text, "INSERT INTO TBL_PRODUTO_PEDIDO(PRO_ID,PED_ID,Quantidade)" +
			   "VALUES (@id_produto, @id_pedido, @quantidade) SET @id_pedidoRetorno = SCOPE_IDENTITY()", listaParametros);

			var idpedido = 0;
			idpedido = Convert.ToInt32(listaParametros[2].Value);
			pedidoProduto.ped_id = idpedido;
			return pedidoProduto;
		}

		public static List<Carrinho> pedidosNaoFinalizados(int idCliente)
		{
			List<Carrinho> carrinhoLista = new List<Carrinho>();
			List<SqlParameter> listaParametros = new List<SqlParameter>();
			listaParametros.Add(new SqlParameter { ParameterName = "@idCliente", SqlDbType = System.Data.SqlDbType.Int, Value = idCliente});

			SqlDataReader dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT Nome_Produto, Quantidade, Valor_PRODUTO, Data_Ped FROM TBL_PRODUTO PRO" +
				" JOIN TBL_PRODUTO_PEDIDO PRO_PE ON PRO_PE.PRO_ID = PRO.Cod_PRO" + " JOIN TBL_PEDIDO PED ON PED.Cod_PED = PRO_PE.PED_ID WHERE Cod_CLI = @idCliente AND Status_Pedido = 0", listaParametros);

			while (dr.Read())
			{

				Carrinho carrinho = new Carrinho();
				carrinho.nomeProduto_carrinho = Convert.ToString(dr["Nome_Produto"]);
				carrinho.quantidadeProduto_carrinho = Convert.ToInt32(dr["Quantidade"]);
				carrinho.dataDeCompra = Convert.ToDateTime(dr["Data_Ped"]);
				carrinho.valorProduto_carrinho = Convert.ToDouble(dr["Valor_PRODUTO"]);

				carrinhoLista.Add(carrinho);
			}

			return carrinhoLista;
		}

		
	}
}
