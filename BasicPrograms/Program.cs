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
                            "\n9: Print Prime Numbers"+
                            "\n10: Sum Of Digits"+
                            "\n11: Reverse A Number Or String"+
                            "\n12: Check Palindrom Or Not"+
                            "\n13: Fibonacci series up to range"+
                            "\n14: Armstrong Number Between A Range"+
                            "\n15: Swaping Of Two And Three Numbers"+
                            "\n16: Factorial Of a Number"+
                            "\n17: Power Of a Number"+
                            "\n18: Factors Of a Given Number"+
                            "\n19: Check The Strong Number"+
                            "\n20: Check The Perfect Number"
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
                    case 10:
                        Console.Write("Enter a digit to add : ");
                        int digit = int.Parse(Console.ReadLine());
                        CheckPrograms.SumOfDigits(digit);
                        break;
                    case 11:
                        Console.Write("Enter a number or string to reverse : ");
                        string numR = Console.ReadLine();
                        CheckPrograms.ReverseNum(numR);
                        break;
                    case 12:
                        Console.Write("Enter a string : ");
                        string palStr = Console.ReadLine();
                        CheckPrograms.ChkPalindrome(palStr);
                        break;
                    case 13:
                        Console.Write("Enter a limit of the fibonacci series : ");
                        int finNum = int.Parse(Console.ReadLine());
                        CheckPrograms.FiboSeries(finNum);
                        break;
                    case 14:
                        Console.Write("Enter a Starting Number : ");
                        int aStart = int.Parse(Console.ReadLine());
                        Console.Write("Enter a Ending Number : ");
                        int aEnd = int.Parse(Console.ReadLine());
                        CheckPrograms.ArmstrongNumber(aStart, aEnd);
                        break;
                    case 15:
                        Console.WriteLine("Enter The Choice From Below :");
                        Console.WriteLine("1: Swap Two Numbers \n2: Swap Three Numbers");
                        int ch = int.Parse(Console.ReadLine());
                        switch (ch) 
                        {
                            case 1:
                                Console.Write("Enter The First Number :");
                                int SFNum = int.Parse(Console.ReadLine());
                                Console.Write("Enter The Second Number :");
                                int SSNum = int.Parse(Console.ReadLine());
                                CheckPrograms.SwapNumbers(SFNum, SSNum);
                                break;
                            case 2:
                                Console.Write("Enter The First Number :");
                                int SwFNum = int.Parse(Console.ReadLine());
                                Console.Write("Enter The Second Number :");
                                int SwSNum = int.Parse(Console.ReadLine());
                                Console.Write("Enter The Second Number :");
                                int SwTNum = int.Parse(Console.ReadLine());
                                CheckPrograms.SwapNumbers(SwFNum, SwSNum, SwTNum);
                                break;
                        }

                        break;
                    case 16:
                        Console.Write("Enter the number to get the factorial : ");
                        int factNum = int.Parse(Console.ReadLine());
                        CheckPrograms.Factorial(factNum);
                        break;
                    case 17:
                        Console.Write("Enter a number to get the power of : ");
                        int numPow = int.Parse(Console.ReadLine());
                        CheckPrograms.PowerOfNum(numPow);
                        break;
                    case 18:
                        Console.Write("Enter a number to get the factors of : ");
                        int numFact = int.Parse(Console.ReadLine());
                        CheckPrograms.FactorsOfNum(numFact);
                        break;
                    case 19:
                        Console.Write("Enter a number to check if its strong number : ");
                        int strngNum = int.Parse(Console.ReadLine());
                        CheckPrograms.ChkStrngNum(strngNum);
                        break;
                    case 20:
                        Console.Write("Enter a number to check if its perfect number : ");
                        int perfNum = int.Parse(Console.ReadLine());
                        CheckPrograms.ChkPerfectNum(perfNum);
                        break;
                    default:
                        Environment.Exit(0);
                        return;
                }  
            }
        }
    }
}
