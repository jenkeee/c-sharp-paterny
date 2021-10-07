using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Methods
    {
        public static int Factorial(int num) // 0 мы сюда не получим поэтому не буду обрабатывать 0
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = num * i;
            }
            return factorial;
        }

        public static int SummaFromNum(int num)
        {
            int summaToNum = 0;
            for (int i = 1; i <= num; i++)
            {
                summaToNum += i;
            }

            return summaToNum;
        }
        public static int SmalleThenNum(int num)
        {
            int smallerNum = num;
            for (int i = 1; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    smallerNum = i;
                }
            }
            return smallerNum;
        }
    }
}
