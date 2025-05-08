using System.Globalization;

namespace GestaoDeEstoque;

public class TelaEquipamentos
{
    public static char ApresentarMenu()
    {
        Console.Clear();
        Console.WriteLine("-- MENU DE EQUIPAMENTOS --");
        Console.WriteLine("1 -> Registrar equipamento");
        Console.WriteLine("2 -> Lista de equipamentos");
        Console.WriteLine("3 -> Editar equipamento");
        Console.WriteLine("4 -> Remover equipamento");
        Console.WriteLine("0 -> Sair");
        Console.WriteLine();
        Console.Write("-> ");
        return Console.ReadKey().KeyChar;
    }

    public void CriarEquipamento()
    {
        var nome = "";
        
        do
        {
            Console.Clear();
            Console.WriteLine("Digite o nome do equipamento [minimo 6 characteres]: ");
            nome = Console.ReadLine();
        } while (nome is { Length: > 6 });
        
        Console.WriteLine("Digite o preco do equipamento: ");
        var preco = double.Parse(Console.ReadLine() ?? "0.0"); 

        Console.WriteLine("Digite o numero de serie do equipamento: ");
        var numeroDeSerie = Console.ReadLine();

        Console.WriteLine("Digite a data de aquisição do equipamento [dd/mm/yyyy]: ");
        var dataString = Console.ReadLine() ?? "01/01/0001";
        
        var dataDeAquisicao = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o nome do produto [minimo 6 characteres]: ");
        var fabricante = Console.ReadLine();

        var equipamento = new Equipamento(nome, preco, numeroDeSerie, dataDeAquisicao, fabricante);

        RepositorioEquipamento.GetListaEquipamento().Add(equipamento);
    }

    public void MostrarEquipamento()
    {
        RepositorioEquipamento.GetListaEquipamento().ForEach(eq => Console.WriteLine(eq.ToString()));
    }

    public static Equipamento? BuscarEquipamentoPorId(int id)
    {
        return RepositorioEquipamento.GetListaEquipamento().FirstOrDefault(eq => eq.Id == id);
    }

    private static char SelecionarEdição()
    {
        Console.Clear();
        Console.WriteLine("-- QUAL VALOR DESEJA EDITAR? --");
        Console.WriteLine("0 -> Nome");
        Console.WriteLine("1 -> Preço de aquisição");
        Console.WriteLine("2 -> Numero de serie");
        Console.WriteLine("3 -> Data de Aquisição");
        Console.WriteLine("4 -> Fabricante");
        Console.WriteLine();
        Console.Write("-> ");
        return Console.ReadKey().KeyChar;
    }

    public void EditarEquipamento()
    {
        Console.WriteLine("Digite o Id do equipamento: ");
        var equipId = int.Parse(Console.ReadLine());

        var opcao = SelecionarEdição();

        foreach (var equipamento in RepositorioEquipamento.GetListaEquipamento().Where
                     (equipamento => equipamento.Id == equipId))
        {
            switch (opcao)
            {
                case '0': equipamento.Nome = EditarNome(); break;
                case '1': equipamento.PrecoDeAquisicao = EditarPreco(); break;
                case '2': equipamento.NumeroDeSerie = EditarNumeroDeSerie(); break;
                case '3': equipamento.DataDeAquisicao = EditarDataDeAquisicao(); break;
                case '4': equipamento.Fabricante = EditarFabricante(); break;
            }
        }
    }

    private static string EditarNome()
    {
        Console.WriteLine("Digite o novo nome do equipamento: ");
        var nome = Console.ReadLine();
        return nome ?? " ";
    }
    private static double EditarPreco()
    {
        Console.WriteLine("Digite o novo preço do equipamento: ");
        var preco = double.Parse(Console.ReadLine());
        return preco;
    }
    private static string EditarNumeroDeSerie()
    {
        Console.WriteLine("Digite o novo numero de serie do equipamento: ");
        var nSerie = Console.ReadLine();
        return nSerie ?? " ";
    }
    private static DateTime EditarDataDeAquisicao()
    {
        Console.WriteLine("Digite a nova data do equipamento: ");
        var dataString = Console.ReadLine();
        var data = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        return data;
    }
    private static string EditarFabricante()
    {
        Console.WriteLine("Digite o novo fabricante do equipamento: ");
        var fabricante = Console.ReadLine();
        return fabricante ?? " ";
    }

    public void ExcluirEquipamento()
    {
        Console.WriteLine("Digite o id do equipamento: ");
        var id = int.Parse(Console.ReadLine());

        foreach (var equip in RepositorioEquipamento.GetListaEquipamento().Where
                     (equip => id == equip.Id))
        {
            RepositorioEquipamento.GetListaEquipamento().Remove(equip);
        }
    }
}