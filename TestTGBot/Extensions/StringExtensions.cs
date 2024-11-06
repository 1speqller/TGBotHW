using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTGBot.Extensions
{
    /// <summary>
    /// Класс для расширенных методов строк
    /// </summary>
    public class StringExtensions
    {
        public static int SummaryNumberInString(string str)
        {
            int sumNum = 0;
            string[] numArray = str.Split(' ');
            for (int i = 0; i < numArray.Length; i++)
            {
                sumNum += int.Parse(numArray[i]);
            }

            return sumNum;
        }
    }
}
