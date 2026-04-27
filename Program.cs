using System;

namespace DebuggingIntro
{
    /// <summary>
    /// Главный класс программы для отладки последовательности Фибоначчи.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в приложение. Вычисляет и выводит число Фибоначчи.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            int result = Fibonacci(5);
            Console.WriteLine(result);
        }

        /// <summary>
        /// Вычисляет n-ое число последовательности Фибоначчи.
        /// </summary>
        /// <param name="n">Порядковый номер числа в последовательности.</param>
        /// <returns>Значение n-ого числа Фибоначчи.</returns>
        static int Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i < n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            return n == 0 ? n1 : n2;
        }
    }
}
