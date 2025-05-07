using GestaoDeEstoque;

var telaEquipamentos = new TelaEquipamentos();

while (true) // LOOP PRINCIPAL
{
    
    Console.WriteLine("--- MENU DO ESTOQUE ---");
    Console.WriteLine("1 -> Equipamento");
    Console.WriteLine("2 -> Chamados");
    Console.WriteLine("3 -> Fabricante");
    Console.WriteLine("0 -> Sair");
    Console.WriteLine();
    Console.Write("-> ");
    var MenuPrincipal = Console.ReadKey().KeyChar;
    
    if (MenuPrincipal == '0') break;

    if (MenuPrincipal == '1') // MENU DE EQUIPAMENTOS
    {
        while (true)
        {
            var opcao = TelaEquipamentos.ApresentarMenu();

            if (opcao == '0') break;

            switch (opcao)
            {
                case '0': break;
                case '1': telaEquipamentos.CriarEquipamento(); break;
                case '2': telaEquipamentos.MostrarEquipamento(); break;
                case '3': telaEquipamentos.EditarEquipamento(); break;
                case '4': telaEquipamentos.ExcluirEquipamento(); break;
                default: Console.WriteLine("Valor invalido"); break;
            }
        
        }
    }
    
    if (MenuPrincipal == '2') // MENU DE CHAMADOS
    {
        while (true)
        {
            var opcao = TelaEquipamentos.ApresentarMenu();

            if (opcao == '0') break;

            switch (opcao)
            {
                case '0': break;
                case '1': telaEquipamentos.CriarEquipamento(); break;
                case '2': telaEquipamentos.MostrarEquipamento(); break;
                case '3': telaEquipamentos.EditarEquipamento(); break;
                case '4': telaEquipamentos.ExcluirEquipamento(); break;
                default: Console.WriteLine("Valor invalido"); break;
            }
        
        }
    }

    
    
    
    
    
}