namespace GestaoDeEstoque.Compartilhado;

public abstract class RepositorioBase
{
    private static readonly List<EntidadeBase> Registro = [];
    
    public static List<EntidadeBase> GetRegistro()
    {
        return Registro;
    }
}