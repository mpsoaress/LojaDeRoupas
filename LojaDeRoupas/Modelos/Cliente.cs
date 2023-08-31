using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeRoupas.Models
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int ClienteID { get; set; }

        public Cliente(string nome, string sobrenome, string endereco, string telefone, int clienteID)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Endereco = endereco;
            Telefone = telefone;
            ClienteID = clienteID;
        }
    }
}