

float salarioMinimo, carrosVendidos, valorVendas;
float salarioFixo, comissaoCarros, comissaoVendas, salarioTotal;

Console.WriteLine("Digite o valor do salário mínimo:");
salarioMinimo = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de carros vendidos:");
carrosVendidos = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor total das vendas:");
valorVendas = float.Parse(Console.ReadLine());

salarioFixo = salarioMinimo * 2;

comissaoCarros = carrosVendidos * 50;

comissaoVendas = valorVendas * 0.05f;

salarioTotal = salarioFixo + comissaoCarros + comissaoVendas;
Console.WriteLine("Salário mínimo: R$ " + salarioMinimo);
Console.WriteLine("Carros vendidos: " + carrosVendidos);
Console.WriteLine("Valor total de vendas: R$ " + valorVendas);

Console.WriteLine("Salário fixo (2 mínimos): R$ " + salarioFixo);
Console.WriteLine("Comissão por carros: R$ " + comissaoCarros);
Console.WriteLine("Comissão sobre vendas: R$ " + comissaoVendas);
Console.WriteLine("Salário total: R$ " + salarioTotal);
