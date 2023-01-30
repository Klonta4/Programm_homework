Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"функция Акераманна для чисел A({M},{N}) : " + AccermanFunc(M, N));

int AccermanFunc(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AccermanFunc(M - 1, 1);
    if (M > 0 && N > 0) return AccermanFunc(M - 1, AccermanFunc(M, N- 1));
    return AccermanFunc(M,N);
}