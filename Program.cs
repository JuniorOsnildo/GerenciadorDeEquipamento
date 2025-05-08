using GestaoDeEstoque;

var telaEquipamentos = new TelaEquipamentos();

while (true) // LOOP PRINCIPAL
{
    Console.Clear();
    Console.WriteLine("--- MENU DO ESTOQUE ---");
    Console.WriteLine("1 -> Equipamento");
    Console.WriteLine("2 -> Chamados");
    Console.WriteLine("3 -> Fabricante");
    Console.WriteLine("0 -> Sair");
    Console.WriteLine();
    Console.Write("-> ");
    var menuPrincipal = Console.ReadKey().KeyChar;
    
    if (menuPrincipal == '0') break;

    switch (menuPrincipal)
    {
        // MENU DE EQUIPAMENTOS
        case '1':
        {
            while (true)
            {
                var opcao = TelaEquipamentos.ApresentarMenu();

                if (opcao == '0') break;

                switch (opcao)
                {
                    case '1': TelaEquipamentos.CriarEquipamento(); break;
                    case '2': TelaEquipamentos.MostrarEquipamento(); break;
                    case '3': TelaEquipamentos.EditarEquipamento(); break;
                    case '4': TelaEquipamentos.ExcluirEquipamento(); break;
                    default: Console.WriteLine("Valor invalido"); break;
                }
        
            }

            break;
        }
        // MENU DE CHAMADOS
        case '2':
        {
            while (true)
            {
                var opcao = TelaChamados.ApresentarMenu();

                if (opcao == '0') break;

                switch (opcao)
                {
                    case '1': TelaChamados.CriarChamado(); break;
                    case '2': TelaChamados.MostrarChamado(); break;
                    case '3': TelaChamados.EditarChamado(); break;
                    case '4': TelaChamados.ExcluirChamado(); break;
                    default: Console.WriteLine("Valor invalido"); break;
                }
        
            }

            break;
        }
        //MENU DE FABRICANTES
        case '3':
        {
            while (true)
            {
                var opcao = TelaChamados.ApresentarMenu();

                if (opcao == '0') break;

                switch (opcao)
                {
                    case '1': TelaFabricante.CriarFabricante(); break;
                    case '2': TelaFabricante.MostrarFabricante(); break;
                    case '3': TelaFabricante.EditarFabricante(); break;
                    case '4': TelaFabricante.ExcluirFabricante(); break;
                    default: Console.WriteLine("Valor invalido"); break;
                }
            }
            break;
        }
    }
}