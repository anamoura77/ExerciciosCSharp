int anos, meses, dias, totalDias;

Console.WriteLine("Digite os anos:");
anos = int.Parse(Console.ReadLine());

Console.WriteLine("Digite os meses:");
meses = int.Parse(Console.ReadLine());

Console.WriteLine("Digite os dias:");
dias = int.Parse(Console.ReadLine());

totalDias = anos * 365 + meses * 30 + dias;

Console.Write("Idade informada: " + anos + "anos," + meses + " meses e, " + dias);
Console.Write("Você já viveu aproximadamente:" + totalDias + " dias.");
