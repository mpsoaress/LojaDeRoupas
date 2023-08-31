using LojaDeRoupas.Models;
using LojaDeRoupas.UI;
using LojaDeRoupas.Utilidades;
using LojaDeRoupas.Menu;

namespace LojaDeRoupas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeradorID geradorID = new GeradorID();
            List<Cliente> listaClientes = new List<Cliente>();
            List<Categoria> listaCategorias = new List<Categoria>();
            List<Produto> listaProdutos = new List<Produto>();
            List<Venda> listaVendas = new List<Venda>();

            int quantidade;
            string resposta;
            int variavelid;
            int opcao;
            int idVariavel;



            Console.Write("\nInsira a quantidade de clientes a serem cadastrados: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                listaClientes.Add(ClienteUI.RegistrarCliente(geradorID.ProximoClienteID()));
                Console.WriteLine("CLIENTE CADASTRADO\n");
            }
            quantidade = 0;

            Console.WriteLine("\n1- Excluir Cliente");
            Console.WriteLine("2- Atualizar Cliente");
            Console.WriteLine("3- Buscar Cliente");
            Console.WriteLine("4- Continuar");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("######################\n");

            ClienteUI.ListarClientes(listaClientes);
            if (opcao == 1) {
                Console.WriteLine("Qual o Id do cliente a ser removido?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                ClienteUI.RemoverCliente(listaClientes, idVariavel); 
            }else if (opcao == 2) {
                Console.WriteLine("Qual o Id do cliente a ser alterado?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                ClienteUI.AlterarCliente(listaClientes, idVariavel);
            }else if (opcao== 3){
                Console.WriteLine("Qual o Id do cliente a ser buscado?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                ClienteUI.BuscarPorIdCliente(listaClientes, idVariavel);
            }
            opcao = 0;
            idVariavel = 0;
            /////////////////////////////////////////////////////////
            Console.Write("\nInsira a quantidade de categorias a serem cadastradas: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {
                listaCategorias.Add(CategoriaUI.RegistrarCategoria(geradorID.ProximoCategoriaID()));
                Console.WriteLine("CATEGORIA CADASTRADA\n");
            }
            quantidade = 0;
            CategoriaUI.ListarCategoria(listaCategorias);

            Console.WriteLine("\n1- Excluir Categoria");
            Console.WriteLine("2- Atualizar Categoria");
            Console.WriteLine("3- Buscar Categoria");
            Console.WriteLine("4- Continuar");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("######################\n");

            if (opcao == 1)
            {
                Console.WriteLine("Qual o Id da categoria a ser removida?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                CategoriaUI.RemoverCategoria(listaCategorias, idVariavel);
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Qual o Id da categoria a ser alterada?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                CategoriaUI.AlterarCategoria(listaCategorias, idVariavel);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Qual o Id da categoria a ser buscada?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                CategoriaUI.BuscarPorIdCategoria(listaCategorias, idVariavel);
            }
            opcao = 0;
            idVariavel = 0;
            /////////////////////////////////////////////////////////
            Console.Write("\nInsira a quantidade de produtos a serem cadastrados: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {
                listaProdutos.Add(ProdutoUI.RegistrarProduto(geradorID.ProximoProdutoID(), listaCategorias));
                Console.WriteLine("PRODUTO CADASTRADO\n");
            }
            quantidade = 0;
            ProdutoUI.ListarProdutos(listaProdutos);

            Console.WriteLine("\n1- Excluir Produto");
            Console.WriteLine("2- Atualizar Produto");
            Console.WriteLine("3- Buscar Produto");
            Console.WriteLine("4- Continuar");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("######################\n");

            
            if (opcao == 1)
            {
                Console.WriteLine("Qual o Id do Produto a ser removido?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                ProdutoUI.RemoverProduto(listaProdutos, idVariavel);
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Qual o Id do Produto a ser alterado?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                ProdutoUI.AlterarProduto(listaProdutos, idVariavel,listaCategorias);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Qual o Id do Produto a ser buscado?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                ProdutoUI.BuscarPorIdProduto(listaProdutos, idVariavel);
            }
            opcao = 0;
            idVariavel = 0;

            /////////////////////////////////////////////////////////
            Console.Write("\nInsira a quantidade de vendas a serem cadastradas: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < quantidade; i++)
            {
                listaVendas.Add(VendaUI.RegistrarVenda(geradorID.ProximoVendaID(), listaClientes, listaProdutos));
                Console.WriteLine("VENDA CADASTRADA\n");
            }

            VendaUI.ListarVendas(listaVendas);
            Console.WriteLine("\n1- Excluir Venda");
            Console.WriteLine("2- Atualizar Venda");
            Console.WriteLine("3- Buscar Venda");
            Console.WriteLine("4- Continuar");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("######################\n");

            
            if (opcao == 1)
            {
                Console.WriteLine("Qual o Id da Venda a ser removida?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                VendaUI.RemoverVenda(listaVendas, idVariavel);
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Qual o Id da Venda a ser alterada?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                VendaUI.AlterarVenda(idVariavel, listaVendas, listaClientes, listaProdutos);
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Qual o Id da Venda a ser buscada?");
                idVariavel = Convert.ToInt32(Console.ReadLine());
                VendaUI.BuscarPorIdVenda(listaVendas, idVariavel);
            }

        }



    }
}