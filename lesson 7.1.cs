internal class lesson7_1
{
    private static void Main(string[] args)
    {
        int m;
        int n;


        Console.WriteLine("Введите количество столбцов.");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество строк.");
        n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int sum = 0;
        int avg;

        int[,] Arr = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Arr[i, j] = (int)rnd.NextInt64();
                Console.WriteLine(Arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}