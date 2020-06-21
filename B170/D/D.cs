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
            var n = int.Parse(Er());
            var datas = Ecr().ToList();
            var d = FindDuplication(datas);
            var cnt = 0;
            foreach (var a in d)
			{
                var c = datas.Count(x => x == a);
                cnt += c;
                datas.RemoveAll(x => x == a);
			}
            datas.OrderBy(x => x);
            cnt += datas.Where(x => datas.Where(y =>
            {
                return x != y && x % y == 0;
            })).Count();
            
            P(n-cnt);
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
