using System.Formats.Asn1;

string larguraTerreno, comprimentoTerreno;
decimal largura, comprimento;

Console.WriteLine("Digite a largura do terreno (em metros):");
larguraTerreno = Console.ReadLine();
largura = Convert.ToDecimal(larguraTerreno);

Console.WriteLine("Digite o comprimento do terreno (em emtros):");
comprimentoTerreno = Console.ReadLine();
comprimento = Convert.ToDecimal(comprimentoTerreno);


comprimento = largura * comprimento;

Console.WriteLine("A área do terreno é: " + comprimento + " metros quadrados.");

