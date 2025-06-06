int salario;
decimal comissao, salarioFinal;

Console.Write("Digite o salário do trabalhador: ");
salario = Convert.ToInt32(Console.ReadLine());

comissao = salario * 0.04m;
salarioFinal = salario + comissao;

Console.WriteLine($"O valor da comissão é de: {comissao} reais, e o salário final do trabalhador é: {salarioFinal}");