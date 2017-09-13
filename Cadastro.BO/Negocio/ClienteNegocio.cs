using System;
using Cadastro.BO.Modelo;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Cadastro.BO.Negocio
{
	public class ClienteNegocio
	{
		static int codigoCliente;
		/// <summary>
		/// Método é utilizado para retonar um OBJ Produto através de um ID
		/// </summary>
		/// <returns>Retorna um OBJ de PRODUTO </returns>
		public static Cliente RetornarClienteId(int id)
		{
			codigoCliente = id;

			List<SqlParameter> ListaParametrosId = new List<SqlParameter>();
			ListaParametrosId.Add(new SqlParameter { ParameterName = "@id", SqlDbType = System.Data.SqlDbType.Int, Value = id });
			Cliente cliente = new Cliente();
			SqlDataReader dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT * FROM TBL_CLIENTE WHERE Codigo_Cliente = @id", ListaParametrosId);
			while (dr.Read())
			{

				cliente.id = Convert.ToInt32(dr["Codigo_Cliente"]);
				cliente.nome = Convert.ToString(dr["Nome_Cliente"]);
				cliente.cpf = Convert.ToString(dr["CPF"]);
				cliente.telefone = Convert.ToString(dr["Telefone"]);
				cliente.sexo = Convert.ToString(dr["Sexo"]);
				cliente.rg = Convert.ToString(dr["RG"]);
				cliente.endereco = Convert.ToString(dr["Endereco"]);
				cliente.numero = Convert.ToString(dr["Numero"]);
				cliente.cidade = Convert.ToString(dr["Cidade"]);
				cliente.bairro = Convert.ToString(dr["Bairro"]);
				cliente.cep = Convert.ToString(dr["CEP"]);
			}

			return cliente;

		}

		/// <summary>
		/// Método é utilizado para carregar a lista de produtos na gridview
		/// </summary>
		/// <returns>Retorna uma lista de CLIENTE</returns>
		public static List<Cliente> ExibirListaSemFiltro()
		{
			List<Cliente> listaCliente = new List<Cliente>();
			SqlDataReader dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT * FROM TBL_CLIENTE", null);

			while (dr.Read())
			{
				Cliente cliente = preencherObjeto(dr);
				listaCliente.Add(cliente);
			}

			return listaCliente;
		}
		/// <summary>
		/// Método é utilizado para fazer a alteraçao de dados no objeto
		/// </summary>
		/// <param name="clienteEditado"></param>
		public static void EditarCliente(Cliente clienteEditado)
		{
			List<SqlParameter> ListParametros = new List<SqlParameter>();
			ListParametros.Add(new SqlParameter { ParameterName = "@Codigo_Cliente", SqlDbType = SqlDbType.VarChar, Value = codigoCliente });
			ListParametros.Add(new SqlParameter { ParameterName = "@Nome_Cliente", SqlDbType = SqlDbType.VarChar, Size = 20, Value = clienteEditado.nome });
			ListParametros.Add(new SqlParameter { ParameterName = "@cpf", SqlDbType = SqlDbType.VarChar, Size = 20, Value = clienteEditado.cpf });
			ListParametros.Add(new SqlParameter { ParameterName = "@telefone", SqlDbType = SqlDbType.VarChar, Size = 20, Value = clienteEditado.telefone });
			ListParametros.Add(new SqlParameter { ParameterName = "@sexo", SqlDbType = SqlDbType.VarChar, Size = 20, Value = clienteEditado.sexo });
			ListParametros.Add(new SqlParameter { ParameterName = "@rg", SqlDbType = SqlDbType.VarChar, Size = 15, Value = clienteEditado.rg });
			ListParametros.Add(new SqlParameter { ParameterName = "@endereco", SqlDbType = SqlDbType.VarChar, Size = 15, Value = clienteEditado.endereco });
			ListParametros.Add(new SqlParameter { ParameterName = "@numero", SqlDbType = SqlDbType.VarChar, Size = 20, Value = clienteEditado.numero });
			ListParametros.Add(new SqlParameter { ParameterName = "@cidade", SqlDbType = SqlDbType.VarChar, Size = 20, Value = clienteEditado.cidade });
			ListParametros.Add(new SqlParameter { ParameterName = "@bairro", SqlDbType = SqlDbType.VarChar, Size = 20, Value = clienteEditado.bairro });
			ListParametros.Add(new SqlParameter { ParameterName = "@cep", SqlDbType = SqlDbType.VarChar, Size = 20, Value = clienteEditado.cep });

			DataAccessLayer.ExecuteNonQuery(System.Data.CommandType.Text, "UPDATE TBL_CLIENTE SET Nome_Cliente = @Nome_Cliente, CPF = @cpf, Telefone = @telefone, Sexo = @sexo, RG = @rg, Endereco = @endereco, Numero = @numero, Cidade = @cidade, Bairro = @bairro,  CEP = @cep WHERE Codigo_Cliente = @Codigo_Cliente", ListParametros);
		}

		/// <summary>
		/// Método ultilzado para ordenar lista de maneira DECRESCENTE e CRESCENTE
		/// </summary>
		/// <returns> retorna uma lista de OBJ Decrescente ou crescente </returns>
		public static List<Cliente> ExibirListaDecresouCrescente(int crecenteouDEcresente)
		{
			SqlDataReader dr;
			List<Cliente> listaCliente;
			if (crecenteouDEcresente == 0)
			{
				listaCliente = new List<Cliente>();
				dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT * FROM TBL_CLIENTE ORDER BY Nome_Cliente DESC", null);
			}
			else
			{
				listaCliente = new List<Cliente>();
				dr = DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "SELECT * FROM TBL_CLIENTE ORDER BY Nome_Cliente ASC", null);
			}


			while (dr.Read())
			{
				Cliente cliente = preencherObjeto(dr);
				listaCliente.Add(cliente);
			}

			return listaCliente;

		}
		/// <summary>
		/// Método é utilizado para retonar uma lista filtrada apartir de uma string parcial e um determinado filtro
		/// </summary>
		/// <param name="filtro"></param>
		/// <param name="palavra"></param>
		/// <returns></returns>
		public static List<Cliente> ExibirListaFiltradaporString(string filtro, string palavra)
		{
			List<Cliente> listaproduto = new List<Cliente>();
			List<SqlParameter> listadeparametros = new List<SqlParameter>();
			listadeparametros.Add(new SqlParameter { ParameterName = "@filtro", SqlDbType = System.Data.SqlDbType.Text, Value = filtro.ToUpper() });
			
			string query = "SELECT * FROM TBL_CLIENTE ";

			switch (palavra)
			{
				case "Nome":
					query += "WHERE UPPER(Nome_Cliente) LIKE" + "'%" + @filtro + "%'";
					break;
				case "CPF":
					query += "WHERE UPPER(CPF) LIKE" + "'%" + @filtro + "%'";
					break;
				case "Telefone":
					query += "WHERE UPPER(Telefone) LIKE" + "'%" + @filtro + "%'";
					break;
				case "Sexo":
					query += "WHERE UPPER(Sexo) LIKE" + "'%" + @filtro + "%'";
					break;
				case "RG":
					query += "WHERE UPPER(RG) LIKE" + "'%" + @filtro + "%'";
					break;
				case "Endereco":
					query += "WHERE UPPER(Endereco) LIKE" + "'%" + @filtro + "%'";
					break;
				case "Cidade":
					query += "WHERE UPPER(Cidade) LIKE" + "'%" + @filtro + "%'";
					break;
				case "Bairro":
					query += "WHERE UPPER(Bairro) LIKE" + "'%" + @filtro + "%'";
					break;
				case "CEP":
					query += "WHERE UPPER(CEP) LIKE" + "'%" + @filtro + "%'";
					break;
			}
			SqlDataReader dr = DataAccessLayer.ExecuteReader(CommandType.Text, query, listadeparametros);
			while (dr.Read())
			{

				Cliente cliente = preencherObjeto(dr);
				listaproduto.Add(cliente);
			}

			return listaproduto;
		}


		/// <summary>
		/// Método é utilizado para preencher objeto de tipo CLIENTE
		/// </summary>
		/// <param name="dr"></param>
		/// <returns>preenche objeto do TIPO CLIENTE</returns>
		public static Cliente preencherObjeto(SqlDataReader dr)
		{
			Cliente cliente = new Cliente();

				cliente.id = Convert.ToInt32(dr["Codigo_Cliente"]);
				cliente.nome = Convert.ToString(dr["Nome_Cliente"]);
				cliente.cpf = Convert.ToString(dr["CPF"]);
				cliente.telefone = Convert.ToString(dr["Telefone"]);
				cliente.sexo = Convert.ToString(dr["Sexo"]);
				cliente.rg = Convert.ToString(dr["RG"]);
				cliente.endereco = Convert.ToString(dr["Endereco"]);
				cliente.numero = Convert.ToString(dr["Numero"]);
				cliente.cidade = Convert.ToString(dr["Cidade"]);
				cliente.bairro = Convert.ToString(dr["Bairro"]);
				cliente.cep = Convert.ToString(dr["CEP"]);
				return cliente;

		}

		/// <summary>
		/// Método é utilizado para adicionar um novo CLIENTE a Base de Dados
		/// </summary>
		/// <param name="cliente"></param>
		public static void adicionarNovoCliente(Cliente cliente)
		{
			List<SqlParameter> ListParametros = new List<SqlParameter>();
			
			ListParametros.Add(new SqlParameter { ParameterName = "@Nome_Cliente", SqlDbType = SqlDbType.VarChar, Size = 35, Value = cliente.nome });
			ListParametros.Add(new SqlParameter { ParameterName = "@cpf", SqlDbType = SqlDbType.BigInt, Size = 20, Value = cliente.cpf });
			ListParametros.Add(new SqlParameter { ParameterName = "@telefone", SqlDbType = SqlDbType.BigInt, Size = 20, Value = cliente.telefone });
			ListParametros.Add(new SqlParameter { ParameterName = "@sexo", SqlDbType = SqlDbType.VarChar, Size = 20, Value = cliente.sexo });
			ListParametros.Add(new SqlParameter { ParameterName = "@rg", SqlDbType = SqlDbType.BigInt, Size = 15, Value = cliente.rg });
			ListParametros.Add(new SqlParameter { ParameterName = "@endereco", SqlDbType = SqlDbType.VarChar, Size = 35, Value = cliente.endereco });
			ListParametros.Add(new SqlParameter { ParameterName = "@numero", SqlDbType = SqlDbType.BigInt, Size = 20, Value = cliente.numero });
			ListParametros.Add(new SqlParameter { ParameterName = "@cidade", SqlDbType = SqlDbType.VarChar, Size = 35, Value = cliente.cidade });
			ListParametros.Add(new SqlParameter { ParameterName = "@bairro", SqlDbType = SqlDbType.VarChar, Size = 35, Value = cliente.bairro });
			ListParametros.Add(new SqlParameter { ParameterName = "@cep", SqlDbType = SqlDbType.BigInt, Size = 20, Value = cliente.cep });

			DataAccessLayer.ExecuteNonQuery(CommandType.Text, "INSERT INTO TBL_CLIENTE(Nome_Cliente, CPF, Telefone, Sexo, RG, Endereco, Numero, Cidade, Bairro, CEP)" +
				"VALUES (@Nome_Cliente, @cpf, @telefone, @sexo, @rg, @endereco, @numero, @cidade, @bairro, @cep)", ListParametros);
		}

		/// <summary>
		/// Método é utilizado para deletar um CLIENTE apartir de um id
		/// </summary>
		/// <param name="idCliente"></param>
		public static void deletarCliente(int idCliente)
		{
			List<SqlParameter> listaParametro = new List<SqlParameter>();

			listaParametro.Add(new SqlParameter { ParameterName = "@id", SqlDbType = System.Data.SqlDbType.Int, Value = idCliente });
			DataAccessLayer.ExecuteReader(System.Data.CommandType.Text, "DELETE FROM TBL_CLIENTE WHERE Codigo_Cliente = @id", listaParametro);
		}




	}
}
