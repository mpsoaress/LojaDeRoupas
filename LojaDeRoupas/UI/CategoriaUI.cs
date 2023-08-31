using LojaDeRoupas.Models;
using LojaDeRoupas.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeRoupas.UI
{
    internal class CategoriaUI
    {
        internal static Categoria RegistrarCategoria(int id)
        {
            string descricao;
            Console.WriteLine("\n############# CADASTRO DE CATEGORIA ###############");
            Console.WriteLine("Descrição: ");
            descricao = Convert.ToString(Console.ReadLine());
            return new Categoria(id, descricao);
        }

        internal static Categoria BuscarPorIdCategoria(List<Categoria> listaCategorias, int id)
        {

            Categoria categoria = listaCategorias.Find(x => x.CategoriaID == id);
            Console.WriteLine($"\nID Categoria: {categoria.CategoriaID}");
            Console.WriteLine($"Descrição: {categoria.Descricao}");
            return categoria;

        }

        internal static void RemoverCategoria(List<Categoria> listaCategorias, int id)
        {

            Categoria categoriaBusca = CategoriaUI.BuscarPorIdCategoria(listaCategorias, id);
            listaCategorias.Remove(categoriaBusca);
            Console.WriteLine($"\nCategoria com id {id} foi removido");
        }

        internal static void ListarCategoria(List<Categoria> listaCategorias)
        {
            foreach (Categoria categoria in listaCategorias)
            {

                Console.WriteLine($"\nID Categoria: {categoria.CategoriaID}");
                Console.WriteLine($"Descrição: {categoria.Descricao}");
                Console.WriteLine("######################################\n");

            }
        }

        internal static void AlterarCategoria(List<Categoria> listaCategorias, int id)
        {

            Categoria categoriabusca = CategoriaUI.BuscarPorIdCategoria(listaCategorias, id);

            Console.WriteLine("\n############# ALTERAÇÂO DE CADASTRO DE CATEGORIA ###############");
            Console.WriteLine("Descrição: ");
            categoriabusca.Descricao = Convert.ToString(Console.ReadLine());

        }
    }
}
