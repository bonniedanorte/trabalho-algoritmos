int um, cinco, dez, vinte, cinquenta, real;

Console.Write("Digite a quantidades de moedas de 1 centavo que Pedrinho guardou: ");
um = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a quantidades de moedas de 5 centavo que Pedrinho guardou: ");
cinco = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a quantidades de moedas de 10 centavo que Pedrinho guardou: ");
dez = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a quantidades de moedas de 25 centavo que Pedrinho guardou: ");
vinte = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a quantidades de moedas de 50 centavo que Pedrinho guardou: ");
cinquenta = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a quantidades de moedas de 1 real que Pedrinho guardou: ");
real = Convert.ToInt32(Console.ReadLine());

decimal total = (um * 0.01m) + (cinco * 0.05m) + (dez * 0.10m) + (vinte * 0.25m) + (cinquenta * 0.50m) + (real * 1.00m);

Console.WriteLine($"O total de dinheiro que Pedrinho guardou é: R$ {total}");