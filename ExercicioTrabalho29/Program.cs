int produto;

Console.Write("Digite o preço do produto: ");
produto = Convert.ToInt32(Console.ReadLine());

decimal desconto = 0.1m * produto;

Console.WriteLine($"O produto com desconto é de: {desconto} reais");