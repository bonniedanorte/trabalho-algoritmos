decimal valorFelipe, valorConta, valorCarlos, valorAndre;
int valorBase;

Console.WriteLine("Digite o valor da conta: ");
valorConta = decimal.Parse.(Console.ReadLine());

valorBase = (int)valorConta; / 3;
valorCarlos = (int)valorBase;
valorAndre = (int)valorBase;
// (int) é usado para converter o valor decimal para inteiro,descartando a parte fracionária.
valorFelipe = valorConta - valorCarlos + valorAndre;

Console.WriteLine($"Valor que Felipe deve pagar: {valorFelipe:C}");
Console.WriteLine($"Valor que Carlos deve pagar: {valorCarlos:C}");
Console.WriteLine($"Valor que Andre deve pagar: {valorAndre:C}");

// O comando :C formata o valor como moeda, usando a cultura do sistema.
