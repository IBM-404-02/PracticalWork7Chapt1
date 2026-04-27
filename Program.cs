using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_FirstApp
{
    /// <summary>
    /// Главный класс программы для пошагового вывода букв имени.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Выполняет основную работу программы: посимвольно выводит буквы имени с задержкой.
        /// </summary>
        private static void doWork()
        {
            string name = "Mads";
            string letters = string.Empty;

            Console.WriteLine("Hello, " + name);

            for (int i = 0; i < name.Length; i++)
            {
                letters += name[i];
                Console.WriteLine(letters);
                System.Threading.Thread.Sleep(200);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Точка входа в приложение.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            doWork();
        }
    }
}
