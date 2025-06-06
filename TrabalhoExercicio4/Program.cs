using System.Security.Authentication;

string nome;
int idade, diasdevida;

Console.WriteLine("Digite o seu nome");
nome = Console.ReadLine();

Console.WriteLine("Digite seus anos de idade");
idade = Convert.ToInt32(Console.ReadLine());

diasdevida = idade * 365;

Console.WriteLine("Voce ja viveu " + diasdevida + "Dias de vida");