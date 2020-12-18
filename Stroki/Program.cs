using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroki
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "He is good!";

            s1 = s1.Remove(0, 2);

            Console.WriteLine(s1);

            Console.ReadLine();
        }
    }
}
