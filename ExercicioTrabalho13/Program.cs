int num, c, d, u;

Console.WriteLine("Digite um número inteiro com até 3 dígitos");
num = Convert.ToInt32(Console.ReadLine());

c = num / 100;
d = (num % 100) / 10;
u = num % 10;

Console.WriteLine($"O seu número em Centena foi de {c}, dezena de {d} e unidade de {u}");