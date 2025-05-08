namespace GestaoDeEstoque;

public static class RepositorioChamados
{
    private static readonly List<Chamado> ListaChamados = [];

    public static List<Chamado> GetListaDeChamados()
    {
        return ListaChamados;
    }
}