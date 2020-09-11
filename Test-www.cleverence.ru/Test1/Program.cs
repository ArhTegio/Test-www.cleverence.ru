using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Test_www.cleverence.ru
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.For(1, 10, x =>
            {
                Server.AddToCount(x);
                var list = new List<int>();

                for (int i = 0; i < 10; ++i)
                {
                    list.Add(Server.GetCount().Result);
                }
            });

            Console.ReadLine();
        }
    }
}
