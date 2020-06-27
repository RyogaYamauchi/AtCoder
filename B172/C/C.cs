using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AtCoder.C
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            var qqqqq = Ecr();
            var n = qqqqq[0];
            var m = qqqqq[1];
            var k = qqqqq[2];
            var alist = Ecr().ToList();
			var blist = Ecr().ToList();
			alist.AddRange(blist);
			alist = alist.OrderBy(x => x).ToList();

			var cnt = 0;
			foreach (var a in alist)
			{
				k -= a;
				cnt++;
				if (k < 0)
				{
					break;
				}
			}
			P(cnt);

		}

        private static StreamReader sr;
        public static long[] Ecr()
        {
            if (sr == null)
            {
                sr = new StreamReader("input.txt", Encoding.GetEncoding("UTF-8"));
            }
            return sr.ReadLine().Split().Select(long.Parse).ToArray();
        }
        public static  long[] cr()
        {
            return Console.ReadLine().Split().Select(long.Parse).ToArray();
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
