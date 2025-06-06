int galinhas;
decimal iden = 4.00m, alimen = 7.00m;

Console.Write("Digite a quantidade de galinhas que tem na granja ");
galinhas = Convert.ToInt32(Console.ReadLine());

iden = iden * galinhas;
alimen = alimen * galinhas;
decimal total = iden + alimen;

Console.WriteLine($"O gasto total da granja é de {total} reais);