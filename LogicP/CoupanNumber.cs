using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicP
{
    public class CoupanNumber
    {
        public void Generate()
        {
            Console.WriteLine("Enter the Number of Unique Coupans That You Want\n");
            int n = Convert.ToInt32(Console.ReadLine());
            HashSet<int> numbers = new HashSet<int>();
            bool flag = true;
            int ans = 0;
            Random random = new Random();
            while (flag)
            {
                int coupan=random.Next(1,1000);
        //        Console.WriteLine(coupan);
                if (!numbers.Contains(coupan))
                {
                    ans++;
                    numbers.Add(coupan);
                    
                }
                if (ans == n) break;
            }
            Console.Write("Total Random Number Needed to Generate {0} Unique coupans ", n);
            Console.WriteLine(ans);

        }
    }
}
