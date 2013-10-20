using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDZCommon
{
    public class Util
    {
        /// <summary>
        /// Designed by eaglet
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns>
        public static int[] GetRandomSequence2(int begin, int end)
        {
            int total = end - begin;

            int[] sequence = new int[end];
            int[] output = new int[end];
            int[] ro = new int[total];

            for (int i = begin; i < end; i++)
            {
                sequence[i] = i;
            }

            Random random = new Random();

            end = end - 1;
            total = end;
            for (int i = begin; i <= total; i++)
            {
                int num = random.Next(begin, end + 1);
                output[i] = sequence[num];
                sequence[num] = sequence[end];
                end--;
            }
            Array.Copy(output, begin, ro, 0, total);
            return ro;
        }
    }
}
