using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{ 
    /// <summary>
    ///   Methods Declaration For Basic programs
    /// </summary>
    internal class CheckPrograms
    {
        //To check even or odd number
        public static void EvenOrOdd(int num)
        {
            string EoOresult = num % 2 == 0 ? "The num "+num+" is Even Number" : "The num "+num+" is Odd Number";
            Console.WriteLine(EoOresult);
            Console.ReadLine();
        }

        //To check positive or negative number 
        public static void PosOrNeg(int num)
        {
            string PoNresult = num < 0 ? "The num " + num + " is Negative Number" : num == 0 ? " The number is zero" : " The num "+num+" is Positive Number";
            Console.WriteLine(PoNresult);
            Console.ReadLine();
        }

       


    }
}
