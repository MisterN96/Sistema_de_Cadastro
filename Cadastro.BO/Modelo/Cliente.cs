using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.BO.Modelo
{
   public class Cliente
    {
       
        public int id { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string sexo { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
		public string login { get; set; }
		public string senha { get; set; }
		public byte[] foto { get; set; }
		public string nomeFoto { get; set; }
		public float carteira { get; set; }
	

	}
}
