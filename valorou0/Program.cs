int somaValores = 0, valor = -1;

while(valor != 0)
{
    Console.WriteLine("Digie um valor ou 0 para sair");
    valor = Convert.ToInt32(valor);

    somaValores += valor;
}
Console.WriteLine("A soma dos valores é: " + somaValores);