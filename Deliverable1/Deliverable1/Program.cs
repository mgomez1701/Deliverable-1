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
        static void Main(string[] args)
        {
            int number;
            int number2;
            int number3;


            Console.WriteLine("Please pick 3 numbers");

            number = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("{0}, {1}, {2}", number, number2, number3);
            Console.ReadLine();

            String note = "The total of all three numbers is ";
            String message1 = "The average is ";
            String message2 = "The lowest number is ";
            String message3 = "The highest number is ";

            Console.WriteLine(note + ((float)number + (float)number2 + (float)number3));
            Console.WriteLine(message1 + ((float)number + (float)number2 + (float)number3) / (3));
            Console.WriteLine(message3);
            Console.WriteLine(Math.Max(Math.Max(number, number2), number3));
            Console.WriteLine(message2);

            Console.WriteLine(Math.Min(Math.Min(number, number2), number3));
            Console.ReadLine();


            Console.WriteLine("Here are what your numbers look like in 3 different currencies");

            CultureInfo ci_US = new CultureInfo("en-US");
            System.Globalization.CultureInfo ci_SE = new CultureInfo("en-SE");
            System.Globalization.CultureInfo ci_JP = new CultureInfo("en-JP");
            System.Globalization.CultureInfo ci_TH = new CultureInfo("en-TH");
            CultureInfo ci;

            ci = ci_US;
            Console.WriteLine(string.Format(ci, "{0:C}, {1:C}, {2:C}", number, number2, number3));

            ci = ci_SE;
            Console.WriteLine(string.Format(ci, "{0:C}, {1:C}, {2:C}", number, number2, number3));

            ci = ci_JP;

            Console.WriteLine(string.Format(ci, "{0:C}, {1:C}, {2:C}", (decimal)number, (decimal)number2, (decimal)number3));

            ci = ci_TH;

            Console.WriteLine(string.Format(ci, "{0:C}, {1:C}, {2:C}", number, number2, number3));



            Console.ReadLine();
        }





    }
}


