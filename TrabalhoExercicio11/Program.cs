int dias;

Console.Write("Digite a quantidade de dias: ");
dias = Convert.ToInt32(Console.ReadLine());
int dps = dias % 360;
int anos = dias / 360;
int meses = dps / 30;
dias = dps % 30;

Console.Write($"Você já está na empresa há {anos} anos, {meses} meses e {dias} dias ");