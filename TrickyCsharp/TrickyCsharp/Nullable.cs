using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyCsharp
{
    public class NullableTypes
    {
        static void TestCasts(string[] args)
        {
            int i = 5;
            /*What’s happening is that the compiler sees the int expression on
             the left side of the ==, sees null on the right side, and knows that there’s an implicit
             conversion to int? from each of them. Because a comparison between two int? values
             is perfectly valid, the code doesn’t generate an error*/
            if (null == i)
            {
                Console.WriteLine("Never going to happen");
            }

            object obj5 = (object)i;
            int? nullable = obj5 as int?; //we can cast objects to int?
            int j = (int)obj5;
            if (j == nullable)
            {
                Console.WriteLine("It is for sure here!");
            }
        }
    }
}
