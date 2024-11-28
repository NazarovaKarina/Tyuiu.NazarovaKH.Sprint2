using Tyuiu.NazarovaKH.Sprint2.Task5.V2.Lib;

namespace Tyuiu.NazarovaKH.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int MonthSeason = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((MonthSeason < 1) || (MonthSeason > 12))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "Это сезон: " + ds.FindMonthSeason(MonthSeason);

            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
