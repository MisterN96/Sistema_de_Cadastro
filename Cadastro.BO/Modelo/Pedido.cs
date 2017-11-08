using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.BO.Modelo
{
	public class Pedido
	{
		public int id_pedido;
		public string cliente_pedido;
		public string produto_pedido;
		public int quantidade_produto;
		public DateTime data_pedido; 
	}
}
