using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AgafonovKS.Sprint2.Task6.V1.Lib;

namespace Tyuiu.AgafonovKS.Sprint2.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Агафонов К. С. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Агафонов Кирилл Сергеевич | ИИПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая использует сокращенную форму записи оператора*");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат.             *");
            Console.WriteLine("*По данному номеру месяца, определите количество дней в этом месяце.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int numMouth = int.Parse(Console.ReadLine());

            string res;

            if ((numMouth < 1) || (numMouth > 12))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Дней в этом месяце: " + ds.FindMonthDaysCount(numMouth);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
           
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
