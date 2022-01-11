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

        //To check sum of natural numbers
        public static void SumOfNatNum(int num)
        {
            int sum = (num * (num + 1)) / 2;
            Console.WriteLine("The sum of natural number is : " + sum);
            Console.ReadLine();
        }
        //To check sum of natural number within a range
        public static void SumOfNatNum(int inum, int fNum)
        {
            int sum = 0;
            for (int i = inum; i <= fNum; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of numbers in the range from " + inum + " to " + fNum + " is " + sum);
            Console.ReadLine();
        }

        //Greatest of two numbers 
        public static void GOfTwoNum(int fNum, int sNum)
        {
            int result = fNum > sNum ? fNum : sNum;
            Console.WriteLine("The Number " + result + " is the greatest");
            Console.ReadLine();
        }

        //Greatest of three numbers
        public static void GOfThreeNum(int fNum, int sNum, int tNum)
        {
            int result = tNum > (fNum > sNum ? fNum : sNum) ? tNum : (fNum > sNum ? fNum : sNum);
            Console.WriteLine("The Number " + result + " is the greatest");
            Console.ReadLine();
        }
    }
}
