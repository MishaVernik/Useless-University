using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.FIFO.Application
{
    public static class GenerateSequenceOfProcessors
    {
       public static List<List<int>> Combine(int n, int k)
        {
            List<List<int>> res = new List<List<int>>();
            int i = 0;
            int[] p = new int[k + 1];
            // p.AddRange(Enumerable.Repeat(0, k));
            while (i >= 0)
            {
                p[i]++;
                if (p[i] > n) --i;
                else if (i == k - 1) res.Add(p.ToList<int>());
                else
                {
                    ++i;
                    p[i] = p[i - 1];
                }
            }

            return res;
        }

        public static List<List<int>> Combine(int n, int k, List<int> availableProcessors)
        {
            var list = new List<List<int>>();

            Backtrack(list, new List<int>(), n, k, 1, availableProcessors);

            return list;
        }

        private static void Backtrack(List<List<int>> list, List<int> temp, int n, int k, int start, List<int> availableProcessors)
        {
            if (temp.Count == k) list.Add(new List<int>(temp));

            for (var i = start; i <= n; i++)
            {
                temp.Add(availableProcessors[i - 1]);

                Backtrack(list, temp, n, k, i + 1, availableProcessors);

                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
