using System;

class Program
{
    static void Main(string[] args)
    {
        InsertionSort insertionSort = new InsertionSort();
    
        int[] vetor1 = new int[10];
        Random rand = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = rand.Next(0, 10);
        }
        
        // unsorted
        foreach(var value in vetor1) {
            Console.Write($"[{value}]");
        }

        insertionSort.sort(vetor1);
        Console.WriteLine("\n--------");
        
        // sorted
        foreach(var value in vetor1) {
            Console.Write($"[{value}]");
        }
    }
}
