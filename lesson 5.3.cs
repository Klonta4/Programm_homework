int m;
int min = 99;
int max = 0;
int diff;
Random rnd = new Random();

Console.WriteLine("Введите размер массива");
m = int.Parse(Console.ReadLine());
int[] Arr = new int[m];
for (int i = 0; i < m; i++)
{
	Arr[i] = rnd.Next(0, 99);
	Console.WriteLine(Arr[i]);
    if (max < Arr[i]) max = Arr[i];
    if (min > Arr[i]) min = Arr[i];
}
diff = max - min;
Console.WriteLine("разница чисел минимального и максимального в массиве равно " + diff);
