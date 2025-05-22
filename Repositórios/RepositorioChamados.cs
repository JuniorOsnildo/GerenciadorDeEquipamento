using GestaoDeEstoque.Compartilhado;

namespace GestaoDeEstoque.Repositórios;

public abstract class RepositorioChamados : RepositorioBase
{
    private static readonly List<Chamado> Registro = [];

    public new static List<Chamado> GetRegistro()
    {
        return Registro;
    }
}