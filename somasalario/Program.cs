decimal[] salarios = new decimal[11];
int[] numeroCamisa = new int[11];
decimal totalSalarios = 0;

for (int i = 0; i < 11; i++)
{
    Console.WriteLine("Digite o salario do jogador " + (i + 1));
    salarios[i] = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite o número da camisa do jogador" 
        + (i + 1));
    numeroCamisa[i] = Convert.ToInt32(Console.ReadLine());

    totalSalarios += salarios[i];
}

decimal mediaSalarios = totalSalarios / 11;

for (int i = 0; i < 11; i++)
{
    if (mediaSalarios < salarios[i])
    {
        Console.WriteLine("O jogador " + (i + 1) +
                 "com o numero da camisa " + numeroCamisa[i] +
                 "com um salario acima da media");
    }

}
