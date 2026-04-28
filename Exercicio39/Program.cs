
int valorCompra, valorPago, troco, restante, nota100, nota10, nota1;

Console.WriteLine("Digite o valor da compra:");
valorCompra = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor pago:");
valorPago = int.Parse(Console.ReadLine());


troco = valorPago - valorCompra;


nota100 = 0;
nota10 = 0;
nota1 = 0;

restante = troco;


if (restante >= 100)
{
    nota100 = restante / 100;
    restante = restante % 100;
}

if (restante >= 10)
{
    nota10 = restante / 10;
    restante = restante % 10;
}


if (restante >= 1)
{
    nota1 = restante;
}

Console.WriteLine("Valor da compra: R$ " + valorCompra);
Console.WriteLine("Valor pago: R$ " + valorPago);
Console.WriteLine("Troco: R$ " + troco);

Console.WriteLine("Notas de 100: " + nota100);
Console.WriteLine("Notas de 10: " + nota10);
Console.WriteLine("Notas de 1: " + nota1);
