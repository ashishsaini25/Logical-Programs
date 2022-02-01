using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicP
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter the Number\n");
            int n=Convert.ToInt32(Console.ReadLine());
            int number = 0;
            while (n > 0)
            {
                int k = n % 10;
                number = number * 10 + k;
                n /= 10;
            }
            Console.WriteLine("The Reverse Of a Given Number is "+number);
        }
    }
}
