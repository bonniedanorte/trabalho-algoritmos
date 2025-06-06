decimal lata, g6, g2l;

Console.Write("Digite a quantidade de latas de 350ml de Meia-Cola deseja: ");
lata = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a quantidade de garrafas de 600ml de Meia-Cola deseja: ");
g6 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a quantidade de garrafas de 2 litros de Meia-Cola deseja: ");
g2l = Convert.ToInt32(Console.ReadLine());

decimal litros = (lata * 350 + g6 * 600 + g2l * 2000) / 1000;

Console.WriteLine($"A quantidade total de Meia-Cola em litros é: {litros} Litros");