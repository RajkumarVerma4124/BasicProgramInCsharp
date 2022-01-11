using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{

    /// <summary>
    ///   Basic Programs
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Enter a choice from below : ");
                Console.Write("1: Check Even Or Odd"+
                            "\n2: Check Positive Or Negative"+
                            "\n3: Check Sum Of Natural Number"+
                            "\n4: Check Sum Of Number In a Given Range"+
                            "\n5: Greatest of two numbers" +
                            "\n6: Greatest of Three numbers"+
                            "\n7: Leap Year Or Not"+
                            "\n8: Check Prime Or Not" +
                            "\n9: Print Prime Numbers"
                             );
                Console.WriteLine();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a num to check even or odd : ");
                        int num = int.Parse(Console.ReadLine());
                        CheckPrograms.EvenOrOdd(num);
                        break;
                    case 2:
                        Console.Write("Enter a num to check positive or negative : ");
                        int chknum = int.Parse(Console.ReadLine());
                        CheckPrograms.PosOrNeg(chknum);
                        break;
                    case 3:
                        Console.Write("Enter a final range to calculate natural numbers : ");
                        int range = int.Parse(Console.ReadLine());
                        CheckPrograms.SumOfNatNum(range);
                        break;
                    case 4:
                        Console.Write("Enter the initial number for calculating sum of natural numbers : ");
                        int IRange = int.Parse(Console.ReadLine());
                        Console.Write("Enter the final number for calculating sum of natural numbers : ");
                        int FRange = int.Parse(Console.ReadLine());
                        CheckPrograms.SumOfNatNum(IRange, FRange);
                        break;
                    case 5:
                        Console.Write("Enter the first number : ");
                        int fNum = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number : ");
                        int sNum = int.Parse(Console.ReadLine());
                        CheckPrograms.GOfTwoNum(fNum, sNum);
                        break;
                    case 6:
                        Console.Write("Enter the first number : ");
                        int fNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter the second number : ");
                        int sNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter the third number : ");
                        int tNumber = int.Parse(Console.ReadLine());
                        CheckPrograms.GOfThreeNum(fNumber, sNumber, tNumber);
                        break;
                    case 7:
                        Console.Write("Enter a year to check if its a leap year : ");
                        int year = int.Parse(Console.ReadLine());
                        CheckPrograms.ChkLeapOrNot(year);
                        break;
                    case 8:
                        Console.Write("Enter a number to check prime : ");
                        int chkPriNum = int.Parse(Console.ReadLine());
                        CheckPrograms.ChkPrime(chkPriNum);
                        break;
                    case 9:
                        Console.Write("Enter Starting Number : ");
                        int startNum = int.Parse(Console.ReadLine());
                        Console.Write("Enter Ending Number : ");
                        int endNum = int.Parse(Console.ReadLine());
                        CheckPrograms.PrintPrimeNum(startNum, endNum);
                        break;
                    default:
                        Environment.Exit(0);
                        return;
                }  
            }
        }
    }
}
