using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicP
{
    public class StopWatch
    {
        public  int [] FetchTime()
        {
            string Time = DateTime.Now.ToString();
            string[] tt = Time.Substring(11).Split(':');
            int [] time= new int[3];
            time[0] = Convert.ToInt32(tt[0]);
            time[1] = Convert.ToInt32(tt[1]);
            time[2] = Convert.ToInt32(tt[2]);
            return time;
        }
        public int [] TimeElapsed(int []starttime, int[] endtime)
        {
            int [] timeelapsed= new int[3];
            if (endtime[2] < starttime[2])
            {
                endtime[2] += 60;
                if (endtime[1] < 0)
                {
                    endtime[0]--;
                    endtime[1] += 60;
                }
                endtime[2]--;
            }
            if (endtime[1] < starttime[1])
            {
                if (endtime[0] < starttime[0]) endtime[0] += 24;
                endtime[0]--;
                endtime[1] += 60;
            }
            timeelapsed[0]= endtime[0]-starttime[0];
            timeelapsed[1]= endtime[1]-starttime[1];
            timeelapsed[2]=endtime[2]-starttime[2];
            return timeelapsed;

        }
        public void Watch()
        {
            Console.WriteLine("Click Enter  to Start  Stop Watch");
            Console.ReadLine();
            int [] starttime= FetchTime();
            Console.WriteLine("Click Enter  to End  Stop Watch");
            Console.ReadLine();
            int[] endtime = FetchTime();
           int [] timetaken= TimeElapsed(starttime, endtime);
            Console.WriteLine("The time taken is {0}:{1}:{2}", timetaken[0], timetaken[1], timetaken[2]);

        }
    }
}
