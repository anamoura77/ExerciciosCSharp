int N;

Console.Write("Digite N: ");
N = int.Parse(Console.ReadLine());

if (N <= 10)
{
    Console.WriteLine("F1");
}
else if (N <= 100)
{
    Console.WriteLine("F2");
}
else
{
    Console.WriteLine("F3");
}
