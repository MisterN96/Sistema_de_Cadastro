using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.BO.Modelo
{
    public class Produto
    {
		
        public int Cod_PRO { get; set; }
        public string nomeprod { get; set; }
		public DateTime data_valid { get; set; }
        public DateTime data_fabri { get; set; }
        public string tipo_pro { get; set; }
        public string status_prod { get; set; }
    }
}
