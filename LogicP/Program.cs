using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1 for Gambler\n" + "Enter 2 to Generate Coupan Number\n" + "Enter 3  for Stopwatch\n"
                    + "Enter 4 to play Tic-Tac-Toe\n"+"Enter 5 to fibonacci\n"+"Enter 6 for perfect number\n"+"Enter 7 for Prime\n");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Gambler gambler = new Gambler();
                        gambler.Play();
                        break;

                    case 2:
                        CoupanNumber coupanNumber = new CoupanNumber();
                        coupanNumber.Generate();
                        break;
                    case 3:
                        StopWatch stopWatch = new StopWatch();
                        stopWatch.Watch();
                        break;
                    case 4:
                        Tic_Tac tic_Tac = new Tic_Tac();
                        tic_Tac.Play();
                        break;
                    case 5:
                        Fibonacii fibonacii = new Fibonacii();
                        fibonacii.Print();
                        break;
                    case 6:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Find();
                        break;
                    case 7:
                        Prime prime = new Prime();
                        prime.Verify();
                        break;
                    case 8:
                        flag = false;
                        break;
                    


                    default:
                        Console.WriteLine("Please enter the correct option\n");
                        break;
                }
            }
        }
    }
}
