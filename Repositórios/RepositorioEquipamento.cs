namespace GestaoDeEstoque;

public class RepositorioEquipamento
{
    private readonly List<Equipamento> ListaEquipamento = [];

    public List<Equipamento> GetListaEquipamento()
    {
        return ListaEquipamento;
    }

    
}