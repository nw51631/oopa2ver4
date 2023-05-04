using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        public static void CardSort(int[] array)
        {
            int num = array.Length;
            for (int var1 = 0; var1 < num - 1; var1++)
            {
                for (int var2 = var1 + 1; var2 < num; var2++)
                {
                    if (array[var1] > array[var2])
                    {
                        int temp = array[var1];
                        array[var1] = array[var2];
                        array[var2] = temp;
                    }
                }
            }
        }
    }
}
