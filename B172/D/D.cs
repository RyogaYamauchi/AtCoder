using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AtCoder.XXX.D
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Er());
            long result = 0;
            var cnt = 0;
            for(var i  =1;i < n+1;i++)
			{
                var a = PrimeFactors(i);
                foreach(var b in a)
				{
                    P(b);
				}
                for(var j = 0;j < a.Count(); j++)
				{
                    for(var k = 0; k < a.Count();k++)
					{
                        cnt++;
					}
				}
                result += i * cnt;

            }
            P(result.ToString());
		}

        public static IEnumerable<int> PrimeFactors(int n)
        {
            int i = 2;
            int tmp = n;

            while (i * i <= n) //※1
            {
                if (tmp % i == 0)
                {
                    tmp /= i;
                    yield return i;
                }
                else
                {
                    i++;
                }
            }
            if (tmp != 1) yield return tmp;//最後の素数も返す
            if (tmp == 1) yield return tmp;
        }

        private static StreamReader sr;
        public static int[] Ecr()
        {
            if (sr == null)
            {
                sr = new StreamReader("input.txt", Encoding.GetEncoding("UTF-8"));
            }
            return sr.ReadLine().Split().Select(int.Parse).ToArray();
        }
        public static  int[] cr()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        public static string Er()
        {
            if (sr == null)
            {
                sr = new StreamReader("input.txt", Encoding.GetEncoding("UTF-8"));
            }
            return sr.ReadLine();
        }
        public static string r()
        {
            return Console.ReadLine();
        }
        public static int cri()
        {
            return int.Parse(Console.ReadLine());
        }
        public static void P(string str)
        {
            Console.WriteLine(str);
        }
        public static void P(int num)
        {
            P(num.ToString());
        }
    }
}
