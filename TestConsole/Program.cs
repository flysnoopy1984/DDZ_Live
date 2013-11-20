using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestConsole
{
  
    class Program
    {
        static ManualResetEvent _mr;

        static Thread t1;
       

        static Thread t2;

        static void Main(string[] args)
        {
            _mr = new ManualResetEvent(false);
            t1 = new Thread(new ThreadStart(dothing1));
            t1.Start();

            t2 = new Thread(new ThreadStart(dothing2));
            t2.Start();

            Console.Read();

            t1 = new Thread(new ThreadStart(dothing1));
            t1.Start();

            t2 = new Thread(new ThreadStart(dothing2));
            t2.Start();

            Console.Read();

        }
        static void dothing2()
        {
            _mr.WaitOne();
            Console.WriteLine("T2");
        }

        static void dothing1()
        {
            Console.WriteLine("T1");
            _mr.Set();

        }

        

       
        

        /// <summary>
        /// Designed by eaglet
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns>
        public static int[] GetRandomSequence2(int begin,int end)
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

            end = end-1 ;
            total = end;
            for (int i = begin; i <= total; i++)
            {
                int num = random.Next(begin, end+1 );
                output[i] = sequence[num];
                sequence[num] = sequence[end];
                end--;
            }
            Array.Copy(output, 10,ro, 0,10);
            return ro;
        }

        public static void Order()
        {
            /*
            for (int i = 1; i < list.Count; i++)
            {
                j = i - 1;
                while (j >= 0)
                {
                    if (list[i].Poker.Size < list[j].Poker.Size)
                    {
                        temp = list[j].Poker;
                        list[j].ChangePoker(list[i].Poker);
                        list[i].ChangePoker(temp);
                    }
                    j--;
                }

            }
             */
        }
    }
}
