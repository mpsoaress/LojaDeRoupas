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
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }

        public Cliente(string nome, string sobrenome, string endereco, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Endereco = endereco;
            Telefone = telefone;
        }
    }
}
