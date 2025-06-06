decimal dMaior, dmenor, A;

Console.Write("Digite o valor do diagonal maior do losango: ");
dMaior = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o valor do diagonal menor do losango: ");
dmenor = Convert.ToDecimal(Console.ReadLine());

A = (dMaior * dmenor) / 2;

Console.WriteLine($"A área do losango é: {A}");
