public struct Produto
{
    public string Nome;
    public string Codigo;
    public double Preco;

    public int Quantidade;
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Insira os dados dos produtos");
        Produto[] produtos = new Produto[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Digite o nome do {i + 1} prduto:");
            produtos[i].Nome = Console.ReadLine();
            Console.WriteLine($"Digite o codigo do {i + 1} prduto:");
            produtos[i].Codigo = Console.ReadLine();
            Console.WriteLine($"Digite o preco do {i + 1} prduto:");
            produtos[i].Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Digite a quantidade do {i + 1} prduto:");
            produtos[i].Quantidade = Convert.ToInt32(Console.ReadLine());
        }
        double soma = 0;
        foreach (Produto x in produtos)
        {
            soma += (x.Preco * x.Quantidade);
        }
        Console.WriteLine(soma);
    }
}