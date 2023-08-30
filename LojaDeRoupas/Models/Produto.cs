using System;

namespace LojaDeRoupas.Models
{
    internal class Produto
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public Categoria? Categoria { get; private set; }
        public double Preco { get; private set; }

        public Produto(string nome, string descricao, Categoria categoria, double preco)
        {
            Nome = nome;
            Descricao = descricao;
            Categoria = categoria;
            Preco = preco;
        }

        public Produto(string nome, string descricao, double preco)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Preco: {Preco}");
        }
    }
}
