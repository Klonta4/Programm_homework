

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
Console.Write("все натуральные числа от " + N + " до 1:");
RecFunc(N);

int RecFunc(int N)
{
    if (N == 0) return 1;
    Console.Write(N + ", ");
    return RecFunc(N - 1);
}

