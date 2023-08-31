using System;

namespace LojaDeRoupas.Models
{
    internal class Produto
    {
        public int ProdutoID { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public double Preco { get; set; }

        public Produto(int produtoid, string descricao, Categoria categoria, double preco)
        {
            ProdutoID = produtoid;
            Descricao = descricao;
            Categoria = categoria;
            Preco = preco;
        }

        
    }
}
