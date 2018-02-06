using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace complex
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string c = s.Split(' ')[0];
            string d = s.Split(' ')[1];
            int a_ = int.Parse(c.Split('/')[0]);
            int b_ = int.Parse(c.Split('/')[1]);
            int c_ = int.Parse(d.Split('/')[0]);
            int d_ = int.Parse(d.Split('/')[1]);
            complex a = new complex(a_, b_);
            complex b = new complex(c_, d_);
            complex sum = a + b;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}