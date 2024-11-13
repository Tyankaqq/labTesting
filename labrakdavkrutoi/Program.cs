class Program
{
    static void Main(string[] args)
    {
        
        Random rand = new Random();
        int arraySize = 10; 
        int[] numbers = new int[arraySize];

        
        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = rand.Next(1, 101); 
        }

        
        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);

        
        Array.Sort(numbers, (x, y) => y.CompareTo(x)); 

       
        Console.WriteLine("\nОтсортированный массив по убыванию:");
        PrintArray(numbers);
    }

    
    static void PrintArray(int[] array)
    {
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}