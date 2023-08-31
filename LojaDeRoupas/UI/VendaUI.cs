using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using LojaDeRoupas.Models;

namespace LojaDeRoupas.UI
{
    internal class VendaUI
    {
        internal static Venda RegistrarVenda(int id, List<Cliente> listaClientes, List<Produto> listaProdutos)
        {
            Produto produto;
            Cliente cliente;
            double totalvenda;
            DateTime datavenda;
            int clienteID;
            int produtoID;
            int quantidadeitens;
            List<Produto> produtosVenda = new List<Produto>();

            Console.WriteLine("\n############# CADASTRO DE VENDA ###############");
            Console.WriteLine("\nSelecione um cliente: ");
            ClienteUI.ListarClientes(listaClientes);
            Console.WriteLine("Digite o ID do cliente: \n");
            clienteID = Convert.ToInt32(Console.ReadLine());
            cliente = ClienteUI.BuscarPorIdCliente(listaClientes, clienteID);

            Console.WriteLine("Insira a data da venda: ");
            datavenda = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de itens vendidos");
            quantidadeitens = Convert.ToInt32(Console.ReadLine());

            totalvenda = 0;

            for (int i = 0; i < quantidadeitens; i++) {
                Console.WriteLine("\nSelecione um produto: ");
                ProdutoUI.ListarProdutos(listaProdutos);
                Console.WriteLine("Digite o ID do produto desejado: \n");
                produtoID = Convert.ToInt32(Console.ReadLine());
                produto = ProdutoUI.BuscarPorIdProduto(listaProdutos, produtoID);

                totalvenda = totalvenda + produto.Preco;
                produtosVenda.Add(produto);

            }

            return new Venda(id, cliente, produtosVenda, datavenda, totalvenda);
        }

        internal static Venda BuscarPorIdVenda(List<Venda> listaVendas, int id)
        {

            Venda venda = listaVendas.Find(x => x.VendaId == id);
            Console.WriteLine($"ID Venda: {venda.VendaId}");
            Console.WriteLine($"Cliente: {venda.Cliente.Nome}");
            ProdutoUI.ListarProdutos(venda.ProdutosVenda);
            Console.WriteLine($"Data da venda: {venda.DataVenda}");
            Console.WriteLine($"Valor da venda: {venda.TotalVenda}");
            return venda;

        }

        internal static void RemoverVenda(List<Venda> listaVendas, int id)
        {

            Venda vendaBusca = VendaUI.BuscarPorIdVenda(listaVendas, id);
            listaVendas.Remove(vendaBusca);
            Console.WriteLine($"Venda com id {id} foi removida");
        }

        internal static void ListarVendas(List<Venda> listaVendas)
        {
            foreach (Venda venda in listaVendas)
            {
                Console.WriteLine($"ID Venda: {venda.VendaId}");
                Console.WriteLine($"Cliente: {venda.Cliente.Nome}");
                ProdutoUI.ListarProdutos(venda.ProdutosVenda);
                Console.WriteLine($"Data da venda: {venda.DataVenda}");
                Console.WriteLine($"Valor da venda: {venda.TotalVenda}");
                Console.WriteLine("\n");


            }
        }

        internal static void AlterarVenda(int id, List<Venda> listaVendas, List<Cliente> listaClientes, List<Produto> listaProdutos)
        {
            Produto produto;
            Cliente cliente;
            double totalvenda;
            DateTime datavenda;
            int clienteID;
            int produtoID;
            int quantidadeitens;
            List<Produto> produtosVenda = new List<Produto>();


            Venda vendabusca = VendaUI.BuscarPorIdVenda(listaVendas, id);

            Console.WriteLine("\n############# ALTERAÇÂO DE CADASTRO DE VENDA ###############");

            Console.WriteLine("\nSelecione um cliente: ");
            ClienteUI.ListarClientes(listaClientes);
            Console.WriteLine("Digite o ID do cliente: \n");
            clienteID = Convert.ToInt32(Console.ReadLine());
            cliente = ClienteUI.BuscarPorIdCliente(listaClientes, clienteID);

            Console.WriteLine("Insira a data da venda: ");
            datavenda = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de itens vendidos");
            quantidadeitens = Convert.ToInt32(Console.ReadLine());

            totalvenda = 0;

            for (int i = 0; i < quantidadeitens; i++)
            {
                Console.WriteLine("\nSelecione um produto: ");
                ProdutoUI.ListarProdutos(listaProdutos);
                Console.WriteLine("Digite o ID do produto desejado: \n");
                produtoID = Convert.ToInt32(Console.ReadLine());
                produto = ProdutoUI.BuscarPorIdProduto(listaProdutos, produtoID);

                totalvenda = totalvenda + produto.Preco;
                produtosVenda.Add(produto);

            }


        }


    }
}
