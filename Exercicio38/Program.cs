int a, b, c, soma;

Console.WriteLine("Digite o valor de A:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B:");
b = int.Parse(Console.ReadLine()); 
Console.WriteLine("Digite o valor de C:");
c = int.Parse(Console.ReadLine());
 soma = a + b;

Console.Write("A = " + a);
Console.Write("B = " + b);
Console.Write("C = " + c);

if (soma > c)
{
    Console.WriteLine("A soma de A + B é MAIOR que C");
}
else if (soma < c)
{
    Console.WriteLine("A soma de A + B é MENOR que C");
}
else
{
    Console.WriteLine("A soma de A + B é IGUAL a C");
}