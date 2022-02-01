using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicP
{
    public class Prime
    {
        public void Verify()
        {
            bool ans = true;
            Console.WriteLine("Enter the number\n");
            int n=Convert.ToInt32(Console.ReadLine());  
            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) ans = false; 
            }
            if (ans)
            {
                Console.WriteLine("It is a prime\n");
            }
            else
            {
                Console.WriteLine("It is not a prime\n");
            }
        }
    }
}
