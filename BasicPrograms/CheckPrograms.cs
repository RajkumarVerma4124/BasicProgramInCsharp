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
                sum += i;
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

        //Checking the given year is leap year or not 
        public static void ChkLeapOrNot(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine(year + " is a leap year.");

            else
                Console.WriteLine(year + " is not a leap year.");
            Console.ReadLine();
        }

        //Check Prime Number
        public static void ChkPrime(int pNum)
        {
            int count = 0;
            if (pNum == 1)
            {
                Console.WriteLine("Not a prime number");
            }
            else if (pNum == 2)
            {
                Console.WriteLine("It is a prime number");

            }
            else 
            {
                for (int i = 2; i <= pNum; i++)
                {
                    if (pNum % i == 0)
                        count++;
                }
                if (count == 1)
                    Console.WriteLine("Prime Number");
                else
                    Console.WriteLine("Not a Prime Number");
            }

            Console.ReadLine();
        }

        //Print Prime Numbers
        public static void PrintPrimeNum(int startNum, int endNum)
        {
            Console.WriteLine("Prime numbers between " + startNum + " and " + endNum + " are : ");
            int count;
            //loop for finding and printing all prime numbers between given range
            for (int i = startNum; i <= endNum; i++)
            {
                //logic for checking number is prime or not
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 2)
                    Console.Write(i + " : ");
            }
            Console.ReadLine();
        }

        //Printing Sum of digits of a number
        public static void SumOfDigits(int digit)
        {
            int sum = 0;
            while (digit != 0)
            {
                int lastNum = digit % 10;
                sum += lastNum;
                digit /= 10;
            }
            Console.WriteLine("Sum of Digits = " + sum);
            Console.ReadLine();
        }
        //Printing Reverse of a number and string
        public static void ReverseNum(string numR)
        {
            // Converting string to character array
            char[] charNum = numR.ToCharArray();
            // Declaring an empty string
            string tempStr = string.Empty;
            for (int i = charNum.Length - 1; i > -1; i--)
            {
                // Append each character to the temp string.
                tempStr += charNum[i];
            }
            Console.WriteLine(tempStr);
            Console.ReadLine();
        }

        //Checking a given number is palindrome or not
        public static void ChkPalindrome(string palStr)
        {
            // Converting string to character array
            char[] charStr = palStr.ToCharArray();
            // Declaring an empty string
            string tempStr = string.Empty;
            for (int i = 0; i < charStr.Length; i++)
            {
                // Append each character to the temp string.
                tempStr += charStr[i];
            }
            if (tempStr.Equals(palStr))
                Console.WriteLine("It is palindrom");
            else
                Console.WriteLine("Not a pam=lindrome");
            Console.ReadLine();
        }
        //Displaying Fibonacci Series upto nth term
        public static void FiboSeries(int limit)
        {
            if (limit > 0)
            {
                int fNum = 0, sNum = 1, tNum;
                //display starting two numbers of series
                Console.Write("Fibonacci Series : " + fNum + "  " + sNum + "  ");
                while (sNum <= limit)
                {
                    tNum = fNum + sNum;
                    fNum = sNum;
                    sNum = tNum;
                    if (sNum <= limit)
                        Console.Write(tNum + " ");
                }

            }
            else
                Console.WriteLine("Wrong input");
            Console.ReadLine();
        }

        //Printing ArmStrong Number
        public static void ArmstrongNumber(int aStart, int aEnd)
        {
            Console.Write("Armstrong numbers between : " + aStart + " and " + aEnd + " are : ");
            int tempNum, sum;
            for (int i = aStart; i <= aEnd; i++)
            {
                tempNum = i;
                sum = 0;
                while (tempNum != 0)
                {
                    int pLast = tempNum % 10;
                    sum += Convert.ToInt32(Math.Pow(pLast, 3));
                    tempNum /= 10;
                }
                if (sum == i)
                    Console.Write(i + " ");
            }
            Console.ReadLine();
        }

        //Swapping of number
        public static void SwapNumbers(int i, int j)
        {
            // SUppose number are i = 5 and i = 6
            i *= j;  // i = (5 * 6) i.e 30
            j = i / j;  // j = 30/6 i.e = 5
            i /= j;  // i = 30/5 i.e = 6

            Console.WriteLine("After Swaping : "+i+" "+j);
            Console.ReadLine();
        }
        public static void SwapNumbers(int i, int j, int k)
        {
            //i = 10, j = 20, k = 30;
            i = i + j + k; // (i = 60)
            j = i - (j + k); // (j = 60 – (20+30) =10)
            k = i - (j + k); // (k = 60 – (10 + 30) = 20)
            i -= (j + k); // (i = = 60 – (10 + 20) = 30)
            Console.WriteLine("After Swaping : " + i + " " + j+" "+k);
            Console.ReadLine();

        }

        //Factorial of a number
        public static void Factorial(int factNum)
        {
            int factorial = 1, i = 1;
            while (i <= factNum)
            {
                factorial *= i;
                i++;
            }
            Console.WriteLine("The Factorial Of "+factNum+" is "+factorial);
            Console.ReadLine();
        }

        //Method to get power of a number
        public static void PowerOfNum(int powNum)
        {
            int ResOfPow = Convert.ToInt32(Math.Pow(powNum,2));
            Console.WriteLine("The Power Of "+powNum+" is : "+ResOfPow);

        }
    }
}
