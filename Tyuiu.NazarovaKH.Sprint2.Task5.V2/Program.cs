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
            int numMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if ((numMonth == 3) || (numMonth == 4) || (numMonth == 5)) 
            {
                Console.WriteLine("Время года данного месяца: весна");
            }
            if ((numMonth == 6) || (numMonth == 7) || (numMonth == 8)) 
            {
                Console.WriteLine("Время года данного месяца: лето");
            }
            if ((numMonth == 9) || (numMonth == 10) || (numMonth == 11))
                        {
                Console.WriteLine("Время года данного месяца: осень");
            }
            if ((numMonth == 12) || (numMonth == 1) || (numMonth == 2))
            {
                Console.WriteLine("Время года данного месяца: зима");
            }
            if ((numMonth > 12 ) || (numMonth < 1))
            {
                Console.WriteLine("Введено неверное значение");
            }

            Console.ReadKey();
        }
    }
}
