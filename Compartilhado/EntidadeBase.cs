namespace GestaoDeEstoque.Compartilhado;

public class EntidadeBase
{
    public int Id { get; set; } = GeradorDeId.GerarId();
}