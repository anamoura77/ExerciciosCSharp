

int n1, n2, n3, media;

Console.Write("Nota 1: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Nota 2: ");
n2 = int.Parse(Console.ReadLine());

Console.Write("Nota 3: ");
n3 = int.Parse(Console.ReadLine());

media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

if (media >= 7)
{
    Console.Write("Situação: Aprovado");
}
else if (media >= 5)
{
    Console.Write("Situação: Recuperação");
}
else
{
    Console.Write("Situação: Reprovado");
}