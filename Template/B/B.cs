using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AtCoder.XXX.B
{ 
    class Main
    {
        public void Run()
        {

        }


        StreamReader sr;
        public int[] Ecr()
		{
            if(sr == null)
			{
                sr = new StreamReader("input.txt", Encoding.GetEncoding("UTF-8"));
            }
            return sr.ReadLine().Split().Select(int.Parse).ToArray();
        }
        public int[] cr()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        public int cri()
        {
            return int.Parse(Console.ReadLine());
        }
        public void P(string str)
        {
            Console.WriteLine(str);
        }
        public void P(int num)
		{
            P(num.ToString());
		}

    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Main();
            a.Run();
        }
    }
}
