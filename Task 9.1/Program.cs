using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите операцию:");
                Console.WriteLine("1:+");
                Console.WriteLine("2:-");
                Console.WriteLine("3:*");
                Console.WriteLine("4:/");
                int sign = Convert.ToInt32(Console.ReadLine());
                if (sign==1)
                {
                    Console.WriteLine("Ответ: {0}", a + b);
                }
                else if (sign == 2)
                {
                    Console.WriteLine("Ответ: {0}", a - b);
                }
                else if (sign == 3)
                {
                    Console.WriteLine("Ответ: {0}", a * b);
                }
                else if (sign == 4 && a == 0 && b == 0)
                {
                    Console.WriteLine("Деление 0 на 0");
                }
                else if (sign == 4 && b == 0)
                {
                    Console.WriteLine("Деление на 0");
                }
                else if (sign == 4)
                {
                    try
                    {
                        Console.WriteLine("Ответ: {0}", a / b);
                    }
                    catch (DivideByZeroException) when (b == 0)
                    {

                        Console.WriteLine("Деление на 0");

                    }

                }
                else
                {
                    Console.WriteLine("Неверная операция");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
