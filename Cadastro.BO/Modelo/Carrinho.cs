using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.BO.Modelo
{
	public class Carrinho
	{
		public int id_carrinho { get; set; }
		public string nomeProduto_carrinho { get; set; }
		public int quantidadeProduto_carrinho { get; set; }
		public Double valorProduto_carrinho { get; set; }
		public DateTime dataDeCompra { get; set; }

	}
}
