using GestaoDeEstoque;

var telaEquipamentos = new TelaEquipamentos();

while (true)
{
    var opcao = telaEquipamentos.ApresentarMenu();

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