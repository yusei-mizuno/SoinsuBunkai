using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample401
{
    class Program
    {
        static void Main(string[] args)
        {
            int  count, amari, i;
            amari = 0;
            i = 1;
            Console.Write("整数を入力：");
    ;        int suji = int.Parse(Console.ReadLine());
            while ( suji > 1) 
            {
                count = 0;
                amari = 0;
                i++;
                while (amari == 0 ) 
                {
                    amari = suji % i;
                    if (amari == 0) 
                    {
                        count++;
                        suji = suji / i;
                    }
                }
                if (count >= 1 && suji == 1) 
                {
                    Console.Write(i + "^" + count);
                }
                else if (count >= 1)
                {
                    Console.Write(i + "^" + count + "×");
                }
            }
            Console.WriteLine("です");


        }
    }
}
