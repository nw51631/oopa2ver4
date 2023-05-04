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
            bool runAgain = true;
            while (runAgain)
            {
                Console.WriteLine("Would you like to run the program again? (y/n)");
                string input = Console.ReadLine();
                runAgain = (input.ToLower() == "y" || input.ToLower() == "yes");
            }
        }
        {
            int num = array.Length;
            for (int var1 = 0; var1 < num - 1; var1++)
            {
                for (int var2 = var1 + 1; var2 < num; var2++)
                {
                    if (array[i].Value > array[j].Value)
                    {
                        Card temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
