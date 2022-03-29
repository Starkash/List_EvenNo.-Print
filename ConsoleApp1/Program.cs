using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lis = new List<int>();
            lis.Add(29);
            lis.Add(30);
            lis.Add(26);
            lis.Add(10);
            foreach(var x in lis)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);

                }
            }

        }
    }
}
