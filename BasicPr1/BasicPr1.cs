using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{

    class HelloCSharp
    {
        
        static void Main(string[] args)
        {
            int numSeq = 1;
            for (int i = 0; i < 100; i++)
            {
                numSeq++;
                if((numSeq % 2) == 0)
                {
                    Console.WriteLine(numSeq);
                }
                else
                {
                    Console.WriteLine(numSeq * (-1));
                }
            }
            
        }
    }
}