using Tyuiu.ParamonovaVA.Sprint3.Task0.V14.Lib;

namespace Tyuiu.ParamonovaVA.Sprint3.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startvalue = 1;
            int stopvalue = 5;
            double value = 2;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("k = 1, k <= 5, n = 2");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSeries(value, startvalue, stopvalue);

            Console.WriteLine("Результат: " + res);
            Console.ReadKey();
        }
    }
}
