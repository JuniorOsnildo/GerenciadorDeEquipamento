using System.Globalization;
using GestaoDeEstoque.Repositórios;

namespace GestaoDeEstoque;

public static class TelaChamados
{
    
    public static char ApresentarMenu()
    {
        Console.Clear();
        Console.WriteLine("-- MENU DE CHAMADOS --");
        Console.WriteLine("1 -> Registro de chamado");
        Console.WriteLine("2 -> Lista de chamados");
        Console.WriteLine("3 -> Editar chamado");
        Console.WriteLine("4 -> Remover chamado");
        Console.WriteLine("0 -> Sair");
        Console.WriteLine();
        Console.Write("-> ");
        return Console.ReadKey().KeyChar;
    }
    
    private static char SelecionarEdição()
    {
        Console.Clear();
        Console.WriteLine("-- QUAL VALOR DESEJA EDITAR? --");
        Console.WriteLine("0 -> Titulo");
        Console.WriteLine("1 -> Descrição");
        Console.WriteLine("2 -> Equipamento");
        Console.WriteLine("3 -> Data de abertura");
        Console.WriteLine();
        Console.Write("-> ");
        return Console.ReadKey().KeyChar;
    }
    
    public static void CriarChamado()
    {
        var titulo = "";
        
        do
        {
            Console.Clear();
            Console.WriteLine("Digite o titulo do chamado [minimo 6 characteres]: ");
            titulo = Console.ReadLine();
        } while (titulo is { Length: < 6 });

        Console.WriteLine("Digite a descrição do chamado: ");
        var descricao = Console.ReadLine();
        
        var dataString = DateTime.Now.ToString("dd/MM/yyyy");
        var data = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o id do equipamento: ");
        var equipId = int.Parse(Console.ReadLine());
        var equipamento = TelaEquipamentos.BuscarEquipamentoPorId(equipId);

        var chamado = new Chamado(titulo, descricao, equipamento, data);

        RepositorioChamados.GetRegistro().Add(chamado);
    }

    public static void MostrarChamado()
    {
        RepositorioChamados.GetRegistro().ForEach(eq => Console.WriteLine(eq.ToString()));
        Console.ReadKey();
    }
    
    public static void ExcluirChamado()
    {
        Console.WriteLine("Digite o id do chamado: ");
        var id = int.Parse(Console.ReadLine());

        foreach (var chamado in RepositorioChamados.GetRegistro().Where
                     (chamado => id == chamado.Id))
        {
            RepositorioChamados.GetRegistro().Remove(chamado);
        }
    }
    
    public static void EditarChamado()
    {
        Console.WriteLine("Digite o Id do chamado: ");
        var equipId = int.Parse(Console.ReadLine());

        var opcao = SelecionarEdição();

        foreach (var chamado in RepositorioChamados.GetRegistro().Where
                     (chamado => chamado.Id == equipId))
        {
            switch (opcao)
            {
                case '0': chamado.Titulo = EditarTitulo(); break;
                case '1': chamado.Descricao = EditarDescricao(); break;
                case '2': chamado.Equipamento = EditarEquipamento(); break;
                case '3': chamado.DataDeAbertura = EditarData(); break;
            }
        }
    }

    private static string EditarTitulo()
    {
        Console.WriteLine("Digite o novo titulo do chamado: ");
        var titulo = Console.ReadLine();
        return titulo ?? " ";
    }
    private static string EditarDescricao()
    {
        Console.WriteLine("Digite a nova descrição do chamado: ");
        var descricao = Console.ReadLine();
        return descricao ?? " ";
    }
    private static Equipamento EditarEquipamento()
    {
        Console.WriteLine("Digite o id do equipamento do chamado: ");
        var id = int.Parse(Console.ReadLine());
        
        var equipamento = TelaEquipamentos.BuscarEquipamentoPorId(id);
        
        return equipamento;
    }
    private static DateTime EditarData()
    {
        Console.WriteLine("Digite a nova data do chamado: ");
        var dataString = Console.ReadLine();
        var data = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        return data;
    }
}