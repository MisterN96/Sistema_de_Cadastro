using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_2._0.Model
{
    public class Produto
    {
        public string status_prod { get; set; }
        public string nomeprod { get; set; }
        public string tipo_pro { get; set; }
        public int data_fabri { get; set; }
		public int data_valid { get; set; }
        public int id_prod { get; set; }
    }
}
