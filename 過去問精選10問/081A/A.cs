using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AtCoder.XXX.A
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            var datas = Er();
            var cnt = 0;
            foreach(var data in datas)
			{
                if(data == '1')
				{
                    cnt++;
				}
			}
            P(cnt);
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
            if(sr == null)
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
