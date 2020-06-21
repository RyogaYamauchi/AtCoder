using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AtCoder.C
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = long.Parse(Er());
            var sb = new StringBuilder();

			while (true)
			{
				var a = n / 26;
				var b = n % 26;
				P("a" + a);
				P("b" + b);
				P("n" + n);
				if (n < 27)
				{
                    P(n + "を追加");
					sb.Append(parse(n));
					break;
				}
                n = a;
                sb.Append(parse(a));

			}
            P(string.Concat(sb.ToString().Reverse()));

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
        public static string parse(long i)
		{
            switch(i)
			{
              
                case 1:
                    return "a";
                    break;
                case 2:
                    return "b";

                    break;
                case 3:
                    return "c";

                    break;
                case 4:
                    return "d";

                    break;
                case 5:
                    return "e";

                    break;
                case 6:
                    return "f";

                    break;
                case 7:
                    return "g";

                    break;
                case 8:
                    return "h";

                    break;
                case 9:
                    return "i";

                    break;
                case 10:
                    return "j";

                    break;
                case 11:
                    return "k";

                    break;
                case 12:
                    return "l";

                    break;
                case 13:
                    return "m";

                    break;
                case 14:
                    return "n";
                    break;
                case 15:
                    return "o";
                    break;
                case 16:
                    return "p";
                    break;
                case 17:
                    return "q";
                    break;
                case 18:
                    return "r";
                    break;
                case 19:
                    return "s";
                    break;
                case 20:
                    return "t";
                    break;
                case 21:
                    return "u";
                    break;
                case 22:
                    return "v";
                    break;
                case 23:
                    return "w";
                    break;
                case 24:
                    return "x";
                    break;
                case 25:
                    return "y";
                    break;
                case 26:
                    return "z";
                    break;
            }
            return "";
		}
    }
}
