using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Geometry Guru Menu ");
        Console.WriteLine("1. Qo'shish (+)");
        Console.WriteLine("2. Ayirish (-)");
        Console.WriteLine("3. Ko'paytirish (*)");
        Console.WriteLine("4. Bo'lish (/)");
        Console.WriteLine("5. Eng kattasini topish (Max)");
        Console.WriteLine("6. Faktorial hisoblash (!)");
        Console.WriteLine("7. 1 dan N gacha yig'indi");

        Console.Write("\nAmalni tanlang (1-7): ");
        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch (userChoice)
        {
            case 1: AddNumbers(); break;
            case 2: SubtractNumbers(); break;
            case 3: MultiplyNumbers(); break;
            case 4: DivideNumbers(); break;
            case 5: ShowMax(); break;
            case 6: ShowFactorial(); break;
            case 7: ShowSumToN(); break;
            default:
                Console.WriteLine("Noto'g'ri tanlov!");
                break;
        }
    }

    static void AddNumbers()
    {
        Console.Write("Birinchi sonni kiriting: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ikkinchi sonni kiriting: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Natija: " + (firstNumber + secondNumber));
    }

    static void SubtractNumbers()
    {
        Console.Write("Birinchi sonni kiriting: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ikkinchi sonni kiriting: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Natija: " + (firstNumber - secondNumber));
    }

    static void MultiplyNumbers()
    {
        Console.Write("Birinchi sonni kiriting: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ikkinchi sonni kiriting: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Natija: " + (firstNumber * secondNumber));
    }

    static void DivideNumbers()
    {
        Console.Write("Bo'linuvchini kiriting: ");
        double dividend = Convert.ToDouble(Console.ReadLine());
        Console.Write("Bo'luvchini kiriting: ");
        double divisor = Convert.ToDouble(Console.ReadLine());

        if (divisor == 0)
            Console.WriteLine("0 ga bo'lish mumkin emas!");
        else
            Console.WriteLine("Natija: " + (dividend / divisor));
    }

    static void ShowMax()
    {
        Console.Write("Birinchi son: "); int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ikkinchi son: "); int num2 = int.Parse(Console.ReadLine());
        Console.Write("Uchinchi son: "); int num3 = int.Parse(Console.ReadLine());
        
        int resultMax = GetMax(num1, num2, num3);
        Console.WriteLine("Eng kattasi: " + resultMax);
    }

    static int GetMax(int val1, int val2, int val3)
    {
        int currentMax = val1;
        if (val2 > currentMax) currentMax = val2;
        if (val3 > currentMax) currentMax = val3;
        return currentMax;
    }

    static void ShowFactorial()
    {
        Console.Write("Faktorial uchun son kiriting: ");
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"{inputNumber}! = " + Factorial(inputNumber));
    }

    static long Factorial(int target)
    {
        long calculationResult = 1;
        for (int i = 1; i <= target; i++) calculationResult *= i;
        return calculationResult;
    }

    static void ShowSumToN()
    {
        Console.Write("Chegarani kiriting (n): ");
        int limit = int.Parse(Console.ReadLine());
        Console.WriteLine($"1 dan {limit} gacha yig'indi: " + SumToN(limit));
    }

    static int SumToN(int endPoint)
    {
        int totalSum = 0;
        for (int i = 1; i <= endPoint; i++) totalSum += i;
        return totalSum;
    }
}