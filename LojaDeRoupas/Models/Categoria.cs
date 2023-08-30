using System;

namespace LojaDeRoupas.Models
{
    internal class Categoria
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

    }
}
