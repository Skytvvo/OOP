using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 4; 
            LinkedList sss = new LinkedList(size);
            sss.AddBack(1);
            sss.AddBack(2);
            sss.AddBack(3);

            LinkedList bbb = new LinkedList(size);
            bbb.AddBack(1);
            bbb.AddBack(2);
            bbb.AddBack(3);


            Console.WriteLine(StatisticOperation.CutStr("abcd", 2));
            Console.WriteLine(StatisticOperation.ListSum(sss));

            Console.WriteLine(sss == bbb);
            bbb = bbb + sss;
            Console.WriteLine(StatisticOperation.ListSum(bbb));
            bbb = bbb < sss;
            Console.WriteLine(StatisticOperation.ListSum(bbb));
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                bbb[i] = random.Next(1,20);
            }

            LinkedList.Owner MEIZU = new LinkedList.Owner(27781, "Chine", "Meizu Inc.");
            LinkedList.Date NOW = new LinkedList.Date(DateTime.Now);

        }
    }
}
