using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                        КАЛЬКУЛЯТОР");
            for (int i = 0; ; i++)
            {
                int answer = 0;
                Console.Write(" Введите первое целое число: ");
                int a1;
                try
                {
                    a1 = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                Console.Write(" Введите второе целое число: ");
                int a2;
                try
                {
                    a2 = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                #region Выбор операции
                Console.WriteLine();
                Console.WriteLine("Выберите необходимую оперцаию: ");
                Console.WriteLine("                       1 для сложения");
                Console.WriteLine("                       2 для вычетания");
                Console.WriteLine("                       3 для умножения");
                Console.WriteLine("                       4 для деления");
                Console.Write("Номер операции:  ");
                #endregion
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    answer = Math.Abs(a1 + a2);
                    Console.WriteLine("Результат: {0}", answer);
                }
                else if (choice == 2)
                {
                    answer = a1 - a2;
                    Console.WriteLine("Результат: {0}", answer);
                }
                else if (choice == 3)
                {
                    answer = a1 * a2;
                    Console.WriteLine("Результат: {0}", answer);
                }
                else if (choice == 4)
                {
                    try
                    {
                        answer = a1 / a2;
                        Console.WriteLine("Результат: {0}", answer);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    Console.WriteLine("                                ОШИБКА! Выберите другую операцию!");
                Console.WriteLine("                                      Нажмите Enter для продолжения: ");
                Console.ReadKey();

            }
        }
    }
}
