int n1, n2, n3, menor, meio, maior;
Console.WriteLine("digite o primeiro numero :");
n1= int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
n2= int.Parse(Console.ReadLine());
Console.WriteLine("digite o terceiro numero:");
n3= int.Parse(Console.ReadLine());

if (n1 <= n2)
{
    if (n1 <= n3)
    {
        menor = n1;

        if (n2 <= n3)
        {
            meio = n2;
            maior = n3;
        }
        else
        {
            meio = n3;
            maior = n2;
        }
    }
}

if (n2 < n1)
{
    if (n2 <= n3)
    {
        menor = n2;

        if (n1 <= n3)
        {
            meio = n1;
            maior = n3;
        }
        else
        {
            meio = n3;
            maior = n1;
        }
    }
}

if (n3 < n1)
{
    if (n3 < n2)
    {
        menor = n3;

        if (n1 <= n2)
        {
            meio = n1;
            maior = n2;
        }
        else
        {
            meio = n2;
            maior = n1;
        }
    }
}

Console.Write("Ordem crescente: " + n1+ ", " + n2 + ", " + n3);
