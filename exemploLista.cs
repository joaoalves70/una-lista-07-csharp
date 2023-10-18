var cargos = new List<string> { "Estagiário", "Aprendiz" };

foreach (var cargo in cargos)
{
    Console.WriteLine("Olá, " + cargo);
}

cargos.Add("Gerente");
Console.WriteLine("Nova Lista");

foreach (var cargo in cargos)
{
    Console.WriteLine("Olá, " + cargo);
}

Console.ReadLine();
