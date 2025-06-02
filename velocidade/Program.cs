string continua = "s";
int velocidade, quantidadeMultas = 0;

while (continua.ToUpper() == "S")
{
    Console.WriteLine("Digite a velocidade do carro");
    velocidade = Convert.ToInt32(Console.ReadLine());

    if(velocidade > 120)
    {
        quantidadeMultas++;
    }

    Console.WriteLine("Deseja continuar ? (s/n)");
    continua = Console.ReadLine();
}
Console.WriteLine("A quantidade de mulas é: " + quantidadeMultas);