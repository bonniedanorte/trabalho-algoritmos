int soma = 0, numeros = 0;

while (soma !< 100)
{
    Console.WriteLine("Digite um valor para somar");
    soma += Convert.ToInt32(Console.ReadLine());

    numeros++;
}

Console.WriteLine("A soma dos numeros é: " + soma);
Console.WriteLine("Foi necessario: " + numeros + " numero para totalisar um numero maior/igual que 10");