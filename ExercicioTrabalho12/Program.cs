decimal salario;

Console.WriteLine("Digite o valor do seu salário para aumentarmos em 15% e depois descontar em 8%");
salario = Convert.ToDecimal(Console.ReadLine());

decimal aumento, desconto;
aumento = (salario * 0.15m) + salario;
desconto = aumento - (aumento * 0.08m);

Console.WriteLine($"O seu salário com aumento de 15% é de {aumento} reais, e com os descontos dos impostos é de {desconto:F2} reais");