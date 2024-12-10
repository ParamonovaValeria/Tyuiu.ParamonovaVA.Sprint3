
using Tyuiu.ParamonovaVA.Sprint3.Task5.V2.Lib;
namespace Tyuiu.ParamonovaVA.Sprint3.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5;
            int s1 = 1;
            int e1 = 3;
            int s2 = 1;
            int e2 = 12;

            Console.Title = "Спринт #3 | Выполнила: Парамонова В.А. | РППб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Парамонова Валерия Алексеевна | РППб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
            Console.WriteLine("* из ряда по формуле                                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Начальная точка первого цикла = " + s1);
            Console.WriteLine("Начальная точка второго цикла = " + s2);
            Console.WriteLine("Конечная точка первого цикла = " + e1);
            Console.WriteLine("Конечная точка второго цикла = " + e2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма равна : " + ds.GetSumSumSeries(x, s1, s2, e1, e2));
            Console.ReadKey();
        }
    }
}
