using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicP
{
    public class Tic_Tac
    {
        public char [,] Turn(ref char [,]sheet,int index, char player )
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (index > 0) index--;
                    if (index == 0)
                    {
                        sheet[i, j] = player;
                        break;
                    }
                    

                }
                if (index == 0) break;
            }

            return sheet;
        }
        public void Intialize(ref char [,]sheet)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    sheet[i, j] = '.';
            }
        }
        public void Print(char [,] sheet)
        {
            for(int i=0; i < 3; i++)
            {
                for(int j =0;j< 3; j++)Console.Write(sheet[i, j]+" ");
                Console.WriteLine();
            }
        }
        public bool Check(char [,]sheet)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    char curr=sheet[i, j];
                    bool ans1 = true, ans2=true;
                    if (curr != '.')
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (sheet[i, k] != curr) ans1 = false;
                        }
                        for (int k = 0; k < 3; k++)
                        {
                            if (sheet[k, j] != curr) ans2 = false;
                        }
                        if (ans1|ans2) return true;
                        if (sheet[0, 0] == sheet[1, 1] && sheet[2, 2] == sheet[1, 1] && sheet[0, 0] != '.')
                            return true;
                        if (sheet[2, 2] == sheet[1, 1] && sheet[2,1] == sheet[1, 1] && sheet[2, 2] != '.')
                            return true;
                    }
                }
            }
            return false;
        }
        public void Play()
        {
            List<int> vs = new List<int>();
            for (int i=1;i<=9;i++)vs.Add(i);
            Random random = new Random();
            char[,] sheet = new char[3, 3];
            Intialize(ref sheet);
            bool comp = true;
            bool won = false;
            for (int k = 1; k <= 9; k++)
            {
                if (comp)
                {
                    int index = random.Next(1,vs.Count);
                    sheet = Turn( ref sheet, vs[index-1], 'X');
                    vs.Remove(vs[index - 1]);
                    comp = false;
                    if (Check(sheet))
                    {
                        Print(sheet);
                        Console.WriteLine("Computer wins the game\n");
                        won = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter the Row+Coloumn value\n");
                    int index =Convert.ToInt32(Console.ReadLine());
                    if (!vs.Contains(index))
                    {
                        Console.WriteLine("Please enter a proper move\n");
                        k--;
                        continue;
                    }
                    vs.Remove(index);
                    sheet = Turn(ref sheet, index, 'O');
                    comp = true;
                    if (Check(sheet))
                    {
                        Print(sheet);
                        Console.WriteLine("Player wins the game\n");
                        won = true;
                        break;
                    }
                }
                Print(sheet);
                Console.WriteLine("\n\n");
            }
            if (!won)
            {
                Console.WriteLine("The game results in a Tie\n");
            }

        }
    }
}
