using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace @try
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int input = Int32.Parse(Console.ReadLine());
            int lenght = Int32.Parse(Console.ReadLine());

            int psize = input + lenght;
            List<List<int>> pascalTriangle = generatePacal(psize);

            int n = pascalTriangle.Count();

            List<int> sequence = new List<int>();
            List<int> listoutput = new List<int>();
            int count = 0;
            int hockeys = 0;
            int flag = 1;
            for (int i = 0; i < n; i++)
            {
                int res = 0;
                count = 0;
                List<int> pattern = new List<int>();
                for (int line = i; line < n - 1; line++)
                {
                    pattern.Add(pascalTriangle[line][i]);
                    res = res + pascalTriangle[line][i];
                    if (res == pascalTriangle[line + 1][i + 1])
                    {
                        if (count >= 1)
                        {
                            if (i == input && pattern.Count() == (lenght-1))
                            {
                                foreach (var item in pattern)
                                {
                                    listoutput.Add(item);
                                    Console.Write(item);
                                    if (item != pattern[pattern.Count()-1])
                                    { Console.Write("+"); }
                                    
                                }
                                hockeys++;
                                hockeys++;
                            }

                        }
                        if (flag != 1)
                        { res = 0; }
                        flag = 1;
                    }
                    count++;
                }
               // Console.WriteLine();
            }
            //Console.WriteLine("hockeys present are " + hockeys);
        }
        static int findCombination(int n, int r)
        {
            return factorial(n) / (factorial(n - r) * factorial(r));
        }
        static int factorial(int f)
        {
            return f * factorial(f - 1);
        }
        static List<List<int>> generatePacal(int no_row)
        {
            int c = 1, i, j;
            List<List<int>> pascalTraingle = new List<List<int>>();
            for (i = 0; i < no_row; i++)
            {
                List<int> tempTraingle = new List<int>();
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        c = 1;
                    }
                    else
                    {
                        c = c * (i - j + 1) / j;
                    }

                    tempTraingle.Add(c);
                }
                pascalTraingle.Add(tempTraingle);
            }
            return pascalTraingle;
        }
    }
}

