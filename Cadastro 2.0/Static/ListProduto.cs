using Cadastro_2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_2._0.Static
{
	public class ListProduto
	{
		public static List<Produto> ListaProduto { get; set; }


		public static void iniciarPro()
		{
			iniciarProduto();
		}


		private static void iniciarProduto()
		{

			Produto produto = new Produto();

			produto.id_prod = 1;
			produto.nomeprod = "Maçã";
			produto.status_prod = "Alimenticio";
			produto.tipo_pro = "Natural";
			produto.data_fabri = 01082017;
			produto.data_valid = 07082017;

			ListaProduto.Add(produto);
		}

		public static void AddProduto(Produto produto)
		{
			ListaProduto.Add(produto);
		}

		public static void alterarproduto(Produto produtoeditado)
		{
			
		}

	}
}
