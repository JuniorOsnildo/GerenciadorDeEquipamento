using GestaoDeEstoque.Compartilhado;

namespace GestaoDeEstoque;

public class Fabricante(string nome, string email, string telefone) : EntidadeBase
{
    public int Id { get; } = GeradorDeId.GerarId();
    public string Nome { get; set; } = nome;
    public string Email { get; set; } = email;
    public string Telefone { get; set; } = telefone;

    public override string ToString()
    {
        return $"-----------------------------------------\n" +
               $"[{Id}] - {Nome}\n" +
               $"Email: {Email}\n" +
               $"Telefone: {Telefone}\n" +
               $"-----------------------------------------";
    }
}