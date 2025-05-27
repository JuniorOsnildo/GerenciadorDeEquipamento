namespace GestaoDeEstoque.Compartilhado;

public abstract class RepositorioBase<T> where T : EntidadeBase
{
    private static readonly List<T> Registro = [];
    
    public static List<T> GetRegistro()
    {
        return Registro;
    }
}