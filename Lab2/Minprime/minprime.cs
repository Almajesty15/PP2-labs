﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lab2_2
{
    class Program
    {
        static int primetest(int a)
        {
            int n = 0;
            for (int i = 1; i <= a; ++i)
            {
                if (a % i == 0)
                {
                    n++;
                }
            }
            return n;
        }
        static void Main(string[] args)
        {
            string line = File.ReadAllText(@"C:\Users\user\user\minprime.txt");
            string[] line2 = line.Split(' ');
            int minprime = 1335555555;
            foreach (string s in line2)
            {
                int k = int.Parse(s);
                if ((primetest(k) == 2) && (minprime > k))
                {
                    minprime = k;
                }
            }
            Console.WriteLine(minprime);
            Console.ReadKey();
        }
    }
}