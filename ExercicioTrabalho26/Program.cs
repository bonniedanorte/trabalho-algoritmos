int num1, num2, num3;

Console.Write("Digite um número para multiplicar com os dois próximos ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite um número ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite um número ");
num3 = Convert.ToInt32(Console.ReadLine());

int resul = num1 * num2 * num3;

Console.WriteLine($"O resultado da multiplicação é: {resul}");