using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadPractice
{
    public class MagicNumbers
    {
        public int[] Numbers { get; set; }

        public static bool operator >(MagicNumbers first, MagicNumbers second)
        {
            int sumFirst = 0;
            for (int i = 0; i < first.Numbers.Length; i++)
            {
                sumFirst += first.Numbers[i];
            }
            int sumSecond = 0;
            for (int i = 0; i < second.Numbers.Length; i++)
            {
                sumSecond += second.Numbers[i];
            }
            return sumFirst > sumSecond;
        }
        public static bool operator <(MagicNumbers first, MagicNumbers second)
        {
            int sumFirst = 0;
            for (int i = 0; i < first.Numbers.Length; i++)
            {
                sumFirst += first.Numbers[i];
            }
            int sumSecond = 0;
            for (int i = 0; i < second.Numbers.Length; i++)
            {
                sumSecond += second.Numbers[i];
            }
            return sumFirst < sumSecond;
        }
    }
}
