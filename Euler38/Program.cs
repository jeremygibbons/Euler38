using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler38
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPan = 0;

            foreach(int n in Enumerable.Range(1, 200000))
            {
                string s = n.ToString();
                foreach(int p in Enumerable.Range(2, 8))
                {
                    s += p * n;

                    if (s.Length < 9)
                        continue;

                    if (s.Length > 9)
                        break;

                    if (is9Pandigital(s))
                    {
                        int num = Convert.ToInt32(s, 10);
                        if (maxPan < num)
                            maxPan = num;
                        break;
                    }
                }
            }
            Console.WriteLine(maxPan);
            Console.ReadLine();
        }

        static bool is9Pandigital(string s)
        {
            char[] carr = s.ToCharArray();
            Array.Sort(carr);
            return "123456789" == new string(carr);
        }
    }
}
