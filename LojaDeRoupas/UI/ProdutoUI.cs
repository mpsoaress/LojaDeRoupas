using LojaDeRoupas.Models;

namespace LojaDeRoupas.UI
{
    internal class ProdutoUI
    {
        internal static Produto RegistrarProduto(int id, List<Categoria> listaCategorias)
        {
            string descricao;
            int categoriaID;
            Categoria categoria;
            double preco;
            Console.WriteLine("\n############# CADASTRO DE PRODUTO ###############");
            Console.WriteLine("Descrição: ");
            descricao = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Preço: ");
            preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEscolha uma categoria do produto: ");
            CategoriaUI.ListarCategoria(listaCategorias);

            Console.WriteLine("\nDigite o ID da categoria desejada: ");
            categoriaID = Convert.ToInt32(Console.ReadLine());
            categoria = CategoriaUI.BuscarPorIdCategoria(listaCategorias, categoriaID);

            return new Produto(id, descricao, categoria, preco);
        }

        internal static Produto BuscarPorIdProduto(List<Produto> listaProdutos, int id)
        {

            Produto produto = listaProdutos.Find(x => x.ProdutoID == id);
            return produto;

        }

        internal static void RemoverProduto(List<Produto> listaProdutos, int id)
        {

            Produto produtoBusca = ProdutoUI.BuscarPorIdProduto(listaProdutos, id);
            listaProdutos.Remove(produtoBusca);
            Console.WriteLine($"Produto com id {id} foi removido");
        }

        internal static void ListarProdutos(List<Produto> listaProdutos)
        {
            foreach (Produto produto in listaProdutos)
            {
                Console.WriteLine($"\nID Produto: {produto.ProdutoID}");
                Console.WriteLine($"Descrição: {produto.Descricao}");
                Console.WriteLine($"Preço: {produto.Preco}");
                Console.WriteLine($"Categoria: {produto.Categoria.Descricao}\n");
                Console.WriteLine("\n");


            }
        }

        internal static void AlterarProduto(List<Produto> produto, int id, List<Categoria> listaCategorias)
        {
            int categoriaID;
            

            Produto produtobusca = ProdutoUI.BuscarPorIdProduto(produto, id);

            Console.WriteLine("\n############# ALTERAÇÂO DE CADASTRO DE PRODUTO ###############");

            Console.WriteLine("Descrição: ");
            produtobusca.Descricao = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Preço: ");
            produtobusca.Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEscolha uma categoria do produto: ");
            CategoriaUI.ListarCategoria(listaCategorias);

            Console.WriteLine("\nDigite o ID da categoria desejada: ");
            categoriaID = Convert.ToInt32(Console.ReadLine());
            produtobusca.Categoria = CategoriaUI.BuscarPorIdCategoria(listaCategorias, categoriaID);


        }
    }
}
