using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            System.Console.WriteLine("n va m ra vared konid");
            n = Convert.ToInt32(System.Console.ReadLine());
            m = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("adad aval az n ta m:");
            for (int i = n; i<= m; i++)
            {
                int a = 0;
                for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("adad Ayneie az n ta m:");
            for (int i = n; i <= m; i++)
            {
                string k = i.ToString();
                string rk = "";
                for (int j = k.Length - 1; j >= 0; j--)
                {
                    rk += k[j];
                }
                if (i.ToString() == rk)
                {
                    System.Console.WriteLine(i);     
                }
            }

                System.Console.ReadKey();
        }
    }
}
