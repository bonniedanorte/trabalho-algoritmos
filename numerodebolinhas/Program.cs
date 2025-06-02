int chute = 0, tentativas = 0;

    while (chute != 82)
{
    Console.WriteLine("Digite um numero para chutar");
    chute = Convert.ToInt32(Console.ReadLine());

    tentativas++;
    if (chute < 82)
    {
        Console.WriteLine("Você errou! Existem mais bolinhas do que você digitou");
    }
    if (chute > 82)
    {
        Console.WriteLine("Você errou! Existem menos bolinhas do que você digitou");
    }
        
}

    Console.WriteLine("Você acertou com " + tentativas + " tentativas");
 