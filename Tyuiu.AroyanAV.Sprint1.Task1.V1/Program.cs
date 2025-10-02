﻿using Tyuiu.AroyanAV.Sprint1.Task1.V1.Lib;

namespace Tyuiu.AroyanAV.Sprint1.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Ароян А. В. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Ароян Армине Вачагановна | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле x/3/y+6*a и печатает его на экране.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a, x, y;

            Console.Write("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(a, x, y));

            Console.ReadLine();
        }
    }
}