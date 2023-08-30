using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeRoupas.Models
{
    internal class Venda
    {
        public Cliente Cliente { get; private set; }
        public Produto Produto { get; private set; }

        public Venda(Cliente cliente, Produto produto)
        {
            Cliente = cliente;
            Produto = produto;
        }
    }
}
