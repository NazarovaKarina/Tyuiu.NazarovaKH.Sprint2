﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarovaKH.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3 && x <= 4 && y >= 4 && y <= 5 && y >= 8 && y <= 10)||(x >= 5 && x <= 6 && y >= 7 && y <= 10)||(x >= 6 && x <= 8 && y >= 3 && y <= 4)||(x == 11 && y >= 3 && y <= 6)||(x == 13 && y >= 3 && y <= 5)||(x >= 10 && x <= 13 && y >= 10 && y <= 13)||(x >= 8 && x <= 9 && y >= 12 && y <= 13)||(x == 3 && y >= 12 && y <= 13)||(x == 7 && y >= 7 && y <= 8)||(x == 7 && y == 10)||(x == 13 && y == 9))
            {
                res = false;
            }
            else
            {
                res = true;
            }

            return res;
        }
    }
}