string nome;
float nota1, nota2, total;
Console.WriteLine("Digite o seu nome:");
nome = Console.ReadLine();
Console.WriteLine("Digite a nota1");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota2");
nota2 = float.Parse(Console.ReadLine());
total= nota1+nota2;
if (total >= 60)
{
    Console.WriteLine("Aluno:" + nome + "- Aprovado");
}
else
{
    Console.WriteLine("Aluno:" + nome + "- Aprovado");
}
