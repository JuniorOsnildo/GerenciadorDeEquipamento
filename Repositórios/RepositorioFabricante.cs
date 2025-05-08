namespace GestaoDeEstoque;

public static class RepositorioFabricante
{
    private static readonly List<Fabricante> ListaFabricante = [];
    
    public static List<Fabricante> GetListaFabricante()
    {
        return ListaFabricante;
    }
}