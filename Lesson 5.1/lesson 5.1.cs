int m;
int count = 0;
int del;
Random rnd = new Random();

Console.WriteLine("Введите размер массива");
m = int.Parse(Console.ReadLine());
int[] Arr = new int[m];
for(int i = 0; i < m; i++ )
{
    Arr[i] = rnd.Next(100, 350);
    Console.WriteLine(Arr[i]);
    del = Arr[i] % 2;
    if (del == 0) count += 1;
}
Console.WriteLine("Количество четных чисел в массиве равно " + count);

