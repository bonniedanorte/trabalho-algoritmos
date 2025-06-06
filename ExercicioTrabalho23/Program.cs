decimal altura, sombra, predio;

Console.Write("Digite o tamanho da sua sombra: ");
sombra = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o seu tamanho: ");
altura = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o tamanho da sombra do prédio: ");
predio = Convert.ToDecimal(Console.ReadLine());

decimal altpre = altura * predio / sombra;

Console.WriteLine($"O tamanho do prédio é de: {altpre} metros");