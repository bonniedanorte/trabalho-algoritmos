int contador = 0, diasNascidos  = 0;

while (contador <10)
{
    Console.WriteLine("Quantos dias o bebé nasceu?");
    diasNascidos += Convert.ToInt32(Console.ReadLine());

    contador++;
}

Console.WriteLine("A média dos dias dos nascimentos é: " + (diasNascidos / 10));