string[] senha = new string[6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite a vogal da sua senha da posição" + (i + 1));
    senha[i] = Console.ReadLine().ToUpper();
    while (senha[i] != "A" && senha[i] != "E" && senha[i] != "I" && senha[i] != "O" && senha[i] != "U")
    {
        Console.WriteLine("Digie a vogal da sua senha da posição" + (i + 1));
        senha[i] = Console.ReadLine().ToUpper();
    }
}

for (int cripto = 0; cripto < 6; cripto++)
{
    if (senha[cripto] == "A")
    {
        senha[cripto] = "z";
    }
    if (senha[cripto] == "E")
    {
        senha[cripto] = "3";
    }
    if (senha[cripto] =="I")
    {
        senha[cripto] = "j";
    }
    if (senha[cripto] =="O")
    {
        senha[cripto] = "9";
    }
    if (senha[cripto] =="U")
    {
        senha[cripto] = "$";
    }
}

