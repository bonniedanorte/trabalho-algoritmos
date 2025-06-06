int dia, mes, diaspassados;
Console.WriteLine("Digite o dia");
dia = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Digite o mês: ");
mes = Convert.ToInt32(Console.ReadLine());


diaspassados = (mes - 1) * 30 + dia;

Console.WriteLine("Já se passaram " + diaspassados + "dias passados");