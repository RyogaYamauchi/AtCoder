using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder.XXX.D
{
    class Main
    {
        
        

    }




    class Program
    {
        //static void Main(string[] args)
        //{
        //    var a = new Main();
        //    a.Run();
        //}

        public static  void Main(string[] args)
        {
            P("Hello World  D!!");
            var datas = new int[] { 1, 2, 3 };
            var comb = datas.Comb(2);
            var result = comb.Select(x => x.ToArray()).ToArray();
            foreach (var a in result)
            {
                PL(a);

            }
        }

        public static int[] cr()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        public static int cri()
        {
            return int.Parse(Console.ReadLine());
        }

        public static void PL(string str)
        {
            Console.WriteLine(str);
        }
        public static void P(string str)
        {
            Console.Write(str);
        }


        public static IEnumerable<List<T>> CombinationWithRepetition<T>(this IList<T> self, int n)
        {
            return Enumerable.Range(0, n - 1)
                .Aggregate(
                    Enumerable.Range(0, self.Count)
                        .Select(num => new List<int> { num }),
                    (list, _) => list.SelectMany(
                        c =>
                            Enumerable.Range(c.Max(), self.Count - c.Max())
                                .Select(num => new List<int>(c) { num })
                    )
                )
                .Select(
                    c => c
                        .Select(num => self[num])
                        .ToList()
                );
        }
    }
}
