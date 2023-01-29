int m;
int sum = 0;
int del;
Random rnd = new Random();

Console.WriteLine("Введите размер массива");
m = int.Parse(Console.ReadLine());
int[] Arr = new int[m];
for (int i = 0; i < m; i++)
{
	Arr[i] = rnd.Next(0, 99);
	Console.WriteLine(Arr[i]);
	if (i % 2 != 0) sum += Arr[i];
}
Console.WriteLine("Сумма чисел стоящих на нечетных позициях в массиве равно " + sum);
