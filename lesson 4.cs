

internal class Lesson4
{

    private static void Main (string[] args)
    {
        bool one = false;
        bool two = false;
        bool free = false;
        int answer;

        Console.WriteLine("Какую программу вы хотите запустить?");
        Console.WriteLine("1. возведение в степень");
        Console.WriteLine("2. Сумма цифр числа");
        Console.WriteLine("3. Выведение массива чисел на экран");
        answer = int.Parse(Console.ReadLine());
        if (answer == 1)
        {
            one = NaturalDegree();
        }
        else
        {
            if(answer == 2)
            {
                two = SumNumbers();
            }
            else
            {
                free = ArrayOnKeyboard();
            }
        }

        if (one == true)
        {
            if (two == true)
            {
                free = ArrayOnKeyboard();
            }
            else
            {
                two = SumNumbers();
                free = ArrayOnKeyboard();
            }
        }
        else
        {
            if (two == true)
            {
                if (free == true)
                {
                    one = NaturalDegree();
                }
                else
                {
                    free = ArrayOnKeyboard();
                    one = NaturalDegree();
                }
            }
            else
            {
                if (free == true)
                {
                    if (one == true)
                    {
                        two = SumNumbers();
                    }
                    else
                    {
                        one = NaturalDegree();
                        two = SumNumbers();
                    }

                }

            }
        }


    }

    private static bool NaturalDegree ()
    {
        Console.WriteLine("Хотите возвести ваше число в вашу степень? Y/N");
        string answer = Console.ReadLine();
        if (answer == "Y")
        {
            Console.WriteLine("");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int b = int.Parse(Console.ReadLine());
            double c = Math.Pow(a, b);
            Console.WriteLine("число " + a + " возведенное в степень " + b +" дает: " + c);
        }
        return true;
    }
    private static bool SumNumbers ()
    {
        Console.WriteLine ("Введите число");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        int ost = 0;

        sum += number / 100;
        ost = number % 100;
        sum += ost / 10;
        sum += ost % 10;

        Console.WriteLine("Сумма цифр числа: " + sum);

        return true;
    }
    private static bool ArrayOnKeyboard ()
    {
        Console.WriteLine ("Введите размер Массива");
        int size = int.Parse(Console.ReadLine());
        int[] Arr = new int[size];
        int index = 1;
        int i = 0;
        string a;

        Console.WriteLine("введите " + index + " элемент массива");

        while ((a = Console.ReadLine()) != "end")
        {
            if (i == size) break;
            index = i + 2;
            Console.WriteLine ("введите " + index + " элемент массива");
            Arr[i++] = int.Parse(a);
        }

        Console.Write("Ваш Массив: ");

        foreach (int k in Arr)
        {
            Console.Write (k + ", ");
        }
        Console.WriteLine("");

        return true;

    }



}