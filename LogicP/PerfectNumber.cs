using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicP
{
    public class PerfectNumber
    {
        public void Find()
        {
            Console.WriteLine("enter the number\n");
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for(int i = 2; i*i<=n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if(i!=n/i)
                    sum += n / i;
                }
                Console.WriteLine(sum+" ");
            }
            if (sum == n)
            {
                Console.WriteLine("It is a perfect number\n");
            }
            else
            {


                Console.WriteLine("It is not a perfect number\n");
            }
        }
    }
}
