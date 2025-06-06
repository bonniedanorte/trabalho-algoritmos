decimal sminino, sfuncionario;

Console.Write("Digite o valor do salário mínimo: ");
sminino = Convert.ToDecimal(Console.ReadLine());
Console.Write("Digite o valor do salário do funcionário: ");
sfuncionario = Convert.ToDecimal(Console.ReadLine());

decimal qntdSalarios = sfuncionario / sminino;

Console.WriteLine($"Esse funcionário ganha {qntdSalarios:F0} salários mínimos.");