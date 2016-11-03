using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            string iFormI = i.ToString();
            int iFormS = Convert.ToInt32("100");
            int iFormS1 = Int32.Parse("101");
            int iForms2;
            bool succeed = Int32.TryParse("jikexueyuan", out iForms2);
            Console.WriteLine(iForms2);
            Console.ReadLine();
            Console.WriteLine("你是傻逼么");
        }
    }
}
