using System;

namespace LojaDeRoupas.Models
{
    internal class Categoria
    {
        public int CategoriaID { get;  set; }
        public string Descricao { get;  set; }

        public Categoria(int id, string descricao)
        {
            CategoriaID = id;
            Descricao = descricao;
        }
        
    }
}
