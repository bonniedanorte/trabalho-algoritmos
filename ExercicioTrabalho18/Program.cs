decimal hrs, HrExtra = 15, i, HrNormal = 10;

Console.Write("Digite as horas trabalhadas: ");
hrs = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite as horas extras: ");
i = Convert.ToDecimal(Console.ReadLine());

decimal salarioBruto = (hrs * HrNormal) + (HrExtra * i);
decimal salarioLiquido = salarioBruto - (salarioBruto * 0.1m);

Console.WriteLine($"O salário bruto é: {salarioBruto} reais, o liquido é de {salarioLiquido} reais");