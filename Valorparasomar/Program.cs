int numero, somatoria = 0, menorValorDigitados = 0, quantidade = 0, quantidadePares = 0;
string continuar = "s";

while(continuar.ToUpper() == "S" )
{
    Console.WriteLine("Digite um numero");
    numero = Convert.ToInt32(Console.ReadLine());

    somatoria += numero;
    quantidade++;

    if(quantidade == 1 || numero  < menorValorDigitados)
    {
        menorValorDigitados = numero
    }
    if(numero % 2 == 0 )
    {
        quantidadePares++;
    }
    Console.WriteLine("Deseja continuar ? (s ou n)");
    continuar = Console.ReadLine();
}

Console.WriteLine("Somatória: " + somatoria);
Console.WriteLine("Maior valor digitado: " +menorValorDigitados);
Console.WriteLine(" media: " + somatoria / quantidade);
Console.WriteLine(" quantidade de pares " = quantidadePares);

