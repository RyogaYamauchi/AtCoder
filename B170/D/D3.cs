using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AtCoder.D
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = Ecr()[0];
            var datas = Ecr();
            bool[] a = new bool[1000001];
            int[] b = new int[1000001];

            datas = datas.OrderBy(x => x).ToArray();
            var cnt = 0;
            foreach(var data in datas)
			{
                b[data]++;
			}
            foreach (var data in datas)
            {
                if (a[data])
                {
                    continue;
				}
				if (b[data]>1)
				{
					continue;
				}
                cnt++;
                for (var i = data; i < a.Length; i += data)
                {
                    a[i] = true;
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
        public static List<int> FindDuplication(List<int> list)
        {
            var duplicates = list.GroupBy(name => name).Where(name => name.Count() > 1)
                .Select(group => group.Key).ToList();

            return duplicates;
        }
    }
}
