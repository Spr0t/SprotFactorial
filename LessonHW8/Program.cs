using System;

namespace LessonHW8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число для вычисления факториала: ");
            int n = int.Parse(Console.ReadLine());
            long factorial = 1;

            for (int j = 1; j <= n; j++)
            {
                factorial *= j;
            }

            Console.WriteLine($"Факториал равен: {factorial}");
            Console.ReadLine();

        }
    }
}
