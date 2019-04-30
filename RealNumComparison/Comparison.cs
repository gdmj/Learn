using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Compares correctly two real numbers with accuracy at least 0.000001
namespace RealNumComparison
{
    class Comparison
    {
        static void Main(string[] args)
        {
            double num1 = 6.12844135, num2 = 6.12844123;
            bool equal = Math.Abs(num1 - num2) < 0.000001;
            Console.WriteLine(equal);
            Console.ReadLine();
        }
    }
}
