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
            var cnt = 0;
            var i = 0;
            var n = Er();
            var datas = Ecr();
			while (true)
			{
				if (datas[i] % 2 == 0)
				{
					datas[i] /= 2;
				}
				else
				{
					P(cnt);

					return;
				}
				i++;
				if (i >= datas.Count())
				{
					cnt++;
					i = 0;
				}
			}
			
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

        public static int[] Copy(int[] datas)
		{
            var result = new int[datas.Count()];
            Array.Copy(datas, result, datas.Count());
            return result;
		}
    }
}
