using System;
using System.Collections.Generic;
using System.Globalization;
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

            String note = "The total of all three numbers is ";
            String message1 = "The average is ";
            String message2 = "The lowest number is ";
            String message3 = "The highest number is ";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine(note + ((float)a + (float)b + (float)c));
            Console.WriteLine(message1 + ((float)a + (float)b + (float)c) / (3));
            Console.WriteLine(message2 + ((float)a));
            Console.WriteLine(message3 + ((float)c));

            CultureInfo ci_US = new CultureInfo("en-US");
            System.Globalization.CultureInfo ci_SE = new CultureInfo("en-SE");
            System.Globalization.CultureInfo ci_JP = new CultureInfo("en-JP");
            System.Globalization.CultureInfo ci_TH = new CultureInfo("en-TH");
            CultureInfo ci;



            ci = ci_US;
            Console.WriteLine(string.Format(ci, "{0:C}, {1:C}, {2:C}", 10, 50, 100));

            ci = ci_SE;
            Console.WriteLine(string.Format(ci, "{0:C}, {1:C}, {2:C}", 10, 50, 100));

            ci = ci_JP;
            Console.WriteLine(string.Format(ci, "{0:C}, {1:C}, {2:C}", 10, 50, 100));

            ci = ci_TH;
            Console.WriteLine(string.Format(ci, "{0:C}, {1:C}, {2:C}", 10, 50, 100));



            Console.ReadLine();
        }




    }






}





