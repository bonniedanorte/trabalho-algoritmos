

decimal Paes = 0.12m, broas = 1.50m, totalPães, totalBroas, valorTotal, porcentagem;
int QuantidadePães, QuantidadeBroas;


Console.WriteLine("Digite a quantidade de pães vendidos:");
QuantidadePães = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de broas vendidas:");
QuantidadeBroas = Convert.ToInt32(Console.ReadLine());

totalPães = QuantidadePães * Paes;
totalBroas = QuantidadeBroas * broas;

valorTotal = totalPães + totalBroas;
porcentagem = valorTotal / 10 * 0.1m;

Console.WriteLine( "O valor total arrecadado: R$" + valorTotal );
Console.WriteLine("O valor a ser guardado na poupança seria de: R$ " + porcentagem);
