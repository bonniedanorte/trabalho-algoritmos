int raio;

Console.WriteLine("Digite o raio da pizza");
raio = Convert.ToInt32(Console.ReadLine());

decimal area;
area = (raio * raio) * 3.14m;

Console.WriteLine($"A área da sua pizza é de {area}");