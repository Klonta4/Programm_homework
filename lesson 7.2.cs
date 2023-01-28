
internal class lesson72
{
    private static void Main(string[] args)
    {
        int m;
        int n;
        int str;
        int stl;
        Random rnd = new Random();
        m = rnd.Next(1, 7);
        n = rnd.Next(1, 7);
        int[,] Arr = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Arr[i, j] = (int)rnd.NextInt64();
                Console.WriteLine(Arr[i, j]);

            }
        }

        Console.WriteLine("Какой элемент вы хотите найти? напишите слитно индекс.");
        int index = int.Parse(Console.ReadLine());
        stl = index / 10;
        str = index % 10;

        if (stl < m)
        {
            if (str < n)
            {
                Console.WriteLine("Элемент c индексом " + stl + " " + str + " это: " + Arr[stl,str]);
            }
            else
            {
                Console.WriteLine("Элемент не найден");
            }
        }
        else
            {
                Console.WriteLine("Элемент не найден");
            }
    }
}