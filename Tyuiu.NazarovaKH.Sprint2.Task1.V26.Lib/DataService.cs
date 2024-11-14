using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarovaKH.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a + 18 > b) | (c < d);
            res[1] = (a + 18 > b) & (c - 738 < d);
            res[2] = (a + 18 > b) || (c < d);
            res[3] = (a > b) && (c < d);
            res[4] = !(!res[0]);
            res[5] = (a > b) ^ (c < d);

            return res;
        }
    }
}
