using System.Drawing;
using System.Globalization;

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
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        Arr[i,j] =(int)rnd.NextInt64();
        Console.WriteLine(Arr[i,j] + "\t");
    }
    Console.WriteLine();
}

for(int i = 0; i < m; i++)
{
    int index = i + 1;
    for(int j = 0; j < n; j++)
    {
        sum += + Arr[i, j];
    }
    avg = sum / n;
    Console.WriteLine("Среднее арифметическое " +(index + 1) + " столбца: " + avg);
}