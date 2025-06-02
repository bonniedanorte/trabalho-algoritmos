int QuantidadeCavalos, ferradurasPorCavalo = 4, totalFerraduras;

Console.WriteLine("Digite a quantidade de cavalos comprados: ");
string entrada = Console.ReadLine();

QuantidadeCavalos = Convert.ToInt32(entrada);
totalFerraduras = QuantidadeCavalos * ferradurasPorCavalo;

Console.WriteLine("São necessarios ferraduas " + totalFerraduras  + " para equipar todos os cavalor ");