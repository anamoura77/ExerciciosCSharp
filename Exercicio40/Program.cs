string cliente;

Console.WriteLine("Digite o nome do cliente:");
cliente = Console.ReadLine();

Console.WriteLine("Quantidade de parafusos:");
float qtdParafusos = float.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de porcas:");
float qtdPorcas = float.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de arruelas:");
float qtdArruelas = float.Parse(Console.ReadLine());

Console.WriteLine("Preço unitário do parafuso:");
float precoParafuso = float.Parse(Console.ReadLine());

Console.WriteLine("Preço unitário da porca:");
float precoPorca = float.Parse(Console.ReadLine());

Console.WriteLine("Preço unitário da arruela:");
float precoArruela = float.Parse(Console.ReadLine());

float totalParafuso = qtdParafusos * precoParafuso;
float totalPorca = qtdPorcas * precoPorca;
float totalArruela = qtdArruelas * precoArruela;

float totalBruto = totalParafuso + totalPorca + totalArruela;

float descontoParafuso = totalParafuso * 0.20f;
float descontoPorca = totalPorca * 0.10f;
float descontoArruela = totalArruela * 0.30f;

float totalDesconto = descontoParafuso + descontoPorca + descontoArruela;

float totalPagar = totalBruto - totalDesconto;

Console.WriteLine();
Console.WriteLine("Cliente: " + cliente);
Console.WriteLine();

Console.WriteLine("Parafusos: " + qtdParafusos + " | Total: R$ " + totalParafuso);
Console.WriteLine("Porcas: " + qtdPorcas + " | Total: R$ " + totalPorca);
Console.WriteLine("Arruelas: " + qtdArruelas + " | Total: R$ " + totalArruela);

Console.WriteLine();
Console.WriteLine("Total de desconto: R$ " + totalDesconto);
Console.WriteLine("Total a pagar: R$ " + totalPagar);