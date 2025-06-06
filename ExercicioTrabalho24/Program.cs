decimal refrescos, agua = 0.8m, suco = 0.2m;

Console.Write("Digite quantos litros de refrescos você deseja: ");
refrescos = Convert.ToInt32(Console.ReadLine());

decimal tonel = (agua * refrescos) + (suco * refrescos);
decimal lA = agua * refrescos;
decimal lS = suco * refrescos;

Console.WriteLine($"São necessário {lA} litros de água, {lS} litros de suco, para fazer {tonel} litros de refresco");