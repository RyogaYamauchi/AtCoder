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
            var datas = new List<int>();
            var n = int.Parse(Er());
            var cnt = 0;
            for(var i = 0; i < n;i++)
			{
                var a = int.Parse(Er());
                datas.Add(a);
			}
            while(true)
			{
                if(datas.Count == 0)
				{
                    break;
				}
                var min = datas.Min();
                datas.RemoveAll(x => x==min);
                cnt++;
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
