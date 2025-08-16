using System.Diagnostics;
namespace MergeSort;
public class Execucao
{
    public static void Executar(int qtd)
    {

        Stopwatch stopwatch = new Stopwatch();
        Random rnd = new();
        int[] vetor = new int[qtd];
        for (int i = 0; i < qtd; i++)
        {
            vetor[i] = rnd.Next(0, 100);
        }
        Console.WriteLine($"Execução com {qtd} valores");
        Console.WriteLine($"Antes: {string.Join(", ", vetor.Take(15))}...");
        stopwatch.Start();
        Algoritmo.Order(vetor);
        stopwatch.Stop();
        Console.WriteLine($"Depois: {string.Join(", ", vetor.Take(15))}...");
        Console.WriteLine($"Tempo discorrido: {stopwatch.Elapsed}");
        Console.WriteLine("\n\n");
        stopwatch.Reset();
    }
}
