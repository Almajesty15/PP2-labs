using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace maximum_and_mimimum
{
    public class Class1
    {
        static void Main(string[] args)
        {

            string line2 = File.ReadAllText(@"C:\Users\User\A.txt");



            string[] line = line2.Split(' ');

            int maxx = -10000000;
            int minn = 10000000;
            foreach (string s in line)
            {
                maxx = Math.Max(maxx, int.Parse(s));
                minn = Math.Min(minn, int.Parse(s));

            }
            StreamWriter sw = new StreamWriter(@"C:\Users\User\A");
            sw.WriteLine("Maximum number is " + maxx);
            sw.WriteLine("Minimum number is " + minn);
            sw.Close();


            Console.ReadKey();

        }
    }
}