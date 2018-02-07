using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2MinPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Vector = new List<int>();
            string text = File.ReadAllText(@"C:\Users\User\A.txt");
            string[] a = text.Split();
            int[] n = new int[a.Count()];
            string lmao;
            for (int i = 0; i < a.Length; i++)
            {
                n[i] = int.Parse(a[i]);
                bool Love = true;
                for (int j = 2; j * j <= n[i]; j++)
                {
                    if (n[i] % j == 0)
                    {
                        Love = false;
                        break;
                    }
                }
                if (Love & n[i] != 1)
                {
                    Vector.Add(n[i]);
                }
            }
            Vector.Sort();
            if (Vector.Count == 0)
            {
                File.WriteAllText(@"C:\Users\User\B.txt", "There are no primes");
            }
            for (int i = 0; i < Vector.Count; i++)
            {
                if (Vector.Count > 0)
                {
                    File.WriteAllText(@"C:\Users\User\B.txt", Convert.ToString(Vector[i]));
                }
                break;
            }
        }
    }
}