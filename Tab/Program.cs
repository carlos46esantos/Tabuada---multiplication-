using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Tab
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tabuada você gostaria de vê");
            int tab = Convert.ToInt16(Console.ReadLine());
            {
                for (int c = 1; c <= 10; c++ )
                {
                    Console.WriteLine(tab + "x" + c + "=" + tab * c);
                }
            }

            Console.Read();
        }
    }
}
