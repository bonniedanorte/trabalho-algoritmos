decimal ano, mes, dia, semanas;

Console.Write("Digite o ano que você nasceu: ");
ano = Convert.ToInt32(Console.ReadLine());

ano = 2025 - ano;
mes = ano * 12;
semanas = ano * 52;
dia = ano * 365;

Console.WriteLine($"Sua idade em anos é de: {ano}, em meses: {mes}, em semanas: {semanas} e em dias: {dia}.");