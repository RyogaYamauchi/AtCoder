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
            var datas = Ecr();
            var a = datas[0];
            var b = datas[1];
            var r = a * b;
            P(r % 2 == 0 ? "Even" : "Odd");
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
