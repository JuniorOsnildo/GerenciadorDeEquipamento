using GestaoDeEstoque.Compartilhado;

namespace GestaoDeEstoque;

public class Chamado(
    string titulo,
    string descricao,
    Equipamento equipamento,
    DateTime dataDeAbertura
) : EntidadeBase
{
    public string Titulo { get; set; } = titulo;
    public string Descricao { get; set; } = descricao;
    public Equipamento Equipamento { get; set; } = equipamento;
    public DateTime DataDeAbertura { get; set; } = dataDeAbertura;

    public override string ToString()
    {
        var data = DateTime.Now;
        var diferenca = data - DataDeAbertura;
        
        return $"-----------------------------------------\n" +
               $"[{Id}] - {Titulo}\n" +
               $"Equipamento: {Equipamento.Nome}\n" +
               $"Descrição: {Descricao}\n" +
               $"Tempo de abertura: {diferenca} Dias\n" +
               $"-----------------------------------------";
    }
}