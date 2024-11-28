using Tyuiu.NazarovaKH.Sprint2.Task6.V12.Lib;

namespace Tyuiu.NazarovaKH.Sprint2.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int g, m, n;

            Console.WriteLine("Введите год G:");
            g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц M:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день N:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            var s = ds.FindDateOfPreviousDay(g, m, n);
            Console.WriteLine("Вчера было " + s);

            Console.ReadKey();
        }
    }
}
