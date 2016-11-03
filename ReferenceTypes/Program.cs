using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = new object();
            object o2 = new Object();
            Console.WriteLine(o.GetType());
            Console.WriteLine(o.ToString());
            int i = 5;
            Console.WriteLine(i.ToString());
            string s = "lokiiart";
            string s1 = "loki";
            s1 += "iart";
            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(s == s1);
            Console.WriteLine((object)s == (object)s1);
            char c = s[2];
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
