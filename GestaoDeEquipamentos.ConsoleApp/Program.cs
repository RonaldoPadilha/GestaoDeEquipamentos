using GestaoDeEquipamentos.ConsoleApp.Dominio;

int contadorIdsEquipamentos = 1;
Equipamento[] equipamentosSalvos = new Equipamento[100];

int contadorIdsChamados = 1;
Chamado[] chamadosSalvos = new Chamado[100];

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Gestão de Equipamentos");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1 - Controle de equipamento");
    Console.WriteLine("2 - Controle de chamados");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------");
    Console.Write("> ");
    string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

    if (opcaoMenuPrincipal == "S")
    {
        Console.Clear();
        break;
    }
    if (opcaoMenuPrincipal == "1")
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Controle de Equipamentos");
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
            // Operações CRUD - Create (Criar), Read (Ler), Update (Atualizar), Delete (Deletar)
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
                equipamento.id = contadorIdsEquipamentos++;
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
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Editar equipamento");
                Console.WriteLine("---------------------------------");

                Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                    "Id", "Nome", "Preço de Aquisição", "Data de fabricação"
                );

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                        continue;

                    Console.WriteLine(
                        "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                        eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao
                    );
                }

                Console.WriteLine("---------------------------------");
                Console.Write("Digite o id do registro que deseja editar: ");
                int idSelecionado = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o nome do equipamento: ");
                String nome = Console.ReadLine();

                Console.WriteLine("Digite o preço de aquisição do equipamento: ");
                decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite a date de fabricação do equipamento: ");
                DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento equipamentoSelecionado = equipamentosSalvos[i];

                    if (equipamentoSelecionado.id == null)
                        continue;

                    if (equipamentoSelecionado.id == idSelecionado)
                    {
                        equipamentoSelecionado.nome = nome;
                        equipamentoSelecionado.precoAquisicao = precoAquisicao;
                        equipamentoSelecionado.dataFabricacao = dataFabricacao;
                        break;
                    }
                }

                Console.WriteLine($"O produto {nome} foi editado com sucesso!");
                Console.ReadLine();
            }

            else if (opcaoMenu == "3")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Editar equipamento");
                Console.WriteLine("---------------------------------");

                Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                    "Id", "Nome", "Preço de Aquisição", "Data de fabricação"
                );

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                        continue;

                    Console.WriteLine(
                        "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                        eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao
                    );
                }

                Console.WriteLine("---------------------------------");
                Console.Write("Digite o id do registro que deseja excluir: ");
                int idSelecionado = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento equipamentoSelecionado = equipamentosSalvos[i];

                    if (equipamentoSelecionado == null)
                        continue;

                    if (equipamentoSelecionado.id == idSelecionado)
                        equipamentosSalvos[i] = null;
                }
                Console.WriteLine($"O equipamento foi excluido com sucesso!");
                Console.ReadLine();
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

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                        continue;

                    Console.WriteLine(
                        "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                        eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao
                    );
                }

                Console.WriteLine("---------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }

    else if (opcaoMenuPrincipal == "2")
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Controle de Chamados");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1 - Cadastrar Chamado");
            Console.WriteLine("2 - Editar Chamado");
            Console.WriteLine("3 - Excluir Chamado");
            Console.WriteLine("4 - Visualizar Chamados");
            Console.WriteLine("S - Sair");
            Console.WriteLine("---------------------------------");
            Console.Write("> ");
            string? opcaoMenu = Console.ReadLine()?.ToUpper();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }
            // Operações CRUD - Create (Criar), Read (Ler), Update (Atualizar), Delete (Deletar)

            if (opcaoMenu == "1")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Cadastro de Chamado");
                Console.WriteLine("---------------------------------");

                Console.WriteLine("Digite o título do chamado: ");
                String titulo = Console.ReadLine();

                Console.WriteLine("Digite a descrição do chamado: ");
                String descricao = Console.ReadLine();

                DateTime dataAbertura = DateTime.Now;

                // Apresentar os equipamentos cadastrados
                Console.WriteLine("---------------------------------");

                Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                    "Id", "Nome", "Preço de Aquisição", "Data de fabricação"
                );

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                        continue;

                    Console.WriteLine(
                        "{0, -7} | {1, -15} | {2, -20} | {3, -15}",
                        eq.id, eq.nome, eq.precoAquisicao, eq.dataFabricacao
                    );
                }

                Console.WriteLine("---------------------------------");

                // Pedir para o usuario selecionar o ID do equipamento desejado
                Console.Write("Digite o id do equipamento que deseja selecionar: ");
                int idEquipamentoSelecionado = Convert.ToInt32(Console.ReadLine());

                Equipamento equipamentoSelecionado = null;

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];

                    if (eq == null)
                        continue;

                    if (eq.id == idEquipamentoSelecionado)
                    {
                        equipamentoSelecionado = eq;
                        break;
                    }
                }

                Chamado novoChamado = new Chamado();
                novoChamado.id = contadorIdsChamados++;
                novoChamado.titulo = titulo;
                novoChamado.descricao = descricao;
                novoChamado.dataAbertura = dataAbertura;
                novoChamado.equipamento = equipamentoSelecionado;

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    if (chamadosSalvos[i] == null)
                    {
                        chamadosSalvos[i] = novoChamado;
                        break;
                    }
                }

                Console.WriteLine($"O chamado {novoChamado.titulo} foi cadastrado com sucesso!");
                Console.ReadLine();
            }
        }
    }
}