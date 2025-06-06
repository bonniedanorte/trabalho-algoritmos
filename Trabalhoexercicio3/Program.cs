int QuantidadePães, QuantidadeBroas, TotalPães, TotalBroas;
decimal Tpães, Tbroas, ValorJuntado, Valorguardado;

Console.WriteLine("Digite a quantidade de pães vendidos: ");
QuantidadePães = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de broas vendidas: ");
QuantidadeBroas = Convert.ToInt32(Console.ReadLine());

Tpães = QuantidadePães * 0.12m;

Tbroas = QuantidadeBroas * 1.50m;

ValorJuntado = Tpães + Tbroas;

Valorguardado = ValorJuntado / 10 * 0.1m;

Console.WriteLine("O total arrecadado : " + ValorJuntado);
Console.WriteLine("O valor a ser guardado na poupança (10%): R$ " + Valorguardado);