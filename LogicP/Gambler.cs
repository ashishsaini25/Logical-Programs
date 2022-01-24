using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicP
{
    public class Gambler
    {
        public bool Game(double value)
        {
            if (value < 0.5)
                return false;
            else
                return true;
        }
        public void Status(double wins, double loss)
        {
            Console.WriteLine("The Gambler wins {0} out of {1} ", wins, wins + loss);
            double winpercentage = (wins / (wins + loss)) * 100;
            Console.WriteLine("The win % of Gambler is {0} %", winpercentage);
            Console.WriteLine("The Loss % of Gambler is {0} %", (100 - winpercentage));

        }
        public void Play()
        {
            double stack, goal, Rep;
            double win = 0, loss = 0;
            Console.WriteLine("Enter stack Price\n");
            stack = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Goal Price \n");
            goal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Number of times You want to play\n");
            Rep = Convert.ToDouble(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < Rep; i++)
            {
                if (Game(random.NextDouble()))
                {
                    win++;
                    stack++;
                }
                else
                {
                    loss++;
                    stack--;
                }
                if (stack <= 0)
                {
                    break;
                }
            }
            if (stack >= goal)
            {
                Console.WriteLine("The  Gambler reaches to the its Goal\n");
            }
            else
            {
                Console.WriteLine("The  Gambler Did not reach to the Goal\n");
            }
            Status(win, loss);

        }
    }
}
