double c1, c2, h;

Console.Write("Digite o valor do primeiro cateto: ");
c1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor do segundo cateto: ");
c2 = Convert.ToDouble(Console.ReadLine());

h = Math.Sqrt(c1 * c1 + c2 * c2);

Console.WriteLine($"A hipotenusa é: {h:F2}");