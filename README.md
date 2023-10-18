# una-lista-07-csharp

# 2 - Explique o que é uma lista e uma pilha em estrutura de dados. Escreva em C# exemplos de uma lista e uma pilha.

Uma estrutura de dados de lista é usada para armazenar elementos e segue o princípio first-in-first-out, ou seja, o primeiro elemento a ser inserido na lista é o primeiro a ser removido. 
```
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
```
Agora, em relação à estrutura de dados de pilha, ela funciona de forma semelhante a uma lista, mas segue o princípio last-in-first out, o que significa que o último elemento inserido é o primeiro a ser removido. 
```
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
```

# 3 - Escreva um algoritmo em C# que implemente a lógica de ordenação por inserção do Insertion Sort. Segue modelo de vetor para ser ordenado:  int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

```
int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

Console.WriteLine("Vetor original:");
ImprimirVetor(vetor);

OrdenarPorInsercao(vetor);

Console.WriteLine("Vetor ordenado:");
ImprimirVetor(vetor);

static void OrdenarPorInsercao(int[] arr)
{
    int n = arr.Length;

    for (int i = 1; i < n; i++)
    {
        int valorAtual = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > valorAtual)
        {
            arr[j + 1] = arr[j];
            j--;
        }

        arr[j + 1] = valorAtual;
    }
}

static void ImprimirVetor(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();
```

# 4 - Escreva um algoritmo em C# que implemente a lógica de ordenação por inserção do Shell Sort. Segue modelo de vetor para ser ordenado: int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

```
int[] vetor = { 1, 100, 30, 50, 11, 13, 5, 7, 78 };

Console.WriteLine("Vetor original:");
ImprimirVetor(vetor);

ShellSort(vetor);

Console.WriteLine("Vetor ordenado:");
ImprimirVetor(vetor);

static void ShellSort(int[] arr)
{
    int n = arr.Length;
    int h = 1;

    while (h < n / 3)
    {
        h = 3 * h + 1;
    }

    while (h >= 1)
    {
        for (int i = h; i < n; i++)
        {
            int chave = arr[i];
            int j = i;

            while (j >= h && arr[j - h] > chave)
            {
                arr[j] = arr[j - h];
                j -= h;
            }

            arr[j] = chave;
        }

        h /= 3;
    }
}

static void ImprimirVetor(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();
```




