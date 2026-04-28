
string nome1, nome2, nome3;
float venda1, venda2, venda3, totalvendas;
double comissao1, comissao2, comissao3;

Console.WriteLine("Nome1:");
nome1 = Console.ReadLine();
Console.WriteLine("Valor de vendas do corretor 1:");
venda1 = float.Parse(Console.ReadLine());

Console.WriteLine("Nome2:");
nome2 = Console.ReadLine();
Console.WriteLine("Valor de vendas do corretor 2:");
venda2 = float.Parse(Console.ReadLine());

Console.WriteLine("Nome3:");
nome3 = Console.ReadLine();
Console.WriteLine("Valor de vendas do corretor 3:");
venda3 = float.Parse(Console.ReadLine());

totalvendas = venda1 + venda2 + venda3;

if (venda1 > 50000)
{
    comissao1 = venda1 * 0.12;
}
else if (venda1 >= 30000)
{
    comissao1 = venda1 * 0.095;
}
else
{
    comissao1 = venda1 * 0.07;
}


if (venda2 > 50000)
{
    comissao2 = venda2 * 0.12;
}
else if (venda2 >= 30000)
{
    comissao2 = venda2 * 0.095;
}
else
{
    comissao2 = venda2 * 0.07;
}


if (venda3 > 50000)
{
    comissao3 = venda3 * 0.12;
}
else if (venda3 >= 30000)
{
    comissao3 = venda3 * 0.095;
}
else
{
    comissao3 = venda3 * 0.07;
}


Console.WriteLine("\nRelatório de Vendas\n");

Console.WriteLine("Nome: " + nome1 + " | Venda: R$ " + venda1 + " | Comissão: R$ " + comissao1);
Console.WriteLine("Nome: " + nome2 + " | Venda: R$ " + venda2 + " | Comissão: R$ " + comissao2);
Console.WriteLine("Nome: " + nome3 + " | Venda: R$ " + venda3 + " | Comissão: R$ " + comissao3);

Console.WriteLine("\nTotal de vendas: R$ " + totalvendas);