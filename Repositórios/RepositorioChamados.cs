namespace GestaoDeEstoque;

public class RepositorioChamados
{
    private readonly List<Chamado> ListaChamados = [];

    public List<Chamado> GetListaDeChamados()
    {
        return ListaChamados;
    }
}