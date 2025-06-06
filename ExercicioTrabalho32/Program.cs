int kg;

Console.Write("Digite o peso em quilogramas: ");
kg = Convert.ToInt32(Console.ReadLine());

decimal gramas = kg * 1000m;

Console.WriteLine($"O peso em gramas é: {gramas} gramas");