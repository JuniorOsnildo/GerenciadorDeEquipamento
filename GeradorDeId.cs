namespace GestaoDeEstoque;

public static class GeradorDeId
{
    private static int id = 1;
    
    public static int GerarId()
    {
        var newId = id;
        id++;
        return newId;
    }
}