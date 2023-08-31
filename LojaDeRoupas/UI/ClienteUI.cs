using LojaDeRoupas.Models;
using LojaDeRoupas.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeRoupas.UI
{
    public static class ClienteUI
    {
        internal static Cliente RegistrarCliente(int id)
        {
         string nome, sobrenome, endereco, telefone;
         Console.WriteLine("\n############# CADASTRO DE CLIENTE ###############");
         Console.Write("Nome: ");
         nome = Convert.ToString(Console.ReadLine());
         Console.Write("Sobrenome: ");
         sobrenome = Console.ReadLine();
         Console.Write("Endereço: ");
         endereco = Console.ReadLine();
         Console.Write("Telefone: ");
         telefone = Console.ReadLine();
         return new Cliente(nome, sobrenome, endereco, telefone, id );
        }

        internal static Cliente BuscarPorIdCliente(List<Cliente> listaClientes, int id)
        {

            Cliente cliente = listaClientes.Find( x => x.ClienteID == id);
            Console.WriteLine($"ID Cliente: {cliente.ClienteID}");
            Console.WriteLine($"Nome: {cliente.Nome} {cliente.Sobrenome}");
            Console.WriteLine($"Endereco: {cliente.Endereco}");
            Console.WriteLine($"Telefone: {cliente.Telefone}");
            return cliente;

        }


        internal static void RemoverCliente(List<Cliente> listaClientes, int id)
        {

            Cliente clientebusca = ClienteUI.BuscarPorIdCliente(listaClientes, id);
            listaClientes.Remove(clientebusca);
            Console.WriteLine($"Cliente com id {id} foi removido");
        }

        internal static void ListarClientes(List<Cliente> listaClientes)
        {
            foreach(Cliente cliente in listaClientes)
            {
                Console.WriteLine($"ID Cliente: {cliente.ClienteID}");      
                Console.WriteLine($"Nome: {cliente.Nome} {cliente.Sobrenome}");
                Console.WriteLine($"Endereco: {cliente.Endereco}");
                Console.WriteLine($"Telefone: {cliente.Telefone}");
                Console.WriteLine("\n");

            }
        }

        internal static void AlterarCliente(List<Cliente> listaClientes, int id)
        {

            Cliente clientebusca = ClienteUI.BuscarPorIdCliente(listaClientes, id);

            Console.WriteLine("\n############# ALTERAÇÂO DE CADASTRO DE CLIENTE ###############");
            Console.Write("Nome: ");
            clientebusca.Nome = Convert.ToString(Console.ReadLine());
            Console.Write("Sobrenome: ");
            clientebusca.Sobrenome = Console.ReadLine();
            Console.Write("Endereço: ");
            clientebusca.Endereco = Console.ReadLine();
            Console.Write("Telefone: ");
            clientebusca.Telefone = Console.ReadLine();
        }

    }
}
