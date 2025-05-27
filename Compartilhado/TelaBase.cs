using System.Globalization;
using GestaoDeEstoque.Repositórios;

namespace GestaoDeEstoque.Compartilhado;

public class TelaBase
{
      
    public static char ApresentarMenu()
    {
        Console.Clear();
        Console.WriteLine("-- MENU --");
        Console.WriteLine("1 -> Registros");
        Console.WriteLine("2 -> Lista de regitros");
        Console.WriteLine("3 -> Editar registro");
        Console.WriteLine("4 -> Remover regitro");
        Console.WriteLine("0 -> Sair");
        Console.WriteLine();
        Console.Write("-> ");
        return Console.ReadKey().KeyChar;
    }
}