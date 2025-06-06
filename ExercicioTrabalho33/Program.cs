decimal Bmaior, Bmenor, altura, A;

Console.Write("Digite o valor da base maior: ");
Bmaior = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o valor da base menor: ");
Bmenor = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o valor da altura: ");
altura = Convert.ToDecimal(Console.ReadLine());

A = ((Bmaior + Bmenor) * altura) / 2;

Console.WriteLine($"A área do trapézio é: {A}");