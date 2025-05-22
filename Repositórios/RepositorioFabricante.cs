using GestaoDeEstoque.Compartilhado;

namespace GestaoDeEstoque;

public abstract class RepositorioFabricante : RepositorioBase
{
    private static readonly List<Fabricante> Registro = [];
    
    public new static List<Fabricante> GetRegistro()
    {
        return Registro;
    }
}