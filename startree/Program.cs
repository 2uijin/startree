using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int k = 7;
            for (int i = 1; i <=8; i++) {

                for (int j = k; j >= 0; j--) {
                    Console.Write(" ");
                }//공백

                for (int n = 1; n <= i+m; n++) {
                    Console.Write("*");
                }

                Console.WriteLine();
                m++;
                k--;
            }
        }//main
    }
}
