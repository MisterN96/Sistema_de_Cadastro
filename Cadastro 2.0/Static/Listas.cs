using Cadastro_2._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_2._0.Static
{
   public class Listas
    {
        private static int cont = 0;

        public static List<Cliente> Clientes { get; set; }


        public static void Iniciar()
        {
            IniciarListaCliente();
            //IniciarListaProduto();
        }

        private static void IniciarListaCliente()
        {
            if (cont == 0) { 
            Clientes = new List<Cliente>();
            int ide = 0;

            Cliente cliente1 = new Cliente();
            ide = ide + 1;
            cliente1.id = ide;
            cliente1.nome = "Natan";
            cliente1.rg = "127159467";
            cliente1.telefone = "998431018";
            cliente1.cpf = "09999616917";
            cliente1.endereco = "Rua osmar Ceccon";
            cliente1.numero = "43";
            cliente1.bairro = "Palmital";
            cliente1.cidade = "Colombo";
            cliente1.cep = "83413390";
            cliente1.sexo = "Masculino";


            Clientes.Add(cliente1);

            Cliente cliente2 = new Cliente();
            ide = ide + 1;
            cliente2.id = ide;
            cliente2.nome = "Kelly";
            cliente2.rg = "09999616917";
            cliente2.telefone = "998888888";
            cliente2.cpf = "127159467";
            cliente2.endereco = "Ceccon Osmar";
            cliente2.numero = "97";
            cliente2.bairro = "Palmital";
            cliente2.cidade = "Colombo";
            cliente2.cep = "83413390";
            cliente2.sexo = "Feminino";

            Clientes.Add(cliente2);
                cont = 1;
            }
            //Criar a lista estática
        }

        public static void InserirCliente(Cliente cliente)
        {
            Clientes.Add(cliente);

        }

        public static void AlterarCliente(Cliente clienteEditado)
        {
            //TODO: Usar metodo de retorno por id

            //Retorna o client e alvo
            Cliente clienteOrig = RetornarClientePorID(clienteEditado.id);


            clienteOrig.nome = clienteEditado.nome;
            clienteOrig.numero = clienteEditado.numero;
            clienteOrig.rg = clienteEditado.rg;
            clienteOrig.sexo = clienteEditado.sexo;
            clienteOrig.telefone = clienteEditado.telefone;
            clienteOrig.endereco = clienteOrig.endereco;
            clienteOrig.cpf = clienteEditado.cpf;
            clienteOrig.cidade = clienteEditado.cidade;
            clienteOrig.cep = clienteEditado.cep;
            clienteOrig.bairro = clienteEditado.bairro;

           
            //TODO completar lista

        }
    

        public static List<Cliente> filtrar(string valor, string check)
        {
            List<Cliente> lista = null;
            switch (check)
            {
                case "Nome":
                    var clientes = (from c in Clientes
                                    where c.nome.ToUpper().Contains(valor.ToUpper())
                                    select c).ToList();
                    lista = clientes;
   
                    break;

                case "Telefone":
                    var contato = (from c in Clientes
                                    where c.telefone.Contains(valor)
                                    select c).ToList();
                    lista = contato;
                    break;

                case "Sexo":
                    var sexo = (from c in Clientes
                                   where c.sexo.ToUpper().Contains(valor.ToUpper())
                                   select c).ToList();
                    lista = sexo;
                    break;

                case "CPF":
                    var cpf = (from c in Clientes
                                where c.cpf.Contains(valor)
                                select c).ToList();
                    lista = cpf;
                    break;

                case "Cep":
                    var cep = (from c in Clientes
                                where c.cep.Contains(valor)
                                select c).ToList();
                    lista = cep;
                    break;

                case "RG":
                    var rg = (from c in Clientes
                               where c.rg.Contains(valor)
                               select c).ToList();
                    lista = rg;
                    break;

                case "Cidade":
                    var cidade = (from c in Clientes
                              where c.cidade.ToUpper().Contains(valor.ToUpper())
                              select c).ToList();
                    lista = cidade;
                    break;

                case "Numero":
                    var numero = (from c in Clientes
                                  where c.numero.Contains(valor)
                                  select c).ToList();
                    lista = numero;
                    break;

                default:
                    return lista;

            }
            


            return lista;
        }

        /// <summary>
        /// metodo responsavel por retornar um obj de cliente perante o id ja informado
        /// </summary>
        /// <param name="ID">id do cliente</param>
        /// <returns></returns>
        public static Cliente RetornarClientePorID(int ID)
        {
            var encontrado = (from c in Clientes
                              where c.id == ID
                              select c).FirstOrDefault();

            return encontrado;
        }

        public static List<Cliente> crescente()
        {
           

            List<Cliente> cliente_crescente = (from c in Clientes
                                     orderby c.nome
                                     select c).ToList();

            return cliente_crescente;
           
        }
        public static List<Cliente> decrescente()
        {
            List<Cliente> cliente_decrescente = (from c in Clientes
                                                 orderby c.nome descending
                                                 select c).ToList();



            return cliente_decrescente;
        }
        public static void deletar(int id)
        {

            var removido = (from c in Clientes
                            where c.id == id
                            select c).First();

            Clientes.Remove(removido);
        }
   

       
    }
}
