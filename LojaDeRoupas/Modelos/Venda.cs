using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeRoupas.Models
{
    internal class Venda
    {
        public int VendaId { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> ProdutosVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public double TotalVenda { get; set; }

        public Venda(int vendaID, Cliente cliente, List<Produto> produtosVenda, DateTime datavenda, double totalvenda)
        {
            VendaId = vendaID;
            Cliente = cliente;
            ProdutosVenda = new List<Produto>();
            DataVenda = datavenda;
            TotalVenda = totalvenda;
        }
    }
}
