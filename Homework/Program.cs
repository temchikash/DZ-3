using System;

namespace Homework
{
    enum Cards
    {
        Шестерка = 6,
        Семерка,
        Восьмерка,
        Девятка,
        Десятка,
        Валет,
        Дама,
        Король,
        Туз
    }
    enum Days
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 не смог\nЗадание 2\nВведите номер карты от 6 до 14\n");
            try
            {
                if (!byte.TryParse(Console.ReadLine(), out byte inputNumber) || (inputNumber < 6 || inputNumber > 14))
                {
                    throw new ArgumentException("Номер карты должен быть от 6 до 14\n");
                }
                else
                {
                    Console.WriteLine((Cards)inputNumber);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Задание 3\nКто вы?");

            switch (Console.ReadLine().ToLower())
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila\n");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol\n");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer\n");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine\n");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars\n");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal\n");
                    break;
                default:
                    Console.WriteLine("Beer\n");
                    break;
            }

            Console.WriteLine("Задание 4.\nВведите номер дня недели от 1 до 7.");
            try
            {
                if (int.TryParse(Console.ReadLine(), out int Day) || Day < 1 || Day > 7)
                {
                    throw new ArgumentException("Неправильный номер\n");
                }
                else
                {
                    Console.WriteLine($"День недели соответствующий номеру {Day} это {(Days)Day}\n");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Задание 5");
            string[] dollsNames = { "Hello Kitty", "Doll", "Doll", "Hello Kitty", "Doll", "Barbie doll", "Barbie doll", "Doll" };
            int c = 0;
            foreach (string el in dollsNames)
            {
                if (el == "Barbie doll" || el == "Hello Kitty")
                {
                    c++;
                }
            }
            Console.WriteLine($"В сумке лежит {c} кукол.");



            Console.ReadKey();
        }
    }
}