Stack<string> cargos = new Stack<string>();

cargos.Push("Estagiário");
cargos.Push("Assistente");
cargos.Push("Analista");
cargos.Push("Gerente");
cargos.Push("Diretor");

Console.WriteLine("Hierarquia de Cargos:");

foreach (var cargo in cargos)
{
    Console.WriteLine(cargo);
}

string cargoRemovido = cargos.Pop();
Console.WriteLine("Cargo removido: " + cargoRemovido);

Console.WriteLine("Nova hierarquia de Cargos:");

foreach (var cargo in cargos)
{
    Console.WriteLine(cargo);
}

Console.ReadLine();
