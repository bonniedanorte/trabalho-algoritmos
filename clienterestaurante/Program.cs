decimal[] conta = new decimal[10];

for (int i = 0; i < 10;  i++)
{
    Console.WriteLine("Digite o valor da conta" + (i + 1));
    conta[i] = Convert.ToDecimal(Console.ReadLine());
}

Console.WriteLine("Hoje o seu almoço é um cortesia da casa, parabéns");