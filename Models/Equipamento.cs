namespace GestaoDeEstoque;

public class Equipamento(
    string nome,
    double precoDeAquisicao,
    string numeroDeSerie,
    DateTime dataDeAquisicao,
    string fabricante)
{
    public int Id { get; } = GeradorDeId.GerarId();
    public string Nome { get; set; } = nome;
    public double  PrecoDeAquisicao { get; set; } = precoDeAquisicao;
    public string NumeroDeSerie { get; set; } = numeroDeSerie;
    public DateTime DataDeAquisicao { get; set; } = dataDeAquisicao;
    public string Fabricante { get; set; } = fabricante;

    public override string ToString()
    {
        return $"-----------------------------------------\n"+
               $"[{Id}] - {Nome}\n"+
               $"Preço de aquisição: {PrecoDeAquisicao}\n"+
               $"Numero de serie: {NumeroDeSerie}\n"+
               $"Data de aquisiçõa: {DataDeAquisicao}\n"+
               $"Fabricante: {Fabricante}\n"+
               $"-----------------------------------------";
    }
}