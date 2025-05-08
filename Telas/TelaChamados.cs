using System.Globalization;

namespace GestaoDeEstoque;

public class TelaChamados
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
    
    public void CriarChamado()
    {
        var titulo = "";
        
        do
        {
            Console.Clear();
            Console.WriteLine("Digite o titulo do chamado [minimo 6 characteres]: ");
            titulo = Console.ReadLine();
        } while (titulo is { Length: > 6 });

        Console.WriteLine("Digite a descrição do chamado: ");
        var descricao = Console.ReadLine();
        
        var dataString = DateTime.Now.ToString("dd/MM/yyyy");
        var data = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o id do equipamento: ");
        var equipId = int.Parse(Console.ReadLine());
        var equipamento = TelaEquipamentos.BuscarEquipamentoPorId(equipId);

        var chamado = new Chamado(titulo, descricao, equipamento, data);

        RepositorioChamados.GetListaDeChamados().Add(chamado);
    }

    public void MostrarMostrarChamado()
    {
        RepositorioEquipamento.GetListaEquipamento().ForEach(eq => Console.WriteLine(eq.ToString()));
    }
    
    
}