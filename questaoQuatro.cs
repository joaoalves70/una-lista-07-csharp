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
