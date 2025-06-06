decimal num1, num2;

Console.Write("Digite o primeiro número para dividir com o segundo: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o segundo número (Não pode ser 0): ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == 0)
{
    Console.WriteLine("Erro: Divisão por zero não é permitida.");
    return;
}

decimal resul = num1 / num2;

Console.WriteLine($"O resultado da divisão é: {resul}");