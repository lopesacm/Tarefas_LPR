public struct Personagem
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}


class Program
{
    public static Personagem[] personagems;
    public static Personagem[] equipe = new Personagem[3];
    static void Main()
    {

        int opcao = 0;
        bool sair = false;
        while (sair == false)
        {


            Console.WriteLine("----------Menu----------");
            Console.WriteLine("1 - Cadastrar Personagem");
            Console.WriteLine("2 - Selecionar equipe");
            Console.WriteLine("3 - Exibir equipe");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("Digite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    CadastrarPersonagem();
                    break;
                case 2:
                    SelecionarEquipe();
                    break;
                case 3:
                    ExibirEquipe();
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa...");
                    sair = true;
                    break;
            }
        }

    }
    static void CadastrarPersonagem()
    {
        Console.Clear();
        int numeroPersonagens;
        Console.WriteLine("Digite o número de personagens que deseja cadastrar (entre 3 e 5): ");
        numeroPersonagens = int.Parse(Console.ReadLine());
        while (numeroPersonagens > 5 && numeroPersonagens < 3)
        {
            Console.WriteLine("Número inválido. Digite um número entre 3 e 5: ");
            numeroPersonagens = int.Parse(Console.ReadLine());
        }

        personagems = new Personagem[numeroPersonagens];
        Console.Clear();
        Console.WriteLine("Cadastrar Personagem");
        for (int i = 0; i < numeroPersonagens; i++)
        {
            Console.WriteLine($"Digite o nome do personagem {i + 1}: ");
            personagems[i].Nome = Console.ReadLine();
            Console.WriteLine($"Digite o poder do personagem {i + 1}: ");
            personagems[i].Poder = Console.ReadLine();
            Console.WriteLine($"Digite a pontuação do personagem {i + 1}: ");
            personagems[i].Pontuacao = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        Console.Clear();
        Console.WriteLine("Personagens cadastrados com sucesso!");
    }
    static void SelecionarEquipe()
    {
        if(personagems == null || personagems.Length == 0)
        {
            Console.WriteLine("Nenhum personagem cadastrado. Por favor, cadastre personagens primeiro.");
            return;
        }
        Console.Clear();
        Console.WriteLine("Selecione a equipe:");
        for (int x = 0; x < 3; x++)
        {
            for (int i = 0; i < personagems.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {personagems[i].Nome} - Poder: {personagems[i].Poder} - Pontuação: {personagems[i].Pontuacao}");
            }
            Console.WriteLine("Digite o número do personagem que deseja selecionar: ");
            int escolha = int.Parse(Console.ReadLine());
            equipe[x] = personagems[escolha - 1];
        }
    }
    static void ExibirEquipe()
    {
        if (equipe == null || equipe.Length == 0)
        {
            Console.WriteLine("Nenhuma equipe selecionada. Por favor, selecione uma equipe primeiro.");
            return;
        }
        Console.Clear();
        Console.WriteLine("Equipe Selecionada:");
        for (int i = 0; i < equipe.Length; i++)
        {
            Console.WriteLine($"Personagem {i + 1}: {equipe[i].Nome} - Poder: {equipe[i].Poder} - Pontuação: {equipe[i].Pontuacao}");
            
        }
        Pontucao();
    }
    static void Pontucao()
    {
        int pontototal = 0;
        for (int i = 0; i < equipe.Length; i++)
        {
            pontototal = equipe[i].Pontuacao;

        }
        Console.WriteLine($"Pontuação Total da equipe:{pontototal}");
    }
}