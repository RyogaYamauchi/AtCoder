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
            var X = Ecr();
            var n = X[0];
            var k = X[1];
            var datas = Ecr();
            var result = new int[n];
            for (var i = 0; i < k; i++)
            {
                for (var j = 1; j < datas.Length + 1; j++)
                {
                    var a = j - datas[j-1] - 0.5;
                    var b = j + datas[j-1] + 0.5;
                    for (var q = 0; q < datas.Length; q++)
                    {
                        if (q> a && q < b)
                        {
                            result[q]++;
                        }
                    }
                }
                datas = result;
            }
            foreach (var a in result)
            {
                P("a ");
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
        public static int[] cr()
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
