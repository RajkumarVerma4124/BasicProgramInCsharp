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
                            "\n2: Check Positive Or Negative"
                            
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
                    
                    default:
                        Environment.Exit(0);
                        return;
                }  
            }
        }
    }
}
