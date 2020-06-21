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
            var datas = Ecr(); // 1 2
            if(datas[0] == datas[1])
			{
                P("No");
                return;
			}
            for(var i = 0;i < datas[0]+1;i++)
			{
                for(var j = 0;j < datas[0]+1;j++)
				{
                    if((i*4) + (j* 2) == datas[1])
					{
                        if(i + j == datas[0])
						{
                            P("Yes");
                            return;

                        }
                    }
				}
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
