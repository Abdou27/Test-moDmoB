using System;
using System.Collections.Generic;

namespace MoDMoBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = Q1();
            Console.WriteLine("S\t= " + S);
            
            List<int> L = Q2(S);
            printList("L", L);

            List<int> LPrime = Q3(L);
            printList("L'", LPrime);

            int SPrime = Q4(LPrime);
            Console.WriteLine("S'\t= " + SPrime);
        }

        static int Q1()
        {
            int sum = 0;
            for (int i = 3; i <= 90000; i += 3)
            {
                sum += i;
            }
            return sum;
        }

        static List<int> Q2(int S)
        {
            List<int> L = new List<int>();
            int source = S;
            while(source > 0)
            {
                var digit = source % 10;
                L.Add(digit);
                source /= 10;
            }
            L.Reverse();
            return L;
        }

        static List<int> Q3(List<int> L)
        {
            List<int> LPrime = new List<int>();
            foreach (var digit in L)
            {
                if(!LPrime.Contains(digit))
                {
                    LPrime.Add(digit);
                }
            }
            return LPrime;
        }

        static int Q4(List<int> L)
        {
            int sum = 0;
            foreach (var digit in L)
            {
                sum += digit;
            }
            return sum;
        }

        static void printList(string Title, List<int> L)
        {
            Console.Write(Title  + "\t= [");
            for (int i = 0; i < L.Count; i++)
            {
                Console.Write(L[i]);
                if (i < (L.Count - 1))
                {
                    Console.Write(", ");
                }

            }
            Console.Write("]\n");
        }
    }
}
