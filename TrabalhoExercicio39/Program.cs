decimal c1 = 200.0m, c2 = 120.0m, sjoao = 1200.0m;

c1 = c1 * 0.02m + c1;
c2 = c2 * 0.02m + c2;
sjoao = sjoao - (c1 + c2);

Console.WriteLine($"Restára {sjoao:F1} reais do salário de João após pagar as contas com multas de 2% ");