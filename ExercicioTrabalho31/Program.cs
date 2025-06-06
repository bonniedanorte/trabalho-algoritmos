int peso;
decimal engordar, emagrecer;

Console.Write("Digite o seu peso: ");
peso = Convert.ToInt32(Console.ReadLine());

engordar = peso * 0.15m + peso;
emagrecer = peso - 0.20m * peso;

Console.WriteLine($"Se engordar 15%, o novo peso será: {engordar} kg");
Console.WriteLine($"Se emagrecer 20%, o novo peso será: {emagrecer} kg");