using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AtCoder.XXX.C
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            var datas = Er();
            var n = datas[0];
            var x = datas[1];
            var q = 0;
            var w = 0;
            var e = 0;
            while(x > 10000)
            {
                x -= 10000;
                q++;
            }
            while(x > 5000)
			{
                x -= 5000;
                q++;
			}
            while(x > 1000)
			{
                x -= 1000;
                e++;
			}
            if(x != 0)
			{
                P("-1 -1 -1");
                return;
			}

            P($"{q} {w} {e}");
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
        public static  int[] cr()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
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
