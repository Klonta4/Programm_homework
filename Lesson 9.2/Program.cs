
Console.WriteLine("Введите Первое число (большое)");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Второе число (Меньше прошлого)");
int M = int.Parse(Console.ReadLine());

void RecFunc(int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine(sum);
        return;
    }
    sum = sum + (M++);
    RecFunc(M, N, sum);
}

Console.Write("Сумма чисел от " + M + " до " + N + " равна: ");
RecFunc(M, N, 0);
