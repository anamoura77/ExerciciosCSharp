Console.Write("Digite o nome do candidato: ");

string nome;
nome= Console.ReadLine();
float portugues, matematica, gerais, media, aprovado, reprovado;

Console.Write("Digite a nota de Português: ");
portugues = float.Parse(Console.ReadLine());

Console.Write("Digite a nota de Matemática: ");
matematica = float.Parse(Console.ReadLine());

Console.Write("Digite a nota de Conhecimentos Gerais: ");
gerais = float.Parse(Console.ReadLine());

media = portugues + matematica + gerais / 3;


Console.WriteLine(nome + " " + "aprovado"); 

if (media > 7.0)
{
    if (portugues >= 5.0)
    {
        if (matematica >= 5.0)
        {
            if (gerais >= 5.0)
            {
                
            }
        }
    }
}

// Saída
Console.WriteLine("\n--- Resultado ---");
Console.WriteLine("Nome: " + nome);
Console.WriteLine("Português: " + portugues);
Console.WriteLine("Matemática: " + matematica);
Console.WriteLine("Conhecimentos Gerais: " + gerais);
Console.WriteLine("Média: " + media);



   
