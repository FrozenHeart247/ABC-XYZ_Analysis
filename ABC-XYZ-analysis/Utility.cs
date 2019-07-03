using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_XYZ_analysis
{
    /***
     * Абстрактный класс с утилитами
     * вроде нигде не используется
    ***/
    public abstract class Utility
    {
        /* Метод проверяет является ли строка числом */
        public static bool IsNum(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c)) return false;
            }
            return true;
        }
    }
}
