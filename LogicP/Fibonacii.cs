using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicP
{
    public class Fibonacii
    {
       public void Print()
        {
            Console.WriteLine("Enter the no of terms\n");
            int n = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int second = 1;
            Console.Write(first+" " + second+" ");  
            for(int i=2; i < n; i++)
            {
                int temp = second;
                second = first + second;
                first = temp;
                Console.Write(second+" ");
            }
        }
    }
}
