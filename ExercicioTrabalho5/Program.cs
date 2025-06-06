int preçoLitro, valorLitro, litros, valorPago;

Console.WriteLine("Digite o preço da gasolina");
preçoLitro = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor que deseja abastecer");
valorPago = Convert.ToInt32(Console.ReadLine());

litros = valorPago / preçoLitro;

Console.WriteLine("Você conseguiu colocar " + litros + "litros no tanque");