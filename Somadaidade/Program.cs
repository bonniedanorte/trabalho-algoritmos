string continuar = "S";
int somaidade = 0, idade = 0, idademaior = 0, idadequantidade = 0, mediaidade = 0;

while (continuar.ToUpper() == "S")
{
    Console.WriteLine("Digite a idade");
    idade = Convert.ToInt32(Console.ReadLine());

    somaidade += idade;
    idadequantidade++;

    if (idade >= 21)
    {
        idademaior++;
    }
    Console.WriteLine("Sseja continuar? (S/N)");
    continuar = Console.ReadLine();

}
mediaidade = (somaidade / idadequantidade);

Console.WriteLine("Foi digitada o total de " + idadequantidade + " idades");
Console.WriteLine("A media da idade é de " + mediaidade + " anos");
Console.WriteLine(idademaior + " pessoas tem ou são mais velha que 21 anos");