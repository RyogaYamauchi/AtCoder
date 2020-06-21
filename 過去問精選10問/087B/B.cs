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

            var a = int.Parse(Er());
            var b = int.Parse(Er());
            var c = int.Parse(Er());
            var x = int.Parse(Er());
            var cnt = 0;
            for(var i = 0; i < a+1;i++)
			{
                for(var j = 0; j < b+1;j++)
				{
                    for( var k = 0; k < c+1;k++)
					{
                        if (i * 500 + j * 100 + k * 50 == x)
                        {
                            cnt++;
			            }
					}
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
