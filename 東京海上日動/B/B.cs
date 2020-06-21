using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AtCoder.XXX.B
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            var F = Ecr();
            long a = F[0];
            var aw = F[1];
            var S = Ecr();
            var b = S[0];
            var bw = S[1];
            var t = int.Parse(Er());
            if(a + (aw * t) >= b + (bw * t))
			{
                P("Yes");
                return;
			}
            P("No");
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
