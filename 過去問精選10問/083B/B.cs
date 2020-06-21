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
            var datas = Ecr();
            var n = datas[0];
            var a = datas[1];
            var b = datas[2];
            var result = 0;
            for(var i = 0;i< n+1;i++)
			{
                var sum = 0;
                foreach(var s in i.ToString())
				{
                    sum += int.Parse(s.ToString());

                }

                if (sum >= a && sum <= b)
				{
                    result += i;
				}
			}
            P(result);
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
