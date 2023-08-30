using LojaDeRoupas.Models;
using LojaDeRoupas.UI;

namespace LojaDeRoupas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Marcos Paulo", "Miranda Soares", "Rua Paraguai 2530", "4599999-9999");
            Produto produto = new Produto("Calça masc jeans", "Calça masculina jeans preta", 199.99);
            produto.ExibirInformacoes();
            ClienteUI.CadastrarCliente();

        }
    }
}