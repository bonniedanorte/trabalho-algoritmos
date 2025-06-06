decimal n1, n2, media;

Console.Write("Digite a primeira nota do aluno: ");
n1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite a segunda nota do aluno: ");
n2 = Convert.ToDecimal(Console.ReadLine());

n1 *= 2;
n2 *= 3;
media = (n1 + n2) / 6;

Console.WriteLine($"A média ponderada do aluno é: {media}");