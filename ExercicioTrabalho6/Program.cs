decimal kg, pagamento = 12;

Console.WriteLine("Quantos kg, deu o prato do cliente");
kg = Convert.ToDecimal(Console.ReadLine());
pagamento = pagamento * kg;

Console.WriteLine($"O cliente deve pagar {pagamento} reais, com o prato pesando{kg}");