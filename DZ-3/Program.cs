using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная\n");

            try
            {
                int year_days, day;
                int year = 2023;

                Console.Write("Введите количество дней в году: ");
                year_days = int.Parse(Console.ReadLine());
                Console.Write($"Введите номер дня (от 1 до {year_days}): ");
                day = int.Parse(Console.ReadLine());

                if ((year_days != 366) && (year_days != 365))
                {
                    throw new Exception($"В году не может быть {year_days} дней!");
                }

                if ((day < 1) || (day > year_days))
                {
                    throw new Exception($"Вы ввели число меньше 1 или больше {year_days}");
                }

                if (year_days % 5 != 0)
                {
                    year += 1;
                }

                DateTime dateTime = new DateTime(year, 1, 1).AddDays(day - 1);

                switch (dateTime.Month)
                {
                    case 01:
                        Console.WriteLine($"{dateTime.Day} Января");
                        break;
                    case 02:
                        Console.WriteLine($"{dateTime.Day} Февраля");
                        break;
                    case 03:
                        Console.WriteLine($"{dateTime.Day} Марта");
                        break;
                    case 04:
                        Console.WriteLine($"{dateTime.Day} Апреля");
                        break;
                    case 05:
                        Console.WriteLine($"{dateTime.Day} Мая");
                        break;
                    case 06:
                        Console.WriteLine($"{dateTime.Day} Июня");
                        break;
                    case 07:
                        Console.WriteLine($"{dateTime.Day} Июля");
                        break;
                    case 08:
                        Console.WriteLine($"{dateTime.Day} Августа");
                        break;
                    case 09:
                        Console.WriteLine($"{dateTime.Day} Сентября");
                        break;
                    case 10:
                        Console.WriteLine($"{dateTime.Day} Октября");
                        break;
                    case 11:
                        Console.WriteLine($"{dateTime.Day} Ноября");
                        break;
                    case 12:
                        Console.WriteLine($"{dateTime.Day} Декабря");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не целое число");
            }
            catch (Exception dateException)
            {
                Console.WriteLine(dateException.Message);
            }

            Console.ReadKey();
        }
    }
}
