using System;

namespace Exercize_2_Console
{
    internal class Program
    {
        static int NonExceptionInput (string s)
        {
            while (true) 
            {
                try
                {
                    Console.Write($"Введите число {s}: ");
                    int num = int.Parse(Console.ReadLine());
                    if (s == "N" && num == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя!");
                        continue;
                    }
                    return num;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод! Доступен ввод только цифр и знака \"минус\"\n");
                }
            }
        }
        static void Main(string[] args)
        {
            int m = NonExceptionInput("M");
            int n = NonExceptionInput("N");
                
            if (m % n == 0)
                Console.WriteLine($"Частное от деления числа {m} на числа {n}: {m / n}");
            else
                Console.WriteLine($"M на N нацело не делится");

        }
    }
}
