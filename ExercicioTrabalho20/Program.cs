int blusas, novelo;

Console.Write("Digite a quantidade de blusas que deseja: ");
blusas = Convert.ToInt32(Console.ReadLine());

novelo = blusas * 7;

Console.WriteLine($"Você precisará de {novelo} novelos de lã para fazer {blusas} blusas.");