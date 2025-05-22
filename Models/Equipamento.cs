using GestaoDeEstoque.Compartilhado;

namespace GestaoDeEstoque;

public class Equipamento : EntidadeBase
{
    public int Id { get; } = GeradorDeId.GerarId();
    public string Nome { get; set; }
    public double  PrecoDeAquisicao { get; set; }
    public string NumeroDeSerie { get; set; }
    public DateTime DataDeAquisicao { get; set; }
    public string Fabricante { get; set; }

    public Equipamento(string nome, double precoDeAquisicao, string numeroDeSerie, DateTime dataDeAquisicao, Fabricante fabricante)
    {
        Nome = nome;
        PrecoDeAquisicao = precoDeAquisicao;
        NumeroDeSerie = numeroDeSerie;
        DataDeAquisicao = dataDeAquisicao;
        Fabricante = fabricante.Nome;
    }
    
    public Equipamento(string nome, double precoDeAquisicao, string numeroDeSerie, DateTime dataDeAquisicao, string fabricante)
    {
        Nome = nome;
        PrecoDeAquisicao = precoDeAquisicao;
        NumeroDeSerie = numeroDeSerie;
        DataDeAquisicao = dataDeAquisicao;
        Fabricante = fabricante;
    }
    
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