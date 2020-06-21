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
            bool[] a = new bool[datas.Count()];
            datas = datas.OrderByDescending(x => x).ToArray();
            for (var i = 0;i < n;i++)
			{
                
                for(var j = 0; j < n;j++)
				{
                    if (i==j)
					{
                        continue;
					}

                    if (datas[i] == datas[j])
                    {
                        a[i] = true;
                        break;
                    }


                    if (datas[i] % datas[j] == 0)
					{
                        a[i] = true;
                        break;
					}
				}
			}
           

            P(a.Count(x => !x));
            
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
