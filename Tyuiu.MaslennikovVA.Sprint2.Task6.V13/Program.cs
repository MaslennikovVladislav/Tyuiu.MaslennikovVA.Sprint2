using System;
using Tyuiu.MaslennikovVA.Sprint2.Task6.V13.Lib;

namespace Tyuiu.MaslennikovVA.Sprint2.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Масленников В. А. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Масленников Владислав Александрович |  ИИПб-24-2              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g (год),*");
            Console.WriteLine("* m (порядковый номер месяца) и n (число). По заданным g, n и m           *");
            Console.WriteLine("* определить дату следующего дня. Заданный год является високосным.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите високосный год: ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindDateOfNextDay(g, m, n);
            Console.WriteLine("Ответ: " + res);
            Console.ReadKey();
        }
    }
}