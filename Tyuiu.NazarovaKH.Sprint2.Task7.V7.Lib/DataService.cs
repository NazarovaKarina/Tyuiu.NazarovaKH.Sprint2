using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarovaKH.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y <= x) && (y <= 2 - x * x) && (x >= 0))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
