using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AtCoder.XXX.F
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            var qqqqq = Ecr();
            var n = qqqqq[0];
            var m = qqqqq[1];
            var k = qqqqq[2];
            var alist = Ecr().ToList();
            var blist = Ecr().ToList();

            var sampleA = new long[200000];
            var sampleB = new long[200000];
            for(var i = 0;i < 200000;i++)
			{
                sampleA[i] = 1;
                sampleB[i] = 2;
			}
            alist = sampleA.ToList();
            blist = sampleB.ToList();
            

            var cnt = 0;
            var acnt = 0;
            var bcnt = 0;
            while(k > 0)
			{
                long af = Int64.MaxValue;

                if (alist.Count() > acnt)
				{
                    af = alist[acnt];
                }
                long bf = Int64.MaxValue ;

                if (blist.Count() > bcnt)
				{
                    bf = blist[bcnt];
                }
                var min = af < bf ? af : bf;
                if(k < min)
				{
                    break;
				}

                if(af < bf)
				{
                    k -= af;
                    cnt++;
                    acnt++;
                    
				}
				else
				{
                    k -= bf;
                    cnt++;
                    bcnt++;
				}
            }
            P(cnt);
        }

        private static StreamReader sr;
        public static long[] Ecr()
        {
            if (sr == null)
            {
                sr = new StreamReader("input.txt", Encoding.GetEncoding("UTF-8"));
            }
            return sr.ReadLine().Split().Select(long.Parse).ToArray();
        }
        public static  long[] cr()
        {
            return Console.ReadLine().Split().Select(long.Parse).ToArray();
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
        public static void P(long num)
        {
            P(num.ToString());
        }
    }
}
