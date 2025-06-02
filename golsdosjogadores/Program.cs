int[] GolsJogador = new int[3];
string[] NomeJogador = new string[3];
int MaisGols = 0;
string NomeArtilheiro = "";

for (int i = 0; i <3; i++)
{
    Console.WriteLine("Digite o nome do jogador: ");
    NomeJogador[i] = Console.ReadLine();
    Console.WriteLine("Digite quantos gols o jogador " + (i + 1) + " fez na temporada");
    GolsJogador[i] = Convert.ToInt32(Console.ReadLine());
    if (GolsJogador[i] > MaisGols)
    {
        MaisGols = GolsJogador[i];
        NomeArtilheiro = NomeJogador[i];
    }
}

Console.WriteLine(" O artilheiro do time foi " + NomeArtilheiro + "com o toal de " + MaisGols + "gols na temporada");