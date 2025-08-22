int classe;

Console.WriteLine("Escolha sua classe:\n1-Guerreiro\n2-Mago\n3-Arqueira");
classe = int.Parse(Console.ReadLine());

switch(classe){
    case 1:
        Console.WriteLine("Habilidades:Ataque Pesado, Defesa Total");
        break;
    case 2:
        Console.WriteLine("Habilidades:Bola de Fogo, Escudo de Gelo");
        break;
    case 3:
        Console.WriteLine("Habilidades:Flecha Precisa, Disparo Triplo");
        break;

}

