using System.Data.SqlClient;
using System.Collections.Generic;
using Cadastro.BO.Modelo;
using System;
using System.Data;

namespace Cadastro.BO.Negocio
{
	public class ProdutoNegocio
	{
		static int codigoProduto;
		/// <summary>
		/// Método é utilizado para retonar um OBJ Produto através de um ID
		/// </summary>
		/// <returns>Retorna um OBJ de PRODUTO </returns>
		public static Produto RetornarProdutoId(int id)
		{
			codigoProduto = id;

			List<SqlParameter> ListaParametrosId = new List<SqlParameter>();
			ListaParametrosId.Add(new SqlParameter { ParameterName = "@id", SqlDbType = SqlDbType.Int, Value = id });
			Produto produto = new Produto();
			SqlDataReader dr = DataAccessLayer.ExecuteReader(CommandType.Text, "SELECT * FROM TBL_PRODUTO WHERE @id = Cod_PRO", ListaParametrosId);
			while (dr.Read())
			{

				produto.nomeprod = Convert.ToString(dr["Nome"]);
				produto.data_valid = Convert.ToDateTime(dr["Validade"]);
				produto.data_fabri = Convert.ToDateTime(dr["Fabricacao"]);
				produto.tipo_pro = Convert.ToString(dr["Tipo_PRO"]);
				produto.status_prod = Convert.ToString(dr["Status_PRO"]);

			}

			return produto;
			
		}

		/// <summary>
		/// Método é utilizado para carregar a lista de produtos na gridview
		/// </summary>
		/// <returns>Retorna uma lista de PRODUTO</returns>
		public static List<Produto> ExibirListaSemFiltro()
		{
			List<Produto> listaProduto = new List<Produto>();
			SqlDataReader dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT * FROM TBL_PRODUTO", null);

			while(dr.Read())
			{
				Produto produto = preencherObjeto(dr);
				listaProduto.Add(produto);
			}

			return listaProduto;
		}
		/// <summary>
		/// Método é utilizado para fazer a alteraçao de dados no objeto
		/// </summary>
		/// <param name="produtoEditado"></param>
		public static void EditarProduto(Produto produtoEditado)
		{
			List<SqlParameter> ListParametros = new List<SqlParameter>();
			ListParametros.Add(new SqlParameter { ParameterName = "@cod_ProdutoEditado", SqlDbType = SqlDbType.Int, Value = codigoProduto });
			ListParametros.Add(new SqlParameter { ParameterName = "@Nome", SqlDbType = SqlDbType.VarChar, Size = 20, Value = produtoEditado.nomeprod });
			ListParametros.Add(new SqlParameter { ParameterName = "@Validade", SqlDbType = SqlDbType.DateTime, Value = DateTime.Now });
			ListParametros.Add(new SqlParameter { ParameterName = "@Fabricacao", SqlDbType = SqlDbType.DateTime, Value = DateTime.Now });
			ListParametros.Add(new SqlParameter { ParameterName = "@Tipo_PRO", SqlDbType = SqlDbType.VarChar, Size = 15, Value = produtoEditado.tipo_pro });
			ListParametros.Add(new SqlParameter { ParameterName = "@Status_PRO", SqlDbType = SqlDbType.VarChar, Size = 15, Value = produtoEditado.status_prod });

			DataAccessLayer.ExecuteNonQuery(System.Data.CommandType.Text, "UPDATE TBL_PRODUTO SET Nome = @Nome, Validade = @Validade, Fabricacao = @Fabricacao, Tipo_PRO = @Tipo_PRO, Status_PRO =@Status_PRO WHERE Cod_PRO = @cod_ProdutoEditado", ListParametros);
		}

		/// <summary>
		/// Método ultilzado para ordenar lista de maneira DECRESCENTE e CRESCENTE
		/// </summary>
		/// <returns> retorna uma lista de OBJ Decrescente ou crescente </returns>
		public static List<Produto> ExibirListaDecresouCrescente(int crecenteouDEcresente)
		{
			SqlDataReader dr;
			List<Produto> listaProduto;
			if (crecenteouDEcresente == 0)
			{
				listaProduto = new List<Produto>();
				dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT * FROM TBL_PRODUTO ORDER BY Nome DESC", null);
			}
			else
			{
				listaProduto = new List<Produto>();
				dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT * FROM TBL_PRODUTO ORDER BY Nome ASC", null);
				
			}
			

			while (dr.Read())
			{
				Produto produto = preencherObjeto(dr);
				listaProduto.Add(produto);
			}

			return listaProduto;

		}
		/// <summary>
		/// Método é utilizado para retonar uma lista filtrada apartir de uma string parcial e um determinado filtro
		/// </summary>
		/// <param name="filtro"></param>
		/// <param name="palavra"></param>
		/// <returns></returns>
		public static List<Produto> ExibirListaFiltradaporString(string palavra, string filtro)
		{
			List<Produto> listaproduto = new List<Produto>();
			List<SqlParameter> listadeparametros = new List<SqlParameter>();
			listadeparametros.Add(new SqlParameter { ParameterName = "@palavra", SqlDbType = SqlDbType.Text, Value = palavra.ToUpper()});
			string query = "SELECT * FROM TBL_PRODUTO ";

			switch (filtro)
			{
				case "Nome":
					query += "WHERE UPPER(Nome) LIKE" + "'%" + @palavra + "%'";
					break;

				case "Validade":
					query += "WHERE UPPER(Validade) LIKE" + "'%" + @palavra + "%'";
					break;

				case "Fabricacao":
					query += "WHERE UPPER(Fabricacao) LIKE" + "'%" + @palavra + "%'";
					break;

				case "Tipo":
					query += "WHERE UPPER(Tipo_PRO) LIKE" + "'%" + @palavra + "%'";
					break;

				case "Status":
					query += "WHERE UPPER(Status_PRO) LIKE" + "'%" + @palavra + "%'";
					break;

				default:
					return listaproduto;
			}
			SqlDataReader dr = DataAccessLayer.ExecuteReader(CommandType.Text, query, listadeparametros);
			while (dr.Read())
			{

				Produto produto = preencherObjeto(dr);
				listaproduto.Add(produto);
			}

			return listaproduto;
		}
	

		/// <summary>
		/// Método é utilizado para preencher objeto de tipo PRODUTO
		/// </summary>
		/// <param name="dr"></param>
		/// <returns>preenche objeto do TIPO PRODUTO</returns>
		public static Produto preencherObjeto(SqlDataReader dr)
		{
				Produto produto = new Produto();

				produto.Cod_PRO = Convert.ToInt32(dr["Cod_PRO"]);
				produto.nomeprod = Convert.ToString(dr["Nome_Produto"]);
				produto.data_fabri = Convert.ToDateTime(dr["Fabricacao"]);
				produto.data_valid = Convert.ToDateTime(dr["Validade"]);
				produto.status_prod = Convert.ToString(dr["Status_PRO"]);
				produto.tipo_pro = Convert.ToString(dr["Tipo_PRO"]);
				return produto;

		}

		/// <summary>
		/// Método é utilizado para adicionar um novo Produto a Base de Dados
		/// </summary>
		/// <param name="produto"></param>
		public static void adicionarNovoProduto(Produto produto)
		{
			List<SqlParameter> listaParametros = new List<SqlParameter>();
			listaParametros.Add(new SqlParameter { ParameterName = "@Nome", SqlDbType = System.Data.SqlDbType.Text, Size = 20, Value = produto.nomeprod });
			listaParametros.Add(new SqlParameter { ParameterName = "@Validade", SqlDbType = System.Data.SqlDbType.DateTime, Value = produto.data_valid });
			listaParametros.Add(new SqlParameter { ParameterName = "@Fabricacao", SqlDbType = System.Data.SqlDbType.DateTime, Value = produto.data_fabri });
			listaParametros.Add(new SqlParameter { ParameterName = "@Status", SqlDbType = System.Data.SqlDbType.NVarChar, Size = 20, Value = produto.status_prod });
			listaParametros.Add(new SqlParameter { ParameterName = "@Tipo", SqlDbType = System.Data.SqlDbType.NVarChar, Size = 20, Value = produto.tipo_pro });

			DataAccessLayer.ExecuteNonQuery(System.Data.CommandType.Text, "INSERT INTO TBL_PRODUTO(Nome, Validade, Fabricacao, Tipo_PRO, Status_PRO)" +
				"VALUES (@Nome, @Validade, @Fabricacao, @Tipo, @Status)", listaParametros);
		}

		/// <summary>
		/// Método é utilizado para deletar um PRODUTO apartir de um id
		/// </summary>
		/// <param name="idProduto"></param>
		public static void deletarProduto(int idProduto)
		{
			List<SqlParameter> listaParametro = new List<SqlParameter>();

			listaParametro.Add(new SqlParameter { ParameterName = "@id", SqlDbType = System.Data.SqlDbType.Int, Value = idProduto });
			DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "DELETE FROM TBL_PRODUTO WHERE Cod_PRO = @id", listaParametro);
		}
	


		
	}
}
