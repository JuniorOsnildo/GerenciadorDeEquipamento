namespace GestaoDeEstoque;

public static class RepositorioEquipamento
{
    private static readonly List<Equipamento> ListaEquipamento = [];

    public static List<Equipamento> GetListaEquipamento()
    {
        return ListaEquipamento;
    }

    
}