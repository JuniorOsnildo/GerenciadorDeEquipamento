namespace GestaoDeEstoque;

public static class GeradorDeId
{
    private static Random random = new Random();
    
    public static int GerarId()
    {
        return random.Next();
    }
}