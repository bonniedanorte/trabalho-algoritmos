int Cp, Cm, Cg, total;

Console.Write("Digite a quantidade de camisas pequenas ");
Cp = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a quantidade de camisas médias ");
Cm = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a quantidade de camisas grandes ");
Cg = Convert.ToInt32(Console.ReadLine());

Cp = Cp * 10;
Cm = Cm * 12;
Cg = Cg * 15;
total = Cp + Cm + Cg;

Console.WriteLine($"O valor a ser arrecadado é de R$ {total},00");