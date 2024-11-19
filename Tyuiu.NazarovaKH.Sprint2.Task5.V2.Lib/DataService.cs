﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NazarovaKH.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            string res;
            switch (value)
            {
                case 3:
                    res = "Март";
                    break;
                case 4:
                    res = "Апрель";
                    break;
                case 5:
                    res = "Май";
                    break;
                case 6:
                    res = "Июнь";
                    break;
                case 7:
                    res = "Июль";
                    break;
                case 8:
                    res = "Август";
                    break;
                case 9:
                    res = "Сентябрь";
                    break;
                case 10:
                    res = "Октябрь";
                    break;
                case 11:
                    res = "Ноябрь";
                    break;
                case 12:
                    res = "Декабрь";
                    break;
                case 1:
                    res = "Январь";
                    break;
                case 2:
                    res = "Февраль";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12{value}");
            }
            return res;
        }
    }
}