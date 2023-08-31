using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeRoupas.Utilidades
{
    public class GeradorID
    {
        public int ClienteID { get; set; }
        public int CategoriaID { get; set; }
        public int ProdutoID { get; set; }
        public int VendaID { get; set; }

        public GeradorID()
        {
            ClienteID = 1;
            CategoriaID = 1;
            ProdutoID = 1;
            VendaID = 1;
        }
        public int ProximoClienteID()
        {
            return (int)ClienteID++;
        }

        public int ProximoCategoriaID()
        {
            return (int)CategoriaID++;
        }

        public int ProximoProdutoID()
        {
            return (int)ProdutoID++;
        }

        public int ProximoVendaID()
        {
            return (int)VendaID++;
        }

    }
}
