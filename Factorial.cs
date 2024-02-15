using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAPP_Assessment2
{
    public class Factorial
    {
        static void Main(string[] args)
         {
                int fact = 1;
                for (int i = 1; i < 10; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine("Factorial of 10 is:" + fact);

            }


        }
    }

