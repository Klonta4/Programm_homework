
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        bool one = false;
        bool two = false;
        Console.WriteLine("Какую подпрограмму выполнить? Напишите цифру.");
        Console.WriteLine("1. Поиск чисел больше нуля.");
        Console.WriteLine("2. Точка пересечения двух отрезков.");
        int input = int.Parse(Console.ReadLine());
        if (input == 1) 
        {
            one = FindCountNumbersLargerThenNull();
        }
        else
        {
            two = PointBreak();
        }
        if(one == true) 
        {
            two = PointBreak();

        }
        else
        {
            one = FindCountNumbersLargerThenNull();
        }

    }
    static int ratio()
    { 
        Console.WriteLine("Введите коэффициент");
        return(int.Parse(Console.ReadLine()));
    }
    static Boolean PointBreak()
    {
        int k1 = ratio();
        int k2 = ratio();
        int b1 = ratio();
        int b2 = ratio();

        int x = (b1 + b2) / (k1 + k2);
        int y = k1 * x + b1;

        Console.WriteLine("точка соприкосновения 2 линий будет в координатах " +"( " + x + ";" + y + ")");
        return true;
    }
    static Boolean FindCountNumbersLargerThenNull()
    {

        int index = 0;
        int number;
        Console.WriteLine("введите количество чисел");
        int numbers = int.Parse(Console.ReadLine());
        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine(value: "Ведите число:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                index++;
            }
        }
        Console.WriteLine("вы ввели " + index + " чисел больше нуля");
        return true;

    }
}