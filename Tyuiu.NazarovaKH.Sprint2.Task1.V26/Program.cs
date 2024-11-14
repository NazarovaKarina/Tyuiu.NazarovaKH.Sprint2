using Tyuiu.NazarovaKH.Sprint2.Task1.V26.Lib;

namespace Tyuiu.NazarovaKH.Sprint2.Task1.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 654;
            int b = 671;
            int c = 874;
            int d = 137;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
