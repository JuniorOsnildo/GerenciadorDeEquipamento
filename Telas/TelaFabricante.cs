namespace GestaoDeEstoque;

public class TelaFabricante
{
    public static char ApresentarMenu()
    {
        Console.Clear();
        Console.WriteLine("-- MENU DE EQUIPAMENTOS --");
        Console.WriteLine("1 -> Registrar fabricante");
        Console.WriteLine("2 -> Lista de fabricantes");
        Console.WriteLine("3 -> Editar fabricante");
        Console.WriteLine("4 -> Remover fabrincante");
        Console.WriteLine("0 -> Sair");
        Console.WriteLine();
        Console.Write("-> ");
        return Console.ReadKey().KeyChar;
    }

    public static void CriarFabricante()
    {
        var nome = "";
        
        do
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do fabricante [minimo 6 characteres]: ");
            nome = Console.ReadLine();
        } while (nome is { Length: < 6 });

        Console.WriteLine("Digite o email do fabricante: ");
        var email = Console.ReadLine();

        Console.WriteLine("Digite o telefone do fabricante: ");
        var telefone = Console.ReadLine();
        
        var fabricante = new Fabricante(nome, email, telefone);

        RepositorioFabricante.GetListaFabricante().Add(fabricante);
    }

    public static void MostrarFabricante()
    {
        RepositorioFabricante.GetListaFabricante().ForEach(eq => Console.WriteLine(eq.ToString()));
        Console.ReadKey();
    }

    private static char SelecionarEdição()
    {
        Console.Clear();
        Console.WriteLine("-- QUAL VALOR DESEJA EDITAR? --");
        Console.WriteLine("0 -> Nome");
        Console.WriteLine("1 -> Email");
        Console.WriteLine("2 -> Telefone");
        Console.WriteLine();
        Console.Write("-> ");
        return Console.ReadKey().KeyChar;
    }

    public static void EditarFabricante()
    {
        Console.WriteLine("Digite o Id do fabricante: ");
        var fabriId = int.Parse(Console.ReadLine());

        var opcao = SelecionarEdição();

        foreach (var fabricante in RepositorioFabricante.GetListaFabricante().Where
                     (fabricante => fabricante.Id == fabriId))
        {
            switch (opcao)
            {
                case '0': fabricante.Nome = EditarNome(); break;
                case '1': fabricante.Email = EditarEmail(); break;
                case '2': fabricante.Telefone = Editartelefone(); break;
            }
        }
    }

    private static string EditarNome()
    {
        Console.WriteLine("Digite o novo nome do fabricante: ");
        var nome = Console.ReadLine();
        return nome ?? " ";
    }
    private static string EditarEmail()
    {
        Console.WriteLine("Digite o novo email do fabricante: ");
        var preco = Console.ReadLine();
        return preco ?? " ";
    }
    private static string Editartelefone()
    {
        Console.WriteLine("Digite o novo Telefone do fabricante: ");
        var nSerie = Console.ReadLine();
        return nSerie ?? " ";
    }

    public static void ExcluirFabricante()
    {
        Console.WriteLine("Digite o id do fabricante: ");
        var id = int.Parse(Console.ReadLine());

        foreach (var fabricante in RepositorioFabricante.GetListaFabricante().Where
                     (fabricante => id == fabricante.Id))
        {
            RepositorioFabricante.GetListaFabricante().Remove(fabricante);
        }
    }
}