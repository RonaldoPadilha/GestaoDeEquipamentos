using GestaoDeEquipamentos.ConsoleApp.Dominio;

int contadorIds = 1;

Equipamento[] equipamentosSalvos = new Equipamento[100];

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Gestão de Equipamentos");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1 - Cadastrar equipamento");
    Console.WriteLine("2 - Editar equipamento");
    Console.WriteLine("3 - Excluir equipamento");
    Console.WriteLine("4 - Visualizar equipamentos");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------");
    Console.Write("> ");
    string? opcaoMenu = Console.ReadLine()?.ToUpper();

    if (opcaoMenu == "S")
    {
        Console.Clear();
        break;
    }

    if (opcaoMenu == "1")
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Cadastro de Equipamento");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Digite o nome do equipamento: ");
        String nome = Console.ReadLine();

        Console.WriteLine("Digite o preço de aquisição do equipamento: ");
        decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite a date de fabricação do equipamento: ");
        DateTime dataFabricação = DateTime.Parse(Console.ReadLine());

        Equipamento equipamento = new Equipamento();
        equipamento.id = contadorIds++;
        equipamento.nome = nome;
        equipamento.precoAquisicao = precoAquisicao;
        equipamento.dataFabricacao = dataFabricação;

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            if (equipamentosSalvos[i] == null)
            {
                equipamentosSalvos[i] = equipamento;
                break;
            }
        }

        Console.WriteLine($"O produto {equipamento.nome} foi cadastrado com sucesso!");
        Console.ReadLine();
    }

    else if (opcaoMenu == "2")
    {
    }

    else if (opcaoMenu == "3")
    {
    }

    else if (opcaoMenu == "4")
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Visualizar equipamentos");
        Console.WriteLine("---------------------------------");

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
            "Id", "Nome", "Preço de Aquisição", "Data de fabricação"
        );

        Console.WriteLine("---------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.WriteLine();
    }
}