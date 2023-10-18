# una-lista-07-csharp

# 2 - Explique o que é uma lista e uma pilha em estrutura de dados. Escreva em C# exemplos de uma lista e uma pilha.

Uma estrutura de dados de lista é usada para armazenar elementos e segue o princípio first-in-first-out, ou seja, o primeiro elemento a ser inserido na lista é o primeiro a ser removido. 

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

Agora, em relação à estrutura de dados de pilha, ela funciona de forma semelhante a uma lista, mas segue o princípio last-in-first out, o que significa que o último elemento inserido é o primeiro a ser removido. 

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


