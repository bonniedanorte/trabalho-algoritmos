int nota1, nota2, nota3, mediaponderada;

Console.WriteLine("Digite a primeira nota (peso 1)");
nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a segunda nota (peso 2)");
nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a terceira nota (peso 3)");
nota3 = Convert.ToInt32(Console.ReadLine());
mediaponderada = nota1 * 1 + nota2 * 2 + nota3 * 3 / (1 + 2 + 3);

Console.WriteLine("A média do aluno é: " + mediaponderada);