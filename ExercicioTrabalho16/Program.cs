using System.Net.Quic;

int sanduiche;

Console.WriteLine("Digite quantos Sanduiches você deseja");
sanduiche = Convert.ToInt32(Console.ReadLine());

decimal queijo = 0.1m, hamburguer = 0.1m, presunto = 0.05m;
queijo = sanduiche * queijo;
presunto = sanduiche * presunto;
hamburguer = sanduiche * hamburguer;

Console.WriteLine($"A quantidade em quilos de queijo é de {queijo} gramas, de presunto é de {presunto} gramas e a de hamburguer é {hamburguer} gramas");