Console.WriteLine("Qual o numero?");
int numero = Int32.Parse(Console.ReadLine());
int numerodobrado = numero * numero;
int soma = 0;
while (numerodobrado != 0)
{
    int resto = numerodobrado % 10;
    numerodobrado = (numerodobrado - resto) / 10;
    soma += resto;

}
Console.WriteLine(soma);