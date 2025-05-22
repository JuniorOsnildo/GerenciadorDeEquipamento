using GestaoDeEstoque.Compartilhado;

namespace GestaoDeEstoque;

public abstract class RepositorioEquipamento : RepositorioBase
{
    private static readonly List<Equipamento> Registro = [];

    public new static List<Equipamento> GetRegistro()
    {
        return Registro;
    }

    
}