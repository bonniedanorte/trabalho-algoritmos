decimal celsius;

Console.Write("Digite a tempeatura em Celsius: ");
celsius = Convert.ToDecimal(Console.ReadLine());

decimal fahrenheit = celsius * 1.8m + 32;
Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}°F");