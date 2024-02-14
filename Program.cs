//Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

//List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "Calypso"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: "); //escreve sem pular linha
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;

        case 2:
            MostrarBandasRegistradas();
            break;

        case 3:
            AvaliarUmaBanda();
            break;

        case 4:
            ExibirMedia();
            break;

        case -1:
            Console.WriteLine("\nTchau tchau :)");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear(); //limpa o console
    ExibirTituloDaOpcao("Registro de todas as bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (!BandaExiste(nomeDaBanda))
    {
        bandasRegistradas.Add(nomeDaBanda, new List<int>()); //apenas registrando, sem notas
        Console.WriteLine($"A banda {nomeDaBanda} foi resgistrada com sucesso!");

    }else
    {
        Console.WriteLine($"A banda {nomeDaBanda} já existe!");
    }

    Thread.Sleep(2000); //esperar um pouco (em ms)
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();

    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

    /*for(int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }*/

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey(); //qualquer tecla é reconhecida
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*'); //string vazia + colocar coisas à esquerda

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");

    //digite qual banda deseja avaliar
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    //se a banda existir no dicionário >> atribuir uma nota
    if(BandaExiste(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? (0 - 10): ");
        int nota = int.Parse(Console.ReadLine()!);

        if(nota >= 0 && nota <= 10)
        {
            bandasRegistradas[nomeDaBanda].Add(nota); //adiciona a nota na banda escolhida
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        
        }else
        {
            Console.WriteLine("\nNota inválida!");
        }

        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

        //senão, volta ao menu principal
    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia()
{
    //Limpar o console
    Console.Clear();

    //Exibir o título da opção 4: "Exibir média da banda"
    ExibirTituloDaOpcao("Exibir média da banda");

    //Perguntar o nome da banda que deseja exibir a média de avaliações
    Console.Write("Informe o nome da banda que você deseja verificar a média de avaliações: ");
    string nomeDaBanda = Console.ReadLine()!;

    //Consultar se a banda está inserida
    if(BandaExiste(nomeDaBanda))
    {
        //calcular a média
        Console.WriteLine($"\nA média de avaliações da banda {nomeDaBanda} é: {bandasRegistradas[nomeDaBanda].Average()}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    
    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

Boolean BandaExiste(string nomeDaBanda)
{
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        return true;
    }

    return false;
}

ExibirOpcoesDoMenu();