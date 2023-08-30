using LojaDeRoupas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeRoupas.UI
{
    public static class ClienteUI
    {
        public static Cliente CadastrarCliente()
        {
            try
            {
                string nome, sobrenome, endereco, telefone;
                Console.WriteLine("#############CADASTRO DE CLIENTE###############");
                Console.Write("Nome: ");
                nome = Convert.ToString(Console.ReadLine());
                Console.Write("Sobrenome: ");
                sobrenome = Console.ReadLine();
                Console.Write("Endereço: ");
                endereco = Console.ReadLine();
                Console.Write("Telefone: ");
                telefone = Console.ReadLine();
                return new Cliente(nome, sobrenome, endereco, telefone);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
