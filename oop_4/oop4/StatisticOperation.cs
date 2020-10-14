using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    public static class StatisticOperation
    {
        public static int Sum(LinkedList A)
        {

            int sum = 0;
            for(LinkedList.Node pA = A.Head; pA!= null; pA = pA.next)
            {
                sum += pA.data;
            }
            return sum;

        }

        public static int CountDiffMinMax(LinkedList A)
        {
            int max = A.Head.data;
            int min = A.Head.data;

            for (LinkedList.Node pA = A.Head; pA != null; pA = pA.next) 
            {
                if (pA.data > max)
                {
                    max = pA.data;
                }
                if(pA.data < min)
                {
                    min = pA.data;
                }

            }
            return (max - min);
        }

        public static int CountQuantity(LinkedList A)
        {
            return A.Count;
        }

        public static string CutStr(this string str, int len)
        {
            str.Substring(len);
            return str;
        }

        public static int ListSum(this LinkedList list)
        {
            int sum = 0;
            
            for (LinkedList.Node p = list.Head; p != null; p = p.next)
            {
                sum += p.data;
            }

            return sum;
        }
    }
}
