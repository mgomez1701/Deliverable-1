using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = 50;
            var c = 100;

            String message1 = "The average is ";
            String message2 = "The Lowest is ";
            String message3 = "The highest number is ";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(message1 + ((float)a + (float)b + (float)c) / (3));
            Console.WriteLine(message2 + ((float)a));
            Console.WriteLine(message3 + ((float)c));
            Console.ReadLine();
        }

    


    }






}

 
