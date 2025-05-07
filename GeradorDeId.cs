namespace GestaoDeEstoque;

public static class GeradorDeId
{
    private static readonly Random Rand = new Random();
    
    public static int GerarId()
    {
        return Rand.Next();
    }
}