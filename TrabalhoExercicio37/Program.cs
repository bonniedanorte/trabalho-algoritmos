decimal num1;
Console.Write("Digite um número para saber a tabuada até o 10: ");
num1 = Convert.ToDecimal(Console.ReadLine());
for (int i = 0; i <= 10; i++)

{
    decimal resultado = num1 * i;
    Console.WriteLine($"{num1} x {i} = " + resultado);
}