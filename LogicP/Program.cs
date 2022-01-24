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
                Console.WriteLine("Enter 1 for Gambler\n"+"Enter 2 to Generate Coupan Number\n");
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
