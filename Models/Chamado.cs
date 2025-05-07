namespace GestaoDeEstoque;

public class Chamado(
    string titulo,
    string descricao,
    Equipamento equipamento,
    DateTime dataDeAbertura
)
{
    public int Id { get; } = GeradorDeId.GerarId();
    public string Titulo { get; set; } = titulo;
    public string Descricao { get; set; } = descricao;
    public Equipamento Equipamento { get; set; } = equipamento;
    public DateTime DataDeAbertura { get; set; } = dataDeAbertura;

    public override string ToString()
    {
        return $"-----------------------------------------\n" +
               $"[{Id}] - {Titulo}\n" +
               $"Preço de aquisição: {Equipamento.Nome}\n" +
               $"Numero de serie: {Descricao}\n" +
               $"Data de aquisiçõa: {DataDeAbertura}\n" +
               $"-----------------------------------------";
    }
}