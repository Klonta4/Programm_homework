
int m;
int n;

Console.WriteLine("Введите количество столбцов.");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк.");
n = int.Parse(Console.ReadLine());
Random rnd = new Random();
int[,] Arr = new int[n, m];

for(int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        Arr[i,j] =(int)rnd.Next(0, 10);
        Console.Write(Arr[i,j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int h = 0; h < m; h++)
		for (int j = 0; j < m - 1; j++)
        {
			if (Arr[i, j] < Arr[i, j + 1])
			{
	    		int t = Arr[i, j];
				Arr[i, j] = Arr[i, j + 1];
				Arr[i, j + 1] = t;
			}
        }
}
Console.WriteLine();
Console.WriteLine();
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        Console.Write(Arr[i,j] + "\t");
    }
    Console.WriteLine();
}