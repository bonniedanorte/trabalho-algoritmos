decimal pi = 3.14m, r, h;

Console.Write("Digite o raio da caixa d'água: ");
r = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite a altura da caixa d'água: ");
h = Convert.ToDecimal(Console.ReadLine());

decimal v = pi * (r * r) * h;

Console.WriteLine($"O volume da caixa d'água é de: {v} cm³");