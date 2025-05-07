using System.Globalization;

namespace GestaoDeEstoque;

public class TelaEquipamentos
{
    RepositorioEquipamento repositorioEquipamento = new RepositorioEquipamento();
    
    public char ApresentarMenu()
    {
        Console.Clear();
        Console.WriteLine("-- MENU DO ESTOQUE --");
        Console.WriteLine("1 -> Registro de equipamento");
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
        var preco = double.Parse(Console.ReadLine()); 

        Console.WriteLine("Digite o numero de serie do equipamento: ");
        var numeroDeSerie = Console.ReadLine();

        Console.WriteLine("Digite a data de aquisição do equipamento [dd/mm/yyyy]: ");
        var dataString = Console.ReadLine();
        
        var dataDeAquisicao = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o nome do produto [minimo 6 characteres]: ");
        var fabricante = Console.ReadLine();

        var equipamento = new Equipamento(nome, preco, numeroDeSerie, dataDeAquisicao, fabricante);

        repositorioEquipamento.GetListaEquipamento().Add(equipamento);
    }

    public void MostrarEquipamento()
    {
        repositorioEquipamento.GetListaEquipamento().ForEach(eq => Console.WriteLine(eq.ToString()));
    }

    private char SelecionarEdição()
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

        foreach (var equipamento in repositorioEquipamento.GetListaEquipamento().Where
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

    private string EditarNome()
    {
        Console.WriteLine("Dgite o novo nome do equipamento: ");
        var nome = Console.ReadLine();
        return nome ?? " ";
    }
    private double EditarPreco()
    {
        Console.WriteLine("Dgite o novo nome do equipamento: ");
        var preco = double.Parse(Console.ReadLine());
        return preco;
    }
    private string EditarNumeroDeSerie()
    {
        Console.WriteLine("Dgite o novo nome do equipamento: ");
        var nSerie = Console.ReadLine();
        return nSerie ?? " ";
    }
    private DateTime EditarDataDeAquisicao()
    {
        Console.WriteLine("Dgite o novo nome do equipamento: ");
        var dataString = Console.ReadLine();
        var data = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        return data;
    }
    private string EditarFabricante()
    {
        Console.WriteLine("Dgite o novo nome do equipamento: ");
        var fabricante = Console.ReadLine();
        return fabricante ?? " ";
    }

    public void ExcluirEquipamento()
    {
        Console.WriteLine("Digite o id do equipamento: ");
        var id = int.Parse(Console.ReadLine());

        foreach (var equip in repositorioEquipamento.GetListaEquipamento().Where
                     (equip => id == equip.Id))
        {
            repositorioEquipamento.GetListaEquipamento().Remove(equip);
        }
    }
}